using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screen 12 - Staff Login. Shown with ShowDialog() from the MDI parent (a modal dialog,
    /// not an MDI child). The check itself is done by LoginController -> UserAccountDAL.
    /// </summary>
    public partial class frmStaffLogin : Form
    {
        private readonly LoginController loginController = new LoginController();

        public frmStaffLogin()
        {
            InitializeComponent();
        }

        /// <summary>The signed-in account; read by frmMain after DialogResult.OK.</summary>
        public UserAccount SignedInUser { get; private set; }

        private void frmStaffLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            lblLoginError.Visible = false;
            try
            {
                SignedInUser = loginController.Login(txtUsername.Text, txtPassword.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Business.BusinessRuleException ex)
            {
                lblLoginError.Text = "  " + ex.Message;   // wrong password / inactive / empty
                lblLoginError.Visible = true;
                txtPassword.Clear();
                txtPassword.Focus();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);                    // e.g. database not set up
            }
        }

        private void btnBackToWelcome_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
