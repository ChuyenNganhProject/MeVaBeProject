namespace MeVaBeProject
{
    partial class frmPhieuThanhLy
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
            this.phieuThanhLyReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // phieuThanhLyReportView
            // 
            this.phieuThanhLyReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuThanhLyReportView.LocalReport.ReportEmbeddedResource = "MeVaBeProject.PhieuThanhLy.rdlc";
            this.phieuThanhLyReportView.Location = new System.Drawing.Point(0, 0);
            this.phieuThanhLyReportView.Name = "phieuThanhLyReportView";
            this.phieuThanhLyReportView.ServerReport.BearerToken = null;
            this.phieuThanhLyReportView.Size = new System.Drawing.Size(729, 661);
            this.phieuThanhLyReportView.TabIndex = 0;
            // 
            // frmPhieuThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 661);
            this.Controls.Add(this.phieuThanhLyReportView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPhieuThanhLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu thanh lý";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhieuThanhLy_FormClosed);
            this.Load += new System.EventHandler(this.frmPhieuThanhLy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer phieuThanhLyReportView;
    }
}