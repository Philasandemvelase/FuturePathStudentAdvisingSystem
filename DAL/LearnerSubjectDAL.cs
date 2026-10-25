using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Learner subjects and marks (mark null = not supplied). Table: dbo.LearnerSubject</summary>
    public class LearnerSubjectDAL
    {
        private const string SelectSql =
            "SELECT learnerSubjectID, learnerID, subjectID, mark " +
            "FROM dbo.LearnerSubject";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into learnerSubject.LearnerSubjectID.</summary>
        public bool Add(LearnerSubject learnerSubject)
        {
            const string sql =
                "INSERT INTO dbo.LearnerSubject (learnerID, subjectID, mark) " +
                "OUTPUT INSERTED.learnerSubjectID " +
                "VALUES (@learnerID, @subjectID, @mark);";

            learnerSubject.LearnerSubjectID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, learnerSubject));
            return learnerSubject.LearnerSubjectID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(LearnerSubject learnerSubject)
        {
            const string sql =
                "UPDATE dbo.LearnerSubject " +
                "SET learnerID = @learnerID, subjectID = @subjectID, mark = @mark " +
                "WHERE learnerSubjectID = @learnerSubjectID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, learnerSubject);
                cmd.AddParameter("@learnerSubjectID", learnerSubject.LearnerSubjectID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int learnerSubjectID)
        {
            const string sql = "DELETE FROM dbo.LearnerSubject WHERE learnerSubjectID = @learnerSubjectID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@learnerSubjectID", learnerSubjectID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public LearnerSubject GetByID(int learnerSubjectID)
        {
            return DbHelper.QuerySingle<LearnerSubject>(SelectSql + " WHERE learnerSubjectID = @learnerSubjectID;", Map,
                cmd => cmd.AddParameter("@learnerSubjectID", learnerSubjectID));
        }

        public List<LearnerSubject> GetAll()
        {
            return DbHelper.Query<LearnerSubject>(SelectSql + " ORDER BY learnerSubjectID;", Map);
        }

        /// <summary>All of one learner's subjects and marks.</summary>
        public List<LearnerSubject> GetByLearner(int learnerID)
        {
            return DbHelper.Query<LearnerSubject>(SelectSql + " WHERE learnerID = @learnerID ORDER BY subjectID;", Map,
                cmd => cmd.AddParameter("@learnerID", learnerID));
        }

        private static void AddColumnParameters(SqlCommand cmd, LearnerSubject learnerSubject)
        {
            cmd.AddParameter("@learnerID", learnerSubject.LearnerID);
            cmd.AddParameter("@subjectID", learnerSubject.SubjectID);
            cmd.AddParameter("@mark", learnerSubject.Mark);
        }

        private static LearnerSubject Map(IDataRecord r)
        {
            return new LearnerSubject
            {
                LearnerSubjectID = r.ReadInt("learnerSubjectID"),
                LearnerID = r.ReadInt("learnerID"),
                SubjectID = r.ReadInt("subjectID"),
                Mark = r.ReadNullableDecimal("mark")
            };
        }
    }
}
