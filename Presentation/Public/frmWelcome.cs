using System;
using System.Windows.Forms;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 01 - landing page shown inside the MDI parent for guests.</summary>
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        /// <summary>The MDI parent this screen is shown in.</summary>
        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
        }

        private void btnStartAdvising_Click(object sender, EventArgs e)
        {
            MainForm.StartAdvising();
        }

        private void btnAdvisorLogin_Click(object sender, EventArgs e)
        {
            MainForm.SignIn();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            MainForm.SignIn();
        }
    }
}
