using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Interest question categories. Table: dbo.InterestQuestionCategory</summary>
    public class InterestQuestionCategoryDAL
    {
        private const string SelectSql =
            "SELECT categoryID, categoryName, description " +
            "FROM dbo.InterestQuestionCategory";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into category.CategoryID.</summary>
        public bool Add(InterestQuestionCategory category)
        {
            const string sql =
                "INSERT INTO dbo.InterestQuestionCategory (categoryName, description) " +
                "OUTPUT INSERTED.categoryID " +
                "VALUES (@categoryName, @description);";

            category.CategoryID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, category));
            return category.CategoryID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(InterestQuestionCategory category)
        {
            const string sql =
                "UPDATE dbo.InterestQuestionCategory " +
                "SET categoryName = @categoryName, description = @description " +
                "WHERE categoryID = @categoryID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, category);
                cmd.AddParameter("@categoryID", category.CategoryID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int categoryID)
        {
            const string sql = "DELETE FROM dbo.InterestQuestionCategory WHERE categoryID = @categoryID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@categoryID", categoryID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public InterestQuestionCategory GetByID(int categoryID)
        {
            return DbHelper.QuerySingle<InterestQuestionCategory>(SelectSql + " WHERE categoryID = @categoryID;", Map,
                cmd => cmd.AddParameter("@categoryID", categoryID));
        }

        public List<InterestQuestionCategory> GetAll()
        {
            return DbHelper.Query<InterestQuestionCategory>(SelectSql + " ORDER BY categoryID;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, InterestQuestionCategory category)
        {
            cmd.AddParameter("@categoryName", category.CategoryName);
            cmd.AddParameter("@description", category.Description);
        }

        private static InterestQuestionCategory Map(IDataRecord r)
        {
            return new InterestQuestionCategory
            {
                CategoryID = r.ReadInt("categoryID"),
                CategoryName = r.ReadString("categoryName"),
                Description = r.ReadString("description")
            };
        }
    }
}
