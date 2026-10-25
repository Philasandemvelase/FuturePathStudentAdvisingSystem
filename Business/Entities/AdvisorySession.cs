using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>One advising session for a learner. Table: dbo.AdvisorySession</summary>
    public class AdvisorySession
    {
        public int      SessionID { get; set; }  // sessionID - PK
        public int      LearnerID { get; set; }  // learnerID - FK -> Learner
        public int?     FacultyID { get; set; }  // facultyID - preferred faculty, optional
        public int?     DegreeID { get; set; }  // degreeID - degree asked about, optional
        public DateTime SessionDate { get; set; } = DateTime.Today;  // sessionDate - DATE column; defaults to today
        public bool     FundingRequested { get; set; }  // fundingRequested
    }
}
