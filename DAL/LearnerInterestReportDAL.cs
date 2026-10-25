using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Learner answers (1..5) to interest questions. Table: dbo.LearnerInterestReport</summary>
    public class LearnerInterestReportDAL
    {
        private const string SelectSql =
            "SELECT responseID, learnerID, questionID, selectedOptionValue " +
            "FROM dbo.LearnerInterestReport";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into report.ResponseID.</summary>
        public bool Add(LearnerInterestReport report)
        {
            const string sql =
                "INSERT INTO dbo.LearnerInterestReport (learnerID, questionID, selectedOptionValue) " +
                "OUTPUT INSERTED.responseID " +
                "VALUES (@learnerID, @questionID, @selectedOptionValue);";

            report.ResponseID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, report));
            return report.ResponseID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(LearnerInterestReport report)
        {
            const string sql =
                "UPDATE dbo.LearnerInterestReport " +
                "SET learnerID = @learnerID, questionID = @questionID, selectedOptionValue = @selectedOptionValue " +
                "WHERE responseID = @responseID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, report);
                cmd.AddParameter("@responseID", report.ResponseID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int responseID)
        {
            const string sql = "DELETE FROM dbo.LearnerInterestReport WHERE responseID = @responseID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@responseID", responseID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public LearnerInterestReport GetByID(int responseID)
        {
            return DbHelper.QuerySingle<LearnerInterestReport>(SelectSql + " WHERE responseID = @responseID;", Map,
                cmd => cmd.AddParameter("@responseID", responseID));
        }

        public List<LearnerInterestReport> GetAll()
        {
            return DbHelper.Query<LearnerInterestReport>(SelectSql + " ORDER BY responseID;", Map);
        }

        /// <summary>All of one learner's questionnaire answers.</summary>
        public List<LearnerInterestReport> GetByLearner(int learnerID)
        {
            return DbHelper.Query<LearnerInterestReport>(SelectSql + " WHERE learnerID = @learnerID ORDER BY questionID;", Map,
                cmd => cmd.AddParameter("@learnerID", learnerID));
        }

        private static void AddColumnParameters(SqlCommand cmd, LearnerInterestReport report)
        {
            cmd.AddParameter("@learnerID", report.LearnerID);
            cmd.AddParameter("@questionID", report.QuestionID);
            cmd.AddParameter("@selectedOptionValue", report.SelectedOptionValue);
        }

        private static LearnerInterestReport Map(IDataRecord r)
        {
            return new LearnerInterestReport
            {
                ResponseID = r.ReadInt("responseID"),
                LearnerID = r.ReadInt("learnerID"),
                QuestionID = r.ReadInt("questionID"),
                SelectedOptionValue = r.ReadInt("selectedOptionValue")
            };
        }
    }
}
