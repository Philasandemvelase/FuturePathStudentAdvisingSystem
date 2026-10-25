namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmReportSelection
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlReportOptions = new System.Windows.Forms.Panel();
            this.pnlReportOptionsAccent = new System.Windows.Forms.Panel();
            this.lblReportOptionsTitle = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.cboReport = new System.Windows.Forms.ComboBox();
            this.lblAvailableReports = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlFiltersAccent = new System.Windows.Forms.Panel();
            this.lblFiltersTitle = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.cboProgramme = new System.Windows.Forms.ComboBox();
            this.lblLearner = new System.Windows.Forms.Label();
            this.cboLearner = new System.Windows.Forms.ComboBox();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlReportOptions.SuspendLayout();
            this.pnlReportOptionsAccent.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlFiltersAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
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
            this.lblPageTitle.Text = "Report Selection";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Choose an authorised report and its selection criteria.";
            // 
            // pnlReportOptions
            // 
            this.pnlReportOptions.Controls.Add(this.pnlReportOptionsAccent);
            this.pnlReportOptions.Controls.Add(this.lblReportOptionsTitle);
            this.pnlReportOptions.Controls.Add(this.lblReport);
            this.pnlReportOptions.Controls.Add(this.cboReport);
            this.pnlReportOptions.Controls.Add(this.lblAvailableReports);
            this.pnlReportOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlReportOptions.BackColor = System.Drawing.Color.White;
            this.pnlReportOptions.Location = new System.Drawing.Point(24, 84);
            this.pnlReportOptions.Name = "pnlReportOptions";
            this.pnlReportOptions.Size = new System.Drawing.Size(992, 120);
            this.pnlReportOptions.TabIndex = 2;
            // 
            // pnlReportOptionsAccent
            // 
            this.pnlReportOptionsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlReportOptionsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportOptionsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlReportOptionsAccent.Name = "pnlReportOptionsAccent";
            this.pnlReportOptionsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlReportOptionsAccent.TabIndex = 3;
            // 
            // lblReportOptionsTitle
            // 
            this.lblReportOptionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportOptionsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblReportOptionsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblReportOptionsTitle.Name = "lblReportOptionsTitle";
            this.lblReportOptionsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblReportOptionsTitle.TabIndex = 4;
            this.lblReportOptionsTitle.Text = "Report options";
            // 
            // lblReport
            // 
            this.lblReport.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblReport.Location = new System.Drawing.Point(16, 44);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(960, 16);
            this.lblReport.TabIndex = 5;
            this.lblReport.Text = "Report *";
            // 
            // cboReport
            // 
            this.cboReport.Items.AddRange(new object[] {
            "Learner Advisory Summary",
            "Degree Interest and Eligibility Report",
            "Learners Not Currently Eligible Exception Report"});
            this.cboReport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.cboReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReport.FormattingEnabled = true;
            this.cboReport.Location = new System.Drawing.Point(16, 63);
            this.cboReport.Name = "cboReport";
            this.cboReport.Size = new System.Drawing.Size(960, 23);
            this.cboReport.TabIndex = 6;
            this.cboReport.SelectedIndexChanged += new System.EventHandler(this.cboReport_SelectedIndexChanged);
            // 
            // lblAvailableReports
            // 
            this.lblAvailableReports.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblAvailableReports.Location = new System.Drawing.Point(16, 92);
            this.lblAvailableReports.Name = "lblAvailableReports";
            this.lblAvailableReports.Size = new System.Drawing.Size(940, 18);
            this.lblAvailableReports.TabIndex = 7;
            this.lblAvailableReports.Text = "Available reports: Learner Advisory Summary; Degree Interest and Eligibility; Learners Not Currently Eligible Exception.";
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.pnlFiltersAccent);
            this.pnlFilters.Controls.Add(this.lblFiltersTitle);
            this.pnlFilters.Controls.Add(this.lblFromDate);
            this.pnlFilters.Controls.Add(this.dtpFromDate);
            this.pnlFilters.Controls.Add(this.lblToDate);
            this.pnlFilters.Controls.Add(this.dtpToDate);
            this.pnlFilters.Controls.Add(this.lblFaculty);
            this.pnlFilters.Controls.Add(this.cboFaculty);
            this.pnlFilters.Controls.Add(this.lblProgramme);
            this.pnlFilters.Controls.Add(this.cboProgramme);
            this.pnlFilters.Controls.Add(this.lblLearner);
            this.pnlFilters.Controls.Add(this.cboLearner);
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Location = new System.Drawing.Point(24, 218);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(992, 202);
            this.pnlFilters.TabIndex = 8;
            // 
            // pnlFiltersAccent
            // 
            this.pnlFiltersAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlFiltersAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltersAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltersAccent.Name = "pnlFiltersAccent";
            this.pnlFiltersAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlFiltersAccent.TabIndex = 9;
            // 
            // lblFiltersTitle
            // 
            this.lblFiltersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltersTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFiltersTitle.Location = new System.Drawing.Point(16, 14);
            this.lblFiltersTitle.Name = "lblFiltersTitle";
            this.lblFiltersTitle.Size = new System.Drawing.Size(700, 20);
            this.lblFiltersTitle.TabIndex = 10;
            this.lblFiltersTitle.Text = "Filters";
            // 
            // lblFromDate
            // 
            this.lblFromDate.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFromDate.Location = new System.Drawing.Point(16, 44);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(470, 16);
            this.lblFromDate.TabIndex = 11;
            this.lblFromDate.Text = "From date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd MMMM yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(16, 63);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(470, 23);
            this.dtpFromDate.TabIndex = 12;
            // 
            // lblToDate
            // 
            this.lblToDate.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblToDate.Location = new System.Drawing.Point(506, 44);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(470, 16);
            this.lblToDate.TabIndex = 13;
            this.lblToDate.Text = "To date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd MMMM yyyy";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(506, 63);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(470, 23);
            this.dtpToDate.TabIndex = 14;
            // 
            // lblFaculty
            // 
            this.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFaculty.Location = new System.Drawing.Point(16, 96);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(470, 16);
            this.lblFaculty.TabIndex = 15;
            this.lblFaculty.Text = "Faculty";
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(16, 115);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(470, 23);
            this.cboFaculty.TabIndex = 16;
            // 
            // lblProgramme
            // 
            this.lblProgramme.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgramme.Location = new System.Drawing.Point(506, 96);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(470, 16);
            this.lblProgramme.TabIndex = 17;
            this.lblProgramme.Text = "Programme";
            // 
            // cboProgramme
            // 
            this.cboProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramme.FormattingEnabled = true;
            this.cboProgramme.Location = new System.Drawing.Point(506, 115);
            this.cboProgramme.Name = "cboProgramme";
            this.cboProgramme.Size = new System.Drawing.Size(470, 23);
            this.cboProgramme.TabIndex = 18;
            // 
            // lblLearner
            // 
            this.lblLearner.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblLearner.Location = new System.Drawing.Point(16, 148);
            this.lblLearner.Name = "lblLearner";
            this.lblLearner.Size = new System.Drawing.Size(470, 16);
            this.lblLearner.TabIndex = 19;
            this.lblLearner.Text = "Learner";
            // 
            // cboLearner
            // 
            this.cboLearner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLearner.FormattingEnabled = true;
            this.cboLearner.Location = new System.Drawing.Point(16, 167);
            this.cboLearner.Name = "cboLearner";
            this.cboLearner.Size = new System.Drawing.Size(470, 23);
            this.cboLearner.TabIndex = 20;
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
            this.btnBackToDashboard.Location = new System.Drawing.Point(710, 436);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(156, 32);
            this.btnBackToDashboard.TabIndex = 21;
            this.btnBackToDashboard.Text = "Back to Dashboard";
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Location = new System.Drawing.Point(874, 436);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(142, 32);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // frmReportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 484);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnBackToDashboard);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlReportOptions);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmReportSelection";
            this.ShowIcon = false;
            this.Text = "Report Selection";
            this.Load += new System.EventHandler(this.frmReportSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlFiltersAccent.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlReportOptionsAccent.ResumeLayout(false);
            this.pnlReportOptions.ResumeLayout(false);
            this.pnlReportOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlReportOptions;
        private System.Windows.Forms.Panel pnlReportOptionsAccent;
        private System.Windows.Forms.Label lblReportOptionsTitle;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.ComboBox cboReport;
        private System.Windows.Forms.Label lblAvailableReports;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlFiltersAccent;
        private System.Windows.Forms.Label lblFiltersTitle;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.ComboBox cboProgramme;
        private System.Windows.Forms.Label lblLearner;
        private System.Windows.Forms.ComboBox cboLearner;
        private System.Windows.Forms.Button btnBackToDashboard;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
