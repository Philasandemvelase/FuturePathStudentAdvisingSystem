using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Advisory sessions. Table: dbo.AdvisorySession</summary>
    public class AdvisorySessionDAL
    {
        private const string SelectSql =
            "SELECT sessionID, learnerID, facultyID, degreeID, sessionDate, fundingRequested " +
            "FROM dbo.AdvisorySession";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into session.SessionID.</summary>
        public bool Add(AdvisorySession session)
        {
            const string sql =
                "INSERT INTO dbo.AdvisorySession (learnerID, facultyID, degreeID, sessionDate, fundingRequested) " +
                "OUTPUT INSERTED.sessionID " +
                "VALUES (@learnerID, @facultyID, @degreeID, @sessionDate, @fundingRequested);";

            session.SessionID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, session));
            return session.SessionID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(AdvisorySession session)
        {
            const string sql =
                "UPDATE dbo.AdvisorySession " +
                "SET learnerID = @learnerID, facultyID = @facultyID, degreeID = @degreeID, sessionDate = @sessionDate, fundingRequested = @fundingRequested " +
                "WHERE sessionID = @sessionID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, session);
                cmd.AddParameter("@sessionID", session.SessionID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int sessionID)
        {
            const string sql = "DELETE FROM dbo.AdvisorySession WHERE sessionID = @sessionID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@sessionID", sessionID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public AdvisorySession GetByID(int sessionID)
        {
            return DbHelper.QuerySingle<AdvisorySession>(SelectSql + " WHERE sessionID = @sessionID;", Map,
                cmd => cmd.AddParameter("@sessionID", sessionID));
        }

        public List<AdvisorySession> GetAll()
        {
            return DbHelper.Query<AdvisorySession>(SelectSql + " ORDER BY sessionID;", Map);
        }

        /// <summary>One learner's sessions, newest first.</summary>
        public List<AdvisorySession> GetByLearner(int learnerID)
        {
            return DbHelper.Query<AdvisorySession>(SelectSql + " WHERE learnerID = @learnerID ORDER BY sessionDate DESC;", Map,
                cmd => cmd.AddParameter("@learnerID", learnerID));
        }

        private static void AddColumnParameters(SqlCommand cmd, AdvisorySession session)
        {
            cmd.AddParameter("@learnerID", session.LearnerID);
            cmd.AddParameter("@facultyID", session.FacultyID);
            cmd.AddParameter("@degreeID", session.DegreeID);
            cmd.AddParameter("@sessionDate", session.SessionDate);
            cmd.AddParameter("@fundingRequested", session.FundingRequested);
        }

        private static AdvisorySession Map(IDataRecord r)
        {
            return new AdvisorySession
            {
                SessionID = r.ReadInt("sessionID"),
                LearnerID = r.ReadInt("learnerID"),
                FacultyID = r.ReadNullableInt("facultyID"),
                DegreeID = r.ReadNullableInt("degreeID"),
                SessionDate = r.ReadDateTime("sessionDate"),
                FundingRequested = r.ReadBool("fundingRequested")
            };
        }
    }
}
