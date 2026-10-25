using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screen 10 - optional funding guidance. Only active, not-yet-closed options are shown
    /// (FundingController.Search). Selecting one records fundingRequested on the session.
    /// </summary>
    public partial class frmFundingInformation : Form, IJourneyStep
    {
        private LookupController lookup = new LookupController();
        private bool loading = false;   // true while the screen fills the lists itself

        public frmFundingInformation()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private AdvisorySessionController Session
        {
            get { return AppSession.Advisory; }
        }

        private void frmFundingInformation_Load(object sender, EventArgs e)
        {
            try
            {
                loading = true;
                UiHelpers.FillFaculties(cboFaculty, lookup.GetFaculties(), "All faculties");
                UiHelpers.FillTexts(cboFundingType, LookupController.FundingTypeList, "All types");

                // Start with the faculty and programme the learner chose.
                if (Session.PreferredFacultyID > 0)
                {
                    UiHelpers.SelectId(cboFaculty, Session.PreferredFacultyID);
                }
                FillProgrammes();
                if (Session.SelectedDegreeID > 0)
                {
                    UiHelpers.SelectId(cboProgramme, Session.SelectedDegreeID);
                }
                loading = false;
                ApplyFilter();
            }
            catch (Exception ex)
            {
                loading = false;
                UiHelpers.ShowError(ex);
            }
        }

        private void FillProgrammes()
        {
            int facultyID = UiHelpers.SelectedId(cboFaculty);
            UiHelpers.FillProgrammes(cboProgramme, lookup.GetActiveProgrammes(facultyID), "All programmes");
        }

        // Shared by the three filter combo boxes.
        private void Filter_Changed(object sender, EventArgs e)
        {
            if (loading)
            {
                return;
            }
            try
            {
                if (sender == cboFaculty)
                {
                    // A different faculty has different programmes.
                    loading = true;
                    FillProgrammes();
                    loading = false;
                }
                ApplyFilter();
            }
            catch (Exception ex)
            {
                loading = false;
                UiHelpers.ShowError(ex);
            }
        }

        private void ApplyFilter()
        {
            string type = null;   // null = all types
            if (cboFundingType.SelectedIndex > 0)
            {
                type = cboFundingType.Text;
            }

            List<FundingListItem> matches = Session.SearchFunding(UiHelpers.SelectedId(cboFaculty),
                                                                  UiHelpers.SelectedId(cboProgramme), type);
            loading = true;
            dgvFunding.Rows.Clear();
            foreach (FundingListItem f in matches)
            {
                string closing = "Open";
                if (f.Funding.ClosingDate.HasValue)
                {
                    closing = f.Funding.ClosingDate.Value.ToString("dd MMMM yyyy");
                }
                int row = dgvFunding.Rows.Add(f.Funding.FundingName, f.Funding.FundingType, f.LinkedTo, closing);
                dgvFunding.Rows[row].Tag = f;
            }
            loading = false;

            if (matches.Count > 0)
            {
                ShowDetails(matches[0], false);
            }
            else
            {
                ShowDetails(null, false);
            }
        }

        private void dgvFunding_SelectionChanged(object sender, EventArgs e)
        {
            if (loading || dgvFunding.CurrentRow == null)
            {
                return;
            }
            FundingListItem f = dgvFunding.CurrentRow.Tag as FundingListItem;
            if (f != null)
            {
                // Only a row the learner clicked counts as a funding request.
                ShowDetails(f, dgvFunding.Focused);
            }
        }

        private void ShowDetails(FundingListItem f, bool chosenByUser)
        {
            if (f == null)
            {
                lblFundName.Text = "No matching funding";
                lblFundEligibility.Text = "Try a different faculty, programme or funding type.";
                lblFundDocuments.Text = "";
                lblFundContact.Text = "";
                return;
            }
            lblFundName.Text = f.Funding.FundingName;
            lblFundEligibility.Text = "Eligibility: " + f.Funding.EligibilityDescription;
            lblFundDocuments.Text = "Documents: " + f.Funding.RequiredDocuments;
            lblFundContact.Text = "Contact / application information: " + f.Funding.ContactInfo;

            if (chosenByUser)
            {
                try
                {
                    Session.RequestFunding(f);   // records AdvisorySession.fundingRequested
                }
                catch (Exception ex)
                {
                    UiHelpers.ShowError(ex);
                }
            }
        }

        private void btnBackToOutcome_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdvisoryOutcome());
        }

        private void btnContinueToSummary_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdvisorySummary());
        }
    }
}
