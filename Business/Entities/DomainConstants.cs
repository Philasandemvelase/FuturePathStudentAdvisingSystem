namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    // These strings must match the CHECK constraints in Database\02_CreateTables.sql exactly.
    // Use them instead of typing the text by hand, e.g. user.Role == Roles.Administrator

    public static class Roles
    {
        public const string Administrator = "Administrator";
        public const string CareerAdvisor = "Career Advisor";
    }

    public static class AdvisoryOutcomes
    {
        public const string StrongMatch = "Strong Match";
        public const string PossibleMatch = "Possible Match";
        public const string NotCurrentlyEligible = "Not Currently Eligible";
        public const string MoreInformationNeeded = "More Information Needed";
    }

    public static class FundingTypes
    {
        public const string Scholarship = "Scholarship";
        public const string Bursary = "Bursary";
        public const string FinancialAid = "Financial Aid";
        public const string ExternalFunding = "External Funding";
    }

    public static class ReportFormats
    {
        public const string Pdf = "PDF";
        public const string Txt = "TXT";
    }
}
