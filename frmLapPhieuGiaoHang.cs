using BLL;
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
    public partial class frmLapPhieuGiaoHang : Form
    {
        private string maNhanVien;

        HoaDonBLL hdbll = new HoaDonBLL();
        ChiTietHoaDonSanPhamBLL cthdbll = new ChiTietHoaDonSanPhamBLL();
        public frmLapPhieuGiaoHang(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;

            this.btnBack.Click += BtnBack_Click;
            
            this.Load += FrmLapPhieuGiaoHang_Load;
            this.txtTenKhachHang.KeyPress += TxtTenKhachHang_KeyPress;
            this.txtSDT.KeyPress += TxtSDT_KeyPress;
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
            dtpNgayGiaoDuKien.MinDate = DateTime.Now;
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            DateTime ngayBatDau = DateTime.Now.Date;
            DateTime ngayKetThuc = DateTime.Now.Date;

            var dshd = hdbll.LoadDanhSachHoaDonTheoNgayLoc(ngayBatDau, ngayKetThuc);
            var dataSource = dshd.Select(hd => new
            {
                maHoaDon = hd.maHoaDon,
                ngayLap = hd.ngayLap,
                tongTien = hd.tongTienSauGiam
            }).ToList();

            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = dataSource;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang(maNhanVien);
            frm.Show();
            this.Close();
        }
    }
}
