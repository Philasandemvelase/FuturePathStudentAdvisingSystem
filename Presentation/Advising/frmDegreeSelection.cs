using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screen 06 - journey step 4 of 5.
    /// Check Eligibility -> AdvisorySessionController.CheckEligibility, which evaluates the rules
    /// (RecommendationController) and saves the session to the database.
    /// </summary>
    public partial class frmDegreeSelection : Form, IJourneyStep
    {
        private LookupController lookup = new LookupController();
        private bool loading = false;   // true while the combo boxes are being filled

        public frmDegreeSelection()
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

        private void frmDegreeSelection_Load(object sender, EventArgs e)
        {
            try
            {
                loading = true;
                UiHelpers.FillFaculties(cboFaculty, lookup.GetFaculties());
                if (Session.PreferredFacultyID > 0)
                {
                    UiHelpers.SelectId(cboFaculty, Session.PreferredFacultyID);
                }
                loading = false;

                FillDegrees();
                if (Session.SelectedDegreeID > 0)
                {
                    UiHelpers.SelectId(cboDegree, Session.SelectedDegreeID);
                }
                ShowRequirements();
            }
            catch (Exception ex)
            {
                loading = false;
                UiHelpers.ShowError(ex);
            }
        }

        /// <summary>Fills the programme list with the active programmes of the chosen faculty.</summary>
        private void FillDegrees()
        {
            int facultyID = UiHelpers.SelectedId(cboFaculty);
            UiHelpers.FillProgrammes(cboDegree, lookup.GetActiveProgrammes(facultyID));
        }

        private void cboFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                return;
            }
            try
            {
                FillDegrees();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void cboDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
            {
                return;
            }
            try
            {
                ShowRequirements();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        /// <summary>Shows the programme's requirements next to the learner's marks.</summary>
        private void ShowRequirements()
        {
            dgvRequirements.Rows.Clear();
            int degreeID = UiHelpers.SelectedId(cboDegree);
            DegreeProgramme degree = null;
            if (degreeID > 0)
            {
                degree = lookup.GetProgramme(degreeID);
            }
            if (degree == null)
            {
                lblProgrammeDescription.Text = "Select a faculty and programme to see its requirements.";
                lblInterestCategories.Text = "";
                return;
            }

            foreach (RequirementCheckLine line in Session.GetRequirementCheck(degreeID))
            {
                dgvRequirements.Rows.Add(line.Requirement, line.Minimum, line.YourResult);
            }

            lblProgrammeDescription.Text = degree.Description;

            List<string> categories = lookup.InterestCategoriesFor(degreeID);
            string text = "";
            foreach (string category in categories)
            {
                if (text != "")
                {
                    text = text + "; ";
                }
                text = text + category;
            }
            lblInterestCategories.Text = "Interest categories: " + text + ".";
        }

        private void btnCheckEligibility_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                AppSession.ViewedSessionID = 0;   // show the live session, not a saved one
                Session.CheckEligibility(UiHelpers.SelectedId(cboFaculty), UiHelpers.SelectedId(cboDegree));
                Cursor = Cursors.Default;
                MainForm.GoTo(this, new frmAdvisoryOutcome());
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                UiHelpers.ShowError(ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmInterestQuestionnaire());
        }

        private void frmDegreeSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Session.SelectProgramme(UiHelpers.SelectedId(cboFaculty), UiHelpers.SelectedId(cboDegree));
        }
    }
}
