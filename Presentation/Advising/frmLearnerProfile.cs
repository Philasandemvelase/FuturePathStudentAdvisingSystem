using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 02 - journey step 1 of 5. Calls AdvisorySessionController.SetProfile.</summary>
    public partial class frmLearnerProfile : Form, IJourneyStep
    {
        public frmLearnerProfile()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        /// <summary>The advisory session in progress.</summary>
        private AdvisorySessionController Session
        {
            get { return AppSession.Advisory; }
        }

        private void frmLearnerProfile_Load(object sender, EventArgs e)
        {
            try
            {
                UiHelpers.FillGrades(cboGrade, new LookupController().GetGradeLevels());
                cboProvince.Items.Clear();
                cboProvince.Items.AddRange(LookupController.Provinces);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }

            // Show what was entered before (if the learner comes back to this screen).
            Learner learner = Session.Learner;
            if (learner.GradeLevelID > 0)
            {
                UiHelpers.SelectId(cboGrade, learner.GradeLevelID);
            }
            else
            {
                cboGrade.SelectedIndex = -1;
            }
            UiHelpers.SelectText(cboProvince, learner.Province);
            txtLearnerName.Text = learner.FullName;
            txtSchool.Text = learner.SchoolName;
            txtEmail.Text = learner.ContactDetails;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            try
            {
                Session.SetProfile(UiHelpers.SelectedId(cboGrade), txtLearnerName.Text, txtSchool.Text,
                                   cboProvince.Text, txtEmail.Text);
                MainForm.GoTo(this, new frmSubjectsMarks());
            }
            catch (BusinessRuleException ex)
            {
                // Point the error icon at the field the rule is about.
                if (ex.Message.Contains("grade"))
                {
                    errProvider.SetError(cboGrade, ex.Message);
                }
                else if (ex.Message.Contains("email"))
                {
                    errProvider.SetError(txtEmail, ex.Message);
                }
                else if (ex.Message.Contains("School"))
                {
                    errProvider.SetError(txtSchool, ex.Message);
                }
                else
                {
                    errProvider.SetError(txtLearnerName, ex.Message);
                }
            }
        }

        private void btnCancelSession_Click(object sender, EventArgs e)
        {
            MainForm.CancelSession();
        }

        private void frmLearnerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Keep what was typed even if the learner leaves via the sidebar.
            Session.UpdateProfileDraft(UiHelpers.SelectedId(cboGrade), txtLearnerName.Text, txtSchool.Text,
                                       cboProvince.Text, txtEmail.Text);
        }
    }
}
