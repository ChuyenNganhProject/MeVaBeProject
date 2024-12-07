using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmHangThanhVien : Form
    {
        HangThanhVienBLL htvbll = new HangThanhVienBLL();
        public frmHangThanhVien()
        {
            InitializeComponent();
            this.Load += frmHangThanhVien_Load;
            txtSearch.ForeColor = Color.Silver;
            SetForm();
            LoadTextMTBD();
        }
        public void SetForm()
        {
            txtMaHang.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMucTieubd.Enabled = false;
        }
        public void SetDataGirdView()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //dgvKhachHang.Columns["maKhachHang"].ReadOnly = true;
        }
        private void ClearForm()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMucTieubd.Text = "";
            txtMucTieukt.Text = "";
            txtGhichu.Text = "";
        }
        public void SetDisEnableText()
        {
            txtMucTieubd.Enabled = false;
            txtMucTieubd.Enabled = false;
        }
        private void LoadTextMTBD()
        {
            decimal mucTieuBatDauValue = 0;
            if (dgvHangThanhVien.Rows.Count > 0)
            {
                // Lấy giá trị mục tiêu từ hàng cuối trong DataGridView
                var lastRow = dgvHangThanhVien.Rows[dgvHangThanhVien.Rows.Count - 1];
                if (decimal.TryParse(lastRow.Cells["mucTieuKetThuc"].Value?.ToString(), out decimal lastMucTieuKetThuc))
                {
                    mucTieuBatDauValue = lastMucTieuKetThuc + 1;
                }
            }
            // Cập nhật giá trị vào TextBox
            txtMucTieubd.Text = mucTieuBatDauValue.ToString();
        }
        public void LoadHangTV()
        {
            try
            {
                List<HangThanhVien> loainhanViens = htvbll.LoadHangTV();
                dgvHangThanhVien.DataSource = loainhanViens;
                // Thiết lập chế độ tự động điều chỉnh kích thước cột
                dgvHangThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmHangThanhVien_Load(object sender, EventArgs e)
        {
            LoadHangTV();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị hộp thoại xác nhận---------------
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                //Kiểm tra điều kiện ------------------------
                if (string.IsNullOrEmpty(txtTenHang.Text.Trim()) ||
                    string.IsNullOrEmpty(txtMucTieukt.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin cho các trường bắt buộc.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi MTC từ TextBox
                if (!decimal.TryParse(txtMucTieukt.Text.Trim(), out decimal mucTieuKetThucValue))
                {
                    MessageBox.Show("Mức tiêu kết thúc phải là một số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Kiểm tra nếu không có hàng trước đó (lấy tự động cho mục tiêu bắt đầu)---------
                decimal mucTieuBatDauValue;
                if (dgvHangThanhVien.Rows.Count > 0)
                {
                    // Lấy MTC từ hàng cuối trong DataGridView
                    var lastRow = dgvHangThanhVien.Rows[dgvHangThanhVien.Rows.Count - 1];
                    if (decimal.TryParse(lastRow.Cells["mucTieuKetThuc"].Value?.ToString(), out decimal lastMucTieuKetThuc))
                    {
                        mucTieuBatDauValue = lastMucTieuKetThuc + 1;
                        txtMucTieubd.Text = mucTieuBatDauValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy giá trị Mục tiêu kết thúc từ hàng cuối. Vui lòng kiểm tra lại dữ liệu.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu trước đó. Vui lòng nhập hàng đầu tiên thủ công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Insert-----------------------
                var maHang = htvbll.GenerateNewHangTV();
                txtMaHang.Text = maHang;
                var htv = new HangThanhVien
                {
                    maHang = maHang,
                    tenHang = txtTenHang.Text.Trim(),
                    mucTieuBatDau = mucTieuBatDauValue,
                    mucTieuKetThuc = mucTieuKetThucValue,
                    ghiChu = txtGhichu.Text.Trim()
                };
                try
                {
                    bool isValid = htvbll.ValidateNewHang(htv.maHang, (decimal)htv.mucTieuBatDau, (decimal)htv.mucTieuKetThuc);
                    if (!isValid)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng kiểm tra mức tiêu bắt đầu và kết thúc.", "Lỗi kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception validationEx)
                {
                    MessageBox.Show($"{validationEx.Message}", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Thêm 
                bool kq = htvbll.InsertHangTV(htv);
                if (kq)
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadHangTV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu.", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}\nChi tiết lỗi: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Region Nhập tay cho hai trường muctieubt và muctieuketthuc
            #region
            //Chuẩn 
            //try
            //{
            //    // Hiển thị hộp thoại xác nhận
            //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.No)
            //    {
            //        return;
            //    }

            //    // Kiểm tra đầu vào
            //    if (string.IsNullOrEmpty(txtTenHang.Text.Trim()) ||
            //        string.IsNullOrEmpty(txtMucTieubd.Text.Trim()) ||
            //        string.IsNullOrEmpty(txtMucTieukt.Text.Trim()))
            //    {
            //        MessageBox.Show("Vui lòng điền đầy đủ thông tin cho các trường.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Kiểm tra và chuyển đổi mức tiêu bắt đầu
            //    if (!decimal.TryParse(txtMucTieubd.Text.Trim(), out decimal mucTieuBatDauValue))
            //    {
            //        MessageBox.Show("Mức tiêu bắt đầu phải là một số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    if (!decimal.TryParse(txtMucTieukt.Text.Trim(), out decimal mucTieuKetThucValue))
            //    {
            //        MessageBox.Show("Mức tiêu kết thúc phải là một số hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    //// Tạo mã tự động
            //    //var maHang = htvbll.TaoMaHangTV();
            //    //txtMaHang.Text = maHang;

            //    // Tạo đối tượng HangThanhVien
            //    var htv = new HangThanhVien
            //    {
            //        maHang = txtMaHang.Text.Trim(),
            //        tenHang = txtTenHang.Text.Trim(),
            //        mucTieuBatDau = mucTieuBatDauValue,
            //        mucTieuKetThuc = mucTieuKetThucValue,
            //        ghiChu = txtGhichu.Text.Trim()
            //    };

            //    // Validate dữ liệu trước khi thêm
            //    try
            //    {
            //        bool isValid = htvbll.ValidateNewHang(htv.maHang, (decimal)htv.mucTieuBatDau, (decimal)htv.mucTieuKetThuc);
            //        if (!isValid)
            //        {
            //            MessageBox.Show("Dữ liệu không hợp lệ! Vui lòng kiểm tra mức tiêu bắt đầu và kết thúc.", "Lỗi kiểm tra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            return;
            //        }
            //    }
            //    catch (Exception validationEx)
            //    {
            //        // Hiển thị lỗi từ ValidateNewHang
            //        MessageBox.Show($"Lỗi xác thực dữ liệu: {validationEx.Message}", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    // Thêm dữ liệu qua BLL
            //    bool kq = htvbll.InsertHangTV(htv);
            //    if (kq)
            //    {
            //        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        ClearForm(); // Làm mới form sau khi thêm thành công
            //        LoadHangTV(); // Tải lại dữ liệu hiển thị
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm không thành công! Vui lòng kiểm tra lại dữ liệu.", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    // Hiển thị lỗi chi tiết nếu có
            //    MessageBox.Show($"Lỗi hệ thống: {ex.Message}\nChi tiết lỗi: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    btnThem.Enabled = true; // Đảm bảo nút được kích hoạt lại
            //}
            #endregion
        }
        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập mã hạng hoặc tên hạng")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                txtSearch.Font = new Font(txtSearch.Font, FontStyle.Regular);
            }
        }
        private void txtSearch_Leave_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Nhập mã hạng hoặc tên hạng";
                txtSearch.ForeColor = Color.Silver;
                txtSearch.Font = new Font(txtSearch.Font, FontStyle.Italic);
                LoadHangTV();
            }
        }
        private void dgvHangThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 
            //Chuẩn 
            dgvHangThanhVien.ReadOnly = true;

            // Kiểm tra nếu người dùng click vào một hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dgvHangThanhVien.Rows[e.RowIndex];

                // Lấy giá trị từ các ô trong hàng đã chọn, đảm bảo không null
                string maH = selectedRow.Cells["maHang"].Value?.ToString() ?? string.Empty;
                string tenH = selectedRow.Cells["tenHang"].Value?.ToString() ?? string.Empty;
                //string diaChi = selectedRow.Cells["diaChi"].Value?.ToString() ?? string.Empty;
                decimal mtbd = decimal.Parse(selectedRow.Cells["mucTieuBatDau"].Value.ToString());
                decimal mtkt = decimal.Parse(selectedRow.Cells["mucTieuKetThuc"].Value.ToString());
                string ghichu = selectedRow.Cells["ghiChu"].Value?.ToString() ?? string.Empty;

                // Cập nhật các TextBox với giá trị tương ứng từ các cột
                txtMaHang.Text = maH;
                txtTenHang.Text = tenH;
                txtMucTieubd.Text = mtbd.ToString("N0").Replace(",", ".");
                txtMucTieukt.Text = mtkt.ToString("N0").Replace(",", ".");
                //txtHangTV.Text = tenHang;
                txtGhichu.Text = ghichu;
                // Nếu cần thiết, gọi lại hàm SetDataGirdView() sau khi cập nhật TextBox
                SetDataGirdView();
                SetDisEnableText();
            }
            else
            {
                // Xử lý khi người dùng click vào tiêu đề cột hoặc ngoài hàng
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ.");
            }
            #endregion
        }
        private void dgvHangThanhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (decimal.TryParse(e.Value.ToString(), out decimal value))
            {
                // Định dạng số với dấu chấm và thêm "VND"
                e.Value = value.ToString("N0").Replace(",", ".") + " VND";
                //e.Value = value.ToString("N0").Replace(",", ".");
                e.FormattingApplied = true;
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTenHang.Focus();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            LoadHangTV();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hạng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (dgvHangThanhVien.SelectedRows.Count > 0)
            {
                string maH = dgvHangThanhVien.SelectedRows[0].Cells["maHang"].Value.ToString();
                string hienthiloi;
                if (htvbll.DeleteHangTV(maH, out hienthiloi))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    //hien thi thong bao loi
                    MessageBox.Show(hienthiloi);
                }
                LoadHangTV();
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
            var results = htvbll.SearchHangTV(txtSearch.Text.Trim());

            // Kiểm tra kết quả trả về có hợp lệ không
            if (results != null && results.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                dgvHangThanhVien.DataSource = results;
            }
            else
            {
                // Nếu không tìm thấy kết quả, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy hạng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtTenHang.Text.Trim()))
            {
                MessageBox.Show("Tên hạng thành viên không được bỏ trống.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal muctieubd = decimal.Parse(txtMucTieubd.Text.Trim());
            decimal muctieukt = decimal.Parse(txtMucTieukt.Text.Trim());
            var kh = new HangThanhVien
            {
                maHang = txtMaHang.Text.Trim(),
                tenHang = txtTenHang.Text.Trim(),
                mucTieuBatDau = muctieubd,
                mucTieuKetThuc = muctieukt,
                ghiChu = txtGhichu.Text.Trim()
            };
            try
            {
                bool kq = htvbll.UpdateHangTV(kh);
                if (kq)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadHangTV();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
        private void txtMucTieubd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMucTieubd.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtMucTieukt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMucTieukt.Text.Length >= 15 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private string FormatLuong(string input)
        {
            // Loại bỏ tất cả dấu chấm hiện có
            input = input.Replace(".", "");

            // Nếu không phải là số thì trả về input ban đầu
            if (!long.TryParse(input, out long luong))
                return input;

            // Chia thành các nhóm ba chữ số và thêm dấu chấm vào giữa
            string formatted = "";
            int count = 0;

            // Duyệt ngược từ cuối chuỗi và chèn dấu chấm sau mỗi 3 chữ số
            for (int i = input.Length - 1; i >= 0; i--)
            {
                formatted = input[i] + formatted;
                count++;

                // Thêm dấu chấm sau mỗi ba chữ số nếu không phải là ký tự đầu tiên
                if (count % 3 == 0 && i > 0)
                {
                    formatted = "." + formatted;
                }
            }
            return formatted;
        }
        private void txtMucTieubd_TextChanged(object sender, EventArgs e)
        {
            // Lưu vị trí con trỏ hiện tại
            int cursorPosition = txtMucTieubd.SelectionStart;

            // Loại bỏ dấu chấm (nếu có) để xử lý lại
            string input = txtMucTieubd.Text.Replace(".", "");

            // Định dạng lại chuỗi với dấu chấm
            string formatted = FormatLuong(input);

            // Cập nhật lại giá trị vào textbox
            txtMucTieubd.Text = formatted;

            // Đặt lại vị trí con trỏ vào cuối
            txtMucTieubd.SelectionStart = cursorPosition + 1;
        }
        private void txtMucTieukt_TextChanged(object sender, EventArgs e)
        {
            // Lưu vị trí con trỏ hiện tại
            int cursorPosition = txtMucTieukt.SelectionStart;

            // Loại bỏ dấu chấm (nếu có) để xử lý lại
            string input = txtMucTieukt.Text.Replace(".", "");

            // Định dạng lại chuỗi với dấu chấm
            string formatted = FormatLuong(input);

            // Cập nhật lại giá trị vào textbox
            txtMucTieukt.Text = formatted;

            // Đặt lại vị trí con trỏ vào cuối
            txtMucTieukt.SelectionStart = cursorPosition + 1;
        }
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
