using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        LoaiNhanVienBLL lnvbll = new LoaiNhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += FrmNhanVien_Load;
            SetForm();
            txtSearch.ForeColor = Color.Silver;
        }
        public void SetForm()
        {
            txtMaNV.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMatKhau.Enabled = false;

        }
        public void SetDataGirdView()
        {
            //không cho phép thêm
            btnThem.Enabled = false;
            //cho phép sửa, xóa 
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txtTenDN.Enabled = false;
            txtMatKhau.Enabled = false;
            dgvNhanVien.Columns["maNhanVien"].ReadOnly = true;
            dgvNhanVien.Columns["tenNhanVien"].ReadOnly = true;
            dgvNhanVien.Columns["luongCoBan"].ReadOnly = true;
            dgvNhanVien.Columns["diaChi"].ReadOnly = true;
            dgvNhanVien.Columns["ngaySinh"].ReadOnly = true;
            dgvNhanVien.Columns["ngayVaoLam"].ReadOnly = true;
            dgvNhanVien.Columns["tenDangNhap"].ReadOnly = true;
            dgvNhanVien.Columns["matKhau"].ReadOnly = true;
            dgvNhanVien.Columns["soDienThoai"].ReadOnly = true;
        }
        private void ClearForm()
        {
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            txtLuong.Text = "";
            txtSDT.Text = "";
            txtTenDN.Text = "";
            txtMatKhau.Text = "";
            txtDiaChi.Text = "";
        }
        //private bool ValidateInput_Them()
        //{
        //    // Kiểm tra tên nhân viên
        //    if (string.IsNullOrWhiteSpace(txtTenNV.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra tên đăng nhập
        //    if (string.IsNullOrWhiteSpace(txtTenDN.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra trùng tên đăng nhập
        //    if (nvbll.IsTaiKhoanDuplicate(txtTenDN.Text))
        //    {
        //        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng nhập tên khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra mật khẩu
        //    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra số điện thoại
        //    if (string.IsNullOrWhiteSpace(txtSDT.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra định dạng số điện thoại
        //    if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
        //    {
        //        MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số và không chứa ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra trùng số điện thoại
        //    if (nvbll.IsSDTDuplicate(txtSDT.Text))
        //    {
        //        MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra địa chỉ
        //    if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
        //    {
        //        MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra ngày sinh và độ tuổi
        //    DateTime selectedDateOfBirth = txtNgaySinh.Value;
        //    int age = DateTime.Now.Year - selectedDateOfBirth.Year;
        //    if (selectedDateOfBirth > DateTime.Now.AddYears(-age)) age--;
        //    if (age < 18)
        //    {
        //        MessageBox.Show("Nhân viên phải có tuổi từ 18 trở lên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    // Kiểm tra ngày vào làm
        //    DateTime minDate = new DateTime(2003, 1, 19);
        //    DateTime today = DateTime.Today;
        //    if (txtNgayVaoLam.Value <= minDate || txtNgayVaoLam.Value > today)
        //    {
        //        MessageBox.Show("Ngày vào làm không được để trống và phải lớn hơn ngày 19/01/2003 và không vượt quá ngày hôm nay.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }


        //    // Kiểm tra lương cơ bản
        //    if (string.IsNullOrWhiteSpace(txtLuong.Text) ||
        //        (!int.TryParse(txtLuong.Text.Replace(" VND", "").Replace(",", "").Trim(), out int luongCoBan) && !isUpdate) ||
        //        luongCoBan <= 0)
        //    {
        //        MessageBox.Show("Lương cơ bản không hợp lệ. Vui lòng nhập một số nguyên dương.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return false;
        //    }

        //    return true;
        //}
        private bool ValidateInput_Them()
        {
            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Kiểm tra tên đăng nhập và loại bỏ tất cả khoảng trắng
            string tenDangNhap = txtTenDN.Text;
            tenDangNhap = Regex.Replace(tenDangNhap, @"\s+", "");
            // Cập nhật lại giá trị 
            txtTenDN.Text = tenDangNhap;
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tenDangNhap.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 ký tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra mật khẩu và loại bỏ tất cả khoảng trắng
            string matKhau = txtMatKhau.Text;
            matKhau = Regex.Replace(matKhau, @"\s+", "");
            txtMatKhau.Text = matKhau;
            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số và không chứa ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra trùng số điện thoại
            if (nvbll.IsSDTDuplicate(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra trùng tên đăng nhập
            if (nvbll.IsTaiKhoanDuplicate(txtTenDN.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra ngày sinh và độ tuổi
            DateTime selectedDateOfBirth = txtNgaySinh.Value;
            int age = DateTime.Now.Year - selectedDateOfBirth.Year;
            if (selectedDateOfBirth > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải có tuổi từ 18 trở lên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra ngày vào làm
            DateTime today = DateTime.Today;
            DateTime minHireDate = selectedDateOfBirth.AddYears(18); // Ngày vào làm phải sau sinh nhật 18 tuổi

            if (txtNgayVaoLam.Value <= new DateTime(2003, 1, 19))
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày 19/01/2003 (ngày thành lập công ty).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgayVaoLam.Value > today)
            {
                MessageBox.Show("Ngày vào làm không được vượt quá ngày hôm nay.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgayVaoLam.Value < minHireDate)
            {
                MessageBox.Show($"Ngày vào làm không được nhỏ hơn ngày {minHireDate.ToString("dd/MM/yyyy")}, khi nhân viên đủ 18 tuổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra lương cơ bản
            if (string.IsNullOrWhiteSpace(txtLuong.Text) ||
                (!int.TryParse(txtLuong.Text.Replace(" VND", "").Replace(",", "").Trim(), out int luongCoBan)) ||
                luongCoBan <= 0)
            {
                MessageBox.Show("Lương cơ bản không hợp lệ. Vui lòng nhập một số nguyên dương.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidateInput_Sua(bool isUpdate = false, string oldPhoneNumber = "")
        {
            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra mật khẩu và loại bỏ tất cả khoảng trắng
            string matKhau = txtMatKhau.Text;
            matKhau = Regex.Replace(matKhau, @"\s+", "");
            txtMatKhau.Text = matKhau;
            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra xem mật khẩu có chứa khoảng trắng không
            if (matKhau.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số và không chứa ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Kiểm tra số điện thoại mới có trùng với số điện thoại của nhân viên khác không
            string newPhoneNumber = txtSDT.Text.Trim();
            if (oldPhoneNumber != newPhoneNumber && nvbll.IsSDTDuplicate(newPhoneNumber)) // Kiểm tra số điện thoại mới
            {
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống. Vui lòng nhập số điện thoại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Kiểm tra trùng tên đăng nhập
            if (nvbll.IsTaiKhoanDuplicate(txtTenDN.Text) && !isUpdate)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng nhập lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra ngày sinh và độ tuổi
            DateTime selectedDateOfBirth = txtNgaySinh.Value;
            int age = DateTime.Now.Year - selectedDateOfBirth.Year;
            if (selectedDateOfBirth > DateTime.Now.AddYears(-age)) age--;
            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải có tuổi từ 18 trở lên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra ngày vào làm
            DateTime today = DateTime.Today;
            DateTime minHireDate = selectedDateOfBirth.AddYears(18); // Ngày vào làm phải sau sinh nhật 18 tuổi

            if (txtNgayVaoLam.Value <= new DateTime(2003, 1, 19))
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày 19/01/2003 (ngày thành lập công ty).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgayVaoLam.Value > today)
            {
                MessageBox.Show("Ngày vào làm không được vượt quá ngày hôm nay.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtNgayVaoLam.Value < minHireDate)
            {
                MessageBox.Show($"Ngày vào làm không được nhỏ hơn ngày {minHireDate.ToString("dd/MM/yyyy")}, khi nhân viên đủ 18 tuổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            dgvNhanVien.ReadOnly = false;
            cboLoaiNV.DataSource = lnvbll.LoadLoaiNhanVien();
            cboLoaiNV.DisplayMember = "tenLoaiNhanVien";
            cboLoaiNV.ValueMember = "maLoaiNhanVien";
        }

        public void LoadNhanVien()
        {
            try
            {
                // Tải dữ liệu từ BLL
                List<NhanVien> nhanViens = nvbll.LoadNhanVien();
                dgvNhanVien.DataSource = nhanViens;
                if (dgvNhanVien.Columns["LoaiNhanVien"] != null)
                {
                    dgvNhanVien.Columns["LoaiNhanVien"].Visible = false;
                }
                if (dgvNhanVien.Columns["maLoaiNhanVien"] != null)
                {
                    dgvNhanVien.Columns["maLoaiNhanVien"].Visible = false; // Ẩn mã loại nhân viên
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            string maLoaiNV = cboLoaiNV.SelectedValue.ToString();
            if (!ValidateInput_Them())
            {
                return;
            }

            var nv = new NhanVien
            {
                tenNhanVien = txtTenNV.Text.Trim(),
                ngaySinh = txtNgaySinh.Value.Date,
                tenDangNhap = txtTenDN.Text.Trim(),
                matKhau = nvbll.MaHoaMatKhauKieuSha256Hash(txtMatKhau.Text.Trim()),
                ngayVaoLam = txtNgayVaoLam.Value.Date,
                soDienThoai = txtSDT.Text.Trim(),
                diaChi = txtDiaChi.Text.Trim(),
                luongCoBan = Convert.ToInt32(txtLuong.Text.Trim()),
                maLoaiNhanVien = maLoaiNV
            };

            try
            {
                bool kq = nvbll.InsertNhanVien(nv);
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadNhanVien();
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi khi không thể thêm nhân viên
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnThem.Enabled = false;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTenNV.Focus();
            //Enable true
            btnThem.Enabled = true;
            txtTenDN.Enabled = true;
            txtMatKhau.Enabled = true;
            //Enable false
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //load db 
            LoadNhanVien();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                string manv = dgvNhanVien.SelectedRows[0].Cells["maNhanVien"].Value.ToString();
                Debug.WriteLine($"Attempting to delete employee with ID: {manv}");

                if (nvbll.DeleteNhanVien(manv))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    Debug.WriteLine($"Failed to delete employee with ID: {manv}");
                }
                LoadNhanVien();
                SetForm();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            // Giả sử ID nhân viên được lưu trong một Label hoặc một field ẩn
            string maNV = txtMaNV.Text; // Hoặc từ biến đã lưu ID

            // Lấy số điện thoại cũ từ cơ sở dữ liệu
            string OldPhoneNumber = nvbll.GetPhoneNumberById(maNV);

            if (!ValidateInput_Sua(true, oldPhoneNumber: OldPhoneNumber))
            {
                return;
            }

            // Xử lý giá trị lương
            string luongText = txtLuong.Text.Replace(" VND", "").Replace(".", "").Trim();
            if (!int.TryParse(luongText, out int luongchuyendoi) || luongchuyendoi <= 0)
            {
                MessageBox.Show("Lương không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nv = new NhanVien
            {
                maNhanVien = txtMaNV.Text.Trim(),
                tenNhanVien = txtTenNV.Text.Trim(),
                ngaySinh = txtNgaySinh.Value.Date,
                tenDangNhap = txtTenDN.Text.Trim(),
                matKhau = nvbll.MaHoaMatKhauKieuSha256Hash(txtMatKhau.Text.Trim()),
                ngayVaoLam = txtNgayVaoLam.Value.Date,
                soDienThoai = txtSDT.Text.Trim(),
                diaChi = txtDiaChi.Text.Trim(),
                luongCoBan = luongchuyendoi,
                tenLoaiNhanVien = cboLoaiNV.Text.Trim(),
            };
            // Cập nhật cơ sở dữ liệu
            bool kq = nvbll.UpdateNhanVien(nv);
            if (kq)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"Cập nhật không thành công cho nhân viên: {nv.tenNhanVien}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    return;
            //}

            //Debug.WriteLine($"Giá trị lương trước khi xử lý: {txtLuong.Text}");
            //if (!ValidateInput_Sua(true))
            //{
            //    return;
            //}
            //// Xử lý giá trị lương
            //string luongText = txtLuong.Text.Replace(" VND", "").Replace(".", "").Trim();
            ///*Debug.WriteLine($"Giá trị lương sau khi loại bỏ ký tự a: {luongText}");*/ // kiểm tra giá trị sau khi xử lý

            //if (!int.TryParse(luongText, out int luongchuyendoi) || luongchuyendoi <= 0)
            //{
            //    MessageBox.Show("Lương không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            ////// Ghi log giá trị lương đã chuyển đổi
            ////Debug.WriteLine($"Giá trị lương đã chuyển đổi: {luongchuyendoi}");
            //var nv = new NhanVien
            //{
            //    maNhanVien = txtMaNV.Text.Trim(),
            //    tenNhanVien = txtTenNV.Text.Trim(),
            //    ngaySinh = txtNgaySinh.Value.Date,
            //    tenDangNhap = txtTenDN.Text.Trim(),
            //    matKhau = txtMatKhau.Text.Trim(),
            //    ngayVaoLam = txtNgayVaoLam.Value.Date,
            //    soDienThoai = txtSDT.Text.Trim(),
            //    diaChi = txtDiaChi.Text.Trim(),
            //    luongCoBan = luongchuyendoi,
            //    tenLoaiNhanVien = cboLoaiNV.Text.Trim(),
            //};
            ////Debug.WriteLine($"Thông tin nhân viên trước khi cập nhật: " +
            ////        $"Mã NV: {nv.maNhanVien}, Tên: {nv.tenNhanVien}, " +
            ////        $"Ngày sinh: {nv.ngaySinh}, Số điện thoại: {nv.soDienThoai}, " +
            ////        $"Lương cơ bản: {nv.luongCoBan}, Ngày vào làm: {nv.ngayVaoLam}");
            //bool kq = nvbll.UpdateNhanVien(nv);
            //if (kq)
            //{
            //    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Debug.WriteLine($"Giá trị lương sau khi loại bỏ ký tự: {txtLuong.Text}");
            //    ClearForm();
            //    LoadNhanVien();
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    MessageBox.Show($"Cập nhật không thành công cho nhân viên: {nv.tenNhanVien}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        private void dgvNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvNhanVien.ReadOnly = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanVien.Rows[e.RowIndex];
                // Lấy giá trị từ các ô trong hàng đã chọn (note: đặt tên name cho cột)
                string maNhanVien = selectedRow.Cells["maNhanVien"].Value.ToString();
                string tenNhanVien = selectedRow.Cells["tenNhanVien"].Value.ToString();
                DateTime ngaySinh = DateTime.Parse(selectedRow.Cells["ngaySinh"].Value.ToString());
                string diaChi = selectedRow.Cells["diaChi"].Value.ToString();
                string soDienThoai = selectedRow.Cells["soDienThoai"].Value.ToString();
                string tenDangNhap = selectedRow.Cells["tenDangNhap"].Value.ToString();
                string matKhau = selectedRow.Cells["matKhau"].Value.ToString();
                int luongCoBan = int.Parse(selectedRow.Cells["luongCoBan"].Value.ToString());
                DateTime ngayVaoLam = DateTime.Parse(selectedRow.Cells["ngayVaoLam"].Value.ToString());
                string maLoaiNhanVien = selectedRow.Cells["maLoaiNhanVien"].Value.ToString();

                // Cập nhật giá trị vào các TextBox
                txtMaNV.Text = maNhanVien;
                txtTenNV.Text = tenNhanVien;
                txtNgaySinh.Value = ngaySinh;
                txtDiaChi.Text = diaChi;
                txtSDT.Text = soDienThoai;
                txtTenDN.Text = tenDangNhap;
                txtMatKhau.Text = matKhau;
                txtLuong.Text = luongCoBan.ToString("N0").Replace(",", ".") + " VND";
                txtNgayVaoLam.Value = ngayVaoLam;
                cboLoaiNV.SelectedValue = maLoaiNhanVien; // Gán giá trị cho ComboBox
                SetDataGirdView();
            }
        }
        private void uiSymbolButton6_Click_1(object sender, EventArgs e)
        {
            frmLoaiNV loaiNhanVienForm = new frmLoaiNV();
            loaiNhanVienForm.ShowDialog();            
        }
        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            // Lấy kết quả tìm kiếm từ BLL
            var results = nvbll.SearchNhanVien(txtSearch.Text.Trim());

            // Kiểm tra kết quả trả về có hợp lệ không
            if (results != null && results.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                dgvNhanVien.DataSource = results;
            }
            else
            {
                // Nếu không tìm thấy kết quả, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa hết dữ liệu trong DataGridView nếu không có kết quả tìm kiếm
                dgvNhanVien.DataSource = null;
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
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
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {           
            txtMatKhau.Enabled = !txtMatKhau.Enabled;
        }
        private void txtNgaySinh_ValueChanged(object sender, DateTime value)
        {

        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập tên, địa chỉ, hoặc số điện thoại để tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor=Color.Black ;
                txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Nhập tên, địa chỉ, hoặc số điện thoại để tìm kiếm";
                txtSearch.ForeColor = Color.Silver;
                txtSearch.Font = new Font(txtSearch.Font, FontStyle.Italic);
                LoadNhanVien();
            }
        }
    }
}
