namespace MeVaBeProject
{
    partial class frmQLLoaiSanPham
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnClose = new Sunny.UI.UILabel();
            this.dtgvLoaiSanPham = new Sunny.UI.UIDataGridView();
            this.maLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.txtTenLoai = new Sunny.UI.UITextBox();
            this.txtMaLoai = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnThem = new Sunny.UI.UISymbolButton();
            this.btnSua = new Sunny.UI.UISymbolButton();
            this.btnXoa = new Sunny.UI.UISymbolButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.btnHuyBo = new Sunny.UI.UIButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSanPham)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Controls.Add(this.btnClose);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel1.Size = new System.Drawing.Size(800, 43);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnClose.Location = new System.Drawing.Point(761, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgvLoaiSanPham
            // 
            this.dtgvLoaiSanPham.AllowUserToAddRows = false;
            this.dtgvLoaiSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvLoaiSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvLoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoaiSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLoaiSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoaiSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvLoaiSanPham.ColumnHeadersHeight = 32;
            this.dtgvLoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvLoaiSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiSanPham,
            this.tenLoaiSanPham});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLoaiSanPham.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvLoaiSanPham.EnableHeadersVisualStyles = false;
            this.dtgvLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgvLoaiSanPham.GridColor = System.Drawing.Color.White;
            this.dtgvLoaiSanPham.Location = new System.Drawing.Point(0, 32);
            this.dtgvLoaiSanPham.Name = "dtgvLoaiSanPham";
            this.dtgvLoaiSanPham.ReadOnly = true;
            this.dtgvLoaiSanPham.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoaiSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtgvLoaiSanPham.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvLoaiSanPham.ScrollBarColor = System.Drawing.Color.HotPink;
            this.dtgvLoaiSanPham.ScrollBarRectColor = System.Drawing.Color.HotPink;
            this.dtgvLoaiSanPham.ScrollBarStyleInherited = false;
            this.dtgvLoaiSanPham.SelectedIndex = -1;
            this.dtgvLoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaiSanPham.Size = new System.Drawing.Size(390, 375);
            this.dtgvLoaiSanPham.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dtgvLoaiSanPham.TabIndex = 1;
            this.dtgvLoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSanPham_CellClick);
            // 
            // maLoaiSanPham
            // 
            this.maLoaiSanPham.DataPropertyName = "maLoaiSanPham";
            this.maLoaiSanPham.HeaderText = "Mã loại sản phẩm";
            this.maLoaiSanPham.Name = "maLoaiSanPham";
            this.maLoaiSanPham.ReadOnly = true;
            // 
            // tenLoaiSanPham
            // 
            this.tenLoaiSanPham.DataPropertyName = "tenLoaiSanPham";
            this.tenLoaiSanPham.HeaderText = "Tên loại sản phẩm";
            this.tenLoaiSanPham.Name = "tenLoaiSanPham";
            this.tenLoaiSanPham.ReadOnly = true;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.dtgvLoaiSanPham);
            this.uiGroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiGroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox1.Location = new System.Drawing.Point(0, 43);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox1.Size = new System.Drawing.Size(390, 407);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Loại sản phẩm";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.txtTenLoai);
            this.uiGroupBox2.Controls.Add(this.txtMaLoai);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiGroupBox2.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox2.Size = new System.Drawing.Size(411, 183);
            this.uiGroupBox2.TabIndex = 3;
            this.uiGroupBox2.Text = "Thông tin";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenLoai.Location = new System.Drawing.Point(158, 126);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoai.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenLoai.RectColor = System.Drawing.Color.HotPink;
            this.txtTenLoai.ShowText = false;
            this.txtTenLoai.Size = new System.Drawing.Size(241, 29);
            this.txtTenLoai.TabIndex = 3;
            this.txtTenLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenLoai.Watermark = "";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaLoai.Location = new System.Drawing.Point(158, 62);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoai.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaLoai.RectColor = System.Drawing.Color.HotPink;
            this.txtMaLoai.ShowText = false;
            this.txtMaLoai.Size = new System.Drawing.Size(241, 29);
            this.txtMaLoai.TabIndex = 2;
            this.txtMaLoai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaLoai.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(9, 132);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(142, 23);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Tên loại sản phẩm:";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(9, 68);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(142, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Mã loại sản phẩm:";
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.HotPink;
            this.btnThem.FillColor2 = System.Drawing.Color.HotPink;
            this.btnThem.FillHoverColor = System.Drawing.Color.DeepPink;
            this.btnThem.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.FillSelectedColor = System.Drawing.Color.Pink;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThem.Location = new System.Drawing.Point(45, 45);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.RectColor = System.Drawing.Color.HotPink;
            this.btnThem.RectHoverColor = System.Drawing.Color.HotPink;
            this.btnThem.RectPressColor = System.Drawing.Color.HotPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.HotPink;
            this.btnThem.Size = new System.Drawing.Size(119, 39);
            this.btnThem.Symbol = 61525;
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.HotPink;
            this.btnSua.FillColor2 = System.Drawing.Color.HotPink;
            this.btnSua.FillHoverColor = System.Drawing.Color.DeepPink;
            this.btnSua.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.FillSelectedColor = System.Drawing.Color.HotPink;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSua.Location = new System.Drawing.Point(244, 45);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.RectColor = System.Drawing.Color.HotPink;
            this.btnSua.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnSua.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Size = new System.Drawing.Size(119, 39);
            this.btnSua.Symbol = 61508;
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillColor2 = System.Drawing.Color.HotPink;
            this.btnXoa.FillHoverColor = System.Drawing.Color.DeepPink;
            this.btnXoa.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.FillSelectedColor = System.Drawing.Color.HotPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoa.Location = new System.Drawing.Point(45, 117);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RectColor = System.Drawing.Color.HotPink;
            this.btnXoa.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnXoa.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Size = new System.Drawing.Size(119, 39);
            this.btnXoa.Symbol = 62163;
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiGroupBox3);
            this.uiPanel2.Controls.Add(this.uiGroupBox2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel2.Location = new System.Drawing.Point(389, 43);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel2.Size = new System.Drawing.Size(411, 407);
            this.uiPanel2.TabIndex = 4;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.btnHuyBo);
            this.uiGroupBox3.Controls.Add(this.btnSua);
            this.uiGroupBox3.Controls.Add(this.btnThem);
            this.uiGroupBox3.Controls.Add(this.btnXoa);
            this.uiGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiGroupBox3.FillColor = System.Drawing.SystemColors.Window;
            this.uiGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiGroupBox3.Location = new System.Drawing.Point(0, 233);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.RectColor = System.Drawing.Color.HotPink;
            this.uiGroupBox3.Size = new System.Drawing.Size(411, 174);
            this.uiGroupBox3.TabIndex = 4;
            this.uiGroupBox3.Text = "Thao tác";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.Enabled = false;
            this.btnHuyBo.FillColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillHoverColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.Location = new System.Drawing.Point(244, 117);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RectColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectDisableColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectHoverColor = System.Drawing.Color.Gray;
            this.btnHuyBo.RectPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Size = new System.Drawing.Size(119, 39);
            this.btnHuyBo.TabIndex = 13;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // frmQLLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLLoaiSanPham";
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSanPham)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel btnClose;
        private Sunny.UI.UIDataGridView dtgvLoaiSanPham;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtTenLoai;
        private Sunny.UI.UITextBox txtMaLoai;
        private Sunny.UI.UISymbolButton btnXoa;
        private Sunny.UI.UISymbolButton btnSua;
        private Sunny.UI.UISymbolButton btnThem;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiSanPham;
        private Sunny.UI.UIButton btnHuyBo;
    }
}