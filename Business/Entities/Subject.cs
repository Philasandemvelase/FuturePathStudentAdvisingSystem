using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A school (NSC) subject. Table: dbo.Subject</summary>
    public class Subject
    {
        public int    SubjectID { get; set; }  // subjectID - PK
        public string SubjectName { get; set; } = string.Empty;  // subjectName
    }
}
