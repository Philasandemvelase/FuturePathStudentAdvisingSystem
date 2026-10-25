using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Degree programmes. Table: dbo.DegreeProgramme</summary>
    public class DegreeProgrammeDAL
    {
        private const string SelectSql =
            "SELECT degreeID, facultyID, degreeName, description, isActive " +
            "FROM dbo.DegreeProgramme";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into programme.DegreeID.</summary>
        public bool Add(DegreeProgramme programme)
        {
            const string sql =
                "INSERT INTO dbo.DegreeProgramme (facultyID, degreeName, description, isActive) " +
                "OUTPUT INSERTED.degreeID " +
                "VALUES (@facultyID, @degreeName, @description, @isActive);";

            programme.DegreeID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, programme));
            return programme.DegreeID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(DegreeProgramme programme)
        {
            const string sql =
                "UPDATE dbo.DegreeProgramme " +
                "SET facultyID = @facultyID, degreeName = @degreeName, description = @description, isActive = @isActive " +
                "WHERE degreeID = @degreeID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, programme);
                cmd.AddParameter("@degreeID", programme.DegreeID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int degreeID)
        {
            const string sql = "DELETE FROM dbo.DegreeProgramme WHERE degreeID = @degreeID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@degreeID", degreeID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public DegreeProgramme GetByID(int degreeID)
        {
            return DbHelper.QuerySingle<DegreeProgramme>(SelectSql + " WHERE degreeID = @degreeID;", Map,
                cmd => cmd.AddParameter("@degreeID", degreeID));
        }

        public List<DegreeProgramme> GetAll()
        {
            return DbHelper.Query<DegreeProgramme>(SelectSql + " ORDER BY degreeID;", Map);
        }

        /// <summary>Degrees offered by one faculty.</summary>
        public List<DegreeProgramme> GetByFaculty(int facultyID)
        {
            return DbHelper.Query<DegreeProgramme>(SelectSql + " WHERE facultyID = @facultyID ORDER BY degreeName;", Map,
                cmd => cmd.AddParameter("@facultyID", facultyID));
        }

        /// <summary>Only degrees currently offered.</summary>
        public List<DegreeProgramme> GetActive()
        {
            return DbHelper.Query<DegreeProgramme>(SelectSql + " WHERE isActive = 1 ORDER BY degreeName;", Map);
        }

        private static void AddColumnParameters(SqlCommand cmd, DegreeProgramme programme)
        {
            cmd.AddParameter("@facultyID", programme.FacultyID);
            cmd.AddParameter("@degreeName", programme.DegreeName);
            cmd.AddParameter("@description", programme.Description);
            cmd.AddParameter("@isActive", programme.IsActive);
        }

        private static DegreeProgramme Map(IDataRecord r)
        {
            return new DegreeProgramme
            {
                DegreeID = r.ReadInt("degreeID"),
                FacultyID = r.ReadInt("facultyID"),
                DegreeName = r.ReadString("degreeName"),
                Description = r.ReadString("description"),
                IsActive = r.ReadBool("isActive")
            };
        }
    }
}
