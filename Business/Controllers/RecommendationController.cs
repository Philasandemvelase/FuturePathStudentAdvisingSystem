using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case: Determine eligibility and recommend programmes.
    ///
    /// SCORES (each 0 - 100)
    ///   Subject match   = % of the programme's required subjects the learner has
    ///                     (or the accepted alternative, e.g. Mathematical Literacy)
    ///   Mark match      = % of required subjects where the mark is at least the minimum
    ///   Interest match  = questionnaire answers for the programme's interest categories
    ///   Faculty pref.   = 100 if the programme is in the faculty the learner chose, else 0
    ///   Overall         = 0.4 x subject + 0.3 x mark + 0.2 x interest + 0.1 x faculty
    ///
    /// OUTCOME (the first rule that applies)
    ///   1. a required subject is missing      -> Not Currently Eligible
    ///   2. a required mark is not supplied    -> More Information Needed
    ///   3. a mark is below the minimum        -> Possible Match
    ///   4. interest match is below 70%        -> Possible Match
    ///   5. otherwise                          -> Strong Match
    /// </summary>
    public class RecommendationController
    {
        public const decimal SubjectWeight = 0.4m;
        public const decimal MarkWeight = 0.3m;
        public const decimal InterestWeight = 0.2m;
        public const decimal FacultyWeight = 0.1m;
        public const decimal StrongInterest = 70m;     // interest match needed for a Strong Match
        public const decimal ModerateInterest = 50m;   // below this the interest match is "Weak"

        // Data loaded from the database once, the first time it is needed.
        private List<ProgrammeRequirement> requirements;
        private List<DegreeInterestMap> interestMaps;
        private List<InterestQuestion> questions;
        private List<DegreeProgramme> programmes;
        private Dictionary<int, string> subjectNames;
        private Dictionary<int, string> facultyNames;
        private Dictionary<int, string> categoryNames;

        private void LoadData()
        {
            if (requirements != null)
            {
                return;   // already loaded
            }
            LookupController lookup = new LookupController();
            requirements = new ProgrammeRequirementDAL().GetAll();
            interestMaps = new DegreeInterestMapDAL().GetAll();
            questions = new InterestQuestionDAL().GetAll();
            programmes = new DegreeProgrammeDAL().GetAll();
            subjectNames = lookup.SubjectNames();
            facultyNames = lookup.FacultyNames();
            categoryNames = lookup.CategoryNames();
        }

        // =====================================================================
        // Main rule: check a learner against one programme
        // =====================================================================

        /// <summary>
        /// Checks the learner's subjects, marks and answers against one programme.
        /// preferredFacultyID is the faculty the learner chose (0 = none).
        /// </summary>
        public EligibilityResult Evaluate(List<LearnerSubject> subjects, Dictionary<int, int> answers,
                                          int degreeID, int preferredFacultyID)
        {
            LoadData();
            DegreeProgramme degree = FindProgramme(degreeID);
            if (degree == null)
            {
                throw new BusinessRuleException("The selected programme no longer exists.");
            }

            // ---- Step 1: check every required subject of this programme ----
            List<string> missing = new List<string>();   // required subject not taken
            List<string> notSupplied = new List<string>();   // subject taken, mark unknown
            List<string> belowMinimum = new List<string>();   // mark too low
            int rulesCount = 0;
            int subjectsPresent = 0;
            int marksPassed = 0;

            foreach (ProgrammeRequirement rule in requirements)
            {
                if (rule.DegreeID != degreeID || rule.IsRequired == false)
                {
                    continue;
                }
                rulesCount++;

                // Look for the subject, or else its accepted alternative.
                LearnerSubject taken = FindSubject(subjects, rule.SubjectID);
                if (taken == null && rule.AcceptedAlternativeSubjectID.HasValue)
                {
                    taken = FindSubject(subjects, rule.AcceptedAlternativeSubjectID.Value);
                }

                if (taken == null)
                {
                    string text = SubjectName(rule.SubjectID);
                    if (rule.AcceptedAlternativeSubjectID.HasValue)
                    {
                        text = text + " (or " + SubjectName(rule.AcceptedAlternativeSubjectID.Value) + ")";
                    }
                    missing.Add(text);
                }
                else if (taken.Mark.HasValue == false)
                {
                    subjectsPresent++;
                    notSupplied.Add(SubjectName(taken.SubjectID));
                }
                else if (taken.Mark.Value < rule.MinimumMark)
                {
                    subjectsPresent++;
                    belowMinimum.Add(SubjectName(taken.SubjectID) + " mark " + taken.Mark.Value.ToString("0.##")
                                     + "% is below the minimum of " + rule.MinimumMark.ToString("0.##") + "%");
                }
                else
                {
                    subjectsPresent++;
                    marksPassed++;
                }

                // Optional rule: a minimum average over all the learner's marks.
                if (rule.MinimumOverallAverage.HasValue)
                {
                    decimal average = AverageMark(subjects);
                    if (average > 0 && average < rule.MinimumOverallAverage.Value)
                    {
                        belowMinimum.Add("Average mark " + average.ToString("0.#") + "% is below the required "
                                         + rule.MinimumOverallAverage.Value.ToString("0.#") + "%");
                    }
                }
            }
            if (rulesCount == 0)
            {
                rulesCount = 1;   // avoid dividing by zero when a programme has no rules
            }

            // ---- Step 2: calculate the scores ----
            RecommendationResult result = new RecommendationResult();
            result.DegreeID = degreeID;
            result.SubjectMatchScore = Math.Round(100m * subjectsPresent / rulesCount, 2);
            if (notSupplied.Count > 0)
            {
                result.MarkMatchScore = null;   // cannot be calculated without the mark
            }
            else
            {
                result.MarkMatchScore = Math.Round(100m * marksPassed / rulesCount, 2);
            }
            result.InterestMatchScore = InterestScore(answers, degreeID);
            if (preferredFacultyID == degree.FacultyID)
            {
                result.FacultyPreference = 100m;
            }
            else
            {
                result.FacultyPreference = 0m;
            }

            if (result.MarkMatchScore.HasValue)
            {
                decimal interest = 0m;
                if (result.InterestMatchScore.HasValue)
                {
                    interest = result.InterestMatchScore.Value;
                }
                result.OverallScore = Math.Round(SubjectWeight * result.SubjectMatchScore.Value
                                               + MarkWeight * result.MarkMatchScore.Value
                                               + InterestWeight * interest
                                               + FacultyWeight * result.FacultyPreference.Value, 2);
            }

            // ---- Step 3: decide the outcome (first rule that applies) ----
            EligibilityResult outcome = new EligibilityResult();
            outcome.Degree = degree;
            outcome.FacultyName = LookupController.NameOf(facultyNames, degree.FacultyID);
            outcome.Result = result;
            string interestLevel = InterestLevel(result.InterestMatchScore);

            if (missing.Count > 0)
            {
                result.AdvisoryOutcome = AdvisoryOutcomes.NotCurrentlyEligible;
                if (missing.Count == 1)
                {
                    result.GapDescription = "Required subject missing: " + missing[0];
                    outcome.Detail = missing[0] + " is required but not in the learner's captured subject list.";
                }
                else
                {
                    result.GapDescription = "Required subjects missing: " + string.Join(" and ", missing);
                    outcome.Detail = string.Join(" and ", missing) + " are required but not in the learner's captured subject list.";
                }
                outcome.Headline = "Required subjects missing";
            }
            else if (notSupplied.Count > 0)
            {
                result.AdvisoryOutcome = AdvisoryOutcomes.MoreInformationNeeded;
                result.GapDescription = string.Join(", ", notSupplied) + " mark not supplied; assessment cannot be completed";
                outcome.Headline = "Complete missing information";
                outcome.Detail = "The " + string.Join(", ", notSupplied) + " mark has not been supplied. "
                               + "The system cannot complete the assessment. Action: return to Subjects & Marks.";
            }
            else if (belowMinimum.Count > 0)
            {
                result.AdvisoryOutcome = AdvisoryOutcomes.PossibleMatch;
                result.GapDescription = string.Join("; ", belowMinimum);
                outcome.Headline = "Mark improvement needed";
                outcome.Detail = result.GapDescription + ".";
            }
            else if (interestLevel != "Strong")
            {
                result.AdvisoryOutcome = AdvisoryOutcomes.PossibleMatch;
                outcome.Headline = "Interests may suit another field";
                if (result.InterestMatchScore.HasValue == false)
                {
                    result.GapDescription = "Interest alignment: questionnaire not completed";
                    outcome.Detail = "You meet the academic requirements. Answer the questionnaire to confirm the programme suits your interests.";
                }
                else
                {
                    string percent = result.InterestMatchScore.Value.ToString("0") + "%";
                    result.GapDescription = "Interest alignment " + interestLevel.ToLower() + " (" + percent + ")";
                    outcome.Detail = "You meet the academic requirements, but your interest match is " + interestLevel.ToLower() + ".";

                    string betterFaculty = BestInterestFaculty(answers, degree.FacultyID);
                    if (betterFaculty != null)
                    {
                        result.GapDescription = result.GapDescription + "; interests align more closely with " + betterFaculty;
                        outcome.Detail = outcome.Detail + " Your answers align more closely with " + betterFaculty + ".";
                    }
                }
            }
            else
            {
                result.AdvisoryOutcome = AdvisoryOutcomes.StrongMatch;
                result.GapDescription = "None identified";
                outcome.Headline = "Strong Match ✔";
                outcome.Detail = "You appear to meet the stored academic requirements and have strong interest alignment.";
            }

            // ---- Step 4: the "Why this outcome?" lines ----
            AddReasons(outcome, degreeID, missing, notSupplied, belowMinimum, interestLevel);
            return outcome;
        }

        private void AddReasons(EligibilityResult outcome, int degreeID, List<string> missing,
                                List<string> notSupplied, List<string> belowMinimum, string interestLevel)
        {
            RecommendationResult result = outcome.Result;

            // 1. Required subjects
            ReasonLine subjectsLine = new ReasonLine();
            subjectsLine.Check = "Required subjects";
            if (missing.Count == 0)
            {
                subjectsLine.Result = "Met";
                subjectsLine.Explanation = "All required subjects captured";
            }
            else
            {
                subjectsLine.Result = "Missing";
                subjectsLine.Explanation = "Missing: " + string.Join(", ", missing);
            }
            outcome.Reasons.Add(subjectsLine);

            // 2. Required marks
            ReasonLine marksLine = new ReasonLine();
            marksLine.Check = "Required marks";
            if (notSupplied.Count > 0)
            {
                marksLine.Result = "Not supplied";
                marksLine.Explanation = "Mark not supplied: " + string.Join(", ", notSupplied);
            }
            else if (belowMinimum.Count > 0)
            {
                marksLine.Result = "Not met";
                marksLine.Explanation = string.Join("; ", belowMinimum);
            }
            else if (missing.Count > 0)
            {
                marksLine.Result = "Not met";
                marksLine.Explanation = "A required subject is missing";
            }
            else
            {
                marksLine.Result = "Met";
                marksLine.Explanation = "Marks meet the stored thresholds";
            }
            outcome.Reasons.Add(marksLine);

            // 3. Interest alignment
            ReasonLine interestLine = new ReasonLine();
            interestLine.Check = "Interest alignment";
            interestLine.Result = interestLevel;
            if (result.InterestMatchScore.HasValue)
            {
                interestLine.Explanation = "Questionnaire match " + result.InterestMatchScore.Value.ToString("0") + "% for this programme's interest categories";
            }
            else
            {
                interestLine.Explanation = "Questionnaire not completed";
            }
            outcome.Reasons.Add(interestLine);

            // 4. Academic gaps
            ReasonLine gapsLine = new ReasonLine();
            gapsLine.Check = "Academic gaps";
            if (result.AdvisoryOutcome == AdvisoryOutcomes.StrongMatch)
            {
                gapsLine.Result = "None identified";
            }
            else
            {
                gapsLine.Result = "See explanation";
            }
            gapsLine.Explanation = result.GapDescription;
            outcome.Reasons.Add(gapsLine);
        }

        // =====================================================================
        // Alternatives
        // =====================================================================

        /// <summary>
        /// Other active programmes the learner qualifies for (Strong or Possible Match).
        /// Strong matches come first; within each group, the best interest match comes first.
        /// </summary>
        public List<EligibilityResult> FindAlternatives(List<LearnerSubject> subjects, Dictionary<int, int> answers,
                                                         int excludeDegreeID, int preferredFacultyID, int max)
        {
            LoadData();
            List<EligibilityResult> found = new List<EligibilityResult>();
            foreach (DegreeProgramme programme in programmes)
            {
                if (programme.IsActive == false || programme.DegreeID == excludeDegreeID)
                {
                    continue;
                }
                EligibilityResult check = Evaluate(subjects, answers, programme.DegreeID, preferredFacultyID);
                if (check.Outcome == AdvisoryOutcomes.StrongMatch || check.Outcome == AdvisoryOutcomes.PossibleMatch)
                {
                    found.Add(check);
                }
            }

            found.Sort(CompareAlternatives);

            // Keep only the first "max" results.
            List<EligibilityResult> best = new List<EligibilityResult>();
            for (int i = 0; i < found.Count && i < max; i++)
            {
                best.Add(found[i]);
            }
            return best;
        }

        /// <summary>Sort order for alternatives: Strong Match first, then highest interest, then highest overall.</summary>
        private static int CompareAlternatives(EligibilityResult a, EligibilityResult b)
        {
            int rankA = 1;
            if (a.Outcome == AdvisoryOutcomes.StrongMatch) rankA = 0;
            int rankB = 1;
            if (b.Outcome == AdvisoryOutcomes.StrongMatch) rankB = 0;
            if (rankA != rankB)
            {
                return rankA.CompareTo(rankB);
            }

            decimal interestA = ValueOrZero(a.Result.InterestMatchScore);
            decimal interestB = ValueOrZero(b.Result.InterestMatchScore);
            if (interestA != interestB)
            {
                return interestB.CompareTo(interestA);   // higher first
            }
            return ValueOrZero(b.Result.OverallScore).CompareTo(ValueOrZero(a.Result.OverallScore));
        }

        // =====================================================================
        // Interest calculations
        // =====================================================================

        /// <summary>
        /// Interest match (0 - 100) for one programme. For each interest category mapped to the
        /// programme: average the learner's answers (1 - 5), turn that into 0 - 100, and weight it by
        /// DegreeInterestMap.weightedScore. Returns null if none of the relevant questions were answered.
        /// </summary>
        public decimal? InterestScore(Dictionary<int, int> answers, int degreeID)
        {
            LoadData();
            if (answers == null || answers.Count == 0)
            {
                return null;
            }

            decimal weightedTotal = 0m;
            decimal totalWeight = 0m;
            foreach (DegreeInterestMap map in interestMaps)
            {
                if (map.DegreeID != degreeID)
                {
                    continue;
                }

                // Average answer for the questions in this category.
                int sum = 0;
                int count = 0;
                foreach (InterestQuestion question in questions)
                {
                    if (question.CategoryID == map.CategoryID && answers.ContainsKey(question.QuestionID))
                    {
                        sum = sum + answers[question.QuestionID];
                        count++;
                    }
                }
                if (count == 0)
                {
                    continue;
                }

                decimal average = (decimal)sum / count;           // 1 .. 5
                decimal asPercent = (average - 1m) / 4m * 100m;    // 0 .. 100
                weightedTotal = weightedTotal + asPercent * map.WeightedScore;
                totalWeight = totalWeight + map.WeightedScore;
            }

            if (totalWeight == 0m)
            {
                return null;
            }
            return Math.Round(weightedTotal / totalWeight, 2);
        }

        /// <summary>"Strong" (70%+), "Moderate" (50 - 69%), "Weak" (under 50%) or "Not answered".</summary>
        public static string InterestLevel(decimal? score)
        {
            if (score.HasValue == false) return "Not answered";
            if (score.Value >= StrongInterest) return "Strong";
            if (score.Value >= ModerateInterest) return "Moderate";
            return "Weak";
        }

        /// <summary>
        /// The faculty of the programme with the best interest match. Returns null if that
        /// programme is in the same faculty as the one being checked.
        /// </summary>
        public string BestInterestFaculty(Dictionary<int, int> answers, int currentFacultyID)
        {
            LoadData();
            DegreeProgramme best = null;
            decimal bestScore = -1m;
            foreach (DegreeProgramme programme in programmes)
            {
                if (programme.IsActive == false)
                {
                    continue;
                }
                decimal score = ValueOrZero(InterestScore(answers, programme.DegreeID));
                if (score > bestScore)
                {
                    bestScore = score;
                    best = programme;
                }
            }
            if (best == null || best.FacultyID == currentFacultyID)
            {
                return null;
            }
            return LookupController.NameOf(facultyNames, best.FacultyID);
        }

        /// <summary>The interest category with the highest average answer.</summary>
        public string StrongestCategory(Dictionary<int, int> answers)
        {
            LoadData();
            if (answers == null || answers.Count == 0)
            {
                return "not answered";
            }

            // Add up the answers per category.
            Dictionary<int, int> sumPerCategory = new Dictionary<int, int>();
            Dictionary<int, int> countPerCategory = new Dictionary<int, int>();
            foreach (InterestQuestion question in questions)
            {
                if (answers.ContainsKey(question.QuestionID) == false)
                {
                    continue;
                }
                if (sumPerCategory.ContainsKey(question.CategoryID) == false)
                {
                    sumPerCategory[question.CategoryID] = 0;
                    countPerCategory[question.CategoryID] = 0;
                }
                sumPerCategory[question.CategoryID] = sumPerCategory[question.CategoryID] + answers[question.QuestionID];
                countPerCategory[question.CategoryID] = countPerCategory[question.CategoryID] + 1;
            }

            // Pick the category with the highest average.
            int bestCategory = 0;
            decimal bestAverage = -1m;
            foreach (int categoryID in sumPerCategory.Keys)
            {
                decimal average = (decimal)sumPerCategory[categoryID] / countPerCategory[categoryID];
                if (average > bestAverage)
                {
                    bestAverage = average;
                    bestCategory = categoryID;
                }
            }
            if (bestCategory == 0)
            {
                return "not answered";
            }
            return LookupController.NameOf(categoryNames, bestCategory);
        }

        // =====================================================================
        // Saved results (loaded from the database)
        // =====================================================================

        /// <summary>
        /// Builds the screen text for a RecommendationResult loaded from the database.
        /// Saved sessions only store the scores, outcome and gap.
        /// </summary>
        public EligibilityResult Describe(RecommendationResult stored)
        {
            LoadData();
            EligibilityResult e = new EligibilityResult();
            e.Degree = FindProgramme(stored.DegreeID);
            if (e.Degree != null)
            {
                e.FacultyName = LookupController.NameOf(facultyNames, e.Degree.FacultyID);
            }
            e.Result = stored;

            if (stored.AdvisoryOutcome == AdvisoryOutcomes.StrongMatch) e.Headline = "Strong Match ✔";
            else if (stored.AdvisoryOutcome == AdvisoryOutcomes.PossibleMatch) e.Headline = "Possible Match";
            else if (stored.AdvisoryOutcome == AdvisoryOutcomes.NotCurrentlyEligible) e.Headline = "Not Currently Eligible";
            else e.Headline = "More Information Needed";

            e.Detail = stored.GapDescription;
            e.Reasons.Add(MakeReason("Subject match", stored.SubjectMatchScore, "Share of required subjects captured"));
            e.Reasons.Add(MakeReason("Mark match", stored.MarkMatchScore, "Share of required marks met"));
            e.Reasons.Add(MakeReason("Interest match", stored.InterestMatchScore, "Questionnaire alignment"));
            e.Reasons.Add(MakeReason("Overall score", stored.OverallScore, "0.4 subject + 0.3 mark + 0.2 interest + 0.1 faculty preference"));

            ReasonLine gaps = new ReasonLine();
            gaps.Check = "Academic gaps";
            gaps.Result = stored.AdvisoryOutcome;
            gaps.Explanation = stored.GapDescription;
            e.Reasons.Add(gaps);
            return e;
        }

        // =====================================================================
        // Small helpers
        // =====================================================================

        private DegreeProgramme FindProgramme(int degreeID)
        {
            foreach (DegreeProgramme programme in programmes)
            {
                if (programme.DegreeID == degreeID)
                {
                    return programme;
                }
            }
            return null;
        }

        private static LearnerSubject FindSubject(List<LearnerSubject> subjects, int subjectID)
        {
            foreach (LearnerSubject s in subjects)
            {
                if (s.SubjectID == subjectID)
                {
                    return s;
                }
            }
            return null;
        }

        /// <summary>Average of the marks that are known (0 if none).</summary>
        private static decimal AverageMark(List<LearnerSubject> subjects)
        {
            decimal total = 0m;
            int count = 0;
            foreach (LearnerSubject s in subjects)
            {
                if (s.Mark.HasValue)
                {
                    total = total + s.Mark.Value;
                    count++;
                }
            }
            if (count == 0)
            {
                return 0m;
            }
            return total / count;
        }

        private string SubjectName(int subjectID)
        {
            return LookupController.NameOf(subjectNames, subjectID);
        }

        private static decimal ValueOrZero(decimal? value)
        {
            if (value.HasValue)
            {
                return value.Value;
            }
            return 0m;
        }

        private static ReasonLine MakeReason(string check, decimal? score, string explanation)
        {
            ReasonLine line = new ReasonLine();
            line.Check = check;
            if (score.HasValue)
            {
                line.Result = score.Value.ToString("0.##") + "%";
            }
            else
            {
                line.Result = "n/a";
            }
            line.Explanation = explanation;
            return line;
        }
    }
}
