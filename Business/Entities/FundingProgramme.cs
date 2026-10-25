using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>Links a funding option to a specific degree. Table: dbo.FundingProgramme</summary>
    public class FundingProgramme
    {
        public int FundingProgrammeID { get; set; }  // fundingProgrammeID - PK
        public int FundingID { get; set; }  // fundingID - FK -> FundingOption
        public int DegreeID { get; set; }  // degreeID - FK -> DegreeProgramme
    }
}
