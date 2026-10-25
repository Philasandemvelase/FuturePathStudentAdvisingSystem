using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A degree offered by a faculty. Table: dbo.DegreeProgramme</summary>
    public class DegreeProgramme
    {
        public int    DegreeID { get; set; }  // degreeID - PK
        public int    FacultyID { get; set; }  // facultyID - FK -> Faculty
        public string DegreeName { get; set; } = string.Empty;  // degreeName
        public string Description { get; set; }  // description - optional
        public bool   IsActive { get; set; } = true;  // isActive
    }
}
