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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmKhachHang : Form
    {
        KhachHangBLL khbll = new KhachHangBLL();
        public frmKhachHang()
        {
            InitializeComponent();
            this.Load += frmKhachHang_Load;
            txtSearch.ForeColor = Color.Silver;
            txtHangTV.Enabled = false;
            SetForm();
        }
        public void SetForm()
        {
            txtMaKH.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtHangTV.Enabled = false;

        }
        public void SetDataGirdView()
        {
            //không cho phép thêm
            btnThem.Enabled = false;
            //cho phép sửa, xóa 
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            dgvKhachHang.Columns["maKhachHang"].ReadOnly = true;
            dgvKhachHang.Columns["tenKhachHang"].ReadOnly = true;
            dgvKhachHang.Columns["diaChi"].ReadOnly = true;
            dgvKhachHang.Columns["tenHang"].ReadOnly = true;
            dgvKhachHang.Columns["email"].ReadOnly = true;
            dgvKhachHang.Columns["soDienThoai"].ReadOnly = true;
            
           
            
        }
        private void ClearForm()
        {
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtHangTV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập tên, địa chỉ, hoặc số điện thoại để tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
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
                LoadKhachHang();

            }
        }

        private void btnSearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private string GetTenHangFromMaHang(string maHang)
        {
            // Giả sử bạn đã có phương thức này để lấy tên hạng từ mã hạng
            var tenHang = khbll.GetTenHangFromMaHang(maHang);  // Thực hiện truy vấn hoặc gọi đến BLL để lấy tên hạng
            return tenHang ?? string.Empty; // Trả về tên hạng hoặc chuỗi rỗng nếu không tìm thấy
        }
        public void LoadKhachHang()
        {
            try
            {
                // Tải dữ liệu từ BLL
                List<KhachHang> kh = khbll.LoadKhachHang();
                dgvKhachHang.DataSource = kh; ;

                if (dgvKhachHang.Columns["maHang"] != null)
                {
                    dgvKhachHang.Columns["maHang"].Visible = false; // Ẩn mã Hạng
                }
                if (dgvKhachHang.Columns["HangThanhVien"] != null)
                {
                    dgvKhachHang.Columns["HangThanhVien"].Visible = false; // Ẩn mã Hạng
                }
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInput_Them()
        {
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại (10 chữ số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số và không chứa ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra trùng số điện thoại
            if (khbll.IsSDTDuplicate(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra email
            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra định dạng email "example@gmail.com"
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Email phải có định dạng 'example@gmail.com'.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra trùng email
            //if (khbll.IsEmailDuplicate(txtEmail.Text))
            //{
            //    MessageBox.Show("Email đã tồn tại. Vui lòng lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return true;
        }


        private bool ValidateInput_Sua(bool isUpdate = false, string oldPhoneNumber = "")
        {
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại (10 chữ số)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải bao gồm đúng 10 chữ số và không chứa ký tự đặc biệt.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số điện thoại mới có trùng với số điện thoại của nhân viên khác không
            string newPhoneNumber = txtSDT.Text.Trim();
            if (oldPhoneNumber != newPhoneNumber) // Kiểm tra số điện thoại mới
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

            // Kiểm tra email
            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra định dạng email "example@gmail.com"
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@gmail\.com$"))
            {
                MessageBox.Show("Email phải có định dạng 'example@gmail.com'.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //// Kiểm tra email mới có trùng với email của nhân viên khác không
            //string newEmail = txtEmail.Text.Trim();
            //if (oldEmail != newEmail && khbll.IsEmailDuplicate(newEmail)) // Kiểm tra số điện thoại mới
            //{
            //    MessageBox.Show("Email này đã tồn tại trong hệ thống. Vui lòng nhập Email khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}


            return true;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            dgvKhachHang.ReadOnly = true;
            
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvKhachHang.ReadOnly = false;

            // Kiểm tra nếu người dùng click vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng đã chọn, đảm bảo không null
                string maKH = selectedRow.Cells["maKhachHang"].Value?.ToString() ?? string.Empty;
                string tenKH = selectedRow.Cells["tenKhachHang"].Value?.ToString() ?? string.Empty;
                string diaChi = selectedRow.Cells["diaChi"].Value?.ToString() ?? string.Empty;
                string soDienThoai = selectedRow.Cells["soDienThoai"].Value?.ToString() ?? string.Empty;
                string tenHang = selectedRow.Cells["tenHang"].Value?.ToString() ?? string.Empty;
                string email = selectedRow.Cells["email"].Value?.ToString() ?? string.Empty;
                //string maHang = selectedRow.Cells["maHang"].Value?.ToString() ?? string.Empty;

                // Cập nhật các TextBox với giá trị tương ứng từ các cột
                txtMaKH.Text = maKH;
                txtTenKH.Text = tenKH;
                txtDiaChi.Text = diaChi;
                txtHangTV.Text = tenHang;
                //txtHangTV.Text = tenHang;
                txtSDT.Text = soDienThoai;
                txtEmail.Text = email;

                // Nếu cần thiết, gọi lại hàm SetDataGirdView() sau khi cập nhật TextBox
                SetDataGirdView();
            }
            else
            {
                // Xử lý khi người dùng click vào tiêu đề cột hoặc ngoài hàng
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ.");
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                string makh = dgvKhachHang.SelectedRows[0].Cells["maKhachHang"].Value.ToString();
                //Debug.WriteLine($"Attempting with ID: {makh}");

                if (khbll.DeleteKhachHang(makh))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                   //Debug.WriteLine($"Failed to delete with ID: {makh}");
                }
                LoadKhachHang();
                SetForm();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy kết quả tìm kiếm từ BLL
            var results = khbll.SearchKhachHang(txtSearch.Text.Trim());

            // Kiểm tra kết quả trả về có hợp lệ không
            if (results != null && results.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                dgvKhachHang.DataSource = results;
            }
            else
            {
                // Nếu không tìm thấy kết quả, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy khách hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa hết dữ liệu trong DataGridView nếu không có kết quả tìm kiếm
                dgvKhachHang.DataSource = null;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTenKH.Focus();
            //Enable true
            btnThem.Enabled = true;
            //Enable false
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //load db 
            txtEmail.Text = "@gmail.com";
            LoadKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            if (!ValidateInput_Them())
            {
                return;
            }

            var kh = new KhachHang
            {
                maKhachHang = khbll.TaoMaKhachHangTuDong(),
                tenKhachHang = txtTenKH.Text.Trim(),
                soDienThoai = txtSDT.Text.Trim(),
                //diaChi = txtDiaChi.Text.Trim(),
                //email=txtEmail.Text.Trim(),
                maHang=txtHangTV.Text.Trim(),
            };

            try
            {
                bool kq = khbll.ThemKhachHang(kh);
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadKhachHang();

                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi khi không thể thêm 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            btnThem.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No )
            {
                return;
            }
            string maKH= txtMaKH.Text; // Hoặc từ biến đã lưu ID
            KhachHang khachHang = khbll.LayKHTheoMa(maKH);
            // Lấy số điện thoại cũ từ cơ sở dữ liệu
            string OldPhoneNumber = khachHang.soDienThoai;
            //string OldEmail = khbll.GetEmailById(maKH);
            //tham số , biến
            if (!ValidateInput_Sua(true, oldPhoneNumber: OldPhoneNumber))
            {
                return;
            }
            // Lấy email cũ từ cơ sở dữ liệu
            
            //tham số , biến
           
            // Cập nhật thông tin khách hàng
            var kh = new KhachHang
            {
                maKhachHang=txtMaKH.Text.Trim(),
                tenKhachHang = txtTenKH.Text.Trim(),
                soDienThoai = txtSDT.Text.Trim(),
                //diaChi = txtDiaChi.Text.Trim(),
                //email = txtEmail.Text.Trim(),
                tenHang = txtHangTV.Text.Trim(),
            };

            // Thực hiện cập nhật thông tin khách hàng
            bool kq = khbll.CapNhatKhachHang(kh);
            if (kq)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txtHangTV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSDT.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
