using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.IO;
using Sunny.UI;
using Sunny.UI.Win32;
using NPOI.SS.Formula.Functions;
namespace MeVaBeProject
{
    public partial class frmSanPham : Form
    {
        private NhanVien nhanVien;
        private SanPhamBLL sanPhamBLL;
        private LoaiSanPhamBLL loaiSanPhamBLL;
        private ChiTietQuyenCuaLoaiNVBLL ctQuyen;
        private BindingSource bindingSource;

        private bool QuyenThemXoaSua;
        private bool QuyenQLLoaiSanPham;
        private bool QuyenQLKhuyenMai;
        private bool QuyenTaoPhieuThanhLy;

        private string selectedFilePath;
        private string saveFilePath;
        private string imagePath;
        private frmTrangChu parentfrm;

        public frmSanPham(frmTrangChu parentfrm, NhanVien nhanVien)
        {
            InitializeComponent();
            this.parentfrm = parentfrm;
            this.btnKhuyenMai.Click += BtnKhuyenMai_Click;
            this.sanPhamBLL = new SanPhamBLL();
            this.loaiSanPhamBLL = new LoaiSanPhamBLL();
            this.ctQuyen = new ChiTietQuyenCuaLoaiNVBLL();
            this.bindingSource = new BindingSource();
            this.nhanVien = nhanVien;
        }
        private void BtnKhuyenMai_Click(object sender, EventArgs e)
        {
            frmQLKhuyenMai frm = new frmQLKhuyenMai(parentfrm, nhanVien);
            parentfrm.OpenChildForm(frm);
        }        
        private void LoadCBLoaiSanPham()
        {
            cbLoaiSP.DataSource = loaiSanPhamBLL.LayDanhSachLoaiSanPham();
            cbLoaiSP.ValueMember = "maLoaiSanPham";
            cbLoaiSP.DisplayMember = "tenLoaiSanPham";
            //ComboBox Lọc theo loại sản phẩm
            cbLocTheoLoai.DataSource = loaiSanPhamBLL.LayDanhSachLoaiSanPham();
            cbLocTheoLoai.ValueMember = "maLoaiSanPham";
            cbLocTheoLoai.DisplayMember = "tenLoaiSanPham";

            cbTrangThai.SelectedIndex = 0;
        }
        private void LoadData()
        {
            List<SanPham> danhSachSanPham = sanPhamBLL.LayTatCaSanPham();
            bindingSource.DataSource = danhSachSanPham;
            dgvProducts.DataSource = bindingSource;
            dgvProducts.Columns["hinhAnh"].Visible = false;
            dgvProducts.Columns["LoaiSanPham"].Visible = false;            
            LoadCBLoaiSanPham();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            EnableTextBox(false);
            dtNgaySanXuat.MaxDate = DateTime.Now;
            dtHanSuDung.MinDate = DateTime.Now.AddYears(2);
            QuyenThemXoaSua = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0003")!=null) ? true : false;
            if (!QuyenThemXoaSua)
            {                
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            QuyenQLKhuyenMai = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0005") != null) ? true : false;
            if (!QuyenQLKhuyenMai)
            {
                btnKhuyenMai.Enabled = false;
            }
            QuyenQLLoaiSanPham = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0004") != null) ? true : false;
            if (!QuyenQLLoaiSanPham)
            {
                btnLoaiSanPham.Enabled = false;
            }
            QuyenTaoPhieuThanhLy = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0006") != null) ? true : false;
            if (!QuyenTaoPhieuThanhLy)
            {
                btnLapPhieuThanhLy.Enabled = false;
            }
        }        
        private bool IsImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".webp" };
            string fileExtension = Path.GetExtension(filePath)?.ToLower();

            return Array.Exists(validExtensions, ext => ext == fileExtension);
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đường dẫn file đã chọn
                    selectedFilePath = openFileDialog.FileName;

