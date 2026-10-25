using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 17 - maintain ProgrammeRequirements, the eligibility rules (RequirementController).</summary>
    public partial class frmProgrammeRequirements : Form
    {
        private RequirementController requirementController = new RequirementController();
        private ProgrammeRequirement editing = null;   // the rule being edited (null = adding a new rule)

        public frmProgrammeRequirements()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmProgrammeRequirements_Load(object sender, EventArgs e)
        {
            try
            {
                LookupController lookup = new LookupController();
                List<Subject> subjects = lookup.GetSubjects();
                UiHelpers.FillSubjects(cboSubject, subjects);
                UiHelpers.FillSubjects(cboAltSubject, subjects, "None");
                // Filling the programme list also loads its rules (SelectedIndexChanged).
                UiHelpers.FillProgrammes(cboProgramme, lookup.GetAllProgrammes());
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void cboProgramme_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshRules();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
            ClearEditor();
        }

        private void RefreshRules()
        {
            dgvRules.Rows.Clear();
            int degreeID = UiHelpers.SelectedId(cboProgramme);
            foreach (RequirementListItem r in requirementController.GetRequirements(degreeID))
            {
                string minimum = r.Requirement.MinimumMark.ToString("0.##") + "%";
                int row = dgvRules.Rows.Add(r.SubjectName, minimum, r.AlternativeName);
                dgvRules.Rows[row].Tag = r.Requirement;
            }
        }

        private void ClearEditor()
        {
            editing = null;
            if (cboSubject.Items.Count > 0)
            {
                cboSubject.SelectedIndex = 0;
            }
            if (cboAltSubject.Items.Count > 0)
            {
                cboAltSubject.SelectedIndex = 0;   // "None"
            }
            nudMinimumMark.Value = 60;
            txtRuleNote.Clear();
        }

        private void dgvRules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            ProgrammeRequirement rule = (ProgrammeRequirement)dgvRules.Rows[e.RowIndex].Tag;

            if (e.ColumnIndex == colEdit.Index)
            {
                // Put the rule in the editor fields.
                editing = rule;
                UiHelpers.SelectId(cboSubject, rule.SubjectID);
                nudMinimumMark.Value = rule.MinimumMark;
                if (rule.AcceptedAlternativeSubjectID.HasValue)
                {
                    UiHelpers.SelectId(cboAltSubject, rule.AcceptedAlternativeSubjectID.Value);
                }
                else
                {
                    cboAltSubject.SelectedIndex = 0;
                }
                txtRuleNote.Text = rule.Notes;
            }
            else if (e.ColumnIndex == colRemove.Index)
            {
                string subjectName = dgvRules.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (UiHelpers.Confirm("Remove the " + subjectName + " rule?") == false)
                {
                    return;
                }
                try
                {
                    requirementController.DeleteRequirement(rule.RequirementID);
                    RefreshRules();
                    ClearEditor();
                }
                catch (Exception ex)
                {
                    UiHelpers.ShowError(ex);
                }
            }
        }

        private void btnAddRequirement_Click(object sender, EventArgs e)
        {
            ClearEditor();
            cboSubject.Focus();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            ProgrammeRequirement rule = editing;
            if (rule == null)
            {
                rule = new ProgrammeRequirement();   // RequirementID 0 = new rule
            }
            rule.DegreeID = UiHelpers.SelectedId(cboProgramme);
            rule.SubjectID = UiHelpers.SelectedId(cboSubject);
            rule.MinimumMark = nudMinimumMark.Value;

            int alternativeID = UiHelpers.SelectedId(cboAltSubject);
            if (alternativeID == 0)
            {
                rule.AcceptedAlternativeSubjectID = null;   // "None"
            }
            else
            {
                rule.AcceptedAlternativeSubjectID = alternativeID;
            }

            if (txtRuleNote.Text.Trim() == "")
            {
                rule.Notes = null;
            }
            else
            {
                rule.Notes = txtRuleNote.Text.Trim();
            }

            try
            {
                requirementController.SaveRequirement(rule);
                RefreshRules();
                ClearEditor();
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
    }
}
