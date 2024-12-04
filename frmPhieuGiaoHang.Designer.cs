namespace MeVaBeProject
{
    partial class frmPhieuGiaoHang
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
            this.rptPhieuGiaoHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptPhieuGiaoHang
            // 
            this.rptPhieuGiaoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptPhieuGiaoHang.LocalReport.ReportEmbeddedResource = "MeVaBeProject.PhieuGiaoHang.rdlc";
            this.rptPhieuGiaoHang.Location = new System.Drawing.Point(0, 0);
            this.rptPhieuGiaoHang.Name = "rptPhieuGiaoHang";
            this.rptPhieuGiaoHang.ServerReport.BearerToken = null;
            this.rptPhieuGiaoHang.Size = new System.Drawing.Size(919, 769);
            this.rptPhieuGiaoHang.TabIndex = 0;
            // 
            // frmPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 769);
            this.Controls.Add(this.rptPhieuGiaoHang);
            this.Name = "frmPhieuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuGiaoHang";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptPhieuGiaoHang;
    }
}