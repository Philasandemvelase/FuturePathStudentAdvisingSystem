namespace FuturePathStudentAdvisingSystem.Presentation
{
    partial class frmReportPreview
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
            this.pnlReportBody = new System.Windows.Forms.Panel();
            this.pnlReportBodyAccent = new System.Windows.Forms.Panel();
            this.lblReportSection = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pnlCommonGaps = new System.Windows.Forms.Panel();
            this.pnlCommonGapsAccent = new System.Windows.Forms.Panel();
            this.lblCommonGapsTitle = new System.Windows.Forms.Label();
            this.lblCommonGaps = new System.Windows.Forms.Label();
            this.btnBackToSelection = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.dlgSaveReport = new System.Windows.Forms.SaveFileDialog();
            this.pnlReportBody.SuspendLayout();
            this.pnlReportBodyAccent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlCommonGaps.SuspendLayout();
            this.pnlCommonGapsAccent.SuspendLayout();
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
            this.lblPageTitle.Text = "Report Preview";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(102, 102, 102);
            this.lblPageSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(900, 18);
            this.lblPageSubtitle.TabIndex = 1;
            this.lblPageSubtitle.Text = "Degree Interest and Eligibility Report · Illustrative report data.";
            // 
            // pnlReportBody
            // 
            this.pnlReportBody.Controls.Add(this.pnlReportBodyAccent);
            this.pnlReportBody.Controls.Add(this.lblReportSection);
            this.pnlReportBody.Controls.Add(this.dgvReport);
            this.pnlReportBody.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlReportBody.BackColor = System.Drawing.Color.White;
            this.pnlReportBody.Location = new System.Drawing.Point(24, 84);
            this.pnlReportBody.Name = "pnlReportBody";
            this.pnlReportBody.Size = new System.Drawing.Size(992, 234);
            this.pnlReportBody.TabIndex = 2;
            // 
            // pnlReportBodyAccent
            // 
            this.pnlReportBodyAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlReportBodyAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportBodyAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlReportBodyAccent.Name = "pnlReportBodyAccent";
            this.pnlReportBodyAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlReportBodyAccent.TabIndex = 3;
            // 
            // lblReportSection
            // 
            this.lblReportSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportSection.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblReportSection.Location = new System.Drawing.Point(16, 14);
            this.lblReportSection.Name = "lblReportSection";
            this.lblReportSection.Size = new System.Drawing.Size(700, 20);
            this.lblReportSection.TabIndex = 4;
            this.lblReportSection.Text = "Advising activity · 01–11 September 2026";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(238, 238, 238);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeight = 30;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.dgvReport.Location = new System.Drawing.Point(16, 44);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(960, 176);
            this.dgvReport.TabIndex = 5;
            // 
            // pnlCommonGaps
            // 
            this.pnlCommonGaps.Controls.Add(this.pnlCommonGapsAccent);
            this.pnlCommonGaps.Controls.Add(this.lblCommonGapsTitle);
            this.pnlCommonGaps.Controls.Add(this.lblCommonGaps);
            this.pnlCommonGaps.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.pnlCommonGaps.BackColor = System.Drawing.Color.White;
            this.pnlCommonGaps.Location = new System.Drawing.Point(24, 332);
            this.pnlCommonGaps.Name = "pnlCommonGaps";
            this.pnlCommonGaps.Size = new System.Drawing.Size(992, 84);
            this.pnlCommonGaps.TabIndex = 6;
            // 
            // pnlCommonGapsAccent
            // 
            this.pnlCommonGapsAccent.BackColor = System.Drawing.Color.FromArgb(218, 30, 40);
            this.pnlCommonGapsAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCommonGapsAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlCommonGapsAccent.Name = "pnlCommonGapsAccent";
            this.pnlCommonGapsAccent.Size = new System.Drawing.Size(992, 3);
            this.pnlCommonGapsAccent.TabIndex = 7;
            // 
            // lblCommonGapsTitle
            // 
            this.lblCommonGapsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommonGapsTitle.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCommonGapsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblCommonGapsTitle.Name = "lblCommonGapsTitle";
            this.lblCommonGapsTitle.Size = new System.Drawing.Size(700, 20);
            this.lblCommonGapsTitle.TabIndex = 8;
            this.lblCommonGapsTitle.Text = "Common gaps";
            // 
            // lblCommonGaps
            // 
            this.lblCommonGaps.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right));
            this.lblCommonGaps.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.lblCommonGaps.Location = new System.Drawing.Point(16, 42);
            this.lblCommonGaps.Name = "lblCommonGaps";
            this.lblCommonGaps.Size = new System.Drawing.Size(940, 32);
            this.lblCommonGaps.TabIndex = 9;
            this.lblCommonGaps.Text = "Mathematics below minimum (2 sessions) · Physical Sciences missing (1 session) · Mathematics mark not supplied (1 session)";
            // 
            // btnBackToSelection
            // 
            this.btnBackToSelection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnBackToSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnBackToSelection.BackColor = System.Drawing.Color.White;
            this.btnBackToSelection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToSelection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToSelection.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnBackToSelection.UseVisualStyleBackColor = false;
            this.btnBackToSelection.Location = new System.Drawing.Point(651, 432);
            this.btnBackToSelection.Name = "btnBackToSelection";
            this.btnBackToSelection.Size = new System.Drawing.Size(156, 32);
            this.btnBackToSelection.TabIndex = 10;
            this.btnBackToSelection.Text = "Back to Selection";
            this.btnBackToSelection.Click += new System.EventHandler(this.btnBackToSelection_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Location = new System.Drawing.Point(815, 432);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 32);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(196, 18, 32);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Location = new System.Drawing.Point(903, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Report";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.Document = this.printReport;
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(900, 700);
            this.dlgPrintPreview.UseAntiAlias = true;
            // 
            // dlgSaveReport
            // 
            this.dlgSaveReport.Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt";
            this.dlgSaveReport.Title = "Save report";
            // 
            // frmReportPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1000, 480);
            this.BackColor = System.Drawing.Color.FromArgb(244, 244, 244);
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnBackToSelection);
            this.Controls.Add(this.pnlCommonGaps);
            this.Controls.Add(this.pnlReportBody);
            this.Controls.Add(this.lblPageSubtitle);
            this.Controls.Add(this.lblPageTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "frmReportPreview";
            this.ShowIcon = false;
            this.Text = "Report Preview";
            this.Load += new System.EventHandler(this.frmReportPreview_Load);
            this.pnlCommonGapsAccent.ResumeLayout(false);
            this.pnlCommonGaps.ResumeLayout(false);
            this.pnlCommonGaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlReportBodyAccent.ResumeLayout(false);
            this.pnlReportBody.ResumeLayout(false);
            this.pnlReportBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel pnlReportBody;
        private System.Windows.Forms.Panel pnlReportBodyAccent;
        private System.Windows.Forms.Label lblReportSection;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel pnlCommonGaps;
        private System.Windows.Forms.Panel pnlCommonGapsAccent;
        private System.Windows.Forms.Label lblCommonGapsTitle;
        private System.Windows.Forms.Label lblCommonGaps;
        private System.Windows.Forms.Button btnBackToSelection;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
        private System.Windows.Forms.SaveFileDialog dlgSaveReport;
    }
}
