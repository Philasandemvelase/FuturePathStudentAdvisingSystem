namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmAdvisorySummary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlSummaryHeader = new System.Windows.Forms.Panel();
            this.pnlSummaryHeaderAccent = new System.Windows.Forms.Panel();
            this.lblLearnerHeading = new System.Windows.Forms.Label();
            this.lblProgrammeCaption = new System.Windows.Forms.Label();
            this.lblSelectedProgramme = new System.Windows.Forms.Label();
            this.lblOutcomeCaption = new System.Windows.Forms.Label();
            this.lblOutcomeValue = new System.Windows.Forms.Label();
            this.pnlAcademicProfile = new System.Windows.Forms.Panel();
            this.pnlAcademicProfileAccent = new System.Windows.Forms.Panel();
            this.lblAcademicProfileTitle = new System.Windows.Forms.Label();
            this.dgvAcademicProfile = new System.Windows.Forms.DataGridView();
            this.pnlAdvisoryDetails = new System.Windows.Forms.Panel();
            this.pnlAdvisoryDetailsAccent = new System.Windows.Forms.Panel();
            this.lblAdvisoryDetailsTitle = new System.Windows.Forms.Label();
            this.lblDetailInterests = new System.Windows.Forms.Label();
            this.lblDetailGaps = new System.Windows.Forms.Label();
            this.lblDetailAlternatives = new System.Windows.Forms.Label();
            this.lblDetailFunding = new System.Windows.Forms.Label();
            this.lblDetailDateGenerated = new System.Windows.Forms.Label();
            this.btnBackToOutcome = new System.Windows.Forms.Button();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dlgSaveSummary = new System.Windows.Forms.SaveFileDialog();
            this.pnlSummaryHeader.SuspendLayout();
            this.pnlSummaryHeaderAccent.SuspendLayout();
            this.pnlAcademicProfile.SuspendLayout();
            this.pnlAcademicProfileAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicProfile)).BeginInit();
            this.pnlAdvisoryDetails.SuspendLayout();
            this.pnlAdvisoryDetailsAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Advisory Summary";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Review your session before saving a shareable copy.";
            // 
            // pnlSummaryHeader
            // 
            this.pnlSummaryHeader.Controls.Add(this.pnlSummaryHeaderAccent);
            this.pnlSummaryHeader.Controls.Add(this.lblLearnerHeading);
            this.pnlSummaryHeader.Controls.Add(this.lblProgrammeCaption);
            this.pnlSummaryHeader.Controls.Add(this.lblSelectedProgramme);
            this.pnlSummaryHeader.Controls.Add(this.lblOutcomeCaption);
            this.pnlSummaryHeader.Controls.Add(this.lblOutcomeValue);
            this.pnlSummaryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSummaryHeader.BackColor = System.Drawing.Color.White;
            this.pnlSummaryHeader.Location = new System.Drawing.Point(24, 84);
            this.pnlSummaryHeader.Name = "pnlSummaryHeader";
            this.pnlSummaryHeader.Size = new System.Drawing.Size(992, 84);
            this.pnlSummaryHeader.TabIndex = 2;
            // 
            // pnlSummaryHeaderAccent
            // 
            this.pnlSummaryHeaderAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSummaryHeaderAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummaryHeaderAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSummaryHeaderAccent.Name = "pnlSummaryHeaderAccent";
            this.pnlSummaryHeaderAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlSummaryHeaderAccent.TabIndex = 3;
            // 
            // lblLearnerHeading
            // 
            this.lblLearnerHeading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnerHeading.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblLearnerHeading.Location = new System.Drawing.Point(16, 14);
            this.lblLearnerHeading.Name = "lblLearnerHeading";
            this.lblLearnerHeading.Size = new System.Drawing.Size(600, 20);
            this.lblLearnerHeading.TabIndex = 4;
            this.lblLearnerHeading.Text = "Gadija Jacobs · Grade 12";
            // 
            // lblProgrammeCaption
            // 
            this.lblProgrammeCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammeCaption.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblProgrammeCaption.Location = new System.Drawing.Point(16, 38);
            this.lblProgrammeCaption.Name = "lblProgrammeCaption";
            this.lblProgrammeCaption.Size = new System.Drawing.Size(300, 16);
            this.lblProgrammeCaption.TabIndex = 5;
            this.lblProgrammeCaption.Text = "Selected programme · retrieved";
            // 
            // lblSelectedProgramme
            // 
            this.lblSelectedProgramme.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProgramme.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSelectedProgramme.Location = new System.Drawing.Point(16, 56);
            this.lblSelectedProgramme.Name = "lblSelectedProgramme";
            this.lblSelectedProgramme.Size = new System.Drawing.Size(400, 20);
            this.lblSelectedProgramme.TabIndex = 6;
            this.lblSelectedProgramme.Text = "BCom Information Systems";
            // 
            // lblOutcomeCaption
            // 
            this.lblOutcomeCaption.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcomeCaption.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblOutcomeCaption.Location = new System.Drawing.Point(506, 38);
            this.lblOutcomeCaption.Name = "lblOutcomeCaption";
            this.lblOutcomeCaption.Size = new System.Drawing.Size(300, 16);
            this.lblOutcomeCaption.TabIndex = 7;
            this.lblOutcomeCaption.Text = "Outcome · calculated";
            // 
            // lblOutcomeValue
            // 
            this.lblOutcomeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcomeValue.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblOutcomeValue.Location = new System.Drawing.Point(506, 56);
            this.lblOutcomeValue.Name = "lblOutcomeValue";
            this.lblOutcomeValue.Size = new System.Drawing.Size(400, 20);
            this.lblOutcomeValue.TabIndex = 8;
            this.lblOutcomeValue.Text = "Strong Match";
            // 
            // pnlAcademicProfile
            // 
            this.pnlAcademicProfile.Controls.Add(this.pnlAcademicProfileAccent);
            this.pnlAcademicProfile.Controls.Add(this.lblAcademicProfileTitle);
            this.pnlAcademicProfile.Controls.Add(this.dgvAcademicProfile);
            this.pnlAcademicProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlAcademicProfile.BackColor = System.Drawing.Color.White;
            this.pnlAcademicProfile.Location = new System.Drawing.Point(24, 182);
            this.pnlAcademicProfile.Name = "pnlAcademicProfile";
            this.pnlAcademicProfile.Size = new System.Drawing.Size(992, 112);
            this.pnlAcademicProfile.TabIndex = 9;
            // 
            // pnlAcademicProfileAccent
            // 
            this.pnlAcademicProfileAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlAcademicProfileAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAcademicProfileAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAcademicProfileAccent.Name = "pnlAcademicProfileAccent";
            this.pnlAcademicProfileAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlAcademicProfileAccent.TabIndex = 10;
            // 
            // lblAcademicProfileTitle
            // 
            this.lblAcademicProfileTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicProfileTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAcademicProfileTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAcademicProfileTitle.Name = "lblAcademicProfileTitle";
            this.lblAcademicProfileTitle.Size = new System.Drawing.Size(700, 20);
            this.lblAcademicProfileTitle.TabIndex = 11;
            this.lblAcademicProfileTitle.Text = "Academic profile";
            // 
            // dgvAcademicProfile
            // 
            this.dgvAcademicProfile.AllowUserToAddRows = false;
            this.dgvAcademicProfile.AllowUserToDeleteRows = false;
            this.dgvAcademicProfile.AllowUserToResizeRows = false;
            this.dgvAcademicProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcademicProfile.BackgroundColor = System.Drawing.Color.White;
            this.dgvAcademicProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcademicProfile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcademicProfile.ColumnHeadersHeight = 30;
            this.dgvAcademicProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAcademicProfile.EnableHeadersVisualStyles = false;
            this.dgvAcademicProfile.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvAcademicProfile.MultiSelect = false;
            this.dgvAcademicProfile.ReadOnly = true;
            this.dgvAcademicProfile.RowHeadersVisible = false;
            this.dgvAcademicProfile.RowTemplate.Height = 28;
            this.dgvAcademicProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcademicProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvAcademicProfile.Location = new System.Drawing.Point(16, 42);
            this.dgvAcademicProfile.Name = "dgvAcademicProfile";
            this.dgvAcademicProfile.Size = new System.Drawing.Size(960, 58);
            this.dgvAcademicProfile.TabIndex = 12;
            // 
            // pnlAdvisoryDetails
            // 
            this.pnlAdvisoryDetails.Controls.Add(this.pnlAdvisoryDetailsAccent);
            this.pnlAdvisoryDetails.Controls.Add(this.lblAdvisoryDetailsTitle);
            this.pnlAdvisoryDetails.Controls.Add(this.lblDetailInterests);
            this.pnlAdvisoryDetails.Controls.Add(this.lblDetailGaps);
            this.pnlAdvisoryDetails.Controls.Add(this.lblDetailAlternatives);
            this.pnlAdvisoryDetails.Controls.Add(this.lblDetailFunding);
            this.pnlAdvisoryDetails.Controls.Add(this.lblDetailDateGenerated);
            this.pnlAdvisoryDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlAdvisoryDetails.BackColor = System.Drawing.Color.White;
            this.pnlAdvisoryDetails.Location = new System.Drawing.Point(24, 308);
            this.pnlAdvisoryDetails.Name = "pnlAdvisoryDetails";
            this.pnlAdvisoryDetails.Size = new System.Drawing.Size(992, 150);
            this.pnlAdvisoryDetails.TabIndex = 13;
            // 
            // pnlAdvisoryDetailsAccent
            // 
            this.pnlAdvisoryDetailsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlAdvisoryDetailsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdvisoryDetailsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAdvisoryDetailsAccent.Name = "pnlAdvisoryDetailsAccent";
            this.pnlAdvisoryDetailsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlAdvisoryDetailsAccent.TabIndex = 14;
            // 
            // lblAdvisoryDetailsTitle
            // 
            this.lblAdvisoryDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisoryDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAdvisoryDetailsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAdvisoryDetailsTitle.Name = "lblAdvisoryDetailsTitle";
            this.lblAdvisoryDetailsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblAdvisoryDetailsTitle.TabIndex = 15;
            this.lblAdvisoryDetailsTitle.Text = "Advisory details";
            // 
            // lblDetailInterests
            // 
            this.lblDetailInterests.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailInterests.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDetailInterests.Location = new System.Drawing.Point(16, 40);
            this.lblDetailInterests.Name = "lblDetailInterests";
            this.lblDetailInterests.Size = new System.Drawing.Size(940, 18);
            this.lblDetailInterests.TabIndex = 16;
            this.lblDetailInterests.Text = "Interests: Strong alignment with Numbers and Technology; Business and Finance.";
            // 
            // lblDetailGaps
            // 
            this.lblDetailGaps.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailGaps.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDetailGaps.Location = new System.Drawing.Point(16, 61);
            this.lblDetailGaps.Name = "lblDetailGaps";
            this.lblDetailGaps.Size = new System.Drawing.Size(940, 18);
            this.lblDetailGaps.TabIndex = 17;
            this.lblDetailGaps.Text = "Gaps: None identified against the programme rules.";
            // 
            // lblDetailAlternatives
            // 
            this.lblDetailAlternatives.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailAlternatives.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDetailAlternatives.Location = new System.Drawing.Point(16, 82);
            this.lblDetailAlternatives.Name = "lblDetailAlternatives";
            this.lblDetailAlternatives.Size = new System.Drawing.Size(940, 18);
            this.lblDetailAlternatives.TabIndex = 18;
            this.lblDetailAlternatives.Text = "Alternatives: BCom General; BA Humanities.";
            // 
            // lblDetailFunding
            // 
            this.lblDetailFunding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailFunding.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDetailFunding.Location = new System.Drawing.Point(16, 103);
            this.lblDetailFunding.Name = "lblDetailFunding";
            this.lblDetailFunding.Size = new System.Drawing.Size(940, 18);
            this.lblDetailFunding.TabIndex = 19;
            this.lblDetailFunding.Text = "Funding: Commerce Merit Award (requested).";
            // 
            // lblDetailDateGenerated
            // 
            this.lblDetailDateGenerated.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblDetailDateGenerated.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDetailDateGenerated.Location = new System.Drawing.Point(16, 124);
            this.lblDetailDateGenerated.Name = "lblDetailDateGenerated";
            this.lblDetailDateGenerated.Size = new System.Drawing.Size(940, 18);
            this.lblDetailDateGenerated.TabIndex = 20;
            this.lblDetailDateGenerated.Text = "Date generated: 11 September 2026";
            // 
            // btnBackToOutcome
            // 
            this.btnBackToOutcome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnBackToOutcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOutcome.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnBackToOutcome.BackColor = System.Drawing.Color.White;
            this.btnBackToOutcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToOutcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToOutcome.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBackToOutcome.UseVisualStyleBackColor = false;
            this.btnBackToOutcome.Location = new System.Drawing.Point(560, 474);
            this.btnBackToOutcome.Name = "btnBackToOutcome";
            this.btnBackToOutcome.Size = new System.Drawing.Size(142, 32);
            this.btnBackToOutcome.TabIndex = 21;
            this.btnBackToOutcome.Text = "Back to Outcome";
            this.btnBackToOutcome.Click += new System.EventHandler(this.btnBackToOutcome_Click);
            // 
            // btnEndSession
            // 
            this.btnEndSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnEndSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndSession.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnEndSession.BackColor = System.Drawing.Color.White;
            this.btnEndSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSession.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnEndSession.UseVisualStyleBackColor = false;
            this.btnEndSession.Location = new System.Drawing.Point(710, 474);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(113, 32);
            this.btnEndSession.TabIndex = 22;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Location = new System.Drawing.Point(831, 474);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(185, 32);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Export / Save Summary";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dlgSaveSummary
            // 
            this.dlgSaveSummary.Filter = "Text file (*.txt)|*.txt";
            this.dlgSaveSummary.Title = "Save advisory summary";
            // 
            // frmAdvisorySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 522);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnEndSession);
            this.Controls.Add(this.btnBackToOutcome);
            this.Controls.Add(this.pnlAdvisoryDetails);
            this.Controls.Add(this.pnlAcademicProfile);
            this.Controls.Add(this.pnlSummaryHeader);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmAdvisorySummary";
            this.ShowIcon = false;
            this.Text = "Advisory Summary";
            this.Load += new System.EventHandler(this.frmAdvisorySummary_Load);
            this.pnlAdvisoryDetailsAccent.ResumeLayout(false);
            this.pnlAdvisoryDetails.ResumeLayout(false);
            this.pnlAdvisoryDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicProfile)).EndInit();
            this.pnlAcademicProfileAccent.ResumeLayout(false);
            this.pnlAcademicProfile.ResumeLayout(false);
            this.pnlAcademicProfile.PerformLayout();
            this.pnlSummaryHeaderAccent.ResumeLayout(false);
            this.pnlSummaryHeader.ResumeLayout(false);
            this.pnlSummaryHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSummaryHeader;
        private System.Windows.Forms.Panel pnlSummaryHeaderAccent;
        private System.Windows.Forms.Label lblLearnerHeading;
        private System.Windows.Forms.Label lblProgrammeCaption;
        private System.Windows.Forms.Label lblSelectedProgramme;
        private System.Windows.Forms.Label lblOutcomeCaption;
        private System.Windows.Forms.Label lblOutcomeValue;
        private System.Windows.Forms.Panel pnlAcademicProfile;
        private System.Windows.Forms.Panel pnlAcademicProfileAccent;
        private System.Windows.Forms.Label lblAcademicProfileTitle;
        private System.Windows.Forms.DataGridView dgvAcademicProfile;
        private System.Windows.Forms.Panel pnlAdvisoryDetails;
        private System.Windows.Forms.Panel pnlAdvisoryDetailsAccent;
        private System.Windows.Forms.Label lblAdvisoryDetailsTitle;
        private System.Windows.Forms.Label lblDetailInterests;
        private System.Windows.Forms.Label lblDetailGaps;
        private System.Windows.Forms.Label lblDetailAlternatives;
        private System.Windows.Forms.Label lblDetailFunding;
        private System.Windows.Forms.Label lblDetailDateGenerated;
        private System.Windows.Forms.Button btnBackToOutcome;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog dlgSaveSummary;
    }
}
