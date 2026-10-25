namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmLearnerProfile
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
            this.pnlProfileDetails = new System.Windows.Forms.Panel();
            this.pnlProfileDetailsAccent = new System.Windows.Forms.Panel();
            this.lblProfileDetailsTitle = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.lblLearnerName = new System.Windows.Forms.Label();
            this.txtLearnerName = new System.Windows.Forms.TextBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCancelSession = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlProfileDetails.SuspendLayout();
            this.pnlProfileDetailsAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Learner Profile";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Step 1 of 5 · Tell us about your current studies.";
            // 
            // pnlProfileDetails
            // 
            this.pnlProfileDetails.Controls.Add(this.pnlProfileDetailsAccent);
            this.pnlProfileDetails.Controls.Add(this.lblProfileDetailsTitle);
            this.pnlProfileDetails.Controls.Add(this.lblGrade);
            this.pnlProfileDetails.Controls.Add(this.cboGrade);
            this.pnlProfileDetails.Controls.Add(this.lblProvince);
            this.pnlProfileDetails.Controls.Add(this.cboProvince);
            this.pnlProfileDetails.Controls.Add(this.lblLearnerName);
            this.pnlProfileDetails.Controls.Add(this.txtLearnerName);
            this.pnlProfileDetails.Controls.Add(this.lblSchool);
            this.pnlProfileDetails.Controls.Add(this.txtSchool);
            this.pnlProfileDetails.Controls.Add(this.lblEmail);
            this.pnlProfileDetails.Controls.Add(this.txtEmail);
            this.pnlProfileDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlProfileDetails.BackColor = System.Drawing.Color.White;
            this.pnlProfileDetails.Location = new System.Drawing.Point(24, 84);
            this.pnlProfileDetails.Name = "pnlProfileDetails";
            this.pnlProfileDetails.Size = new System.Drawing.Size(992, 214);
            this.pnlProfileDetails.TabIndex = 2;
            // 
            // pnlProfileDetailsAccent
            // 
            this.pnlProfileDetailsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlProfileDetailsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileDetailsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileDetailsAccent.Name = "pnlProfileDetailsAccent";
            this.pnlProfileDetailsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlProfileDetailsAccent.TabIndex = 3;
            // 
            // lblProfileDetailsTitle
            // 
            this.lblProfileDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProfileDetailsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblProfileDetailsTitle.Name = "lblProfileDetailsTitle";
            this.lblProfileDetailsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblProfileDetailsTitle.TabIndex = 4;
            this.lblProfileDetailsTitle.Text = "Profile details";
            // 
            // lblGrade
            // 
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblGrade.Location = new System.Drawing.Point(16, 44);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(470, 16);
            this.lblGrade.TabIndex = 5;
            this.lblGrade.Text = "Grade *";
            // 
            // cboGrade
            // 
            this.cboGrade.Items.AddRange(new object[] {
            "Grade 11",
            "Grade 12"});
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(16, 63);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(470, 23);
            this.cboGrade.TabIndex = 6;
            // 
            // lblProvince
            // 
            this.lblProvince.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblProvince.Location = new System.Drawing.Point(506, 44);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(470, 16);
            this.lblProvince.TabIndex = 7;
            this.lblProvince.Text = "Province";
            // 
            // cboProvince
            // 
            this.cboProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "North West",
            "Northern Cape",
            "Western Cape"});
            this.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(506, 63);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(470, 23);
            this.cboProvince.TabIndex = 8;
            // 
            // lblLearnerName
            // 
            this.lblLearnerName.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblLearnerName.Location = new System.Drawing.Point(16, 96);
            this.lblLearnerName.Name = "lblLearnerName";
            this.lblLearnerName.Size = new System.Drawing.Size(470, 16);
            this.lblLearnerName.TabIndex = 9;
            this.lblLearnerName.Text = "Name (optional)";
            // 
            // txtLearnerName
            // 
            this.txtLearnerName.MaxLength = 100;
            this.txtLearnerName.Location = new System.Drawing.Point(16, 115);
            this.txtLearnerName.Name = "txtLearnerName";
            this.txtLearnerName.Size = new System.Drawing.Size(470, 23);
            this.txtLearnerName.TabIndex = 10;
            // 
            // lblSchool
            // 
            this.lblSchool.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSchool.Location = new System.Drawing.Point(506, 96);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(470, 16);
            this.lblSchool.TabIndex = 11;
            this.lblSchool.Text = "School (optional)";
            // 
            // txtSchool
            // 
            this.txtSchool.MaxLength = 100;
            this.txtSchool.Location = new System.Drawing.Point(506, 115);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(470, 23);
            this.txtSchool.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblEmail.Location = new System.Drawing.Point(16, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(470, 16);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Contact email (optional)";
            // 
            // txtEmail
            // 
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Location = new System.Drawing.Point(16, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(470, 23);
            this.txtEmail.TabIndex = 14;
            // 
            // btnCancelSession
            // 
            this.btnCancelSession.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnCancelSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSession.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnCancelSession.BackColor = System.Drawing.Color.White;
            this.btnCancelSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelSession.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSession.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnCancelSession.UseVisualStyleBackColor = false;
            this.btnCancelSession.Location = new System.Drawing.Point(682, 314);
            this.btnCancelSession.Name = "btnCancelSession";
            this.btnCancelSession.Size = new System.Drawing.Size(134, 32);
            this.btnCancelSession.TabIndex = 15;
            this.btnCancelSession.Text = "Cancel Session";
            this.btnCancelSession.Click += new System.EventHandler(this.btnCancelSession_Click);
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
            this.btnNext.Location = new System.Drawing.Point(824, 314);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 32);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Next: Subjects & Marks";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // frmLearnerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 362);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancelSession);
            this.Controls.Add(this.pnlProfileDetails);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmLearnerProfile";
            this.ShowIcon = false;
            this.Text = "Learner Profile";
            this.Load += new System.EventHandler(this.frmLearnerProfile_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLearnerProfile_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlProfileDetailsAccent.ResumeLayout(false);
            this.pnlProfileDetails.ResumeLayout(false);
            this.pnlProfileDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlProfileDetails;
        private System.Windows.Forms.Panel pnlProfileDetailsAccent;
        private System.Windows.Forms.Label lblProfileDetailsTitle;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Label lblLearnerName;
        private System.Windows.Forms.TextBox txtLearnerName;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancelSession;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}
