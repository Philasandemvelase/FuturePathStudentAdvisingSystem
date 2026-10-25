using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>Scored recommendation of one degree for one session. Table: dbo.RecommendationResult</summary>
    public class RecommendationResult
    {
        public int      ResultID { get; set; }  // resultID - PK
        public int      SessionID { get; set; }  // sessionID - FK -> AdvisorySession
        public int      DegreeID { get; set; }  // degreeID - FK -> DegreeProgramme
        public decimal? SubjectMatchScore { get; set; }  // subjectMatchScore - 0..100
        public decimal? MarkMatchScore { get; set; }  // markMatchScore - 0..100
        public decimal? InterestMatchScore { get; set; }  // interestMatchScore - 0..100
        public decimal? FacultyPreference { get; set; }  // facultyPreference - 0..100
        public decimal? OverallScore { get; set; }  // overallScore - null when assessment could not be completed
        public string   AdvisoryOutcome { get; set; } = string.Empty;  // advisoryOutcome - See AdvisoryOutcomes constants.
        public string   GapDescription { get; set; }  // gapDescription - optional
    }
}
