using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A subject/mark requirement for a degree. Table: dbo.ProgrammeRequirements</summary>
    public class ProgrammeRequirement
    {
        public int      RequirementID { get; set; }  // requirementID - PK
        public int      DegreeID { get; set; }  // degreeID - FK -> DegreeProgramme
        public int      SubjectID { get; set; }  // subjectID - FK -> Subject
        public decimal  MinimumMark { get; set; }  // minimumMark
        public bool     IsRequired { get; set; } = true;  // isRequired
        public int?     AcceptedAlternativeSubjectID { get; set; }  // acceptedAlternativeSubjectID - FK -> Subject, e.g. Maths Literacy instead of Maths
        public decimal? MinimumOverallAverage { get; set; }  // minimumOverallAverage - optional
        public string   RequirementType { get; set; } = "Subject";  // requirementType - defaults to "Subject"
        public string   Notes { get; set; }  // notes - optional
    }
}
