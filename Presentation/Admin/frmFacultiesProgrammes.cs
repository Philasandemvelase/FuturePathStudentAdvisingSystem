using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 16 - maintain DegreeProgramme and Faculty (ProgrammeController).</summary>
    public partial class frmFacultiesProgrammes : Form
    {
        private ProgrammeController programmeController = new ProgrammeController();
        private int editingDegreeID = 0;    // 0 = new programme
        private int editingFacultyID = 0;   // 0 = new faculty

        public frmFacultiesProgrammes()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmFacultiesProgrammes_Load(object sender, EventArgs e)
        {
            try
            {
                FillFaculties();
                RefreshGrid();
                if (dgvProgrammes.Rows.Count > 0)
                {
                    LoadProgramme((ProgrammeListItem)dgvProgrammes.Rows[0].Tag);
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void FillFaculties()
        {
            UiHelpers.FillFaculties(cboFaculty, programmeController.GetFaculties());
        }

        private void RefreshGrid()
        {
            dgvProgrammes.Rows.Clear();
            foreach (ProgrammeListItem p in programmeController.GetProgrammes())
            {
                string status = "Inactive";
                if (p.Programme.IsActive)
                {
                    status = "Active";
                }
                int row = dgvProgrammes.Rows.Add(p.Programme.DegreeName, p.FacultyName, status);
                dgvProgrammes.Rows[row].Tag = p;
            }
        }

        /// <summary>Puts a programme (and its faculty) into the editor fields.</summary>
        private void LoadProgramme(ProgrammeListItem item)
        {
            errProvider.Clear();
            DegreeProgramme d = item.Programme;
            editingDegreeID = d.DegreeID;
            txtProgrammeName.Text = d.DegreeName;
            UiHelpers.SelectId(cboFaculty, d.FacultyID);
            if (d.IsActive)
            {
                cboProgrammeStatus.SelectedIndex = 0;   // Active
            }
            else
            {
                cboProgrammeStatus.SelectedIndex = 1;   // Inactive
            }
            txtDescription.Text = d.Description;
            editingFacultyID = d.FacultyID;
            txtFacultyName.Text = item.FacultyName;
        }

        private void dgvProgrammes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colEdit.Index)
            {
                return;
            }
            LoadProgramme((ProgrammeListItem)dgvProgrammes.Rows[e.RowIndex].Tag);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            editingDegreeID = 0;
            editingFacultyID = 0;
            txtProgrammeName.Clear();
            cboProgrammeStatus.SelectedIndex = 0;
            txtDescription.Clear();
            txtFacultyName.Clear();
            txtProgrammeName.Focus();
        }

        /// <summary>True if a faculty with this name already exists.</summary>
        private bool FacultyExists(string name)
        {
            foreach (Faculty f in programmeController.GetFaculties())
            {
                if (f.FacultyName.ToLower() == name.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            try
            {
                // ---- 1. Faculty: rename the selected faculty, or add a new one after Add New ----
                string facultyName = txtFacultyName.Text.Trim();
                bool facultyIsNew = (editingFacultyID == 0 && facultyName != "" && FacultyExists(facultyName) == false);
                if (facultyName != "" && (editingFacultyID != 0 || facultyIsNew))
                {
                    Faculty faculty = new Faculty();
                    faculty.FacultyID = editingFacultyID;
                    faculty.FacultyName = facultyName;
                    programmeController.SaveFaculty(faculty);
                    editingFacultyID = faculty.FacultyID;
                    FillFaculties();
                    if (facultyIsNew)
                    {
                        UiHelpers.SelectId(cboFaculty, faculty.FacultyID);
                    }
                }

                // ---- 2. Programme ----
                if (txtProgrammeName.Text.Trim() != "")
                {
                    DegreeProgramme programme = new DegreeProgramme();
                    programme.DegreeID = editingDegreeID;
                    programme.DegreeName = txtProgrammeName.Text;
                    programme.FacultyID = UiHelpers.SelectedId(cboFaculty);
                    programme.IsActive = (cboProgrammeStatus.SelectedIndex != 1);
                    if (txtDescription.Text.Trim() == "")
                    {
                        programme.Description = null;
                    }
                    else
                    {
                        programme.Description = txtDescription.Text.Trim();
                    }
                    programmeController.SaveProgramme(programme);
                    editingDegreeID = programme.DegreeID;
                }
                else if (facultyName == "")
                {
                    errProvider.SetError(txtProgrammeName, "Enter a programme name (or a faculty name below).");
                    return;
                }

                // Refresh the lists but keep the selected faculty.
                int keepFacultyID = UiHelpers.SelectedId(cboFaculty);
                FillFaculties();
                UiHelpers.SelectId(cboFaculty, keepFacultyID);
                RefreshGrid();
                UiHelpers.Info("Changes saved.");
            }
            catch (BusinessRuleException ex)
            {
                // Point the error icon at the field the rule is about.
                if (ex.Message.StartsWith("Faculty") || ex.Message.StartsWith("A faculty"))
                {
                    errProvider.SetError(txtFacultyName, ex.Message);
                }
                else if (ex.Message.Contains("faculty"))
                {
                    errProvider.SetError(cboFaculty, ex.Message);
                }
                else if (ex.Message.StartsWith("Description"))
                {
                    errProvider.SetError(txtDescription, ex.Message);
                }
                else
                {
                    errProvider.SetError(txtProgrammeName, ex.Message);
                }
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (editingDegreeID == 0)
            {
                UiHelpers.Info("Select a programme with Edit first.");
                return;
            }
            if (UiHelpers.Confirm("Deactivate " + txtProgrammeName.Text + "? It will no longer be offered to learners.") == false)
            {
                return;
            }
            try
            {
                programmeController.DeactivateProgramme(editingDegreeID);
                cboProgrammeStatus.SelectedIndex = 1;
                RefreshGrid();
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
