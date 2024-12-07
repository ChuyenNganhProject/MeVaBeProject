using BLL;
using DTO;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmThongTinNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        LoaiNhanVienBLL lnvbll = new LoaiNhanVienBLL();
        private string matkhauCu;
        private string tenNV;
        public frmThongTinNhanVien()
        {
            InitializeComponent();
            this.Load += frmThongTinNhanVien_Load;
            SetEnableFalse();
            btnDoi.Enabled = false;
            btnHuy.Enabled = false;
            this.btnDong.Click += BtnDong_Click;
        }
        public void SetEnableTrue()
        {
            txtMatKhauCu.Enabled = true;
            txtMatKhauMoi.Enabled = true;
            btnDoi.Enabled = true;
            btnHuy.Enabled = true;
            btnChon.Enabled = false;
            txtTaiKhoan.Focus();
        }
        public void SetEnableFalse()
        {
            txtMatKhauCu.Enabled = false;
            txtMatKhauMoi.Enabled = false;
            btnDoi.Enabled = false;
            btnHuy.Enabled = false;
            btnChon.Enabled = true;
        }
        public void loadThongTinNhanVien()
        {
            var nv = nvbll.LayTTNhanVienTuMa(frmTrangChu.maNhanVienDangNhap);
            if (nv != null)
            {                
                tenNV = lbTenNhanVien.Text = txtTenNV.Text = nv.tenNhanVien;
                txtNgaySinh.Value = nv.ngaySinh.Value;
                txtNgayVaoLam.Value = nv.ngayVaoLam.Value;
                txtSDT.Text = nv.soDienThoai;
                txtDiaChi.Text = nv.diaChi;
                txtChucVuNV.Text = frmTrangChu.chucVuNhanVienDangNhap;
                txtLuong.Text = (nv.luongCoBan.HasValue ? nv.luongCoBan.Value.ToString("N0").Replace(",", ".") : "0") + " VND";
                txtTaiKhoan.Text = nv.tenDangNhap;
                matkhauCu = nv.matKhau;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void frmThongTinNhanVien_Load(object sender, System.EventArgs e)
        {
            loadThongTinNhanVien();
            txtNgaySinh.Enabled = false;
            txtChucVuNV.Enabled = false;
            txtLuong.Enabled = false;
            txtNgayVaoLam.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenNV.Enabled = false;
            btnSua.Enabled = false;
        }
        private void BtnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnChon_Click_1(object sender, EventArgs e)
        {
            SetEnableTrue();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            btnSua.Enabled = true;
        }
        private bool ValidateInput_Sua_MK()
        {
            //TK
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //MK cũ
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //MK mới
            if (txtMatKhauMoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có độ dài từ 6 kí tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhauMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập tênn đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidateInput_Sua(string oldPhoneNumber = "")
        {
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            if (txtSDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đúng 10 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra số điện thoại mới có trùng với số điện thoại của nhân viên khác không
            string newPhoneNumber = txtSDT.Text.Trim();
            if (oldPhoneNumber != newPhoneNumber && nvbll.IsSDTDuplicate(newPhoneNumber)) // Kiểm tra số điện thoại mới
            {
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống. Vui lòng nhập số điện thoại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            string maNV = frmTrangChu.maNhanVienDangNhap;
            // Lấy số điện thoại cũ và mật khẩu cũ từ cơ sở dữ liệu
            string OldPhoneNumber = nvbll.GetPhoneNumberById(maNV);
            //string OldPassword = nvbll.GetPasswordById(maNV); // Get old password 

            if (!ValidateInput_Sua(oldPhoneNumber: OldPhoneNumber))
            {
                return;
            }
            var nv = new NhanVien
            {
                maNhanVien = frmTrangChu.maNhanVienDangNhap,
                soDienThoai = txtSDT.Text.Trim(),
                diaChi = txtDiaChi.Text.Trim(),
            };

            // Cập nhật cơ sở dữ liệu
            bool kq = nvbll.UpdateSDT_DiaChi(nv);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadThongTinNhanVien();
                btnSua.Enabled = false;
                txtSDT.Enabled = false;
                txtDiaChi.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Cập nhật không thành công cho nhân viên: {nv.tenNhanVien}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTaiKhoan.Text.Length >= 30 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đổi mật khẩu ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (!ValidateInput_Sua_MK())
            {
                return;
            }
            string matKhauCuHashed = nvbll.MaHoaMKMoi(txtMatKhauCu.Text);
            string matKhauMoiHashed = nvbll.MaHoaMKMoi(txtMatKhauMoi.Text);
            Debug.WriteLine("Mật khẩu cũ đã băm: " + matKhauCuHashed);
            Debug.WriteLine("Mật khẩu mới đã băm: " + matKhauMoiHashed);
            Debug.WriteLine("Mật khẩu : " + matkhauCu);
            Debug.WriteLine("------------------------");
            if (!nvbll.KiemTraMatKhauCu(txtTaiKhoan.Text, matKhauCuHashed))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai! Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Debug.WriteLine("------------------------");
                return;
            }
            var nv = new NhanVien
            {
                maNhanVien = frmTrangChu.maNhanVienDangNhap,
                //tenDangNhap = txtTaiKhoan.Text.Trim(),
                matKhau = matKhauMoiHashed,
            };

            // Cập nhật cơ sở dữ liệu
            bool kq = nvbll.UpdateMatKhauMoi(nv);
            if (kq)
            {
                MessageBox.Show($"Cập nhật thành công thành công :\n {nv.tenNhanVien}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadThongTinNhanVien();
                SetEnableFalse();
                txtMatKhauCu.Text = "";
                txtMatKhauMoi.Text = "";
            }
            else
            {
                MessageBox.Show($"Lỗi cập nhật: {nv.tenNhanVien}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetEnableFalse();
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
        }
        private void btnAnMatKhau_Click(object sender, EventArgs e)
        {
            if (btnAnMatKhau.Symbol == 559636)
            {
                txtMatKhauMoi.PasswordChar = '\0';
                btnAnMatKhau.Symbol = 559637;
            }
            else
            {
                txtMatKhauMoi.PasswordChar = '*';
                btnAnMatKhau.Symbol = 559636;
            }
        }
    }
}
