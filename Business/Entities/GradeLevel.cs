using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>School grade (Grade 11 / Grade 12). Table: dbo.GradeLevel</summary>
    public class GradeLevel
    {
        public int    GradeLevelID { get; set; }  // gradeLevelID - PK
        public string GradeName { get; set; } = string.Empty;  // gradeName
    }
}
