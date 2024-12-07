namespace MeVaBeProject
{
    partial class frmChonSanPhamDoi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dgvProducts = new Sunny.UI.UIDataGridView();
            this.txtTimKiem = new Sunny.UI.UITextBox();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.cbLocTheoLoai = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            this.uiPanel1.Size = new System.Drawing.Size(800, 39);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "Chọn sản phẩm đổi";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(752, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dgvProducts);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 71);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox1.Size = new System.Drawing.Size(800, 340);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.Text = "Danh sách sản phẩm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.cbLocTheoLoai);
            this.uiGroupBox2.Controls.Add(this.uiLabel9);
            this.uiGroupBox2.Controls.Add(this.txtTimKiem);
            this.uiGroupBox2.Controls.Add(this.btnSearch);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox2.Size = new System.Drawing.Size(800, 74);
            this.uiGroupBox2.TabIndex = 2;
            this.uiGroupBox2.Text = "Tìm kiếm";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiGroupBox2);
            this.uiPanel2.Controls.Add(this.uiGroupBox1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(0, 39);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel2.Size = new System.Drawing.Size(800, 411);
            this.uiPanel2.TabIndex = 3;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProducts.ColumnHeadersHeight = 32;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.maLoaiSanPham,
            this.tenLoaiSanPham,
            this.hinhAnh,
            this.LoaiSanPham,
            this.donGiaNhap,
            this.donGiaBan,
            this.donGiaSale,
            this.soLuong,
            this.ngaySanXuat,
            this.hanSuDung,
            this.trangThai});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvProducts.GridColor = System.Drawing.Color.White;
            this.dgvProducts.Location = new System.Drawing.Point(0, 32);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.ScrollBarBackColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.ScrollBarColor = System.Drawing.Color.LightPink;
            this.dgvProducts.ScrollBarRectColor = System.Drawing.Color.Pink;
            this.dgvProducts.ScrollBarStyleInherited = false;
            this.dgvProducts.SelectedIndex = -1;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(800, 308);
            this.dgvProducts.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvProducts.TabIndex = 17;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(467, 32);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(5);
            this.txtTimKiem.Radius = 29;
            this.txtTimKiem.RectColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.ShowText = false;
            this.txtTimKiem.Size = new System.Drawing.Size(285, 29);
            this.txtTimKiem.TabIndex = 23;
            this.txtTimKiem.TabStop = false;
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
            this.btnSearch.Location = new System.Drawing.Point(759, 32);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RectColor = System.Drawing.Color.LightPink;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 24;
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbLocTheoLoai
            // 
            this.cbLocTheoLoai.DataSource = null;
            this.cbLocTheoLoai.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbLocTheoLoai.FillColor = System.Drawing.Color.White;
            this.cbLocTheoLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbLocTheoLoai.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbLocTheoLoai.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbLocTheoLoai.Location = new System.Drawing.Point(138, 32);
            this.cbLocTheoLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLocTheoLoai.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbLocTheoLoai.Name = "cbLocTheoLoai";
            this.cbLocTheoLoai.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbLocTheoLoai.RectColor = System.Drawing.Color.HotPink;
            this.cbLocTheoLoai.Size = new System.Drawing.Size(184, 29);
            this.cbLocTheoLoai.SymbolSize = 24;
            this.cbLocTheoLoai.TabIndex = 26;
            this.cbLocTheoLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbLocTheoLoai.Watermark = "";
            this.cbLocTheoLoai.SelectedIndexChanged += new System.EventHandler(this.cbLocTheoLoai_SelectedIndexChanged);
            // 
            // uiLabel9
            // 
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(12, 32);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(119, 31);
            this.uiLabel9.TabIndex = 25;
            this.uiLabel9.Text = "Loại sản phẩm:";
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
            // hinhAnh
            // 
            this.hinhAnh.DataPropertyName = "hinhAnh";
            this.hinhAnh.HeaderText = "Hình ảnh";
            this.hinhAnh.Name = "hinhAnh";
            this.hinhAnh.ReadOnly = true;
            this.hinhAnh.Visible = false;
            this.hinhAnh.Width = 97;
            // 
            // LoaiSanPham
            // 
            this.LoaiSanPham.DataPropertyName = "LoaiSanPham";
            this.LoaiSanPham.HeaderText = "Loại sản phẩm";
            this.LoaiSanPham.Name = "LoaiSanPham";
            this.LoaiSanPham.ReadOnly = true;
            this.LoaiSanPham.Visible = false;
            this.LoaiSanPham.Width = 137;
            // 
            // donGiaNhap
            // 
            this.donGiaNhap.DataPropertyName = "donGiaNhap";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "C0";
            this.donGiaNhap.DefaultCellStyle = dataGridViewCellStyle12;
            this.donGiaNhap.HeaderText = "Đơn giá nhập";
            this.donGiaNhap.Name = "donGiaNhap";
            this.donGiaNhap.ReadOnly = true;
            this.donGiaNhap.Visible = false;
            this.donGiaNhap.Width = 128;
            // 
            // donGiaBan
            // 
            this.donGiaBan.DataPropertyName = "donGiaBan";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "C0";
            this.donGiaBan.DefaultCellStyle = dataGridViewCellStyle13;
            this.donGiaBan.HeaderText = "Đơn giá bán";
            this.donGiaBan.Name = "donGiaBan";
            this.donGiaBan.ReadOnly = true;
            this.donGiaBan.Width = 119;
            // 
            // donGiaSale
            // 
            this.donGiaSale.DataPropertyName = "donGiaSale";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "C0";
            this.donGiaSale.DefaultCellStyle = dataGridViewCellStyle14;
            this.donGiaSale.HeaderText = "Đơn giá sale";
            this.donGiaSale.Name = "donGiaSale";
            this.donGiaSale.ReadOnly = true;
            this.donGiaSale.Visible = false;
            this.donGiaSale.Width = 121;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.soLuong.DefaultCellStyle = dataGridViewCellStyle15;
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
            this.ngaySanXuat.Visible = false;
            this.ngaySanXuat.Width = 133;
            // 
            // hanSuDung
            // 
            this.hanSuDung.DataPropertyName = "hanSuDung";
            this.hanSuDung.HeaderText = "Hạn sử dụng";
            this.hanSuDung.Name = "hanSuDung";
            this.hanSuDung.ReadOnly = true;
            this.hanSuDung.Visible = false;
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
            // frmChonSanPhamDoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChonSanPhamDoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChonSanPhamDoi";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel btnClose;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIDataGridView dgvProducts;
        private Sunny.UI.UITextBox txtTimKiem;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UIComboBox cbLocTheoLoai;
        private Sunny.UI.UILabel uiLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}