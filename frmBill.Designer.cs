namespace MeVaBeProject
{
    partial class frmBill
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
            this.hoaDonReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // hoaDonReport
            // 
            this.hoaDonReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoaDonReport.Location = new System.Drawing.Point(0, 0);
            this.hoaDonReport.Name = "hoaDonReport";
            this.hoaDonReport.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.hoaDonReport.ServerReport.BearerToken = null;
            this.hoaDonReport.Size = new System.Drawing.Size(800, 450);
            this.hoaDonReport.TabIndex = 0;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hoaDonReport);
            this.Name = "frmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer hoaDonReport;
    }
}