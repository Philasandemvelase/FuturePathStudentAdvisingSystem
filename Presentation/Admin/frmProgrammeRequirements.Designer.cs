namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmProgrammeRequirements
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
            this.pnlSelectProgramme = new System.Windows.Forms.Panel();
            this.pnlSelectProgrammeAccent = new System.Windows.Forms.Panel();
            this.lblSelectProgrammeTitle = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.cboProgramme = new System.Windows.Forms.ComboBox();
            this.pnlStoredRules = new System.Windows.Forms.Panel();
            this.pnlStoredRulesAccent = new System.Windows.Forms.Panel();
            this.lblStoredRulesTitle = new System.Windows.Forms.Label();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.colRequiredSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinimumMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlRequirementEditor = new System.Windows.Forms.Panel();
            this.pnlRequirementEditorAccent = new System.Windows.Forms.Panel();
            this.lblRequirementEditorTitle = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.lblMinimumMark = new System.Windows.Forms.Label();
            this.nudMinimumMark = new System.Windows.Forms.NumericUpDown();
            this.lblAltSubject = new System.Windows.Forms.Label();
            this.cboAltSubject = new System.Windows.Forms.ComboBox();
            this.lblRuleNote = new System.Windows.Forms.Label();
            this.txtRuleNote = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddRequirement = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pnlSelectProgramme.SuspendLayout();
            this.pnlSelectProgrammeAccent.SuspendLayout();
            this.pnlStoredRules.SuspendLayout();
            this.pnlStoredRulesAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.pnlRequirementEditor.SuspendLayout();
            this.pnlRequirementEditorAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumMark)).BeginInit();
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
            this.lblPageTitle.Text = "Programme Requirements";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Administrator maintenance · Define the local eligibility rules.";
            // 
            // pnlSelectProgramme
            // 
            this.pnlSelectProgramme.Controls.Add(this.pnlSelectProgrammeAccent);
            this.pnlSelectProgramme.Controls.Add(this.lblSelectProgrammeTitle);
            this.pnlSelectProgramme.Controls.Add(this.lblProgramme);
            this.pnlSelectProgramme.Controls.Add(this.cboProgramme);
            this.pnlSelectProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlSelectProgramme.BackColor = System.Drawing.Color.White;
            this.pnlSelectProgramme.Location = new System.Drawing.Point(24, 84);
            this.pnlSelectProgramme.Name = "pnlSelectProgramme";
            this.pnlSelectProgramme.Size = new System.Drawing.Size(992, 98);
            this.pnlSelectProgramme.TabIndex = 2;
            // 
            // pnlSelectProgrammeAccent
            // 
            this.pnlSelectProgrammeAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSelectProgrammeAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelectProgrammeAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSelectProgrammeAccent.Name = "pnlSelectProgrammeAccent";
            this.pnlSelectProgrammeAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlSelectProgrammeAccent.TabIndex = 3;
            // 
            // lblSelectProgrammeTitle
            // 
            this.lblSelectProgrammeTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProgrammeTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSelectProgrammeTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSelectProgrammeTitle.Name = "lblSelectProgrammeTitle";
            this.lblSelectProgrammeTitle.Size = new System.Drawing.Size(700, 20);
            this.lblSelectProgrammeTitle.TabIndex = 4;
            this.lblSelectProgrammeTitle.Text = "Select programme";
            // 
            // lblProgramme
            // 
            this.lblProgramme.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgramme.Location = new System.Drawing.Point(16, 44);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(960, 16);
            this.lblProgramme.TabIndex = 5;
            this.lblProgramme.Text = "Programme *";
            // 
            // cboProgramme
            // 
            this.cboProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.cboProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramme.FormattingEnabled = true;
            this.cboProgramme.Location = new System.Drawing.Point(16, 63);
            this.cboProgramme.Name = "cboProgramme";
            this.cboProgramme.Size = new System.Drawing.Size(960, 23);
            this.cboProgramme.TabIndex = 6;
            this.cboProgramme.SelectedIndexChanged += new System.EventHandler(this.cboProgramme_SelectedIndexChanged);
            // 
            // pnlStoredRules
            // 
            this.pnlStoredRules.Controls.Add(this.pnlStoredRulesAccent);
            this.pnlStoredRules.Controls.Add(this.lblStoredRulesTitle);
            this.pnlStoredRules.Controls.Add(this.dgvRules);
            this.pnlStoredRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlStoredRules.BackColor = System.Drawing.Color.White;
            this.pnlStoredRules.Location = new System.Drawing.Point(24, 196);
            this.pnlStoredRules.Name = "pnlStoredRules";
            this.pnlStoredRules.Size = new System.Drawing.Size(992, 146);
            this.pnlStoredRules.TabIndex = 7;
            // 
            // pnlStoredRulesAccent
            // 
            this.pnlStoredRulesAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlStoredRulesAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStoredRulesAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlStoredRulesAccent.Name = "pnlStoredRulesAccent";
            this.pnlStoredRulesAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlStoredRulesAccent.TabIndex = 8;
            // 
            // lblStoredRulesTitle
            // 
            this.lblStoredRulesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoredRulesTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblStoredRulesTitle.Location = new System.Drawing.Point(16, 14);
            this.lblStoredRulesTitle.Name = "lblStoredRulesTitle";
            this.lblStoredRulesTitle.Size = new System.Drawing.Size(700, 20);
            this.lblStoredRulesTitle.TabIndex = 9;
            this.lblStoredRulesTitle.Text = "Stored rules";
            // 
            // dgvRules
            // 
            this.dgvRules.AllowUserToAddRows = false;
            this.dgvRules.AllowUserToDeleteRows = false;
            this.dgvRules.AllowUserToResizeRows = false;
            this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRules.BackgroundColor = System.Drawing.Color.White;
            this.dgvRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRules.ColumnHeadersHeight = 30;
            this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequiredSubject,
            this.colMinimumMark,
            this.colAlternative,
            this.colEdit,
            this.colRemove});
            this.dgvRules.EnableHeadersVisualStyles = false;
            this.dgvRules.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvRules.MultiSelect = false;
            this.dgvRules.ReadOnly = true;
            this.dgvRules.RowHeadersVisible = false;
            this.dgvRules.RowTemplate.Height = 28;
            this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRules.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvRules.Location = new System.Drawing.Point(16, 44);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.Size = new System.Drawing.Size(960, 88);
            this.dgvRules.TabIndex = 10;
            this.dgvRules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRules_CellContentClick);
            // 
            // colRequiredSubject
            // 
            this.colRequiredSubject.FillWeight = 110F;
            this.colRequiredSubject.HeaderText = "Required subject";
            this.colRequiredSubject.Name = "colRequiredSubject";
            this.colRequiredSubject.ReadOnly = true;
            // 
            // colMinimumMark
            // 
            this.colMinimumMark.FillWeight = 60F;
            this.colMinimumMark.HeaderText = "Minimum mark";
            this.colMinimumMark.Name = "colMinimumMark";
            this.colMinimumMark.ReadOnly = true;
            // 
            // colAlternative
            // 
            this.colAlternative.FillWeight = 100F;
            this.colAlternative.HeaderText = "Accepted alternative";
            this.colAlternative.Name = "colAlternative";
            this.colAlternative.ReadOnly = true;
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
            this.colEdit.Width = 70;
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
            // pnlRequirementEditor
            // 
            this.pnlRequirementEditor.Controls.Add(this.pnlRequirementEditorAccent);
            this.pnlRequirementEditor.Controls.Add(this.lblRequirementEditorTitle);
            this.pnlRequirementEditor.Controls.Add(this.lblSubject);
            this.pnlRequirementEditor.Controls.Add(this.cboSubject);
            this.pnlRequirementEditor.Controls.Add(this.lblMinimumMark);
            this.pnlRequirementEditor.Controls.Add(this.nudMinimumMark);
            this.pnlRequirementEditor.Controls.Add(this.lblAltSubject);
            this.pnlRequirementEditor.Controls.Add(this.cboAltSubject);
            this.pnlRequirementEditor.Controls.Add(this.lblRuleNote);
            this.pnlRequirementEditor.Controls.Add(this.txtRuleNote);
            this.pnlRequirementEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRequirementEditor.BackColor = System.Drawing.Color.White;
            this.pnlRequirementEditor.Location = new System.Drawing.Point(24, 356);
            this.pnlRequirementEditor.Name = "pnlRequirementEditor";
            this.pnlRequirementEditor.Size = new System.Drawing.Size(992, 150);
            this.pnlRequirementEditor.TabIndex = 11;
            // 
            // pnlRequirementEditorAccent
            // 
            this.pnlRequirementEditorAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlRequirementEditorAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequirementEditorAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlRequirementEditorAccent.Name = "pnlRequirementEditorAccent";
            this.pnlRequirementEditorAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlRequirementEditorAccent.TabIndex = 12;
            // 
            // lblRequirementEditorTitle
            // 
            this.lblRequirementEditorTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequirementEditorTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRequirementEditorTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRequirementEditorTitle.Name = "lblRequirementEditorTitle";
            this.lblRequirementEditorTitle.Size = new System.Drawing.Size(700, 20);
            this.lblRequirementEditorTitle.TabIndex = 13;
            this.lblRequirementEditorTitle.Text = "Requirement editor";
            // 
            // lblSubject
            // 
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSubject.Location = new System.Drawing.Point(16, 44);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(470, 16);
            this.lblSubject.TabIndex = 14;
            this.lblSubject.Text = "Subject *";
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.FormattingEnabled = true;
            this.cboSubject.Location = new System.Drawing.Point(16, 63);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(470, 23);
            this.cboSubject.TabIndex = 15;
            // 
            // lblMinimumMark
            // 
            this.lblMinimumMark.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMinimumMark.Location = new System.Drawing.Point(506, 44);
            this.lblMinimumMark.Name = "lblMinimumMark";
            this.lblMinimumMark.Size = new System.Drawing.Size(470, 16);
            this.lblMinimumMark.TabIndex = 16;
            this.lblMinimumMark.Text = "Minimum mark (%) *";
            // 
            // nudMinimumMark
            // 
            this.nudMinimumMark.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMinimumMark.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudMinimumMark.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMinimumMark.Location = new System.Drawing.Point(506, 63);
            this.nudMinimumMark.Name = "nudMinimumMark";
            this.nudMinimumMark.Size = new System.Drawing.Size(470, 23);
            this.nudMinimumMark.TabIndex = 17;
            // 
            // lblAltSubject
            // 
            this.lblAltSubject.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblAltSubject.Location = new System.Drawing.Point(16, 96);
            this.lblAltSubject.Name = "lblAltSubject";
            this.lblAltSubject.Size = new System.Drawing.Size(470, 16);
            this.lblAltSubject.TabIndex = 18;
            this.lblAltSubject.Text = "Accepted alternative subject";
            // 
            // cboAltSubject
            // 
            this.cboAltSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAltSubject.FormattingEnabled = true;
            this.cboAltSubject.Location = new System.Drawing.Point(16, 115);
            this.cboAltSubject.Name = "cboAltSubject";
            this.cboAltSubject.Size = new System.Drawing.Size(470, 23);
            this.cboAltSubject.TabIndex = 19;
            // 
            // lblRuleNote
            // 
            this.lblRuleNote.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRuleNote.Location = new System.Drawing.Point(506, 96);
            this.lblRuleNote.Name = "lblRuleNote";
            this.lblRuleNote.Size = new System.Drawing.Size(470, 16);
            this.lblRuleNote.TabIndex = 20;
            this.lblRuleNote.Text = "Advisory note";
            // 
            // txtRuleNote
            // 
            this.txtRuleNote.Location = new System.Drawing.Point(506, 115);
            this.txtRuleNote.Name = "txtRuleNote";
            this.txtRuleNote.Size = new System.Drawing.Size(470, 23);
            this.txtRuleNote.TabIndex = 21;
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
            this.btnBack.Location = new System.Drawing.Point(658, 522);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddRequirement
            // 
            this.btnAddRequirement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnAddRequirement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequirement.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddRequirement.BackColor = System.Drawing.Color.White;
            this.btnAddRequirement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRequirement.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRequirement.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAddRequirement.UseVisualStyleBackColor = false;
            this.btnAddRequirement.Location = new System.Drawing.Point(746, 522);
            this.btnAddRequirement.Name = "btnAddRequirement";
            this.btnAddRequirement.Size = new System.Drawing.Size(142, 32);
            this.btnAddRequirement.TabIndex = 23;
            this.btnAddRequirement.Text = "Add Requirement";
            this.btnAddRequirement.Click += new System.EventHandler(this.btnAddRequirement_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(896, 522);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 32);
            this.btnSaveChanges.TabIndex = 24;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmProgrammeRequirements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 570);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddRequirement);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlRequirementEditor);
            this.Controls.Add(this.pnlStoredRules);
            this.Controls.Add(this.pnlSelectProgramme);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmProgrammeRequirements";
            this.ShowIcon = false;
            this.Text = "Programme Requirements";
            this.Load += new System.EventHandler(this.frmProgrammeRequirements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumMark)).EndInit();
            this.pnlRequirementEditorAccent.ResumeLayout(false);
            this.pnlRequirementEditor.ResumeLayout(false);
            this.pnlRequirementEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.pnlStoredRulesAccent.ResumeLayout(false);
            this.pnlStoredRules.ResumeLayout(false);
            this.pnlStoredRules.PerformLayout();
            this.pnlSelectProgrammeAccent.ResumeLayout(false);
            this.pnlSelectProgramme.ResumeLayout(false);
            this.pnlSelectProgramme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSelectProgramme;
        private System.Windows.Forms.Panel pnlSelectProgrammeAccent;
        private System.Windows.Forms.Label lblSelectProgrammeTitle;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.ComboBox cboProgramme;
        private System.Windows.Forms.Panel pnlStoredRules;
        private System.Windows.Forms.Panel pnlStoredRulesAccent;
        private System.Windows.Forms.Label lblStoredRulesTitle;
        private System.Windows.Forms.DataGridView dgvRules;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequiredSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinimumMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlternative;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colRemove;
        private System.Windows.Forms.Panel pnlRequirementEditor;
        private System.Windows.Forms.Panel pnlRequirementEditorAccent;
        private System.Windows.Forms.Label lblRequirementEditorTitle;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cboSubject;
        private System.Windows.Forms.Label lblMinimumMark;
        private System.Windows.Forms.NumericUpDown nudMinimumMark;
        private System.Windows.Forms.Label lblAltSubject;
        private System.Windows.Forms.ComboBox cboAltSubject;
        private System.Windows.Forms.Label lblRuleNote;
        private System.Windows.Forms.TextBox txtRuleNote;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddRequirement;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
