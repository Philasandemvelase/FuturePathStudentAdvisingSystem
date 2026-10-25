namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmFundingInformation
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
            this.pnlFilterFunding = new System.Windows.Forms.Panel();
            this.pnlFilterFundingAccent = new System.Windows.Forms.Panel();
            this.lblFilterFundingTitle = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.cboProgramme = new System.Windows.Forms.ComboBox();
            this.lblFundingType = new System.Windows.Forms.Label();
            this.cboFundingType = new System.Windows.Forms.ComboBox();
            this.pnlAvailableFunding = new System.Windows.Forms.Panel();
            this.pnlAvailableFundingAccent = new System.Windows.Forms.Panel();
            this.lblAvailableFundingTitle = new System.Windows.Forms.Label();
            this.dgvFunding = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFundingDetails = new System.Windows.Forms.Panel();
            this.pnlFundingDetailsAccent = new System.Windows.Forms.Panel();
            this.lblFundingDetailsTitle = new System.Windows.Forms.Label();
            this.lblFundName = new System.Windows.Forms.Label();
            this.lblFundEligibility = new System.Windows.Forms.Label();
            this.lblFundDocuments = new System.Windows.Forms.Label();
            this.lblFundContact = new System.Windows.Forms.Label();
            this.btnBackToOutcome = new System.Windows.Forms.Button();
            this.btnContinueToSummary = new System.Windows.Forms.Button();
            this.pnlFilterFunding.SuspendLayout();
            this.pnlFilterFundingAccent.SuspendLayout();
            this.pnlAvailableFunding.SuspendLayout();
            this.pnlAvailableFundingAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunding)).BeginInit();
            this.pnlFundingDetails.SuspendLayout();
            this.pnlFundingDetailsAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Funding Information";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Optional · View locally stored funding guidance.";
            // 
            // pnlFilterFunding
            // 
            this.pnlFilterFunding.Controls.Add(this.pnlFilterFundingAccent);
            this.pnlFilterFunding.Controls.Add(this.lblFilterFundingTitle);
            this.pnlFilterFunding.Controls.Add(this.lblFaculty);
            this.pnlFilterFunding.Controls.Add(this.cboFaculty);
            this.pnlFilterFunding.Controls.Add(this.lblProgramme);
            this.pnlFilterFunding.Controls.Add(this.cboProgramme);
            this.pnlFilterFunding.Controls.Add(this.lblFundingType);
            this.pnlFilterFunding.Controls.Add(this.cboFundingType);
            this.pnlFilterFunding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFilterFunding.BackColor = System.Drawing.Color.White;
            this.pnlFilterFunding.Location = new System.Drawing.Point(24, 84);
            this.pnlFilterFunding.Name = "pnlFilterFunding";
            this.pnlFilterFunding.Size = new System.Drawing.Size(992, 150);
            this.pnlFilterFunding.TabIndex = 2;
            // 
            // pnlFilterFundingAccent
            // 
            this.pnlFilterFundingAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlFilterFundingAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterFundingAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlFilterFundingAccent.Name = "pnlFilterFundingAccent";
            this.pnlFilterFundingAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlFilterFundingAccent.TabIndex = 3;
            // 
            // lblFilterFundingTitle
            // 
            this.lblFilterFundingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterFundingTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFilterFundingTitle.Location = new System.Drawing.Point(16, 14);
            this.lblFilterFundingTitle.Name = "lblFilterFundingTitle";
            this.lblFilterFundingTitle.Size = new System.Drawing.Size(700, 20);
            this.lblFilterFundingTitle.TabIndex = 4;
            this.lblFilterFundingTitle.Text = "Filter funding";
            // 
            // lblFaculty
            // 
            this.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFaculty.Location = new System.Drawing.Point(16, 44);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(470, 16);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Faculty";
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(16, 63);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(470, 23);
            this.cboFaculty.TabIndex = 6;
            this.cboFaculty.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblProgramme
            // 
            this.lblProgramme.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgramme.Location = new System.Drawing.Point(506, 44);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(470, 16);
            this.lblProgramme.TabIndex = 7;
            this.lblProgramme.Text = "Programme";
            // 
            // cboProgramme
            // 
            this.cboProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramme.FormattingEnabled = true;
            this.cboProgramme.Location = new System.Drawing.Point(506, 63);
            this.cboProgramme.Name = "cboProgramme";
            this.cboProgramme.Size = new System.Drawing.Size(470, 23);
            this.cboProgramme.TabIndex = 8;
            this.cboProgramme.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblFundingType
            // 
            this.lblFundingType.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundingType.Location = new System.Drawing.Point(16, 96);
            this.lblFundingType.Name = "lblFundingType";
            this.lblFundingType.Size = new System.Drawing.Size(470, 16);
            this.lblFundingType.TabIndex = 9;
            this.lblFundingType.Text = "Funding type";
            // 
            // cboFundingType
            // 
            this.cboFundingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFundingType.FormattingEnabled = true;
            this.cboFundingType.Location = new System.Drawing.Point(16, 115);
            this.cboFundingType.Name = "cboFundingType";
            this.cboFundingType.Size = new System.Drawing.Size(470, 23);
            this.cboFundingType.TabIndex = 10;
            this.cboFundingType.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // pnlAvailableFunding
            // 
            this.pnlAvailableFunding.Controls.Add(this.pnlAvailableFundingAccent);
            this.pnlAvailableFunding.Controls.Add(this.lblAvailableFundingTitle);
            this.pnlAvailableFunding.Controls.Add(this.dgvFunding);
            this.pnlAvailableFunding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlAvailableFunding.BackColor = System.Drawing.Color.White;
            this.pnlAvailableFunding.Location = new System.Drawing.Point(24, 248);
            this.pnlAvailableFunding.Name = "pnlAvailableFunding";
            this.pnlAvailableFunding.Size = new System.Drawing.Size(992, 150);
            this.pnlAvailableFunding.TabIndex = 11;
            // 
            // pnlAvailableFundingAccent
            // 
            this.pnlAvailableFundingAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlAvailableFundingAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvailableFundingAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAvailableFundingAccent.Name = "pnlAvailableFundingAccent";
            this.pnlAvailableFundingAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlAvailableFundingAccent.TabIndex = 12;
            // 
            // lblAvailableFundingTitle
            // 
            this.lblAvailableFundingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableFundingTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAvailableFundingTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAvailableFundingTitle.Name = "lblAvailableFundingTitle";
            this.lblAvailableFundingTitle.Size = new System.Drawing.Size(700, 20);
            this.lblAvailableFundingTitle.TabIndex = 13;
            this.lblAvailableFundingTitle.Text = "Available funding";
            // 
            // dgvFunding
            // 
            this.dgvFunding.AllowUserToAddRows = false;
            this.dgvFunding.AllowUserToDeleteRows = false;
            this.dgvFunding.AllowUserToResizeRows = false;
            this.dgvFunding.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunding.BackgroundColor = System.Drawing.Color.White;
            this.dgvFunding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunding.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunding.ColumnHeadersHeight = 30;
            this.dgvFunding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFunding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colLinkedTo,
            this.colClosingDate});
            this.dgvFunding.EnableHeadersVisualStyles = false;
            this.dgvFunding.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvFunding.MultiSelect = false;
            this.dgvFunding.ReadOnly = true;
            this.dgvFunding.RowHeadersVisible = false;
            this.dgvFunding.RowTemplate.Height = 28;
            this.dgvFunding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFunding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvFunding.Location = new System.Drawing.Point(16, 44);
            this.dgvFunding.Name = "dgvFunding";
            this.dgvFunding.Size = new System.Drawing.Size(960, 92);
            this.dgvFunding.TabIndex = 14;
            this.dgvFunding.SelectionChanged += new System.EventHandler(this.dgvFunding_SelectionChanged);
            // 
            // colName
            // 
            this.colName.FillWeight = 150F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.FillWeight = 70F;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colLinkedTo
            // 
            this.colLinkedTo.FillWeight = 70F;
            this.colLinkedTo.HeaderText = "Linked to";
            this.colLinkedTo.Name = "colLinkedTo";
            this.colLinkedTo.ReadOnly = true;
            // 
            // colClosingDate
            // 
            this.colClosingDate.FillWeight = 70F;
            this.colClosingDate.HeaderText = "Closing date";
            this.colClosingDate.Name = "colClosingDate";
            this.colClosingDate.ReadOnly = true;
            // 
            // pnlFundingDetails
            // 
            this.pnlFundingDetails.Controls.Add(this.pnlFundingDetailsAccent);
            this.pnlFundingDetails.Controls.Add(this.lblFundingDetailsTitle);
            this.pnlFundingDetails.Controls.Add(this.lblFundName);
            this.pnlFundingDetails.Controls.Add(this.lblFundEligibility);
            this.pnlFundingDetails.Controls.Add(this.lblFundDocuments);
            this.pnlFundingDetails.Controls.Add(this.lblFundContact);
            this.pnlFundingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFundingDetails.BackColor = System.Drawing.Color.White;
            this.pnlFundingDetails.Location = new System.Drawing.Point(24, 412);
            this.pnlFundingDetails.Name = "pnlFundingDetails";
            this.pnlFundingDetails.Size = new System.Drawing.Size(992, 138);
            this.pnlFundingDetails.TabIndex = 15;
            // 
            // pnlFundingDetailsAccent
            // 
            this.pnlFundingDetailsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlFundingDetailsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFundingDetailsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlFundingDetailsAccent.Name = "pnlFundingDetailsAccent";
            this.pnlFundingDetailsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlFundingDetailsAccent.TabIndex = 16;
            // 
            // lblFundingDetailsTitle
            // 
            this.lblFundingDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundingDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundingDetailsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblFundingDetailsTitle.Name = "lblFundingDetailsTitle";
            this.lblFundingDetailsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblFundingDetailsTitle.TabIndex = 17;
            this.lblFundingDetailsTitle.Text = "Selected funding details";
            // 
            // lblFundName
            // 
            this.lblFundName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblFundName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundName.Location = new System.Drawing.Point(16, 42);
            this.lblFundName.Name = "lblFundName";
            this.lblFundName.Size = new System.Drawing.Size(940, 18);
            this.lblFundName.TabIndex = 18;
            this.lblFundName.Text = "Commerce Merit Award";
            // 
            // lblFundEligibility
            // 
            this.lblFundEligibility.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblFundEligibility.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundEligibility.Location = new System.Drawing.Point(16, 64);
            this.lblFundEligibility.Name = "lblFundEligibility";
            this.lblFundEligibility.Size = new System.Drawing.Size(940, 18);
            this.lblFundEligibility.TabIndex = 19;
            this.lblFundEligibility.Text = "Eligibility: Academic merit; verify the provider's criteria.";
            // 
            // lblFundDocuments
            // 
            this.lblFundDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblFundDocuments.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundDocuments.Location = new System.Drawing.Point(16, 86);
            this.lblFundDocuments.Name = "lblFundDocuments";
            this.lblFundDocuments.Size = new System.Drawing.Size(940, 18);
            this.lblFundDocuments.TabIndex = 20;
            this.lblFundDocuments.Text = "Documents: Results, identity document and application form.";
            // 
            // lblFundContact
            // 
            this.lblFundContact.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblFundContact.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundContact.Location = new System.Drawing.Point(16, 108);
            this.lblFundContact.Name = "lblFundContact";
            this.lblFundContact.Size = new System.Drawing.Size(940, 18);
            this.lblFundContact.TabIndex = 21;
            this.lblFundContact.Text = "Contact / application information: commerce.awards@example.org";
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
            this.btnBackToOutcome.Location = new System.Drawing.Point(696, 566);
            this.btnBackToOutcome.Name = "btnBackToOutcome";
            this.btnBackToOutcome.Size = new System.Drawing.Size(142, 32);
            this.btnBackToOutcome.TabIndex = 22;
            this.btnBackToOutcome.Text = "Back to Outcome";
            this.btnBackToOutcome.Click += new System.EventHandler(this.btnBackToOutcome_Click);
            // 
            // btnContinueToSummary
            // 
            this.btnContinueToSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnContinueToSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueToSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnContinueToSummary.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnContinueToSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinueToSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueToSummary.ForeColor = System.Drawing.Color.White;
            this.btnContinueToSummary.UseVisualStyleBackColor = false;
            this.btnContinueToSummary.Location = new System.Drawing.Point(846, 566);
            this.btnContinueToSummary.Name = "btnContinueToSummary";
            this.btnContinueToSummary.Size = new System.Drawing.Size(170, 32);
            this.btnContinueToSummary.TabIndex = 23;
            this.btnContinueToSummary.Text = "Continue to Summary";
            this.btnContinueToSummary.Click += new System.EventHandler(this.btnContinueToSummary_Click);
            // 
            // frmFundingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 614);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnContinueToSummary);
            this.Controls.Add(this.btnBackToOutcome);
            this.Controls.Add(this.pnlFundingDetails);
            this.Controls.Add(this.pnlAvailableFunding);
            this.Controls.Add(this.pnlFilterFunding);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmFundingInformation";
            this.ShowIcon = false;
            this.Text = "Funding Information";
            this.Load += new System.EventHandler(this.frmFundingInformation_Load);
            this.pnlFundingDetailsAccent.ResumeLayout(false);
            this.pnlFundingDetails.ResumeLayout(false);
            this.pnlFundingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunding)).EndInit();
            this.pnlAvailableFundingAccent.ResumeLayout(false);
            this.pnlAvailableFunding.ResumeLayout(false);
            this.pnlAvailableFunding.PerformLayout();
            this.pnlFilterFundingAccent.ResumeLayout(false);
            this.pnlFilterFunding.ResumeLayout(false);
            this.pnlFilterFunding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlFilterFunding;
        private System.Windows.Forms.Panel pnlFilterFundingAccent;
        private System.Windows.Forms.Label lblFilterFundingTitle;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.ComboBox cboProgramme;
        private System.Windows.Forms.Label lblFundingType;
        private System.Windows.Forms.ComboBox cboFundingType;
        private System.Windows.Forms.Panel pnlAvailableFunding;
        private System.Windows.Forms.Panel pnlAvailableFundingAccent;
        private System.Windows.Forms.Label lblAvailableFundingTitle;
        private System.Windows.Forms.DataGridView dgvFunding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosingDate;
        private System.Windows.Forms.Panel pnlFundingDetails;
        private System.Windows.Forms.Panel pnlFundingDetailsAccent;
        private System.Windows.Forms.Label lblFundingDetailsTitle;
        private System.Windows.Forms.Label lblFundName;
        private System.Windows.Forms.Label lblFundEligibility;
        private System.Windows.Forms.Label lblFundDocuments;
        private System.Windows.Forms.Label lblFundContact;
        private System.Windows.Forms.Button btnBackToOutcome;
        private System.Windows.Forms.Button btnContinueToSummary;
    }
}
