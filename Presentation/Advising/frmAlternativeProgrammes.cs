using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 09 - other programmes the learner qualifies for (AdvisorySessionController.GetAlternatives).</summary>
    public partial class frmAlternativeProgrammes : Form, IJourneyStep
    {
        public frmAlternativeProgrammes()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmAlternativeProgrammes_Load(object sender, EventArgs e)
        {
            dgvAlternatives.Rows.Clear();

            if (AppSession.Advisory.Subjects.Count == 0)
            {
                lblAltName.Text = "No subjects captured yet";
                lblAltDetails.Text = "Add your subjects and marks first; alternatives are based on them.";
                return;
            }

            List<EligibilityResult> alternatives;
            try
            {
                alternatives = AppSession.Advisory.GetAlternatives(5);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
                return;
            }

            foreach (EligibilityResult alternative in alternatives)
            {
                string reason;
                if (alternative.Outcome == AdvisoryOutcomes.StrongMatch)
                {
                    reason = "Accepts the learner's subject combination; interest match " + Percent(alternative.Result.InterestMatchScore);
                }
                else
                {
                    reason = alternative.Result.GapDescription;
                }
                int row = dgvAlternatives.Rows.Add(alternative.Degree.DegreeName, alternative.FacultyName, reason);
                dgvAlternatives.Rows[row].Tag = alternative;
            }

            if (alternatives.Count == 0)
            {
                lblAltName.Text = "No alternatives found";
                lblAltDetails.Text = "No other active programme matches the captured subjects. Speak to a Career Advisor.";
            }
            else
            {
                ShowDetails(alternatives[0]);
            }
        }

        private void ShowDetails(EligibilityResult alternative)
        {
            lblAltName.Text = alternative.Degree.DegreeName + " · " + alternative.Outcome;
            lblAltDetails.Text = alternative.Degree.Description
                + "  Interest match: " + Percent(alternative.Result.InterestMatchScore)
                + ". Overall score: " + Percent(alternative.Result.OverallScore)
                + ". Gaps: " + alternative.Result.GapDescription + ".";
        }

        /// <summary>A score as "75%", or "n/a" when there is no score.</summary>
        private static string Percent(decimal? value)
        {
            if (value.HasValue)
            {
                return value.Value.ToString("0") + "%";
            }
            return "n/a";
        }

        private void dgvAlternatives_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colViewDetails.Index)
            {
                return;
            }
            EligibilityResult alternative = (EligibilityResult)dgvAlternatives.Rows[e.RowIndex].Tag;
            ShowDetails(alternative);
        }

        private void btnBackToOutcome_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdvisoryOutcome());
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
