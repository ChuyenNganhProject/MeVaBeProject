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

namespace MeVaBeProject
{
    public partial class frmDashboard : Form
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        KhachHangBLL khbll = new KhachHangBLL();

        public frmDashboard()
        {
            InitializeComponent();
            this.Load += FrmDashboard_Load;
            this.btnLocThangNay.Click += BtnLocThangNay_Click;
            this.btnLoc30NgayQua.Click += BtnLoc30NgayQua_Click;
            this.btnLoc7NgayQua.Click += BtnLoc7NgayQua_Click;
            this.btnLocHomNay.Click += BtnLocHomNay_Click;
            this.btnCustom.Click += BtnCustom_Click;
            this.btnLocTheoCustom.Click += BtnLocTheoCustom_Click;
            this.btnLocNamNay.Click += BtnLocNamNay_Click;
        }

        private void BtnLocNamNay_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongHoaDonNamNay().ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThuNamNay();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnLocTheoCustom_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongSoHoaDonTheoKhoangThoiGian(dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date).ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThuTheoKhoangThoiGian(dtpNgayBatDau.Value.Date, dtpNgayKetThuc.Value.Date);
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";

        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            btnLocTheoCustom.Enabled = true;
        }

        private void BtnLocHomNay_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongHoaDonHomNay().ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThuHomNay();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnLoc7NgayQua_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongHoaDon7NgayQua().ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThu7NgayQua();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnLoc30NgayQua_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongHoaDon30NgayQua().ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThu30NgayQua();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnLocThangNay_Click(object sender, EventArgs e)
        {
            lblSoLuongHD.Text = hdbll.TongHoaDonThangNay().ToString("N0").Replace(",", ".");

            decimal tongDoanhThu = hdbll.TinhDoanhThuThangNay();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            int tongHD = hdbll.TongSoHoaDon();
            int tongKH = khbll.TongSoKhachHang();
            decimal tongDoanhThu = hdbll.TinhTongDoanhThu();
            lblSoLuongKH.Text = tongKH.ToString();
            lblSoLuongHD.Text = tongHD.ToString();
            lblDoanhThu.Text = tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }
    }
}
