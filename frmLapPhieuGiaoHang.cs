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
        private string TongTienHoaDonText;

        private List<ChiTietHoaDonSanPham> chiTietPhieuGiaoHangList;

        HoaDonBLL hdbll = new HoaDonBLL();
        ChiTietHoaDonSanPhamBLL cthdbll = new ChiTietHoaDonSanPhamBLL();
        PhieuGiaoHangBLL pgbll = new PhieuGiaoHangBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        KhachHangBLL khbll = new KhachHangBLL();
        SanPhamBLL spbll = new SanPhamBLL();
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

            this.btnLuuPhieuGiao.Click += BtnLuuPhieuGiao_Click;

            // TT Phiếu giao
            this.txtTenKhachHang.KeyPress += TxtTenKhachHang_KeyPress;
            this.txtSDT.KeyPress += TxtSDT_KeyPress;
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

            btnLuuPhieuGiao.Enabled = true;
            txtPhiVanChuyen.Text = "";
        }

        private void BtnXacNhanMaHD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaHD)) {
                LoadDanhSachSanPhamCuaHoaDon(MaHD);
                btnXacNhanMaHD.Enabled = false;
                btnHuyMaHD.Enabled = true;
                dgvHoaDon.Enabled = false;

                KiemTraSuTonTaiPhieuGiaoCuaHoaDon(MaHD);
            }
            else
            {
                MessageBox.Show("Hãy chọn hóa đơn để xác nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        maHoaDon = MaHD,
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
                    MessageBox.Show("Không thể thực hiện lập phiếu giao\nTổng tiền hóa đơn dưới 199.000đ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string phiVanChuyenText = txtPhiVanChuyen.Text;
                frmPhieuGiaoHang frm = new frmPhieuGiaoHang(chiTietPhieuGiaoHangList, mahd, mapg, tenKH, diaChiNhanHang, sdt, tenNV, TongTienHoaDonText, phiVanChuyenText);
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

                        btnHuyMaHD.Enabled = false;
                        btnXacNhanMaHD.Enabled = true;

                        txtMaPhieuGiao.Text = pgbll.TaoMaPhieuGiaoHangTuDong();
                    }
                    else
                    {
                        MessageBox.Show("Xác nhận phiếu giao hàng thất bại cho đơn hàng " + MaHD, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHoaDon.SelectedRows[0];
                string maHoaDon = row.Cells["maHoaDon"].Value.ToString();
                string tongTienHD = row.Cells["tongTien"].Value.ToString();
                MaHD = maHoaDon;
                txtMaHD.Text = maHoaDon;
                TongTienHoaDonText = tongTienHD.Replace(".00", "") + "đ";
            }
        }
        public void KiemTraSuTonTaiPhieuGiaoCuaHoaDon(string mahd)
        {
            PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaHoaDon(mahd);
            if (phieuGiao != null)
            {
                if (phieuGiao.tinhTrang != "Chưa xác nhận")
                {
                    EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(false);
                }
                else if (phieuGiao.tinhTrang == "Chưa xác nhận")
                {
                    EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(true);
                }

                btnXacNhanPhieuGiao.Enabled = false;
                btnHuyPhieuGiao.Enabled = false;
                btnInPhieuGiao.Enabled = true;

                txtMaPhieuGiao.Text = phieuGiao.maPhieuGiao;
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
        }
        private void ResetForm()
        {
            txtMaPhieuGiao.Text = "";
            txtDiaChi.Text = "";
            txtTenKhachHang.Text = "";
            txtSDT.Text = "";
            dtpNgayGiaoDuKien.Value = DateTime.Now.AddDays(2);
            txtPhiVanChuyen.Text = "";
        }
        private void EnableKhiCoSuTonTaiPhieuGiaoCuaHoaDon(bool enable)
        {
            btnLuuPhieuGiao.Enabled = enable;
            txtDiaChi.Enabled = enable;
            txtTenKhachHang.Enabled = enable;
            txtSDT.Enabled = enable;
            dtpNgayGiaoDuKien.Enabled = enable;
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
            if(!string.IsNullOrEmpty(mahd))
            {
                var dsSanPhamCuaHoaDon = cthdbll.LoadCTHDSanPham(mahd);
                dgvDSSP.DataSource = dsSanPhamCuaHoaDon.Select(ds => new
                {
                    maSanPham = ds.maSanPham,
                    tenSanPham = ds.tenSanPham,
                    soLuong = ds.soLuong,
                    donGia = ds.donGia,
                    tongTienSP = ds.tongTien
                }).ToList();
                dgvDSSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDSSP.Columns["donGia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDSSP.Columns["soLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvDSSP.Columns["tongTienSP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                if (dgvDSSP.Columns["maSanPham"] != null)
                {
                    dgvDSSP.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
                }
                if (dgvDSSP.Columns["tenSanPham"] != null)
                {
                    dgvDSSP.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
                }
                if (dgvDSSP.Columns["soLuong"] != null)
                {
                    dgvDSSP.Columns["soLuong"].HeaderText = "Số lượng";
                }
                if (dgvDSSP.Columns["donGia"] != null)
                {
                    dgvDSSP.Columns["donGia"].HeaderText = "Đơn giá (đ)";
                }
                if (dgvDSSP.Columns["tongTienSP"] != null)
                {
                    dgvDSSP.Columns["tongTienSP"].HeaderText = "Tổng tiền (đ)";
                }

                chiTietPhieuGiaoHangList = new List<ChiTietHoaDonSanPham>();
                foreach (DataGridViewRow row in dgvDSSP.Rows)
                {
                    string maSp = row.Cells["maSanPham"].Value.ToString();
                    ChiTietHoaDonSanPham sp = cthdbll.LayTTSanPhamTrongHoaDon(maSp, mahd);
                    chiTietPhieuGiaoHangList.Add(sp);
                }
                decimal phiVanChuyen = 0;
                HoaDon hd = hdbll.LoadHoaDonTheoMa(MaHD);
                if (hd.tongTienSauGiam < 199000)
                {
                    return;
                }
                else if (hd.tongTienSauGiam < 399000)
                {
                    phiVanChuyen = 20000;
                }
                else if (hd.tongTienSauGiam < 699000)
                {
                    phiVanChuyen = 15000;
                }
                else
                {
                    phiVanChuyen = 5000;
                }
                txtPhiVanChuyen.Text = phiVanChuyen.ToString("N0").Replace(",", ".") + "đ";
            }
            else
            {
                dgvDSSP.DataSource = null;
                return;
            }
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
                PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaHoaDon(maHD);
                if (phieuGiao != null)
                {
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
