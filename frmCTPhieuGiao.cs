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
    public partial class frmCTPhieuGiao : Form
    {
        private string MaPG;
        private string MaHD;
        private string TenNV;
        PhieuGiaoHangBLL pgbll = new PhieuGiaoHangBLL();
        ChiTietPhieuGiaoBLL ctpgbll = new ChiTietPhieuGiaoBLL();
        public frmCTPhieuGiao(string mapg, string mahd, string tenNV)
        {
            InitializeComponent();
            this.MaPG = mapg;
            this.MaHD = mahd;
            this.TenNV = tenNV;

            this.Load += FrmCTPhieuGiao_Load;
            this.dgvCTPG.CellFormatting += DgvCTPG_CellFormatting;
            this.btnThoat.Click += BtnThoat_Click;
        }

        private void DgvCTPG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCTPG.Columns[e.ColumnIndex].Name == "soLuong")
            {
                dgvCTPG.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                return;
            }
            if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal tien))
            {
                dgvCTPG.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.Value = tien.ToString("N0").Replace(",", ".") + "đ";
                e.FormattingApplied = true;
            }
        }

        private void FrmCTPhieuGiao_Load(object sender, EventArgs e)
        {
            PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(MaPG);
            lblMaPG.Text = MaPG;
            lblMaHD.Text = MaHD;
            lblTenKH.Text = phieuGiao.tenKhachHang;
            lblTenNV.Text = TenNV;
            lblNgayLap.Text = phieuGiao.ngayLap.Value.ToString("dd/MM/yyyy");
            lblPhiVanChuyen.Text = phieuGiao.chiPhi.Value.ToString("N0").Replace(",", ".");

            dgvCTPG.DataSource = ctpgbll.LoadCTPGChoForm(MaPG);
            dgvCTPG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SettingDgv();
            decimal tongGiaTri = 0;
            if (dgvCTPG.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvCTPG.Rows)
                {
                    string tongTienText = row.Cells["tongTien"].Value.ToString().Replace("đ", "");
                    decimal tongTien = decimal.Parse(tongTienText);
                    tongGiaTri += tongTien;
                }
            }
            lblTongGiaTri.Text = tongGiaTri.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingDgv()
        {
            if (dgvCTPG.Columns["SanPham"] != null)
            {
                dgvCTPG.Columns["SanPham"].Visible = false;
            }
            if (dgvCTPG.Columns["maHoaDon"] != null)
            {
                dgvCTPG.Columns["maHoaDon"].Visible = false;
            }
            if (dgvCTPG.Columns["STT"] != null)
            {
                dgvCTPG.Columns["STT"].Visible = false;
            }
            if (dgvCTPG.Columns["PhieuGiaoHang"] != null)
            {
                dgvCTPG.Columns["PhieuGiaoHang"].Visible = false;
            }
            if (dgvCTPG.Columns["ChiTietHoaDonSanPham"] != null)
            {
                dgvCTPG.Columns["ChiTietHoaDonSanPham"].Visible = false;
            }
            if (dgvCTPG.Columns["maPhieuGiao"] != null)
            {
                dgvCTPG.Columns["maPhieuGiao"].Visible = false;
            }

            if (dgvCTPG.Columns["tenSanPham"] != null)
            {
                dgvCTPG.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
            }
            if (dgvCTPG.Columns["maSanPham"] != null)
            {
                dgvCTPG.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
            }
            if (dgvCTPG.Columns["soLuong"] != null)
            {
                dgvCTPG.Columns["soLuong"].HeaderText = "Số lượng";
            }
            if (dgvCTPG.Columns["donGia"] != null)
            {
                dgvCTPG.Columns["donGia"].HeaderText = "Đơn giá";
            }
            if (dgvCTPG.Columns["tongTien"] != null)
            {
                dgvCTPG.Columns["tongTien"].HeaderText = "Tổng tiền";
            }

            dgvCTPG.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCTPG.Columns["soLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvCTPG.Columns["maSanPham"].DisplayIndex = 0;
            dgvCTPG.Columns["tenSanPham"].DisplayIndex = 1;
            dgvCTPG.Columns["soLuong"].DisplayIndex = 2;
            dgvCTPG.Columns["donGia"].DisplayIndex = 3;
            dgvCTPG.Columns["tongTien"].DisplayIndex = 4;
        }
    }
}
