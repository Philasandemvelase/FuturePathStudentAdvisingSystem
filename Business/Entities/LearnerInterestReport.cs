using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A learner's answer to one interest question. Table: dbo.LearnerInterestReport</summary>
    public class LearnerInterestReport
    {
        public int ResponseID { get; set; }  // responseID - PK
        public int LearnerID { get; set; }  // learnerID - FK -> Learner
        public int QuestionID { get; set; }  // questionID - FK -> InterestQuestion
        public int SelectedOptionValue { get; set; }  // selectedOptionValue - 1..5 (stored as TINYINT)
    }
}
