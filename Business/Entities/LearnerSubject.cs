using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A subject a learner takes, with their mark. Table: dbo.LearnerSubject</summary>
    public class LearnerSubject
    {
        public int      LearnerSubjectID { get; set; }  // learnerSubjectID - PK
        public int      LearnerID { get; set; }  // learnerID - FK -> Learner
        public int      SubjectID { get; set; }  // subjectID - FK -> Subject
        public decimal? Mark { get; set; }  // mark - null = mark not supplied (More Information Needed)
    }
}
