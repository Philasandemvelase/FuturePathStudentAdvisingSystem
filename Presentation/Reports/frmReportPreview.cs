using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screens 21-22 - one preview form for both reports (ReportController); columns are built for the chosen report.
    /// </summary>
    public partial class frmReportPreview : Form
    {
        private ReportCriteria criteria = null;
        private int printRow = 0;   // the next grid row to print

        public frmReportPreview()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmReportPreview_Load(object sender, EventArgs e)
        {
            // Opened from the menu without criteria: show this year's degree report.
            if (criteria == null)
            {
                ReportCriteria defaults = new ReportCriteria();
                defaults.ReportName = ReportController.DegreeInterestReport;
                defaults.From = new DateTime(DateTime.Today.Year, 1, 1);
                defaults.To = DateTime.Today;
                LoadReport(defaults);
            }
        }

        internal void LoadReport(ReportCriteria newCriteria)
        {
            criteria = newCriteria;
            string range = criteria.From.ToString("dd MMM yyyy") + " – " + criteria.To.ToString("dd MMM yyyy");
            dgvReport.Columns.Clear();
            try
            {
                if (criteria.ReportName == ReportController.ExceptionReportName)
                {
                    BuildExceptionReport(range);
                }
                else
                {
                    BuildDegreeReport(range);
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void BuildDegreeReport(string range)
        {
            Text = "Report Preview";
            lblPageTitle.Text = "Report Preview";
            lblPageSubtitle.Text = ReportController.DegreeInterestReport + " · from saved advisory sessions.";
            lblReportSection.Text = "Advising activity · " + range;

            dgvReport.Columns.Add("colProgramme", "Programme");
            dgvReport.Columns.Add("colSessions", "Sessions");
            dgvReport.Columns.Add("colStrong", "Strong");
            dgvReport.Columns.Add("colPossible", "Possible");
            dgvReport.Columns.Add("colNotEligible", "Not eligible");
            dgvReport.Columns.Add("colNeedInformation", "Need information");
            dgvReport.Columns[0].FillWeight = 260;

            ReportController report = new ReportController();
            List<DegreeReportRow> rows = report.DegreeReport(criteria.From, criteria.To, criteria.FacultyID, criteria.DegreeID);
            foreach (DegreeReportRow r in rows)
            {
                int i = dgvReport.Rows.Add(r.Programme, r.Sessions, r.Strong, r.Possible, r.NotEligible, r.NeedInformation);
                if (r.Programme == "Total")
                {
                    dgvReport.Rows[i].DefaultCellStyle.Font = new Font(dgvReport.Font, FontStyle.Bold);
                }
            }

            List<string> gaps = report.CommonGaps(criteria.From, criteria.To, criteria.FacultyID, criteria.DegreeID);
            pnlCommonGaps.Visible = true;
            if (gaps.Count == 0)
            {
                lblCommonGaps.Text = "No gaps recorded in this period.";
            }
            else
            {
                string text = "";
                foreach (string gap in gaps)
                {
                    if (text != "")
                    {
                        text = text + "  ·  ";
                    }
                    text = text + gap;
                }
                lblCommonGaps.Text = text;
            }
        }

        private void BuildExceptionReport(string range)
        {
            Text = "Exception Report Preview";
            lblPageTitle.Text = "Exception Report Preview";
            lblPageSubtitle.Text = ReportController.ExceptionReportName + " · from saved advisory sessions.";
            lblReportSection.Text = "Learners requiring guidance · " + range;

            dgvReport.Columns.Add("colLearner", "Learner");
            dgvReport.Columns.Add("colProgramme", "Programme");
            dgvReport.Columns.Add("colOutcome", "Outcome");
            dgvReport.Columns.Add("colReason", "Reason");
            dgvReport.Columns[3].FillWeight = 180;

            List<ExceptionReportRow> rows = new ReportController().ExceptionReport(criteria.From, criteria.To,
                                                                                   criteria.FacultyID, criteria.DegreeID);
            foreach (ExceptionReportRow r in rows)
            {
                dgvReport.Rows.Add(r.Learner, r.Programme, r.Outcome, r.Reason);
            }
            pnlCommonGaps.Visible = false;
        }

        // ---- export and print ------------------------------------------------------------

        /// <summary>The grid as text: first the column headers, then one array per row.</summary>
        private List<string[]> GridLines()
        {
            List<string[]> lines = new List<string[]>();
            int columns = dgvReport.Columns.Count;

            string[] headers = new string[columns];
            for (int c = 0; c < columns; c++)
            {
                headers[c] = dgvReport.Columns[c].HeaderText;
            }
            lines.Add(headers);

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                string[] cells = new string[columns];
                for (int c = 0; c < columns; c++)
                {
                    cells[c] = Convert.ToString(row.Cells[c].Value);
                }
                lines.Add(cells);
            }
            return lines;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSaveReport.FileName = "FuturePath_Report_" + DateTime.Today.ToString("yyyyMMdd");
            if (dlgSaveReport.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            bool csv = (dlgSaveReport.FilterIndex == 1);   // 1 = CSV, 2 = text
            string nl = Environment.NewLine;
            string text = "";

            if (csv == false)
            {
                text += lblPageTitle.Text + nl;
                text += lblReportSection.Text + nl + nl;
            }
            foreach (string[] cells in GridLines())
            {
                string line = "";
                for (int c = 0; c < cells.Length; c++)
                {
                    if (csv)
                    {
                        // CSV: every value in quotes, quotes inside a value doubled
                        if (c > 0) line += ",";
                        line += "\"" + cells[c].Replace("\"", "\"\"") + "\"";
                    }
                    else
                    {
                        // Text: values separated by tabs
                        if (c > 0) line += "\t";
                        line += cells[c];
                    }
                }
                text += line + nl;
            }
            if (csv == false && pnlCommonGaps.Visible)
            {
                text += nl + "Common gaps: " + lblCommonGaps.Text + nl;
            }

            try
            {
                File.WriteAllText(dlgSaveReport.FileName, text);
                UiHelpers.Info("Report saved to:\n" + dlgSaveReport.FileName);
            }
            catch (IOException ex)
            {
                MessageBox.Show("The report could not be saved.\n" + ex.Message, "Save Report",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printRow = 0;
            dlgPrintPreview.ShowDialog(this);
        }

        /// <summary>Draws one printed page. Sets HasMorePages when the rows do not fit.</summary>
        private void printReport_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle area = e.MarginBounds;
            float y = area.Top;
            Font titleFont = new Font("Segoe UI", 14F, FontStyle.Bold);
            Font boldFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 9F);

            // Title on the first page only.
            if (printRow == 0)
            {
                e.Graphics.DrawString(lblPageTitle.Text, titleFont, Brushes.Black, area.Left, y);
                y += 30;
                e.Graphics.DrawString(lblReportSection.Text, normalFont, Brushes.Black, area.Left, y);
                y += 28;
            }

            List<string[]> lines = GridLines();
            int columns = lines[0].Length;
            if (columns < 1)
            {
                columns = 1;
            }
            float colWidth = area.Width / (float)columns;

            // Column headers on every page.
            for (int c = 0; c < lines[0].Length; c++)
            {
                RectangleF cell = new RectangleF(area.Left + c * colWidth, y, colWidth - 6, 20);
                e.Graphics.DrawString(lines[0][c], boldFont, Brushes.Black, cell);
            }
            y += 22;
            e.Graphics.DrawLine(Pens.Gray, area.Left, y, area.Right, y);
            y += 4;

            // The rows (lines[0] is the header, so row n is lines[n + 1]).
            bool morePages = false;
            while (printRow < lines.Count - 1)
            {
                if (y + 34 > area.Bottom)
                {
                    morePages = true;   // page full
                    break;
                }
                string[] cells = lines[printRow + 1];
                for (int c = 0; c < cells.Length; c++)
                {
                    RectangleF cell = new RectangleF(area.Left + c * colWidth, y, colWidth - 6, 32);
                    e.Graphics.DrawString(cells[c], normalFont, Brushes.Black, cell);
                }
                y += 34;
                printRow++;
            }

            titleFont.Dispose();
            boldFont.Dispose();
            normalFont.Dispose();

            e.HasMorePages = morePages;
            if (morePages == false)
            {
                printRow = 0;   // ready for the next print
            }
        }

        private void btnBackToSelection_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmReportSelection());
        }
    }
}
