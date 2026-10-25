namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmSubjectsMarks
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
            this.pnlAddSubject = new System.Windows.Forms.Panel();
            this.pnlAddSubjectAccent = new System.Windows.Forms.Panel();
            this.lblAddSubjectTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblMark = new System.Windows.Forms.Label();
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.chkMarkNotAvailable = new System.Windows.Forms.CheckBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.pnlCapturedSubjects = new System.Windows.Forms.Panel();
            this.pnlCapturedSubjectsAccent = new System.Windows.Forms.Panel();
            this.lblCapturedSubjectsTitle = new System.Windows.Forms.Label();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblValidation = new System.Windows.Forms.Label();
            this.pnlAddSubject.SuspendLayout();
            this.pnlAddSubjectAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).BeginInit();
            this.pnlCapturedSubjects.SuspendLayout();
            this.pnlCapturedSubjectsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
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
            this.lblPageTitle.Text = "Subjects & Marks";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Step 2 of 5 · Add your current school subjects and marks.";
            // 
            // pnlAddSubject
            // 
            this.pnlAddSubject.Controls.Add(this.pnlAddSubjectAccent);
            this.pnlAddSubject.Controls.Add(this.lblAddSubjectTitle);
            this.pnlAddSubject.Controls.Add(this.lblSubject);
            this.pnlAddSubject.Controls.Add(this.cboSubject);
            this.pnlAddSubject.Controls.Add(this.lblMark);
            this.pnlAddSubject.Controls.Add(this.nudMark);
            this.pnlAddSubject.Controls.Add(this.chkMarkNotAvailable);
            this.pnlAddSubject.Controls.Add(this.btnAddSubject);
            this.pnlAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlAddSubject.BackColor = System.Drawing.Color.White;
            this.pnlAddSubject.Location = new System.Drawing.Point(24, 84);
            this.pnlAddSubject.Name = "pnlAddSubject";
            this.pnlAddSubject.Size = new System.Drawing.Size(992, 128);
            this.pnlAddSubject.TabIndex = 2;
            // 
            // pnlAddSubjectAccent
            // 
            this.pnlAddSubjectAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlAddSubjectAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddSubjectAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAddSubjectAccent.Name = "pnlAddSubjectAccent";
            this.pnlAddSubjectAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlAddSubjectAccent.TabIndex = 3;
            // 
            // lblAddSubjectTitle
            // 
            this.lblAddSubjectTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSubjectTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAddSubjectTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAddSubjectTitle.Name = "lblAddSubjectTitle";
            this.lblAddSubjectTitle.Size = new System.Drawing.Size(700, 20);
            this.lblAddSubjectTitle.TabIndex = 4;
            this.lblAddSubjectTitle.Text = "Add a subject";
            // 
            // lblSubject
            // 
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSubject.Location = new System.Drawing.Point(16, 44);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(470, 16);
            this.lblSubject.TabIndex = 5;
            this.lblSubject.Text = "Subject *";
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(16, 63);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(470, 23);
            this.cboSubject.TabIndex = 6;
            // 
            // lblMark
            // 
            this.lblMark.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMark.Location = new System.Drawing.Point(506, 44);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(200, 16);
            this.lblMark.TabIndex = 7;
            this.lblMark.Text = "Mark (%) *";
            // 
            // nudMark
            // 
            this.nudMark.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMark.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMark.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMark.Location = new System.Drawing.Point(506, 63);
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(200, 23);
            this.nudMark.TabIndex = 8;
            // 
            // chkMarkNotAvailable
            // 
            this.chkMarkNotAvailable.AutoSize = true;
            this.chkMarkNotAvailable.Location = new System.Drawing.Point(722, 64);
            this.chkMarkNotAvailable.Name = "chkMarkNotAvailable";
            this.chkMarkNotAvailable.Size = new System.Drawing.Size(220, 22);
            this.chkMarkNotAvailable.TabIndex = 9;
            this.chkMarkNotAvailable.Text = "Mark not available yet";
            this.chkMarkNotAvailable.UseVisualStyleBackColor = true;
            this.chkMarkNotAvailable.CheckedChanged += new System.EventHandler(this.chkMarkNotAvailable_CheckedChanged);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Location = new System.Drawing.Point(866, 88);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(110, 32);
            this.btnAddSubject.TabIndex = 10;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // pnlCapturedSubjects
            // 
            this.pnlCapturedSubjects.Controls.Add(this.pnlCapturedSubjectsAccent);
            this.pnlCapturedSubjects.Controls.Add(this.lblCapturedSubjectsTitle);
            this.pnlCapturedSubjects.Controls.Add(this.dgvSubjects);
            this.pnlCapturedSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlCapturedSubjects.BackColor = System.Drawing.Color.White;
            this.pnlCapturedSubjects.Location = new System.Drawing.Point(24, 226);
            this.pnlCapturedSubjects.Name = "pnlCapturedSubjects";
            this.pnlCapturedSubjects.Size = new System.Drawing.Size(992, 262);
            this.pnlCapturedSubjects.TabIndex = 11;
            // 
            // pnlCapturedSubjectsAccent
            // 
            this.pnlCapturedSubjectsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlCapturedSubjectsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCapturedSubjectsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCapturedSubjectsAccent.Name = "pnlCapturedSubjectsAccent";
            this.pnlCapturedSubjectsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlCapturedSubjectsAccent.TabIndex = 12;
            // 
            // lblCapturedSubjectsTitle
            // 
            this.lblCapturedSubjectsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapturedSubjectsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCapturedSubjectsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblCapturedSubjectsTitle.Name = "lblCapturedSubjectsTitle";
            this.lblCapturedSubjectsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblCapturedSubjectsTitle.TabIndex = 13;
            this.lblCapturedSubjectsTitle.Text = "Captured subjects";
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToResizeRows = false;
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubjects.ColumnHeadersHeight = 30;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colMark,
            this.colEdit,
            this.colRemove});
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowTemplate.Height = 28;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvSubjects.Location = new System.Drawing.Point(16, 44);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(960, 202);
            this.dgvSubjects.TabIndex = 14;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // colSubject
            // 
            this.colSubject.FillWeight = 160F;
            this.colSubject.HeaderText = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            // 
            // colMark
            // 
            this.colMark.FillWeight = 80F;
            this.colMark.HeaderText = "Mark (%)";
            this.colMark.Name = "colMark";
            this.colMark.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.HeaderText = "";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 80;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            this.colRemove.Text = "Remove";
            this.colRemove.UseColumnTextForButtonValue = true;
            this.colRemove.Width = 80;
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
            this.btnBack.Location = new System.Drawing.Point(758, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Location = new System.Drawing.Point(846, 504);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 32);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next: Questionnaire";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.BackColor = System.Drawing.Color.FromArgb(253, 232, 234);
            this.lblValidation.ForeColor = System.Drawing.Color.FromArgb(164, 22, 26);
            this.lblValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValidation.Visible = false;
            this.lblValidation.Location = new System.Drawing.Point(24, 504);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(600, 32);
            this.lblValidation.TabIndex = 17;
            this.lblValidation.Text = "  This subject has already been added. Edit the existing mark instead.";
            // 
            // frmSubjectsMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 552);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlCapturedSubjects);
            this.Controls.Add(this.pnlAddSubject);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmSubjectsMarks";
            this.ShowIcon = false;
            this.Text = "Subjects & Marks";
            this.Load += new System.EventHandler(this.frmSubjectsMarks_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSubjectsMarks_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.pnlCapturedSubjectsAccent.ResumeLayout(false);
            this.pnlCapturedSubjects.ResumeLayout(false);
            this.pnlCapturedSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).EndInit();
            this.pnlAddSubjectAccent.ResumeLayout(false);
            this.pnlAddSubject.ResumeLayout(false);
            this.pnlAddSubject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlAddSubject;
        private System.Windows.Forms.Panel pnlAddSubjectAccent;
        private System.Windows.Forms.Label lblAddSubjectTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.NumericUpDown nudMark;
        private System.Windows.Forms.CheckBox chkMarkNotAvailable;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Panel pnlCapturedSubjects;
        private System.Windows.Forms.Panel pnlCapturedSubjectsAccent;
        private System.Windows.Forms.Label lblCapturedSubjectsTitle;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMark;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblValidation;
    }
}
