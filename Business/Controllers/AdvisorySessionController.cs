using System;
using System.Collections.Generic;
using System.IO;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case: Conduct an advisory session (the learner journey).
    ///
    /// ONE object holds ONE session while the learner moves through the screens:
    ///   1. SetProfile               Learner Profile
    ///   2. SaveSubject / Remove     Subjects & Marks
    ///   3. RecordAnswer             Interest Questionnaire
    ///   4. CheckEligibility         Faculty & Degree Selection (checks AND saves the session)
    ///   5. LastResult               Advisory Outcome
    ///      GetAlternatives          Alternative Programmes
    ///      SearchFunding            Funding Information
    ///      BuildSummary / Export    Advisory Summary
    ///
    /// Nothing is written to the database until CheckEligibility. It then saves
    /// Learner, LearnerSubject, LearnerInterestReport, AdvisorySession and RecommendationResult.
    /// Checking again after a change updates the same rows instead of creating new ones.
    /// </summary>
    public class AdvisorySessionController
    {
        public const string Disclaimer = "Advisory guidance only. Not an official admission or funding decision.";
        public const int AlternativesToStore = 3;

        private RecommendationController recommender = new RecommendationController();
        private LookupController lookup = new LookupController();

        // The learner's subjects and questionnaire answers (questionID -> answer 1..5).
        private List<LearnerSubject> subjects = new List<LearnerSubject>();
        private Dictionary<int, int> answers = new Dictionary<int, int>();

        /// <summary>The learner being advised (LearnerID is 0 until the session is saved).</summary>
        public Learner Learner { get; private set; }

        public int PreferredFacultyID { get; private set; }   // 0 = no faculty chosen
        public int SelectedDegreeID { get; private set; }     // 0 = no programme chosen
        public bool FundingRequested { get; private set; }
        public string SelectedFundingName { get; private set; }

        /// <summary>The saved AdvisorySession.sessionID (0 = not saved yet).</summary>
        public int SavedSessionID { get; private set; }

        /// <summary>Result of the last CheckEligibility (null until then).</summary>
        public EligibilityResult LastResult { get; private set; }

        /// <summary>True when subjects, answers or the programme changed after the last check.</summary>
        public bool ResultIsOutOfDate { get; private set; }

        public AdvisorySessionController()
        {
            Learner = new Learner();
        }

        /// <summary>True once the learner has entered anything (used to confirm before discarding).</summary>
        public bool HasData
        {
            get
            {
                if (Learner.GradeLevelID > 0 || subjects.Count > 0 || answers.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        // =========================== 1. Profile ===========================

        /// <summary>Keeps whatever is typed, without validation (used when a screen closes).</summary>
        public void UpdateProfileDraft(int gradeLevelID, string fullName, string school, string province, string contact)
        {
            Learner.GradeLevelID = gradeLevelID;
            Learner.FullName = Clean(fullName);
            Learner.SchoolName = BlankToNull(school);
            Learner.Province = BlankToNull(province);
            Learner.ContactDetails = BlankToNull(contact);
        }

        /// <summary>Validates and stores the profile (Next on the Learner Profile screen).</summary>
        public void SetProfile(int gradeLevelID, string fullName, string school, string province, string contact)
        {
            if (gradeLevelID <= 0)
            {
                throw new BusinessRuleException("Select your current grade.");
            }

            string email = Clean(contact);
            if (email.Length > 0)
            {
                int at = email.IndexOf('@');
                int dot = email.LastIndexOf('.');
                if (at < 1 || dot < at)
                {
                    throw new BusinessRuleException("Enter a valid email address or leave it blank.");
                }
            }
            if (Clean(fullName).Length > 100)
            {
                throw new BusinessRuleException("Name can be at most 100 characters.");
            }
            if (Clean(school).Length > 100)
            {
                throw new BusinessRuleException("School can be at most 100 characters.");
            }
            if (email.Length > 100)
            {
                throw new BusinessRuleException("Contact email can be at most 100 characters.");
            }

            UpdateProfileDraft(gradeLevelID, fullName, school, province, contact);
            MarkChanged();
        }

        // =========================== 2. Subjects ===========================

        public List<LearnerSubject> Subjects
        {
            get { return subjects; }
        }

        /// <summary>The captured subjects with their names, for the grid.</summary>
        public List<SubjectMarkLine> GetSubjectLines()
        {
            Dictionary<int, string> names = lookup.SubjectNames();
            List<SubjectMarkLine> lines = new List<SubjectMarkLine>();
            foreach (LearnerSubject s in subjects)
            {
                SubjectMarkLine line = new SubjectMarkLine();
                line.SubjectID = s.SubjectID;
                line.SubjectName = LookupController.NameOf(names, s.SubjectID);
                line.Mark = s.Mark;
                lines.Add(line);
            }
            return lines;
        }

        /// <summary>
        /// Adds a subject. When replacingSubjectID is not 0 (Edit), that subject is replaced.
        /// mark = null means "mark not available yet".
        /// </summary>
        public void SaveSubject(int subjectID, decimal? mark, int replacingSubjectID)
        {
            if (subjectID <= 0)
            {
                throw new BusinessRuleException("Select a subject.");
            }
            if (mark.HasValue && (mark.Value < 0 || mark.Value > 100))
            {
                throw new BusinessRuleException("A mark must be between 0 and 100.");
            }

            // The same subject may not be added twice (except the one being edited).
            foreach (LearnerSubject s in subjects)
            {
                if (s.SubjectID == subjectID && s.SubjectID != replacingSubjectID)
                {
                    throw new BusinessRuleException("This subject has already been added. Edit the existing mark instead.");
                }
            }

            if (replacingSubjectID > 0)
            {
                RemoveFromList(replacingSubjectID);
            }

            LearnerSubject newSubject = new LearnerSubject();
            newSubject.SubjectID = subjectID;
            newSubject.Mark = mark;

            // Insert in SubjectID order so the grid always shows the same order.
            int position = subjects.Count;
            for (int i = 0; i < subjects.Count; i++)
            {
                if (subjects[i].SubjectID > subjectID)
                {
                    position = i;
                    break;
                }
            }
            subjects.Insert(position, newSubject);
            MarkChanged();
        }

        public void RemoveSubject(int subjectID)
        {
            RemoveFromList(subjectID);
            MarkChanged();
        }

        public void ValidateSubjects()
        {
            if (subjects.Count == 0)
            {
                throw new BusinessRuleException("Add at least one subject before continuing.");
            }
        }

        private void RemoveFromList(int subjectID)
        {
            for (int i = subjects.Count - 1; i >= 0; i--)
            {
                if (subjects[i].SubjectID == subjectID)
                {
                    subjects.RemoveAt(i);
                }
            }
        }

        // =========================== 3. Questionnaire ===========================

        /// <summary>Active questions in questionID order (the DAL already sorts them).</summary>
        public List<InterestQuestion> GetQuestions()
        {
            return new InterestQuestionDAL().GetActive();
        }

        public void RecordAnswer(int questionID, int value)
        {
            if (value < 1 || value > 5)
            {
                throw new BusinessRuleException("Answers must be between 1 and 5.");
            }
            answers[questionID] = value;
            MarkChanged();
        }

        /// <summary>The learner's answer, or 0 if the question has not been answered.</summary>
        public int GetAnswer(int questionID)
        {
            if (answers.ContainsKey(questionID))
            {
                return answers[questionID];
            }
            return 0;
        }

        public bool AllAnswered(List<InterestQuestion> questions)
        {
            foreach (InterestQuestion q in questions)
            {
                if (answers.ContainsKey(q.QuestionID) == false)
                {
                    return false;
                }
            }
            return true;
        }

        // =========================== 4. Programme + eligibility ===========================

        /// <summary>Keeps the chosen faculty/programme without checking (used when a screen closes).</summary>
        public void SelectProgramme(int facultyID, int degreeID)
        {
            if (facultyID < 0) facultyID = 0;
            if (degreeID < 0) degreeID = 0;
            if (facultyID != PreferredFacultyID || degreeID != SelectedDegreeID)
            {
                MarkChanged();
            }
            PreferredFacultyID = facultyID;
            SelectedDegreeID = degreeID;
        }

        /// <summary>The selected programme's requirements next to the learner's marks.</summary>
        public List<RequirementCheckLine> GetRequirementCheck(int degreeID)
        {
            Dictionary<int, string> names = lookup.SubjectNames();
            List<RequirementCheckLine> lines = new List<RequirementCheckLine>();

            foreach (ProgrammeRequirement rule in new ProgrammeRequirementDAL().GetByDegree(degreeID))
            {
                string name = LookupController.NameOf(names, rule.SubjectID);
                LearnerSubject captured = FindSubject(rule.SubjectID);

                if (rule.AcceptedAlternativeSubjectID.HasValue)
                {
                    int alternativeID = rule.AcceptedAlternativeSubjectID.Value;
                    name = name + " (or " + LookupController.NameOf(names, alternativeID) + ")";
                    if (captured == null)
                    {
                        captured = FindSubject(alternativeID);
                    }
                }

                RequirementCheckLine line = new RequirementCheckLine();
                line.Requirement = name;
                line.Minimum = rule.MinimumMark.ToString("0.##") + "%";
                if (captured == null)
                {
                    line.YourResult = "Not captured";
                }
                else if (captured.Mark.HasValue)
                {
                    line.YourResult = captured.Mark.Value.ToString("0.##") + "%";
                }
                else
                {
                    line.YourResult = "Not supplied";
                }
                lines.Add(line);
            }
            return lines;
        }

        /// <summary>
        /// Checks the selected programme and saves the whole session to the database.
        /// Returns the result shown on the Advisory Outcome screen.
        /// </summary>
        public EligibilityResult CheckEligibility(int facultyID, int degreeID)
        {
            if (Learner.GradeLevelID <= 0)
            {
                throw new BusinessRuleException("Complete the Learner Profile first.");
            }
            ValidateSubjects();
            if (degreeID <= 0)
            {
                throw new BusinessRuleException("Select a faculty and a degree programme first.");
            }
            SelectProgramme(facultyID, degreeID);

            LastResult = recommender.Evaluate(subjects, answers, degreeID, PreferredFacultyID);
            List<EligibilityResult> alternatives =
                recommender.FindAlternatives(subjects, answers, degreeID, PreferredFacultyID, AlternativesToStore);

            SaveSession(alternatives);
            ResultIsOutOfDate = false;
            return LastResult;
        }

        public List<EligibilityResult> GetAlternatives(int max)
        {
            if (subjects.Count == 0)
            {
                return new List<EligibilityResult>();
            }
            return recommender.FindAlternatives(subjects, answers, SelectedDegreeID, PreferredFacultyID, max);
        }

        // =========================== Funding ===========================

        public List<FundingListItem> SearchFunding(int facultyID, int degreeID, string fundingType)
        {
            return new FundingController().Search(facultyID, degreeID, fundingType);
        }

        /// <summary>Records that the learner is interested in funding (AdvisorySession.fundingRequested).</summary>
        public void RequestFunding(FundingListItem funding)
        {
            if (funding == null)
            {
                return;
            }
            FundingRequested = true;
            SelectedFundingName = funding.Funding.FundingName;

            // If the session is already saved, update its fundingRequested column too.
            if (SavedSessionID > 0)
            {
                AdvisorySessionDAL sessionDal = new AdvisorySessionDAL();
                AdvisorySession session = sessionDal.GetByID(SavedSessionID);
                if (session != null && session.FundingRequested == false)
                {
                    session.FundingRequested = true;
                    sessionDal.Update(session);
                }
            }
        }

        // =========================== Summary + export ===========================

        public SessionSummary BuildSummary()
        {
            SessionSummary summary = new SessionSummary();
            summary.SessionID = SavedSessionID;

            if (Learner.FullName == null || Learner.FullName == "")
            {
                summary.LearnerName = "Learner";
            }
            else
            {
                summary.LearnerName = Learner.FullName;
            }
            summary.GradeName = LookupController.NameOf(lookup.GradeNames(), Learner.GradeLevelID);

            if (LastResult == null)
            {
                summary.ProgrammeName = "Not selected";
                summary.Outcome = "Not calculated";
                summary.Gaps = "Not assessed.";
            }
            else
            {
                summary.ProgrammeName = LastResult.Degree.DegreeName;
                summary.Outcome = LastResult.Outcome;
                summary.Gaps = LastResult.Result.GapDescription + ".";
            }

            summary.Marks = GetSubjectLines();
            summary.Interests = "Strongest alignment with " + recommender.StrongestCategory(answers) + ".";

            List<EligibilityResult> alternatives = GetAlternatives(AlternativesToStore);
            if (alternatives.Count == 0)
            {
                summary.Alternatives = "None identified.";
            }
            else
            {
                string text = "";
                foreach (EligibilityResult a in alternatives)
                {
                    if (text != "") text = text + "; ";
                    text = text + a.Degree.DegreeName;
                }
                summary.Alternatives = text + ".";
            }

            if (FundingRequested == false)
            {
                summary.Funding = "Not requested.";
            }
            else if (SelectedFundingName == null)
            {
                summary.Funding = "Requested.";
            }
            else
            {
                summary.Funding = "Requested (" + SelectedFundingName + ").";
            }

            summary.DateGenerated = DateTime.Today;
            return summary;
        }

        /// <summary>
        /// Writes the summary to a text file and records it in ExportReport.
        /// The session must have been saved (Check Eligibility) first.
        /// </summary>
        public void ExportSummary(SessionSummary summary, string filePath)
        {
            if (SavedSessionID == 0)
            {
                throw new BusinessRuleException("Check eligibility first, so the session is saved before exporting.");
            }
            File.WriteAllText(filePath, FormatSummary(summary));

            ExportReport report = new ExportReport();
            report.SessionID = SavedSessionID;
            report.DisclaimerText = Disclaimer;
            report.ReportFormat = ReportFormats.Txt;
            report.ExportDate = DateTime.Now;
            if (filePath.Length <= 260)
            {
                report.FilePath = filePath;   // the column holds at most 260 characters
            }
            new ExportReportDAL().Add(report);
        }

        /// <summary>The summary as plain text (used for the exported file).</summary>
        public static string FormatSummary(SessionSummary s)
        {
            string nl = Environment.NewLine;
            string text = "FUTURE PATH - ADVISORY SUMMARY" + nl;
            text += "========================================" + nl;
            if (s.GradeName == null || s.GradeName == "")
            {
                text += s.LearnerName + nl;
            }
            else
            {
                text += s.LearnerName + " - " + s.GradeName + nl;
            }
            text += "Selected programme: " + s.ProgrammeName + nl;
            text += "Outcome: " + s.Outcome + nl;
            text += nl;
            text += "Academic profile" + nl;
            foreach (SubjectMarkLine m in s.Marks)
            {
                text += "  " + m.SubjectName + ": " + m.MarkText + nl;
            }
            text += nl;
            text += "Interests: " + s.Interests + nl;
            text += "Gaps: " + s.Gaps + nl;
            text += "Alternatives: " + s.Alternatives + nl;
            text += "Funding: " + s.Funding + nl;
            text += "Date generated: " + s.DateGenerated.ToString("dd MMMM yyyy") + nl;
            text += nl;
            text += Disclaimer + nl;
            return text;
        }

        // =========================== Saving to the database ===========================

        /// <summary>
        /// Writes the session to the database in foreign-key order:
        /// Learner -> LearnerSubject -> LearnerInterestReport -> AdvisorySession -> RecommendationResult.
        /// If a NEW session fails halfway, the learner row is deleted again; the foreign keys
        /// cascade, so no half-saved session is left behind.
        /// </summary>
        private void SaveSession(List<EligibilityResult> alternatives)
        {
            LearnerDAL learnerDal = new LearnerDAL();
            LearnerSubjectDAL subjectDal = new LearnerSubjectDAL();
            LearnerInterestReportDAL answerDal = new LearnerInterestReportDAL();
            AdvisorySessionDAL sessionDal = new AdvisorySessionDAL();
            RecommendationResultDAL resultDal = new RecommendationResultDAL();

            if (Learner.FullName == null || Learner.FullName.Trim() == "")
            {
                Learner.FullName = "Name not supplied";
            }
            bool isNew = (SavedSessionID == 0);

            try
            {
                // ---- 1. Learner ----
                if (isNew)
                {
                    learnerDal.Add(Learner);   // fills in Learner.LearnerID
                }
                else
                {
                    learnerDal.Update(Learner);
                    // Remove the old subjects and answers; the current ones are added below.
                    foreach (LearnerSubject old in subjectDal.GetByLearner(Learner.LearnerID))
                    {
                        subjectDal.Delete(old.LearnerSubjectID);
                    }
                    foreach (LearnerInterestReport old in answerDal.GetByLearner(Learner.LearnerID))
                    {
                        answerDal.Delete(old.ResponseID);
                    }
                }

                // ---- 2. LearnerSubject ----
                foreach (LearnerSubject s in subjects)
                {
                    s.LearnerID = Learner.LearnerID;
                    subjectDal.Add(s);
                }

                // ---- 3. LearnerInterestReport ----
                foreach (KeyValuePair<int, int> pair in answers)
                {
                    LearnerInterestReport answer = new LearnerInterestReport();
                    answer.LearnerID = Learner.LearnerID;
                    answer.QuestionID = pair.Key;
                    answer.SelectedOptionValue = pair.Value;
                    answerDal.Add(answer);
                }

                // ---- 4. AdvisorySession ----
                AdvisorySession session;
                if (isNew)
                {
                    session = new AdvisorySession();
                    session.SessionDate = DateTime.Today;
                }
                else
                {
                    session = sessionDal.GetByID(SavedSessionID);
                }
                session.LearnerID = Learner.LearnerID;
                session.FacultyID = ZeroToNull(PreferredFacultyID);
                session.DegreeID = ZeroToNull(SelectedDegreeID);
                session.FundingRequested = FundingRequested;

                if (isNew)
                {
                    sessionDal.Add(session);   // fills in session.SessionID
                }
                else
                {
                    sessionDal.Update(session);
                    foreach (RecommendationResult old in resultDal.GetBySession(session.SessionID))
                    {
                        resultDal.Delete(old.ResultID);
                    }
                }

                // ---- 5. RecommendationResult: the selected programme first, then the alternatives ----
                LastResult.Result.SessionID = session.SessionID;
                resultDal.Add(LastResult.Result);
                foreach (EligibilityResult alternative in alternatives)
                {
                    alternative.Result.SessionID = session.SessionID;
                    resultDal.Add(alternative.Result);
                }

                SavedSessionID = session.SessionID;
            }
            catch
            {
                // Undo a half-saved NEW session (deleting the learner cascades to the other rows).
                if (isNew && Learner.LearnerID > 0)
                {
                    try
                    {
                        learnerDal.Delete(Learner.LearnerID);
                    }
                    catch
                    {
                        // ignore, so the original error is the one the user sees
                    }
                    Learner.LearnerID = 0;
                }
                throw;
            }
        }

        // =========================== Small helpers ===========================

        private LearnerSubject FindSubject(int subjectID)
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

        private void MarkChanged()
        {
            if (LastResult != null)
            {
                ResultIsOutOfDate = true;
            }
        }

        private static string Clean(string text)
        {
            if (text == null)
            {
                return "";
            }
            return text.Trim();
        }

        private static string BlankToNull(string text)
        {
            text = Clean(text);
            if (text == "")
            {
                return null;
            }
            return text;
        }

        private static int? ZeroToNull(int id)
        {
            if (id == 0)
            {
                return null;
            }
            return id;
        }
    }
}
