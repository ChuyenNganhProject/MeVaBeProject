using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using Sunny.UI.Win32;
namespace MeVaBeProject
{
    public partial class frmNhapHang : Form
    {
        private string maPhieuNhap;
        private string maNhanVien;
        private PhieuDatBLL phieuDatBLL;
        private PhieuNhapBLL phieuNhapBLL;
        private ChiTietPhieuNhapBLL chiTietPhieuNhapBLL;
        private ChiTietPhieuDatBLL chiTietPhieuDatBLL;
        public frmNhapHang(string maNhanVien)
        {
            this.phieuNhapBLL = new PhieuNhapBLL();
            this.phieuDatBLL = new PhieuDatBLL();
            this.chiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
            this.chiTietPhieuDatBLL = new ChiTietPhieuDatBLL();
            InitializeComponent();
            this.maPhieuNhap = phieuNhapBLL.TaoMaPhieuNhap();
            this.maNhanVien = maNhanVien;
            this.Load += FrmNhapHang_Load;
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Text = maPhieuNhap;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnChonPhieuDat_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieuDat frmDanhSachPhieuDat = new frmDanhSachPhieuDat();
            frmDanhSachPhieuDat.DataSent += FormDanhSachPhieuDat_SendData;
            frmDanhSachPhieuDat.ShowDialog();
        }
        private void FormDanhSachPhieuDat_SendData(string maPhieuDat)
        {
            PhieuDat phieuDat = phieuDatBLL.TimKiemPhieuDatTheoMaPhieuDat(maPhieuDat);
            txtMaPhieuDat.Text = phieuDat.maPhieuDat;
            txtNhaCungCap.Text = phieuDat.NhaCungCap.tenNhaCungCap;
            dtgvSanPhamTrongPhieuDat.DataSource = chiTietPhieuDatBLL.LayChiTietPhieuDat(maPhieuDat);
            dtgvSanPhamTrongPhieuDat.Columns["maPhieuDat"].Visible = false;
            dtgvSanPhamTrongPhieuDat.Columns["PhieuDat"].Visible = false;
            dtgvSanPhamTrongPhieuDat.Columns["SanPham"].Visible = false;
            dtgvSanPhamTrongPhieuDat.Columns["soLuongDat"].Visible = false;
        }
    }
}
