using BLL;
using DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmLapPhieuGiaoHang : Form
    {
        private string placeholderText = "Tìm kiếm theo mã hóa đơn";
        private Color placeholderColor = Color.Gray;
        private Color textColor = Color.Black;

        private string maNhanVien;
        private string MaHD;
        private string MaPGSauKhiHuyPhieu;

        List<ChiTietPhieuGiaoHang> chiTietPhieuGiaoHangList = new List<ChiTietPhieuGiaoHang>();
        private List<SanPhamGiao> danhSachSanPhamGiao = new List<SanPhamGiao>();

        HoaDonBLL hdbll = new HoaDonBLL();
        ChiTietHoaDonSanPhamBLL cthdbll = new ChiTietHoaDonSanPhamBLL();
        PhieuGiaoHangBLL pgbll = new PhieuGiaoHangBLL();
        ChiTietPhieuGiaoBLL ctpgbll = new ChiTietPhieuGiaoBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        KhachHangBLL khbll = new KhachHangBLL();
        public frmLapPhieuGiaoHang(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;

            this.Load += FrmLapPhieuGiaoHang_Load;

            this.btnBack.Click += BtnBack_Click;
            this.btnClose.Click += BtnClose_Click;
            this.btnPhongToThuNho.Click += BtnPhongToThuNho_Click;
            this.btnMinimize.Click += BtnMinimize_Click;

            // Bên hóa đơn
            this.dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            this.btnXacNhanMaHD.Click += BtnXacNhanMaHD_Click;
            this.btnHuyMaHD.Click += BtnHuyMaHD_Click;
            this.dgvHoaDon.CellFormatting += DgvHoaDon_CellFormatting;
            this.dgvDSSP.CellFormatting += DgvDSSP_CellFormatting;
            this.btnLocTheoNgay.Click += BtnLocTheoNgay_Click;
            this.dtpNgayBatDau.ValueChanged += DtpNgayBatDau_ValueChanged;
            this.dtpNgayKetThuc.ValueChanged += DtpNgayKetThuc_ValueChanged;
            this.dtpNgayBatDau.MaxDate = DateTime.Now.Date;
            this.dtpNgayKetThuc.MaxDate = DateTime.Now.Date;
            this.btnLocHienTai.Click += BtnLocHienTai_Click;
            this.btnTimKiem.Click += BtnTimKiem_Click;

            // Các button khác
            this.btnInPhieuGiao.Click += BtnInPhieuGiao_Click;
            this.btnXacNhanPhieuGiao.Click += BtnXacNhanPhieuGiao_Click;
            this.btnHuyPhieuGiao.Click += BtnHuyPhieuGiao_Click;

            this.btnThemSPVaoPhieuGiao.Click += BtnThemSPVaoPhieuGiao_Click;
            this.btnXoaSPTrongPhieuGiao.Click += BtnXoaSPTrongPhieuGiao_Click;
            this.btnLuuPhieuGiao.Click += BtnLuuPhieuGiao_Click;

            // TT Phiếu giao
            this.dgvSanPhamGiao.CellFormatting += DgvSanPhamGiao_CellFormatting;
            this.txtTenKhachHang.KeyPress += TxtTenKhachHang_KeyPress;
            this.txtSDT.KeyPress += TxtSDT_KeyPress;
            this.numericSoLuongSp.ValueChanged += NumericSoLuongSp_ValueChanged;
            this.dgvSanPhamGiao.SelectionChanged += DgvSanPhamGiao_SelectionChanged;
            this.dgvSanPhamGiao.CellValueChanged += DgvSanPhamGiao_CellValueChanged;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm theo mã hóa đơn")
            {
                txtTimKiem.Text = "";
            }
            string giaTriTimKiem = txtTimKiem.Text.Trim();
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            LoadDanhSachHoaDon("Mã hóa đơn", giaTriTimKiem, ngayBatDau, ngayKetThuc, "Loại khách hàng");
            if(!string.IsNullOrEmpty(giaTriTimKiem))
            {
                txtTimKiem.Text = giaTriTimKiem;
            }
            else
            {
                txtTimKiem.Text = "Tìm kiếm theo mã hóa đơn";
            }
        }

        private void BtnLocHienTai_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm theo mã hóa đơn")
            {
                txtTimKiem.Text = "";
            }
            this.dtpNgayKetThuc.Value = DateTime.Now.Date;
            this.dtpNgayBatDau.Value = DateTime.Now.Date;
            string giaTriTimKiem = txtTimKiem.Text.Trim();
            DateTime ngayBatDau = DateTime.Now.Date;
            DateTime ngayKetThuc = DateTime.Now.Date;
            LoadDanhSachHoaDon("Mã hóa đơn", giaTriTimKiem, ngayBatDau, ngayKetThuc, "Loại khách hàng");
            if (!string.IsNullOrEmpty(giaTriTimKiem))
            {
                txtTimKiem.Text = giaTriTimKiem;
            }
            else
            {
                txtTimKiem.Text = "Tìm kiếm theo mã hóa đơn";
            }
        }

        private void DtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                this.dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
            }
        }

        private void DtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                this.dtpNgayBatDau.Value = dtpNgayKetThuc.Value;
            }
        }

        private void BtnLocTheoNgay_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text == "Tìm kiếm theo mã hóa đơn")
            {
                txtTimKiem.Text = "";
            }
            string giaTriTimKiem = txtTimKiem.Text.Trim();
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;
            LoadDanhSachHoaDon("Mã hóa đơn", giaTriTimKiem, ngayBatDau, ngayKetThuc, "Loại khách hàng");
            if (!string.IsNullOrEmpty(giaTriTimKiem))
            {
                txtTimKiem.Text = giaTriTimKiem;
            }
            else
            {
                txtTimKiem.Text = "Tìm kiếm theo mã hóa đơn";
            }
        }

        private void NumericSoLuongSp_ValueChanged(object sender, EventArgs e)
        {
            string maSp = txtMaSPGiao.Text;
            if(!string.IsNullOrEmpty(maSp))
            {
                foreach (var item in danhSachSanPhamGiao) 
                {
                    if (item.MaSanPham == maSp)
                    {
                        item.SoLuong = (int)numericSoLuongSp.Value;
                        item.TongTien = item.SoLuong * item.DonGia;
                        break;
                    }
                }
                CapNhatDgvSanPhamGiao();
                CapNhatTongTienCuaSP();
            }
        }

        private void DgvSanPhamGiao_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvSanPhamGiao.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dgvSanPhamGiao.SelectedRows)
                {
                    string maSp = selectedRow.Cells["maSanPhamGiao"].Value.ToString();
                    txtMaSPGiao.Text = maSp;
                    ChiTietHoaDonSanPham sp = cthdbll.LayTTSanPhamTrongHoaDon(maSp, MaHD);
                    numericSoLuongSp.Maximum = sp.soLuong.Value;
                    numericSoLuongSp.Enabled = true;
                    numericSoLuongSp.Value = int.Parse(selectedRow.Cells["soLuongGiao"].Value.ToString());
                }
            }
        }

        private void BtnHuyMaHD_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn muốn hủy chọn hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                dtpNgayGiaoDuKien.MinDate = DateTime.Now;
                this.dtpNgayGiaoDuKien.MinDate = DateTime.Now;
                this.dtpNgayGiaoDuKien.Value = DateTime.Now.AddDays(2);
                
                ResetForm();
                LoadSauKhiHuyMaHD();
            }
        }
        private void LoadSauKhiHuyMaHD()
        {
            dgvHoaDon.Enabled = true;
            btnHuyMaHD.Enabled = false;
            btnXacNhanMaHD.Enabled = true;
            txtMaHD.Text = "";
            MaHD = "";
            LoadDanhSachSanPhamCuaHoaDon(MaHD);

            this.btnInPhieuGiao.Enabled = false;
            this.btnXacNhanPhieuGiao.Enabled = false;
            this.btnHuyPhieuGiao.Enabled = false;

            btnThemSPVaoPhieuGiao.Enabled = true;
            btnXoaSPTrongPhieuGiao.Enabled = true;
            btnLuuPhieuGiao.Enabled = true;

            txtTongGíaTri.Text = "";
            txtPhiVanChuyen.Text = "";
            danhSachSanPhamGiao.Clear();
            CapNhatDgvSanPhamGiao();
        }

        private void BtnXacNhanMaHD_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            if (!string.IsNullOrEmpty(mahd)) {
                LoadDanhSachSanPhamCuaHoaDon(mahd);
                btnXacNhanMaHD.Enabled = false;
                btnHuyMaHD.Enabled = true;
                dgvHoaDon.Enabled = false;

                KiemTraSuTonTaiPhieuGiaoCuaHoaDon(mahd);
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DgvSanPhamGiao_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {       
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvSanPhamGiao.Rows[e.RowIndex];
                string maSanPham = row.Cells["maSanPhamGiao"].Value?.ToString();

                if (dgvSanPhamGiao.Columns[e.ColumnIndex].Name == "soLuongGiao")
                {
                    int soLuong = Convert.ToInt32(row.Cells["soLuongGiao"].Value);
                    var sanPham = danhSachSanPhamGiao.FirstOrDefault(sp => sp.MaSanPham == maSanPham);

                    if (sanPham != null)
                    {
                        sanPham.SoLuong = soLuong;
                        sanPham.TongTien = sanPham.SoLuong * sanPham.DonGia;

                        CapNhatDgvSanPhamGiao();
                        CapNhatTongTienCuaSP();
                    }
                }
            }
        }

        private void BtnThemSPVaoPhieuGiao_Click(object sender, EventArgs e)
        {
            if (dgvDSSP.SelectedRows.Count > 0)
            {
                List<string> sanPhamDatSoLuongMax = new List<string>();

                foreach (DataGridViewRow selectedRow in dgvDSSP.SelectedRows)
                {
                    string maSanPham = selectedRow.Cells["maSanPham"].Value?.ToString();
                    int soLuongDSSP = int.Parse(selectedRow.Cells["soLuong"].Value?.ToString() ?? "0");
                    ChiTietHoaDonSanPham sp = cthdbll.LayTTSanPhamTrongHoaDon(maSanPham, MaHD);

                    bool trungLap = false;
                    foreach (var item in danhSachSanPhamGiao)
                    {
                        if (item.MaSanPham == maSanPham)
                        {
                            if (item.SoLuong < soLuongDSSP)
                            {
                                trungLap = true;
                                // Tăng số lượng nếu trùng lặp
                                item.SoLuong += 1;
                                item.TongTien = item.SoLuong * sp.donGia.Value;
                            }
                            else
                            {
                                sanPhamDatSoLuongMax.Add(maSanPham);
                            }
                            break;
                        }
                    }
                    if (!trungLap && !sanPhamDatSoLuongMax.Contains(maSanPham))
                    {
                        danhSachSanPhamGiao.Add(new SanPhamGiao
                        {
                            MaSanPham = maSanPham,
                            SoLuong = 1,
                            DonGia = sp.donGia.Value,
                            TongTien = sp.donGia.Value
                        });
                    }
                }
                dgvDSSP.ClearSelection();

                if (sanPhamDatSoLuongMax.Count > 0)
                {
                    CapNhatDgvSanPhamGiao();
                    string message = "Các sản phẩm sau đã đạt số lượng tối đa:\n" + string.Join("\n", sanPhamDatSoLuongMax);
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    CapNhatDgvSanPhamGiao();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để thêm vào phiếu giao.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CapNhatTongTienCuaSP();
        }
        
        private void BtnXoaSPTrongPhieuGiao_Click(object sender, EventArgs e)
        {
            if(dgvSanPhamGiao.SelectedRows.Count > 0)
            {
                List<string> sanPhamCanXoa = new List<string>();
                foreach (DataGridViewRow selectedRow in dgvSanPhamGiao.SelectedRows)
                {
                    if (selectedRow.Cells["maSanPhamGiao"].Value != null)
                    {
                        string maSanPham = selectedRow.Cells["maSanPhamGiao"].Value.ToString();
                        sanPhamCanXoa.Add(maSanPham);
                    }
                }
                MessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Xóa sản phẩm khỏi danh sách
                danhSachSanPhamGiao.RemoveAll(sp => sanPhamCanXoa.Contains(sp.MaSanPham));
                CapNhatDgvSanPhamGiao();
                CapNhatTongTienCuaSP();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLuuPhieuGiao_Click(object sender, EventArgs e)
        {
            if(KiemTraTruocKhiLuuHoacIn())
            {
                string phiVanChuyenText = txtPhiVanChuyen.Text.Replace("đ", "");
                if (!string.IsNullOrEmpty(txtPhiVanChuyen.Text) 
                    && decimal.TryParse(phiVanChuyenText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal phiVanChuyen)) 
                {
                    string maPhieuGiao = txtMaPhieuGiao.Text;
                    PhieuGiaoHang phieuGiao = new PhieuGiaoHang
                    {
                        maPhieuGiao = maPhieuGiao,
                        maNhanVien = maNhanVien,
                        tenKhachHang = txtTenKhachHang.Text.Trim(),
                        soDienThoai = txtSDT.Text,
                        DiaChiGiaoHang = txtDiaChi.Text.Trim(),
                        ngayGiaoDuKien = dtpNgayGiaoDuKien.Value,
                        chiPhi = phiVanChuyen,
                        tinhTrang = "Chưa xác nhận",
                        ngayLap = DateTime.Now
                    };
                    if (pgbll.ThemHoacSuaPhieuGiao(phieuGiao))
                    {
                        chiTietPhieuGiaoHangList = new List<ChiTietPhieuGiaoHang>();
                        foreach (DataGridViewRow row in dgvSanPhamGiao.Rows)
                        {
                            int soLuongGiao = int.Parse(row.Cells["soLuongGiao"].Value.ToString());
                            decimal donGia = decimal.Parse(row.Cells["donGia"].Value.ToString());
                            decimal tongTienGiao = decimal.Parse(row.Cells["tongTienGiao"].Value.ToString());

                            ChiTietPhieuGiaoHang ctpg = new ChiTietPhieuGiaoHang
                            {
                                maPhieuGiao = phieuGiao.maPhieuGiao,
                                maHoaDon = txtMaHD.Text,
                                maSanPham = row.Cells["maSanPhamGiao"].Value.ToString(),
                                soLuong = soLuongGiao,
                                donGia = donGia,
                                tongTien = tongTienGiao
                            };

                            chiTietPhieuGiaoHangList.Add(ctpg);

                            if (!ctpgbll.ThemHoacSuaChiTietPhieuGiao(ctpg))
                            {
                                MessageBox.Show("Lỗi khi thêm chi tiết phiếu giao", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        MessageBox.Show("Cập nhật phiếu giao thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        btnInPhieuGiao.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu giao thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(string.IsNullOrEmpty(txtPhiVanChuyen.Text))
                {
                    MessageBox.Show("Chưa có sản phẩm giao!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnInPhieuGiao_Click(object sender, EventArgs e)
        {
            if(KiemTraTruocKhiLuuHoacIn())
            {
                string mahd = txtMaHD.Text;
                string mapg = txtMaPhieuGiao.Text;
                string tenKH = txtTenKhachHang.Text.Trim();
                string diaChiNhanHang = txtDiaChi.Text.Trim();
                string sdt = txtSDT.Text;
                NhanVien nv = nvbll.LayTTNhanVienTuTenDangNhap(maNhanVien);
                string tenNV = nv.tenNhanVien;
                chiTietPhieuGiaoHangList = ctpgbll.LayDanhSachChiTietPhieuGiao(mapg);
                string tongGiaTriText = txtTongGíaTri.Text;
                string phiVanChuyenText = txtPhiVanChuyen.Text;
                frmPhieuGiaoHang frm = new frmPhieuGiaoHang(chiTietPhieuGiaoHangList, mahd, mapg, tenKH, diaChiNhanHang, sdt, tenNV, tongGiaTriText, phiVanChuyenText);
                frm.ShowDialog();
                PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(mapg);
                if(phieuGiao.tinhTrang == "Chưa xác nhận")
                {
                    btnXacNhanPhieuGiao.Enabled = true;
                    btnHuyPhieuGiao.Enabled = true;
                }
                else
                {
                    btnXacNhanPhieuGiao.Enabled = false;
                    btnHuyPhieuGiao.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnHuyPhieuGiao_Click(object sender, EventArgs e)
        {
            PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(txtMaPhieuGiao.Text);
            if (phieuGiao != null)
            {
                var result = MessageBox.Show("Bạn muốn hủy phiếu giao hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maPhieuGiaoMoi = pgbll.TaoMaPhieuGiaoHangTuDong();
                    MaPGSauKhiHuyPhieu = maPhieuGiaoMoi;
                    if (pgbll.XoaPhieuGiao(phieuGiao))
                    {
                        MessageBox.Show("Đã hủy đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        btnXacNhanPhieuGiao.Enabled = false;
                        btnHuyPhieuGiao.Enabled = false;
                        btnInPhieuGiao.Enabled = false;
                        LoadForm();
                        danhSachSanPhamGiao.Clear();
                        CapNhatDgvSanPhamGiao();

                        LoadDSSanPhamCuaPhieuGiao("");

                        txtMaPhieuGiao.Text = MaPGSauKhiHuyPhieu;
                    }
                }
            }
        }

        private void BtnXacNhanPhieuGiao_Click(object sender, EventArgs e)
        {
            PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(txtMaPhieuGiao.Text);
            if(phieuGiao != null)
            {
                var result = MessageBox.Show("Bạn muốn chốt phiếu giao hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    phieuGiao.tinhTrang = "Chưa giao";
                    if(pgbll.ThemHoacSuaPhieuGiao(phieuGiao))
                    {
                        MessageBox.Show("Đã xác nhận phiếu giao hàng thành công cho đơn hàng " + MaHD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        LoadForm();
                        LoadSauKhiHuyMaHD();

                        LoadDSSanPhamCuaPhieuGiao("");
                        btnHuyMaHD.Enabled = false;
                        btnXacNhanMaHD.Enabled = true;

                        txtMaPhieuGiao.Text = pgbll.TaoMaPhieuGiaoHangTuDong();
                    }
                }
            }
        }
        private void CapNhatDgvSanPhamGiao()
        {
            dgvSanPhamGiao.DataSource = null;
            dgvSanPhamGiao.DataSource = danhSachSanPhamGiao.Select(ctpg => new
            {
                maSanPhamGiao = ctpg.MaSanPham,
                soLuongGiao = ctpg.SoLuong,
                donGia = ctpg.DonGia,
                tongTienGiao = ctpg.TongTien
            }).ToList();
            if (dgvSanPhamGiao.Columns["maSanPhamGiao"] != null)
            {
                dgvSanPhamGiao.Columns["maSanPhamGiao"].HeaderText = "Mã sản phẩm";
            }
            if (dgvSanPhamGiao.Columns["soLuongGiao"] != null)
            {
                dgvSanPhamGiao.Columns["soLuongGiao"].HeaderText = "Số lượng";
            }
            if (dgvSanPhamGiao.Columns["donGia"] != null)
            {
                dgvSanPhamGiao.Columns["donGia"].HeaderText = "Đơn giá (đ)";
            }
            if (dgvSanPhamGiao.Columns["tongTienGiao"] != null)
            {
                dgvSanPhamGiao.Columns["tongTienGiao"].HeaderText = "Tổng tiền (đ)";
            }
        }
        private bool KiemTraTruocKhiLuuHoacIn()
        {
            bool dinhDang = true;
            errorTTPhieu.Clear();
            KiemTraInputSoDienThoai();
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTPhieu.SetError(txtTenKhachHang, "Vui lòng nhập họ tên khách hàng");
                dinhDang = false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhận hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTPhieu.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
                dinhDang = false;
            }
            return dinhDang;
        }
        private bool KiemTraInputSoDienThoai()
        {
            bool dinhDang = true;
            errorTTPhieu.Clear();
            if (string.IsNullOrWhiteSpace(txtSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTPhieu.SetError(txtSDT, "Vui lòng nhập số điện thoại khách hàng");
                dinhDang = false;
            }
            else if (txtSDT.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTPhieu.SetError(txtSDT, "Vui lòng nhập đúng định dạng số điện thoại");
                dinhDang = false;
            }
            return dinhDang;
        }

        private void CapNhatTongTienCuaSP()
        {
            decimal tongTienTatCaSanPham = 0;
            decimal phiVanChuyen;
            foreach (var item in danhSachSanPhamGiao)
            {
                if (item.MaSanPham != null)
                {
                    int soLuongGiao = item.SoLuong;
                    decimal donGiaSp = item.DonGia;
                    decimal tongTienGiao = soLuongGiao * donGiaSp;
                    item.TongTien = tongTienGiao;

                    tongTienTatCaSanPham += tongTienGiao;
                }
            }
            txtTongGíaTri.Text = tongTienTatCaSanPham.ToString("N0").Replace(",", ".") + "đ";

            if(tongTienTatCaSanPham < 199000)
            {
                phiVanChuyen = 0;
            }
            else if(tongTienTatCaSanPham < 399000)
            {
                phiVanChuyen = 20000;
            }
            else if (tongTienTatCaSanPham < 699000)
            {
                phiVanChuyen = 15000;
            }
            else
            {
                phiVanChuyen = 5000;
            }
            txtPhiVanChuyen.Text = phiVanChuyen.ToString("N0").Replace(",", ".") + "đ";
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHoaDon.SelectedRows[0];
                string maHoaDon = row.Cells["maHoaDon"].Value.ToString();
                MaHD = maHoaDon;
                txtMaHD.Text = maHoaDon;
            }
        }
        public void KiemTraSuTonTaiPhieuGiaoCuaHoaDon(string mahd)
        {
            string mapg = ctpgbll.LayMaPGTuHoaDon(mahd);
            if (mapg != null)
            {
                PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(mapg);
                if (phieuGiao.tinhTrang != "Chưa xác nhận")
                {
                    EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(false);
                    
                    dgvSanPhamGiao.Enabled = false;
                    numericSoLuongSp.Enabled = false;
                }
                else if (phieuGiao.tinhTrang == "Chưa xác nhận")
                {
                    EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(true);
                    
                    dgvSanPhamGiao.Enabled = true;
                    numericSoLuongSp.Enabled = true;
                }

                btnXacNhanPhieuGiao.Enabled = false;
                btnHuyPhieuGiao.Enabled = false;
                btnInPhieuGiao.Enabled = true;

                txtMaPhieuGiao.Text = mapg;
                txtDiaChi.Text = phieuGiao.DiaChiGiaoHang;
                dtpNgayGiaoDuKien.Value = phieuGiao.ngayGiaoDuKien.Value;

                txtTenKhachHang.Text = phieuGiao.tenKhachHang;
                txtSDT.Text = phieuGiao.soDienThoai;
            }
            else
            {
                btnXacNhanPhieuGiao.Enabled = false;
                btnHuyPhieuGiao.Enabled = false;
                btnInPhieuGiao.Enabled = false;
                dgvSanPhamGiao.Enabled = true;
                ResetForm();
                EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(true);
                dtpNgayGiaoDuKien.MinDate = DateTime.Now;
                this.dtpNgayGiaoDuKien.MinDate = DateTime.Now;
                this.dtpNgayGiaoDuKien.Value = DateTime.Now.AddDays(2);
                txtMaPhieuGiao.Text = MaPGSauKhiHuyPhieu != null ? MaPGSauKhiHuyPhieu : pgbll.TaoMaPhieuGiaoHangTuDong();
                
                HoaDon hoaDon = hdbll.LoadHoaDonTheoMa(mahd);
                if (!string.IsNullOrEmpty(hoaDon.maKhachHang))
                {
                    KhachHang khachHang = khbll.LayKHTheoMa(hoaDon.maKhachHang);
                    txtTenKhachHang.Text = khachHang.tenKhachHang;
                    txtSDT.Text = khachHang.soDienThoai;
                }
                else
                {
                    txtTenKhachHang.Text = "";
                    txtSDT.Text = "";
                }
            }

            LoadDanhSachSanPhamCuaHoaDon(mahd);
            LoadDSSanPhamCuaPhieuGiao(mapg);
        }
        private void ResetForm()
        {
            txtMaPhieuGiao.Text = "";
            txtDiaChi.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            dtpNgayGiaoDuKien.Value = DateTime.Now.AddDays(2);
            txtTongGíaTri.Text = "";
            txtPhiVanChuyen.Text = "";
            txtMaSPGiao.Text = "";
            numericSoLuongSp.Value = 1;
        }
        private void LoadDSSanPhamCuaPhieuGiao(string mapg)
        {
            if (string.IsNullOrEmpty(mapg))
            {
                danhSachSanPhamGiao.Clear();
            }
            else
            {
                var dsChiTietPG = ctpgbll.LayDanhSachChiTietPhieuGiao(mapg);
                danhSachSanPhamGiao = dsChiTietPG.Select(ctpg => new SanPhamGiao
                {
                    MaSanPham = ctpg.maSanPham,
                    SoLuong = ctpg.soLuong.Value,
                    DonGia = ctpg.donGia.Value,
                    TongTien = ctpg.tongTien.Value
                }).ToList();
            }
            dgvSanPhamGiao.DataSource = danhSachSanPhamGiao.Select(ctpg => new
            {
                maSanPhamGiao = ctpg.MaSanPham,
                soLuongGiao = ctpg.SoLuong,
                donGia = ctpg.DonGia,
                tongTienGiao = ctpg.TongTien
            }).ToList();

            CapNhatTongTienCuaSP();
        }
        private void EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(bool enable)
        {
            btnLuuPhieuGiao.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtTenKhachHang.Enabled = enable;
            txtSDT.Enabled = enable;
            dtpNgayGiaoDuKien.Enabled = enable;
            btnXoaSPTrongPhieuGiao.Enabled = enable;
            btnThemSPVaoPhieuGiao.Enabled = enable;
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FrmLapPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            txtMaPhieuGiao.Text = pgbll.TaoMaPhieuGiaoHangTuDong();
            txtTimKiem.Text = placeholderText;
            txtTimKiem.Enter += (s, ex) =>
            {
                if (txtTimKiem.Text == placeholderText)
                {
                    txtTimKiem.Text = "";
                    txtTimKiem.ForeColor = textColor;
                }
            };

            txtTimKiem.Leave += (s, ex) =>
            {
                if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
                {
                    txtTimKiem.Text = placeholderText;
                    txtTimKiem.ForeColor = placeholderColor;
                }
            };
            
            this.dtpNgayBatDau.Value = this.dtpNgayKetThuc.Value;
            DateTime ngayBatDau = DateTime.Now.Date;
            DateTime ngayKetThuc = DateTime.Now.Date;
            LoadDanhSachHoaDon("Các tiêu chí", "", ngayBatDau, ngayKetThuc, "Loại khách hàng");
            LoadForm();
        }

        private void LoadForm()
        { 
            dtpNgayGiaoDuKien.MinDate = DateTime.Now;
            this.dtpNgayGiaoDuKien.MinDate = DateTime.Now;
            this.dtpNgayGiaoDuKien.Value = DateTime.Now.AddDays(2);
        }
        private void LoadDanhSachHoaDon(string tieuChi, string giaTriTimKiem, DateTime ngayBatDau, DateTime ngayKetThuc, string loaikh)
        {
            var dshd = hdbll.TimKiemVaLocHoaDon(tieuChi, giaTriTimKiem, ngayBatDau, ngayKetThuc, loaikh).OrderByDescending(hd => hd.ngayLap.Value);
            var dataSource = dshd.Select(hd => new
            {
                maHoaDon = hd.maHoaDon,
                ngayLap = hd.ngayLap,
                tongTien = hd.tongTienSauGiam
            }).ToList();

            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = dataSource;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvHoaDon.Columns["maHoaDon"] != null)
            {
                dgvHoaDon.Columns["maHoaDon"].HeaderText = "Mã hóa đơn";
            }
            if (dgvHoaDon.Columns["ngayLap"] != null)
            {
                dgvHoaDon.Columns["ngayLap"].HeaderText = "Ngày lập";
            }
            if (dgvHoaDon.Columns["tongTien"] != null)
            {
                dgvHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
            }
        }

        private void LoadDanhSachSanPhamCuaHoaDon(string mahd)
        {
            var dsSanPhamCuaHoaDon = cthdbll.LoadCTHDSanPham(mahd);
            dgvDSSP.DataSource = dsSanPhamCuaHoaDon.Select(ds => new
            {
                maSanPham = ds.maSanPham,
                tenSanPham = ds.tenSanPham,
                soLuong = ds.soLuong
            }).ToList();
            dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["soLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void DgvSanPhamGiao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatCell(e);
        }

        private void DgvDSSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatCell(e);
        }

        private void DgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatCell(e);
            if (e.RowIndex >= 0 && dgvHoaDon.Columns[e.ColumnIndex].Name == "maHoaDon")
            {
                string maHD = dgvHoaDon.Rows[e.RowIndex].Cells["maHoaDon"].Value.ToString();
                string maPGCuaHoaDonDuocChon = ctpgbll.LayMaPGTuHoaDon(maHD);
                if (!string.IsNullOrEmpty(maPGCuaHoaDonDuocChon))
                {
                    PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(maPGCuaHoaDonDuocChon);
                    if(phieuGiao.tinhTrang == "Chưa xác nhận")
                    {
                        dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                        dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                        return;
                    }
                    else if (phieuGiao.tinhTrang != "Chưa xác nhận")
                    {
                        dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#747d8c");
                        dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#f1f2f6");
                        return;
                    }
                }
                else
                {
                    dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dgvHoaDon.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void FormatCell(DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal so))
            {
                e.Value = so.ToString("N0").Replace(",", ".");
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang(maNhanVien);
            frm.Show();
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnPhongToThuNho_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
