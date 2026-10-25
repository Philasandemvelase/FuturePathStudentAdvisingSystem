namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmFacultiesProgrammes
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
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.pnlRecordsAccent = new System.Windows.Forms.Panel();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.dgvProgrammes = new System.Windows.Forms.DataGridView();
            this.colProgramme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlEditProgramme = new System.Windows.Forms.Panel();
            this.pnlEditProgrammeAccent = new System.Windows.Forms.Panel();
            this.lblEditProgrammeTitle = new System.Windows.Forms.Label();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.cboFaculty = new System.Windows.Forms.ComboBox();
            this.lblProgrammeStatus = new System.Windows.Forms.Label();
            this.cboProgrammeStatus = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlFacultyMaintenance = new System.Windows.Forms.Panel();
            this.pnlFacultyMaintenanceAccent = new System.Windows.Forms.Panel();
            this.lblFacultyMaintenanceTitle = new System.Windows.Forms.Label();
            this.lblFacultyName = new System.Windows.Forms.Label();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRecords.SuspendLayout();
            this.pnlRecordsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrammes)).BeginInit();
            this.pnlEditProgramme.SuspendLayout();
            this.pnlEditProgrammeAccent.SuspendLayout();
            this.pnlFacultyMaintenance.SuspendLayout();
            this.pnlFacultyMaintenanceAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Faculties & Programmes";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Administrator maintenance · Browse, add, update or deactivate.";
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.pnlRecordsAccent);
            this.pnlRecords.Controls.Add(this.lblRecordsTitle);
            this.pnlRecords.Controls.Add(this.dgvProgrammes);
            this.pnlRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRecords.BackColor = System.Drawing.Color.White;
            this.pnlRecords.Location = new System.Drawing.Point(24, 84);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(992, 150);
            this.pnlRecords.TabIndex = 2;
            // 
            // pnlRecordsAccent
            // 
            this.pnlRecordsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlRecordsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecordsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlRecordsAccent.Name = "pnlRecordsAccent";
            this.pnlRecordsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlRecordsAccent.TabIndex = 3;
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblRecordsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblRecordsTitle.TabIndex = 4;
            this.lblRecordsTitle.Text = "Reference records";
            // 
            // dgvProgrammes
            // 
            this.dgvProgrammes.AllowUserToAddRows = false;
            this.dgvProgrammes.AllowUserToDeleteRows = false;
            this.dgvProgrammes.AllowUserToResizeRows = false;
            this.dgvProgrammes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgrammes.BackgroundColor = System.Drawing.Color.White;
            this.dgvProgrammes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProgrammes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProgrammes.ColumnHeadersHeight = 30;
            this.dgvProgrammes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProgrammes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProgramme,
            this.colFaculty,
            this.colStatus,
            this.colEdit});
            this.dgvProgrammes.EnableHeadersVisualStyles = false;
            this.dgvProgrammes.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvProgrammes.MultiSelect = false;
            this.dgvProgrammes.ReadOnly = true;
            this.dgvProgrammes.RowHeadersVisible = false;
            this.dgvProgrammes.RowTemplate.Height = 28;
            this.dgvProgrammes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProgrammes.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvProgrammes.Location = new System.Drawing.Point(16, 44);
            this.dgvProgrammes.Name = "dgvProgrammes";
            this.dgvProgrammes.Size = new System.Drawing.Size(960, 92);
            this.dgvProgrammes.TabIndex = 5;
            this.dgvProgrammes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgrammes_CellContentClick);
            // 
            // colProgramme
            // 
            this.colProgramme.FillWeight = 150F;
            this.colProgramme.HeaderText = "Programme";
            this.colProgramme.Name = "colProgramme";
            this.colProgramme.ReadOnly = true;
            // 
            // colFaculty
            // 
            this.colFaculty.FillWeight = 80F;
            this.colFaculty.HeaderText = "Faculty";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 50F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEdit.HeaderText = "Action";
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 80;
            // 
            // pnlEditProgramme
            // 
            this.pnlEditProgramme.Controls.Add(this.pnlEditProgrammeAccent);
            this.pnlEditProgramme.Controls.Add(this.lblEditProgrammeTitle);
            this.pnlEditProgramme.Controls.Add(this.lblProgrammeName);
            this.pnlEditProgramme.Controls.Add(this.txtProgrammeName);
            this.pnlEditProgramme.Controls.Add(this.lblFaculty);
            this.pnlEditProgramme.Controls.Add(this.cboFaculty);
            this.pnlEditProgramme.Controls.Add(this.lblProgrammeStatus);
            this.pnlEditProgramme.Controls.Add(this.cboProgrammeStatus);
            this.pnlEditProgramme.Controls.Add(this.lblDescription);
            this.pnlEditProgramme.Controls.Add(this.txtDescription);
            this.pnlEditProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEditProgramme.BackColor = System.Drawing.Color.White;
            this.pnlEditProgramme.Location = new System.Drawing.Point(24, 248);
            this.pnlEditProgramme.Name = "pnlEditProgramme";
            this.pnlEditProgramme.Size = new System.Drawing.Size(992, 150);
            this.pnlEditProgramme.TabIndex = 6;
            // 
            // pnlEditProgrammeAccent
            // 
            this.pnlEditProgrammeAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlEditProgrammeAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditProgrammeAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlEditProgrammeAccent.Name = "pnlEditProgrammeAccent";
            this.pnlEditProgrammeAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlEditProgrammeAccent.TabIndex = 7;
            // 
            // lblEditProgrammeTitle
            // 
            this.lblEditProgrammeTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProgrammeTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEditProgrammeTitle.Location = new System.Drawing.Point(16, 14);
            this.lblEditProgrammeTitle.Name = "lblEditProgrammeTitle";
            this.lblEditProgrammeTitle.Size = new System.Drawing.Size(700, 20);
            this.lblEditProgrammeTitle.TabIndex = 8;
            this.lblEditProgrammeTitle.Text = "Edit programme";
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgrammeName.Location = new System.Drawing.Point(16, 44);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(470, 16);
            this.lblProgrammeName.TabIndex = 9;
            this.lblProgrammeName.Text = "Programme name *";
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.MaxLength = 100;
            this.txtProgrammeName.Location = new System.Drawing.Point(16, 63);
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(470, 23);
            this.txtProgrammeName.TabIndex = 10;
            // 
            // lblFaculty
            // 
            this.lblFaculty.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFaculty.Location = new System.Drawing.Point(506, 44);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(470, 16);
            this.lblFaculty.TabIndex = 11;
            this.lblFaculty.Text = "Faculty *";
            // 
            // cboFaculty
            // 
            this.cboFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaculty.FormattingEnabled = true;
            this.cboFaculty.Location = new System.Drawing.Point(506, 63);
            this.cboFaculty.Name = "cboFaculty";
            this.cboFaculty.Size = new System.Drawing.Size(470, 23);
            this.cboFaculty.TabIndex = 12;
            // 
            // lblProgrammeStatus
            // 
            this.lblProgrammeStatus.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProgrammeStatus.Location = new System.Drawing.Point(16, 96);
            this.lblProgrammeStatus.Name = "lblProgrammeStatus";
            this.lblProgrammeStatus.Size = new System.Drawing.Size(470, 16);
            this.lblProgrammeStatus.TabIndex = 13;
            this.lblProgrammeStatus.Text = "Status *";
            // 
            // cboProgrammeStatus
            // 
            this.cboProgrammeStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboProgrammeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgrammeStatus.FormattingEnabled = true;
            this.cboProgrammeStatus.Location = new System.Drawing.Point(16, 115);
            this.cboProgrammeStatus.Name = "cboProgrammeStatus";
            this.cboProgrammeStatus.Size = new System.Drawing.Size(470, 23);
            this.cboProgrammeStatus.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDescription.Location = new System.Drawing.Point(506, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(470, 16);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Location = new System.Drawing.Point(506, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(470, 23);
            this.txtDescription.TabIndex = 16;
            // 
            // pnlFacultyMaintenance
            // 
            this.pnlFacultyMaintenance.Controls.Add(this.pnlFacultyMaintenanceAccent);
            this.pnlFacultyMaintenance.Controls.Add(this.lblFacultyMaintenanceTitle);
            this.pnlFacultyMaintenance.Controls.Add(this.lblFacultyName);
            this.pnlFacultyMaintenance.Controls.Add(this.txtFacultyName);
            this.pnlFacultyMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlFacultyMaintenance.BackColor = System.Drawing.Color.White;
            this.pnlFacultyMaintenance.Location = new System.Drawing.Point(24, 412);
            this.pnlFacultyMaintenance.Name = "pnlFacultyMaintenance";
            this.pnlFacultyMaintenance.Size = new System.Drawing.Size(992, 98);
            this.pnlFacultyMaintenance.TabIndex = 17;
            // 
            // pnlFacultyMaintenanceAccent
            // 
            this.pnlFacultyMaintenanceAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlFacultyMaintenanceAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFacultyMaintenanceAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlFacultyMaintenanceAccent.Name = "pnlFacultyMaintenanceAccent";
            this.pnlFacultyMaintenanceAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlFacultyMaintenanceAccent.TabIndex = 18;
            // 
            // lblFacultyMaintenanceTitle
            // 
            this.lblFacultyMaintenanceTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyMaintenanceTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFacultyMaintenanceTitle.Location = new System.Drawing.Point(16, 14);
            this.lblFacultyMaintenanceTitle.Name = "lblFacultyMaintenanceTitle";
            this.lblFacultyMaintenanceTitle.Size = new System.Drawing.Size(700, 20);
            this.lblFacultyMaintenanceTitle.TabIndex = 19;
            this.lblFacultyMaintenanceTitle.Text = "Faculty maintenance";
            // 
            // lblFacultyName
            // 
            this.lblFacultyName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFacultyName.Location = new System.Drawing.Point(16, 44);
            this.lblFacultyName.Name = "lblFacultyName";
            this.lblFacultyName.Size = new System.Drawing.Size(960, 16);
            this.lblFacultyName.TabIndex = 20;
            this.lblFacultyName.Text = "Faculty name (selected programme's faculty, or a new one after Add New) *";
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.MaxLength = 50;
            this.txtFacultyName.Location = new System.Drawing.Point(16, 63);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(960, 23);
            this.txtFacultyName.TabIndex = 21;
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
            this.btnBack.Location = new System.Drawing.Point(602, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddNew.BackColor = System.Drawing.Color.White;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Location = new System.Drawing.Point(690, 526);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 32);
            this.btnAddNew.TabIndex = 23;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeactivate.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnDeactivate.BackColor = System.Drawing.Color.White;
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivate.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Location = new System.Drawing.Point(782, 526);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(106, 32);
            this.btnDeactivate.TabIndex = 24;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
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
            this.btnSaveChanges.Location = new System.Drawing.Point(896, 526);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 32);
            this.btnSaveChanges.TabIndex = 25;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // frmFacultiesProgrammes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 574);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlFacultyMaintenance);
            this.Controls.Add(this.pnlEditProgramme);
            this.Controls.Add(this.pnlRecords);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmFacultiesProgrammes";
            this.ShowIcon = false;
            this.Text = "Faculties & Programmes";
            this.Load += new System.EventHandler(this.frmFacultiesProgrammes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlFacultyMaintenanceAccent.ResumeLayout(false);
            this.pnlFacultyMaintenance.ResumeLayout(false);
            this.pnlFacultyMaintenance.PerformLayout();
            this.pnlEditProgrammeAccent.ResumeLayout(false);
            this.pnlEditProgramme.ResumeLayout(false);
            this.pnlEditProgramme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrammes)).EndInit();
            this.pnlRecordsAccent.ResumeLayout(false);
            this.pnlRecords.ResumeLayout(false);
            this.pnlRecords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.Panel pnlRecordsAccent;
        private System.Windows.Forms.Label lblRecordsTitle;
        private System.Windows.Forms.DataGridView dgvProgrammes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.Panel pnlEditProgramme;
        private System.Windows.Forms.Panel pnlEditProgrammeAccent;
        private System.Windows.Forms.Label lblEditProgrammeTitle;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.TextBox txtProgrammeName;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.ComboBox cboFaculty;
        private System.Windows.Forms.Label lblProgrammeStatus;
        private System.Windows.Forms.ComboBox cboProgrammeStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlFacultyMaintenance;
        private System.Windows.Forms.Panel pnlFacultyMaintenanceAccent;
        private System.Windows.Forms.Label lblFacultyMaintenanceTitle;
        private System.Windows.Forms.Label lblFacultyName;
        private System.Windows.Forms.TextBox txtFacultyName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
