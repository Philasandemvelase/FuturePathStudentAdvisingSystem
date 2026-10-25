using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Data;

namespace FuturePathStudentAdvisingSystem.DAL
{
    /// <summary>Exported advisory reports. Table: dbo.ExportReport</summary>
    public class ExportReportDAL
    {
        private const string SelectSql =
            "SELECT reportID, sessionID, disclaimerText, reportFormat, exportDate, filePath " +
            "FROM dbo.ExportReport";

        /// <summary>Inserts a new row. The database generates the ID; it is copied into report.ReportID.</summary>
        public bool Add(ExportReport report)
        {
            const string sql =
                "INSERT INTO dbo.ExportReport (sessionID, disclaimerText, reportFormat, exportDate, filePath) " +
                "OUTPUT INSERTED.reportID " +
                "VALUES (@sessionID, @disclaimerText, @reportFormat, @exportDate, @filePath);";

            report.ReportID = DbHelper.InsertAndGetId(sql, cmd => AddColumnParameters(cmd, report));
            return report.ReportID > 0;
        }

        /// <summary>Updates every column except the ID. Returns false if the ID does not exist.</summary>
        public bool Update(ExportReport report)
        {
            const string sql =
                "UPDATE dbo.ExportReport " +
                "SET sessionID = @sessionID, disclaimerText = @disclaimerText, reportFormat = @reportFormat, exportDate = @exportDate, filePath = @filePath " +
                "WHERE reportID = @reportID;";

            return DbHelper.Execute(sql, cmd =>
            {
                AddColumnParameters(cmd, report);
                cmd.AddParameter("@reportID", report.ReportID);
            }) == 1;
        }

        /// <summary>Returns false if the ID does not exist. Throws SqlException 547 if other rows still reference it.</summary>
        public bool Delete(int reportID)
        {
            const string sql = "DELETE FROM dbo.ExportReport WHERE reportID = @reportID;";
            return DbHelper.Execute(sql, cmd => cmd.AddParameter("@reportID", reportID)) == 1;
        }

        /// <summary>Returns null if not found.</summary>
        public ExportReport GetByID(int reportID)
        {
            return DbHelper.QuerySingle<ExportReport>(SelectSql + " WHERE reportID = @reportID;", Map,
                cmd => cmd.AddParameter("@reportID", reportID));
        }

        public List<ExportReport> GetAll()
        {
            return DbHelper.Query<ExportReport>(SelectSql + " ORDER BY reportID;", Map);
        }

        /// <summary>Reports exported for one session.</summary>
        public List<ExportReport> GetBySession(int sessionID)
        {
            return DbHelper.Query<ExportReport>(SelectSql + " WHERE sessionID = @sessionID ORDER BY exportDate DESC;", Map,
                cmd => cmd.AddParameter("@sessionID", sessionID));
        }

        private static void AddColumnParameters(SqlCommand cmd, ExportReport report)
        {
            cmd.AddParameter("@sessionID", report.SessionID);
            cmd.AddParameter("@disclaimerText", report.DisclaimerText);
            cmd.AddParameter("@reportFormat", report.ReportFormat);
            cmd.AddParameter("@exportDate", report.ExportDate);
            cmd.AddParameter("@filePath", report.FilePath);
        }

        private static ExportReport Map(IDataRecord r)
        {
            return new ExportReport
            {
                ReportID = r.ReadInt("reportID"),
                SessionID = r.ReadInt("sessionID"),
                DisclaimerText = r.ReadString("disclaimerText"),
                ReportFormat = r.ReadString("reportFormat"),
                ExportDate = r.ReadDateTime("exportDate"),
                FilePath = r.ReadString("filePath")
            };
        }
    }
}
