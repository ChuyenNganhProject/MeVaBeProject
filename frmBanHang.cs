using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny;
using Sunny.UI;
using CustomControl;
using System.Globalization;

namespace MeVaBeProject
{
    public partial class frmBanHang : Form
    {
        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
        SanPhamBLL spbll = new SanPhamBLL();
        KhachHangBLL khbll = new KhachHangBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        HoaDonBLL hdbll = new HoaDonBLL();
        HangThanhVienBLL htvbll = new HangThanhVienBLL();
        UuDaiThanhVienBLL uubll = new UuDaiThanhVienBLL();
        
        private List<GioHangItemControl> gioHangItems = new List<GioHangItemControl>();
        private string maNhanVien;
        private string currentLoaiSp;
        private string currentTenTimKiem;
        public frmBanHang(string maNhanVien)
        {
            InitializeComponent();

            this.maNhanVien = maNhanVien;

            this.btnClose.Click += BtnClose_Click;
            this.btnPhongToThuNho.Click += BtnPhongToThuNho_Click;
            this.btnMinimize.Click += BtnMinimize_Click;
            this.btnDangXuat.Click += BtnDangXuat_Click;
            
            // Thông tin khách
            this.txtSdt.KeyPress += TxtSdt_KeyPress;
            this.txtSdt.Leave += TxtSdt_Leave;
            this.btnSuaSDT.Click += BtnSuaSDT_Click;
            this.txtTenKH.KeyPress += TxtTenKH_KeyPress;
            this.btnNhapTTKhach.Click += BtnNhapTTKhach_Click;
            this.btnHuyNhapTTKhach.Click += BtnHuyNhapTTKhach_Click;

            // Bộ lọc
            this.btnXacNhanTimKiem.Click += BtnXacNhanTimKiem_Click;
            this.btnLamMoiTimKiem.Click += BtnLamMoiTimKiem_Click;

            // Tính tiền
            this.lblTongTien.TextChanged += LblTongTien_TextChanged;
            this.btnThanhToan.Click += BtnThanhToan_Click;

            // Nút bấm loại sản phẩm
            this.btnTatCaSanPham.Click += BtnTatCaSanPham_Click;
            LoadLoaiSanPham();
        }

        private void LblTongTien_TextChanged(object sender, EventArgs e)
        {
            if (lblPhanTramGiam.Visible)
            {
                string tongTienText = lblTongTien.Text.Replace("đ", "").Trim();
                string phanTramGiamText = lblPhanTramGiam.Text.Replace("%)", "").Trim();
                if (decimal.TryParse(tongTienText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTien))
                {
                    if (decimal.TryParse(phanTramGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal phanTramGiam))
                    {
                        decimal tienBiGiam = tongTien * (phanTramGiam / 100);
                        lblTienGiamGiaVip.Text = "-" + tienBiGiam.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                    }
                }
            }
        }

        private void BtnHuyNhapTTKhach_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtSdt.Clear();
            errorTTKhach.Clear();
            txtSdt.Enabled = false;
            txtTenKH.Enabled = false;
            btnSuaSDT.Enabled = false;
            btnHuyNhapTTKhach.Enabled = false;
            btnNhapTTKhach.Enabled = true;
            lblMucGiam.Visible = false;
            lblMucTenHang.Visible = false;
            lblTenHangKH.Visible = false;
            lblTenHangKH.Text = "";
            lblPhanTramGiam.Visible = false;
            lblPhanTramGiam.Text = "";
            lblTienGiamGiaVip.Visible = false;
            lblTienGiamGiaVip.Text = "";
            decimal tienBiGiam = 0;
            lblTienGiamGiaVip.Text = "-" + tienBiGiam.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            CapNhatTongTien();
        }

        private void BtnNhapTTKhach_Click(object sender, EventArgs e)
        {
            txtSdt.Enabled = true;
            btnSuaSDT.Enabled = true;
            btnHuyNhapTTKhach.Enabled = true;
            btnNhapTTKhach.Enabled = false;
        }

