
namespace MeVaBeProject
{
    partial class frmQLDatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.tabControlPhieuDat = new Sunny.UI.UITabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.dtgvDanhSachPhieuDat = new Sunny.UI.UIDataGridView();
            this.maPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.dtgvChiTietPhieuDat = new Sunny.UI.UIDataGridView();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.btnInPhieuDat = new Sunny.UI.UIButton();
            this.btnSuaPhieuDat = new Sunny.UI.UIButton();
            this.btnXoaPhieuDat = new Sunny.UI.UIButton();
            this.btnTaoPhieuDat = new Sunny.UI.UIButton();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dtNgayTaoPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiem = new Sunny.UI.UITextBox();
            this.btnTimKiem = new Sunny.UI.UISymbolButton();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.maPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDuyetPhieuDat = new Sunny.UI.UIButton();
            this.uiPanel2.SuspendLayout();
            this.tabControlPhieuDat.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuDat)).BeginInit();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuDat)).BeginInit();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1113, 43);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "Quản lý phiếu đặt hàng";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.tabControlPhieuDat);
            this.uiPanel2.Controls.Add(this.uiGroupBox4);
            this.uiPanel2.Controls.Add(this.uiGroupBox3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 43);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(1113, 677);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlPhieuDat
            // 
            this.tabControlPhieuDat.Controls.Add(this.tabDanhSach);
            this.tabControlPhieuDat.Controls.Add(this.tabChiTiet);
            this.tabControlPhieuDat.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControlPhieuDat.ItemSize = new System.Drawing.Size(150, 40);
            this.tabControlPhieuDat.Location = new System.Drawing.Point(3, 142);
            this.tabControlPhieuDat.MainPage = "";
            this.tabControlPhieuDat.MenuStyle = Sunny.UI.UIMenuStyle.White;
            this.tabControlPhieuDat.Name = "tabControlPhieuDat";
            this.tabControlPhieuDat.SelectedIndex = 0;
            this.tabControlPhieuDat.Size = new System.Drawing.Size(1113, 532);
            this.tabControlPhieuDat.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlPhieuDat.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabControlPhieuDat.TabIndex = 9;
            this.tabControlPhieuDat.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabControlPhieuDat.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.tabControlPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tabControlPhieuDat.SelectedIndexChanged += new System.EventHandler(this.tabControlPhieuDat_SelectedIndexChanged);
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.dtgvDanhSachPhieuDat);
            this.tabDanhSach.Location = new System.Drawing.Point(0, 40);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(1113, 492);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "Danh sách";
            this.tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // dtgvDanhSachPhieuDat
            // 
            this.dtgvDanhSachPhieuDat.AllowUserToAddRows = false;
            this.dtgvDanhSachPhieuDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachPhieuDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDanhSachPhieuDat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachPhieuDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachPhieuDat.ColumnHeadersHeight = 32;
            this.dtgvDanhSachPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDanhSachPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuDat,
            this.tenNhanVien,
            this.tenNhaCungCap,
            this.ngayLap,
            this.soLuong,
            this.tongTien,
            this.trangThai});
            this.dtgvDanhSachPhieuDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachPhieuDat.EnableHeadersVisualStyles = false;
            this.dtgvDanhSachPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvDanhSachPhieuDat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachPhieuDat.Location = new System.Drawing.Point(0, 0);
            this.dtgvDanhSachPhieuDat.Name = "dtgvDanhSachPhieuDat";
            this.dtgvDanhSachPhieuDat.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachPhieuDat.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvDanhSachPhieuDat.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvDanhSachPhieuDat.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvDanhSachPhieuDat.RowTemplate.Height = 24;
            this.dtgvDanhSachPhieuDat.SelectedIndex = -1;
            this.dtgvDanhSachPhieuDat.Size = new System.Drawing.Size(1113, 492);
            this.dtgvDanhSachPhieuDat.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvDanhSachPhieuDat.TabIndex = 8;
            this.dtgvDanhSachPhieuDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhieuDat_CellClick);
            this.dtgvDanhSachPhieuDat.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachPhieuDat_CellDoubleClick);
            // 
            // maPhieuDat
            // 
            this.maPhieuDat.DataPropertyName = "maPhieuDat";
            this.maPhieuDat.HeaderText = "Mã phiếu đặt";
            this.maPhieuDat.Name = "maPhieuDat";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // tenNhaCungCap
            // 
            this.tenNhaCungCap.DataPropertyName = "tenNhaCungCap";
            this.tenNhaCungCap.HeaderText = "Nhà cung cấp";
            this.tenNhaCungCap.Name = "tenNhaCungCap";
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.Name = "ngayLap";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C0";
            this.tongTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.Name = "tongTien";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.dtgvChiTietPhieuDat);
            this.tabChiTiet.Location = new System.Drawing.Point(0, 40);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Size = new System.Drawing.Size(1113, 492);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi tiết";
            this.tabChiTiet.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietPhieuDat
            // 
            this.dtgvChiTietPhieuDat.AllowUserToAddRows = false;
            this.dtgvChiTietPhieuDat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvChiTietPhieuDat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvChiTietPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietPhieuDat.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietPhieuDat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietPhieuDat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvChiTietPhieuDat.ColumnHeadersHeight = 32;
            this.dtgvChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvChiTietPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPD,
            this.maSanPham,
            this.tenSanPham,
            this.soLuongDat,
            this.soLuongNhan,
            this.donGia,
            this.thanhTien});
            this.dtgvChiTietPhieuDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietPhieuDat.EnableHeadersVisualStyles = false;
            this.dtgvChiTietPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvChiTietPhieuDat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dtgvChiTietPhieuDat.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTietPhieuDat.Name = "dtgvChiTietPhieuDat";
            this.dtgvChiTietPhieuDat.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvChiTietPhieuDat.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvChiTietPhieuDat.RowHeadersWidth = 51;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvChiTietPhieuDat.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvChiTietPhieuDat.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuDat.SelectedIndex = -1;
            this.dtgvChiTietPhieuDat.Size = new System.Drawing.Size(1113, 492);
            this.dtgvChiTietPhieuDat.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvChiTietPhieuDat.TabIndex = 9;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox4.Controls.Add(this.btnDuyetPhieuDat);
            this.uiGroupBox4.Controls.Add(this.btnInPhieuDat);
            this.uiGroupBox4.Controls.Add(this.btnSuaPhieuDat);
            this.uiGroupBox4.Controls.Add(this.btnXoaPhieuDat);
            this.uiGroupBox4.Controls.Add(this.btnTaoPhieuDat);
            this.uiGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox4.Location = new System.Drawing.Point(464, 10);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(645, 124);
            this.uiGroupBox4.TabIndex = 13;
            this.uiGroupBox4.Text = "Thao tác";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInPhieuDat
            // 
            this.btnInPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInPhieuDat.Location = new System.Drawing.Point(386, 34);
            this.btnInPhieuDat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInPhieuDat.Name = "btnInPhieuDat";
            this.btnInPhieuDat.Size = new System.Drawing.Size(118, 36);
            this.btnInPhieuDat.TabIndex = 7;
            this.btnInPhieuDat.Text = "In phiếu đặt";
            this.btnInPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInPhieuDat.Click += new System.EventHandler(this.btnInPhieuDat_Click);
            // 
            // btnSuaPhieuDat
            // 
            this.btnSuaPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSuaPhieuDat.Location = new System.Drawing.Point(138, 35);
            this.btnSuaPhieuDat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSuaPhieuDat.Name = "btnSuaPhieuDat";
            this.btnSuaPhieuDat.Size = new System.Drawing.Size(118, 36);
            this.btnSuaPhieuDat.TabIndex = 6;
            this.btnSuaPhieuDat.Text = "Sửa phiếu đặt";
            this.btnSuaPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSuaPhieuDat.Click += new System.EventHandler(this.btnSuaPhieuDat_Click);
            // 
            // btnXoaPhieuDat
            // 
            this.btnXoaPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoaPhieuDat.Location = new System.Drawing.Point(262, 34);
            this.btnXoaPhieuDat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoaPhieuDat.Name = "btnXoaPhieuDat";
            this.btnXoaPhieuDat.Size = new System.Drawing.Size(118, 36);
            this.btnXoaPhieuDat.TabIndex = 5;
            this.btnXoaPhieuDat.Text = "Xóa phiếu đặt";
            this.btnXoaPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoaPhieuDat.Click += new System.EventHandler(this.btnXoaPhieuDat_Click);
            // 
            // btnTaoPhieuDat
            // 
            this.btnTaoPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTaoPhieuDat.Location = new System.Drawing.Point(14, 35);
            this.btnTaoPhieuDat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTaoPhieuDat.Name = "btnTaoPhieuDat";
            this.btnTaoPhieuDat.Size = new System.Drawing.Size(118, 36);
            this.btnTaoPhieuDat.TabIndex = 4;
            this.btnTaoPhieuDat.Text = "Tạo phiếu đặt";
            this.btnTaoPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTaoPhieuDat.Click += new System.EventHandler(this.btnTaoPhieuDat_Click);
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.uiLabel2);
            this.uiGroupBox3.Controls.Add(this.dtNgayTaoPhieuNhap);
            this.uiGroupBox3.Controls.Add(this.txtTimKiem);
            this.uiGroupBox3.Controls.Add(this.btnTimKiem);
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(4, 10);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(452, 124);
            this.uiGroupBox3.TabIndex = 12;
            this.uiGroupBox3.Text = "Tìm kiếm";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(15, 79);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(161, 23);
            this.uiLabel2.TabIndex = 4;
            this.uiLabel2.Text = "Ngày tạo phiếu đặt";
            // 
            // dtNgayTaoPhieuNhap
            // 
            this.dtNgayTaoPhieuNhap.CustomFormat = "dd-MM-yyyy";
            this.dtNgayTaoPhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTaoPhieuNhap.Location = new System.Drawing.Point(182, 76);
            this.dtNgayTaoPhieuNhap.Name = "dtNgayTaoPhieuNhap";
            this.dtNgayTaoPhieuNhap.Size = new System.Drawing.Size(121, 26);
            this.dtNgayTaoPhieuNhap.TabIndex = 3;
            this.dtNgayTaoPhieuNhap.ValueChanged += new System.EventHandler(this.dtNgayTaoPhieuNhap_ValueChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(19, 35);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.ShowText = false;
            this.txtTimKiem.Size = new System.Drawing.Size(385, 29);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Watermark = "";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiem.Location = new System.Drawing.Point(411, 35);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(29, 29);
            this.btnTimKiem.Symbol = 61442;
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.uiToolTip1.OwnerDraw = true;
            // 
            // maPD
            // 
            this.maPD.DataPropertyName = "maPhieuDat";
            this.maPD.HeaderText = "Mã phiếu đặt";
            this.maPD.Name = "maPD";
            // 
            // maSanPham
            // 
            this.maSanPham.DataPropertyName = "maSanPham";
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.Name = "maSanPham";
            // 
            // tenSanPham
            // 
            this.tenSanPham.DataPropertyName = "tenSanPham";
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.Name = "tenSanPham";
            // 
            // soLuongDat
            // 
            this.soLuongDat.DataPropertyName = "soLuongDat";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuongDat.DefaultCellStyle = dataGridViewCellStyle9;
            this.soLuongDat.HeaderText = "Số lượng đặt";
            this.soLuongDat.Name = "soLuongDat";
            // 
            // soLuongNhan
            // 
            this.soLuongNhan.DataPropertyName = "soLuongNhan";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuongNhan.DefaultCellStyle = dataGridViewCellStyle10;
            this.soLuongNhan.HeaderText = "Số lượng nhận";
            this.soLuongNhan.Name = "soLuongNhan";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C0";
            this.donGia.DefaultCellStyle = dataGridViewCellStyle11;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "tongTien";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C0";
            this.thanhTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            // 
            // btnDuyetPhieuDat
            // 
            this.btnDuyetPhieuDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyetPhieuDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDuyetPhieuDat.Location = new System.Drawing.Point(510, 35);
            this.btnDuyetPhieuDat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDuyetPhieuDat.Name = "btnDuyetPhieuDat";
            this.btnDuyetPhieuDat.Size = new System.Drawing.Size(118, 36);
            this.btnDuyetPhieuDat.TabIndex = 8;
            this.btnDuyetPhieuDat.Text = "Duyệt phiếu đặt";
            this.btnDuyetPhieuDat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnDuyetPhieuDat.Click += new System.EventHandler(this.btnDuyetPhieuDat_Click);
            // 
            // frmQLDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 720);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLDatHang";
            this.Text = "frmQLDatHang";
            this.Load += new System.EventHandler(this.frmQLDatHang_Load);
            this.uiPanel2.ResumeLayout(false);
            this.tabControlPhieuDat.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuDat)).EndInit();
            this.tabChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuDat)).EndInit();
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DateTimePicker dtNgayTaoPhieuNhap;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UISymbolButton btnTimKiem;
        private Sunny.UI.UIDataGridView dtgvDanhSachPhieuDat;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UIButton btnInPhieuDat;
        private Sunny.UI.UIButton btnSuaPhieuDat;
        private Sunny.UI.UIButton btnXoaPhieuDat;
        private Sunny.UI.UIButton btnTaoPhieuDat;
        private Sunny.UI.UITabControl tabControlPhieuDat;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabChiTiet;
        private Sunny.UI.UIDataGridView dtgvChiTietPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private Sunny.UI.UIButton btnDuyetPhieuDat;
    }
}