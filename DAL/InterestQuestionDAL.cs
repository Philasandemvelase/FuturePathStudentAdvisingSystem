using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Interest questionnaire questions. Table: dbo.InterestQuestion</summary>
    public class InterestQuestionDAL
    {
        private const string SelectSql =
            "SELECT questionID, questionText, categoryID, isActive " +
            "FROM dbo.InterestQuestion";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into question.QuestionID.</summary>
        public bool Add(InterestQuestion question)
        {
            const string sql =
                "INSERT INTO dbo.InterestQuestion (questionText, categoryID, isActive) " +
                "OUTPUT INSERTED.questionID " +
                "VALUES (@questionText, @categoryID, @isActive);";

            question.QuestionID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, question));
            return question.QuestionID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(InterestQuestion question)
        {
            const string sql =
                "UPDATE dbo.InterestQuestion " +
                "SET questionText = @questionText, categoryID = @categoryID, isActive = @isActive " +
                "WHERE questionID = @questionID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, question);
                cmd.AddParameter("@questionID", question.QuestionID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int questionID)
        {
            const string sql = "DELETE FROM dbo.InterestQuestion WHERE questionID = @questionID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@questionID", questionID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public InterestQuestion GetByID(int questionID)
        {
            return DbHelper.QuerySingle<InterestQuestion>(SelectSql + " WHERE questionID = @questionID;", Map,
                cmd => cmd.AddParameter("@questionID", questionID));
        }

        public List<InterestQuestion> GetAll()
        {
            return DbHelper.Query<InterestQuestion>(SelectSql + " ORDER BY questionID;", Map);
        }

        /// <summary>Questions in one category.</summary>
        public List<InterestQuestion> GetByCategory(int categoryID)
        {
            return DbHelper.Query<InterestQuestion>(SelectSql + " WHERE categoryID = @categoryID ORDER BY questionID;", Map,
                cmd => cmd.AddParameter("@categoryID", categoryID));
        }

        /// <summary>Only questions that should appear on the questionnaire.</summary>
        public List<InterestQuestion> GetActive()
        {
            return DbHelper.Query<InterestQuestion>(SelectSql + " WHERE isActive = 1 ORDER BY questionID;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, InterestQuestion question)
        {
            cmd.AddParameter("@questionText", question.QuestionText);
            cmd.AddParameter("@categoryID", question.CategoryID);
            cmd.AddParameter("@isActive", question.IsActive);
        }

        private static InterestQuestion Map(IDataRecord r)
        {
            return new InterestQuestion
            {
                QuestionID = r.ReadInt("questionID"),
                QuestionText = r.ReadString("questionText"),
                CategoryID = r.ReadInt("categoryID"),
                IsActive = r.ReadBool("isActive")
            };
        }
    }
}
