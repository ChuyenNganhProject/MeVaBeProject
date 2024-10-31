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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvNhanVien = new Sunny.UI.UIDataGridView();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSearch = new Sunny.UI.UIImageButton();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.btnHuyBo = new Sunny.UI.UIButton();
            this.btnSua = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.btnThem = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.txtTenNCC = new Sunny.UI.UITextBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.txtMaNCC = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.uiPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1068, 51);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Danh sách nhân viên";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 103);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RectColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.SelectedIndex = -1;
            this.dgvNhanVien.Size = new System.Drawing.Size(1068, 300);
            this.dgvNhanVien.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.TabIndex = 1;
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.dgvNhanVien);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiTextBox4);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1068, 403);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DeepPink;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ImageOffset = new System.Drawing.Point(5, 10);
            this.btnSearch.Location = new System.Drawing.Point(1006, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = null;
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox4.Location = new System.Drawing.Point(714, 68);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox4.Radius = 1;
            this.uiTextBox4.RectColor = System.Drawing.Color.HotPink;
            this.uiTextBox4.ShowText = false;
            this.uiTextBox4.Size = new System.Drawing.Size(285, 29);
            this.uiTextBox4.TabIndex = 11;
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox4.Watermark = "";
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyBo.Enabled = false;
            this.btnHuyBo.FillColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillHoverColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.FillPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuyBo.Location = new System.Drawing.Point(782, 655);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RectColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectDisableColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectHoverColor = System.Drawing.Color.Gray;
            this.btnHuyBo.RectPressColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.RectSelectedColor = System.Drawing.Color.DarkGray;
            this.btnHuyBo.Size = new System.Drawing.Size(112, 32);
            this.btnHuyBo.TabIndex = 12;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.LightPink;
            this.btnSua.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnSua.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(588, 655);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.RectColor = System.Drawing.Color.HotPink;
            this.btnSua.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnSua.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnSua.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Size = new System.Drawing.Size(112, 32);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.LightPink;
            this.btnXoa.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnXoa.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(371, 655);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RectColor = System.Drawing.Color.HotPink;
            this.btnXoa.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnXoa.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnXoa.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Size = new System.Drawing.Size(112, 32);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FillColor = System.Drawing.Color.LightPink;
            this.btnThem.FillHoverColor = System.Drawing.Color.HotPink;
            this.btnThem.FillPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(155, 655);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.RectColor = System.Drawing.Color.HotPink;
            this.btnThem.RectDisableColor = System.Drawing.Color.Fuchsia;
            this.btnThem.RectHoverColor = System.Drawing.Color.DeepPink;
            this.btnThem.RectPressColor = System.Drawing.Color.DeepPink;
            this.btnThem.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Size = new System.Drawing.Size(112, 32);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.dateTimePicker1);
            this.uiPanel2.Controls.Add(this.dtpNgaySinh);
            this.uiPanel2.Controls.Add(this.uiComboBox1);
            this.uiPanel2.Controls.Add(this.uiTextBox3);
            this.uiPanel2.Controls.Add(this.uiTextBox2);
            this.uiPanel2.Controls.Add(this.uiTextBox1);
            this.uiPanel2.Controls.Add(this.txtTenNCC);
            this.uiPanel2.Controls.Add(this.uiLabel9);
            this.uiPanel2.Controls.Add(this.txtMaNCC);
            this.uiPanel2.Controls.Add(this.uiLabel8);
            this.uiPanel2.Controls.Add(this.uiLabel7);
            this.uiPanel2.Controls.Add(this.uiLabel10);
            this.uiPanel2.Controls.Add(this.uiLabel6);
            this.uiPanel2.Controls.Add(this.uiLabel3);
            this.uiPanel2.Controls.Add(this.uiLabel5);
            this.uiPanel2.Controls.Add(this.uiLabel2);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel2.FillColor = System.Drawing.SystemColors.Window;
            this.uiPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 403);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.DeepPink;
            this.uiPanel2.Size = new System.Drawing.Size(1068, 223);
            this.uiPanel2.TabIndex = 14;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(746, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(746, 9);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 14;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(746, 93);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiComboBox1.Size = new System.Drawing.Size(253, 29);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 13;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox3.Location = new System.Drawing.Point(176, 171);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.Radius = 1;
            this.uiTextBox3.RectColor = System.Drawing.Color.HotPink;
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(285, 29);
            this.uiTextBox3.TabIndex = 9;
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox2.Location = new System.Drawing.Point(176, 132);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.Radius = 1;
            this.uiTextBox2.RectColor = System.Drawing.Color.HotPink;
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(285, 29);
            this.uiTextBox2.TabIndex = 9;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiTextBox1.Location = new System.Drawing.Point(176, 93);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.Radius = 1;
            this.uiTextBox1.RectColor = System.Drawing.Color.HotPink;
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(285, 29);
            this.uiTextBox1.TabIndex = 9;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNCC.Location = new System.Drawing.Point(176, 53);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNCC.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenNCC.Radius = 1;
            this.txtTenNCC.RectColor = System.Drawing.Color.HotPink;
            this.txtTenNCC.ShowText = false;
            this.txtTenNCC.Size = new System.Drawing.Size(285, 29);
            this.txtTenNCC.TabIndex = 10;
            this.txtTenNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenNCC.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(30, 171);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(184, 31);
            this.uiLabel9.TabIndex = 4;
            this.uiLabel9.Text = "Tên đăng nhập:";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNCC.Location = new System.Drawing.Point(176, 14);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNCC.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaNCC.Radius = 1;
            this.txtMaNCC.RectColor = System.Drawing.Color.HotPink;
            this.txtMaNCC.ShowText = false;
            this.txtMaNCC.Size = new System.Drawing.Size(285, 29);
            this.txtMaNCC.TabIndex = 11;
            this.txtMaNCC.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaNCC.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(30, 130);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(184, 31);
            this.uiLabel8.TabIndex = 4;
            this.uiLabel8.Text = "Số điện thoại:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(30, 91);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(184, 31);
            this.uiLabel7.TabIndex = 4;
            this.uiLabel7.Text = "Địa chỉ:";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(603, 91);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(184, 31);
            this.uiLabel10.TabIndex = 5;
            this.uiLabel10.Text = "Loại nhân viên:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(603, 53);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(137, 31);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Ngày vào làm:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(30, 53);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(184, 31);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Tên nhân viên:";
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(603, 14);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(144, 31);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "Ngày sinh:";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(30, 14);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(123, 31);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "Mã nhân viên:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1068, 720);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.uiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmNhanVien";
            this.Text = "frmSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.uiPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvNhanVien;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnHuyBo;
        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoa;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox txtTenNCC;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UITextBox txtMaNCC;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIImageButton btnSearch;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel10;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}