using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class GioHangItemControl : UserControl
    {
        public event EventHandler SoLuongThayDoi;
        public event EventHandler XoaSanPhamKhoiGioHang;

        SanPhamBLL spbll = new SanPhamBLL();
        KhuyenMaiSanPhamBLL kmspbll = new KhuyenMaiSanPhamBLL();
        KhuyenMaiBLL kmbll = new KhuyenMaiBLL();
        public string MaSanPham { get; private set; }
        public int SoLuong { get; private set; }
        public decimal DonGiaBan { get; set; }
        public decimal DonGiaGoc { get; private set; }
        public decimal TongTienTruocKhiGiamGiaSp { get; private set; }
        public decimal TongGiaTri { get; private set; }
        public string TenSanPham { get; private set; }

        public GioHangItemControl()
        {
            InitializeComponent();
            this.numericSoLuongSp.ValueChanged += NumericSoLuongSp_ValueChanged;
            this.btnXoa.Click += BtnXoa_Click;
            this.numericSoLuongSp.KeyPress += NumericSoLuongSp_KeyPress;
        }

        private void NumericSoLuongSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            XoaSanPhamKhoiGioHang?.Invoke(this, e);
        }

        private void NumericSoLuongSp_ValueChanged(object sender, EventArgs e)
        {
            SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSanPham);
            int max = sanPham.soLuong.Value;
            int soLuong = (int)this.numericSoLuongSp.Value;

            if (soLuong > max)
            {
                MessageBox.Show(this,"Số lượng sản phẩm hiện tại: " + max, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.numericSoLuongSp.Value = max;
                return;
            }
            // Đặt giá trị Maximum sau khi kiểm tra số lượng
            this.numericSoLuongSp.Maximum = max;

            string donGiaText = this.labelGiaTinhTien.Text.Replace("đ", "").Trim();
            if (decimal.TryParse(donGiaText, NumberStyles.Number, CultureInfo.GetCultureInfo("vi-VN"), out decimal donGia))
            {
                this.SoLuong = soLuong;
                this.TongGiaTri = donGia * soLuong;

                this.labelTongGiaTri.Text = (donGia * soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";

                SoLuongThayDoi?.Invoke(this, e);
            }
        }

        // Thêm sản phẩm vào giỏ hàng
        public void CapNhatGioHang(string maSp, string tenSp, decimal donGia, int soLuong)
        {
            SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(maSp);
            this.TongTienTruocKhiGiamGiaSp = soLuong * donGia;
            
            this.MaSanPham = maSp;
            this.TenSanPham = tenSp;
            this.SoLuong = soLuong;
            this.DonGiaGoc = donGia;
            this.lblGiaGoc.Text = donGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
            decimal donGiaSale = sanPham.donGiaSale.HasValue ? sanPham.donGiaSale.Value : 0;

            List<KhuyenMaiSanPham> kmsp = kmspbll.LayKhuyenMaiTheoSanPham(maSp);
            if(kmsp.Count() != 0)
            {
                foreach (var km in kmsp)
                {
                    KhuyenMai khuyenMai = kmbll.LayTTKhuyenMaiTuMaKM(km.maKhuyenMai);
                    if (khuyenMai.trangThai == "Đang diễn ra" && donGiaSale > 0)
                    {
                        this.DonGiaBan = donGiaSale;
                        this.labelGiaTinhTien.Text = DonGiaBan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
                        this.lblGiaGoc.Font = new Font(lblGiaGoc.Font, FontStyle.Strikeout);
                        this.lblGiaGoc.Visible = true;
                        this.TongGiaTri = soLuong * donGiaSale;
                        decimal phantramgiamsp = km.phanTramGiam.Value;
                        this.lblPhanTramGiamSp.Text = "(-" + phantramgiamsp + "%)";
                        this.lblPhanTramGiamSp.Visible = true;
                    }
                    else if(donGiaSale > 0 && khuyenMai.trangThai != "Đang diễn ra")
                    {
                        continue;
                    }
                    else if(donGiaSale == 0)
                    {
                        this.DonGiaBan = donGia;
                        this.labelGiaTinhTien.Text = donGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
                        this.TongGiaTri = soLuong * donGia;
                        this.lblPhanTramGiamSp.Visible = false;
                        this.lblGiaGoc.Visible = false;
                    }
                }
            }
            else
            {
                this.DonGiaBan = donGia;
                this.labelGiaTinhTien.Text = donGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
                this.TongGiaTri = soLuong * donGia;
                this.lblPhanTramGiamSp.Visible = false;
                this.lblGiaGoc.Visible = false;
            }
            this.labelTenSp.Text = tenSp;
            this.numericSoLuongSp.Value = soLuong;
            this.labelTongGiaTri.Text = this.TongGiaTri.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
        }
    }
}
