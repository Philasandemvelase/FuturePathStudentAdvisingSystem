using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Subject/mark entry requirements per degree. Table: dbo.ProgrammeRequirements</summary>
    public class ProgrammeRequirementDAL
    {
        private const string SelectSql =
            "SELECT requirementID, degreeID, subjectID, minimumMark, isRequired, acceptedAlternativeSubjectID, minimumOverallAverage, requirementType, notes " +
            "FROM dbo.ProgrammeRequirements";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into requirement.RequirementID.</summary>
        public bool Add(ProgrammeRequirement requirement)
        {
            const string sql =
                "INSERT INTO dbo.ProgrammeRequirements (degreeID, subjectID, minimumMark, isRequired, acceptedAlternativeSubjectID, minimumOverallAverage, requirementType, notes) " +
                "OUTPUT INSERTED.requirementID " +
                "VALUES (@degreeID, @subjectID, @minimumMark, @isRequired, @acceptedAlternativeSubjectID, @minimumOverallAverage, @requirementType, @notes);";

            requirement.RequirementID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, requirement));
            return requirement.RequirementID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(ProgrammeRequirement requirement)
        {
            const string sql =
                "UPDATE dbo.ProgrammeRequirements " +
                "SET degreeID = @degreeID, subjectID = @subjectID, minimumMark = @minimumMark, isRequired = @isRequired, acceptedAlternativeSubjectID = @acceptedAlternativeSubjectID, minimumOverallAverage = @minimumOverallAverage, requirementType = @requirementType, notes = @notes " +
                "WHERE requirementID = @requirementID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, requirement);
                cmd.AddParameter("@requirementID", requirement.RequirementID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int requirementID)
        {
            const string sql = "DELETE FROM dbo.ProgrammeRequirements WHERE requirementID = @requirementID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@requirementID", requirementID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public ProgrammeRequirement GetByID(int requirementID)
        {
            return DbHelper.QuerySingle<ProgrammeRequirement>(SelectSql + " WHERE requirementID = @requirementID;", Map,
                cmd => cmd.AddParameter("@requirementID", requirementID));
        }

        public List<ProgrammeRequirement> GetAll()
        {
            return DbHelper.Query<ProgrammeRequirement>(SelectSql + " ORDER BY requirementID;", Map);
        }

        /// <summary>All entry requirements for one degree.</summary>
        public List<ProgrammeRequirement> GetByDegree(int degreeID)
        {
            return DbHelper.Query<ProgrammeRequirement>(SelectSql + " WHERE degreeID = @degreeID ORDER BY subjectID;", Map,
                cmd => cmd.AddParameter("@degreeID", degreeID));
        }

        private static void AddColumnParameters(SqlCommand cmd, ProgrammeRequirement requirement)
        {
            cmd.AddParameter("@degreeID", requirement.DegreeID);
            cmd.AddParameter("@subjectID", requirement.SubjectID);
            cmd.AddParameter("@minimumMark", requirement.MinimumMark);
            cmd.AddParameter("@isRequired", requirement.IsRequired);
            cmd.AddParameter("@acceptedAlternativeSubjectID", requirement.AcceptedAlternativeSubjectID);
            cmd.AddParameter("@minimumOverallAverage", requirement.MinimumOverallAverage);
            cmd.AddParameter("@requirementType", requirement.RequirementType);
            cmd.AddParameter("@notes", requirement.Notes);
        }

        private static ProgrammeRequirement Map(IDataRecord r)
        {
            return new ProgrammeRequirement
            {
                RequirementID = r.ReadInt("requirementID"),
                DegreeID = r.ReadInt("degreeID"),
                SubjectID = r.ReadInt("subjectID"),
                MinimumMark = r.ReadDecimal("minimumMark"),
                IsRequired = r.ReadBool("isRequired"),
                AcceptedAlternativeSubjectID = r.ReadNullableInt("acceptedAlternativeSubjectID"),
                MinimumOverallAverage = r.ReadNullableDecimal("minimumOverallAverage"),
                RequirementType = r.ReadString("requirementType"),
                Notes = r.ReadString("notes")
            };
        }
    }
}
