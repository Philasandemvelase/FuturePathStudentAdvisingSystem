using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use cases (Career Advisor): Search learners and Review saved advisory sessions.
    /// Everything here is read-only.
    /// </summary>
    public class LearnerController
    {
        private LearnerDAL learnerDal = new LearnerDAL();
        private AdvisorySessionDAL sessionDal = new AdvisorySessionDAL();
        private RecommendationResultDAL resultDal = new RecommendationResultDAL();
        private LookupController lookup = new LookupController();

        /// <summary>Search by name (or learner number) and grade (gradeLevelID 0 = all grades).</summary>
        public List<LearnerListItem> Search(string text, int gradeLevelID)
        {
            if (text == null)
            {
                text = "";
            }
            text = text.Trim();

            // 1. Find the learners: everyone, one learner number, or a name search.
            List<Learner> found;
            int number;
            if (text == "")
            {
                found = learnerDal.GetAll();
            }
            else if (int.TryParse(text, out number))
            {
                found = new List<Learner>();
                Learner one = learnerDal.GetByID(number);
                if (one != null)
                {
                    found.Add(one);
                }
            }
            else
            {
                found = learnerDal.SearchByName(text);
            }

            // 2. Keep only the chosen grade and add the grade name.
            Dictionary<int, string> grades = lookup.GradeNames();
            List<LearnerListItem> items = new List<LearnerListItem>();
            foreach (Learner l in found)
            {
                if (gradeLevelID != 0 && l.GradeLevelID != gradeLevelID)
                {
                    continue;
                }
                LearnerListItem item = new LearnerListItem();
                item.LearnerID = l.LearnerID;
                item.FullName = l.FullName;
                item.GradeName = LookupController.NameOf(grades, l.GradeLevelID);
                item.SchoolName = l.SchoolName;
                items.Add(item);
            }

            // 3. Sort by name.
            items.Sort(CompareByName);
            return items;
        }

        private static int CompareByName(LearnerListItem a, LearnerListItem b)
        {
            return string.Compare(a.FullName, b.FullName, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>All sessions of one learner (newest first; the DAL sorts them).</summary>
        public List<SessionListItem> GetSessions(int learnerID)
        {
            return ToListItems(sessionDal.GetByLearner(learnerID));
        }

        /// <summary>The most recent sessions (Career Advisor dashboard).</summary>
        public List<SessionListItem> GetRecentSessions(int count)
        {
            List<AdvisorySession> all = sessionDal.GetAll();
            all.Sort(CompareNewestFirst);

            List<AdvisorySession> recent = new List<AdvisorySession>();
            for (int i = 0; i < all.Count && i < count; i++)
            {
                recent.Add(all[i]);
            }
            return ToListItems(recent);
        }

        /// <summary>Newest date first; on the same date the higher session number first.</summary>
        private static int CompareNewestFirst(AdvisorySession a, AdvisorySession b)
        {
            if (a.SessionDate != b.SessionDate)
            {
                return b.SessionDate.CompareTo(a.SessionDate);
            }
            return b.SessionID.CompareTo(a.SessionID);
        }

        /// <summary>Outcome of a saved session for the selected programme, ready for the Outcome screen.</summary>
        public EligibilityResult GetSavedOutcome(int sessionID)
        {
            AdvisorySession session = sessionDal.GetByID(sessionID);
            RecommendationResult main = null;
            if (session != null)
            {
                main = MainResult(session, resultDal.GetBySession(sessionID));
            }
            if (main == null)
            {
                throw new BusinessRuleException("This session has no recorded outcome.");
            }
            return new RecommendationController().Describe(main);
        }

        /// <summary>Rebuilds the summary of a saved session from the database.</summary>
        public SessionSummary GetSessionSummary(int sessionID)
        {
            AdvisorySession session = sessionDal.GetByID(sessionID);
            if (session == null)
            {
                throw new BusinessRuleException("The session could not be found.");
            }
            Learner learner = learnerDal.GetByID(session.LearnerID);
            Dictionary<int, string> subjectNames = lookup.SubjectNames();
            Dictionary<int, string> programmeNames = lookup.ProgrammeNames();

            List<RecommendationResult> results = resultDal.GetBySession(sessionID);
            RecommendationResult main = MainResult(session, results);

            SessionSummary summary = new SessionSummary();
            summary.SessionID = sessionID;
            summary.LearnerName = learner.FullName;
            summary.GradeName = LookupController.NameOf(lookup.GradeNames(), learner.GradeLevelID);
            summary.DateGenerated = session.SessionDate;

            if (session.DegreeID.HasValue && programmeNames.ContainsKey(session.DegreeID.Value))
            {
                summary.ProgrammeName = programmeNames[session.DegreeID.Value];
            }
            else
            {
                summary.ProgrammeName = "Not selected";
            }

            if (main == null)
            {
                summary.Outcome = "Not calculated";
                summary.Gaps = "Not assessed.";
            }
            else
            {
                summary.Outcome = main.AdvisoryOutcome;
                summary.Gaps = main.GapDescription + ".";
            }

            // Subjects and marks
            foreach (LearnerSubject s in new LearnerSubjectDAL().GetByLearner(learner.LearnerID))
            {
                SubjectMarkLine line = new SubjectMarkLine();
                line.SubjectID = s.SubjectID;
                line.SubjectName = LookupController.NameOf(subjectNames, s.SubjectID);
                line.Mark = s.Mark;
                summary.Marks.Add(line);
            }

            // Questionnaire answers -> strongest interest category
            Dictionary<int, int> answers = new Dictionary<int, int>();
            foreach (LearnerInterestReport a in new LearnerInterestReportDAL().GetByLearner(learner.LearnerID))
            {
                answers[a.QuestionID] = a.SelectedOptionValue;
            }
            summary.Interests = "Strongest alignment with " + new RecommendationController().StrongestCategory(answers) + ".";

            // Every other stored result is an alternative programme.
            string alternatives = "";
            foreach (RecommendationResult r in results)
            {
                if (main != null && r.ResultID == main.ResultID)
                {
                    continue;
                }
                if (alternatives != "")
                {
                    alternatives = alternatives + "; ";
                }
                alternatives = alternatives + LookupController.NameOf(programmeNames, r.DegreeID);
            }
            if (alternatives == "")
            {
                summary.Alternatives = "None recorded.";
            }
            else
            {
                summary.Alternatives = alternatives + ".";
            }

            if (session.FundingRequested)
            {
                summary.Funding = "Requested.";
            }
            else
            {
                summary.Funding = "Not requested.";
            }
            return summary;
        }

        /// <summary>
        /// The result for the programme the learner selected.
        /// If no row matches that programme, the first row is used (null if there are none).
        /// </summary>
        private RecommendationResult MainResult(AdvisorySession session, List<RecommendationResult> results)
        {
            if (results.Count == 0)
            {
                return null;
            }
            if (session.DegreeID.HasValue)
            {
                foreach (RecommendationResult r in results)
                {
                    if (r.DegreeID == session.DegreeID.Value)
                    {
                        return r;
                    }
                }
            }
            return results[0];
        }

        /// <summary>Turns sessions into list rows with the learner name, programme and outcome.</summary>
        private List<SessionListItem> ToListItems(List<AdvisorySession> sessions)
        {
            Dictionary<int, string> learnerNames = new Dictionary<int, string>();
            foreach (Learner l in learnerDal.GetAll())
            {
                learnerNames[l.LearnerID] = l.FullName;
            }
            Dictionary<int, string> programmeNames = lookup.ProgrammeNames();
            List<RecommendationResult> allResults = resultDal.GetAll();

            List<SessionListItem> items = new List<SessionListItem>();
            foreach (AdvisorySession s in sessions)
            {
                // The results that belong to this session.
                List<RecommendationResult> sessionResults = new List<RecommendationResult>();
                foreach (RecommendationResult r in allResults)
                {
                    if (r.SessionID == s.SessionID)
                    {
                        sessionResults.Add(r);
                    }
                }
                RecommendationResult main = MainResult(s, sessionResults);

                SessionListItem item = new SessionListItem();
                item.SessionID = s.SessionID;
                item.LearnerID = s.LearnerID;
                item.LearnerName = LookupController.NameOf(learnerNames, s.LearnerID);
                item.SessionDate = s.SessionDate;
                if (s.DegreeID.HasValue && programmeNames.ContainsKey(s.DegreeID.Value))
                {
                    item.DegreeName = programmeNames[s.DegreeID.Value];
                }
                else
                {
                    item.DegreeName = "Not selected";
                }
                if (main == null)
                {
                    item.Outcome = "Not calculated";
                }
                else
                {
                    item.Outcome = main.AdvisoryOutcome;
                }
                items.Add(item);
            }
            return items;
        }
    }
}
