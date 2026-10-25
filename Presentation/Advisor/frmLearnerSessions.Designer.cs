namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmLearnerSessions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlSearchLearners = new System.Windows.Forms.Panel();
            this.pnlSearchLearnersAccent = new System.Windows.Forms.Panel();
            this.lblSearchLearnersTitle = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchGrade = new System.Windows.Forms.Label();
            this.cboSearchGrade = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.pnlResultsAccent = new System.Windows.Forms.Panel();
            this.lblResultsTitle = new System.Windows.Forms.Label();
            this.dgvLearners = new System.Windows.Forms.DataGridView();
            this.colLearnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectLearner = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlSessions = new System.Windows.Forms.Panel();
            this.pnlSessionsAccent = new System.Windows.Forms.Panel();
            this.lblSessionsTitle = new System.Windows.Forms.Label();
            this.dgvSessions = new System.Windows.Forms.DataGridView();
            this.colSessionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSessionOutcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewOutcome = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colViewSummary = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            this.btnNewSession = new System.Windows.Forms.Button();
            this.pnlSearchLearners.SuspendLayout();
            this.pnlSearchLearnersAccent.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.pnlResultsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).BeginInit();
            this.pnlSessions.SuspendLayout();
            this.pnlSessionsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblPageTitle.Location = new System.Drawing.Point(24, 16);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(900, 32);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Learners & Advisory Sessions";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Find a learner and inspect their saved guidance.";
            // 
            // pnlSearchLearners
            // 
            this.pnlSearchLearners.Controls.Add(this.pnlSearchLearnersAccent);
            this.pnlSearchLearners.Controls.Add(this.lblSearchLearnersTitle);
            this.pnlSearchLearners.Controls.Add(this.lblSearchName);
            this.pnlSearchLearners.Controls.Add(this.txtSearchName);
            this.pnlSearchLearners.Controls.Add(this.lblSearchGrade);
            this.pnlSearchLearners.Controls.Add(this.cboSearchGrade);
            this.pnlSearchLearners.Controls.Add(this.btnSearch);
            this.pnlSearchLearners.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSearchLearners.BackColor = System.Drawing.Color.White;
            this.pnlSearchLearners.Location = new System.Drawing.Point(24, 84);
            this.pnlSearchLearners.Name = "pnlSearchLearners";
            this.pnlSearchLearners.Size = new System.Drawing.Size(992, 132);
            this.pnlSearchLearners.TabIndex = 2;
            // 
            // pnlSearchLearnersAccent
            // 
            this.pnlSearchLearnersAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSearchLearnersAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchLearnersAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchLearnersAccent.Name = "pnlSearchLearnersAccent";
            this.pnlSearchLearnersAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlSearchLearnersAccent.TabIndex = 3;
            // 
            // lblSearchLearnersTitle
            // 
            this.lblSearchLearnersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchLearnersTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSearchLearnersTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSearchLearnersTitle.Name = "lblSearchLearnersTitle";
            this.lblSearchLearnersTitle.Size = new System.Drawing.Size(700, 20);
            this.lblSearchLearnersTitle.TabIndex = 4;
            this.lblSearchLearnersTitle.Text = "Search learners";
            // 
            // lblSearchName
            // 
            this.lblSearchName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSearchName.Location = new System.Drawing.Point(16, 44);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(470, 16);
            this.lblSearchName.TabIndex = 5;
            this.lblSearchName.Text = "Name or learner reference";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 63);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(470, 23);
            this.txtSearchName.TabIndex = 6;
            // 
            // lblSearchGrade
            // 
            this.lblSearchGrade.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSearchGrade.Location = new System.Drawing.Point(506, 44);
            this.lblSearchGrade.Name = "lblSearchGrade";
            this.lblSearchGrade.Size = new System.Drawing.Size(470, 16);
            this.lblSearchGrade.TabIndex = 7;
            this.lblSearchGrade.Text = "Grade";
            // 
            // cboSearchGrade
            // 
            this.cboSearchGrade.Items.AddRange(new object[] {
            "All grades",
            "Grade 11",
            "Grade 12"});
            this.cboSearchGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchGrade.FormattingEnabled = true;
            this.cboSearchGrade.Location = new System.Drawing.Point(506, 63);
            this.cboSearchGrade.Name = "cboSearchGrade";
            this.cboSearchGrade.Size = new System.Drawing.Size(470, 23);
            this.cboSearchGrade.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Location = new System.Drawing.Point(886, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.pnlResultsAccent);
            this.pnlResults.Controls.Add(this.lblResultsTitle);
            this.pnlResults.Controls.Add(this.dgvLearners);
            this.pnlResults.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlResults.BackColor = System.Drawing.Color.White;
            this.pnlResults.Location = new System.Drawing.Point(24, 230);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(992, 138);
            this.pnlResults.TabIndex = 10;
            // 
            // pnlResultsAccent
            // 
            this.pnlResultsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlResultsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlResultsAccent.Name = "pnlResultsAccent";
            this.pnlResultsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlResultsAccent.TabIndex = 11;
            // 
            // lblResultsTitle
            // 
            this.lblResultsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblResultsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblResultsTitle.Name = "lblResultsTitle";
            this.lblResultsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblResultsTitle.TabIndex = 12;
            this.lblResultsTitle.Text = "Search results";
            // 
            // dgvLearners
            // 
            this.dgvLearners.AllowUserToAddRows = false;
            this.dgvLearners.AllowUserToDeleteRows = false;
            this.dgvLearners.AllowUserToResizeRows = false;
            this.dgvLearners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLearners.BackgroundColor = System.Drawing.Color.White;
            this.dgvLearners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLearners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLearners.ColumnHeadersHeight = 30;
            this.dgvLearners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLearners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLearnerName,
            this.colGrade,
            this.colSchool,
            this.colSelectLearner});
            this.dgvLearners.EnableHeadersVisualStyles = false;
            this.dgvLearners.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvLearners.MultiSelect = false;
            this.dgvLearners.ReadOnly = true;
            this.dgvLearners.RowHeadersVisible = false;
            this.dgvLearners.RowTemplate.Height = 28;
            this.dgvLearners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLearners.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvLearners.Location = new System.Drawing.Point(16, 44);
            this.dgvLearners.Name = "dgvLearners";
            this.dgvLearners.Size = new System.Drawing.Size(960, 80);
            this.dgvLearners.TabIndex = 13;
            this.dgvLearners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLearners_CellContentClick);
            // 
            // colLearnerName
            // 
            this.colLearnerName.FillWeight = 120F;
            this.colLearnerName.HeaderText = "Learner";
            this.colLearnerName.Name = "colLearnerName";
            this.colLearnerName.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.FillWeight = 40F;
            this.colGrade.HeaderText = "Grade";
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // colSchool
            // 
            this.colSchool.FillWeight = 150F;
            this.colSchool.HeaderText = "School";
            this.colSchool.Name = "colSchool";
            this.colSchool.ReadOnly = true;
            // 
            // colSelectLearner
            // 
            this.colSelectLearner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelectLearner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSelectLearner.HeaderText = "Action";
            this.colSelectLearner.Name = "colSelectLearner";
            this.colSelectLearner.ReadOnly = true;
            this.colSelectLearner.Text = "Select Learner";
            this.colSelectLearner.UseColumnTextForButtonValue = true;
            this.colSelectLearner.Width = 110;
            // 
            // pnlSessions
            // 
            this.pnlSessions.Controls.Add(this.pnlSessionsAccent);
            this.pnlSessions.Controls.Add(this.lblSessionsTitle);
            this.pnlSessions.Controls.Add(this.dgvSessions);
            this.pnlSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSessions.BackColor = System.Drawing.Color.White;
            this.pnlSessions.Location = new System.Drawing.Point(24, 382);
            this.pnlSessions.Name = "pnlSessions";
            this.pnlSessions.Size = new System.Drawing.Size(992, 138);
            this.pnlSessions.TabIndex = 14;
            // 
            // pnlSessionsAccent
            // 
            this.pnlSessionsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSessionsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSessionsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSessionsAccent.Name = "pnlSessionsAccent";
            this.pnlSessionsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlSessionsAccent.TabIndex = 15;
            // 
            // lblSessionsTitle
            // 
            this.lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSessionsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSessionsTitle.Name = "lblSessionsTitle";
            this.lblSessionsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblSessionsTitle.TabIndex = 16;
            this.lblSessionsTitle.Text = "Selected learner's sessions";
            // 
            // dgvSessions
            // 
            this.dgvSessions.AllowUserToAddRows = false;
            this.dgvSessions.AllowUserToDeleteRows = false;
            this.dgvSessions.AllowUserToResizeRows = false;
            this.dgvSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgvSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSessions.ColumnHeadersHeight = 30;
            this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSessionDate,
            this.colSessionProgramme,
            this.colSessionOutcome,
            this.colViewOutcome,
            this.colViewSummary});
            this.dgvSessions.EnableHeadersVisualStyles = false;
            this.dgvSessions.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvSessions.MultiSelect = false;
            this.dgvSessions.ReadOnly = true;
            this.dgvSessions.RowHeadersVisible = false;
            this.dgvSessions.RowTemplate.Height = 28;
            this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvSessions.Location = new System.Drawing.Point(16, 44);
            this.dgvSessions.Name = "dgvSessions";
            this.dgvSessions.Size = new System.Drawing.Size(960, 80);
            this.dgvSessions.TabIndex = 17;
            this.dgvSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSessions_CellContentClick);
            // 
            // colSessionDate
            // 
            this.colSessionDate.FillWeight = 80F;
            this.colSessionDate.HeaderText = "Session date";
            this.colSessionDate.Name = "colSessionDate";
            this.colSessionDate.ReadOnly = true;
            // 
            // colSessionProgramme
            // 
            this.colSessionProgramme.FillWeight = 130F;
            this.colSessionProgramme.HeaderText = "Programme";
            this.colSessionProgramme.Name = "colSessionProgramme";
            this.colSessionProgramme.ReadOnly = true;
            // 
            // colSessionOutcome
            // 
            this.colSessionOutcome.FillWeight = 80F;
            this.colSessionOutcome.HeaderText = "Outcome";
            this.colSessionOutcome.Name = "colSessionOutcome";
            this.colSessionOutcome.ReadOnly = true;
            // 
            // colViewOutcome
            // 
            this.colViewOutcome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colViewOutcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colViewOutcome.HeaderText = "";
            this.colViewOutcome.Name = "colViewOutcome";
            this.colViewOutcome.ReadOnly = true;
            this.colViewOutcome.Text = "View Outcome";
            this.colViewOutcome.UseColumnTextForButtonValue = true;
            this.colViewOutcome.Width = 110;
            // 
            // colViewSummary
            // 
            this.colViewSummary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colViewSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colViewSummary.HeaderText = "";
            this.colViewSummary.Name = "colViewSummary";
            this.colViewSummary.ReadOnly = true;
            this.colViewSummary.Text = "View Summary";
            this.colViewSummary.UseColumnTextForButtonValue = true;
            this.colViewSummary.Width = 110;
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnBackToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnBackToDashboard.BackColor = System.Drawing.Color.White;
            this.btnBackToDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDashboard.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBackToDashboard.UseVisualStyleBackColor = false;
            this.btnBackToDashboard.Location = new System.Drawing.Point(653, 536);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(156, 32);
            this.btnBackToDashboard.TabIndex = 18;
            this.btnBackToDashboard.Text = "Back to Dashboard";
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // btnNewSession
            // 
            this.btnNewSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSession.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnNewSession.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnNewSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSession.ForeColor = System.Drawing.Color.White;
            this.btnNewSession.UseVisualStyleBackColor = false;
            this.btnNewSession.Location = new System.Drawing.Point(817, 536);
            this.btnNewSession.Name = "btnNewSession";
            this.btnNewSession.Size = new System.Drawing.Size(199, 32);
            this.btnNewSession.TabIndex = 19;
            this.btnNewSession.Text = "Assist with New Session";
            this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
            // 
            // frmLearnerSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 584);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnNewSession);
            this.Controls.Add(this.btnBackToDashboard);
            this.Controls.Add(this.pnlSessions);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlSearchLearners);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmLearnerSessions";
            this.ShowIcon = false;
            this.Text = "Learners & Advisory Sessions";
            this.Load += new System.EventHandler(this.frmLearnerSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
            this.pnlSessionsAccent.ResumeLayout(false);
            this.pnlSessions.ResumeLayout(false);
            this.pnlSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLearners)).EndInit();
            this.pnlResultsAccent.ResumeLayout(false);
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.pnlSearchLearnersAccent.ResumeLayout(false);
            this.pnlSearchLearners.ResumeLayout(false);
            this.pnlSearchLearners.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSearchLearners;
        private System.Windows.Forms.Panel pnlSearchLearnersAccent;
        private System.Windows.Forms.Label lblSearchLearnersTitle;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchGrade;
        private System.Windows.Forms.ComboBox cboSearchGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Panel pnlResultsAccent;
        private System.Windows.Forms.Label lblResultsTitle;
        private System.Windows.Forms.DataGridView dgvLearners;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLearnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSchool;
        private System.Windows.Forms.DataGridViewButtonColumn colSelectLearner;
        private System.Windows.Forms.Panel pnlSessions;
        private System.Windows.Forms.Panel pnlSessionsAccent;
        private System.Windows.Forms.Label lblSessionsTitle;
        private System.Windows.Forms.DataGridView dgvSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSessionOutcome;
        private System.Windows.Forms.DataGridViewButtonColumn colViewOutcome;
        private System.Windows.Forms.DataGridViewButtonColumn colViewSummary;
        private System.Windows.Forms.Button btnBackToDashboard;
        private System.Windows.Forms.Button btnNewSession;
    }
}
