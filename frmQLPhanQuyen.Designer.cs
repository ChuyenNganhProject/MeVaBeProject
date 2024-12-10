namespace MeVaBeProject
{
    partial class frmQLPhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UILabel();
            this.dtgvQuyenHeThong = new Sunny.UI.UIDataGridView();
            this.maQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.dtgvChiTietQuyen = new Sunny.UI.UIDataGridView();
            this.maQuyenCuaLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuyenCuaLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new Sunny.UI.UISymbolButton();
            this.btnXoa = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuyenHeThong)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnClose);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel1.Size = new System.Drawing.Size(1100, 39);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "Phân Quyền";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(1052, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgvQuyenHeThong
            // 
            this.dtgvQuyenHeThong.AllowUserToAddRows = false;
            this.dtgvQuyenHeThong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvQuyenHeThong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvQuyenHeThong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvQuyenHeThong.BackgroundColor = System.Drawing.Color.White;
            this.dtgvQuyenHeThong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQuyenHeThong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvQuyenHeThong.ColumnHeadersHeight = 32;
            this.dtgvQuyenHeThong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvQuyenHeThong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuyen,
            this.tenQuyen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvQuyenHeThong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvQuyenHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvQuyenHeThong.EnableHeadersVisualStyles = false;
            this.dtgvQuyenHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgvQuyenHeThong.GridColor = System.Drawing.Color.White;
            this.dtgvQuyenHeThong.Location = new System.Drawing.Point(0, 32);
            this.dtgvQuyenHeThong.Name = "dtgvQuyenHeThong";
            this.dtgvQuyenHeThong.ReadOnly = true;
            this.dtgvQuyenHeThong.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvQuyenHeThong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            this.dtgvQuyenHeThong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvQuyenHeThong.SelectedIndex = -1;
            this.dtgvQuyenHeThong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQuyenHeThong.Size = new System.Drawing.Size(449, 379);
            this.dtgvQuyenHeThong.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvQuyenHeThong.TabIndex = 1;
            // 
            // maQuyen
            // 
            this.maQuyen.DataPropertyName = "maQuyen";
            this.maQuyen.HeaderText = "Mã quyền";
            this.maQuyen.Name = "maQuyen";
            this.maQuyen.ReadOnly = true;
            this.maQuyen.Width = 102;
            // 
            // tenQuyen
            // 
            this.tenQuyen.DataPropertyName = "tenQuyen";
            this.tenQuyen.HeaderText = "Tên quyền";
            this.tenQuyen.Name = "tenQuyen";
            this.tenQuyen.ReadOnly = true;
            this.tenQuyen.Width = 107;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dtgvQuyenHeThong);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 39);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox1.Size = new System.Drawing.Size(449, 411);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Quyền hệ thống";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.dtgvChiTietQuyen);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiGroupBox2.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(576, 39);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox2.Size = new System.Drawing.Size(524, 411);
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "Quyền của loại nhân viên";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgvChiTietQuyen
            // 
            this.dtgvChiTietQuyen.AllowUserToAddRows = false;
            this.dtgvChiTietQuyen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvChiTietQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvChiTietQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvChiTietQuyen.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietQuyen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvChiTietQuyen.ColumnHeadersHeight = 32;
            this.dtgvChiTietQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvChiTietQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuyenCuaLoaiNhanVien,
            this.tenQuyenCuaLoaiNV,
            this.tenLoaiNV,
            this.ngayCapQuyen});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvChiTietQuyen.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvChiTietQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietQuyen.EnableHeadersVisualStyles = false;
            this.dtgvChiTietQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgvChiTietQuyen.GridColor = System.Drawing.Color.White;
            this.dtgvChiTietQuyen.Location = new System.Drawing.Point(0, 32);
            this.dtgvChiTietQuyen.Name = "dtgvChiTietQuyen";
            this.dtgvChiTietQuyen.ReadOnly = true;
            this.dtgvChiTietQuyen.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietQuyen.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightPink;
            this.dtgvChiTietQuyen.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvChiTietQuyen.ScrollBarColor = System.Drawing.Color.HotPink;
            this.dtgvChiTietQuyen.ScrollBarStyleInherited = false;
            this.dtgvChiTietQuyen.SelectedIndex = -1;
            this.dtgvChiTietQuyen.Size = new System.Drawing.Size(524, 379);
            this.dtgvChiTietQuyen.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvChiTietQuyen.TabIndex = 1;
            // 
            // maQuyenCuaLoaiNhanVien
            // 
            this.maQuyenCuaLoaiNhanVien.DataPropertyName = "maQuyen";
            this.maQuyenCuaLoaiNhanVien.HeaderText = "Mã quyền";
            this.maQuyenCuaLoaiNhanVien.Name = "maQuyenCuaLoaiNhanVien";
            this.maQuyenCuaLoaiNhanVien.ReadOnly = true;
            this.maQuyenCuaLoaiNhanVien.Width = 102;
            // 
            // tenQuyenCuaLoaiNV
            // 
            this.tenQuyenCuaLoaiNV.DataPropertyName = "tenQuyen";
            this.tenQuyenCuaLoaiNV.HeaderText = "Tên quyền";
            this.tenQuyenCuaLoaiNV.Name = "tenQuyenCuaLoaiNV";
            this.tenQuyenCuaLoaiNV.ReadOnly = true;
            this.tenQuyenCuaLoaiNV.Width = 107;
            // 
            // tenLoaiNV
            // 
            this.tenLoaiNV.DataPropertyName = "tenLoaiNhanVien";
            this.tenLoaiNV.HeaderText = "Loại nhân viên";
            this.tenLoaiNV.Name = "tenLoaiNV";
            this.tenLoaiNV.ReadOnly = true;
            this.tenLoaiNV.Width = 135;
            // 
            // ngayCapQuyen
            // 
            this.ngayCapQuyen.DataPropertyName = "ngayCapQuyen";
            this.ngayCapQuyen.HeaderText = "Ngày cấp quyền";
            this.ngayCapQuyen.Name = "ngayCapQuyen";
            this.ngayCapQuyen.ReadOnly = true;
            this.ngayCapQuyen.Width = 146;
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.HotPink;
            this.btnThem.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnThem.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnThem.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(456, 160);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.RectColor = System.Drawing.Color.LightPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnThem.Size = new System.Drawing.Size(114, 44);
            this.btnThem.Symbol = 61525;
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnXoa.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnXoa.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(456, 310);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RectColor = System.Drawing.Color.LightPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Size = new System.Drawing.Size(114, 44);
            this.btnXoa.Symbol = 61527;
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQLPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.uiGroupBox2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLPhanQuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLPhanQuyen";
            this.Load += new System.EventHandler(this.frmQLPhanQuyen_Load);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuyenHeThong)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel btnClose;
        private Sunny.UI.UIDataGridView dtgvQuyenHeThong;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIDataGridView dtgvChiTietQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuyen;
        private Sunny.UI.UISymbolButton btnThem;
        private Sunny.UI.UISymbolButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyenCuaLoaiNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuyenCuaLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapQuyen;
    }
}