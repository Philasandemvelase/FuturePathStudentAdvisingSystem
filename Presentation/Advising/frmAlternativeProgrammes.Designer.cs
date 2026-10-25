namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmAlternativeProgrammes
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
            this.pnlSuggested = new System.Windows.Forms.Panel();
            this.pnlSuggestedAccent = new System.Windows.Forms.Panel();
            this.lblSuggestedTitle = new System.Windows.Forms.Label();
            this.dgvAlternatives = new System.Windows.Forms.DataGridView();
            this.colProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViewDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlAltDetails = new System.Windows.Forms.Panel();
            this.pnlAltDetailsAccent = new System.Windows.Forms.Panel();
            this.lblAltDetailsTitle = new System.Windows.Forms.Label();
            this.lblAltName = new System.Windows.Forms.Label();
            this.lblAltDetails = new System.Windows.Forms.Label();
            this.btnBackToOutcome = new System.Windows.Forms.Button();
            this.btnViewFunding = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.pnlSuggested.SuspendLayout();
            this.pnlSuggestedAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternatives)).BeginInit();
            this.pnlAltDetails.SuspendLayout();
            this.pnlAltDetailsAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Alternative Programmes";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Explore options based on your subjects, marks and interest profile.";
            // 
            // pnlSuggested
            // 
            this.pnlSuggested.Controls.Add(this.pnlSuggestedAccent);
            this.pnlSuggested.Controls.Add(this.lblSuggestedTitle);
            this.pnlSuggested.Controls.Add(this.dgvAlternatives);
            this.pnlSuggested.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSuggested.BackColor = System.Drawing.Color.White;
            this.pnlSuggested.Location = new System.Drawing.Point(24, 84);
            this.pnlSuggested.Name = "pnlSuggested";
            this.pnlSuggested.Size = new System.Drawing.Size(992, 176);
            this.pnlSuggested.TabIndex = 2;
            // 
            // pnlSuggestedAccent
            // 
            this.pnlSuggestedAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSuggestedAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuggestedAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSuggestedAccent.Name = "pnlSuggestedAccent";
            this.pnlSuggestedAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlSuggestedAccent.TabIndex = 3;
            // 
            // lblSuggestedTitle
            // 
            this.lblSuggestedTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestedTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSuggestedTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSuggestedTitle.Name = "lblSuggestedTitle";
            this.lblSuggestedTitle.Size = new System.Drawing.Size(700, 20);
            this.lblSuggestedTitle.TabIndex = 4;
            this.lblSuggestedTitle.Text = "Suggested alternatives · illustrative results";
            // 
            // dgvAlternatives
            // 
            this.dgvAlternatives.AllowUserToAddRows = false;
            this.dgvAlternatives.AllowUserToDeleteRows = false;
            this.dgvAlternatives.AllowUserToResizeRows = false;
            this.dgvAlternatives.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlternatives.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlternatives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlternatives.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlternatives.ColumnHeadersHeight = 30;
            this.dgvAlternatives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlternatives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProgramme,
            this.colFaculty,
            this.colReason,
            this.colViewDetails});
            this.dgvAlternatives.EnableHeadersVisualStyles = false;
            this.dgvAlternatives.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvAlternatives.MultiSelect = false;
            this.dgvAlternatives.ReadOnly = true;
            this.dgvAlternatives.RowHeadersVisible = false;
            this.dgvAlternatives.RowTemplate.Height = 28;
            this.dgvAlternatives.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlternatives.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvAlternatives.Location = new System.Drawing.Point(16, 44);
            this.dgvAlternatives.Name = "dgvAlternatives";
            this.dgvAlternatives.Size = new System.Drawing.Size(960, 118);
            this.dgvAlternatives.TabIndex = 5;
            this.dgvAlternatives.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlternatives_CellContentClick);
            // 
            // colProgramme
            // 
            this.colProgramme.FillWeight = 90F;
            this.colProgramme.HeaderText = "Programme";
            this.colProgramme.Name = "colProgramme";
            this.colProgramme.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.FillWeight = 70F;
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colReason
            // 
            this.colReason.FillWeight = 170F;
            this.colReason.HeaderText = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.ReadOnly = true;
            // 
            // colViewDetails
            // 
            this.colViewDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colViewDetails.HeaderText = "Action";
            this.colViewDetails.Name = "colViewDetails";
            this.colViewDetails.ReadOnly = true;
            this.colViewDetails.Text = "View Details";
            this.colViewDetails.UseColumnTextForButtonValue = true;
            this.colViewDetails.Width = 100;
            // 
            // pnlAltDetails
            // 
            this.pnlAltDetails.Controls.Add(this.pnlAltDetailsAccent);
            this.pnlAltDetails.Controls.Add(this.lblAltDetailsTitle);
            this.pnlAltDetails.Controls.Add(this.lblAltName);
            this.pnlAltDetails.Controls.Add(this.lblAltDetails);
            this.pnlAltDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlAltDetails.BackColor = System.Drawing.Color.White;
            this.pnlAltDetails.Location = new System.Drawing.Point(24, 274);
            this.pnlAltDetails.Name = "pnlAltDetails";
            this.pnlAltDetails.Size = new System.Drawing.Size(992, 100);
            this.pnlAltDetails.TabIndex = 6;
            // 
            // pnlAltDetailsAccent
            // 
            this.pnlAltDetailsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlAltDetailsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAltDetailsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAltDetailsAccent.Name = "pnlAltDetailsAccent";
            this.pnlAltDetailsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlAltDetailsAccent.TabIndex = 7;
            // 
            // lblAltDetailsTitle
            // 
            this.lblAltDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAltDetailsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAltDetailsTitle.Name = "lblAltDetailsTitle";
            this.lblAltDetailsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblAltDetailsTitle.TabIndex = 8;
            this.lblAltDetailsTitle.Text = "Selected alternative details";
            // 
            // lblAltName
            // 
            this.lblAltName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAltName.Location = new System.Drawing.Point(16, 42);
            this.lblAltName.Name = "lblAltName";
            this.lblAltName.Size = new System.Drawing.Size(940, 18);
            this.lblAltName.TabIndex = 9;
            this.lblAltName.Text = "BCom General";
            // 
            // lblAltDetails
            // 
            this.lblAltDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblAltDetails.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAltDetails.Location = new System.Drawing.Point(16, 64);
            this.lblAltDetails.Name = "lblAltDetails";
            this.lblAltDetails.Size = new System.Drawing.Size(940, 30);
            this.lblAltDetails.TabIndex = 10;
            this.lblAltDetails.Text = "Select an alternative to see its stored subject requirements, mark thresholds, interest match and any remaining gaps.";
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
            this.btnBackToOutcome.Location = new System.Drawing.Point(618, 390);
            this.btnBackToOutcome.Name = "btnBackToOutcome";
            this.btnBackToOutcome.Size = new System.Drawing.Size(142, 32);
            this.btnBackToOutcome.TabIndex = 11;
            this.btnBackToOutcome.Text = "Back to Outcome";
            this.btnBackToOutcome.Click += new System.EventHandler(this.btnBackToOutcome_Click);
            // 
            // btnViewFunding
            // 
            this.btnViewFunding.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnViewFunding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFunding.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnViewFunding.BackColor = System.Drawing.Color.White;
            this.btnViewFunding.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewFunding.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFunding.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnViewFunding.UseVisualStyleBackColor = false;
            this.btnViewFunding.Location = new System.Drawing.Point(768, 390);
            this.btnViewFunding.Name = "btnViewFunding";
            this.btnViewFunding.Size = new System.Drawing.Size(120, 32);
            this.btnViewFunding.TabIndex = 12;
            this.btnViewFunding.Text = "View Funding";
            this.btnViewFunding.Click += new System.EventHandler(this.btnViewFunding_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnViewSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnViewSummary.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnViewSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSummary.ForeColor = System.Drawing.Color.White;
            this.btnViewSummary.UseVisualStyleBackColor = false;
            this.btnViewSummary.Location = new System.Drawing.Point(896, 390);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(120, 32);
            this.btnViewSummary.TabIndex = 13;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // frmAlternativeProgrammes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 438);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnViewSummary);
            this.Controls.Add(this.btnViewFunding);
            this.Controls.Add(this.btnBackToOutcome);
            this.Controls.Add(this.pnlAltDetails);
            this.Controls.Add(this.pnlSuggested);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmAlternativeProgrammes";
            this.ShowIcon = false;
            this.Text = "Alternative Programmes";
            this.Load += new System.EventHandler(this.frmAlternativeProgrammes_Load);
            this.pnlAltDetailsAccent.ResumeLayout(false);
            this.pnlAltDetails.ResumeLayout(false);
            this.pnlAltDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlternatives)).EndInit();
            this.pnlSuggestedAccent.ResumeLayout(false);
            this.pnlSuggested.ResumeLayout(false);
            this.pnlSuggested.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSuggested;
        private System.Windows.Forms.Panel pnlSuggestedAccent;
        private System.Windows.Forms.Label lblSuggestedTitle;
        private System.Windows.Forms.DataGridView dgvAlternatives;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReason;
        private System.Windows.Forms.DataGridViewButtonColumn colViewDetails;
        private System.Windows.Forms.Panel pnlAltDetails;
        private System.Windows.Forms.Panel pnlAltDetailsAccent;
        private System.Windows.Forms.Label lblAltDetailsTitle;
        private System.Windows.Forms.Label lblAltName;
        private System.Windows.Forms.Label lblAltDetails;
        private System.Windows.Forms.Button btnBackToOutcome;
        private System.Windows.Forms.Button btnViewFunding;
        private System.Windows.Forms.Button btnViewSummary;
    }
}
