using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A bursary, scholarship or other funding source. Table: dbo.FundingOption</summary>
    public class FundingOption
    {
        public int       FundingID { get; set; }  // fundingID - PK
        public string    FundingName { get; set; } = string.Empty;  // fundingName
        public string    FundingType { get; set; } = string.Empty;  // fundingType - See FundingTypes constants.
        public string    EligibilityDescription { get; set; }  // eligibilityDescription - optional
        public string    RequiredDocuments { get; set; }  // requiredDocuments - optional
        public DateTime? ClosingDate { get; set; }  // closingDate - optional
        public string    ContactInfo { get; set; }  // contactInfo - optional
        public bool      IsActive { get; set; } = true;  // isActive
    }
}
