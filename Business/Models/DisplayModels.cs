using System;
using System.Collections.Generic;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Business.Models
{
    // Simple classes the controllers give to the forms. Each one combines data from
    // more than one table (for example a session together with the learner's name),
    // so the forms never have to look anything up themselves.

    /// <summary>A captured subject with its name (LearnerSubject + Subject).</summary>
    public class SubjectMarkLine
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public decimal? Mark { get; set; }

        /// <summary>The mark as text, or "Not supplied" when there is no mark.</summary>
        public string MarkText
        {
            get
            {
                if (Mark.HasValue)
                {
                    return Mark.Value.ToString("0.##");
                }
                return "Not supplied";
            }
        }
    }

    /// <summary>One row of "Programme requirements": requirement, minimum, learner's result.</summary>
    public class RequirementCheckLine
    {
        public string Requirement { get; set; }
        public string Minimum { get; set; }
        public string YourResult { get; set; }
    }

    /// <summary>A saved advisory session for lists and grids.</summary>
    public class SessionListItem
    {
        public int SessionID { get; set; }
        public int LearnerID { get; set; }
        public string LearnerName { get; set; }
        public string DegreeName { get; set; }
        public DateTime SessionDate { get; set; }
        public string Outcome { get; set; }
    }

    /// <summary>A learner row in search results (Learner + grade name).</summary>
    public class LearnerListItem
    {
        public int LearnerID { get; set; }
        public string FullName { get; set; }
        public string GradeName { get; set; }
        public string SchoolName { get; set; }
    }

    /// <summary>A funding option together with the faculties and programmes it is linked to.</summary>
    public class FundingListItem
    {
        public FundingOption Funding { get; set; }
        public List<int> FacultyIDs { get; set; }
        public List<int> DegreeIDs { get; set; }
        public string LinkedTo { get; set; }

        public FundingListItem()
        {
            FacultyIDs = new List<int>();
            DegreeIDs = new List<int>();
        }
    }

    /// <summary>A programme with its faculty name (DegreeProgramme + Faculty).</summary>
    public class ProgrammeListItem
    {
        public DegreeProgramme Programme { get; set; }
        public string FacultyName { get; set; }
    }

    /// <summary>A requirement with readable subject names (ProgrammeRequirements + Subject).</summary>
    public class RequirementListItem
    {
        public ProgrammeRequirement Requirement { get; set; }
        public string SubjectName { get; set; }
        public string AlternativeName { get; set; }
    }

    /// <summary>A question with its category name.</summary>
    public class QuestionListItem
    {
        public InterestQuestion Question { get; set; }
        public string CategoryName { get; set; }
    }

    /// <summary>Everything the Advisory Summary screen and the exported file show.</summary>
    public class SessionSummary
    {
        public int SessionID { get; set; }          // 0 = not saved yet
        public string LearnerName { get; set; }
        public string GradeName { get; set; }
        public string ProgrammeName { get; set; }
        public string Outcome { get; set; }
        public List<SubjectMarkLine> Marks { get; set; }
        public string Interests { get; set; }
        public string Gaps { get; set; }
        public string Alternatives { get; set; }
        public string Funding { get; set; }
        public DateTime DateGenerated { get; set; }

        public SessionSummary()
        {
            Marks = new List<SubjectMarkLine>();
        }
    }

    /// <summary>Degree Interest and Eligibility report: one row per programme.</summary>
    public class DegreeReportRow
    {
        public string Programme { get; set; }
        public int Sessions { get; set; }
        public int Strong { get; set; }
        public int Possible { get; set; }
        public int NotEligible { get; set; }
        public int NeedInformation { get; set; }
    }

    /// <summary>Learners Not Currently Eligible exception report: one row per session.</summary>
    public class ExceptionReportRow
    {
        public string Learner { get; set; }
        public string Programme { get; set; }
        public string Outcome { get; set; }
        public string Reason { get; set; }
    }
}
