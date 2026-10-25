using System;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>Screen 18 - questions, categories and programme weightings (QuestionnaireController).</summary>
    public partial class frmQuestionnaireMaintenance : Form
    {
        private QuestionnaireController questionnaireController = new QuestionnaireController();
        private int editingQuestionID = 0;   // 0 = new question

        public frmQuestionnaireMaintenance()
        {
            InitializeComponent();
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void frmQuestionnaireMaintenance_Load(object sender, EventArgs e)
        {
            nudWeight.DecimalPlaces = 2;
            nudWeight.Increment = 0.05m;
            try
            {
                FillCategories();
                UiHelpers.FillProgrammes(cboMapProgramme, new LookupController().GetAllProgrammes());
                RefreshGrid(0);
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void FillCategories()
        {
            UiHelpers.FillCategories(cboCategory, questionnaireController.GetCategories());
        }

        /// <summary>Reloads the questions and selects one (0 = the first question).</summary>
        private void RefreshGrid(int selectQuestionID)
        {
            dgvQuestions.Rows.Clear();
            foreach (QuestionListItem q in questionnaireController.GetQuestions())
            {
                string status = "Inactive";
                if (q.Question.IsActive)
                {
                    status = "Active";
                }
                int row = dgvQuestions.Rows.Add(q.Question.QuestionText, q.CategoryName, status);
                dgvQuestions.Rows[row].Tag = q.Question;
            }

            foreach (DataGridViewRow row in dgvQuestions.Rows)
            {
                InterestQuestion q = (InterestQuestion)row.Tag;
                if (selectQuestionID == 0 || q.QuestionID == selectQuestionID)
                {
                    row.Selected = true;
                    dgvQuestions.CurrentCell = row.Cells[0];
                    LoadQuestion(q);
                    break;
                }
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                return;
            }
            InterestQuestion q = dgvQuestions.CurrentRow.Tag as InterestQuestion;
            if (q != null)
            {
                LoadQuestion(q);
            }
        }

        /// <summary>Puts a question, its category and the category's strongest mapping in the editor.</summary>
        private void LoadQuestion(InterestQuestion q)
        {
            editingQuestionID = q.QuestionID;
            txtQuestionText.Text = q.QuestionText;
            UiHelpers.SelectId(cboCategory, q.CategoryID);
            if (q.IsActive)
            {
                cboQuestionStatus.SelectedIndex = 0;
            }
            else
            {
                cboQuestionStatus.SelectedIndex = 1;
            }
            txtCategoryName.Text = cboCategory.Text;

            DegreeInterestMap map = questionnaireController.GetTopMapping(q.CategoryID);
            if (map != null)
            {
                UiHelpers.SelectId(cboMapProgramme, map.DegreeID);
                nudWeight.Value = map.WeightedScore;
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            editingQuestionID = 0;
            txtQuestionText.Clear();
            cboQuestionStatus.SelectedIndex = 0;
            txtQuestionText.Focus();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                InterestQuestionCategory category = questionnaireController.AddCategory(txtCategoryName.Text);
                questionnaireController.SaveMapping(UiHelpers.SelectedId(cboMapProgramme), category.CategoryID, nudWeight.Value);
                FillCategories();
                UiHelpers.SelectId(cboCategory, category.CategoryID);
                UiHelpers.Info("Category added and mapped to " + cboMapProgramme.Text + ".");
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                int categoryID = UiHelpers.SelectedId(cboCategory);

                InterestQuestion question = new InterestQuestion();
                question.QuestionID = editingQuestionID;
                question.QuestionText = txtQuestionText.Text;
                question.CategoryID = categoryID;
                question.IsActive = (cboQuestionStatus.SelectedIndex != 1);

                questionnaireController.SaveQuestion(question);
                questionnaireController.RenameCategory(categoryID, txtCategoryName.Text);
                questionnaireController.SaveMapping(UiHelpers.SelectedId(cboMapProgramme), categoryID, nudWeight.Value);

                FillCategories();
                RefreshGrid(question.QuestionID);
                UiHelpers.Info("Changes saved.");
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
