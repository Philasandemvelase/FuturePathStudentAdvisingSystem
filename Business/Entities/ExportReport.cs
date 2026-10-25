using System;

namespace FuturePathStudentAdvisingSystem.Business.Entities
{
    /// <summary>A record of an advisory report exported for a session. Table: dbo.ExportReport</summary>
    public class ExportReport
    {
        public int      ReportID { get; set; }  // reportID - PK
        public int      SessionID { get; set; }  // sessionID - FK -> AdvisorySession
        public string   DisclaimerText { get; set; } = string.Empty;  // disclaimerText
        public string   ReportFormat { get; set; } = string.Empty;  // reportFormat - See ReportFormats constants.
        public DateTime ExportDate { get; set; } = DateTime.Now;  // exportDate
        public string   FilePath { get; set; }  // filePath - optional
    }
}
