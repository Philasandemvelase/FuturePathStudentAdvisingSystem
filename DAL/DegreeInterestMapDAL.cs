using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>How strongly each interest category fits a degree. Table: dbo.DegreeInterestMap</summary>
    public class DegreeInterestMapDAL
    {
        private const string SelectSql =
            "SELECT mappingID, degreeID, categoryID, weightedScore " +
            "FROM dbo.DegreeInterestMap";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into map.MappingID.</summary>
        public bool Add(DegreeInterestMap map)
        {
            const string sql =
                "INSERT INTO dbo.DegreeInterestMap (degreeID, categoryID, weightedScore) " +
                "OUTPUT INSERTED.mappingID " +
                "VALUES (@degreeID, @categoryID, @weightedScore);";

            map.MappingID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, map));
            return map.MappingID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(DegreeInterestMap map)
        {
            const string sql =
                "UPDATE dbo.DegreeInterestMap " +
                "SET degreeID = @degreeID, categoryID = @categoryID, weightedScore = @weightedScore " +
                "WHERE mappingID = @mappingID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, map);
                cmd.AddParameter("@mappingID", map.MappingID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int mappingID)
        {
            const string sql = "DELETE FROM dbo.DegreeInterestMap WHERE mappingID = @mappingID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@mappingID", mappingID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public DegreeInterestMap GetByID(int mappingID)
        {
            return DbHelper.QuerySingle<DegreeInterestMap>(SelectSql + " WHERE mappingID = @mappingID;", Map,
                cmd => cmd.AddParameter("@mappingID", mappingID));
        }

        public List<DegreeInterestMap> GetAll()
        {
            return DbHelper.Query<DegreeInterestMap>(SelectSql + " ORDER BY mappingID;", Map);
        }

        /// <summary>Interest-category weights for one degree.</summary>
        public List<DegreeInterestMap> GetByDegree(int degreeID)
        {
            return DbHelper.Query<DegreeInterestMap>(SelectSql + " WHERE degreeID = @degreeID ORDER BY weightedScore DESC;", Map,
                cmd => cmd.AddParameter("@degreeID", degreeID));
        }

        private static void AddColumnParameters(SqlCommand cmd, DegreeInterestMap map)
        {
            cmd.AddParameter("@degreeID", map.DegreeID);
            cmd.AddParameter("@categoryID", map.CategoryID);
            cmd.AddParameter("@weightedScore", map.WeightedScore);
        }

        private static DegreeInterestMap Map(IDataRecord r)
        {
            return new DegreeInterestMap
            {
                MappingID = r.ReadInt("mappingID"),
                DegreeID = r.ReadInt("degreeID"),
                CategoryID = r.ReadInt("categoryID"),
                WeightedScore = r.ReadDecimal("weightedScore")
            };
        }
    }
}
