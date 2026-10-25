namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmAdvisorDashboard
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlLearners = new System.Windows.Forms.Panel();
            this.pnlLearnersAccent = new System.Windows.Forms.Panel();
            this.lblLearnersTitle = new System.Windows.Forms.Label();
            this.lblLearnersDesc = new System.Windows.Forms.Label();
            this.btnSearchLearners = new System.Windows.Forms.Button();
            this.pnlSessions = new System.Windows.Forms.Panel();
            this.pnlSessionsAccent = new System.Windows.Forms.Panel();
            this.lblSessionsTitle = new System.Windows.Forms.Label();
            this.lblSessionsDesc = new System.Windows.Forms.Label();
            this.btnViewSessions = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.pnlReportsAccent = new System.Windows.Forms.Panel();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.lblReportsDesc = new System.Windows.Forms.Label();
            this.btnSelectReport = new System.Windows.Forms.Button();
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.pnlRecentAccent = new System.Windows.Forms.Panel();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecentSessions = new System.Windows.Forms.DataGridView();
            this.colLearner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutcome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlLearners.SuspendLayout();
            this.pnlLearnersAccent.SuspendLayout();
            this.pnlSessions.SuspendLayout();
            this.pnlSessionsAccent.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.pnlReportsAccent.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            this.pnlRecentAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSessions)).BeginInit();
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
            this.lblPageTitle.Text = "Career Advisor Dashboard";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Review learners, advisory sessions and guidance reports.";
            // 
            // pnlLearners
            // 
            this.pnlLearners.Controls.Add(this.pnlLearnersAccent);
            this.pnlLearners.Controls.Add(this.lblLearnersTitle);
            this.pnlLearners.Controls.Add(this.lblLearnersDesc);
            this.pnlLearners.Controls.Add(this.btnSearchLearners);
            this.pnlLearners.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.pnlLearners.BackColor = System.Drawing.Color.White;
            this.pnlLearners.Location = new System.Drawing.Point(24, 84);
            this.pnlLearners.Name = "pnlLearners";
            this.pnlLearners.Size = new System.Drawing.Size(489, 98);
            this.pnlLearners.TabIndex = 2;
            // 
            // pnlLearnersAccent
            // 
            this.pnlLearnersAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlLearnersAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLearnersAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlLearnersAccent.Name = "pnlLearnersAccent";
            this.pnlLearnersAccent.Size = new System.Drawing.Size(489, 3);
            this.pnlLearnersAccent.TabIndex = 3;
            // 
            // lblLearnersTitle
            // 
            this.lblLearnersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnersTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblLearnersTitle.Location = new System.Drawing.Point(16, 14);
            this.lblLearnersTitle.Name = "lblLearnersTitle";
            this.lblLearnersTitle.Size = new System.Drawing.Size(400, 20);
            this.lblLearnersTitle.TabIndex = 4;
            this.lblLearnersTitle.Text = "Learners";
            // 
            // lblLearnersDesc
            // 
            this.lblLearnersDesc.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblLearnersDesc.Location = new System.Drawing.Point(16, 40);
            this.lblLearnersDesc.Name = "lblLearnersDesc";
            this.lblLearnersDesc.Size = new System.Drawing.Size(457, 18);
            this.lblLearnersDesc.TabIndex = 5;
            this.lblLearnersDesc.Text = "Find a learner and review their advising information.";
            // 
            // btnSearchLearners
            // 
            this.btnSearchLearners.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSearchLearners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchLearners.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSearchLearners.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSearchLearners.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchLearners.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLearners.ForeColor = System.Drawing.Color.White;
            this.btnSearchLearners.UseVisualStyleBackColor = false;
            this.btnSearchLearners.Location = new System.Drawing.Point(331, 56);
            this.btnSearchLearners.Name = "btnSearchLearners";
            this.btnSearchLearners.Size = new System.Drawing.Size(142, 32);
            this.btnSearchLearners.TabIndex = 6;
            this.btnSearchLearners.Text = "Search Learners";
            this.btnSearchLearners.Click += new System.EventHandler(this.btnSearchLearners_Click);
            // 
            // pnlSessions
            // 
            this.pnlSessions.Controls.Add(this.pnlSessionsAccent);
            this.pnlSessions.Controls.Add(this.lblSessionsTitle);
            this.pnlSessions.Controls.Add(this.lblSessionsDesc);
            this.pnlSessions.Controls.Add(this.btnViewSessions);
            this.pnlSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.pnlSessions.BackColor = System.Drawing.Color.White;
            this.pnlSessions.Location = new System.Drawing.Point(527, 84);
            this.pnlSessions.Name = "pnlSessions";
            this.pnlSessions.Size = new System.Drawing.Size(489, 98);
            this.pnlSessions.TabIndex = 7;
            // 
            // pnlSessionsAccent
            // 
            this.pnlSessionsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSessionsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSessionsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSessionsAccent.Name = "pnlSessionsAccent";
            this.pnlSessionsAccent.Size = new System.Drawing.Size(489, 3);
            this.pnlSessionsAccent.TabIndex = 8;
            // 
            // lblSessionsTitle
            // 
            this.lblSessionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSessionsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSessionsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSessionsTitle.Name = "lblSessionsTitle";
            this.lblSessionsTitle.Size = new System.Drawing.Size(400, 20);
            this.lblSessionsTitle.TabIndex = 9;
            this.lblSessionsTitle.Text = "Advisory sessions";
            // 
            // lblSessionsDesc
            // 
            this.lblSessionsDesc.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSessionsDesc.Location = new System.Drawing.Point(16, 40);
            this.lblSessionsDesc.Name = "lblSessionsDesc";
            this.lblSessionsDesc.Size = new System.Drawing.Size(457, 18);
            this.lblSessionsDesc.TabIndex = 10;
            this.lblSessionsDesc.Text = "Review saved outcomes and summaries.";
            // 
            // btnViewSessions
            // 
            this.btnViewSessions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnViewSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnViewSessions.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnViewSessions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSessions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSessions.ForeColor = System.Drawing.Color.White;
            this.btnViewSessions.UseVisualStyleBackColor = false;
            this.btnViewSessions.Location = new System.Drawing.Point(346, 56);
            this.btnViewSessions.Name = "btnViewSessions";
            this.btnViewSessions.Size = new System.Drawing.Size(127, 32);
            this.btnViewSessions.TabIndex = 11;
            this.btnViewSessions.Text = "View Sessions";
            this.btnViewSessions.Click += new System.EventHandler(this.btnViewSessions_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.pnlReportsAccent);
            this.pnlReports.Controls.Add(this.lblReportsTitle);
            this.pnlReports.Controls.Add(this.lblReportsDesc);
            this.pnlReports.Controls.Add(this.btnSelectReport);
            this.pnlReports.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.pnlReports.BackColor = System.Drawing.Color.White;
            this.pnlReports.Location = new System.Drawing.Point(24, 196);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(489, 98);
            this.pnlReports.TabIndex = 12;
            // 
            // pnlReportsAccent
            // 
            this.pnlReportsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlReportsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlReportsAccent.Name = "pnlReportsAccent";
            this.pnlReportsAccent.Size = new System.Drawing.Size(489, 3);
            this.pnlReportsAccent.TabIndex = 13;
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblReportsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(400, 20);
            this.lblReportsTitle.TabIndex = 14;
            this.lblReportsTitle.Text = "Reports";
            // 
            // lblReportsDesc
            // 
            this.lblReportsDesc.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblReportsDesc.Location = new System.Drawing.Point(16, 40);
            this.lblReportsDesc.Name = "lblReportsDesc";
            this.lblReportsDesc.Size = new System.Drawing.Size(457, 18);
            this.lblReportsDesc.TabIndex = 15;
            this.lblReportsDesc.Text = "Generate summaries and exception reports.";
            // 
            // btnSelectReport
            // 
            this.btnSelectReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSelectReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectReport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSelectReport.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSelectReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectReport.ForeColor = System.Drawing.Color.White;
            this.btnSelectReport.UseVisualStyleBackColor = false;
            this.btnSelectReport.Location = new System.Drawing.Point(346, 56);
            this.btnSelectReport.Name = "btnSelectReport";
            this.btnSelectReport.Size = new System.Drawing.Size(127, 32);
            this.btnSelectReport.TabIndex = 16;
            this.btnSelectReport.Text = "Select Report";
            this.btnSelectReport.Click += new System.EventHandler(this.btnSelectReport_Click);
            // 
            // pnlRecent
            // 
            this.pnlRecent.Controls.Add(this.pnlRecentAccent);
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.Controls.Add(this.dgvRecentSessions);
            this.pnlRecent.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRecent.BackColor = System.Drawing.Color.White;
            this.pnlRecent.Location = new System.Drawing.Point(24, 308);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Size = new System.Drawing.Size(992, 176);
            this.pnlRecent.TabIndex = 17;
            // 
            // pnlRecentAccent
            // 
            this.pnlRecentAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlRecentAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlRecentAccent.Name = "pnlRecentAccent";
            this.pnlRecentAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlRecentAccent.TabIndex = 18;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRecentTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(700, 20);
            this.lblRecentTitle.TabIndex = 19;
            this.lblRecentTitle.Text = "Recent advisory sessions";
            // 
            // dgvRecentSessions
            // 
            this.dgvRecentSessions.AllowUserToAddRows = false;
            this.dgvRecentSessions.AllowUserToDeleteRows = false;
            this.dgvRecentSessions.AllowUserToResizeRows = false;
            this.dgvRecentSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentSessions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentSessions.ColumnHeadersHeight = 30;
            this.dgvRecentSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLearner,
            this.colProgramme,
            this.colOutcome,
            this.colOpen});
            this.dgvRecentSessions.EnableHeadersVisualStyles = false;
            this.dgvRecentSessions.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvRecentSessions.MultiSelect = false;
            this.dgvRecentSessions.ReadOnly = true;
            this.dgvRecentSessions.RowHeadersVisible = false;
            this.dgvRecentSessions.RowTemplate.Height = 28;
            this.dgvRecentSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvRecentSessions.Location = new System.Drawing.Point(16, 44);
            this.dgvRecentSessions.Name = "dgvRecentSessions";
            this.dgvRecentSessions.Size = new System.Drawing.Size(960, 118);
            this.dgvRecentSessions.TabIndex = 20;
            this.dgvRecentSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentSessions_CellContentClick);
            // 
            // colLearner
            // 
            this.colLearner.FillWeight = 100F;
            this.colLearner.HeaderText = "Learner";
            this.colLearner.Name = "colLearner";
            this.colLearner.ReadOnly = true;
            // 
            // colProgramme
            // 
            this.colProgramme.FillWeight = 120F;
            this.colProgramme.HeaderText = "Programme";
            this.colProgramme.Name = "colProgramme";
            this.colProgramme.ReadOnly = true;
            // 
            // colOutcome
            // 
            this.colOutcome.FillWeight = 100F;
            this.colOutcome.HeaderText = "Outcome";
            this.colOutcome.Name = "colOutcome";
            this.colOutcome.ReadOnly = true;
            // 
            // colOpen
            // 
            this.colOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colOpen.HeaderText = "Action";
            this.colOpen.Name = "colOpen";
            this.colOpen.ReadOnly = true;
            this.colOpen.Text = "Open";
            this.colOpen.UseColumnTextForButtonValue = true;
            this.colOpen.Width = 80;
            // 
            // frmAdvisorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 500);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.pnlRecent);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlSessions);
            this.Controls.Add(this.pnlLearners);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmAdvisorDashboard";
            this.ShowIcon = false;
            this.Text = "Career Advisor Dashboard";
            this.Load += new System.EventHandler(this.frmAdvisorDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentSessions)).EndInit();
            this.pnlRecentAccent.ResumeLayout(false);
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecent.PerformLayout();
            this.pnlReportsAccent.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.pnlSessionsAccent.ResumeLayout(false);
            this.pnlSessions.ResumeLayout(false);
            this.pnlSessions.PerformLayout();
            this.pnlLearnersAccent.ResumeLayout(false);
            this.pnlLearners.ResumeLayout(false);
            this.pnlLearners.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlLearners;
        private System.Windows.Forms.Panel pnlLearnersAccent;
        private System.Windows.Forms.Label lblLearnersTitle;
        private System.Windows.Forms.Label lblLearnersDesc;
        private System.Windows.Forms.Button btnSearchLearners;
        private System.Windows.Forms.Panel pnlSessions;
        private System.Windows.Forms.Panel pnlSessionsAccent;
        private System.Windows.Forms.Label lblSessionsTitle;
        private System.Windows.Forms.Label lblSessionsDesc;
        private System.Windows.Forms.Button btnViewSessions;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlReportsAccent;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsDesc;
        private System.Windows.Forms.Button btnSelectReport;
        private System.Windows.Forms.Panel pnlRecent;
        private System.Windows.Forms.Panel pnlRecentAccent;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecentSessions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLearner;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutcome;
        private System.Windows.Forms.DataGridViewButtonColumn colOpen;
    }
}
