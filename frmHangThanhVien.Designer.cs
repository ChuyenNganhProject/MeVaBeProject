﻿namespace MeVaBeProject
{
    partial class frmHangThanhVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHangThanhVien = new Sunny.UI.UIDataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucTieuBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucTieuKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new Sunny.UI.UISymbolButton();
            this.txtSearch = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.txtMaHang = new Sunny.UI.UITextBox();
            this.txtMucTieubd = new Sunny.UI.UITextBox();
            this.txtMucTieukt = new Sunny.UI.UITextBox();
            this.txtTenHang = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txtGhichu = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiPanel4 = new Sunny.UI.UIPanel();
            this.btnLamMoi = new Sunny.UI.UISymbolButton();
            this.btnThem = new Sunny.UI.UISymbolButton();
            this.btnXoa = new Sunny.UI.UISymbolButton();
            this.btnSua = new Sunny.UI.UISymbolButton();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.txtTenUuDai = new Sunny.UI.UITextBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.numericPhanTramGiam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangThanhVien)).BeginInit();
            this.uiPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPhanTramGiam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHangThanhVien
            // 
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvHangThanhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle71;
            this.dgvHangThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangThanhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangThanhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle72.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle72.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle72.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle72.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangThanhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvHangThanhVien.ColumnHeadersHeight = 32;
            this.dgvHangThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.mucTieuBatDau,
            this.mucTieuKetThuc,
            this.ghiChu});
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangThanhVien.DefaultCellStyle = dataGridViewCellStyle78;
            this.dgvHangThanhVien.EnableHeadersVisualStyles = false;
            this.dgvHangThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHangThanhVien.GridColor = System.Drawing.Color.White;
            this.dgvHangThanhVien.Location = new System.Drawing.Point(15, 122);
            this.dgvHangThanhVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHangThanhVien.Name = "dgvHangThanhVien";
            this.dgvHangThanhVien.ReadOnly = true;
            this.dgvHangThanhVien.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangThanhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle79;
            this.dgvHangThanhVien.RowHeadersWidth = 51;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle80.SelectionBackColor = System.Drawing.Color.Pink;
            this.dgvHangThanhVien.RowsDefaultCellStyle = dataGridViewCellStyle80;
            this.dgvHangThanhVien.RowTemplate.Height = 24;
            this.dgvHangThanhVien.ScrollBarColor = System.Drawing.Color.White;
            this.dgvHangThanhVien.ScrollBarRectColor = System.Drawing.Color.Pink;
            this.dgvHangThanhVien.ScrollBarStyleInherited = false;
            this.dgvHangThanhVien.SelectedIndex = -1;
            this.dgvHangThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangThanhVien.Size = new System.Drawing.Size(863, 205);
            this.dgvHangThanhVien.StripeOddColor = System.Drawing.Color.LavenderBlush;
            this.dgvHangThanhVien.TabIndex = 3;
            this.dgvHangThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangThanhVien_CellClick);
            this.dgvHangThanhVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHangThanhVien_CellFormatting);
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.maHang.DefaultCellStyle = dataGridViewCellStyle73;
            this.maHang.HeaderText = "Mã hạng";
            this.maHang.MinimumWidth = 6;
            this.maHang.Name = "maHang";
            this.maHang.ReadOnly = true;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tenHang.DefaultCellStyle = dataGridViewCellStyle74;
            this.tenHang.HeaderText = "Tên hạng";
            this.tenHang.MinimumWidth = 6;
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            // 
            // mucTieuBatDau
            // 
            this.mucTieuBatDau.DataPropertyName = "mucTieuBatDau";
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mucTieuBatDau.DefaultCellStyle = dataGridViewCellStyle75;
            this.mucTieuBatDau.HeaderText = "Mục tiêu bắt đầu";
            this.mucTieuBatDau.MinimumWidth = 6;
            this.mucTieuBatDau.Name = "mucTieuBatDau";
            this.mucTieuBatDau.ReadOnly = true;
            // 
            // mucTieuKetThuc
            // 
            this.mucTieuKetThuc.DataPropertyName = "mucTieuKetThuc";
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.mucTieuKetThuc.DefaultCellStyle = dataGridViewCellStyle76;
            this.mucTieuKetThuc.HeaderText = "Mục tiêu kết thúc";
            this.mucTieuKetThuc.MinimumWidth = 6;
            this.mucTieuKetThuc.Name = "mucTieuKetThuc";
            this.mucTieuKetThuc.ReadOnly = true;
            this.mucTieuKetThuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ghiChu.DefaultCellStyle = dataGridViewCellStyle77;
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.MinimumWidth = 6;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.HotPink;
            this.btnSearch.FillColor2 = System.Drawing.Color.Fuchsia;
            this.btnSearch.FillHoverColor = System.Drawing.Color.LightPink;
            this.btnSearch.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(339, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 4;
            this.btnSearch.RectColor = System.Drawing.Color.LightPink;
            this.btnSearch.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSearch.Size = new System.Drawing.Size(30, 28);
            this.btnSearch.Symbol = 61442;
            this.btnSearch.TabIndex = 22;
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(15, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(4);
            this.txtSearch.Radius = 28;
            this.txtSearch.RectColor = System.Drawing.Color.HotPink;
            this.txtSearch.ShowText = false;
            this.txtSearch.Size = new System.Drawing.Size(319, 28);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.Text = "Nhập mã hạng hoặc tên hạng";
            this.txtSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtSearch.Watermark = "";
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave_1);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter_1);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.Fuchsia;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.LightPink;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.DeepPink;
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.White;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(852, 2);
            this.uiSymbolButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.White;
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.uiSymbolButton1.Size = new System.Drawing.Size(38, 41);
            this.uiSymbolButton1.Symbol = 61527;
            this.uiSymbolButton1.SymbolColor = System.Drawing.Color.DeepPink;
            this.uiSymbolButton1.SymbolHoverColor = System.Drawing.Color.Pink;
            this.uiSymbolButton1.SymbolSize = 45;
            this.uiSymbolButton1.TabIndex = 25;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.DeepPink;
            this.uiLabel1.Location = new System.Drawing.Point(688, 86);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(190, 21);
            this.uiLabel1.TabIndex = 26;
            this.uiLabel1.Text = "Danh sách hạng thành viên ";
            // 
            // uiPanel3
            // 
            this.uiPanel3.BackColor = System.Drawing.Color.DeepPink;
            this.uiPanel3.Controls.Add(this.uiPanel1);
            this.uiPanel3.FillColor = System.Drawing.Color.HotPink;
            this.uiPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel3.Location = new System.Drawing.Point(3, 50);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Radius = 3;
            this.uiPanel3.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel3.Size = new System.Drawing.Size(897, 4);
            this.uiPanel3.TabIndex = 27;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.Color.DeepPink;
            this.uiPanel1.FillColor = System.Drawing.Color.HotPink;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(-9, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 3;
            this.uiPanel1.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel1.Size = new System.Drawing.Size(1205, 10);
            this.uiPanel1.TabIndex = 28;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHang.Location = new System.Drawing.Point(141, 381);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHang.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Padding = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Radius = 10;
            this.txtMaHang.RectColor = System.Drawing.Color.HotPink;
            this.txtMaHang.ShowText = false;
            this.txtMaHang.Size = new System.Drawing.Size(180, 27);
            this.txtMaHang.TabIndex = 37;
            this.txtMaHang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaHang.Watermark = "";
            // 
            // txtMucTieubd
            // 
            this.txtMucTieubd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMucTieubd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMucTieubd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMucTieubd.Location = new System.Drawing.Point(348, 416);
            this.txtMucTieubd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMucTieubd.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtMucTieubd.Name = "txtMucTieubd";
            this.txtMucTieubd.Padding = new System.Windows.Forms.Padding(4);
            this.txtMucTieubd.Radius = 10;
            this.txtMucTieubd.RectColor = System.Drawing.Color.HotPink;
            this.txtMucTieubd.ShowText = false;
            this.txtMucTieubd.Size = new System.Drawing.Size(180, 27);
            this.txtMucTieubd.TabIndex = 36;
            this.txtMucTieubd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMucTieubd.Watermark = "";
            this.txtMucTieubd.TextChanged += new System.EventHandler(this.txtMucTieubd_TextChanged);
            this.txtMucTieubd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucTieubd_KeyPress);
            // 
            // txtMucTieukt
            // 
            this.txtMucTieukt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMucTieukt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMucTieukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMucTieukt.Location = new System.Drawing.Point(348, 480);
            this.txtMucTieukt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMucTieukt.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtMucTieukt.Name = "txtMucTieukt";
            this.txtMucTieukt.Padding = new System.Windows.Forms.Padding(4);
            this.txtMucTieukt.Radius = 10;
            this.txtMucTieukt.RectColor = System.Drawing.Color.HotPink;
            this.txtMucTieukt.ShowText = false;
            this.txtMucTieukt.Size = new System.Drawing.Size(180, 27);
            this.txtMucTieukt.TabIndex = 33;
            this.txtMucTieukt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMucTieukt.Watermark = "";
            this.txtMucTieukt.TextChanged += new System.EventHandler(this.txtMucTieukt_TextChanged);
            this.txtMucTieukt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucTieukt_KeyPress);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHang.Location = new System.Drawing.Point(141, 416);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHang.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Padding = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Radius = 10;
            this.txtTenHang.RectColor = System.Drawing.Color.HotPink;
            this.txtTenHang.ShowText = false;
            this.txtTenHang.Size = new System.Drawing.Size(180, 27);
            this.txtTenHang.TabIndex = 35;
            this.txtTenHang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenHang.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(344, 451);
            this.uiLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(138, 25);
            this.uiLabel9.TabIndex = 28;
            this.uiLabel9.Text = "Mục tiêu kết thúc:";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(344, 387);
            this.uiLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(138, 25);
            this.uiLabel8.TabIndex = 29;
            this.uiLabel8.Text = "Mục tiêu bắt đầu:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(11, 521);
            this.uiLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(73, 25);
            this.uiLabel7.TabIndex = 30;
            this.uiLabel7.Text = "Ghi chú:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(11, 418);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(85, 25);
            this.uiLabel3.TabIndex = 31;
            this.uiLabel3.Text = "Tên hạng:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(11, 383);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(85, 25);
            this.uiLabel2.TabIndex = 32;
            this.uiLabel2.Text = "Mã hạng:";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGhichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGhichu.Location = new System.Drawing.Point(141, 521);
            this.txtGhichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGhichu.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtGhichu.Multiline = true;
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Padding = new System.Windows.Forms.Padding(4);
            this.txtGhichu.Radius = 10;
            this.txtGhichu.RectColor = System.Drawing.Color.HotPink;
            this.txtGhichu.ShowText = false;
            this.txtGhichu.Size = new System.Drawing.Size(180, 106);
            this.txtGhichu.TabIndex = 36;
            this.txtGhichu.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtGhichu.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(335, 15);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(255, 31);
            this.uiLabel4.TabIndex = 39;
            this.uiLabel4.Text = "Quản lí hạng thành viên ";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.DeepPink;
            this.uiLabel6.Location = new System.Drawing.Point(12, 344);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(297, 16);
            this.uiLabel6.TabIndex = 88;
            this.uiLabel6.Text = "Nhập thông tin hạng thành viên ";
            // 
            // uiPanel4
            // 
            this.uiPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel4.Location = new System.Drawing.Point(15, 371);
            this.uiPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel4.Name = "uiPanel4";
            this.uiPanel4.Radius = 2;
            this.uiPanel4.RectColor = System.Drawing.Color.HotPink;
            this.uiPanel4.Size = new System.Drawing.Size(863, 2);
            this.uiPanel4.TabIndex = 89;
            this.uiPanel4.Text = null;
            this.uiPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnLamMoi.Location = new System.Drawing.Point(570, 431);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Radius = 1;
            this.btnLamMoi.RectColor = System.Drawing.Color.LightPink;
            this.btnLamMoi.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnLamMoi.Size = new System.Drawing.Size(134, 32);
            this.btnLamMoi.Symbol = 61473;
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnThem.Location = new System.Drawing.Point(570, 387);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Radius = 1;
            this.btnThem.RectColor = System.Drawing.Color.LightPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnThem.Size = new System.Drawing.Size(134, 32);
            this.btnThem.Symbol = 61525;
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm ";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(716, 387);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Radius = 1;
            this.btnXoa.RectColor = System.Drawing.Color.LightPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Size = new System.Drawing.Size(134, 32);
            this.btnXoa.Symbol = 262189;
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(716, 431);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Radius = 1;
            this.btnSua.RectColor = System.Drawing.Color.LightPink;
            this.btnSua.RectSelectedColor = System.Drawing.Color.DeepPink;
            this.btnSua.Size = new System.Drawing.Size(134, 32);
            this.btnSua.Symbol = 61508;
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa ";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(11, 453);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(97, 25);
            this.uiLabel5.TabIndex = 90;
            this.uiLabel5.Text = "Tên ưu đãi:";
            // 
            // txtTenUuDai
            // 
            this.txtTenUuDai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenUuDai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenUuDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenUuDai.Location = new System.Drawing.Point(141, 451);
            this.txtTenUuDai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenUuDai.MinimumSize = new System.Drawing.Size(1, 13);
            this.txtTenUuDai.Name = "txtTenUuDai";
            this.txtTenUuDai.Padding = new System.Windows.Forms.Padding(4);
            this.txtTenUuDai.Radius = 10;
            this.txtTenUuDai.RectColor = System.Drawing.Color.HotPink;
            this.txtTenUuDai.ShowText = false;
            this.txtTenUuDai.Size = new System.Drawing.Size(180, 27);
            this.txtTenUuDai.TabIndex = 36;
            this.txtTenUuDai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenUuDai.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(11, 488);
            this.uiLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(125, 25);
            this.uiLabel10.TabIndex = 92;
            this.uiLabel10.Text = "Phần trăm giảm:";
            // 
            // numericPhanTramGiam
            // 
            this.numericPhanTramGiam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericPhanTramGiam.Location = new System.Drawing.Point(141, 485);
            this.numericPhanTramGiam.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericPhanTramGiam.Name = "numericPhanTramGiam";
            this.numericPhanTramGiam.Size = new System.Drawing.Size(62, 26);
            this.numericPhanTramGiam.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(209, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 95;
            this.label2.Text = "% Giảm";
            // 
            // frmHangThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(899, 640);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericPhanTramGiam);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.txtTenUuDai);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.uiPanel4);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.txtMucTieubd);
            this.Controls.Add(this.txtMucTieukt);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvHangThanhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHangThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHangThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangThanhVien)).EndInit();
            this.uiPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericPhanTramGiam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvHangThanhVien;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox txtMaHang;
        private Sunny.UI.UITextBox txtMucTieubd;
        private Sunny.UI.UITextBox txtMucTieukt;
        private Sunny.UI.UITextBox txtTenHang;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtGhichu;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucTieuBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucTieuKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UISymbolButton btnLamMoi;
        private Sunny.UI.UISymbolButton btnThem;
        private Sunny.UI.UISymbolButton btnXoa;
        private Sunny.UI.UISymbolButton btnSua;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtTenUuDai;
        private Sunny.UI.UILabel uiLabel10;
        public System.Windows.Forms.NumericUpDown numericPhanTramGiam;
        public System.Windows.Forms.Label label2;
    }
}