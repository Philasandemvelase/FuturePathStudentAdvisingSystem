using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A Likert-scale interest question. Table: dbo.InterestQuestion</summary>
    public class InterestQuestion
    {
        public int    QuestionID { get; set; }  // questionID - PK
        public int    CategoryID { get; set; }  // categoryID - FK -> InterestQuestionCategory
        public string QuestionText { get; set; } = string.Empty;  // questionText
        public bool   IsActive { get; set; } = true;  // isActive
    }
}