                    // Đường dẫn thư mục lưu ảnh (thiết lập sẵn)
                    string relativeFolder = @"..\..\PicSanPham"; // Thay đổi đường dẫn theo ý bạn
                    string destinationFolder = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeFolder));

                    // Tạo thư mục nếu chưa tồn tại
                    Directory.CreateDirectory(destinationFolder);
                    // Đường dẫn file lưu
                    string fileName = Path.GetFileName(selectedFilePath); // Lấy tên file gốc
                    saveFilePath = Path.Combine(destinationFolder, fileName); // Tạo đường dẫn đầy đủ                    
                    imagePath = Path.Combine("PicSanPham", fileName);
                    if (IsImageFile(selectedFilePath))
                    {
                        hinhAnh.Image = Image.FromFile(selectedFilePath);
                    }
                    else
                    {
                        MessageBox.Show(this, "Vui lòng chọn file ảnh hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmQLLoaiSanPham frmQLLoaiSanPham = new frmQLLoaiSanPham();
            frmQLLoaiSanPham.DongForm += FrmQLLoaiSanPham_DongForm;
            frmQLLoaiSanPham.ShowDialog();
        }
        private void FrmQLLoaiSanPham_DongForm(bool loadData)
        {
            if (loadData)
            {
                LoadCBLoaiSanPham();
            }
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtMaSanPham.Text = dgvProducts.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString();
                txtTenSanPham.Text = dgvProducts.Rows[e.RowIndex].Cells["tenSanPham"].Value.ToString();               
                string ngaySanXuat = dgvProducts.Rows[e.RowIndex].Cells["ngaySanXuat"].Value.ToString();
                string hanSuDung = dgvProducts.Rows[e.RowIndex].Cells["hanSuDung"].Value.ToString();
                dtNgaySanXuat.Value = DateTime.Parse(ngaySanXuat);
                dtHanSuDung.Value = DateTime.Parse(hanSuDung);
                cbLoaiSP.SelectedValue = dgvProducts.Rows[e.RowIndex].Cells["maLoaiSanPham"].Value.ToString();                
                string absolutePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PicSanPham"));
                imagePath = Path.Combine(absolutePath, Path.GetFileName(dgvProducts.Rows[e.RowIndex].Cells["hinhAnh"].Value.ToString())).Replace("/", "\\");
                hinhAnh.Image = Image.FromFile(imagePath);                
            }
        }
        private void EnableDataGridView(bool enable)
        {
            dgvProducts.Enabled = enable;
            dgvProducts.DefaultCellStyle.BackColor = enable ? Color.White : Color.LightGray;
        }
        private void EnableTextBox(bool enable)
        {
            txtTenSanPham.Enabled = enable;           
            cbLoaiSP.Enabled = enable;
            btnChonAnh.Enabled = enable;
            dtNgaySanXuat.Enabled = enable; 
            dtHanSuDung.Enabled = enable;
        }
        private void ClearForm()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            hinhAnh.Image = null;
            selectedFilePath = null;
            saveFilePath = null;
            imagePath = null;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }           
            if (imagePath == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void SetButtonStyle(UIButton button, bool isEnabled)
        {
            if (isEnabled)
            {
                button.RectColor = System.Drawing.Color.HotPink;
                button.RectDisableColor = System.Drawing.Color.Fuchsia;
                button.RectHoverColor = System.Drawing.Color.DeepPink;
                button.RectPressColor = System.Drawing.Color.DeepPink;
                button.RectSelectedColor = System.Drawing.Color.FromArgb(255, 128, 255);
                button.FillColor = System.Drawing.Color.HotPink;
                button.FillHoverColor = System.Drawing.Color.DeepPink;
                button.FillPressColor = System.Drawing.Color.DeepPink;
                button.ForeColor = System.Drawing.Color.White; // Màu chữ khi nút được kích hoạt
            }
            else
            {
                button.RectColor = System.Drawing.Color.DarkGray;
                button.RectDisableColor = System.Drawing.Color.DarkGray;
                button.RectHoverColor = System.Drawing.Color.DarkGray;
                button.RectPressColor = System.Drawing.Color.DarkGray;
                button.RectSelectedColor = System.Drawing.Color.DarkGray;
                button.FillColor = System.Drawing.Color.DarkGray;
                button.FillHoverColor = System.Drawing.Color.DarkGray;
                button.FillPressColor = System.Drawing.Color.DarkGray;
                button.ForeColor = System.Drawing.Color.Gray; // Màu chữ khi nút bị vô hiệu hóa
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {            
            if (btnThem.Text == "Thêm")
            {
                ClearForm();
                btnThem.Text = "Xác nhận";
                btnHuyBo.Enabled = true;
                btnHuyBo.BackColor = Color.IndianRed;
                btnSua.Enabled = false;
                SetButtonStyle(btnSua, false);
                btnXoa.Enabled = false;
                SetButtonStyle(btnXoa, false);
                txtMaSanPham.Text = sanPhamBLL.TaoMaSanPham();
                EnableTextBox(true);
            }
            else if (btnThem.Text == "Xác nhận")
            {                
                if (ValidateInput())
                {
                    try
                    {
                        // Sao chép file đến nơi lưu
                        File.Copy(selectedFilePath, saveFilePath, overwrite: true);
                        MessageBox.Show($"Đã lưu ảnh thành công tại {saveFilePath}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    string maSanPham = txtMaSanPham.Text.Trim();
                    string tenSanPham = txtTenSanPham.Text.Trim();
                    SanPham newSanPham = new SanPham
                    {
                        maSanPham = maSanPham,
                        tenSanPham = tenSanPham,
                        maLoaiSanPham = cbLoaiSP.SelectedValue.ToString(),
                        donGiaNhap = 0,
                        donGiaBan = 0,
                        hinhAnh = imagePath,
                        ngaySanXuat = dtNgaySanXuat.Value,
                        hanSuDung = dtHanSuDung.Value,
                        trangThai = "Hết hàng",
                        soLuong = 0
                    };
                    try
                    {
                        bool isSuccess = sanPhamBLL.ThemSanPham(newSanPham);
                        if (isSuccess)
                        {
                            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                            EnableDataGridView(true);
                            btnSua.Enabled = true;
                            SetButtonStyle(btnSua, true);
                            btnXoa.Enabled = true;
                            SetButtonStyle(btnXoa, true);
                            btnThem.Text = "Thêm";
                            btnHuyBo.Enabled = false;
                            btnHuyBo.BackColor = Color.DarkGray;

                            EnableTextBox(false);
                        }
                        else
                        {
                            MessageBox.Show("Thêm sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count>0)
            {
                DialogResult r = MessageBox.Show(this, "Bạn có chắc chắc muốn xóa sản phẩm không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int soLuong = int.Parse(dgvProducts.SelectedRows[0].Cells["soLuong"].Value.ToString());
                    if (soLuong > 0)
                    {
                        MessageBox.Show(this, "Không thể xóa sản phẩm do sản phầm còn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sanPhamBLL.KiemTraSanPhamCoThuocHoaDon(dgvProducts.SelectedRows[0].Cells["maSanPham"].Value.ToString()))
                    {
                        MessageBox.Show(this, "Không thể xóa sản phẩm do sản phầm có trong hóa đơn bán hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (sanPhamBLL.KiemTraSanPhamCoThuocPhieuDat(dgvProducts.SelectedRows[0].Cells["maSanPham"].Value.ToString()))
                    {
                        MessageBox.Show(this, "Không thể xóa sản phẩm do sản phầm có trong phiếu đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool isSuccess = sanPhamBLL.XoaSanPham(dgvProducts.SelectedRows[0].Cells["maSanPham"].Value.ToString());
                        if (isSuccess)
                        {
                            MessageBox.Show(this, "Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show(this, "Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }                    
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSanPham.Text != string.Empty)
            {
                if (btnSua.Text == "Sửa")
                {
                    EnableDataGridView(false);
                    btnSua.Text = "Xác nhận";
                    btnHuyBo.Enabled = true;
                    btnHuyBo.BackColor = Color.IndianRed;
                    btnThem.Enabled = false;
                    SetButtonStyle(btnThem, false);
                    btnXoa.Enabled = false;
                    SetButtonStyle(btnXoa, false);
                    EnableTextBox(true);
                }
                else if (btnSua.Text == "Xác nhận")
                {
                    if (ValidateInput())
                    {
                        if (selectedFilePath !=null && saveFilePath !=null)
                        {
                            try
                            {
                                // Sao chép file đến nơi lưu
                                File.Copy(selectedFilePath, saveFilePath, overwrite: true);
                                hinhAnh.Image = Image.FromFile(saveFilePath);
                                MessageBox.Show($"Đã lưu ảnh thành công tại {saveFilePath}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Lỗi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        SanPham newSanPham = new SanPham()
                        {
                            maSanPham = txtMaSanPham.Text.Trim(),
                            tenSanPham = txtTenSanPham.Text.Trim(),
                            maLoaiSanPham = cbLoaiSP.SelectedValue.ToString(),                            
                            ngaySanXuat = dtNgaySanXuat.Value,
                            hanSuDung = dtHanSuDung.Value,
                            hinhAnh = imagePath,
                        };
                        try
                        {
                            bool isSuccess = sanPhamBLL.SuaSanPham(newSanPham);
                            if (isSuccess)
                            {
                                MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();

                                ClearForm();
                                EnableDataGridView(true);
                                btnThem.Enabled = true;
                                SetButtonStyle(btnThem, true);
                                btnXoa.Enabled = true;
                                SetButtonStyle(btnXoa, true);
                                btnSua.Text = "Sửa";
                                btnHuyBo.Enabled = false;
                                btnHuyBo.BackColor = Color.DarkGray;

                                EnableTextBox(false);
                            }
                            else
                            {
                                MessageBox.Show("Sửa sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi sửa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableTextBox(false);

            EnableDataGridView(true);
            btnThem.Enabled = true;
            SetButtonStyle(btnThem, true);
            btnSua.Enabled = true;
            SetButtonStyle(btnSua, true);
            btnXoa.Enabled = true;
            SetButtonStyle(btnXoa, true);
            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnHuyBo.Enabled = false;
            btnHuyBo.BackColor = Color.DarkGray;
        }
        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }        
        private void dtNgaySanXuat_ValueChanged(object sender, EventArgs e)
        {
            dtHanSuDung.MinDate = dtNgaySanXuat.Value;
        }
        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            UIComboBox comboBox = sender as UIComboBox;
            if (comboBox == cbTrangThai)
            {
                if (cbTrangThai.SelectedItem!=null)
                {
                    if (cbTrangThai.SelectedText == "Sắp hết hạn")
                    {
                        bindingSource.DataSource = sanPhamBLL.LayDanhSachSanPhamSapHetHan();
                    }
                    else
                    {
                        bindingSource.DataSource = sanPhamBLL.LayDanhSachSanPhamTheoTrangThai(cbTrangThai.SelectedText);
                    }                    
                }                
            }
            else if(comboBox == cbLocTheoLoai)  
            {
                if (cbLocTheoLoai.SelectedItem!=null)
                {
                    bindingSource.DataSource = sanPhamBLL.LayDanhSachSanPhamTheoMaLoai(cbLocTheoLoai.SelectedValue.ToString());
                }                
            }
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm để tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Italic);
                LoadData();
            }
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã hoặc tên sản phẩm để tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Regular);
            }
        }
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím nhấn có phải là Enter không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Tự động click vào nút tìm kiếm
                btnSearch.PerformClick();

                // Ngăn chặn âm thanh bíp khi nhấn Enter
                e.Handled = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = sanPhamBLL.TimKiemSanPham(txtTimKiem.Text.Trim());

            // Kiểm tra kết quả trả về có hợp lệ không
            if (results != null && results.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                bindingSource.DataSource = results;
            }
            else
            {
                // Nếu không tìm thấy kết quả, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnLapPhieuThanhLy_Click(object sender, EventArgs e)
        {
            List<SanPham> danhSachSanPhamHetHan = sanPhamBLL.LayDanhSachSanPhamHetHan();
            if (danhSachSanPhamHetHan.Count>0)
            {
                PhieuThanhLyBLL phieuThanhLyBLL = new PhieuThanhLyBLL();
                PhieuThanhLy newPhieu = new PhieuThanhLy()
                {
                    maThanhLy = phieuThanhLyBLL.TaoMaPhieuThanhLy(),
                    maNhanVien = nhanVien.maNhanVien,
                    ngayThanhLy = DateTime.Now,
                    lyDo = "Sản phẩm hết hạn sử dụng"
                };
                phieuThanhLyBLL.TaoPhieuThanhLy(newPhieu);
                ChiTietPhieuThanhLyBLL ctPhieuThanhLyBLL = new ChiTietPhieuThanhLyBLL();
                foreach(SanPham sanPham in danhSachSanPhamHetHan)
                {
                    ChiTietPhieuThanhLy chiTietPhieuThanhLy =new ChiTietPhieuThanhLy()
                    {
                        maThanhLy = newPhieu.maThanhLy,
                        maSanPham = sanPham.maSanPham,
                        soLuong = sanPham.soLuong,
                        ngayHetHan = sanPham.hanSuDung
                    };
                    ctPhieuThanhLyBLL.TaoChiTietPhieuThanhLy(chiTietPhieuThanhLy);
                }
                frmPhieuThanhLy frmPhieuThanhLy = new frmPhieuThanhLy(newPhieu.maThanhLy);
                frmPhieuThanhLy.DongForm += FrmPhieuThanhLy_DongForm;
                frmPhieuThanhLy.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Không có sản phẩm hết hạn để thanh lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmPhieuThanhLy_DongForm(bool loadData)
        {
            if (loadData)
            {
                LoadData();
            }
        }
    }
}
