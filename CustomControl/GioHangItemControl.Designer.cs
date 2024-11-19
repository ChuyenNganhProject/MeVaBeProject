namespace CustomControl
{
    partial class GioHangItemControl
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GioHangItemControl));
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhanTramGiamSp = new System.Windows.Forms.Label();
            this.labelTenSp = new System.Windows.Forms.Label();
            this.labelTongGiaTri = new System.Windows.Forms.Label();
            this.numericSoLuongSp = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGiaGoc = new System.Windows.Forms.Label();
            this.labelGiaTinhTien = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuongSp)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(390, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 89);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPhanTramGiamSp);
            this.panel2.Controls.Add(this.labelTenSp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 89);
            this.panel2.TabIndex = 12;
            // 
            // lblPhanTramGiamSp
            // 
            this.lblPhanTramGiamSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPhanTramGiamSp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhanTramGiamSp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPhanTramGiamSp.Location = new System.Drawing.Point(0, 61);
            this.lblPhanTramGiamSp.Name = "lblPhanTramGiamSp";
            this.lblPhanTramGiamSp.Size = new System.Drawing.Size(150, 28);
            this.lblPhanTramGiamSp.TabIndex = 12;
            this.lblPhanTramGiamSp.Text = "(-0%)";
            this.lblPhanTramGiamSp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPhanTramGiamSp.Visible = false;
            // 
            // labelTenSp
            // 
            this.labelTenSp.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTenSp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenSp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTenSp.Location = new System.Drawing.Point(0, 0);
            this.labelTenSp.Name = "labelTenSp";
            this.labelTenSp.Size = new System.Drawing.Size(150, 55);
            this.labelTenSp.TabIndex = 1;
            this.labelTenSp.Text = "Tên sản phẩm";
            // 
            // labelTongGiaTri
            // 
            this.labelTongGiaTri.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTongGiaTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTongGiaTri.Location = new System.Drawing.Point(292, 0);
            this.labelTongGiaTri.Name = "labelTongGiaTri";
            this.labelTongGiaTri.Size = new System.Drawing.Size(99, 89);
            this.labelTongGiaTri.TabIndex = 15;
            this.labelTongGiaTri.Text = "Tổng tiền";
            this.labelTongGiaTri.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericSoLuongSp
            // 
            this.numericSoLuongSp.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericSoLuongSp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericSoLuongSp.Location = new System.Drawing.Point(231, 0);
            this.numericSoLuongSp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSoLuongSp.Name = "numericSoLuongSp";
            this.numericSoLuongSp.Size = new System.Drawing.Size(61, 30);
            this.numericSoLuongSp.TabIndex = 14;
            this.numericSoLuongSp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGiaGoc);
            this.panel1.Controls.Add(this.labelGiaTinhTien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 89);
            this.panel1.TabIndex = 13;
            // 
            // lblGiaGoc
            // 
            this.lblGiaGoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGiaGoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaGoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGiaGoc.Location = new System.Drawing.Point(0, 61);
            this.lblGiaGoc.Name = "lblGiaGoc";
            this.lblGiaGoc.Size = new System.Drawing.Size(81, 28);
            this.lblGiaGoc.TabIndex = 11;
            this.lblGiaGoc.Text = "Đơn giá";
            this.lblGiaGoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGiaGoc.Visible = false;
            // 
            // labelGiaTinhTien
            // 
            this.labelGiaTinhTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGiaTinhTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelGiaTinhTien.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelGiaTinhTien.Location = new System.Drawing.Point(0, 0);
            this.labelGiaTinhTien.Name = "labelGiaTinhTien";
            this.labelGiaTinhTien.Size = new System.Drawing.Size(81, 33);
            this.labelGiaTinhTien.TabIndex = 10;
            this.labelGiaTinhTien.Text = "Đơn giá";
            this.labelGiaTinhTien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GioHangItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelTongGiaTri);
            this.Controls.Add(this.numericSoLuongSp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXoa);
            this.Name = "GioHangItemControl";
            this.Size = new System.Drawing.Size(430, 89);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuongSp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblPhanTramGiamSp;
        public System.Windows.Forms.Label labelTenSp;
        public System.Windows.Forms.Label labelTongGiaTri;
        public System.Windows.Forms.NumericUpDown numericSoLuongSp;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblGiaGoc;
        public System.Windows.Forms.Label labelGiaTinhTien;
    }
}
