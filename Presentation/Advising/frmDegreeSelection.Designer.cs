namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmDegreeSelection
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
            this.pnlPreferredProgramme = new System.Windows.Forms.Panel();
            this.pnlPreferredProgrammeAccent = new System.Windows.Forms.Panel();
            this.lblPreferredProgrammeTitle = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.cboDegree = new System.Windows.Forms.ComboBox();
            this.pnlRequirements = new System.Windows.Forms.Panel();
            this.pnlRequirementsAccent = new System.Windows.Forms.Panel();
            this.lblRequirementsTitle = new System.Windows.Forms.Label();
            this.dgvRequirements = new System.Windows.Forms.DataGridView();
            this.colRequirement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYourResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProgrammeInfo = new System.Windows.Forms.Panel();
            this.pnlProgrammeInfoAccent = new System.Windows.Forms.Panel();
            this.lblProgrammeInfoTitle = new System.Windows.Forms.Label();
            this.lblProgrammeDescription = new System.Windows.Forms.Label();
            this.lblInterestCategories = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckEligibility = new System.Windows.Forms.Button();
            this.pnlPreferredProgramme.SuspendLayout();
            this.pnlPreferredProgrammeAccent.SuspendLayout();
            this.pnlRequirements.SuspendLayout();
            this.pnlRequirementsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).BeginInit();
            this.pnlProgrammeInfo.SuspendLayout();
            this.pnlProgrammeInfoAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Faculty & Degree Selection";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Step 4 of 5 · Select one programme for this advisory session.";
            // 
            // pnlPreferredProgramme
            // 
            this.pnlPreferredProgramme.Controls.Add(this.pnlPreferredProgrammeAccent);
            this.pnlPreferredProgramme.Controls.Add(this.lblPreferredProgrammeTitle);
            this.pnlPreferredProgramme.Controls.Add(this.lblFaculty);
            this.pnlPreferredProgramme.Controls.Add(this.cboFaculty);
            this.pnlPreferredProgramme.Controls.Add(this.lblDegree);
            this.pnlPreferredProgramme.Controls.Add(this.cboDegree);
            this.pnlPreferredProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlPreferredProgramme.BackColor = System.Drawing.Color.White;
            this.pnlPreferredProgramme.Location = new System.Drawing.Point(24, 84);
            this.pnlPreferredProgramme.Name = "pnlPreferredProgramme";
            this.pnlPreferredProgramme.Size = new System.Drawing.Size(992, 98);
            this.pnlPreferredProgramme.TabIndex = 2;
            // 
            // pnlPreferredProgrammeAccent
            // 
            this.pnlPreferredProgrammeAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlPreferredProgrammeAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreferredProgrammeAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlPreferredProgrammeAccent.Name = "pnlPreferredProgrammeAccent";
            this.pnlPreferredProgrammeAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlPreferredProgrammeAccent.TabIndex = 3;
            // 
            // lblPreferredProgrammeTitle
            // 
            this.lblPreferredProgrammeTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreferredProgrammeTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblPreferredProgrammeTitle.Location = new System.Drawing.Point(16, 14);
            this.lblPreferredProgrammeTitle.Name = "lblPreferredProgrammeTitle";
            this.lblPreferredProgrammeTitle.Size = new System.Drawing.Size(700, 20);
            this.lblPreferredProgrammeTitle.TabIndex = 4;
            this.lblPreferredProgrammeTitle.Text = "Your preferred programme";
            // 
            // lblFaculty
            // 
            this.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFaculty.Location = new System.Drawing.Point(16, 44);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(470, 16);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Faculty *";
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(16, 63);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(470, 23);
            this.cboFaculty.TabIndex = 6;
            this.cboFaculty.SelectedIndexChanged += new System.EventHandler(this.cboFaculty_SelectedIndexChanged);
            // 
            // lblDegree
            // 
            this.lblDegree.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDegree.Location = new System.Drawing.Point(506, 44);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(470, 16);
            this.lblDegree.TabIndex = 7;
            this.lblDegree.Text = "Degree programme *";
            // 
            // cboDegree
            // 
            this.cboDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDegree.FormattingEnabled = true;
            this.cboDegree.Location = new System.Drawing.Point(506, 63);
            this.cboDegree.Name = "cboDegree";
            this.cboDegree.Size = new System.Drawing.Size(470, 23);
            this.cboDegree.TabIndex = 8;
            this.cboDegree.SelectedIndexChanged += new System.EventHandler(this.cboDegree_SelectedIndexChanged);
            // 
            // pnlRequirements
            // 
            this.pnlRequirements.Controls.Add(this.pnlRequirementsAccent);
            this.pnlRequirements.Controls.Add(this.lblRequirementsTitle);
            this.pnlRequirements.Controls.Add(this.dgvRequirements);
            this.pnlRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRequirements.BackColor = System.Drawing.Color.White;
            this.pnlRequirements.Location = new System.Drawing.Point(24, 196);
            this.pnlRequirements.Name = "pnlRequirements";
            this.pnlRequirements.Size = new System.Drawing.Size(992, 170);
            this.pnlRequirements.TabIndex = 9;
            // 
            // pnlRequirementsAccent
            // 
            this.pnlRequirementsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlRequirementsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequirementsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlRequirementsAccent.Name = "pnlRequirementsAccent";
            this.pnlRequirementsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlRequirementsAccent.TabIndex = 10;
            // 
            // lblRequirementsTitle
            // 
            this.lblRequirementsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirementsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRequirementsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRequirementsTitle.Name = "lblRequirementsTitle";
            this.lblRequirementsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblRequirementsTitle.TabIndex = 11;
            this.lblRequirementsTitle.Text = "Programme requirements · retrieved from the database";
            // 
            // dgvRequirements
            // 
            this.dgvRequirements.AllowUserToAddRows = false;
            this.dgvRequirements.AllowUserToDeleteRows = false;
            this.dgvRequirements.AllowUserToResizeRows = false;
            this.dgvRequirements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequirements.BackgroundColor = System.Drawing.Color.White;
            this.dgvRequirements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequirements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequirements.ColumnHeadersHeight = 30;
            this.dgvRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequirement,
            this.colMinimum,
            this.colYourResult});
            this.dgvRequirements.EnableHeadersVisualStyles = false;
            this.dgvRequirements.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvRequirements.MultiSelect = false;
            this.dgvRequirements.ReadOnly = true;
            this.dgvRequirements.RowHeadersVisible = false;
            this.dgvRequirements.RowTemplate.Height = 28;
            this.dgvRequirements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequirements.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvRequirements.Location = new System.Drawing.Point(16, 44);
            this.dgvRequirements.Name = "dgvRequirements";
            this.dgvRequirements.Size = new System.Drawing.Size(960, 112);
            this.dgvRequirements.TabIndex = 12;
            // 
            // colRequirement
            // 
            this.colRequirement.FillWeight = 120F;
            this.colRequirement.HeaderText = "Requirement";
            this.colRequirement.Name = "colRequirement";
            this.colRequirement.ReadOnly = true;
            // 
            // colMinimum
            // 
            this.colMinimum.FillWeight = 80F;
            this.colMinimum.HeaderText = "Minimum";
            this.colMinimum.Name = "colMinimum";
            this.colMinimum.ReadOnly = true;
            // 
            // colYourResult
            // 
            this.colYourResult.FillWeight = 80F;
            this.colYourResult.HeaderText = "Your result";
            this.colYourResult.Name = "colYourResult";
            this.colYourResult.ReadOnly = true;
            // 
            // pnlProgrammeInfo
            // 
            this.pnlProgrammeInfo.Controls.Add(this.pnlProgrammeInfoAccent);
            this.pnlProgrammeInfo.Controls.Add(this.lblProgrammeInfoTitle);
            this.pnlProgrammeInfo.Controls.Add(this.lblProgrammeDescription);
            this.pnlProgrammeInfo.Controls.Add(this.lblInterestCategories);
            this.pnlProgrammeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlProgrammeInfo.BackColor = System.Drawing.Color.White;
            this.pnlProgrammeInfo.Location = new System.Drawing.Point(24, 380);
            this.pnlProgrammeInfo.Name = "pnlProgrammeInfo";
            this.pnlProgrammeInfo.Size = new System.Drawing.Size(992, 96);
            this.pnlProgrammeInfo.TabIndex = 13;
            // 
            // pnlProgrammeInfoAccent
            // 
            this.pnlProgrammeInfoAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlProgrammeInfoAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgrammeInfoAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlProgrammeInfoAccent.Name = "pnlProgrammeInfoAccent";
            this.pnlProgrammeInfoAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlProgrammeInfoAccent.TabIndex = 14;
            // 
            // lblProgrammeInfoTitle
            // 
            this.lblProgrammeInfoTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammeInfoTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgrammeInfoTitle.Location = new System.Drawing.Point(16, 14);
            this.lblProgrammeInfoTitle.Name = "lblProgrammeInfoTitle";
            this.lblProgrammeInfoTitle.Size = new System.Drawing.Size(700, 20);
            this.lblProgrammeInfoTitle.TabIndex = 15;
            this.lblProgrammeInfoTitle.Text = "Programme information";
            // 
            // lblProgrammeDescription
            // 
            this.lblProgrammeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblProgrammeDescription.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgrammeDescription.Location = new System.Drawing.Point(16, 42);
            this.lblProgrammeDescription.Name = "lblProgrammeDescription";
            this.lblProgrammeDescription.Size = new System.Drawing.Size(940, 18);
            this.lblProgrammeDescription.TabIndex = 16;
            this.lblProgrammeDescription.Text = "Explore how information systems support organisations and business decisions.";
            // 
            // lblInterestCategories
            // 
            this.lblInterestCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblInterestCategories.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblInterestCategories.Location = new System.Drawing.Point(16, 64);
            this.lblInterestCategories.Name = "lblInterestCategories";
            this.lblInterestCategories.Size = new System.Drawing.Size(940, 18);
            this.lblInterestCategories.TabIndex = 17;
            this.lblInterestCategories.Text = "Interest categories: Numbers and Technology; Business and Finance.";
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Location = new System.Drawing.Point(772, 492);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckEligibility
            // 
            this.btnCheckEligibility.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnCheckEligibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEligibility.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnCheckEligibility.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnCheckEligibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckEligibility.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEligibility.ForeColor = System.Drawing.Color.White;
            this.btnCheckEligibility.UseVisualStyleBackColor = false;
            this.btnCheckEligibility.Location = new System.Drawing.Point(860, 492);
            this.btnCheckEligibility.Name = "btnCheckEligibility";
            this.btnCheckEligibility.Size = new System.Drawing.Size(156, 32);
            this.btnCheckEligibility.TabIndex = 19;
            this.btnCheckEligibility.Text = "Check Eligibility";
            this.btnCheckEligibility.Click += new System.EventHandler(this.btnCheckEligibility_Click);
            // 
            // frmDegreeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 540);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnCheckEligibility);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlProgrammeInfo);
            this.Controls.Add(this.pnlRequirements);
            this.Controls.Add(this.pnlPreferredProgramme);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmDegreeSelection";
            this.ShowIcon = false;
            this.Text = "Faculty & Degree Selection";
            this.Load += new System.EventHandler(this.frmDegreeSelection_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDegreeSelection_FormClosing);
            this.pnlProgrammeInfoAccent.ResumeLayout(false);
            this.pnlProgrammeInfo.ResumeLayout(false);
            this.pnlProgrammeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequirements)).EndInit();
            this.pnlRequirementsAccent.ResumeLayout(false);
            this.pnlRequirements.ResumeLayout(false);
            this.pnlRequirements.PerformLayout();
            this.pnlPreferredProgrammeAccent.ResumeLayout(false);
            this.pnlPreferredProgramme.ResumeLayout(false);
            this.pnlPreferredProgramme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlPreferredProgramme;
        private System.Windows.Forms.Panel pnlPreferredProgrammeAccent;
        private System.Windows.Forms.Label lblPreferredProgrammeTitle;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.ComboBox cboDegree;
        private System.Windows.Forms.Panel pnlRequirements;
        private System.Windows.Forms.Panel pnlRequirementsAccent;
        private System.Windows.Forms.Label lblRequirementsTitle;
        private System.Windows.Forms.DataGridView dgvRequirements;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequirement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinimum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYourResult;
        private System.Windows.Forms.Panel pnlProgrammeInfo;
        private System.Windows.Forms.Panel pnlProgrammeInfoAccent;
        private System.Windows.Forms.Label lblProgrammeInfoTitle;
        private System.Windows.Forms.Label lblProgrammeDescription;
        private System.Windows.Forms.Label lblInterestCategories;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckEligibility;
    }
}
