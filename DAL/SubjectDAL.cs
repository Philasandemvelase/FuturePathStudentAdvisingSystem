using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>School subjects. Table: dbo.Subject</summary>
    public class SubjectDAL
    {
        private const string SelectSql =
            "SELECT subjectID, subjectName " +
            "FROM dbo.Subject";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into subject.SubjectID.</summary>
        public bool Add(Subject subject)
        {
            const string sql =
                "INSERT INTO dbo.Subject (subjectName) " +
                "OUTPUT INSERTED.subjectID " +
                "VALUES (@subjectName);";

            subject.SubjectID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, subject));
            return subject.SubjectID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(Subject subject)
        {
            const string sql =
                "UPDATE dbo.Subject " +
                "SET subjectName = @subjectName " +
                "WHERE subjectID = @subjectID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, subject);
                cmd.AddParameter("@subjectID", subject.SubjectID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int subjectID)
        {
            const string sql = "DELETE FROM dbo.Subject WHERE subjectID = @subjectID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@subjectID", subjectID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public Subject GetByID(int subjectID)
        {
            return DbHelper.QuerySingle<Subject>(SelectSql + " WHERE subjectID = @subjectID;", Map,
                cmd => cmd.AddParameter("@subjectID", subjectID));
        }

        public List<Subject> GetAll()
        {
            return DbHelper.Query<Subject>(SelectSql + " ORDER BY subjectID;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, Subject subject)
        {
            cmd.AddParameter("@subjectName", subject.SubjectName);
        }

        private static Subject Map(IDataRecord r)
        {
            return new Subject
            {
                SubjectID = r.ReadInt("subjectID"),
                SubjectName = r.ReadString("subjectName")
            };
        }
    }
}
