using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using FuturePathStudentAdvisingSystem.Business;
using FuturePathStudentAdvisingSystem.Business.Entities;
using FuturePathStudentAdvisingSystem.Business.Models;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// An item for a ComboBox or CheckedListBox: the text the user sees plus the
    /// database ID behind it (for example "Mathematics" with SubjectID 1).
    /// </summary>
    internal class ListItem
    {
        public string Text;
        public int Value;

        public ListItem(string text, int value)
        {
            Text = text;
            Value = value;
        }

        // A ComboBox shows whatever ToString() returns.
        public override string ToString()
        {
            return Text;
        }
    }

    /// <summary>Marker for the learner journey screens (they replace each other in the MDI area).</summary>
    internal interface IJourneyStep
    {
    }

    /// <summary>Small helpers that all the forms share.</summary>
    internal static class UiHelpers
    {
        // =====================================================================
        // Filling combo boxes. allText adds a first item such as "All faculties"
        // with Value 0. Leave it out when there should be no such item.
        // =====================================================================

        public static void FillFaculties(ComboBox combo, List<Faculty> faculties, string allText = null)
        {
            StartFill(combo, allText);
            foreach (Faculty f in faculties)
            {
                combo.Items.Add(new ListItem(f.FacultyName, f.FacultyID));
            }
            EndFill(combo);
        }

        public static void FillProgrammes(ComboBox combo, List<DegreeProgramme> programmes, string allText = null)
        {
            StartFill(combo, allText);
            foreach (DegreeProgramme d in programmes)
            {
                combo.Items.Add(new ListItem(d.DegreeName, d.DegreeID));
            }
            EndFill(combo);
        }

        public static void FillSubjects(ComboBox combo, List<Subject> subjects, string allText = null)
        {
            StartFill(combo, allText);
            foreach (Subject s in subjects)
            {
                combo.Items.Add(new ListItem(s.SubjectName, s.SubjectID));
            }
            EndFill(combo);
        }

        public static void FillGrades(ComboBox combo, List<GradeLevel> grades, string allText = null)
        {
            StartFill(combo, allText);
            foreach (GradeLevel g in grades)
            {
                combo.Items.Add(new ListItem(g.GradeName, g.GradeLevelID));
            }
            EndFill(combo);
        }

        public static void FillCategories(ComboBox combo, List<InterestQuestionCategory> categories, string allText = null)
        {
            StartFill(combo, allText);
            foreach (InterestQuestionCategory c in categories)
            {
                combo.Items.Add(new ListItem(c.CategoryName, c.CategoryID));
            }
            EndFill(combo);
        }

        public static void FillLearners(ComboBox combo, List<LearnerListItem> learners, string allText = null)
        {
            StartFill(combo, allText);
            foreach (LearnerListItem l in learners)
            {
                combo.Items.Add(new ListItem(l.FullName, l.LearnerID));
            }
            EndFill(combo);
        }

        /// <summary>Fills a combo box with fixed texts; the values are 1, 2, 3 ...</summary>
        public static void FillTexts(ComboBox combo, string[] texts, string allText = null)
        {
            StartFill(combo, allText);
            for (int i = 0; i < texts.Length; i++)
            {
                combo.Items.Add(new ListItem(texts[i], i + 1));
            }
            EndFill(combo);
        }

        private static void StartFill(ComboBox combo, string allText)
        {
            combo.BeginUpdate();
            combo.Items.Clear();
            if (allText != null)
            {
                combo.Items.Add(new ListItem(allText, 0));
            }
        }

        private static void EndFill(ComboBox combo)
        {
            combo.EndUpdate();
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        // =====================================================================
        // Reading and setting the selection
        // =====================================================================

        /// <summary>The ID of the selected item, or 0 when nothing / an "All ..." item is selected.</summary>
        public static int SelectedId(ComboBox combo)
        {
            ListItem item = combo.SelectedItem as ListItem;
            if (item == null)
            {
                return 0;
            }
            return item.Value;
        }

        /// <summary>Selects the item with this ID (nothing happens if it is not in the list).</summary>
        public static void SelectId(ComboBox combo, int id)
        {
            for (int i = 0; i < combo.Items.Count; i++)
            {
                ListItem item = combo.Items[i] as ListItem;
                if (item != null && item.Value == id)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
        }

        /// <summary>Selects the item with exactly this text (or nothing when the text is empty).</summary>
        public static void SelectText(ComboBox combo, string text)
        {
            if (text == null || text == "")
            {
                combo.SelectedIndex = -1;
                return;
            }
            combo.SelectedIndex = combo.FindStringExact(text);
        }

        /// <summary>Ticks the CheckedListBox items whose IDs are in the list and unticks the rest.</summary>
        public static void CheckIds(CheckedListBox list, List<int> ids)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                ListItem item = list.Items[i] as ListItem;
                bool tick = item != null && ids.Contains(item.Value);
                list.SetItemChecked(i, tick);
            }
        }

        /// <summary>The IDs of the ticked items.</summary>
        public static List<int> CheckedIds(CheckedListBox list)
        {
            List<int> ids = new List<int>();
            foreach (object checkedObject in list.CheckedItems)
            {
                ListItem item = checkedObject as ListItem;
                if (item != null)
                {
                    ids.Add(item.Value);
                }
            }
            return ids;
        }

        // =====================================================================
        // Messages
        // =====================================================================

        /// <summary>
        /// The one place forms report errors:
        ///   BusinessRuleException -> the rule's message (user mistake, shown as a warning)
        ///   SqlException          -> database problem, with the SQL error number
        ///   anything else         -> unexpected error
        /// Usage:  try { controller.Save(...); } catch (Exception ex) { UiHelpers.ShowError(ex); }
        /// </summary>
        public static void ShowError(Exception ex)
        {
            string title = "Future Path";

            if (ex is BusinessRuleException)
            {
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ex is SqlException)
            {
                SqlException sql = (SqlException)ex;
                string hint;
                if (sql.Number == 547)
                {
                    hint = "The record is still used elsewhere, or a value breaks a database rule.";
                }
                else if (sql.Number == 2627 || sql.Number == 2601)
                {
                    hint = "That value already exists.";
                }
                else if (sql.Number == 4060 || sql.Number == 208)
                {
                    hint = "The database is not set up. Run the scripts in the Database folder (see SETUP.md).";
                }
                else
                {
                    hint = "A database error occurred.";
                }
                MessageBox.Show(hint + "\n\nSQL error " + sql.Number + ": " + sql.Message, title,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Unexpected error: " + ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Info(string message)
        {
            MessageBox.Show(message, "Future Path", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Info(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool Confirm(string message)
        {
            return Confirm(message, "Future Path");
        }

        public static bool Confirm(string message, string title)
        {
            DialogResult answer = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer == DialogResult.Yes;
        }
    }
}
