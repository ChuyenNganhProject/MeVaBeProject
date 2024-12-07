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
        private NhanVien nhanVien;
        private ChiTietQuyenCuaLoaiNVBLL ctQuyen;
        private bool QuyenQLKhachHang;
        private bool QuyenQLHangThanhVien;
        public frmKhachHang(NhanVien nhanVien)
        {
            InitializeComponent();
            this.Load += frmKhachHang_Load;
            txtSearch.ForeColor = Color.Silver;
            txtHangTV1.Enabled = false;
            this.txtSDT1.KeyPress += txtSDT1_KeyPress;
            SetForm();
            DateTime currentDate = DateTime.Now.Date;
            txtNgayTichLuyDiem1.Text = currentDate.ToString("dd/MM/yyyy");
            txtNgayTichLuyDiem1.Enabled = false;
            this.nhanVien = nhanVien;
            this.ctQuyen= new ChiTietQuyenCuaLoaiNVBLL();
        }
        public void SetForm()
        {
            txtMaKH1.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtHangTV1.Enabled = false;
        }
        public void SetDataGirdView()
        {
            //không cho phép thêm
            btnThem.Enabled = false;
            //cho phép sửa, xóa 
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //dgvKhachHang.Columns["maKhachHang"].ReadOnly = true;
            //dgvKhachHang.Columns["tenKhachHang"].ReadOnly = true;
            //dgvKhachHang.Columns["diaChi"].ReadOnly = true;
            //dgvKhachHang.Columns["tenHang"].ReadOnly = true;
            //dgvKhachHang.Columns["email"].ReadOnly = true;
            //dgvKhachHang.Columns["soDienThoai"].ReadOnly = true;
        }
        private void ClearForm()
        {
            txtTenKH1.Text = "";
            txtMaKH1.Text = "";
            txtHangTV1.Text = "";
            txtSDT1.Text = "";
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
            // Kiểm tra tên 
            if (string.IsNullOrWhiteSpace(txtTenKH1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT1.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại (10 chữ số)
            if (txtSDT1.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải  đúng 10 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra trùng số điện thoại
            if (khbll.IsSDTDuplicate(txtSDT1.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số điện thoại khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private bool ValidateInput_Sua(bool isUpdate = false, string oldPhoneNumber = "")
        {
            // Kiểm tra tên 
            if (string.IsNullOrWhiteSpace(txtTenKH1.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(txtSDT1.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra định dạng số điện thoại (10 chữ số)
            if (txtSDT1.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải  đúng 10 chữ số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra số điện thoại mới có trùng với số điện thoại của nhân viên khác không
            string newPhoneNumber = txtSDT1.Text.Trim();
            if (oldPhoneNumber != newPhoneNumber && khbll.IsSDTDuplicate(newPhoneNumber)) // Kiểm tra số điện thoại mới
            {
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống. Vui lòng nhập số điện thoại khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            dgvKhachHang.ReadOnly = true;
            QuyenQLKhachHang = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0008") != null) ? true : false;
            if (!QuyenQLKhachHang)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLamMoi.Enabled = false;              
            }
            QuyenQLHangThanhVien = (ctQuyen.TimQuyenCuaNhanVien(nhanVien.maLoaiNhanVien, "Q0009") != null) ? true : false;
            if (!QuyenQLHangThanhVien)
            {
                btnHangThanhViieen.Enabled = false;
            }
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvKhachHang.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng đã chọn, đảm bảo không null
                string maKH = selectedRow.Cells["maKhachHang"].Value.ToString();
                string tenKH = selectedRow.Cells["tenKhachHang"].Value.ToString();
                string soDienThoai = selectedRow.Cells["soDienThoai"].Value.ToString();
                string tenHang = selectedRow.Cells["tenHang"].Value.ToString();
                decimal diemTL = selectedRow.Cells["diemTichLuy"].Value != null ? Convert.ToDecimal(selectedRow.Cells["diemTichLuy"].Value) : 0;
                DateTime ngayTLD = selectedRow.Cells["ngayCapNhatDiem"].Value != null ? DateTime.Parse(selectedRow.Cells["ngayCapNhatDiem"].Value.ToString()) : DateTime.Now;
                //string maHang = selectedRow.Cells["maHang"].Value?.ToString() ?? string.Empty;

                // Cập nhật các TextBox với giá trị tương ứng từ các cột
                txtMaKH1.Text = maKH;
                txtTenKH1.Text = tenKH;
                txtdiemTichLuy1.Text = diemTL.ToString();
                txtHangTV1.Text = tenHang;
                txtSDT1.Text = soDienThoai;
                txtNgayTichLuyDiem1.Value = ngayTLD;

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

                if (khbll.DeleteKhachHang(makh))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
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
            txtTenKH1.Focus();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
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

            var maKhachHang = khbll.TaoMaKhachHangTuDong();
            txtMaKH1.Text = maKhachHang;
            var ngayCapNhatDiem = DateTime.Today;

            decimal diemTichLuy = 0;
            var kh = new KhachHang
            {
                maKhachHang = maKhachHang,
                tenKhachHang = txtTenKH1.Text.Trim(),
                soDienThoai = txtSDT1.Text.Trim(),
                diemTichLuy = diemTichLuy,
                maHang = "HTV001",
                ngayCapNhatDiem = ngayCapNhatDiem
            };

            try
            {
                bool kq = khbll.ThemKhachHang(kh);
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadKhachHang();
                    btnThem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi khi không thể thêm 
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            btnThem.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //// Hỏi người dùng xác nhận trước khi sửa
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    return;
            //}
            //string maKH = txtMaKH1.Text; // Hoặc từ biến đã lưu ID

            //// Lấy số điện thoại cũ từ cơ sở dữ liệu
            ////string OldPhoneNumber = khachHang.soDienThoai;
            ////string OldEmail = khbll.GetEmailById(maKH);
            ////tham số , biến
            //string OldPhoneNumber = khbll.GetPhoneNumberById(maKH);
            //if (!ValidateInput_Sua(oldPhoneNumber: OldPhoneNumber))
            //{
            //    return;
            //}
            //// Lấy email cũ từ cơ sở dữ liệu

            ////tham số , biến

            //// Cập nhật thông tin khách hàng
            //var kh = new KhachHang
            //{
            //    maKhachHang = txtMaKH1.Text.Trim(),
            //    tenKhachHang = txtTenKH1.Text.Trim(),
            //    soDienThoai = txtSDT1.Text.Trim(),
            //    diemTichLuy = int.Parse(txtdiemTichLuy11.Text.Trim()),
            //    //diaChi = txtDiaChi.Text.Trim(),
            //    //email = txtEmail.Text.Trim(),
            //    ngayCapNhatDiem= txtNgayTichLuyDiem1.Value.Date,
            //    tenHang = txtHangTV1.Text.Trim(),
            //};

            //// Thực hiện cập nhật thông tin khách hàng

            //bool kq = khbll.CapNhatKhachHang(kh);
            //if (kq)
            //{
            //    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    ClearForm();
            //    LoadKhachHang();
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


            //// Hỏi người dùng xác nhận trước khi sửa
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    return;
            //}

            //// Lấy mã khách hàng từ TextBox
            //string maKH = txtMaKH1.Text;
            //Debug.WriteLine($"Mã khách hàng: {maKH}");  // Debug: In ra mã khách hàng

            //// Lấy số điện thoại cũ từ cơ sở dữ liệu
            //string OldPhoneNumber = khbll.GetPhoneNumberById(maKH);
            //Debug.WriteLine($"Số điện thoại cũ: {OldPhoneNumber}");  // Debug: In ra số điện thoại cũ

            //// Kiểm tra đầu vào sửa
            //if (!ValidateInput_Sua(oldPhoneNumber: OldPhoneNumber))
            //{
            //    MessageBox.Show("Dữ liệu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Debug: In các thông tin đầu vào
            //Debug.WriteLine($"Tên khách hàng: {txtTenKH1.Text.Trim()}");
            //Debug.WriteLine($"Số điện thoại mới: {txtSDT1.Text.Trim()}");
            //Debug.WriteLine($"Điểm tích lũy: {txtdiemTichLuy1.Text.Trim()}");
            //Debug.WriteLine($"Ngày cập nhật điểm: {txtNgayTichLuyDiem1.Value.Date}");
            //Debug.WriteLine($"Tên hạng: {txtHangTV1.Text.Trim()}");

            //// Cập nhật thông tin khách hàng
            //var kh = new KhachHang
            //{
            //    maKhachHang = txtMaKH1.Text.Trim(),
            //    tenKhachHang = txtTenKH1.Text.Trim(),
            //    soDienThoai = txtSDT1.Text.Trim(),
            //    diemTichLuy = int.Parse(txtdiemTichLuy1.Text.Trim()),  // Kiểm tra việc chuyển đổi điểm tích lũy
            //    ngayCapNhatDiem = txtNgayTichLuyDiem1.Value.Date,
            //    tenHang = txtHangTV1.Text.Trim(),
            //};

            //// Debug: In thông tin khách hàng đã cập nhật
            //Debug.WriteLine($"Thông tin khách hàng sau khi cập nhật: {kh.tenKhachHang}, {kh.soDienThoai}, {kh.diemTichLuy}, {kh.tenHang}");

            //// Thực hiện cập nhật thông tin khách hàng
            //try
            //{
            //    bool kq = khbll.CapNhatKhachHang(kh);
            //    if (kq)
            //    {
            //        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ClearForm();
            //        LoadKhachHang();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // In lỗi ra nếu có
            //    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Debug.WriteLine($"Lỗi: {ex.Message}");  // Debug: In thông báo lỗi
            //}

            // Hỏi người dùng xác nhận trước khi sửa
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    return;
            //}

            //// Lấy mã khách hàng từ TextBox
            //string maKH = txtMaKH1.Text;
            //Debug.WriteLine($"Mã khách hàng: {maKH}");  // Debug: In ra mã khách hàng

            //// Lấy số điện thoại cũ từ cơ sở dữ liệu
            //string OldPhoneNumber = khbll.GetPhoneNumberById(maKH);
            //Debug.WriteLine($"Số điện thoại cũ: {OldPhoneNumber}");  // Debug: In ra số điện thoại cũ

            //// Kiểm tra đầu vào sửa
            //if (!ValidateInput_Sua(oldPhoneNumber: OldPhoneNumber))
            //{
            //    MessageBox.Show("Dữ liệu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Debug: In các thông tin đầu vào
            //Debug.WriteLine($"Tên khách hàng: {txtTenKH1.Text.Trim()}");
            //Debug.WriteLine($"Số điện thoại mới: {txtSDT1.Text.Trim()}");
            //Debug.WriteLine($"Điểm tích lũy: {txtdiemTichLuy1.Text.Trim()}");
            //Debug.WriteLine($"Ngày cập nhật điểm: {txtNgayTichLuyDiem1.Value.Date}");
            //Debug.WriteLine($"Tên hạng: {txtHangTV1.Text.Trim()}");

            //// Xử lý giá trị diemTichLuy (kiểm tra xem có phải kiểu decimal không)
            ////decimal diemTichLuy = 0m;  // Giá trị mặc định là 0m (decimal)
            ////if (!decimal.TryParse(txtdiemTichLuy1.Text.Trim(), out diemTichLuy))
            ////{
            ////    MessageBox.Show("Điểm tích lũy không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    return;
            ////}

            //// Cập nhật thông tin khách hàng
            //var kh = new KhachHang
            //{
            //    maKhachHang = txtMaKH1.Text.Trim(),
            //    tenKhachHang = txtTenKH1.Text.Trim(),
            //    soDienThoai = txtSDT1.Text.Trim(),
            //    //diemTichLuy = diemTichLuy,  // Sử dụng decimal cho diemTichLuy
            //    //ngayCapNhatDiem = txtNgayTichLuyDiem1.Value.Date,
            //    tenHang = txtHangTV1.Text.Trim(),
            //};

            //// Debug: In thông tin khách hàng đã cập nhật
            //Debug.WriteLine($"Thông tin khách hàng sau khi cập nhật: {kh.tenKhachHang}, {kh.soDienThoai}, {kh.diemTichLuy}, {kh.tenHang}");

            //// Thực hiện cập nhật thông tin khách hàng
            //try
            //{
            //    bool kq = khbll.CapNhatKhachHang(kh);
            //    if (kq)
            //    {
            //        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ClearForm();
            //        LoadKhachHang();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // In lỗi ra nếu có
            //    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Debug.WriteLine($"Lỗi: {ex.Message}");  // Debug: In thông báo lỗi
            //}

            // Hỏi người dùng xác nhận trước khi sửa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }


            string maKH = txtMaKH1.Text;
            //Debug.WriteLine($"Mã khách hàng: {maKH}"); 

            // Lấy số điện thoại cũ từ cơ sở dữ liệu
            string OldPhoneNumber = khbll.GetPhoneNumberById(maKH);
            //Debug.WriteLine($"Số điện thoại cũ: {OldPhoneNumber}");  

            // Kiểm tra đầu vào sửa
            if (!ValidateInput_Sua(oldPhoneNumber: OldPhoneNumber))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal diemTichLuy = decimal.Parse(txtdiemTichLuy1.Text.Trim());
            // Cập nhật thông tin khách hàng mà không cập nhật điểm tích lũy
            var kh = new KhachHang
            {
                maKhachHang = txtMaKH1.Text.Trim(),
                tenKhachHang = txtTenKH1.Text.Trim(),
                soDienThoai = txtSDT1.Text.Trim(),
                diemTichLuy = diemTichLuy,
                ngayCapNhatDiem = txtNgayTichLuyDiem1.Value.Date,
                tenHang = txtHangTV1.Text.Trim(),
            };

            //// Debug: In thông tin khách hàng đã cập nhật
            //Debug.WriteLine($"Thông tin khách hàng sau khi cập nhật: {kh.tenKhachHang}, {kh.soDienThoai}, {kh.tenHang}");


            try
            {
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
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSDT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSDT1.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //private void txtHangTV_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (txtSDT.Text.Length >= 10 && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //    else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
        private void btnHangThanhViieen_Click(object sender, EventArgs e)
        {
            frmHangThanhVien frm = new frmHangThanhVien();
            frm.ShowDialog();

        }
    }
}
