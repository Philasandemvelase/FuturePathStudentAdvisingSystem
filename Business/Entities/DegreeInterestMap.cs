using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>How strongly an interest category fits a degree. Table: dbo.DegreeInterestMap</summary>
    public class DegreeInterestMap
    {
        public int     MappingID { get; set; }  // mappingID - PK
        public int     DegreeID { get; set; }  // degreeID - FK -> DegreeProgramme
        public int     CategoryID { get; set; }  // categoryID - FK -> InterestQuestionCategory
        public decimal WeightedScore { get; set; }  // weightedScore - 0.00 .. 1.00
    }
}
