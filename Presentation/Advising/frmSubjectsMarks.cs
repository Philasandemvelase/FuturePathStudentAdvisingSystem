using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 03 - journey step 2 of 5. Calls AdvisorySessionController.SaveSubject / RemoveSubject.</summary>
    public partial class frmSubjectsMarks : Form, IJourneyStep
    {
        private int editingSubjectID = 0;   // the subject being edited (0 = adding a new one)

        public frmSubjectsMarks()
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

        private void frmSubjectsMarks_Load(object sender, EventArgs e)
        {
            try
            {
                UiHelpers.FillSubjects(cboSubject, new LookupController().GetSubjects());
                RefreshGrid();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void RefreshGrid()
        {
            dgvSubjects.Rows.Clear();
            foreach (SubjectMarkLine line in Session.GetSubjectLines())
            {
                int row = dgvSubjects.Rows.Add(line.SubjectName, line.MarkText);
                dgvSubjects.Rows[row].Tag = line;   // remember which subject is on this row
            }
        }

        private void ShowValidation(string message)
        {
            lblValidation.Text = "  " + message;
            lblValidation.Visible = true;
        }

        private void chkMarkNotAvailable_CheckedChanged(object sender, EventArgs e)
        {
            nudMark.Enabled = !chkMarkNotAvailable.Checked;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            lblValidation.Visible = false;

            decimal? mark = null;   // null = "mark not available yet"
            if (chkMarkNotAvailable.Checked == false)
            {
                mark = nudMark.Value;
            }

            try
            {
                Session.SaveSubject(UiHelpers.SelectedId(cboSubject), mark, editingSubjectID);
                editingSubjectID = 0;
                btnAddSubject.Text = "Add Subject";
                chkMarkNotAvailable.Checked = false;
                RefreshGrid();
            }
            catch (BusinessRuleException ex)
            {
                ShowValidation(ex.Message);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;   // the header was clicked
            }
            SubjectMarkLine line = (SubjectMarkLine)dgvSubjects.Rows[e.RowIndex].Tag;

            if (e.ColumnIndex == colEdit.Index)
            {
                // Put the subject back in the input fields so the mark can be changed.
                editingSubjectID = line.SubjectID;
                UiHelpers.SelectId(cboSubject, line.SubjectID);
                if (line.Mark.HasValue)
                {
                    chkMarkNotAvailable.Checked = false;
                    nudMark.Value = line.Mark.Value;
                }
                else
                {
                    chkMarkNotAvailable.Checked = true;
                }
                btnAddSubject.Text = "Save Mark";
            }
            else if (e.ColumnIndex == colRemove.Index)
            {
                Session.RemoveSubject(line.SubjectID);
                RefreshGrid();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.GoTo(this, new frmLearnerProfile());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                Session.ValidateSubjects();
                MainForm.GoTo(this, new frmInterestQuestionnaire());
            }
            catch (BusinessRuleException ex)
            {
                ShowValidation(ex.Message);
            }
        }

        private void frmSubjectsMarks_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Subjects are stored in the controller as soon as they are added.
        }
    }
}
