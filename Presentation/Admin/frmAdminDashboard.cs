using System;
using System.Windows.Forms;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 15 - Administrator home. Each tile opens a maintenance window in the MDI area.</summary>
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnOpenFaculties_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmFacultiesProgrammes());
        }

        private void btnOpenRequirements_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmProgrammeRequirements());
        }

        private void btnOpenQuestionnaire_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmQuestionnaireMaintenance());
        }

        private void btnOpenFunding_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmFundingMaintenance());
        }

        private void btnSelectReport_Click(object sender, EventArgs e)
        {
            MainForm.OpenChild(new frmReportSelection());
        }
    }
}
