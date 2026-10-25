using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;
using FuturePathStudentAdvisingSystem.DAL;

namespace FuturePathStudentAdvisingSystem.Business.Controllers
{
    /// <summary>
    /// Use case (Career Advisor / Administrator): Generate reports.
    ///   1. Learner Advisory Summary          -> LearnerController.GetSessionSummary
    ///   2. Degree Interest and Eligibility   -> DegreeReport + CommonGaps
    ///   3. Learners Not Currently Eligible   -> ExceptionReport
    /// Each session counts once, using the result for the programme the learner selected.
    /// </summary>
    public class ReportController
    {
        public const string LearnerSummaryReport = "Learner Advisory Summary";
        public const string DegreeInterestReport = "Degree Interest and Eligibility Report";
        public const string ExceptionReportName = "Learners Not Currently Eligible Exception Report";
        public static string[] ReportNames = { LearnerSummaryReport, DegreeInterestReport, ExceptionReportName };

        private LookupController lookup = new LookupController();

        /// <summary>A saved session together with the result for its selected programme.</summary>
        private class SessionOutcome
        {
            public AdvisorySession Session;
            public RecommendationResult Result;
        }

        /// <summary>
        /// Sessions in the date range that match the faculty/programme filter (0 = all),
        /// each with the result for the programme the learner selected.
        /// </summary>
        private List<SessionOutcome> Load(DateTime from, DateTime to, int facultyID, int degreeID)
        {
            if (from.Date > to.Date)
            {
                throw new BusinessRuleException("The From date must be on or before the To date.");
            }

            // programme -> faculty, so we can filter by faculty
            Dictionary<int, int> facultyOfProgramme = new Dictionary<int, int>();
            foreach (DegreeProgramme d in new DegreeProgrammeDAL().GetAll())
            {
                facultyOfProgramme[d.DegreeID] = d.FacultyID;
            }
            List<RecommendationResult> allResults = new RecommendationResultDAL().GetAll();

            List<SessionOutcome> list = new List<SessionOutcome>();
            foreach (AdvisorySession s in new AdvisorySessionDAL().GetAll())
            {
                if (s.SessionDate.Date < from.Date || s.SessionDate.Date > to.Date)
                {
                    continue;   // outside the dates
                }
                if (s.DegreeID.HasValue == false)
                {
                    continue;   // no programme selected
                }
                int sessionDegree = s.DegreeID.Value;
                if (degreeID != 0 && sessionDegree != degreeID)
                {
                    continue;   // other programme
                }
                if (facultyID != 0)
                {
                    if (facultyOfProgramme.ContainsKey(sessionDegree) == false || facultyOfProgramme[sessionDegree] != facultyID)
                    {
                        continue;   // other faculty
                    }
                }

                // Find the result row for the selected programme.
                RecommendationResult main = null;
                foreach (RecommendationResult r in allResults)
                {
                    if (r.SessionID == s.SessionID && r.DegreeID == sessionDegree)
                    {
                        main = r;
                        break;
                    }
                }
                if (main == null)
                {
                    continue;
                }

                SessionOutcome item = new SessionOutcome();
                item.Session = s;
                item.Result = main;
                list.Add(item);
            }
            return list;
        }

        /// <summary>One row per programme (sorted by name) plus a Total row.</summary>
        public List<DegreeReportRow> DegreeReport(DateTime from, DateTime to, int facultyID, int degreeID)
        {
            Dictionary<int, string> names = lookup.ProgrammeNames();
            Dictionary<int, DegreeReportRow> rowOfProgramme = new Dictionary<int, DegreeReportRow>();
            List<DegreeReportRow> rows = new List<DegreeReportRow>();

            DegreeReportRow total = new DegreeReportRow();
            total.Programme = "Total";

            foreach (SessionOutcome x in Load(from, to, facultyID, degreeID))
            {
                int id = x.Session.DegreeID.Value;
                if (rowOfProgramme.ContainsKey(id) == false)
                {
                    DegreeReportRow newRow = new DegreeReportRow();
                    newRow.Programme = LookupController.NameOf(names, id);
                    rowOfProgramme[id] = newRow;
                    rows.Add(newRow);
                }
                Count(rowOfProgramme[id], x.Result.AdvisoryOutcome);
                Count(total, x.Result.AdvisoryOutcome);
            }

            rows.Sort(CompareRows);
            rows.Add(total);
            return rows;
        }

