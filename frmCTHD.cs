﻿using BLL;
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
    public partial class frmCTHD : Form
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        ChiTietHoaDonSanPhamBLL cthdspbll = new ChiTietHoaDonSanPhamBLL();
        private string mahd;
        public frmCTHD(string mahd)
        {
            InitializeComponent();
            this.Load += FrmCTHD_Load;
            this.mahd = mahd;

            this.dgvCTHD.CellFormatting += DgvCTHD_CellFormatting;
            this.btnThoat.Click += BtnThoat_Click;
        }

        private void DgvCTHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal tien))
            {
                dgvCTHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                // Định dạng giá trị và loại bỏ phần thập phân
                e.Value = tien.ToString("N0").Replace(",", "."); // Thay đổi dấu phẩy thành dấu chấm
                e.FormattingApplied = true; // Đánh dấu rằng định dạng đã được áp dụng
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmCTHD_Load(object sender, EventArgs e)
        {
            HoaDon hoadon = hdbll.LoadHoaDonTheoMa(mahd);
            lblMaHD.Text = mahd;
            lblTenKH.Text = hoadon.tenKhachHang;
            lblTenNV.Text = hoadon.tenNhanVien;
            lblNgayLap.Text = hoadon.ngayLap.Value.ToString("dd/MM/yyyy");
            
            dgvCTHD.DataSource = cthdspbll.LoadCTHDSanPham(mahd);
            dgvCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SettingDgv();

            decimal tongTien = hoadon.tongTien.Value;
            decimal tienDuocGiam = hoadon.tienDuocGiam.Value;
            decimal tongTienThanhToan = hoadon.tongTienSauGiam.Value;
            
            lblTongTien.Text = tongTien.ToString("N0").Replace(",", ".") + "đ";
            lblTienDuocGiam.Text = "- " + tienDuocGiam.ToString("N0").Replace(",", ".") + "đ";
            lblTongTienHD.Text = tongTienThanhToan.ToString("N0").Replace(",", ".") + "đ";
        }

        private void SettingDgv()
        {
            if (dgvCTHD.Columns["SanPham"] != null)
            {
                dgvCTHD.Columns["SanPham"].Visible = false;
            }
            if (dgvCTHD.Columns["HoaDon"] != null)
            {
                dgvCTHD.Columns["HoaDon"].Visible = false;
            }
            if (dgvCTHD.Columns["maHoaDon"] != null)
            {
                dgvCTHD.Columns["maHoaDon"].Visible = false;
            }

            if (dgvCTHD.Columns["tenSanPham"] != null)
            {
                dgvCTHD.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
            }
            if (dgvCTHD.Columns["maSanPham"] != null)
            {
                dgvCTHD.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
            }
            if (dgvCTHD.Columns["soLuong"] != null)
            {
                dgvCTHD.Columns["soLuong"].HeaderText = "Số lượng";
            }
            if (dgvCTHD.Columns["donGia"] != null)
            {
                dgvCTHD.Columns["donGia"].HeaderText = "Đơn giá";
            }
            if (dgvCTHD.Columns["tongTien"] != null)
            {
                dgvCTHD.Columns["tongTien"].HeaderText = "Tổng tiền";
            }

            dgvCTHD.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvCTHD.Columns["maSanPham"].DisplayIndex = 0;
            dgvCTHD.Columns["tenSanPham"].DisplayIndex = 1;
            dgvCTHD.Columns["soLuong"].DisplayIndex = 2;
            dgvCTHD.Columns["donGia"].DisplayIndex = 3;
            dgvCTHD.Columns["tongTien"].DisplayIndex = 4;
        }
    }
}
