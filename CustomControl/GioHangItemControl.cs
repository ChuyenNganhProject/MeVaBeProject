using BLL;
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

namespace CustomControl
{
    public partial class GioHangItemControl : UserControl
    {
        public event EventHandler SoLuongThayDoi;
        public event EventHandler XoaSanPhamKhoiGioHang;

        SanPhamBLL spbll = new SanPhamBLL();
        public string MaSanPham { get; private set; }
        public int SoLuong { get; private set; }
        public decimal DonGia { get; private set; }
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
            string donGiaText = this.labelDonGia.Text.Replace("đ", "").Trim();
            if (decimal.TryParse(donGiaText, NumberStyles.Number, CultureInfo.GetCultureInfo("vi-VN"), out decimal donGia))
            {
                int soLuong = (int)this.numericSoLuongSp.Value;

                this.SoLuong = soLuong;
                this.TongGiaTri = donGia * soLuong;

                this.labelTongGiaTri.Text = (donGia * soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";

                SoLuongThayDoi?.Invoke(this, e);
            }
        }

        // Thêm sản phẩm vào giỏ hàng
        public void CapNhatGioHang(string maSp, string tenSp, decimal donGia, int soLuong)
        {   
            this.numericSoLuongSp.Maximum = spbll.LaySanPhamTheoMa(maSp).soLuong.Value;
            this.MaSanPham = maSp;
            this.TenSanPham = tenSp;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.TongGiaTri = soLuong * donGia;
            this.labelTenSp.Text = tenSp;
            this.labelDonGia.Text = donGia.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
            this.numericSoLuongSp.Value = soLuong;
            this.labelTongGiaTri.Text = (donGia * soLuong).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
        }
    }
}
