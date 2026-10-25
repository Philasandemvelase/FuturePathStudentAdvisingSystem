using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Which specific degrees a funding option supports. Table: dbo.FundingProgramme</summary>
    public class FundingProgrammeDAL
    {
        private const string SelectSql =
            "SELECT fundingProgrammeID, fundingID, degreeID " +
            "FROM dbo.FundingProgramme";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into fundingProgramme.FundingProgrammeID.</summary>
        public bool Add(FundingProgramme fundingProgramme)
        {
            const string sql =
                "INSERT INTO dbo.FundingProgramme (fundingID, degreeID) " +
                "OUTPUT INSERTED.fundingProgrammeID " +
                "VALUES (@fundingID, @degreeID);";

            fundingProgramme.FundingProgrammeID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, fundingProgramme));
            return fundingProgramme.FundingProgrammeID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(FundingProgramme fundingProgramme)
        {
            const string sql =
                "UPDATE dbo.FundingProgramme " +
                "SET fundingID = @fundingID, degreeID = @degreeID " +
                "WHERE fundingProgrammeID = @fundingProgrammeID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, fundingProgramme);
                cmd.AddParameter("@fundingProgrammeID", fundingProgramme.FundingProgrammeID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int fundingProgrammeID)
        {
            const string sql = "DELETE FROM dbo.FundingProgramme WHERE fundingProgrammeID = @fundingProgrammeID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@fundingProgrammeID", fundingProgrammeID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public FundingProgramme GetByID(int fundingProgrammeID)
        {
            return DbHelper.QuerySingle<FundingProgramme>(SelectSql + " WHERE fundingProgrammeID = @fundingProgrammeID;", Map,
                cmd => cmd.AddParameter("@fundingProgrammeID", fundingProgrammeID));
        }

        public List<FundingProgramme> GetAll()
        {
            return DbHelper.Query<FundingProgramme>(SelectSql + " ORDER BY fundingProgrammeID;", Map);
        }

        /// <summary>Funding links for one degree.</summary>
        public List<FundingProgramme> GetByDegree(int degreeID)
        {
            return DbHelper.Query<FundingProgramme>(SelectSql + " WHERE degreeID = @degreeID ORDER BY fundingID;", Map,
                cmd => cmd.AddParameter("@degreeID", degreeID));
        }

        private static void AddColumnParameters(SqlCommand cmd, FundingProgramme fundingProgramme)
        {
            cmd.AddParameter("@fundingID", fundingProgramme.FundingID);
            cmd.AddParameter("@degreeID", fundingProgramme.DegreeID);
        }

        private static FundingProgramme Map(IDataRecord r)
        {
            return new FundingProgramme
            {
                FundingProgrammeID = r.ReadInt("fundingProgrammeID"),
                FundingID = r.ReadInt("fundingID"),
                DegreeID = r.ReadInt("degreeID")
            };
        }
    }
}
