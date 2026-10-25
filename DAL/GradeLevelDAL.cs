using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Grade 11 / Grade 12 lookup. Table: dbo.GradeLevel</summary>
    public class GradeLevelDAL
    {
        private const string SelectSql =
            "SELECT gradeLevelID, gradeName " +
            "FROM dbo.GradeLevel";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into gradeLevel.GradeLevelID.</summary>
        public bool Add(GradeLevel gradeLevel)
        {
            const string sql =
                "INSERT INTO dbo.GradeLevel (gradeName) " +
                "OUTPUT INSERTED.gradeLevelID " +
                "VALUES (@gradeName);";

            gradeLevel.GradeLevelID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, gradeLevel));
            return gradeLevel.GradeLevelID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(GradeLevel gradeLevel)
        {
            const string sql =
                "UPDATE dbo.GradeLevel " +
                "SET gradeName = @gradeName " +
                "WHERE gradeLevelID = @gradeLevelID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, gradeLevel);
                cmd.AddParameter("@gradeLevelID", gradeLevel.GradeLevelID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int gradeLevelID)
        {
            const string sql = "DELETE FROM dbo.GradeLevel WHERE gradeLevelID = @gradeLevelID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@gradeLevelID", gradeLevelID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public GradeLevel GetByID(int gradeLevelID)
        {
            return DbHelper.QuerySingle<GradeLevel>(SelectSql + " WHERE gradeLevelID = @gradeLevelID;", Map,
                cmd => cmd.AddParameter("@gradeLevelID", gradeLevelID));
        }

        public List<GradeLevel> GetAll()
        {
            return DbHelper.Query<GradeLevel>(SelectSql + " ORDER BY gradeLevelID;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, GradeLevel gradeLevel)
        {
            cmd.AddParameter("@gradeName", gradeLevel.GradeName);
        }

        private static GradeLevel Map(IDataRecord r)
        {
            return new GradeLevel
            {
                GradeLevelID = r.ReadInt("gradeLevelID"),
                GradeName = r.ReadString("gradeName")
            };
        }
    }
}
