using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>The choices made on the Report Selection screen, handed to the preview.</summary>
    internal class ReportCriteria
    {
        public string ReportName;
        public DateTime From;
        public DateTime To;
        public int FacultyID = 0;   // 0 = all faculties
        public int DegreeID = 0;    // 0 = all programmes
    }

    /// <summary>Screen 20 - shared by Career Advisors and Administrators (ReportController).</summary>
    public partial class frmReportSelection : Form
    {
        public frmReportSelection()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmReportSelection_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtpToDate.Value = DateTime.Today;
            cboReport.Items.Clear();
            cboReport.Items.AddRange(ReportController.ReportNames);
            try
            {
                LookupController lookup = new LookupController();
                UiHelpers.FillFaculties(cboFaculty, lookup.GetFaculties(), "All faculties");
                UiHelpers.FillProgrammes(cboProgramme, lookup.GetAllProgrammes(), "All programmes");
                UiHelpers.FillLearners(cboLearner, new LearnerController().Search("", 0), "Select for individual summary");
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
            cboReport.SelectedIndex = 1;   // Degree Interest and Eligibility Report
        }

        private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The individual summary needs a learner; the other reports use faculty/programme filters.
            bool individual = (cboReport.Text == ReportController.LearnerSummaryReport);
            cboLearner.Enabled = individual;
            cboFaculty.Enabled = !individual;
            cboProgramme.Enabled = !individual;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            if (cboReport.SelectedIndex < 0)
            {
                errProvider.SetError(cboReport, "Choose a report.");
                return;
            }
            if (dtpFromDate.Value.Date > dtpToDate.Value.Date)
            {
                errProvider.SetError(dtpToDate, "The To date must be on or after the From date.");
                return;
            }

            try
            {
                // ---- Report 1: one learner's latest advisory summary ----
                if (cboReport.Text == ReportController.LearnerSummaryReport)
                {
                    int learnerID = UiHelpers.SelectedId(cboLearner);
                    if (learnerID == 0)
                    {
                        errProvider.SetError(cboLearner, "Select the learner for the individual summary.");
                        return;
                    }
                    int sessionID = new ReportController().LatestSessionOf(learnerID);
                    if (sessionID == 0)
                    {
                        UiHelpers.Info("This learner has no saved advisory sessions.");
                        return;
                    }
                    MainForm.OpenSavedSession(sessionID, true);
                    return;
                }

                // ---- Reports 2 and 3: open the preview with the chosen filters ----
                ReportCriteria criteria = new ReportCriteria();
                criteria.ReportName = cboReport.Text;
                criteria.From = dtpFromDate.Value.Date;
                criteria.To = dtpToDate.Value.Date;
                criteria.FacultyID = UiHelpers.SelectedId(cboFaculty);
                criteria.DegreeID = UiHelpers.SelectedId(cboProgramme);

                // The preview opens as another MDI child, so the selection stays open beside it.
                frmReportPreview preview = (frmReportPreview)MainForm.OpenChild(new frmReportPreview());
                preview.LoadReport(criteria);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            if (AppSession.Role == UserRole.Administrator)
            {
                MainForm.OpenChild(new frmAdminDashboard());
            }
            else
            {
                MainForm.OpenChild(new frmAdvisorDashboard());
            }
        }
    }
}
