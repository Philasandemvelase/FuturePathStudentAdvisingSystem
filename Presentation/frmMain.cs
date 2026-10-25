using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FuturePathStudentAdvisingSystem.Presentation
{
    /// <summary>
    /// MDI parent (IsMdiContainer = true). Owns the menu, toolstrip, header, role-based
    /// sidebar and status bar. Every screen opens inside it as an MDI child.
    /// Presentation layer only: it opens windows and applies the role; the business
    /// logic is in Business\Controllers.
    /// </summary>
    public partial class frmMain : Form
    {
        // The sidebar buttons. Each button's Tag holds a key: a form name such as
        // "frmLearnerProfile", or an action: "Cancel", "Logout" or "Login".
        private List<Button> navButtons = new List<Button>();

        public frmMain()
        {
            InitializeComponent();
        }

        // =====================================================================
        // Window management
        // =====================================================================

        /// <summary>
        /// Shows a form inside the MDI area. If a form of the same type is already open,
        /// that one is brought to the front instead (so each screen is open only once)
        /// and the new one is thrown away. Returns the form that is now showing.
        /// </summary>
        public Form OpenChild(Form newForm)
        {
            foreach (Form child in MdiChildren)
            {
                if (child.GetType() == newForm.GetType())
                {
                    if (child.WindowState == FormWindowState.Minimized)
                    {
                        child.WindowState = FormWindowState.Normal;
                    }
                    child.Activate();
                    newForm.Dispose();
                    return child;
                }
            }

            // Open maximised, unless the user has tiled/cascaded the other windows.
            bool othersAreNormal = false;
            foreach (Form child in MdiChildren)
            {
                if (child.WindowState == FormWindowState.Normal)
                {
                    othersAreNormal = true;
                }
            }

            newForm.MdiParent = this;
            if (othersAreNormal)
            {
                newForm.WindowState = FormWindowState.Normal;
            }
            else
            {
                newForm.WindowState = FormWindowState.Maximized;
            }
            newForm.Show();
            return newForm;
        }

        /// <summary>Opens the next screen and closes the current one (Next / Back buttons).</summary>
        public Form GoTo(Form from, Form to)
        {
            Form target = OpenChild(to);
            if (from != null && from != target)
            {
                from.Close();
            }
            return target;
        }

        /// <summary>
        /// Used by the menu and sidebar. A learner journey screen replaces the journey
        /// screen that is open; staff screens stay open side by side.
        /// </summary>
        public void OpenStep(Form newForm)
        {
            Form current = ActiveMdiChild;
            Form target = OpenChild(newForm);
            if (current != null && current != target && current is IJourneyStep && target is IJourneyStep)
            {
                current.Close();
            }
        }

        private void CloseAllChildren()
        {
            // Copy the list first, because closing a form removes it from MdiChildren.
            Form[] children = MdiChildren;
            foreach (Form child in children)
            {
                child.Close();
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            Form active = ActiveMdiChild;
            if (active == null)
            {
                tsslWindow.Text = "No window open";
            }
            else
            {
                tsslWindow.Text = active.Text;
            }

            // Highlight the sidebar button of the open screen.
            foreach (Button button in navButtons)
            {
                bool isActive = active != null && (string)button.Tag == active.Name;
                Theme.SetNavActive(button, isActive);
            }
        }

        // =====================================================================
        // Start-up, roles and sign-in
        // =====================================================================

        private void frmMain_Load(object sender, EventArgs e)
        {
            // The MDI client area is dark grey by default; match the page colour instead.
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Theme.Page;
                }
            }
            tsslDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
            ApplyRole(UserRole.Guest);
            OpenChild(new frmWelcome());
        }

        /// <summary>Shows only the menus and sidebar entries the current role may use.</summary>
        internal void ApplyRole(UserRole role)
        {
            AppSession.Role = role;
            bool guest = (role == UserRole.Guest);
            bool learner = (role == UserRole.Learner);
            bool advisor = (role == UserRole.CareerAdvisor);
            bool admin = (role == UserRole.Administrator);

            mnuFileStaffLogin.Visible = guest || learner;
            mnuFileLogout.Visible = !guest;
            mnuAdvising.Visible = guest || learner || advisor;
            foreach (ToolStripItem item in mnuAdvising.DropDownItems)
            {
                if (item != mnuAdvisingNewSession)
                {
                    item.Visible = learner;
                }
            }
            mnuAdvisor.Visible = advisor;
            mnuAdmin.Visible = admin;
            mnuReports.Visible = advisor || admin;
            tsbNewSession.Visible = !admin;

            string roleName = AppSession.RoleDisplayName(role);
            lblRoleBadge.Text = roleName;
            if (AppSession.Username == "")
            {
                tsslRole.Text = "Signed in as: " + roleName;
            }
            else
            {
                tsslRole.Text = "Signed in as: " + AppSession.Username + " (" + roleName + ")";
            }
            BuildNavigation(role);
        }

        /// <summary>Creates the sidebar buttons for a role.</summary>
        private void BuildNavigation(UserRole role)
        {
            flpNav.SuspendLayout();
            foreach (Button old in navButtons)
            {
                old.Dispose();
            }
            navButtons.Clear();
            flpNav.Controls.Clear();

            if (role == UserRole.Learner)
            {
                lblNavSection.Text = "YOUR ADVISING JOURNEY";
                AddNavButton("Learner Profile", "frmLearnerProfile");
                AddNavButton("Subjects & Marks", "frmSubjectsMarks");
                AddNavButton("Interest Questionnaire", "frmInterestQuestionnaire");
                AddNavButton("Faculty & Degree Selection", "frmDegreeSelection");
                AddNavButton("Advisory Outcome", "frmAdvisoryOutcome");
                AddNavButton("Alternative Programmes", "frmAlternativeProgrammes");
                AddNavButton("Funding Information", "frmFundingInformation");
                AddNavButton("Advisory Summary", "frmAdvisorySummary");
                AddNavButton("Cancel Session", "Cancel");
            }
            else if (role == UserRole.CareerAdvisor)
            {
                lblNavSection.Text = "WORKSPACE";
                AddNavButton("Career Advisor Dashboard", "frmAdvisorDashboard");
                AddNavButton("Learners & Advisory Sessions", "frmLearnerSessions");
                AddNavButton("Report Selection", "frmReportSelection");
                AddNavButton("Logout / Welcome", "Logout");
            }
            else if (role == UserRole.Administrator)
            {
                lblNavSection.Text = "WORKSPACE";
                AddNavButton("Administrator Dashboard", "frmAdminDashboard");
                AddNavButton("Faculties & Programmes", "frmFacultiesProgrammes");
                AddNavButton("Programme Requirements", "frmProgrammeRequirements");
                AddNavButton("Interest Questionnaire Maintenance", "frmQuestionnaireMaintenance");
                AddNavButton("Funding Maintenance", "frmFundingMaintenance");
                AddNavButton("Report Selection", "frmReportSelection");
                AddNavButton("Logout / Welcome", "Logout");
            }
            else
            {
                lblNavSection.Text = "WORKSPACE";
                AddNavButton("Welcome", "frmWelcome");
                AddNavButton("Staff Login", "Login");
            }

            flpNav.ResumeLayout();
            frmMain_MdiChildActivate(this, EventArgs.Empty);
        }

        private void AddNavButton(string text, string key)
        {
            Button button = Theme.CreateNavButton(text);
            if (text.Length > 26)
            {
                button.Height = 44;   // room for two lines
            }
            button.Tag = key;
            button.Click += new EventHandler(NavButton_Click);
            flpNav.Controls.Add(button);
            navButtons.Add(button);
        }

        /// <summary>One click handler for every sidebar button; the Tag says what to do.</summary>
        private void NavButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string key = (string)button.Tag;

            if (key == "Cancel")
            {
                CancelSession();
            }
            else if (key == "Logout")
            {
                Logout();
            }
            else if (key == "Login")
            {
                SignIn();
            }
            else
            {
                OpenStep(CreateForm(key));
            }
        }

        /// <summary>Creates a new screen from its name.</summary>
        private Form CreateForm(string formName)
        {
            switch (formName)
            {
                case "frmLearnerProfile": return new frmLearnerProfile();
                case "frmSubjectsMarks": return new frmSubjectsMarks();
                case "frmInterestQuestionnaire": return new frmInterestQuestionnaire();
                case "frmDegreeSelection": return new frmDegreeSelection();
                case "frmAdvisoryOutcome": return new frmAdvisoryOutcome();
                case "frmAlternativeProgrammes": return new frmAlternativeProgrammes();
                case "frmFundingInformation": return new frmFundingInformation();
                case "frmAdvisorySummary": return new frmAdvisorySummary();
                case "frmAdvisorDashboard": return new frmAdvisorDashboard();
                case "frmLearnerSessions": return new frmLearnerSessions();
                case "frmReportSelection": return new frmReportSelection();
                case "frmAdminDashboard": return new frmAdminDashboard();
                case "frmFacultiesProgrammes": return new frmFacultiesProgrammes();
                case "frmProgrammeRequirements": return new frmProgrammeRequirements();
                case "frmQuestionnaireMaintenance": return new frmQuestionnaireMaintenance();
                case "frmFundingMaintenance": return new frmFundingMaintenance();
                default: return new frmWelcome();
            }
        }

        /// <summary>Staff Login is a modal dialog: it blocks the shell until the user signs in or cancels.</summary>
        internal void SignIn()
        {
            frmStaffLogin login = new frmStaffLogin();
            DialogResult answer = login.ShowDialog(this);
            if (answer == DialogResult.OK)
            {
                CloseAllChildren();
                AppSession.CurrentUser = login.SignedInUser;   // UserAccount from LoginController
                AppSession.StartNewAdvisory();
                UserRole role = AppSession.RoleOf(login.SignedInUser);
                ApplyRole(role);
                OpenHome();
            }
            login.Dispose();
        }

        /// <summary>Opens the dashboard of the signed-in staff member.</summary>
        private void OpenHome()
        {
            if (AppSession.Role == UserRole.Administrator)
            {
                OpenChild(new frmAdminDashboard());
            }
            else
            {
                OpenChild(new frmAdvisorDashboard());
            }
        }

        internal void Logout()
        {
            if (AppSession.Role == UserRole.Learner && AppSession.Advisory.HasData)
            {
                if (UiHelpers.Confirm("Leave this advisory session? Unsaved answers will be cleared.") == false)
                {
                    return;
                }
            }
            CloseAllChildren();
            AppSession.CurrentUser = null;
            AppSession.StartNewAdvisory();
            ApplyRole(UserRole.Guest);
            OpenChild(new frmWelcome());
        }

        /// <summary>Starts a guided advisory session (learner, or an advisor assisting a learner).</summary>
        internal void StartAdvising()
        {
            if (AppSession.Advisory.HasData)
            {
                if (UiHelpers.Confirm("Start a new advisory session? The current answers will be cleared.") == false)
                {
                    return;
                }
            }

            // Close the journey screens first (they save their inputs when they close).
            if (AppSession.Role == UserRole.Guest)
            {
                CloseAllChildren();
            }
            Form[] children = MdiChildren;
            foreach (Form child in children)
            {
                if (child is IJourneyStep)
                {
                    child.Close();
                }
            }
            AppSession.StartNewAdvisory();

            if (AppSession.Role == UserRole.Guest)
            {
                ApplyRole(UserRole.Learner);
            }
            else if (AppSession.Role == UserRole.CareerAdvisor)
            {
                // The advisor keeps their own windows; the journey opens alongside them.
                mnuAdvising.Visible = true;
                foreach (ToolStripItem item in mnuAdvising.DropDownItems)
                {
                    item.Visible = true;
                }
            }
            OpenChild(new frmLearnerProfile());
        }

        internal void CancelSession()
        {
            if (UiHelpers.Confirm("Cancel this advisory session? Your answers will not be saved.", "Cancel Session"))
            {
                FinishSession();
            }
        }

        /// <summary>Closes the journey and returns to the role's home screen.</summary>
        internal void FinishSession()
        {
            CloseAllChildren();
            AppSession.StartNewAdvisory();
            if (AppSession.Role == UserRole.Learner)
            {
                ApplyRole(UserRole.Guest);
                OpenChild(new frmWelcome());
            }
            else
            {
                ApplyRole(AppSession.Role);
                OpenHome();
            }
        }

        /// <summary>Advisor view of a stored AdvisorySession (outcome or summary), read-only.</summary>
        internal void OpenSavedSession(int sessionID, bool showSummary)
        {
            // Close an open outcome/summary so it reloads with the chosen session.
            Form[] children = MdiChildren;
            foreach (Form child in children)
            {
                if (child is frmAdvisoryOutcome || child is frmAdvisorySummary)
                {
                    child.Close();
                }
            }
            AppSession.ViewedSessionID = sessionID;
            if (showSummary)
            {
                OpenChild(new frmAdvisorySummary());
            }
            else
            {
                OpenChild(new frmAdvisoryOutcome());
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && AppSession.Advisory.HasData)
            {
                if (UiHelpers.Confirm("An advisory session is in progress. Exit Future Path anyway?") == false)
                {
                    e.Cancel = true;
                }
            }
        }

        // =====================================================================
        // Menu + toolstrip handlers
        // =====================================================================

        private void mnuFileWelcome_Click(object sender, EventArgs e) { OpenChild(new frmWelcome()); }
        private void mnuFileStaffLogin_Click(object sender, EventArgs e) { SignIn(); }
        private void mnuFileLogout_Click(object sender, EventArgs e) { Logout(); }
        private void mnuFileExit_Click(object sender, EventArgs e) { Close(); }

        private void mnuAdvisingNewSession_Click(object sender, EventArgs e) { StartAdvising(); }
        private void mnuAdvisingProfile_Click(object sender, EventArgs e) { OpenStep(new frmLearnerProfile()); }
        private void mnuAdvisingSubjects_Click(object sender, EventArgs e) { OpenStep(new frmSubjectsMarks()); }
        private void mnuAdvisingQuestionnaire_Click(object sender, EventArgs e) { OpenStep(new frmInterestQuestionnaire()); }
        private void mnuAdvisingDegree_Click(object sender, EventArgs e) { OpenStep(new frmDegreeSelection()); }
        private void mnuAdvisingOutcome_Click(object sender, EventArgs e) { OpenStep(new frmAdvisoryOutcome()); }
        private void mnuAdvisingAlternatives_Click(object sender, EventArgs e) { OpenStep(new frmAlternativeProgrammes()); }
        private void mnuAdvisingFunding_Click(object sender, EventArgs e) { OpenStep(new frmFundingInformation()); }
        private void mnuAdvisingSummary_Click(object sender, EventArgs e) { OpenStep(new frmAdvisorySummary()); }
        private void mnuAdvisingCancel_Click(object sender, EventArgs e) { CancelSession(); }

        private void mnuAdvisorDashboard_Click(object sender, EventArgs e) { OpenChild(new frmAdvisorDashboard()); }
        private void mnuAdvisorLearners_Click(object sender, EventArgs e) { OpenChild(new frmLearnerSessions()); }

        private void mnuAdminDashboard_Click(object sender, EventArgs e) { OpenChild(new frmAdminDashboard()); }
        private void mnuAdminFaculties_Click(object sender, EventArgs e) { OpenChild(new frmFacultiesProgrammes()); }
        private void mnuAdminRequirements_Click(object sender, EventArgs e) { OpenChild(new frmProgrammeRequirements()); }
        private void mnuAdminQuestionnaire_Click(object sender, EventArgs e) { OpenChild(new frmQuestionnaireMaintenance()); }
        private void mnuAdminFunding_Click(object sender, EventArgs e) { OpenChild(new frmFundingMaintenance()); }

        private void mnuReportsSelection_Click(object sender, EventArgs e) { OpenChild(new frmReportSelection()); }

        private void mnuWindowCascade_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.Cascade); }
        private void mnuWindowTileVertical_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileVertical); }
        private void mnuWindowTileHorizontal_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileHorizontal); }
        private void mnuWindowArrangeIcons_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.ArrangeIcons); }
        private void mnuWindowCloseAll_Click(object sender, EventArgs e) { CloseAllChildren(); }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            UiHelpers.Info("Future Path - Student Advising System\n\nINF2011S Systems Design & Development.\n" +
                           "Guidance is preliminary and based on locally stored data. It is not an admission or funding decision.",
                           "About Future Path");
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            if (AppSession.Role == UserRole.CareerAdvisor || AppSession.Role == UserRole.Administrator)
            {
                OpenHome();
            }
            else if (AppSession.Role == UserRole.Learner)
            {
                OpenStep(new frmLearnerProfile());
            }
            else
            {
                OpenChild(new frmWelcome());
            }
        }

        private void tsbNewSession_Click(object sender, EventArgs e) { StartAdvising(); }
        private void tsbCascade_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.Cascade); }
        private void tsbTileVertical_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileVertical); }
        private void tsbTileHorizontal_Click(object sender, EventArgs e) { LayoutMdi(MdiLayout.TileHorizontal); }
        private void tsbCloseAll_Click(object sender, EventArgs e) { CloseAllChildren(); }
    }
}
