using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>Links a funding option to a faculty it supports. Table: dbo.FundingFaculty</summary>
    public class FundingFaculty
    {
        public int FundingFacultyID { get; set; }  // fundingFacultyID - PK
        public int FundingID { get; set; }  // fundingID - FK -> FundingOption
        public int FacultyID { get; set; }  // facultyID - FK -> Faculty
    }
}
