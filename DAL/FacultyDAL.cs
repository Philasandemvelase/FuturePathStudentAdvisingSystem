using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>University faculties. Table: dbo.Faculty</summary>
    public class FacultyDAL
    {
        private const string SelectSql =
            "SELECT facultyID, facultyName " +
            "FROM dbo.Faculty";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into faculty.FacultyID.</summary>
        public bool Add(Faculty faculty)
        {
            const string sql =
                "INSERT INTO dbo.Faculty (facultyName) " +
                "OUTPUT INSERTED.facultyID " +
                "VALUES (@facultyName);";

            faculty.FacultyID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, faculty));
            return faculty.FacultyID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(Faculty faculty)
        {
            const string sql =
                "UPDATE dbo.Faculty " +
                "SET facultyName = @facultyName " +
                "WHERE facultyID = @facultyID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, faculty);
                cmd.AddParameter("@facultyID", faculty.FacultyID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int facultyID)
        {
            const string sql = "DELETE FROM dbo.Faculty WHERE facultyID = @facultyID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@facultyID", facultyID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public Faculty GetByID(int facultyID)
        {
            return DbHelper.QuerySingle<Faculty>(SelectSql + " WHERE facultyID = @facultyID;", Map,
                cmd => cmd.AddParameter("@facultyID", facultyID));
        }

        public List<Faculty> GetAll()
        {
            return DbHelper.Query<Faculty>(SelectSql + " ORDER BY facultyID;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, Faculty faculty)
        {
            cmd.AddParameter("@facultyName", faculty.FacultyName);
        }

        private static Faculty Map(IDataRecord r)
        {
            return new Faculty
            {
                FacultyID = r.ReadInt("facultyID"),
                FacultyName = r.ReadString("facultyName")
            };
        }
    }
}
