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
namespace MeVaBeProject
{
    public partial class frmQLNhapHang : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        private PhieuDatBLL phieuDatBLL;
        private PhieuNhapBLL phieuNhapBLL;
        private ChiTietPhieuNhapBLL chiTietPhieuNhapBLL;
        private BindingSource bindingSource;
        private BindingSource bindingSourceCTPN; 
        private string maNhanVien;
        public frmQLNhapHang(string maNhanVien)
        {
            this.nhaCungCapBLL = new NhaCungCapBLL();
            this.phieuDatBLL = new PhieuDatBLL();
            this.phieuNhapBLL = new PhieuNhapBLL();
            this.chiTietPhieuNhapBLL = new ChiTietPhieuNhapBLL();
            this.maNhanVien = maNhanVien;
            this.bindingSource = new BindingSource();
            this.bindingSourceCTPN = new BindingSource();
            InitializeComponent();
        }
        private void LoadData()
        {
            List<PhieuNhap> danhSachPhieuNhap = phieuNhapBLL.LayDanhSachPhieuNhap();
            bindingSource.DataSource = danhSachPhieuNhap;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            this.rdbtnMaPhieuNhap.Checked = true;
            LoadData();
            dtgvPhieuNhap.DataSource = bindingSource;
            dtgvPhieuNhap.Columns["maNhanVien"].Visible = false;
            dtgvPhieuNhap.Columns["PhieuDat"].Visible = false;
        }   
        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {                          
            frmNhapHang frmNhapHang = new frmNhapHang(maNhanVien);
            frmNhapHang.ShowDialog();         
        }
        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dtgvPhieuNhap.SelectedRows.Count > 0)
            {
                string maPhieuNhap = dtgvPhieuNhap.SelectedRows[0].Cells["maPhieuNhap"].Value.ToString();
                frmPhieuNhapHang frmPhieuNhap = new frmPhieuNhapHang(maPhieuNhap);
                frmPhieuNhap.ShowDialog();
            }
        }
        private void dtgvPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlPhieuNhap.SelectedTab = tbChiTiet;
            string maPhieuNhap = dtgvPhieuNhap.Rows[e.RowIndex].Cells["maPhieuNhap"].Value.ToString();
            bindingSourceCTPN.DataSource = chiTietPhieuNhapBLL.LayDanhSachChiTietPhieuNhap(maPhieuNhap);
            dtgvChiTietPhieuNhap.DataSource = bindingSourceCTPN;
            dtgvChiTietPhieuNhap.Columns["phieuDat"].Visible = false;
            dtgvChiTietPhieuNhap.Columns["PhieuNhap"].Visible = false;
            dtgvChiTietPhieuNhap.Columns["ChiTietPhieuDat"].Visible = false;
        }
        private void tabControlPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPhieuNhap.SelectedTab == tabPhieuNhap)
            {
                bindingSourceCTPN.Clear();
            }            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbtnMaPhieuNhap.Checked)
            {
                string maPhieuNhap = txtTimKiem.Text.Trim();
                bindingSource.DataSource = phieuNhapBLL.TimKiemPhieuNhapTheoMaPhieuNhap(maPhieuNhap);
            }
            else
            {
                string maPhieuDat = txtTimKiem.Text.Trim();
                bindingSource.DataSource = phieuNhapBLL.TimKiemPhieuNhapTheoMaPhieuDat(maPhieuDat);
            }
        }

        private void dtNgayTaoPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = phieuNhapBLL.LocDanhSachPhieuNhapTheoNgayLap(dtNgayTaoPhieuNhap.Value);
        }
    }
}
