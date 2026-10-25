using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 14 - search learners and open their saved sessions (LearnerController).</summary>
    public partial class frmLearnerSessions : Form
    {
        private LearnerController learnerController = new LearnerController();

        public frmLearnerSessions()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmLearnerSessions_Load(object sender, EventArgs e)
        {
            try
            {
                UiHelpers.FillGrades(cboSearchGrade, new LookupController().GetGradeLevels(), "All grades");
                RunSearch();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void RunSearch()
        {
            dgvLearners.Rows.Clear();
            dgvSessions.Rows.Clear();
            List<LearnerListItem> learners = learnerController.Search(txtSearchName.Text, UiHelpers.SelectedId(cboSearchGrade));
            foreach (LearnerListItem l in learners)
            {
                int row = dgvLearners.Rows.Add(l.FullName, l.GradeName, l.SchoolName);
                dgvLearners.Rows[row].Tag = l.LearnerID;
            }
            // Only one learner found: show their sessions straight away.
            if (learners.Count == 1)
            {
                ShowSessions(learners[0].LearnerID);
            }
        }

        /// <summary>Shows a learner's sessions (newest first; the DAL sorts them).</summary>
        private void ShowSessions(int learnerID)
        {
            dgvSessions.Rows.Clear();
            foreach (SessionListItem s in learnerController.GetSessions(learnerID))
            {
                int row = dgvSessions.Rows.Add(s.SessionDate.ToString("dd MMMM yyyy"), s.DegreeName, s.Outcome);
                dgvSessions.Rows[row].Tag = s.SessionID;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                RunSearch();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void dgvLearners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colSelectLearner.Index)
            {
                return;
            }
            try
            {
                ShowSessions((int)dgvLearners.Rows[e.RowIndex].Tag);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void dgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int sessionID = (int)dgvSessions.Rows[e.RowIndex].Tag;
            if (e.ColumnIndex == colViewOutcome.Index)
            {
                MainForm.OpenSavedSession(sessionID, false);
            }
            else if (e.ColumnIndex == colViewSummary.Index)
            {
                MainForm.OpenSavedSession(sessionID, true);
            }
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmAdvisorDashboard());
        }

        private void btnNewSession_Click(object sender, EventArgs e)
        {
            MainForm.StartAdvising();
        }
    }
}
