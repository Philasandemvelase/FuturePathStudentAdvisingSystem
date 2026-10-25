using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A high-school learner receiving advice. Table: dbo.Learner</summary>
    public class Learner
    {
        public int    LearnerID { get; set; }  // learnerID - PK
        public string FullName { get; set; } = string.Empty;  // fullName
        public int    GradeLevelID { get; set; }  // gradeLevelID - FK -> GradeLevel
        public string SchoolName { get; set; }  // schoolName - optional
        public string Province { get; set; }  // province - optional
        public string ContactDetails { get; set; }  // contactDetails - optional
    }
}
