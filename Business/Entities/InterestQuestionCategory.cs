using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A group of interest questions, e.g. Numbers and Technology. Table: dbo.InterestQuestionCategory</summary>
    public class InterestQuestionCategory
    {
        public int    CategoryID { get; set; }  // categoryID - PK
        public string CategoryName { get; set; } = string.Empty;  // categoryName
        public string Description { get; set; }  // description - optional
    }
}
