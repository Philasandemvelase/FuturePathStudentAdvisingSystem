using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Scored degree recommendations per session. Table: dbo.RecommendationResult</summary>
    public class RecommendationResultDAL
    {
        private const string SelectSql =
            "SELECT resultID, sessionID, degreeID, subjectMatchScore, markMatchScore, interestMatchScore, facultyPreference, overallScore, advisoryOutcome, gapDescription " +
            "FROM dbo.RecommendationResult";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into result.ResultID.</summary>
        public bool Add(RecommendationResult result)
        {
            const string sql =
                "INSERT INTO dbo.RecommendationResult (sessionID, degreeID, subjectMatchScore, markMatchScore, interestMatchScore, facultyPreference, overallScore, advisoryOutcome, gapDescription) " +
                "OUTPUT INSERTED.resultID " +
                "VALUES (@sessionID, @degreeID, @subjectMatchScore, @markMatchScore, @interestMatchScore, @facultyPreference, @overallScore, @advisoryOutcome, @gapDescription);";

            result.ResultID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, result));
            return result.ResultID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(RecommendationResult result)
        {
            const string sql =
                "UPDATE dbo.RecommendationResult " +
                "SET sessionID = @sessionID, degreeID = @degreeID, subjectMatchScore = @subjectMatchScore, markMatchScore = @markMatchScore, interestMatchScore = @interestMatchScore, facultyPreference = @facultyPreference, overallScore = @overallScore, advisoryOutcome = @advisoryOutcome, gapDescription = @gapDescription " +
                "WHERE resultID = @resultID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, result);
                cmd.AddParameter("@resultID", result.ResultID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int resultID)
        {
            const string sql = "DELETE FROM dbo.RecommendationResult WHERE resultID = @resultID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@resultID", resultID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public RecommendationResult GetByID(int resultID)
        {
            return DbHelper.QuerySingle<RecommendationResult>(SelectSql + " WHERE resultID = @resultID;", Map,
                cmd => cmd.AddParameter("@resultID", resultID));
        }

        public List<RecommendationResult> GetAll()
        {
            return DbHelper.Query<RecommendationResult>(SelectSql + " ORDER BY resultID;", Map);
        }

        /// <summary>One session's recommendations, best score first.</summary>
        public List<RecommendationResult> GetBySession(int sessionID)
        {
            return DbHelper.Query<RecommendationResult>(SelectSql + " WHERE sessionID = @sessionID ORDER BY overallScore DESC;", Map,
                cmd => cmd.AddParameter("@sessionID", sessionID));
        }

        private static void AddColumnParameters(SqlCommand cmd, RecommendationResult result)
        {
            cmd.AddParameter("@sessionID", result.SessionID);
            cmd.AddParameter("@degreeID", result.DegreeID);
            cmd.AddParameter("@subjectMatchScore", result.SubjectMatchScore);
            cmd.AddParameter("@markMatchScore", result.MarkMatchScore);
            cmd.AddParameter("@interestMatchScore", result.InterestMatchScore);
            cmd.AddParameter("@facultyPreference", result.FacultyPreference);
            cmd.AddParameter("@overallScore", result.OverallScore);
            cmd.AddParameter("@advisoryOutcome", result.AdvisoryOutcome);
            cmd.AddParameter("@gapDescription", result.GapDescription);
        }

        private static RecommendationResult Map(IDataRecord r)
        {
            return new RecommendationResult
            {
                ResultID = r.ReadInt("resultID"),
                SessionID = r.ReadInt("sessionID"),
                DegreeID = r.ReadInt("degreeID"),
                SubjectMatchScore = r.ReadNullableDecimal("subjectMatchScore"),
                MarkMatchScore = r.ReadNullableDecimal("markMatchScore"),
                InterestMatchScore = r.ReadNullableDecimal("interestMatchScore"),
                FacultyPreference = r.ReadNullableDecimal("facultyPreference"),
                OverallScore = r.ReadNullableDecimal("overallScore"),
                AdvisoryOutcome = r.ReadString("advisoryOutcome"),
                GapDescription = r.ReadString("gapDescription")
            };
        }
    }
}
