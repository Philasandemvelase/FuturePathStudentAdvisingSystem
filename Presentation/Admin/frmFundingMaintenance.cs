using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screen 19 - maintain FundingOption and its FundingFaculty / FundingProgramme links (FundingController).
    /// The two checklists replace the mockup's single drop-downs because one funding option can be
    /// linked to several faculties and programmes (e.g. the Study Support Bursary: Commerce + Humanities).
    /// </summary>
    public partial class frmFundingMaintenance : Form
    {
        private FundingController fundingController = new FundingController();
        private int editingFundingID = 0;   // 0 = new record

        public frmFundingMaintenance()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmFundingMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                LookupController lookup = new LookupController();
                cboFundingType.Items.Clear();
                cboFundingType.Items.AddRange(LookupController.FundingTypeList);

                clbFundFaculties.Items.Clear();
                foreach (Faculty f in lookup.GetFaculties())
                {
                    clbFundFaculties.Items.Add(new ListItem(f.FacultyName, f.FacultyID));
                }

                clbFundProgrammes.Items.Clear();
                foreach (DegreeProgramme d in lookup.GetAllProgrammes())
                {
                    clbFundProgrammes.Items.Add(new ListItem(d.DegreeName, d.DegreeID));
                }
                RefreshGrid(0);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        /// <summary>Reloads the funding list and selects one record (0 = the first).</summary>
        private void RefreshGrid(int selectFundingID)
        {
            dgvFundingRecords.Rows.Clear();
            foreach (FundingListItem f in fundingController.GetAll())
            {
                string status = "Inactive";
                if (f.Funding.IsActive)
                {
                    status = "Active";
                }
                int row = dgvFundingRecords.Rows.Add(f.Funding.FundingName, f.Funding.FundingType, status);
                dgvFundingRecords.Rows[row].Tag = f;
            }

            foreach (DataGridViewRow row in dgvFundingRecords.Rows)
            {
                FundingListItem f = (FundingListItem)row.Tag;
                if (selectFundingID == 0 || f.Funding.FundingID == selectFundingID)
                {
                    dgvFundingRecords.CurrentCell = row.Cells[0];
                    LoadRecord(f);
                    break;
                }
            }
        }

        private void dgvFundingRecords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFundingRecords.CurrentRow == null)
            {
                return;
            }
            FundingListItem f = dgvFundingRecords.CurrentRow.Tag as FundingListItem;
            if (f != null)
            {
                LoadRecord(f);
            }
        }

        /// <summary>Puts a funding option in the editor fields and ticks its links.</summary>
        private void LoadRecord(FundingListItem item)
        {
            errProvider.Clear();
            FundingOption f = item.Funding;
            editingFundingID = f.FundingID;
            txtFundingName.Text = f.FundingName;
            UiHelpers.SelectText(cboFundingType, f.FundingType);
            if (f.ClosingDate.HasValue)
            {
                dtpClosingDate.Value = f.ClosingDate.Value;
            }
            else
            {
                dtpClosingDate.Value = DateTime.Today.AddMonths(2);
            }
            if (f.IsActive)
            {
                cboFundingStatus.SelectedIndex = 0;
            }
            else
            {
                cboFundingStatus.SelectedIndex = 1;
            }
            txtEligibility.Text = f.EligibilityDescription;
            txtDocuments.Text = f.RequiredDocuments;
            txtContact.Text = f.ContactInfo;
            UiHelpers.CheckIds(clbFundFaculties, item.FacultyIDs);
            UiHelpers.CheckIds(clbFundProgrammes, item.DegreeIDs);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            editingFundingID = 0;
            txtFundingName.Clear();
            txtEligibility.Clear();
            txtDocuments.Clear();
            txtContact.Clear();
            cboFundingType.SelectedIndex = -1;
            dtpClosingDate.Value = DateTime.Today.AddMonths(2);
            cboFundingStatus.SelectedIndex = 0;
            UiHelpers.CheckIds(clbFundFaculties, new List<int>());   // untick everything
            UiHelpers.CheckIds(clbFundProgrammes, new List<int>());
            txtFundingName.Focus();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            errProvider.Clear();

            FundingOption funding = new FundingOption();
            funding.FundingID = editingFundingID;
            funding.FundingName = txtFundingName.Text.Trim();
            funding.FundingType = cboFundingType.Text;
            funding.ClosingDate = dtpClosingDate.Value.Date;
            funding.IsActive = (cboFundingStatus.SelectedIndex != 1);
            funding.EligibilityDescription = txtEligibility.Text.Trim();
            funding.RequiredDocuments = BlankToNull(txtDocuments.Text);
            funding.ContactInfo = BlankToNull(txtContact.Text);

            try
            {
                fundingController.Save(funding, UiHelpers.CheckedIds(clbFundFaculties), UiHelpers.CheckedIds(clbFundProgrammes));
                RefreshGrid(funding.FundingID);
                UiHelpers.Info("Funding record saved.");
            }
            catch (BusinessRuleException ex)
            {
                // Point the error icon at the field the rule is about.
                if (ex.Message.Contains("type"))
                {
                    errProvider.SetError(cboFundingType, ex.Message);
                }
                else if (ex.Message.Contains("eligible"))
                {
                    errProvider.SetError(txtEligibility, ex.Message);
                }
                else if (ex.Message.Contains("closing"))
                {
                    errProvider.SetError(dtpClosingDate, ex.Message);
                }
                else if (ex.Message.Contains("faculty"))
                {
                    errProvider.SetError(clbFundFaculties, ex.Message);
                }
                else
                {
                    errProvider.SetError(txtFundingName, ex.Message);
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (editingFundingID == 0)
            {
                return;
            }
            if (UiHelpers.Confirm("Deactivate " + txtFundingName.Text + "? Learners will no longer see it.") == false)
            {
                return;
            }
            try
            {
                fundingController.Deactivate(editingFundingID);
                RefreshGrid(editingFundingID);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmAdminDashboard());
        }

        private static string BlankToNull(string text)
        {
            if (text == null || text.Trim() == "")
            {
                return null;
            }
            return text.Trim();
        }
    }
}
