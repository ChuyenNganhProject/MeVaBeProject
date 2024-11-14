using System.Drawing;

namespace CustomControl
{
    partial class SanPhamItemControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.labelGiaSanPham = new System.Windows.Forms.Label();
            this.labelTenSp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.labelMaSp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbAnhSp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGiaSanPham
            // 
            this.labelGiaSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelGiaSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelGiaSanPham.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelGiaSanPham.Location = new System.Drawing.Point(0, 285);
            this.labelGiaSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGiaSanPham.Name = "labelGiaSanPham";
            this.labelGiaSanPham.Size = new System.Drawing.Size(218, 30);
            this.labelGiaSanPham.TabIndex = 2;
            this.labelGiaSanPham.Text = "Giá";
            this.labelGiaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTenSp
            // 
            this.labelTenSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTenSp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenSp.Location = new System.Drawing.Point(0, 231);
            this.labelTenSp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenSp.Name = "labelTenSp";
            this.labelTenSp.Size = new System.Drawing.Size(218, 54);
            this.labelTenSp.TabIndex = 5;
            this.labelTenSp.Text = "Tên sản phẩm";
            this.labelTenSp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 22);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMaSp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 22);
            this.panel2.TabIndex = 8;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSoLuong.Location = new System.Drawing.Point(0, 0);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(218, 22);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaSp
            // 
            this.labelMaSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaSp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMaSp.ForeColor = System.Drawing.Color.Red;
            this.labelMaSp.Location = new System.Drawing.Point(34, 0);
            this.labelMaSp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaSp.Name = "labelMaSp";
            this.labelMaSp.Size = new System.Drawing.Size(184, 22);
            this.labelMaSp.TabIndex = 7;
            this.labelMaSp.Text = "Mã";
            this.labelMaSp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbAnhSp
            // 
            this.pbAnhSp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAnhSp.Location = new System.Drawing.Point(0, 0);
            this.pbAnhSp.Margin = new System.Windows.Forms.Padding(4);
            this.pbAnhSp.Name = "pbAnhSp";
            this.pbAnhSp.Size = new System.Drawing.Size(218, 187);
            this.pbAnhSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhSp.TabIndex = 9;
            this.pbAnhSp.TabStop = false;
            // 
            // SanPhamItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pbAnhSp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTenSp);
            this.Controls.Add(this.labelGiaSanPham);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPhamItemControl";
            this.Size = new System.Drawing.Size(218, 315);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSp)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public System.Windows.Forms.Label labelGiaSanPham;
        public System.Windows.Forms.Label labelTenSp;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelMaSp;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbAnhSp;
    }
}