        private void BtnSuaSDT_Click(object sender, EventArgs e)
        {
            if (KiemTraInputSoDienThoai())
            {
                string sdt = txtSdt.Text;
                KhachHang kh = khbll.LayKhachHangTheoSoDienThoai(sdt);
                if(kh != null)
                {
                    frmCapNhatSDT frm = new frmCapNhatSDT(sdt);
                    frm.ShowDialog();
                    if(frm.DialogResult == DialogResult.OK)
                    {
                        txtSdt.Text = frm.newSDT;
                    }
                }
                else
                {
                    MessageBox.Show("Không có thông tin khách hàng về số điện thoại này", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void TxtSdt_Leave(object sender, EventArgs e)
        {
            if(KiemTraInputSoDienThoai())
            {
                KhachHang kh = khbll.LayKhachHangTheoSoDienThoai(txtSdt.Text);
                if (kh != null)
                {
                    txtTenKH.Text = kh.tenKhachHang;
                    if (kh.maHang != "MEMBER")
                    {
                        string tenHang = kh.tenHang.ToString();
                        lblMucTenHang.Visible = true;
                        lblTenHangKH.Visible = true;
                        lblTenHangKH.Text = tenHang;
                        decimal phanTramGiam = uubll.GetPhanTramGiam(kh.maHang);
                        lblMucGiam.Visible = true;
                        lblPhanTramGiam.Visible = true;
                        lblTienGiamGiaVip.Visible = true;
                        lblPhanTramGiam.Text = phanTramGiam.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "%)";
                        string tongTienText = lblTongTien.Text.Replace("đ", "").Trim();
                        if (decimal.TryParse(tongTienText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTien))
                        {
                            decimal tienBiGiam = tongTien * (phanTramGiam / 100);
                            lblTienGiamGiaVip.Text = "-" + tienBiGiam.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
                        }
                        CapNhatTongTien();
                    }
                    else
                    {
                        lblMucGiam.Visible = false;
                        lblMucTenHang.Visible = false;
                        lblTenHangKH.Visible = false;
                        lblTenHangKH.Text = "";
                        lblPhanTramGiam.Visible = false;
                        lblPhanTramGiam.Text = "";
                        lblTienGiamGiaVip.Visible = false;
                        lblTienGiamGiaVip.Text = "";
                        CapNhatTongTien();
                    }
                    txtTenKH.Enabled = false;
                }
                else
                {
                    txtTenKH.Enabled = true;
                    txtTenKH.Text = "";
                    lblMucGiam.Visible = false;
                    lblMucTenHang.Visible = false;
                    lblTenHangKH.Visible = false;
                    lblTenHangKH.Text = "";
                    lblPhanTramGiam.Visible = false;
                    lblPhanTramGiam.Text = "";
                    lblTienGiamGiaVip.Visible = false;
                    lblTienGiamGiaVip.Text = "";
                    CapNhatTongTien();
                }
            }
            
            else
            {
                txtTenKH.Enabled = false;
                txtTenKH.Text = "";
                lblMucGiam.Visible = false;
                lblMucTenHang.Visible = false;
                lblTenHangKH.Visible = false;
                lblTenHangKH.Text = "";
                lblPhanTramGiam.Visible = false;
                lblPhanTramGiam.Text = "";
                lblTienGiamGiaVip.Visible = false;
                lblTienGiamGiaVip.Text = "";
                CapNhatTongTien();
            }
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            NhanVien nv = nvbll.LayTTNhanVienTuTenDangNhap(maNhanVien);
            string tienTruocKhiGiamText = lblTongTien.Text.Replace("đ", "");
            string tongTienThanhToanText = lblTienThanhToan.Text.Replace("đ", "");
            string tienBiGiamText = lblTienGiamGiaVip.Text.Trim();
            string hangThanhVienText = lblTenHangKH.Text.Trim();
            string phanTramGiamText = "";
            if (!string.IsNullOrEmpty(lblPhanTramGiam.Text))
            {
                phanTramGiamText = lblMucGiam.Text.Trim() + " " + lblPhanTramGiam.Text;
            }
            
            if (gioHangItems.Count == 0)
            {
                MessageBox.Show("Giỏ hàng không có sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtSdt.Enabled && KiemTraTruocKhiThanhToan())
            {
                string sdt = txtSdt.Text;
                KhachHang kh = khbll.LayKhachHangTheoSoDienThoai(sdt);

                if (kh == null)
                {
                    kh = new KhachHang
                    {
                        maKhachHang = khbll.TaoMaKhachHangTuDong(),
                        tenKhachHang = txtTenKH.Text.Trim(),
                        soDienThoai = sdt,
                        diemTichLuy = 0,
                        maHang = "MEMBER"
                    };
                    khbll.ThemKhachHang(kh);
                }

                if (decimal.TryParse(tienTruocKhiGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTien))
                {
                    if(!string.IsNullOrEmpty(tienBiGiamText))
                    {
                        tienBiGiamText = tienBiGiamText.Replace("-", "");
                        if (decimal.TryParse(tienBiGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tienDuocGiam))
                        {
                            if (decimal.TryParse(tongTienThanhToanText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTienThanhToan))
                            {
                                HoaDon hd = new HoaDon
                                {
                                    maHoaDon = hdbll.TaoMaHoaDonTuDong(),
                                    maKhachHang = kh.maKhachHang,
                                    maNhanVien = nv.maNhanVien,
                                    ngayLap = DateTime.Now,
                                    tongTien = tongTien,
                                    tienDuocGiam = tienDuocGiam,
                                    tongTienSauGiam = tongTienThanhToan,
                                    trangThai = true // Đã thanh toán
                                };

                                if (hdbll.ThemHoaDon(hd))
                                {
                                    ChiTietHoaDonSanPhamBLL cthdspBLL = new ChiTietHoaDonSanPhamBLL();
                                    List<ChiTietHoaDonSanPham> chiTietHoaDons = new List<ChiTietHoaDonSanPham>();

                                    foreach (var item in gioHangItems)
                                    {
                                        var sanPham = spbll.TimKiemSanPhamTheoMaSP(item.MaSanPham);
                                        if (sanPham == null)
                                        {
                                            MessageBox.Show($"Sản phẩm với mã {item.MaSanPham} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        ChiTietHoaDonSanPham cthd = new ChiTietHoaDonSanPham
                                        {
                                            maHoaDon = hd.maHoaDon,
                                            maSanPham = item.MaSanPham,
                                            soLuong = item.SoLuong,
                                            donGia = item.DonGiaBan,
                                            tongTien = item.TongGiaTri,
                                            tenSanPham = item.TenSanPham
                                        };
                                        chiTietHoaDons.Add(cthd);

                                        if (!cthdspBLL.ThemChiTietHoaDonSanPham(cthd))
                                        {
                                            MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    if (kh.diemTichLuy == null)
                                    {
                                        kh.diemTichLuy = 0;
                                    }
                                    kh.diemTichLuy = hdbll.tongTienTatCaHoaDonCuaKH(kh);
                                    kh.ngayCapNhatDiem = DateTime.Now;
                                    if (kh.diemTichLuy.HasValue)
                                    {
                                        decimal diemTichLuy = kh.diemTichLuy.Value;
                                        kh.maHang = htvbll.GetMaHangThanhVienTheoDiemTichLuy(diemTichLuy);
                                    }
                                    khbll.CapNhatKhachHang(kh);
                                    tienBiGiamText = "-" + tienBiGiamText;
                                    frmBill frmBill = new frmBill(hd, chiTietHoaDons, tienBiGiamText, tienTruocKhiGiamText, hangThanhVienText, phanTramGiamText);
                                    frmBill.ShowDialog();

                                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ResetForm();

                                    if (!string.IsNullOrEmpty(currentLoaiSp))
                                    {
                                        LoadSanPhamTheoLoai(currentLoaiSp);
                                    }
                                    else if (!string.IsNullOrEmpty(currentTenTimKiem))
                                    {
                                        LoadTatCaSanPhamTheoTenHoacMaSp(currentTenTimKiem);
                                    }
                                    else
                                    {
                                        LoadTatCaSanPham();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (decimal.TryParse(tongTienThanhToanText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTienThanhToan))
                        {
                            HoaDon hd = new HoaDon
                            {
                                maHoaDon = hdbll.TaoMaHoaDonTuDong(),
                                maKhachHang = kh.maKhachHang,
                                maNhanVien = nv.maNhanVien,
                                ngayLap = DateTime.Now,
                                tongTien = tongTien,
                                tienDuocGiam = 0,
                                tongTienSauGiam = tongTienThanhToan,
                                trangThai = true // Đã thanh toán
                            };

                            if (hdbll.ThemHoaDon(hd))
                            {
                                ChiTietHoaDonSanPhamBLL cthdspBLL = new ChiTietHoaDonSanPhamBLL();
                                List<ChiTietHoaDonSanPham> chiTietHoaDons = new List<ChiTietHoaDonSanPham>();

                                foreach (var item in gioHangItems)
                                {
                                    var sanPham = spbll.TimKiemSanPhamTheoMaSP(item.MaSanPham);
                                    if (sanPham == null)
                                    {
                                        MessageBox.Show($"Sản phẩm với mã {item.MaSanPham} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    ChiTietHoaDonSanPham cthd = new ChiTietHoaDonSanPham
                                    {
                                        maHoaDon = hd.maHoaDon,
                                        maSanPham = item.MaSanPham,
                                        soLuong = item.SoLuong,
                                        donGia = item.DonGiaBan,
                                        tongTien = item.TongGiaTri,
                                        tenSanPham = item.TenSanPham
                                    };
                                    chiTietHoaDons.Add(cthd);

                                    if (!cthdspBLL.ThemChiTietHoaDonSanPham(cthd))
                                    {
                                        MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                if (kh.diemTichLuy == null)
                                {
                                    kh.diemTichLuy = 0;
                                }
                                kh.diemTichLuy = hdbll.tongTienTatCaHoaDonCuaKH(kh);
                                kh.ngayCapNhatDiem = DateTime.Now;
                                if (kh.diemTichLuy.HasValue)
                                {
                                    decimal diemTichLuy = kh.diemTichLuy.Value;
                                    kh.maHang = htvbll.GetMaHangThanhVienTheoDiemTichLuy(diemTichLuy);
                                }
                                khbll.CapNhatKhachHang(kh);
                                frmBill frmBill = new frmBill(hd, chiTietHoaDons, tienBiGiamText, tienTruocKhiGiamText, hangThanhVienText, phanTramGiamText);
                                frmBill.ShowDialog();

                                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetForm();

                                if (!string.IsNullOrEmpty(currentLoaiSp))
                                {
                                    LoadSanPhamTheoLoai(currentLoaiSp);
                                }
                                else if (!string.IsNullOrEmpty(currentTenTimKiem))
                                {
                                    LoadTatCaSanPhamTheoTenHoacMaSp(currentTenTimKiem);
                                }
                                else
                                {
                                    LoadTatCaSanPham();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else if(!txtSdt.Enabled)
            {
                if (decimal.TryParse(tienTruocKhiGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTien))
                {
                    if(!string.IsNullOrEmpty(tienBiGiamText))
                    {
                        tienBiGiamText = tienBiGiamText.Replace("-", "");
                        if (decimal.TryParse(tienBiGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tienDuocGiam))
                        {
                            if (decimal.TryParse(tongTienThanhToanText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTienThanhToan))
                            {
                                HoaDon hd = new HoaDon
                                {
                                    maHoaDon = hdbll.TaoMaHoaDonTuDong(),
                                    maKhachHang = null,
                                    maNhanVien = nv.maNhanVien,
                                    ngayLap = DateTime.Now,
                                    tongTien = tongTien,
                                    tienDuocGiam = tienDuocGiam,
                                    tongTienSauGiam = tongTienThanhToan,
                                    trangThai = true // Đã thanh toán
                                };

                                if (hdbll.ThemHoaDon(hd))
                                {
                                    ChiTietHoaDonSanPhamBLL cthdspBLL = new ChiTietHoaDonSanPhamBLL();
                                    List<ChiTietHoaDonSanPham> chiTietHoaDons = new List<ChiTietHoaDonSanPham>();

                                    foreach (var item in gioHangItems)
                                    {
                                        var sanPham = spbll.TimKiemSanPhamTheoMaSP(item.MaSanPham);
                                        if (sanPham == null)
                                        {
                                            MessageBox.Show($"Sản phẩm với mã {item.MaSanPham} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        ChiTietHoaDonSanPham cthd = new ChiTietHoaDonSanPham
                                        {
                                            maHoaDon = hd.maHoaDon,
                                            maSanPham = item.MaSanPham,
                                            soLuong = item.SoLuong,
                                            donGia = item.DonGiaBan,
                                            tongTien = item.TongGiaTri,
                                            tenSanPham = item.TenSanPham
                                        };
                                        chiTietHoaDons.Add(cthd);

                                        if (!cthdspBLL.ThemChiTietHoaDonSanPham(cthd))
                                        {
                                            MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }

                                    tienBiGiamText = "-" + tienBiGiamText;
                                    frmBill frmBill = new frmBill(hd, chiTietHoaDons, tienBiGiamText, tienTruocKhiGiamText, hangThanhVienText, phanTramGiamText);
                                    frmBill.ShowDialog();

                                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ResetForm();

                                    if (!string.IsNullOrEmpty(currentLoaiSp))
                                    {
                                        LoadSanPhamTheoLoai(currentLoaiSp);
                                    }
                                    else if (!string.IsNullOrEmpty(currentTenTimKiem))
                                    {
                                        LoadTatCaSanPhamTheoTenHoacMaSp(currentTenTimKiem);
                                    }
                                    else
                                    {
                                        LoadTatCaSanPham();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (decimal.TryParse(tongTienThanhToanText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongTienThanhToan))
                        {
                            HoaDon hd = new HoaDon
                            {
                                maHoaDon = hdbll.TaoMaHoaDonTuDong(),
                                maKhachHang = null,
                                maNhanVien = nv.maNhanVien,
                                ngayLap = DateTime.Now,
                                tongTien = tongTien,
                                tienDuocGiam = 0,
                                tongTienSauGiam = tongTienThanhToan,
                                trangThai = true // Đã thanh toán
                            };

                            if (hdbll.ThemHoaDon(hd))
                            {
                                ChiTietHoaDonSanPhamBLL cthdspBLL = new ChiTietHoaDonSanPhamBLL();
                                List<ChiTietHoaDonSanPham> chiTietHoaDons = new List<ChiTietHoaDonSanPham>();

                                foreach (var item in gioHangItems)
                                {
                                    var sanPham = spbll.TimKiemSanPhamTheoMaSP(item.MaSanPham);
                                    if (sanPham == null)
                                    {
                                        MessageBox.Show($"Sản phẩm với mã {item.MaSanPham} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    ChiTietHoaDonSanPham cthd = new ChiTietHoaDonSanPham
                                    {
                                        maHoaDon = hd.maHoaDon,
                                        maSanPham = item.MaSanPham,
                                        soLuong = item.SoLuong,
                                        donGia = item.DonGiaBan,
                                        tongTien = item.TongGiaTri,
                                        tenSanPham = item.TenSanPham
                                    };
                                    chiTietHoaDons.Add(cthd);

                                    if (!cthdspBLL.ThemChiTietHoaDonSanPham(cthd))
                                    {
                                        MessageBox.Show("Lỗi khi thêm chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                frmBill frmBill = new frmBill(hd, chiTietHoaDons, tienBiGiamText, tienTruocKhiGiamText, hangThanhVienText, phanTramGiamText);
                                frmBill.ShowDialog();

                                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ResetForm();

                                if (!string.IsNullOrEmpty(currentLoaiSp))
                                {
                                    LoadSanPhamTheoLoai(currentLoaiSp);
                                }
                                else if (!string.IsNullOrEmpty(currentTenTimKiem))
                                {
                                    LoadTatCaSanPhamTheoTenHoacMaSp(currentTenTimKiem);
                                }
                                else
                                {
                                    LoadTatCaSanPham();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void ResetForm()
        {
            txtTenKH.Clear();
            txtSdt.Clear();
            lblTongTien.Text = "0 đ";
            txtSdt.Enabled = false;
            txtTenKH.Enabled = false;
            btnHuyNhapTTKhach.Enabled = false;
            btnSuaSDT.Enabled = false;
            btnNhapTTKhach.Enabled = true;
            lblMucGiam.Visible = false;
            lblMucTenHang.Visible = false;
            lblTenHangKH.Visible = false;
            lblPhanTramGiam.Visible = false;
            lblTienGiamGiaVip.Visible = false;
            lblTienGiamGiaVip.Text = "";
            lblTenHangKH.Text = "";
            lblPhanTramGiam.Text = "";
            ResetGioHang();
        }

        private void ResetGioHang()
        {
            foreach (var item in gioHangItems)
            {
                item.Visible = false;
            }
            gioHangItems.Clear();
            CapNhatGioHangPanel();
            CapNhatTongTien();
        }

        private void TxtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSdt.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SanPhamItem_SanPhamClicked(object sender, EventArgs e)
        {
            SanPhamItemControl sanPhamItem = sender as SanPhamItemControl;
            if(sanPhamItem != null)
            {
                string maSp = sanPhamItem.labelMaSp.Text;
                string tenSp = sanPhamItem.labelTenSp.Text;
                string giaSanPhamText = sanPhamItem.labelGiaSanPham.Text.Replace("đ", "").Trim();
                SanPham sp = spbll.TimKiemSanPhamTheoMaSP(maSp);
                
                if(decimal.TryParse(giaSanPhamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal donGiaBan))
                {
                    int soLuong = 1;
                    decimal donGiaSale = sp.donGiaSale.HasValue ? sp.donGiaSale.Value : 0;
                    ThemSpVaoGioHang(maSp, tenSp, donGiaBan, donGiaSale, soLuong);
                }
            }
        }

        private void ThemSpVaoGioHang(string maSp, string tenSp, decimal donGiaBan, decimal donGiaSale, int soLuong)
        {
            foreach(GioHangItemControl item in gioHangItems)
            {
                if (item.labelTenSp.Text.Trim() == tenSp.Trim())
                {
                    int soLuongHienTai = (int)item.numericSoLuongSp.Value;
                    item.numericSoLuongSp.Value = soLuongHienTai + soLuong;
                    CapNhatTongTien();
                    return;
                }
            }
            GioHangItemControl gioHangItem = new GioHangItemControl();
            gioHangItem.CapNhatGioHang(maSp, tenSp, donGiaBan, donGiaSale, soLuong);
            gioHangItem.SoLuongThayDoi += GioHangItem_SoLuongThayDoi;
            gioHangItem.XoaSanPhamKhoiGioHang += GioHangItem_XoaSanPhamKhoiGioHang;
            gioHangPanel.Controls.Add(gioHangItem);
            gioHangItems.Add(gioHangItem);
            CapNhatTongTien();
        }

        private void CapNhatGioHangPanel()
        {
            gioHangPanel.SuspendLayout(); // Tạm dừng cập nhật giao diện
            foreach (GioHangItemControl item in gioHangItems)
            {
                if (item.Visible)
                {
                    gioHangPanel.Controls.Add(item);
                }
            }
            gioHangPanel.ResumeLayout(); // Tiếp tục cập nhật giao diện
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            decimal tongTienTruocKhiGiam = 0;
            decimal tienSanPhamDuocGiamGia = 0;

            foreach (GioHangItemControl item in gioHangItems)
            {
                string tongGiaTriText = item.labelTongGiaTri.Text.Replace("đ", "").Trim();
                if (decimal.TryParse(tongGiaTriText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal tongGiaTri))
                {
                    tongTien += tongGiaTri;
                }

                tongTienTruocKhiGiam += item.TongTienTruocKhiGiamGiaSp;
            }

            this.lblTongTien.Text = tongTien.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
            decimal tongTienThanhToan = 0;
            if(!lblPhanTramGiam.Visible)
            {
                tongTienThanhToan = tongTien;
            }
            else
            {
                string TienGiamGiaVipText = lblTienGiamGiaVip.Text.Replace("-", "").Trim();
                if (decimal.TryParse(TienGiamGiaVipText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal TienGiamGiaVip))
                { 
                    tongTienThanhToan = tongTien - TienGiamGiaVip;
                }
            }
            this.lblTienThanhToan.Text = tongTienThanhToan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
            tienSanPhamDuocGiamGia = tongTienTruocKhiGiam - tongTien;
            if(tienSanPhamDuocGiamGia != 0)
            {
                lblGiamGiaSanPham.Text = tienSanPhamDuocGiamGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
                lblMucGiamGiaSanPham.Visible = true;
                lblGiamGiaSanPham.Visible = true;
            }
        }

        private void GioHangItem_XoaSanPhamKhoiGioHang(object sender, EventArgs e)
        {
            GioHangItemControl item = sender as GioHangItemControl;
            if(item != null)
            {
                string maSp = item.MaSanPham;
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSp} này khỏi giỏ hàng?", "Xác nhận xóa", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    item.Visible = false;
                    gioHangItems.Remove(item);
                    CapNhatGioHangPanel();
                    CapNhatTongTien();
                }
            }
        }

        private void GioHangItem_SoLuongThayDoi(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private bool KiemTraTruocKhiThanhToan()
        {
            bool dinhDang = true;
            errorTTKhach.Clear();
            KiemTraInputSoDienThoai();
            if (string.IsNullOrWhiteSpace(txtTenKH.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTKhach.SetError(txtTenKH, "Vui lòng nhập họ tên khách hàng");
                dinhDang = false;
            }
            return dinhDang;
        }

        private bool KiemTraInputSoDienThoai()
        {
            bool dinhDang = true;
            errorTTKhach.Clear();
            if (string.IsNullOrWhiteSpace(txtSdt.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTKhach.SetError(txtSdt, "Vui lòng nhập số điện thoại khách hàng");
                dinhDang = false;
            }
            else if (txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorTTKhach.SetError(txtSdt, "Vui lòng nhập đúng định dạng số điện thoại");
                dinhDang = false;
            }
            return dinhDang;
        }

        // Load loai san pham, san pham
        private void BtnTatCaSanPham_Click(object sender, EventArgs e)
        {
            LoadTatCaSanPham();
        }

        private void AddLoaiSpButton(string tenLoaiSp, string maLoaiSp)
        {
            UIButton loaiSpButton = new UIButton();
            loaiSpButton.Text = tenLoaiSp;
            loaiSpButton.BackColor = SystemColors.Window;
            loaiSpButton.Cursor = Cursors.Hand;
            loaiSpButton.Dock = DockStyle.Top;
            loaiSpButton.FillColor = SystemColors.Window;
            loaiSpButton.FillHoverColor = Color.White;
            loaiSpButton.FillPressColor = Color.White;
            loaiSpButton.FillSelectedColor = Color.White;
            loaiSpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163)));
            loaiSpButton.ForeColor = Color.Black;
            loaiSpButton.ForeHoverColor = Color.Black;
            loaiSpButton.ForePressColor = Color.Magenta;
            loaiSpButton.ForeSelectedColor = Color.Magenta;
            loaiSpButton.MinimumSize = new Size(1, 1);
            loaiSpButton.Padding = new Padding(20);
            loaiSpButton.RectColor = SystemColors.Window;
            loaiSpButton.RectHoverColor = Color.Magenta;
            loaiSpButton.RectPressColor = Color.Magenta;
            loaiSpButton.RectSelectedColor = Color.Magenta;
            loaiSpButton.Size = new Size(this.btnTatCaSanPham.Width, 62);
            loaiSpButton.TextAlign = ContentAlignment.MiddleLeft;
            loaiSpButton.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            loaiSpButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

            loaiSpButton.Click += (s, e) => LoadSanPhamTheoLoai(maLoaiSp);
            loaiSpPanel.Controls.Add(loaiSpButton);
        }

        private void LoadLoaiSanPham()
        {
            List<LoaiSanPham> loaiSanPhams = lspbll.LayDanhSachSanPham();

            foreach (var loaisp in loaiSanPhams)
            {
                AddLoaiSpButton(loaisp.tenLoaiSanPham, loaisp.maLoaiSanPham);
            }
        }

        private void LoadTatCaSanPham()
        {
            currentLoaiSp = null;
            currentTenTimKiem = null;
            sanPhamPanel.Visible = false;
            this.sanPhamPanel.BackColor = Color.HotPink;
            List<SanPham> sanPhams = spbll.LoadTatCaSanPham();

            sanPhamPanel.Controls.Clear();
            SanPhamItemControl tempItem = new SanPhamItemControl();
            int itemWidth = tempItem.Width;
            int itemHeight = tempItem.Height;
            int padding = 10;
            int availableWidth = sanPhamPanel.ClientSize.Width;

            // Tính số cột
            int columnCount = Math.Max(1, availableWidth / (itemWidth + padding));

            // Cập nhật RowCount và ColumnCount
            sanPhamPanel.ColumnCount = columnCount;
            sanPhamPanel.RowCount = 0;

            // Xóa các RowStyle và ColumnStyle cũ
            sanPhamPanel.RowStyles.Clear();
            sanPhamPanel.ColumnStyles.Clear();

            for (int i = 0; i < sanPhamPanel.RowCount; i++)
            {
                sanPhamPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Chiều cao tự động
            }

            for (int i = 0; i < columnCount; i++)
            {
                sanPhamPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount)); // Chiều rộng chia đều
            }

            int row = 0;
            int column = 0;

            foreach (var sp in sanPhams)
            {
                SanPhamItemControl sanPhamItem = new SanPhamItemControl();
                sanPhamItem.SetSanPhamData(sp.hinhAnh, sp.maSanPham, sp.tenSanPham, sp.donGiaBan);
                sanPhamItem.Margin = new Padding(padding);
                sanPhamItem.Size = new Size(itemWidth, itemHeight);
                sanPhamItem.SanPhamClicked += SanPhamItem_SanPhamClicked;

                sanPhamPanel.Controls.Add(sanPhamItem, column, row);

                column++;
                if (column >= columnCount)
                {
                    column = 0;
                    row++;
                }
            }

            sanPhamPanel.Visible = true; // Hiện panel sau khi đã cập nhật
        }

        private void LoadSanPhamTheoLoai(string maLoaiSanPham)
        {
            currentTenTimKiem = null;
            currentLoaiSp = maLoaiSanPham;

            sanPhamPanel.Visible = false;
            this.sanPhamPanel.BackColor = Color.HotPink;
            List<SanPham> sanPhams = spbll.LayDanhSachSanPhamTheoMaLoai(maLoaiSanPham);

            sanPhamPanel.Controls.Clear();

            SanPhamItemControl tempItem = new SanPhamItemControl();
            int itemWidth = tempItem.Width;
            int itemHeight = tempItem.Height;
            int padding = 10;
            int availableWidth = sanPhamPanel.ClientSize.Width;

            // Tính số cột
            int columnCount = Math.Max(1, availableWidth / (itemWidth + padding));

            // Cập nhật RowCount và ColumnCount
            sanPhamPanel.ColumnCount = columnCount;
            sanPhamPanel.RowCount = 0;

            // Xóa các RowStyle và ColumnStyle cũ
            sanPhamPanel.RowStyles.Clear();
            sanPhamPanel.ColumnStyles.Clear();

            for (int i = 0; i < sanPhamPanel.RowCount; i++)
            {
                sanPhamPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Chiều cao tự động
            }

            for (int i = 0; i < columnCount; i++)
            {
                sanPhamPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount)); // Chiều rộng chia đều
            }

            int row = 0;
            int column = 0;

            foreach (var sp in sanPhams)
            {
                SanPhamItemControl sanPhamItem = new SanPhamItemControl();
                sanPhamItem.SetSanPhamData(sp.hinhAnh, sp.maSanPham, sp.tenSanPham, sp.donGiaBan);
                sanPhamItem.Margin = new Padding(padding);
                sanPhamItem.Size = new Size(itemWidth, itemHeight);
                sanPhamItem.SanPhamClicked += SanPhamItem_SanPhamClicked;

                sanPhamPanel.Controls.Add(sanPhamItem, column, row);

                column++;
                if (column >= columnCount)
                {
                    column = 0;
                    row++;
                }
            }

            sanPhamPanel.Visible = true;
        }

        // Bộ lọc
        private void BtnLamMoiTimKiem_Click(object sender, EventArgs e)
        {
            txtNhapMaHoacTenSP.Text = "";
        }

        private void BtnXacNhanTimKiem_Click(object sender, EventArgs e)
        {
            string tenSPTimKiem = txtNhapMaHoacTenSP.Text.Trim();
            LoadTatCaSanPhamTheoTenHoacMaSp(tenSPTimKiem);
        }

        private void LoadTatCaSanPhamTheoTenHoacMaSp(string tenHoacMaSpTimKiem)
        {
            currentTenTimKiem = tenHoacMaSpTimKiem;
            currentLoaiSp = null;

            sanPhamPanel.Visible = false;
            this.sanPhamPanel.BackColor = Color.HotPink;
            List<SanPham> sanPhams = spbll.LoadSpTheoTenHoacMaSp(tenHoacMaSpTimKiem);

            sanPhamPanel.Controls.Clear();

            SanPhamItemControl tempItem = new SanPhamItemControl();
            int itemWidth = tempItem.Width;
            int itemHeight = tempItem.Height;
            int padding = 10;
            int availableWidth = sanPhamPanel.ClientSize.Width;

            // Tính số cột
            int columnCount = Math.Max(1, availableWidth / (itemWidth + padding));

            // Cập nhật RowCount và ColumnCount
            sanPhamPanel.ColumnCount = columnCount;
            sanPhamPanel.RowCount = 0;

            // Xóa các RowStyle và ColumnStyle cũ
            sanPhamPanel.RowStyles.Clear();
            sanPhamPanel.ColumnStyles.Clear();

            for (int i = 0; i < sanPhamPanel.RowCount; i++)
            {
                sanPhamPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // Chiều cao tự động
            }

            for (int i = 0; i < columnCount; i++)
            {
                sanPhamPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnCount)); // Chiều rộng chia đều
            }

            int row = 0;
            int column = 0;

            foreach (var sp in sanPhams)
            {
                SanPhamItemControl sanPhamItem = new SanPhamItemControl();
                sanPhamItem.SetSanPhamData(sp.hinhAnh, sp.maSanPham, sp.tenSanPham, sp.donGiaBan);
                sanPhamItem.Margin = new Padding(padding);
                sanPhamItem.Size = new Size(itemWidth, itemHeight);
                sanPhamItem.SanPhamClicked += SanPhamItem_SanPhamClicked;

                sanPhamPanel.Controls.Add(sanPhamItem, column, row);

                column++;
                if (column >= columnCount)
                {
                    column = 0;
                    row++;
                }
            }

            sanPhamPanel.Visible = true;
        }

        // Nut cua form
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

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormDangNhap frm = new FormDangNhap();
                frm.Show();
                this.Hide();
            }
        }
    }
}
