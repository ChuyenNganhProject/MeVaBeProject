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
            this.labelTenSp = new System.Windows.Forms.Label();
            this.labelDonGia = new System.Windows.Forms.Label();
            this.numericSoLuongSp = new System.Windows.Forms.NumericUpDown();
            this.labelTongGiaTri = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuongSp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTenSp
            // 
            this.labelTenSp.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTenSp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTenSp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelTenSp.Location = new System.Drawing.Point(0, 0);
            this.labelTenSp.Name = "labelTenSp";
            this.labelTenSp.Size = new System.Drawing.Size(144, 64);
            this.labelTenSp.TabIndex = 0;
            this.labelTenSp.Text = "Tên sản phẩm";
            // 
            // labelDonGia
            // 
            this.labelDonGia.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDonGia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelDonGia.Location = new System.Drawing.Point(144, 0);
            this.labelDonGia.Name = "labelDonGia";
            this.labelDonGia.Size = new System.Drawing.Size(85, 64);
            this.labelDonGia.TabIndex = 1;
            this.labelDonGia.Text = "Đơn giá";
            this.labelDonGia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericSoLuongSp
            // 
            this.numericSoLuongSp.Dock = System.Windows.Forms.DockStyle.Left;
            this.numericSoLuongSp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericSoLuongSp.Location = new System.Drawing.Point(229, 0);
            this.numericSoLuongSp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSoLuongSp.Name = "numericSoLuongSp";
            this.numericSoLuongSp.Size = new System.Drawing.Size(61, 30);
            this.numericSoLuongSp.TabIndex = 4;
            this.numericSoLuongSp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelTongGiaTri
            // 
            this.labelTongGiaTri.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTongGiaTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTongGiaTri.Location = new System.Drawing.Point(290, 0);
            this.labelTongGiaTri.Name = "labelTongGiaTri";
            this.labelTongGiaTri.Size = new System.Drawing.Size(99, 64);
            this.labelTongGiaTri.TabIndex = 5;
            this.labelTongGiaTri.Text = "Tổng tiền";
            this.labelTongGiaTri.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.btnXoa.Size = new System.Drawing.Size(40, 64);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // GioHangItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.labelTongGiaTri);
            this.Controls.Add(this.numericSoLuongSp);
            this.Controls.Add(this.labelDonGia);
            this.Controls.Add(this.labelTenSp);
            this.Name = "GioHangItemControl";
            this.Size = new System.Drawing.Size(430, 64);
            ((System.ComponentModel.ISupportInitialize)(this.numericSoLuongSp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelTenSp;
        public System.Windows.Forms.Label labelDonGia;
        public System.Windows.Forms.NumericUpDown numericSoLuongSp;
        public System.Windows.Forms.Label labelTongGiaTri;
        private System.Windows.Forms.Button btnXoa;
    }
}
