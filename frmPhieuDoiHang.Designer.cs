namespace MeVaBeProject
{
    partial class frmPhieuDoiHang
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
            this.phieuDoiHangReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // phieuDoiHangReportViewer
            // 
            this.phieuDoiHangReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuDoiHangReportViewer.LocalReport.ReportEmbeddedResource = "MeVaBeProject.PhieuDoiHang.rdlc";
            this.phieuDoiHangReportViewer.Location = new System.Drawing.Point(0, 0);
            this.phieuDoiHangReportViewer.Name = "phieuDoiHangReportViewer";
            this.phieuDoiHangReportViewer.ServerReport.BearerToken = null;
            this.phieuDoiHangReportViewer.Size = new System.Drawing.Size(702, 661);
            this.phieuDoiHangReportViewer.TabIndex = 0;
            // 
            // frmPhieuDoiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 661);
            this.Controls.Add(this.phieuDoiHangReportViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPhieuDoiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu đổi hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhieuDoiHang_FormClosed);
            this.Load += new System.EventHandler(this.frmPhieuDoiHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer phieuDoiHangReportViewer;
    }
}