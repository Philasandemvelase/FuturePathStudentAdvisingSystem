using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Which faculties a funding option supports. Table: dbo.FundingFaculty</summary>
    public class FundingFacultyDAL
    {
        private const string SelectSql =
            "SELECT fundingFacultyID, fundingID, facultyID " +
            "FROM dbo.FundingFaculty";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into fundingFaculty.FundingFacultyID.</summary>
        public bool Add(FundingFaculty fundingFaculty)
        {
            const string sql =
                "INSERT INTO dbo.FundingFaculty (fundingID, facultyID) " +
                "OUTPUT INSERTED.fundingFacultyID " +
                "VALUES (@fundingID, @facultyID);";

            fundingFaculty.FundingFacultyID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, fundingFaculty));
            return fundingFaculty.FundingFacultyID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(FundingFaculty fundingFaculty)
        {
            const string sql =
                "UPDATE dbo.FundingFaculty " +
                "SET fundingID = @fundingID, facultyID = @facultyID " +
                "WHERE fundingFacultyID = @fundingFacultyID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, fundingFaculty);
                cmd.AddParameter("@fundingFacultyID", fundingFaculty.FundingFacultyID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int fundingFacultyID)
        {
            const string sql = "DELETE FROM dbo.FundingFaculty WHERE fundingFacultyID = @fundingFacultyID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@fundingFacultyID", fundingFacultyID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public FundingFaculty GetByID(int fundingFacultyID)
        {
            return DbHelper.QuerySingle<FundingFaculty>(SelectSql + " WHERE fundingFacultyID = @fundingFacultyID;", Map,
                cmd => cmd.AddParameter("@fundingFacultyID", fundingFacultyID));
        }

        public List<FundingFaculty> GetAll()
        {
            return DbHelper.Query<FundingFaculty>(SelectSql + " ORDER BY fundingFacultyID;", Map);
        }

        /// <summary>Funding links for one faculty.</summary>
        public List<FundingFaculty> GetByFaculty(int facultyID)
        {
            return DbHelper.Query<FundingFaculty>(SelectSql + " WHERE facultyID = @facultyID ORDER BY fundingID;", Map,
                cmd => cmd.AddParameter("@facultyID", facultyID));
        }

        /// <summary>Faculty links for one funding option.</summary>
        public List<FundingFaculty> GetByFunding(int fundingID)
        {
            return DbHelper.Query<FundingFaculty>(SelectSql + " WHERE fundingID = @fundingID ORDER BY facultyID;", Map,
                cmd => cmd.AddParameter("@fundingID", fundingID));
        }

        private static void AddColumnParameters(SqlCommand cmd, FundingFaculty fundingFaculty)
        {
            cmd.AddParameter("@fundingID", fundingFaculty.FundingID);
            cmd.AddParameter("@facultyID", fundingFaculty.FacultyID);
        }

        private static FundingFaculty Map(IDataRecord r)
        {
            return new FundingFaculty
            {
                FundingFacultyID = r.ReadInt("fundingFacultyID"),
                FundingID = r.ReadInt("fundingID"),
                FacultyID = r.ReadInt("facultyID")
            };
        }
    }
}
