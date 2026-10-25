using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screen 11 - session summary and export.
    /// Live session: AdvisorySessionController.BuildSummary / ExportSummary (adds an ExportReport row).
    /// Saved session (Career Advisor): LearnerController.GetSessionSummary.
    /// </summary>
    public partial class frmAdvisorySummary : Form, IJourneyStep
    {
        private SessionSummary summary;

        public frmAdvisorySummary()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmAdvisorySummary_Load(object sender, EventArgs e)
        {
            try
            {
                if (AppSession.ViewedSessionID > 0)
                {
                    // A Career Advisor looking at a saved session (read-only).
                    summary = new LearnerController().GetSessionSummary(AppSession.ViewedSessionID);
                    Text = "Advisory Summary - " + summary.LearnerName;
                    lblPageSubtitle.Text = "Saved session · read-only view for the Career Advisor.";
                    btnEndSession.Text = "Close";
                    btnExport.Enabled = false;
                }
                else
                {
                    summary = AppSession.Advisory.BuildSummary();
                }
                ShowSummary(summary);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void ShowSummary(SessionSummary s)
        {
            if (s.GradeName == null || s.GradeName == "")
            {
                lblLearnerHeading.Text = s.LearnerName;
            }
            else
            {
                lblLearnerHeading.Text = s.LearnerName + " · " + s.GradeName;
            }
            lblSelectedProgramme.Text = s.ProgrammeName;
            lblOutcomeValue.Text = s.Outcome;
            ShowMarks(s.Marks);
            lblDetailInterests.Text = "Interests: " + s.Interests;
            lblDetailGaps.Text = "Gaps: " + s.Gaps;
            lblDetailAlternatives.Text = "Alternatives: " + s.Alternatives;
            lblDetailFunding.Text = "Funding: " + s.Funding;
            lblDetailDateGenerated.Text = "Date: " + s.DateGenerated.ToString("dd MMMM yyyy");
        }

        /// <summary>Subjects as columns, marks in one row (as in the mockup).</summary>
        private void ShowMarks(List<SubjectMarkLine> marks)
        {
            dgvAcademicProfile.Columns.Clear();
            if (marks.Count == 0)
            {
                dgvAcademicProfile.Columns.Add("colNone", "No subjects captured");
                return;
            }

            // One column per subject, then one row with all the marks.
            object[] values = new object[marks.Count];
            for (int i = 0; i < marks.Count; i++)
            {
                SubjectMarkLine m = marks[i];
                dgvAcademicProfile.Columns.Add("col" + m.SubjectID, m.SubjectName);
                if (m.Mark.HasValue)
                {
                    values[i] = m.MarkText + "%";
                }
                else
                {
                    values[i] = "n/a";
                }
            }
            dgvAcademicProfile.Rows.Add(values);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dlgSaveSummary.FileName = "FuturePath_Summary_" + DateTime.Today.ToString("yyyyMMdd") + ".txt";
            if (dlgSaveSummary.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            try
            {
                AppSession.Advisory.ExportSummary(summary, dlgSaveSummary.FileName);
                UiHelpers.Info("Summary saved to:\n" + dlgSaveSummary.FileName);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnBackToOutcome_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdvisoryOutcome());
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            if (AppSession.ViewedSessionID > 0)
            {
                Close();
                return;
            }
            if (UiHelpers.Confirm("End this advisory session? Export the summary first if you need a copy.", "End Session"))
            {
                MainForm.FinishSession();
            }
        }
    }
}
