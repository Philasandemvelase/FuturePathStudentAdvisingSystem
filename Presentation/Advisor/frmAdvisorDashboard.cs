using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 13 - Career Advisor home (LearnerController.GetRecentSessions).</summary>
    public partial class frmAdvisorDashboard : Form
    {
        public frmAdvisorDashboard()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmAdvisorDashboard_Load(object sender, EventArgs e)
        {
            dgvRecentSessions.Rows.Clear();
            try
            {
                foreach (SessionListItem s in new LearnerController().GetRecentSessions(5))
                {
                    int row = dgvRecentSessions.Rows.Add(s.LearnerName, s.DegreeName, s.Outcome);
                    dgvRecentSessions.Rows[row].Tag = s.SessionID;   // remember the session on the row
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void dgvRecentSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colOpen.Index)
            {
                return;
            }
            int sessionID = (int)dgvRecentSessions.Rows[e.RowIndex].Tag;
            MainForm.OpenSavedSession(sessionID, false);
        }

        private void btnSearchLearners_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmLearnerSessions());
        }

        private void btnViewSessions_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmLearnerSessions());
        }

        private void btnSelectReport_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmReportSelection());
        }
    }
}
