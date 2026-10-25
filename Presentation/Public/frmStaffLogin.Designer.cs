namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmStaffLogin
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
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.pnlSignInAccent = new System.Windows.Forms.Panel();
            this.lblSignInTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLoginError = new System.Windows.Forms.Label();
            this.btnBackToWelcome = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblAccessNote = new System.Windows.Forms.Label();
            this.pnlSignIn.SuspendLayout();
            this.pnlSignInAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Staff Login";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Career Advisors and System Administrators authenticate here.";
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.Controls.Add(this.pnlSignInAccent);
            this.pnlSignIn.Controls.Add(this.lblSignInTitle);
            this.pnlSignIn.Controls.Add(this.lblUsername);
            this.pnlSignIn.Controls.Add(this.txtUsername);
            this.pnlSignIn.Controls.Add(this.lblPassword);
            this.pnlSignIn.Controls.Add(this.txtPassword);
            this.pnlSignIn.Controls.Add(this.lblLoginError);
            this.pnlSignIn.Controls.Add(this.btnBackToWelcome);
            this.pnlSignIn.Controls.Add(this.btnSignIn);
            this.pnlSignIn.BackColor = System.Drawing.Color.White;
            this.pnlSignIn.Location = new System.Drawing.Point(24, 84);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(432, 236);
            this.pnlSignIn.TabIndex = 2;
            // 
            // pnlSignInAccent
            // 
            this.pnlSignInAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlSignInAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSignInAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlSignInAccent.Name = "pnlSignInAccent";
            this.pnlSignInAccent.Size = new System.Drawing.Size(432, 3);
            this.pnlSignInAccent.TabIndex = 3;
            // 
            // lblSignInTitle
            // 
            this.lblSignInTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignInTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblSignInTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSignInTitle.Name = "lblSignInTitle";
            this.lblSignInTitle.Size = new System.Drawing.Size(300, 20);
            this.lblSignInTitle.TabIndex = 4;
            this.lblSignInTitle.Text = "Sign in";
            // 
            // lblUsername
            // 
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblUsername.Location = new System.Drawing.Point(16, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(400, 16);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username *";
            // 
            // txtUsername
            // 
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Location = new System.Drawing.Point(16, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(400, 23);
            this.txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblPassword.Location = new System.Drawing.Point(16, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(400, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password *";
            // 
            // txtPassword
            // 
            this.txtPassword.MaxLength = 50;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Location = new System.Drawing.Point(16, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // lblLoginError
            // 
            this.lblLoginError.BackColor = System.Drawing.Color.FromArgb(253, 232, 234);
            this.lblLoginError.ForeColor = System.Drawing.Color.FromArgb(164, 22, 26);
            this.lblLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginError.Visible = false;
            this.lblLoginError.Location = new System.Drawing.Point(16, 148);
            this.lblLoginError.Name = "lblLoginError";
            this.lblLoginError.Size = new System.Drawing.Size(400, 28);
            this.lblLoginError.TabIndex = 9;
            this.lblLoginError.Text = "  Username or password is incorrect. Please try again.";
            // 
            // btnBackToWelcome
            // 
            this.btnBackToWelcome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnBackToWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.btnBackToWelcome.BackColor = System.Drawing.Color.White;
            this.btnBackToWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToWelcome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToWelcome.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBackToWelcome.UseVisualStyleBackColor = false;
            this.btnBackToWelcome.Location = new System.Drawing.Point(186, 188);
            this.btnBackToWelcome.Name = "btnBackToWelcome";
            this.btnBackToWelcome.Size = new System.Drawing.Size(132, 32);
            this.btnBackToWelcome.TabIndex = 10;
            this.btnBackToWelcome.Text = "Back to Welcome";
            this.btnBackToWelcome.Click += new System.EventHandler(this.btnBackToWelcome_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Location = new System.Drawing.Point(326, 188);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(90, 32);
            this.btnSignIn.TabIndex = 11;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblAccessNote
            // 
            this.lblAccessNote.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblAccessNote.Location = new System.Drawing.Point(24, 330);
            this.lblAccessNote.Name = "lblAccessNote";
            this.lblAccessNote.Size = new System.Drawing.Size(432, 18);
            this.lblAccessNote.TabIndex = 12;
            this.lblAccessNote.Text = "Your account determines which dashboard and functions you can access.";
            // 
            // frmStaffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AcceptButton = this.btnSignIn;
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.CancelButton = this.btnBackToWelcome;
            this.ClientSize = new System.Drawing.Size(480, 364);
            this.Controls.Add(this.lblAccessNote);
            this.Controls.Add(this.pnlSignIn);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaffLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.frmStaffLogin_Load);
            this.pnlSignInAccent.ResumeLayout(false);
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Panel pnlSignInAccent;
        private System.Windows.Forms.Label lblSignInTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLoginError;
        private System.Windows.Forms.Button btnBackToWelcome;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblAccessNote;
    }
}
