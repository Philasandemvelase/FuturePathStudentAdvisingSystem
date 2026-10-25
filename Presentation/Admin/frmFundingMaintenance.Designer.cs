namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmFundingMaintenance
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
            this.dgvFundingRecords = new System.Windows.Forms.DataGridView();
            this.colFundingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFundingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFundingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.pnlEditorAccent = new System.Windows.Forms.Panel();
            this.lblEditorTitle = new System.Windows.Forms.Label();
            this.lblFundingName = new System.Windows.Forms.Label();
            this.txtFundingName = new System.Windows.Forms.TextBox();
            this.lblFundingType = new System.Windows.Forms.Label();
            this.cboFundingType = new System.Windows.Forms.ComboBox();
            this.lblClosingDate = new System.Windows.Forms.Label();
            this.dtpClosingDate = new System.Windows.Forms.DateTimePicker();
            this.lblFundingStatus = new System.Windows.Forms.Label();
            this.cboFundingStatus = new System.Windows.Forms.ComboBox();
            this.lblEligibility = new System.Windows.Forms.Label();
            this.txtEligibility = new System.Windows.Forms.TextBox();
            this.lblDocuments = new System.Windows.Forms.Label();
            this.txtDocuments = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblFundFaculties = new System.Windows.Forms.Label();
            this.clbFundFaculties = new System.Windows.Forms.CheckedListBox();
            this.lblFundProgrammes = new System.Windows.Forms.Label();
            this.clbFundProgrammes = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRecords.SuspendLayout();
            this.pnlRecordsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundingRecords)).BeginInit();
            this.pnlEditor.SuspendLayout();
            this.pnlEditorAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Funding Maintenance";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Administrator maintenance · Keep funding guidance accurate.";
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.pnlRecordsAccent);
            this.pnlRecords.Controls.Add(this.lblRecordsTitle);
            this.pnlRecords.Controls.Add(this.dgvFundingRecords);
            this.pnlRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlRecords.BackColor = System.Drawing.Color.White;
            this.pnlRecords.Location = new System.Drawing.Point(24, 84);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(992, 140);
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
            this.lblRecordsTitle.Text = "Funding records";
            // 
            // dgvFundingRecords
            // 
            this.dgvFundingRecords.AllowUserToAddRows = false;
            this.dgvFundingRecords.AllowUserToDeleteRows = false;
            this.dgvFundingRecords.AllowUserToResizeRows = false;
            this.dgvFundingRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFundingRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvFundingRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFundingRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFundingRecords.ColumnHeadersHeight = 30;
            this.dgvFundingRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFundingRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFundingName,
            this.colFundingType,
            this.colFundingStatus});
            this.dgvFundingRecords.EnableHeadersVisualStyles = false;
            this.dgvFundingRecords.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvFundingRecords.MultiSelect = false;
            this.dgvFundingRecords.ReadOnly = true;
            this.dgvFundingRecords.RowHeadersVisible = false;
            this.dgvFundingRecords.RowTemplate.Height = 28;
            this.dgvFundingRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFundingRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvFundingRecords.Location = new System.Drawing.Point(16, 44);
            this.dgvFundingRecords.Name = "dgvFundingRecords";
            this.dgvFundingRecords.Size = new System.Drawing.Size(960, 84);
            this.dgvFundingRecords.TabIndex = 5;
            this.dgvFundingRecords.SelectionChanged += new System.EventHandler(this.dgvFundingRecords_SelectionChanged);
            // 
            // colFundingName
            // 
            this.colFundingName.FillWeight = 200F;
            this.colFundingName.HeaderText = "Funding name";
            this.colFundingName.Name = "colFundingName";
            this.colFundingName.ReadOnly = true;
            // 
            // colFundingType
            // 
            this.colFundingType.FillWeight = 80F;
            this.colFundingType.HeaderText = "Type";
            this.colFundingType.Name = "colFundingType";
            this.colFundingType.ReadOnly = true;
            // 
            // colFundingStatus
            // 
            this.colFundingStatus.FillWeight = 50F;
            this.colFundingStatus.HeaderText = "Status";
            this.colFundingStatus.Name = "colFundingStatus";
            this.colFundingStatus.ReadOnly = true;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Controls.Add(this.pnlEditorAccent);
            this.pnlEditor.Controls.Add(this.lblEditorTitle);
            this.pnlEditor.Controls.Add(this.lblFundingName);
            this.pnlEditor.Controls.Add(this.txtFundingName);
            this.pnlEditor.Controls.Add(this.lblFundingType);
            this.pnlEditor.Controls.Add(this.cboFundingType);
            this.pnlEditor.Controls.Add(this.lblClosingDate);
            this.pnlEditor.Controls.Add(this.dtpClosingDate);
            this.pnlEditor.Controls.Add(this.lblFundingStatus);
            this.pnlEditor.Controls.Add(this.cboFundingStatus);
            this.pnlEditor.Controls.Add(this.lblEligibility);
            this.pnlEditor.Controls.Add(this.txtEligibility);
            this.pnlEditor.Controls.Add(this.lblDocuments);
            this.pnlEditor.Controls.Add(this.txtDocuments);
            this.pnlEditor.Controls.Add(this.lblContact);
            this.pnlEditor.Controls.Add(this.txtContact);
            this.pnlEditor.Controls.Add(this.lblFundFaculties);
            this.pnlEditor.Controls.Add(this.clbFundFaculties);
            this.pnlEditor.Controls.Add(this.lblFundProgrammes);
            this.pnlEditor.Controls.Add(this.clbFundProgrammes);
            this.pnlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEditor.BackColor = System.Drawing.Color.White;
            this.pnlEditor.Location = new System.Drawing.Point(24, 238);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(992, 348);
            this.pnlEditor.TabIndex = 6;
            // 
            // pnlEditorAccent
            // 
            this.pnlEditorAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlEditorAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditorAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlEditorAccent.Name = "pnlEditorAccent";
            this.pnlEditorAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlEditorAccent.TabIndex = 7;
            // 
            // lblEditorTitle
            // 
            this.lblEditorTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEditorTitle.Location = new System.Drawing.Point(16, 14);
            this.lblEditorTitle.Name = "lblEditorTitle";
            this.lblEditorTitle.Size = new System.Drawing.Size(700, 20);
            this.lblEditorTitle.TabIndex = 8;
            this.lblEditorTitle.Text = "Funding editor";
            // 
            // lblFundingName
            // 
            this.lblFundingName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundingName.Location = new System.Drawing.Point(16, 44);
            this.lblFundingName.Name = "lblFundingName";
            this.lblFundingName.Size = new System.Drawing.Size(470, 16);
            this.lblFundingName.TabIndex = 9;
            this.lblFundingName.Text = "Funding name *";
            // 
            // txtFundingName
            // 
            this.txtFundingName.Location = new System.Drawing.Point(16, 63);
            this.txtFundingName.Name = "txtFundingName";
            this.txtFundingName.Size = new System.Drawing.Size(470, 23);
            this.txtFundingName.TabIndex = 10;
            // 
            // lblFundingType
            // 
            this.lblFundingType.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundingType.Location = new System.Drawing.Point(506, 44);
            this.lblFundingType.Name = "lblFundingType";
            this.lblFundingType.Size = new System.Drawing.Size(470, 16);
            this.lblFundingType.TabIndex = 11;
            this.lblFundingType.Text = "Funding type *";
            // 
            // cboFundingType
            // 
            this.cboFundingType.Items.AddRange(new object[] {
            "Scholarship",
            "Bursary",
            "Financial Aid",
            "External Funding"});
            this.cboFundingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFundingType.FormattingEnabled = true;
            this.cboFundingType.Location = new System.Drawing.Point(506, 63);
            this.cboFundingType.Name = "cboFundingType";
            this.cboFundingType.Size = new System.Drawing.Size(470, 23);
            this.cboFundingType.TabIndex = 12;
            // 
            // lblClosingDate
            // 
            this.lblClosingDate.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblClosingDate.Location = new System.Drawing.Point(16, 94);
            this.lblClosingDate.Name = "lblClosingDate";
            this.lblClosingDate.Size = new System.Drawing.Size(470, 16);
            this.lblClosingDate.TabIndex = 13;
            this.lblClosingDate.Text = "Closing date *";
            // 
            // dtpClosingDate
            // 
            this.dtpClosingDate.CustomFormat = "dd MMMM yyyy";
            this.dtpClosingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClosingDate.Location = new System.Drawing.Point(16, 113);
            this.dtpClosingDate.Name = "dtpClosingDate";
            this.dtpClosingDate.Size = new System.Drawing.Size(470, 23);
            this.dtpClosingDate.TabIndex = 14;
            // 
            // lblFundingStatus
            // 
            this.lblFundingStatus.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundingStatus.Location = new System.Drawing.Point(506, 94);
            this.lblFundingStatus.Name = "lblFundingStatus";
            this.lblFundingStatus.Size = new System.Drawing.Size(470, 16);
            this.lblFundingStatus.TabIndex = 15;
            this.lblFundingStatus.Text = "Status *";
            // 
            // cboFundingStatus
            // 
            this.cboFundingStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboFundingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFundingStatus.FormattingEnabled = true;
            this.cboFundingStatus.Location = new System.Drawing.Point(506, 113);
            this.cboFundingStatus.Name = "cboFundingStatus";
            this.cboFundingStatus.Size = new System.Drawing.Size(470, 23);
            this.cboFundingStatus.TabIndex = 16;
            // 
            // lblEligibility
            // 
            this.lblEligibility.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEligibility.Location = new System.Drawing.Point(16, 144);
            this.lblEligibility.Name = "lblEligibility";
            this.lblEligibility.Size = new System.Drawing.Size(470, 16);
            this.lblEligibility.TabIndex = 17;
            this.lblEligibility.Text = "Eligibility description *";
            // 
            // txtEligibility
            // 
            this.txtEligibility.Location = new System.Drawing.Point(16, 163);
            this.txtEligibility.Name = "txtEligibility";
            this.txtEligibility.Size = new System.Drawing.Size(470, 23);
            this.txtEligibility.TabIndex = 18;
            // 
            // lblDocuments
            // 
            this.lblDocuments.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblDocuments.Location = new System.Drawing.Point(506, 144);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(470, 16);
            this.lblDocuments.TabIndex = 19;
            this.lblDocuments.Text = "Required documents";
            // 
            // txtDocuments
            // 
            this.txtDocuments.Location = new System.Drawing.Point(506, 163);
            this.txtDocuments.Name = "txtDocuments";
            this.txtDocuments.Size = new System.Drawing.Size(470, 23);
            this.txtDocuments.TabIndex = 20;
            // 
            // lblContact
            // 
            this.lblContact.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblContact.Location = new System.Drawing.Point(16, 194);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(960, 16);
            this.lblContact.TabIndex = 21;
            this.lblContact.Text = "Contact / application information";
            // 
            // txtContact
            // 
            this.txtContact.MaxLength = 100;
            this.txtContact.Location = new System.Drawing.Point(16, 213);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(960, 23);
            this.txtContact.TabIndex = 22;
            // 
            // lblFundFaculties
            // 
            this.lblFundFaculties.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundFaculties.Location = new System.Drawing.Point(16, 244);
            this.lblFundFaculties.Name = "lblFundFaculties";
            this.lblFundFaculties.Size = new System.Drawing.Size(470, 16);
            this.lblFundFaculties.TabIndex = 23;
            this.lblFundFaculties.Text = "Linked faculties (tick one or more) *";
            // 
            // clbFundFaculties
            // 
            this.clbFundFaculties.CheckOnClick = true;
            this.clbFundFaculties.FormattingEnabled = true;
            this.clbFundFaculties.IntegralHeight = false;
            this.clbFundFaculties.Location = new System.Drawing.Point(16, 263);
            this.clbFundFaculties.Name = "clbFundFaculties";
            this.clbFundFaculties.Size = new System.Drawing.Size(470, 70);
            this.clbFundFaculties.TabIndex = 24;
            // 
            // lblFundProgrammes
            // 
            this.lblFundProgrammes.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblFundProgrammes.Location = new System.Drawing.Point(506, 244);
            this.lblFundProgrammes.Name = "lblFundProgrammes";
            this.lblFundProgrammes.Size = new System.Drawing.Size(470, 16);
            this.lblFundProgrammes.TabIndex = 25;
            this.lblFundProgrammes.Text = "Linked programmes (optional; tick to limit to specific programmes)";
            // 
            // clbFundProgrammes
            // 
            this.clbFundProgrammes.CheckOnClick = true;
            this.clbFundProgrammes.FormattingEnabled = true;
            this.clbFundProgrammes.IntegralHeight = false;
            this.clbFundProgrammes.Location = new System.Drawing.Point(506, 263);
            this.clbFundProgrammes.Name = "clbFundProgrammes";
            this.clbFundProgrammes.Size = new System.Drawing.Size(470, 70);
            this.clbFundProgrammes.TabIndex = 26;
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
            this.btnBack.Location = new System.Drawing.Point(602, 602);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 27;
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
            this.btnAddNew.Location = new System.Drawing.Point(690, 602);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(84, 32);
            this.btnAddNew.TabIndex = 28;
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
            this.btnDeactivate.Location = new System.Drawing.Point(782, 602);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(106, 32);
            this.btnDeactivate.TabIndex = 29;
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
            this.btnSaveChanges.Location = new System.Drawing.Point(896, 602);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(120, 32);
            this.btnSaveChanges.TabIndex = 30;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // frmFundingMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 650);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.pnlRecords);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmFundingMaintenance";
            this.ShowIcon = false;
            this.Text = "Funding Maintenance";
            this.Load += new System.EventHandler(this.frmFundingMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlEditorAccent.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFundingRecords)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFundingRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFundingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFundingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFundingStatus;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Panel pnlEditorAccent;
        private System.Windows.Forms.Label lblEditorTitle;
        private System.Windows.Forms.Label lblFundingName;
        private System.Windows.Forms.TextBox txtFundingName;
        private System.Windows.Forms.Label lblFundingType;
        private System.Windows.Forms.ComboBox cboFundingType;
        private System.Windows.Forms.Label lblClosingDate;
        private System.Windows.Forms.DateTimePicker dtpClosingDate;
        private System.Windows.Forms.Label lblFundingStatus;
        private System.Windows.Forms.ComboBox cboFundingStatus;
        private System.Windows.Forms.Label lblEligibility;
        private System.Windows.Forms.TextBox txtEligibility;
        private System.Windows.Forms.Label lblDocuments;
        private System.Windows.Forms.TextBox txtDocuments;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblFundFaculties;
        private System.Windows.Forms.CheckedListBox clbFundFaculties;
        private System.Windows.Forms.Label lblFundProgrammes;
        private System.Windows.Forms.CheckedListBox clbFundProgrammes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
