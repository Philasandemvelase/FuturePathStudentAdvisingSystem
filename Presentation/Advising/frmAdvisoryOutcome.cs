using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screens 07-08 - journey step 5 of 5. Shows AdvisorySessionController.LastResult.
    /// The four outcomes from the "Other States" mockup are colour states of this one form.
    /// A Career Advisor sees a saved session here too (LearnerController.GetSavedOutcome).
    /// </summary>
    public partial class frmAdvisoryOutcome : Form, IJourneyStep
    {
        public frmAdvisoryOutcome()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmAdvisoryOutcome_Load(object sender, EventArgs e)
        {
            try
            {
                // A Career Advisor looking at a saved session (read-only).
                if (AppSession.ViewedSessionID > 0)
                {
                    EligibilityResult saved = new LearnerController().GetSavedOutcome(AppSession.ViewedSessionID);
                    Text = "Advisory Outcome - saved session " + AppSession.ViewedSessionID;
                    lblPageSubtitle.Text = "Saved session · read-only view for the Career Advisor.";
                    btnEditStudyOptions.Enabled = false;
                    ShowResult(saved);
                    return;
                }

                // The live session.
                AdvisorySessionController session = AppSession.Advisory;
                if (session.LastResult == null)
                {
                    lblOutcomeProgramme.Text = "No result yet";
                    ApplyState(AdvisoryOutcomes.MoreInformationNeeded, "Check eligibility",
                               "Choose a programme in Faculty & Degree Selection and click Check Eligibility.");
                    dgvReasons.Rows.Clear();
                }
                else if (session.ResultIsOutOfDate)
                {
                    lblOutcomeProgramme.Text = session.LastResult.Degree.DegreeName;
                    ApplyState(AdvisoryOutcomes.MoreInformationNeeded, "Check eligibility",
                               "Your subjects, answers or programme changed. Click Check Eligibility again to update the result.");
                    dgvReasons.Rows.Clear();
                }
                else
                {
                    ShowResult(session.LastResult);
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void ShowResult(EligibilityResult result)
        {
            if (result.Degree == null)
            {
                lblOutcomeProgramme.Text = "";
            }
            else
            {
                lblOutcomeProgramme.Text = result.Degree.DegreeName + " · " + result.FacultyName;
            }
            ApplyState(result.Outcome, result.Headline, result.Detail);

            dgvReasons.Rows.Clear();
            foreach (ReasonLine reason in result.Reasons)
            {
                dgvReasons.Rows.Add(reason.Check, reason.Result, reason.Explanation);
            }
        }

        /// <summary>Colours the banner: green = Strong, amber = Possible, red = Not eligible, blue = more info.</summary>
        private void ApplyState(string outcome, string headline, string detail)
        {
            if (outcome == AdvisoryOutcomes.StrongMatch)
            {
                pnlOutcomeBanner.BackColor = Theme.SuccessBack;
                lblOutcomeHeadline.ForeColor = Theme.SuccessText;
            }
            else if (outcome == AdvisoryOutcomes.PossibleMatch)
            {
                pnlOutcomeBanner.BackColor = Theme.WarningBack;
                lblOutcomeHeadline.ForeColor = Theme.WarningText;
            }
            else if (outcome == AdvisoryOutcomes.NotCurrentlyEligible)
            {
                pnlOutcomeBanner.BackColor = Theme.ErrorBack;
                lblOutcomeHeadline.ForeColor = Theme.ErrorText;
            }
            else
            {
                pnlOutcomeBanner.BackColor = Theme.InfoBack;
                lblOutcomeHeadline.ForeColor = Theme.InfoText;
            }
            lblOutcomeDetail.ForeColor = lblOutcomeHeadline.ForeColor;
            lblOutcomeHeadline.Text = headline;
            lblOutcomeDetail.Text = detail;
        }

        private void btnEditStudyOptions_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmDegreeSelection());
        }

        private void btnViewAlternatives_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAlternativeProgrammes());
        }

        private void btnViewFunding_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmFundingInformation());
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdvisorySummary());
        }
    }
}
