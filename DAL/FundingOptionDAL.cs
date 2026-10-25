using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Bursaries, scholarships and other funding. Table: dbo.FundingOption</summary>
    public class FundingOptionDAL
    {
        private const string SelectSql =
            "SELECT fundingID, fundingName, fundingType, eligibilityDescription, requiredDocuments, closingDate, contactInfo, isActive " +
            "FROM dbo.FundingOption";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into funding.FundingID.</summary>
        public bool Add(FundingOption funding)
        {
            const string sql =
                "INSERT INTO dbo.FundingOption (fundingName, fundingType, eligibilityDescription, requiredDocuments, closingDate, contactInfo, isActive) " +
                "OUTPUT INSERTED.fundingID " +
                "VALUES (@fundingName, @fundingType, @eligibilityDescription, @requiredDocuments, @closingDate, @contactInfo, @isActive);";

            funding.FundingID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, funding));
            return funding.FundingID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(FundingOption funding)
        {
            const string sql =
                "UPDATE dbo.FundingOption " +
                "SET fundingName = @fundingName, fundingType = @fundingType, eligibilityDescription = @eligibilityDescription, requiredDocuments = @requiredDocuments, closingDate = @closingDate, contactInfo = @contactInfo, isActive = @isActive " +
                "WHERE fundingID = @fundingID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, funding);
                cmd.AddParameter("@fundingID", funding.FundingID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int fundingID)
        {
            const string sql = "DELETE FROM dbo.FundingOption WHERE fundingID = @fundingID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@fundingID", fundingID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public FundingOption GetByID(int fundingID)
        {
            return DbHelper.QuerySingle<FundingOption>(SelectSql + " WHERE fundingID = @fundingID;", Map,
                cmd => cmd.AddParameter("@fundingID", fundingID));
        }

        public List<FundingOption> GetAll()
        {
            return DbHelper.Query<FundingOption>(SelectSql + " ORDER BY fundingID;", Map);
        }

        /// <summary>Active funding whose closing date has not passed.</summary>
        public List<FundingOption> GetActive()
        {
            return DbHelper.Query<FundingOption>(SelectSql + " WHERE isActive = 1 AND (closingDate IS NULL OR closingDate >= CAST(GETDATE() AS DATE)) ORDER BY closingDate;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, FundingOption funding)
        {
            cmd.AddParameter("@fundingName", funding.FundingName);
            cmd.AddParameter("@fundingType", funding.FundingType);
            cmd.AddParameter("@eligibilityDescription", funding.EligibilityDescription);
            cmd.AddParameter("@requiredDocuments", funding.RequiredDocuments);
            cmd.AddParameter("@closingDate", funding.ClosingDate);
            cmd.AddParameter("@contactInfo", funding.ContactInfo);
            cmd.AddParameter("@isActive", funding.IsActive);
        }

        private static FundingOption Map(IDataRecord r)
        {
            return new FundingOption
            {
                FundingID = r.ReadInt("fundingID"),
                FundingName = r.ReadString("fundingName"),
                FundingType = r.ReadString("fundingType"),
                EligibilityDescription = r.ReadString("eligibilityDescription"),
                RequiredDocuments = r.ReadString("requiredDocuments"),
                ClosingDate = r.ReadNullableDateTime("closingDate"),
                ContactInfo = r.ReadString("contactInfo"),
                IsActive = r.ReadBool("isActive")
            };
        }
    }
}
