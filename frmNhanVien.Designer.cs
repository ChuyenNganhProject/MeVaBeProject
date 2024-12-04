namespace MeVaBeProject
{
    partial class frmNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvNhanVien = new Sunny.UI.UIDataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.btnLamMoi = new Sunny.UI.UISymbolButton();
            this.btnXoa = new Sunny.UI.UISymbolButton();
            this.btnThem = new Sunny.UI.UISymbolButton();
            this.btnSua = new Sunny.UI.UISymbolButton();
            this.btnOpen = new Sunny.UI.UISymbolButton();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.txtLuong = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txtMatKhau = new Sunny.UI.UITextBox();
            this.cboLoaiNV = new Sunny.UI.UIComboBox();
            this.txtNgayVaoLam = new Sunny.UI.UIDatePicker();
            this.txtNgaySinh = new Sunny.UI.UIDatePicker();
            this.txtTenDN = new Sunny.UI.UITextBox();
            this.txtSDT = new Sunny.UI.UITextBox();
            this.txtDiaChi = new Sunny.UI.UITextBox();
            this.txtTenNV = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtMaNV = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel4.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1113, 51);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Danh sách nhân viên";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNhanVien.ColumnHeadersHeight = 32;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien,
            this.ngaySinh,
            this.diaChi,
            this.soDienThoai,
            this.tenDangNhap,
            this.matKhau,
            this.ngayVaoLam,
            this.luongCoBan,
            this.tenLoaiNhanVien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhanVien.GridColor = System.Drawing.Color.White;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RectColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.ScrollBarColor = System.Drawing.Color.White;
            this.dgvNhanVien.ScrollBarRectColor = System.Drawing.Color.Pink;
            this.dgvNhanVien.ScrollBarStyleInherited = false;
            this.dgvNhanVien.SelectedIndex = -1;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1113, 323);
            this.dgvNhanVien.StripeOddColor = System.Drawing.Color.LavenderBlush;
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick_1);
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên ";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 131;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên ";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 136;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaySinh";
            this.ngaySinh.HeaderText = "Ngày sinh ";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.ReadOnly = true;
            this.ngaySinh.Width = 106;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 85;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "soDienThoai";
            this.soDienThoai.HeaderText = "Số điện thoại ";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            this.soDienThoai.Width = 130;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "Tài khoản";
            this.tenDangNhap.MinimumWidth = 6;
            this.tenDangNhap.Name = "tenDangNhap";
            this.tenDangNhap.ReadOnly = true;
            this.tenDangNhap.Width = 102;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật khẩu ";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            this.matKhau.Width = 103;
            // 
            // ngayVaoLam
            // 
            this.ngayVaoLam.DataPropertyName = "ngayVaoLam";
            this.ngayVaoLam.HeaderText = "Ngày vào làm";
            this.ngayVaoLam.MinimumWidth = 6;
            this.ngayVaoLam.Name = "ngayVaoLam";
            this.ngayVaoLam.ReadOnly = true;
            this.ngayVaoLam.Width = 127;
            // 
            // luongCoBan
            // 
            this.luongCoBan.DataPropertyName = "luongCoBan";
            this.luongCoBan.HeaderText = "Lương ";
            this.luongCoBan.MinimumWidth = 6;
            this.luongCoBan.Name = "luongCoBan";
            this.luongCoBan.ReadOnly = true;
            this.luongCoBan.Width = 82;
            // 
            // tenLoaiNhanVien
            // 
            this.tenLoaiNhanVien.DataPropertyName = "tenLoaiNhanVien";
            this.tenLoaiNhanVien.HeaderText = "Chức vụ ";
            this.tenLoaiNhanVien.MinimumWidth = 6;
            this.tenLoaiNhanVien.Name = "tenLoaiNhanVien";
            this.tenLoaiNhanVien.ReadOnly = true;
            this.tenLoaiNhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tenLoaiNhanVien.Width = 94;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Controls.Add(this.uiPanel4);
            this.uiPanel1.Controls.Add(this.uiPanel3);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Pink;
            this.uiPanel1.Size = new System.Drawing.Size(1113, 435);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel4
            // 
            this.uiPanel4.Controls.Add(this.dgvNhanVien);
            this.uiPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel4.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(0, 112);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel4.Size = new System.Drawing.Size(1113, 323);
            this.uiPanel4.TabIndex = 22;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.uiSymbolButton6);
            this.uiPanel3.Controls.Add(this.btnSearch);
            this.uiPanel3.Controls.Add(this.txtSearch);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(0, 51);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel3.Size = new System.Drawing.Size(1113, 61);
            this.uiPanel3.TabIndex = 21;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.FillColor = System.Drawing.Color.HotPink;
            this.uiSymbolButton6.FillColor2 = System.Drawing.Color.Fuchsia;
            this.uiSymbolButton6.FillHoverColor = System.Drawing.Color.LightPink;
            this.uiSymbolButton6.FillPressColor = System.Drawing.Color.DeepPink;
            this.uiSymbolButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton6.Location = new System.Drawing.Point(5, 10);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.Radius = 1;
            this.uiSymbolButton6.RectColor = System.Drawing.Color.LightPink;
            this.uiSymbolButton6.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.uiSymbolButton6.Size = new System.Drawing.Size(158, 42);
            this.uiSymbolButton6.Symbol = 557921;
            this.uiSymbolButton6.TabIndex = 20;
            this.uiSymbolButton6.Text = "Loại nhân viên ";
            this.uiSymbolButton6.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton6.Click += new System.EventHandler(this.uiSymbolButton6_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.HotPink;
            this.btnSearch.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnSearch.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnSearch.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(1044, 10);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.LightPink;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Size = new System.Drawing.Size(57, 35);
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(629, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.Radius = 30;
            this.txtSearch.RectColor = System.Drawing.Color.HotPink;
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(408, 35);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "Nhập tên, địa chỉ, hoặc số điện thoại để tìm kiếm";
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiTableLayoutPanel2);
            this.uiPanel2.Controls.Add(this.btnOpen);
            this.uiPanel2.Controls.Add(this.uiLabel12);
            this.uiPanel2.Controls.Add(this.txtLuong);
            this.uiPanel2.Controls.Add(this.uiLabel11);
            this.uiPanel2.Controls.Add(this.txtMatKhau);
            this.uiPanel2.Controls.Add(this.cboLoaiNV);
            this.uiPanel2.Controls.Add(this.txtNgayVaoLam);
            this.uiPanel2.Controls.Add(this.txtNgaySinh);
            this.uiPanel2.Controls.Add(this.txtTenDN);
            this.uiPanel2.Controls.Add(this.txtSDT);
            this.uiPanel2.Controls.Add(this.txtDiaChi);
            this.uiPanel2.Controls.Add(this.txtTenNV);
            this.uiPanel2.Controls.Add(this.uiLabel9);
            this.uiPanel2.Controls.Add(this.txtMaNV);
            this.uiPanel2.Controls.Add(this.uiLabel8);
            this.uiPanel2.Controls.Add(this.uiLabel7);
            this.uiPanel2.Controls.Add(this.uiLabel10);
            this.uiPanel2.Controls.Add(this.uiLabel6);
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.Controls.Add(this.uiLabel5);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 435);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.DeepPink;
            this.uiPanel2.Size = new System.Drawing.Size(1113, 205);
            this.uiPanel2.TabIndex = 14;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 4;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.uiTableLayoutPanel2.Controls.Add(this.btnLamMoi, 3, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.btnXoa, 2, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.btnSua, 1, 0);
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(221, 12);
            this.uiTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(552, 37);
            this.uiTableLayoutPanel2.TabIndex = 19;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FillColor = System.Drawing.Color.HotPink;
            this.btnLamMoi.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnLamMoi.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnLamMoi.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLamMoi.Location = new System.Drawing.Point(416, 2);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.RectColor = System.Drawing.Color.LightPink;
            this.btnLamMoi.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnLamMoi.Size = new System.Drawing.Size(134, 33);
            this.btnLamMoi.Symbol = 61473;
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnXoa.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnXoa.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(278, 2);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RectColor = System.Drawing.Color.LightPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Size = new System.Drawing.Size(134, 33);
            this.btnXoa.Symbol = 262189;
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.HotPink;
            this.btnThem.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnThem.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnThem.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(2, 2);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.RectColor = System.Drawing.Color.LightPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnThem.Size = new System.Drawing.Size(134, 33);
            this.btnThem.Symbol = 61525;
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.HotPink;
            this.btnSua.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnSua.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnSua.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(140, 2);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.RectColor = System.Drawing.Color.LightPink;
            this.btnSua.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSua.Size = new System.Drawing.Size(134, 33);
            this.btnSua.Symbol = 61508;
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FillColor = System.Drawing.Color.Transparent;
            this.btnOpen.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnOpen.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnOpen.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeSelectedColor = System.Drawing.Color.Transparent;
            this.btnOpen.Location = new System.Drawing.Point(992, 223);
            this.btnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Radius = 1;
            this.btnOpen.RectColor = System.Drawing.Color.Transparent;
            this.btnOpen.RectHoverColor = System.Drawing.Color.Transparent;
            this.btnOpen.RectPressColor = System.Drawing.Color.White;
            this.btnOpen.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnOpen.Size = new System.Drawing.Size(69, 31);
            this.btnOpen.Symbol = 61508;
            this.btnOpen.SymbolColor = System.Drawing.Color.DeepPink;
            this.btnOpen.SymbolHoverColor = System.Drawing.Color.DeepPink;
            this.btnOpen.SymbolSelectedColor = System.Drawing.Color.DeepPink;
            this.btnOpen.SymbolSize = 30;
            this.btnOpen.TabIndex = 21;
            this.btnOpen.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOpen.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(549, 143);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(144, 31);
            this.uiLabel12.TabIndex = 16;
            this.uiLabel12.Text = "Lương cơ bản:";
            // 
            // txtLuong
            // 
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(700, 145);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuong.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Padding = new System.Windows.Forms.Padding(5);
            this.txtLuong.Radius = 10;
            this.txtLuong.RectColor = System.Drawing.Color.HotPink;
            this.txtLuong.ShowText = false;
            this.txtLuong.Size = new System.Drawing.Size(285, 29);
            this.txtLuong.TabIndex = 15;
            this.txtLuong.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLuong.Watermark = "";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel11.Location = new System.Drawing.Point(549, 223);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(102, 31);
            this.uiLabel11.TabIndex = 15;
            this.uiLabel11.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(700, 223);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(5);
            this.txtMatKhau.Radius = 10;
            this.txtMatKhau.RectColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.ShowText = false;
            this.txtMatKhau.Size = new System.Drawing.Size(285, 29);
            this.txtMatKhau.TabIndex = 14;
            this.txtMatKhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMatKhau.Watermark = "";
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboLoaiNV.DataSource = null;
            this.cboLoaiNV.FillColor = System.Drawing.Color.White;
            this.cboLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiNV.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboLoaiNV.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboLoaiNV.Location = new System.Drawing.Point(700, 106);
            this.cboLoaiNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboLoaiNV.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboLoaiNV.Radius = 10;
            this.cboLoaiNV.RectColor = System.Drawing.Color.HotPink;
            this.cboLoaiNV.Size = new System.Drawing.Size(285, 29);
            this.cboLoaiNV.SymbolSize = 24;
            this.cboLoaiNV.TabIndex = 13;
            this.cboLoaiNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboLoaiNV.Watermark = "";
            // 
            // txtNgayVaoLam
            // 
            this.txtNgayVaoLam.DateFormat = "dd-MM-yyyy";
            this.txtNgayVaoLam.FillColor = System.Drawing.Color.White;
            this.txtNgayVaoLam.FillColor2 = System.Drawing.Color.HotPink;
            this.txtNgayVaoLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayVaoLam.Location = new System.Drawing.Point(700, 67);
            this.txtNgayVaoLam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgayVaoLam.MaxLength = 10;
            this.txtNgayVaoLam.MinimumSize = new System.Drawing.Size(63, 0);
            this.txtNgayVaoLam.Name = "txtNgayVaoLam";
            this.txtNgayVaoLam.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txtNgayVaoLam.RectColor = System.Drawing.Color.HotPink;
            this.txtNgayVaoLam.Size = new System.Drawing.Size(285, 29);
            this.txtNgayVaoLam.SymbolDropDown = 61555;
            this.txtNgayVaoLam.SymbolNormal = 61555;
            this.txtNgayVaoLam.SymbolSize = 24;
            this.txtNgayVaoLam.TabIndex = 12;
            this.txtNgayVaoLam.Text = "29-10-2024";
            this.txtNgayVaoLam.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNgayVaoLam.Value = new System.DateTime(2024, 10, 29, 0, 0, 0, 0);
            this.txtNgayVaoLam.Watermark = "";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.DateFormat = "dd-MM-yyyy";
            this.txtNgaySinh.FillColor = System.Drawing.Color.White;
            this.txtNgaySinh.FillColor2 = System.Drawing.Color.HotPink;
            this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaySinh.Location = new System.Drawing.Point(221, 223);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaySinh.MaxLength = 10;
            this.txtNgaySinh.MinimumSize = new System.Drawing.Size(63, 0);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.txtNgaySinh.Radius = 10;
            this.txtNgaySinh.RectColor = System.Drawing.Color.HotPink;
            this.txtNgaySinh.Size = new System.Drawing.Size(285, 29);
            this.txtNgaySinh.SymbolDropDown = 61555;
            this.txtNgaySinh.SymbolNormal = 61555;
            this.txtNgaySinh.SymbolSize = 24;
            this.txtNgaySinh.TabIndex = 12;
            this.txtNgaySinh.Text = "29-10-2024";
            this.txtNgaySinh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtNgaySinh.Value = new System.DateTime(2024, 10, 29, 0, 0, 0, 0);
            this.txtNgaySinh.Watermark = "";
            this.txtNgaySinh.ValueChanged += new Sunny.UI.UIDatePicker.OnDateTimeChanged(this.txtNgaySinh_ValueChanged);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDN.Location = new System.Drawing.Point(700, 184);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDN.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenDN.Radius = 10;
            this.txtTenDN.RectColor = System.Drawing.Color.HotPink;
            this.txtTenDN.ShowText = false;
            this.txtTenDN.Size = new System.Drawing.Size(285, 29);
            this.txtTenDN.TabIndex = 9;
            this.txtTenDN.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenDN.Watermark = "";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(221, 184);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5);
            this.txtSDT.Radius = 10;
            this.txtSDT.RectColor = System.Drawing.Color.HotPink;
            this.txtSDT.ShowText = false;
            this.txtSDT.Size = new System.Drawing.Size(285, 29);
            this.txtSDT.TabIndex = 9;
            this.txtSDT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSDT.Watermark = "";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(221, 145);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Radius = 10;
            this.txtDiaChi.RectColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.ShowText = false;
            this.txtDiaChi.Size = new System.Drawing.Size(285, 29);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDiaChi.Watermark = "";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNV.Location = new System.Drawing.Point(221, 106);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNV.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenNV.Radius = 10;
            this.txtTenNV.RectColor = System.Drawing.Color.HotPink;
            this.txtTenNV.ShowText = false;
            this.txtTenNV.Size = new System.Drawing.Size(285, 29);
            this.txtTenNV.TabIndex = 10;
            this.txtTenNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenNV.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(549, 184);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(184, 31);
            this.uiLabel9.TabIndex = 4;
            this.uiLabel9.Text = "Tên đăng nhập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNV.Location = new System.Drawing.Point(221, 67);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaNV.Radius = 10;
            this.txtMaNV.RectColor = System.Drawing.Color.HotPink;
            this.txtMaNV.ShowText = false;
            this.txtMaNV.Size = new System.Drawing.Size(285, 29);
            this.txtMaNV.TabIndex = 11;
            this.txtMaNV.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaNV.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(30, 184);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(184, 31);
            this.uiLabel8.TabIndex = 4;
            this.uiLabel8.Text = "Số điện thoại:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(30, 146);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(184, 31);
            this.uiLabel7.TabIndex = 4;
            this.uiLabel7.Text = "Địa chỉ:";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(549, 106);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(184, 31);
            this.uiLabel10.TabIndex = 5;
            this.uiLabel10.Text = "Chức vụ:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(549, 67);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(137, 31);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Ngày vào làm:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(30, 104);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(184, 31);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Tên nhân viên:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(30, 221);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(144, 31);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "Ngày sinh:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(30, 67);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(184, 31);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Mã nhân viên:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1113, 640);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.Click += new System.EventHandler(this.btnLamMoi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel4.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvNhanVien;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox txtTenDN;
        private Sunny.UI.UITextBox txtSDT;
        private Sunny.UI.UITextBox txtDiaChi;
        private Sunny.UI.UITextBox txtTenNV;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtMaNV;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDatePicker txtNgaySinh;
        private Sunny.UI.UIDatePicker txtNgayVaoLam;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIComboBox cboLoaiNV;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txtMatKhau;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox txtLuong;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiNhanVien;
        private Sunny.UI.UISymbolButton btnOpen;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UISymbolButton btnLamMoi;
        private Sunny.UI.UISymbolButton btnXoa;
        private Sunny.UI.UISymbolButton btnSua;
        private Sunny.UI.UISymbolButton btnThem;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel4;
    }
}