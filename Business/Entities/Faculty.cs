using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A university faculty, e.g. Commerce, Science. Table: dbo.Faculty</summary>
    public class Faculty
    {
        public int    FacultyID { get; set; }  // facultyID - PK
        public string FacultyName { get; set; } = string.Empty;  // facultyName
    }
}
