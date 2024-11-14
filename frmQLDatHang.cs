using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace MeVaBeProject
{
    public partial class frmQLDatHang : Form
    {
        private string maNhanVien;
        private PhieuDatBLL phieuDatBLL;
        private ChiTietPhieuDatBLL chiTietPhieuDatBLL;
        private BindingSource bindingSource;
        private BindingSource bindingSourceCTPD;
        public frmQLDatHang(string maNhanVien)
        {
            this.maNhanVien = maNhanVien;
            this.phieuDatBLL = new PhieuDatBLL();
            this.chiTietPhieuDatBLL = new ChiTietPhieuDatBLL();
            this.bindingSource = new BindingSource();
            this.bindingSourceCTPD = new BindingSource();
            InitializeComponent();
        }
        private void btnTaoPhieuDat_Click(object sender, EventArgs e)
        {
            frmDatHang frmDatHang = new frmDatHang(maNhanVien,true,string.Empty,string.Empty);
            frmDatHang.ShowDialog();
        }
        private void btnXoaPhieuDat_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhieuDat.SelectedRows.Count>0)
            {
                string trangThai = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["trangThai"].Value.ToString();
                if (trangThai != "Đã duyệt")
                {
                    string maPhieuDat = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["maPhieuDat"].Value.ToString();
                    DialogResult r = MessageBox.Show(this, "Bạn có chắc chắn muốn xóa phiếu đặt này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (r == DialogResult.Yes)
                    {
                        bool result = phieuDatBLL.XoaPhieuDat(maPhieuDat);
                        if (result)
                        {
                            MessageBox.Show(this, "Xóa phiếu đặt thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show(this, "Xóa phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }   
                }
                else
                {
                    MessageBox.Show(this, "Không thể xóa phiếu đặt", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }            
        }
        private void btnSuaPhieuDat_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhieuDat.SelectedRows.Count>0)
            {
                string trangThai = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["trangThai"].Value.ToString();
                if (trangThai!="Đã duyệt")
                {
                    string maPhieuDat = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["maPhieuDat"].Value.ToString();
                    string maNhaCungCap = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["maNhaCungCap"].Value.ToString();
                    frmDatHang frmDatHang = new frmDatHang(maNhanVien, false, maPhieuDat,maNhaCungCap);
                    frmDatHang.ShowDialog();
                }
                else
                {
                    MessageBox.Show(this, "Không thể sửa phiếu đặt", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void LoadData()
        {
            List<PhieuDat> phieuDats = phieuDatBLL.LayDanhSachPhieuDat();
            bindingSource.DataSource = phieuDats;
            dtgvDanhSachPhieuDat.DataSource = bindingSource;
            dtgvDanhSachPhieuDat.Columns["maNhaCungCap"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["NhaCungCap"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["maNhanVien"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["NhanVien"].Visible = false;
        }
        private void frmQLDatHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void dtNgayTaoPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            bindingSource.DataSource = phieuDatBLL.LocDanhSachPhieuDatTheoNgayLap(dtNgayTaoPhieuNhap.Value);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maPhieuDat = txtTimKiem.Text;
            bindingSource.DataSource = phieuDatBLL.TimKiemPhieuDatTheoMaPhieuDat(maPhieuDat);
        }
        private void dtgvDanhSachPhieuDat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlPhieuDat.SelectedTab = tabChiTiet;
            string maPhieuDat = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["maPhieuDat"].Value.ToString();
            bindingSourceCTPD.DataSource = chiTietPhieuDatBLL.LayChiTietPhieuDat(maPhieuDat);
            dtgvChiTietPhieuDat.DataSource = bindingSourceCTPD;
            dtgvChiTietPhieuDat.Columns["PhieuDat"].Visible = false;
            dtgvChiTietPhieuDat.Columns["SanPham"].Visible = false;           
        }
        private void tabControlPhieuDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPhieuDat.SelectedTab == tabDanhSach)
            {
                bindingSourceCTPD.Clear();
            }
        }
        private void btnInPhieuDat_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhieuDat.SelectedRows.Count>0)
            {

            }
        }
        private void btnDuyetPhieuDat_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachPhieuDat.SelectedRows.Count > 0)
            {
                string maPhieuDat = dtgvDanhSachPhieuDat.SelectedRows[0].Cells["maPhieuDat"].Value.ToString();
                bool result = phieuDatBLL.DuyetPhieuDat(maPhieuDat);
                if (result)
                {
                    MessageBox.Show(this, "Duyệt phiếu đặt thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(this, "Duyệt phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void dtgvDanhSachPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string trangThai = dtgvDanhSachPhieuDat.Rows[e.RowIndex].Cells["trangThai"].Value.ToString();
                if (trangThai!="Đã duyệt")
                {
                    btnDuyetPhieuDat.Enabled = true;
                }
                else
                {
                    btnDuyetPhieuDat.Enabled = false;
                }
            }
        }
    }
}
