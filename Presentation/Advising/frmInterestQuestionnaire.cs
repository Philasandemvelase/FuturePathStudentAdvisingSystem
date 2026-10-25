using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business.Controllers;
using FuturePathStudentAdvisingSystem.Business.Entities;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// Screens 04-05 - journey step 3 of 5. Active questions come from the database
    /// (InterestQuestion); answers go to AdvisorySessionController.RecordAnswer.
    /// The five designer rows are re-used for each page of five questions.
    /// </summary>
    public partial class frmInterestQuestionnaire : Form, IJourneyStep
    {
        private const int PerPage = 5;
        private List<InterestQuestion> questions = new List<InterestQuestion>();
        private Panel[] rows;
        private Label[] labels;
        private RadioButton[,] options;   // options[row, answer - 1]
        private int page = 0;             // 0 = first page
        private bool loading = false;     // true while the screen fills the radio buttons itself

        public frmInterestQuestionnaire()
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

        /// <summary>Number of pages of five questions (at least 1).</summary>
        private int PageCount
        {
            get
            {
                int count = (questions.Count + PerPage - 1) / PerPage;
                if (count < 1)
                {
                    count = 1;
                }
                return count;
            }
        }

        private void frmInterestQuestionnaire_Load(object sender, EventArgs e)
        {
            rows = new Panel[] { pnlQuestion1, pnlQuestion2, pnlQuestion3, pnlQuestion4, pnlQuestion5 };
            labels = new Label[] { lblQuestion1, lblQuestion2, lblQuestion3, lblQuestion4, lblQuestion5 };
            options = new RadioButton[,]
            {
                { rdoQ1A1, rdoQ1A2, rdoQ1A3, rdoQ1A4, rdoQ1A5 },
                { rdoQ2A1, rdoQ2A2, rdoQ2A3, rdoQ2A4, rdoQ2A5 },
                { rdoQ3A1, rdoQ3A2, rdoQ3A3, rdoQ3A4, rdoQ3A5 },
                { rdoQ4A1, rdoQ4A2, rdoQ4A3, rdoQ4A4, rdoQ4A5 },
                { rdoQ5A1, rdoQ5A2, rdoQ5A3, rdoQ5A4, rdoQ5A5 }
            };
            try
            {
                questions = Session.GetQuestions();
            }
            catch (Exception ex)
            {
                UiHelpers.ShowError(ex);
            }
            ShowPage(0);
        }

        /// <summary>The question shown on a row of the current page (null if the row is empty).</summary>
        private InterestQuestion QuestionAt(int row)
        {
            int index = page * PerPage + row;
            if (index < questions.Count)
            {
                return questions[index];
            }
            return null;
        }

        /// <summary>The questions on the current page.</summary>
        private List<InterestQuestion> QuestionsOnPage()
        {
            List<InterestQuestion> list = new List<InterestQuestion>();
            for (int row = 0; row < PerPage; row++)
            {
                InterestQuestion q = QuestionAt(row);
                if (q != null)
                {
                    list.Add(q);
                }
            }
            return list;
        }

        private void ShowPage(int newPage)
        {
            loading = true;
            page = newPage;
            lblUnanswered.Visible = false;

            for (int row = 0; row < PerPage; row++)
            {
                InterestQuestion q = QuestionAt(row);
                if (q == null)
                {
                    rows[row].Visible = false;
                    continue;
                }
                rows[row].Visible = true;
                int number = page * PerPage + row + 1;
                labels[row].Text = number + ". " + q.QuestionText;

                // Tick the answer the learner gave before (0 = none).
                int answer = Session.GetAnswer(q.QuestionID);
                for (int value = 1; value <= 5; value++)
                {
                    options[row, value - 1].Checked = (answer == value);
                }
            }

            lblPageSubtitle.Text = "Step 3 of 5 · Page " + (page + 1) + " of " + PageCount + " · Select one response per statement.";
            if (page == 0)
            {
                btnPrevious.Text = "Back";
            }
            else
            {
                btnPrevious.Text = "Previous Questions";
            }
            if (page == PageCount - 1)
            {
                btnNext.Text = "Next: Study Options";
            }
            else
            {
                btnNext.Text = "Next Questions";
            }
            loading = false;
        }

        // All 25 radio buttons share this handler.
        private void Answer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (loading || radio.Checked == false)
            {
                return;
            }

            // Find the row and the value of the radio button that was clicked.
            for (int row = 0; row < PerPage; row++)
            {
                for (int value = 1; value <= 5; value++)
                {
                    if (options[row, value - 1] == radio)
                    {
                        InterestQuestion q = QuestionAt(row);
                        if (q != null)
                        {
                            Session.RecordAnswer(q.QuestionID, value);
                        }
                        lblUnanswered.Visible = false;
                        return;
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Session.AllAnswered(QuestionsOnPage()) == false)
            {
                lblUnanswered.Visible = true;
                return;
            }
            if (page < PageCount - 1)
            {
                ShowPage(page + 1);
            }
            else
            {
                MainForm.GoTo(this, new frmDegreeSelection());
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                ShowPage(page - 1);
            }
            else
            {
                MainForm.GoTo(this, new frmSubjectsMarks());
            }
        }

        private void frmInterestQuestionnaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Answers are stored in the controller as soon as they are selected.
        }
    }
}