        private static int CompareRows(DegreeReportRow a, DegreeReportRow b)
        {
            return string.Compare(a.Programme, b.Programme, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>Adds one session to a report row.</summary>
        private static void Count(DegreeReportRow row, string outcome)
        {
            row.Sessions++;
            if (outcome == AdvisoryOutcomes.StrongMatch)
            {
                row.Strong++;
            }
            else if (outcome == AdvisoryOutcomes.PossibleMatch)
            {
                row.Possible++;
            }
            else if (outcome == AdvisoryOutcomes.NotCurrentlyEligible)
            {
                row.NotEligible++;
            }
            else if (outcome == AdvisoryOutcomes.MoreInformationNeeded)
            {
                row.NeedInformation++;
            }
        }

        /// <summary>The gaps that occur, most frequent first, e.g. "Mathematics mark ... (2 sessions)".</summary>
        public List<string> CommonGaps(DateTime from, DateTime to, int facultyID, int degreeID)
        {
            // Two lists side by side: gaps[i] occurred counts[i] times.
            List<string> gaps = new List<string>();
            List<int> counts = new List<int>();

            foreach (SessionOutcome x in Load(from, to, facultyID, degreeID))
            {
                string gap = x.Result.GapDescription;
                if (gap == null || gap.Trim() == "" || gap == "None identified")
                {
                    continue;
                }
                int index = gaps.IndexOf(gap);
                if (index == -1)
                {
                    gaps.Add(gap);
                    counts.Add(1);
                }
                else
                {
                    counts[index] = counts[index] + 1;
                }
            }

            // Bubble sort: highest count first (equal counts keep their order).
            for (int pass = 0; pass < counts.Count - 1; pass++)
            {
                for (int i = 0; i < counts.Count - 1 - pass; i++)
                {
                    if (counts[i] < counts[i + 1])
                    {
                        int tempCount = counts[i];
                        counts[i] = counts[i + 1];
                        counts[i + 1] = tempCount;

                        string tempGap = gaps[i];
                        gaps[i] = gaps[i + 1];
                        gaps[i + 1] = tempGap;
                    }
                }
            }

            List<string> lines = new List<string>();
            for (int i = 0; i < gaps.Count; i++)
            {
                if (counts[i] == 1)
                {
                    lines.Add(gaps[i] + " (1 session)");
                }
                else
                {
                    lines.Add(gaps[i] + " (" + counts[i] + " sessions)");
                }
            }
            return lines;
        }

        /// <summary>Learners whose selected programme is Not Currently Eligible or More Information Needed.</summary>
        public List<ExceptionReportRow> ExceptionReport(DateTime from, DateTime to, int facultyID, int degreeID)
        {
            Dictionary<int, string> programmeNames = lookup.ProgrammeNames();
            Dictionary<int, string> learnerNames = new Dictionary<int, string>();
            foreach (Learner l in new LearnerDAL().GetAll())
            {
                learnerNames[l.LearnerID] = l.FullName;
            }

            List<ExceptionReportRow> rows = new List<ExceptionReportRow>();
            foreach (SessionOutcome x in Load(from, to, facultyID, degreeID))
            {
                string outcome = x.Result.AdvisoryOutcome;
                if (outcome != AdvisoryOutcomes.NotCurrentlyEligible && outcome != AdvisoryOutcomes.MoreInformationNeeded)
                {
                    continue;
                }
                ExceptionReportRow row = new ExceptionReportRow();
                row.Learner = LookupController.NameOf(learnerNames, x.Session.LearnerID);
                row.Programme = LookupController.NameOf(programmeNames, x.Session.DegreeID.Value);
                row.Outcome = outcome;
                row.Reason = x.Result.GapDescription;
                rows.Add(row);
            }
            rows.Sort(CompareExceptionRows);
            return rows;
        }

        /// <summary>Sort by outcome, then by learner name.</summary>
        private static int CompareExceptionRows(ExceptionReportRow a, ExceptionReportRow b)
        {
            int byOutcome = string.Compare(a.Outcome, b.Outcome, StringComparison.Ordinal);
            if (byOutcome != 0)
            {
                return byOutcome;
            }
            return string.Compare(a.Learner, b.Learner, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>The latest saved session of a learner (for the individual summary report); 0 if none.</summary>
        public int LatestSessionOf(int learnerID)
        {
            AdvisorySession latest = null;
            foreach (AdvisorySession s in new AdvisorySessionDAL().GetByLearner(learnerID))
            {
                if (latest == null
                    || s.SessionDate > latest.SessionDate
                    || (s.SessionDate == latest.SessionDate && s.SessionID > latest.SessionID))
                {
                    latest = s;
                }
            }
            if (latest == null)
            {
                return 0;
            }
            return latest.SessionID;
        }
    }
}
