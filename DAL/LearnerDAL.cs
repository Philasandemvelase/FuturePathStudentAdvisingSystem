using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Learners. Table: dbo.Learner</summary>
    public class LearnerDAL
    {
        private const string SelectSql =
            "SELECT learnerID, fullName, gradeLevelID, schoolName, province, contactDetails " +
            "FROM dbo.Learner";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into learner.LearnerID.</summary>
        public bool Add(Learner learner)
        {
            const string sql =
                "INSERT INTO dbo.Learner (fullName, gradeLevelID, schoolName, province, contactDetails) " +
                "OUTPUT INSERTED.learnerID " +
                "VALUES (@fullName, @gradeLevelID, @schoolName, @province, @contactDetails);";

            learner.LearnerID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, learner));
            return learner.LearnerID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(Learner learner)
        {
            const string sql =
                "UPDATE dbo.Learner " +
                "SET fullName = @fullName, gradeLevelID = @gradeLevelID, schoolName = @schoolName, province = @province, contactDetails = @contactDetails " +
                "WHERE learnerID = @learnerID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, learner);
                cmd.AddParameter("@learnerID", learner.LearnerID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int learnerID)
        {
            const string sql = "DELETE FROM dbo.Learner WHERE learnerID = @learnerID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@learnerID", learnerID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public Learner GetByID(int learnerID)
        {
            return DbHelper.QuerySingle<Learner>(SelectSql + " WHERE learnerID = @learnerID;", Map,
                cmd => cmd.AddParameter("@learnerID", learnerID));
        }

        public List<Learner> GetAll()
        {
            return DbHelper.Query<Learner>(SelectSql + " ORDER BY learnerID;", Map);
        }

        /// <summary>Learners whose name contains the given text.</summary>
        public List<Learner> SearchByName(string fullName)
        {
            return DbHelper.Query<Learner>(SelectSql + " WHERE fullName LIKE '%' + @fullName + '%' ORDER BY fullName;", Map,
                cmd => cmd.AddParameter("@fullName", fullName));
        }

        private static void AddColumnParameters(SqlCommand cmd, Learner learner)
        {
            cmd.AddParameter("@fullName", learner.FullName);
            cmd.AddParameter("@gradeLevelID", learner.GradeLevelID);
            cmd.AddParameter("@schoolName", learner.SchoolName);
            cmd.AddParameter("@province", learner.Province);
            cmd.AddParameter("@contactDetails", learner.ContactDetails);
        }

        private static Learner Map(IDataRecord r)
        {
            return new Learner
            {
                LearnerID = r.ReadInt("learnerID"),
                FullName = r.ReadString("fullName"),
                GradeLevelID = r.ReadInt("gradeLevelID"),
                SchoolName = r.ReadString("schoolName"),
                Province = r.ReadString("province"),
                ContactDetails = r.ReadString("contactDetails")
            };
        }
    }
}
