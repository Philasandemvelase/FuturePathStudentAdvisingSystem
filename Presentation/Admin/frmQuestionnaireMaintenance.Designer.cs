namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmQuestionnaireMaintenance
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
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.pnlQuestionsAccent = new System.Windows.Forms.Panel();
            this.lblQuestionsTitle = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlEditQuestion = new System.Windows.Forms.Panel();
            this.pnlEditQuestionAccent = new System.Windows.Forms.Panel();
            this.lblEditQuestionTitle = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblQuestionStatus = new System.Windows.Forms.Label();
            this.cboQuestionStatus = new System.Windows.Forms.ComboBox();
            this.pnlMapping = new System.Windows.Forms.Panel();
            this.pnlMappingAccent = new System.Windows.Forms.Panel();
            this.lblMappingTitle = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblMapProgramme = new System.Windows.Forms.Label();
            this.cboMapProgramme = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pnlQuestions.SuspendLayout();
            this.pnlQuestionsAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.pnlEditQuestion.SuspendLayout();
            this.pnlEditQuestionAccent.SuspendLayout();
            this.pnlMapping.SuspendLayout();
            this.pnlMappingAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
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
            this.lblPageTitle.Text = "Interest Questionnaire Maintenance";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Administrator maintenance · Questions, categories and programme mappings.";
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Controls.Add(this.pnlQuestionsAccent);
            this.pnlQuestions.Controls.Add(this.lblQuestionsTitle);
            this.pnlQuestions.Controls.Add(this.dgvQuestions);
            this.pnlQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlQuestions.BackColor = System.Drawing.Color.White;
            this.pnlQuestions.Location = new System.Drawing.Point(24, 84);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(992, 150);
            this.pnlQuestions.TabIndex = 2;
            // 
            // pnlQuestionsAccent
            // 
            this.pnlQuestionsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlQuestionsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestionsAccent.Name = "pnlQuestionsAccent";
            this.pnlQuestionsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlQuestionsAccent.TabIndex = 3;
            // 
            // lblQuestionsTitle
            // 
            this.lblQuestionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblQuestionsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblQuestionsTitle.Name = "lblQuestionsTitle";
            this.lblQuestionsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblQuestionsTitle.TabIndex = 4;
            this.lblQuestionsTitle.Text = "Questions";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AllowUserToResizeRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.ColumnHeadersHeight = 30;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestion,
            this.colCategory,
            this.colStatus});
            this.dgvQuestions.EnableHeadersVisualStyles = false;
            this.dgvQuestions.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;
            this.dgvQuestions.RowTemplate.Height = 28;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvQuestions.Location = new System.Drawing.Point(16, 44);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.Size = new System.Drawing.Size(960, 92);
            this.dgvQuestions.TabIndex = 5;
            this.dgvQuestions.SelectionChanged += new System.EventHandler(this.dgvQuestions_SelectionChanged);
            // 
            // colQuestion
            // 
            this.colQuestion.FillWeight = 260F;
            this.colQuestion.HeaderText = "Question";
            this.colQuestion.Name = "colQuestion";
            this.colQuestion.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 100F;
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 40F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // pnlEditQuestion
            // 
            this.pnlEditQuestion.Controls.Add(this.pnlEditQuestionAccent);
            this.pnlEditQuestion.Controls.Add(this.lblEditQuestionTitle);
            this.pnlEditQuestion.Controls.Add(this.lblQuestionText);
            this.pnlEditQuestion.Controls.Add(this.txtQuestionText);
            this.pnlEditQuestion.Controls.Add(this.lblCategory);
            this.pnlEditQuestion.Controls.Add(this.cboCategory);
            this.pnlEditQuestion.Controls.Add(this.lblQuestionStatus);
            this.pnlEditQuestion.Controls.Add(this.cboQuestionStatus);
            this.pnlEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlEditQuestion.BackColor = System.Drawing.Color.White;
            this.pnlEditQuestion.Location = new System.Drawing.Point(24, 248);
            this.pnlEditQuestion.Name = "pnlEditQuestion";
            this.pnlEditQuestion.Size = new System.Drawing.Size(992, 150);
            this.pnlEditQuestion.TabIndex = 6;
            // 
            // pnlEditQuestionAccent
            // 
            this.pnlEditQuestionAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlEditQuestionAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEditQuestionAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlEditQuestionAccent.Name = "pnlEditQuestionAccent";
            this.pnlEditQuestionAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlEditQuestionAccent.TabIndex = 7;
            // 
            // lblEditQuestionTitle
            // 
            this.lblEditQuestionTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditQuestionTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEditQuestionTitle.Location = new System.Drawing.Point(16, 14);
            this.lblEditQuestionTitle.Name = "lblEditQuestionTitle";
            this.lblEditQuestionTitle.Size = new System.Drawing.Size(700, 20);
            this.lblEditQuestionTitle.TabIndex = 8;
            this.lblEditQuestionTitle.Text = "Edit question";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblQuestionText.Location = new System.Drawing.Point(16, 44);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(470, 16);
            this.lblQuestionText.TabIndex = 9;
            this.lblQuestionText.Text = "Question text *";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.MaxLength = 200;
            this.txtQuestionText.Location = new System.Drawing.Point(16, 63);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(470, 23);
            this.txtQuestionText.TabIndex = 10;
            // 
            // lblCategory
            // 
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCategory.Location = new System.Drawing.Point(506, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(470, 16);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Interest category *";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(506, 63);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(470, 23);
            this.cboCategory.TabIndex = 12;
            // 
            // lblQuestionStatus
            // 
            this.lblQuestionStatus.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblQuestionStatus.Location = new System.Drawing.Point(16, 96);
            this.lblQuestionStatus.Name = "lblQuestionStatus";
            this.lblQuestionStatus.Size = new System.Drawing.Size(470, 16);
            this.lblQuestionStatus.TabIndex = 13;
            this.lblQuestionStatus.Text = "Status *";
            // 
            // cboQuestionStatus
            // 
            this.cboQuestionStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboQuestionStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionStatus.FormattingEnabled = true;
            this.cboQuestionStatus.Location = new System.Drawing.Point(16, 115);
            this.cboQuestionStatus.Name = "cboQuestionStatus";
            this.cboQuestionStatus.Size = new System.Drawing.Size(470, 23);
            this.cboQuestionStatus.TabIndex = 14;
            // 
            // pnlMapping
            // 
            this.pnlMapping.Controls.Add(this.pnlMappingAccent);
            this.pnlMapping.Controls.Add(this.lblMappingTitle);
            this.pnlMapping.Controls.Add(this.lblCategoryName);
            this.pnlMapping.Controls.Add(this.txtCategoryName);
            this.pnlMapping.Controls.Add(this.lblMapProgramme);
            this.pnlMapping.Controls.Add(this.cboMapProgramme);
            this.pnlMapping.Controls.Add(this.lblWeight);
            this.pnlMapping.Controls.Add(this.nudWeight);
            this.pnlMapping.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlMapping.BackColor = System.Drawing.Color.White;
            this.pnlMapping.Location = new System.Drawing.Point(24, 412);
            this.pnlMapping.Name = "pnlMapping";
            this.pnlMapping.Size = new System.Drawing.Size(992, 98);
            this.pnlMapping.TabIndex = 15;
            // 
            // pnlMappingAccent
            // 
            this.pnlMappingAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlMappingAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMappingAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlMappingAccent.Name = "pnlMappingAccent";
            this.pnlMappingAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlMappingAccent.TabIndex = 16;
            // 
            // lblMappingTitle
            // 
            this.lblMappingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMappingTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMappingTitle.Location = new System.Drawing.Point(16, 14);
            this.lblMappingTitle.Name = "lblMappingTitle";
            this.lblMappingTitle.Size = new System.Drawing.Size(700, 20);
            this.lblMappingTitle.TabIndex = 17;
            this.lblMappingTitle.Text = "Category and programme mapping";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCategoryName.Location = new System.Drawing.Point(16, 44);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(300, 16);
            this.lblCategoryName.TabIndex = 18;
            this.lblCategoryName.Text = "Category name *";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.MaxLength = 50;
            this.txtCategoryName.Location = new System.Drawing.Point(16, 63);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(300, 23);
            this.txtCategoryName.TabIndex = 19;
            // 
            // lblMapProgramme
            // 
            this.lblMapProgramme.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblMapProgramme.Location = new System.Drawing.Point(332, 44);
            this.lblMapProgramme.Name = "lblMapProgramme";
            this.lblMapProgramme.Size = new System.Drawing.Size(420, 16);
            this.lblMapProgramme.TabIndex = 20;
            this.lblMapProgramme.Text = "Programme *";
            // 
            // cboMapProgramme
            // 
            this.cboMapProgramme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMapProgramme.FormattingEnabled = true;
            this.cboMapProgramme.Location = new System.Drawing.Point(332, 63);
            this.cboMapProgramme.Name = "cboMapProgramme";
            this.cboMapProgramme.Size = new System.Drawing.Size(420, 23);
            this.cboMapProgramme.TabIndex = 21;
            // 
            // lblWeight
            // 
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblWeight.Location = new System.Drawing.Point(764, 44);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(212, 16);
            this.lblWeight.TabIndex = 22;
            this.lblWeight.Text = "Weighting (0–1)";
            // 
            // nudWeight
            // 
            this.nudWeight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWeight.Location = new System.Drawing.Point(764, 63);
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(212, 23);
            this.nudWeight.TabIndex = 23;
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
            this.btnBack.Location = new System.Drawing.Point(552, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 32);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddQuestion.BackColor = System.Drawing.Color.White;
            this.btnAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Location = new System.Drawing.Point(640, 526);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(120, 32);
            this.btnAddQuestion.TabIndex = 25;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Location = new System.Drawing.Point(768, 526);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(120, 32);
            this.btnAddCategory.TabIndex = 26;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
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
            this.btnSaveChanges.TabIndex = 27;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // frmQuestionnaireMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 574);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlMapping);
            this.Controls.Add(this.pnlEditQuestion);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmQuestionnaireMaintenance";
            this.ShowIcon = false;
            this.Text = "Interest Questionnaire Maintenance";
            this.Load += new System.EventHandler(this.frmQuestionnaireMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.pnlMappingAccent.ResumeLayout(false);
            this.pnlMapping.ResumeLayout(false);
            this.pnlMapping.PerformLayout();
            this.pnlEditQuestionAccent.ResumeLayout(false);
            this.pnlEditQuestion.ResumeLayout(false);
            this.pnlEditQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.pnlQuestionsAccent.ResumeLayout(false);
            this.pnlQuestions.ResumeLayout(false);
            this.pnlQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Panel pnlQuestionsAccent;
        private System.Windows.Forms.Label lblQuestionsTitle;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlEditQuestion;
        private System.Windows.Forms.Panel pnlEditQuestionAccent;
        private System.Windows.Forms.Label lblEditQuestionTitle;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblQuestionStatus;
        private System.Windows.Forms.ComboBox cboQuestionStatus;
        private System.Windows.Forms.Panel pnlMapping;
        private System.Windows.Forms.Panel pnlMappingAccent;
        private System.Windows.Forms.Label lblMappingTitle;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblMapProgramme;
        private System.Windows.Forms.ComboBox cboMapProgramme;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}
