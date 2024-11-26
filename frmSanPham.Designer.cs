namespace MeVaBeProject
{
    partial class frmSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvProducts = new Sunny.UI.UIDataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhSP = new System.Windows.Forms.DataGridViewImageColumn();
            this.donGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cbLocTheoLoai = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtTimKiem = new Sunny.UI.UITextBox();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.cbTrangThai = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.btnLoaiSanPham = new Sunny.UI.UISymbolButton();
            this.btnHuyBo = new Sunny.UI.UIButton();
            this.btnSua = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.btnThem = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.btnKhoiPhuc = new Sunny.UI.UIButton();
            this.dtHanSuDung = new System.Windows.Forms.DateTimePicker();
            this.dtNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.btnChonAnh = new Sunny.UI.UIButton();
            this.cbLoaiSP = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.hinhAnh = new System.Windows.Forms.PictureBox();
            this.txtDonGiaBan = new Sunny.UI.UITextBox();
            this.txtTenSanPham = new Sunny.UI.UITextBox();
            this.txtMaSanPham = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnKhuyenMai = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1424, 51);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Danh sách sản phẩm";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle58;
            this.dgvProducts.ColumnHeadersHeight = 32;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.maLoaiSanPham,
            this.tenLoaiSanPham,
            this.hinhAnhSP,
            this.donGiaBan,
            this.donGiaSale,
            this.soLuong,
            this.ngaySanXuat,
            this.hanSuDung,
            this.trangThai});
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvProducts.GridColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(0, 166);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle64.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.ScrollBarColor = System.Drawing.Color.White;
            this.dgvProducts.ScrollBarRectColor = System.Drawing.Color.Pink;
            this.dgvProducts.ScrollBarStyleInherited = false;
            this.dgvProducts.SelectedIndex = -1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1068, 269);
            this.dgvProducts.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // maSanPham
            // 
            this.maSanPham.DataPropertyName = "maSanPham";
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.ReadOnly = true;
            this.maSanPham.Width = 129;
            // 
            // tenSanPham
            // 
            this.tenSanPham.DataPropertyName = "tenSanPham";
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.ReadOnly = true;
            this.tenSanPham.Width = 134;
            // 
            // maLoaiSanPham
            // 
            this.maLoaiSanPham.DataPropertyName = "maLoaiSanPham";
            this.maLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            this.maLoaiSanPham.Name = "maLoaiSanPham";
            this.maLoaiSanPham.ReadOnly = true;
            this.maLoaiSanPham.Visible = false;
            this.maLoaiSanPham.Width = 157;
            // 
            // tenLoaiSanPham
            // 
            this.tenLoaiSanPham.DataPropertyName = "tenLoaiSanPham";
            this.tenLoaiSanPham.HeaderText = "Tên loại sản phẩm";
            this.tenLoaiSanPham.Name = "tenLoaiSanPham";
            this.tenLoaiSanPham.ReadOnly = true;
            this.tenLoaiSanPham.Width = 162;
            // 
            // hinhAnhSP
            // 
            this.hinhAnhSP.HeaderText = "Hình ảnh";
            this.hinhAnhSP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.hinhAnhSP.Name = "hinhAnhSP";
            this.hinhAnhSP.ReadOnly = true;
            this.hinhAnhSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hinhAnhSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hinhAnhSP.Width = 97;
            // 
            // donGiaBan
            // 
            this.donGiaBan.DataPropertyName = "donGiaBan";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle59.Format = "C0";
            this.donGiaBan.DefaultCellStyle = dataGridViewCellStyle59;
            this.donGiaBan.HeaderText = "Đơn giá bán";
            this.donGiaBan.Name = "donGiaBan";
            this.donGiaBan.ReadOnly = true;
            this.donGiaBan.Width = 119;
            // 
            // donGiaSale
            // 
            this.donGiaSale.DataPropertyName = "donGiaSale";
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle60.Format = "C0";
            this.donGiaSale.DefaultCellStyle = dataGridViewCellStyle60;
            this.donGiaSale.HeaderText = "Đơn giá sale";
            this.donGiaSale.Name = "donGiaSale";
            this.donGiaSale.ReadOnly = true;
            this.donGiaSale.Width = 121;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuong.DefaultCellStyle = dataGridViewCellStyle61;
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 96;
            // 
            // ngaySanXuat
            // 
            this.ngaySanXuat.DataPropertyName = "ngaySanXuat";
            this.ngaySanXuat.HeaderText = "Ngày sản xuất";
            this.ngaySanXuat.Name = "ngaySanXuat";
            this.ngaySanXuat.ReadOnly = true;
            this.ngaySanXuat.Width = 133;
            // 
            // hanSuDung
            // 
            this.hanSuDung.DataPropertyName = "hanSuDung";
            this.hanSuDung.HeaderText = "Hạn sử dụng";
            this.hanSuDung.Name = "hanSuDung";
            this.hanSuDung.ReadOnly = true;
            this.hanSuDung.Width = 124;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            this.trangThai.Width = 104;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Controls.Add(this.uiGroupBox1);
            this.uiPanel1.Controls.Add(this.btnLoaiSanPham);
            this.uiPanel1.Controls.Add(this.dgvProducts);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1068, 435);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox1.Controls.Add(this.cbLocTheoLoai);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.txtTimKiem);
            this.uiGroupBox1.Controls.Add(this.btnSearch);
            this.uiGroupBox1.Controls.Add(this.cbTrangThai);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(357, 56);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox1.Size = new System.Drawing.Size(707, 110);
            this.uiGroupBox1.TabIndex = 23;
            this.uiGroupBox1.Text = "Tìm kiếm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbLocTheoLoai
            // 
            this.cbLocTheoLoai.DataSource = null;
            this.cbLocTheoLoai.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbLocTheoLoai.FillColor = System.Drawing.Color.White;
            this.cbLocTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLocTheoLoai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbLocTheoLoai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbLocTheoLoai.Location = new System.Drawing.Point(173, 68);
            this.cbLocTheoLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLocTheoLoai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbLocTheoLoai.Name = "cbLocTheoLoai";
            this.cbLocTheoLoai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbLocTheoLoai.RectColor = System.Drawing.Color.HotPink;
            this.cbLocTheoLoai.Size = new System.Drawing.Size(184, 29);
            this.cbLocTheoLoai.SymbolSize = 24;
            this.cbLocTheoLoai.TabIndex = 24;
            this.cbLocTheoLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbLocTheoLoai.Watermark = "";
            this.cbLocTheoLoai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(21, 68);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(119, 31);
            this.uiLabel9.TabIndex = 23;
            this.uiLabel9.Text = "Loại sản phẩm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(378, 29);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Radius = 29;
            this.txtTimKiem.RectColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.ShowText = false;
            this.txtTimKiem.Size = new System.Drawing.Size(285, 29);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm để tìm kiếm";
            this.txtTimKiem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTimKiem.Watermark = "";
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.HotPink;
            this.btnSearch.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnSearch.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnSearch.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(670, 29);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.LightPink;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 22;
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DataSource = null;
            this.cbTrangThai.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbTrangThai.FillColor = System.Drawing.Color.White;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbTrangThai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng",
            "Không tồn tại"});
            this.cbTrangThai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Location = new System.Drawing.Point(173, 29);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTrangThai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbTrangThai.RectColor = System.Drawing.Color.HotPink;
            this.cbTrangThai.Size = new System.Drawing.Size(184, 29);
            this.cbTrangThai.SymbolSize = 24;
            this.cbTrangThai.TabIndex = 16;
            this.cbTrangThai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbTrangThai.Watermark = "";
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // uiLabel7
            // 
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(48, 29);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(92, 31);
            this.uiLabel7.TabIndex = 19;
            this.uiLabel7.Text = "Trạng thái:";
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoaiSanPham.FillColor = System.Drawing.Color.HotPink;
            this.btnLoaiSanPham.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnLoaiSanPham.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnLoaiSanPham.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoaiSanPham.Location = new System.Drawing.Point(12, 60);
            this.btnLoaiSanPham.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.RectColor = System.Drawing.Color.LightPink;
            this.btnLoaiSanPham.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnLoaiSanPham.Size = new System.Drawing.Size(148, 42);
            this.btnLoaiSanPham.Symbol = 557921;
            this.btnLoaiSanPham.TabIndex = 21;
            this.btnLoaiSanPham.Text = "Loại sản phẩm ";
            this.btnLoaiSanPham.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoaiSanPham.Click += new System.EventHandler(this.btnLoaiSanPham_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.Enabled = false;
            this.btnHuyBo.FillColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillHoverColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.Location = new System.Drawing.Point(893, 241);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RectColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectDisableColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectHoverColor = System.Drawing.Color.Gray;
            this.btnHuyBo.RectPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Size = new System.Drawing.Size(149, 39);
            this.btnHuyBo.TabIndex = 12;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.HotPink;
            this.btnSua.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnSua.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(331, 241);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.RectColor = System.Drawing.Color.HotPink;
            this.btnSua.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnSua.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Size = new System.Drawing.Size(149, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(520, 241);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RectColor = System.Drawing.Color.HotPink;
            this.btnXoa.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnXoa.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Size = new System.Drawing.Size(149, 39);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.HotPink;
            this.btnThem.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnThem.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(140, 241);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.RectColor = System.Drawing.Color.HotPink;
            this.btnThem.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnThem.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnThem.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Size = new System.Drawing.Size(149, 39);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.btnKhoiPhuc);
            this.uiPanel2.Controls.Add(this.btnHuyBo);
            this.uiPanel2.Controls.Add(this.dtHanSuDung);
            this.uiPanel2.Controls.Add(this.btnXoa);
            this.uiPanel2.Controls.Add(this.btnSua);
            this.uiPanel2.Controls.Add(this.dtNgaySanXuat);
            this.uiPanel2.Controls.Add(this.btnChonAnh);
            this.uiPanel2.Controls.Add(this.btnThem);
            this.uiPanel2.Controls.Add(this.cbLoaiSP);
            this.uiPanel2.Controls.Add(this.uiLabel4);
            this.uiPanel2.Controls.Add(this.hinhAnh);
            this.uiPanel2.Controls.Add(this.txtDonGiaBan);
            this.uiPanel2.Controls.Add(this.txtTenSanPham);
            this.uiPanel2.Controls.Add(this.txtMaSanPham);
            this.uiPanel2.Controls.Add(this.uiLabel8);
            this.uiPanel2.Controls.Add(this.uiLabel10);
            this.uiPanel2.Controls.Add(this.uiLabel6);
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.Controls.Add(this.uiLabel5);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 436);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.DeepPink;
            this.uiPanel2.Size = new System.Drawing.Size(1068, 284);
            this.uiPanel2.TabIndex = 14;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhoiPhuc.FillColor = System.Drawing.Color.HotPink;
            this.btnKhoiPhuc.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnKhoiPhuc.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(711, 241);
            this.btnKhoiPhuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnKhoiPhuc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.RectColor = System.Drawing.Color.HotPink;
            this.btnKhoiPhuc.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnKhoiPhuc.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnKhoiPhuc.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnKhoiPhuc.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKhoiPhuc.Size = new System.Drawing.Size(112, 32);
            this.btnKhoiPhuc.TabIndex = 15;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // dtHanSuDung
            // 
            this.dtHanSuDung.CustomFormat = "dd-MM-yyyy";
            this.dtHanSuDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtHanSuDung.Location = new System.Drawing.Point(848, 22);
            this.dtHanSuDung.Name = "dtHanSuDung";
            this.dtHanSuDung.Size = new System.Drawing.Size(113, 26);
            this.dtHanSuDung.TabIndex = 18;
            // 
            // dtNgaySanXuat
            // 
            this.dtNgaySanXuat.CustomFormat = "dd-MM-yyyy";
            this.dtNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySanXuat.Location = new System.Drawing.Point(601, 22);
            this.dtNgaySanXuat.Name = "dtNgaySanXuat";
            this.dtNgaySanXuat.Size = new System.Drawing.Size(113, 26);
            this.dtNgaySanXuat.TabIndex = 17;
            this.dtNgaySanXuat.ValueChanged += new System.EventHandler(this.dtNgaySanXuat_ValueChanged);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.FillColor = System.Drawing.Color.HotPink;
            this.btnChonAnh.FillColor2 = System.Drawing.Color.HotPink;
            this.btnChonAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChonAnh.Location = new System.Drawing.Point(767, 63);
            this.btnChonAnh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.RectColor = System.Drawing.Color.HotPink;
            this.btnChonAnh.RectDisableColor = System.Drawing.Color.DarkGray;
            this.btnChonAnh.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnChonAnh.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnChonAnh.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChonAnh.Size = new System.Drawing.Size(90, 27);
            this.btnChonAnh.TabIndex = 16;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.DataSource = null;
            this.cbLoaiSP.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbLoaiSP.FillColor = System.Drawing.Color.White;
            this.cbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLoaiSP.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbLoaiSP.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbLoaiSP.Location = new System.Drawing.Point(182, 134);
            this.cbLoaiSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiSP.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbLoaiSP.RectColor = System.Drawing.Color.HotPink;
            this.cbLoaiSP.Size = new System.Drawing.Size(285, 29);
            this.cbLoaiSP.SymbolSize = 24;
            this.cbLoaiSP.TabIndex = 15;
            this.cbLoaiSP.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbLoaiSP.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(30, 134);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(184, 31);
            this.uiLabel4.TabIndex = 14;
            this.uiLabel4.Text = "Loại sản phẩm:";
            // 
            // hinhAnh
            // 
            this.hinhAnh.Location = new System.Drawing.Point(573, 63);
            this.hinhAnh.Name = "hinhAnh";
            this.hinhAnh.Size = new System.Drawing.Size(171, 152);
            this.hinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhAnh.TabIndex = 13;
            this.hinhAnh.TabStop = false;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGiaBan.Location = new System.Drawing.Point(182, 186);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDonGiaBan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Padding = new System.Windows.Forms.Padding(5);
            this.txtDonGiaBan.Radius = 1;
            this.txtDonGiaBan.RectColor = System.Drawing.Color.HotPink;
            this.txtDonGiaBan.ShowText = false;
            this.txtDonGiaBan.Size = new System.Drawing.Size(285, 29);
            this.txtDonGiaBan.TabIndex = 9;
            this.txtDonGiaBan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDonGiaBan.Watermark = "";
            this.txtDonGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGiaBan_KeyPress);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSanPham.Location = new System.Drawing.Point(182, 80);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSanPham.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenSanPham.Radius = 1;
            this.txtTenSanPham.RectColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.ShowText = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(285, 29);
            this.txtTenSanPham.TabIndex = 10;
            this.txtTenSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenSanPham.Watermark = "";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSanPham.Enabled = false;
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(182, 29);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSanPham.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaSanPham.Radius = 1;
            this.txtMaSanPham.RectColor = System.Drawing.Color.HotPink;
            this.txtMaSanPham.ShowText = false;
            this.txtMaSanPham.Size = new System.Drawing.Size(285, 29);
            this.txtMaSanPham.TabIndex = 11;
            this.txtMaSanPham.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaSanPham.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(30, 186);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(184, 31);
            this.uiLabel8.TabIndex = 4;
            this.uiLabel8.Text = "Đơn giá bán:";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(485, 63);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(82, 31);
            this.uiLabel10.TabIndex = 6;
            this.uiLabel10.Text = "Hình ảnh:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(732, 27);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(110, 31);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Hạn sử dụng:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(30, 80);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(184, 31);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Tên sản phẩm:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(485, 27);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(124, 31);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "Ngày sản xuất:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(30, 27);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(184, 31);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Mã sản phẩm:";
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhuyenMai.Location = new System.Drawing.Point(501, 67);
            this.btnKhuyenMai.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(177, 35);
            this.btnKhuyenMai.TabIndex = 13;
            this.btnKhuyenMai.Text = "Xem khuyến mãi";
            this.btnKhuyenMai.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1424, 886);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvProducts;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnHuyBo;
        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox txtDonGiaBan;
        private Sunny.UI.UITextBox txtTenSanPham;
        private Sunny.UI.UITextBox txtMaSanPham;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.PictureBox hinhAnh;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UIComboBox cbLoaiSP;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnChonAnh;
        private Sunny.UI.UISymbolButton btnLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPham;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnhSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.DateTimePicker dtHanSuDung;
        private System.Windows.Forms.DateTimePicker dtNgaySanXuat;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox cbTrangThai;
        private Sunny.UI.UIButton btnKhoiPhuc;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cbLocTheoLoai;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIButton btnKhuyenMai;
    }
}