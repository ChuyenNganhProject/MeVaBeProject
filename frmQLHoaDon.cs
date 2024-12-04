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
    public partial class frmQLHoaDon : Form
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        private string MaHoaDon;
        private string maNhanVien;
        public frmQLHoaDon(string maNhanVien)
        {
            InitializeComponent();
            this.Load += FrmQLHoaDon_Load;
            this.dtpNgayBatDau.Value = dtpNgayKetThuc.Value;

            this.btnReset.Click += BtnReset_Click;
            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.cboTieuChi.SelectedIndexChanged += CboTieuChi_SelectedIndexChanged;
            this.btnLocTheoNgay.Click += BtnLocTheoNgay_Click;
            this.dtpNgayBatDau.ValueChanged += DtpNgayBatDau_ValueChanged;
            this.dtpNgayKetThuc.ValueChanged += DtpNgayKetThuc_ValueChanged;

            this.dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            this.dgvHoaDon.CellFormatting += DgvHoaDon_CellFormatting;

            this.btnXemChiTiet.Click += BtnXemChiTiet_Click;
            this.maNhanVien = maNhanVien;
        }

        private void DtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                this.dtpNgayKetThuc.Value = dtpNgayBatDau.Value;
            }
        }

        private void DtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if(this.dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                this.dtpNgayBatDau.Value = dtpNgayKetThuc.Value;
            }
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvHoaDon.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvHoaDon.SelectedRows[0];
                MaHoaDon = selectedRow.Cells["maHoaDon"].Value.ToString();
            }
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MaHoaDon))
            {
                frmCTHD frm = new frmCTHD(MaHoaDon,maNhanVien);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                dtpNgayKetThuc.Value = DateTime.Now;
                dtpNgayBatDau.Value = dtpNgayKetThuc.Value;
                txtTimKiem.Text = "";
                txtTimKiem.Enabled = false;
                List<HoaDon> dsHoaDon = hdbll.LoadDanhSachHoaDon();
                SettingDgv(dsHoaDon);
                LoadTieuChiCombobox();

                decimal tongDoanhThu = hdbll.TinhTongDoanhThu();
                lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLocTheoNgay_Click(object sender, EventArgs e)
        {
            LoadDanhSachHoaDonTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
        }

        private void LoadDanhSachHoaDonTheoNgayLoc(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<HoaDon> dsHoaDon = hdbll.LoadDanhSachHoaDonTheoNgayLoc(ngayBatDau, ngayKetThuc);
            SettingDgv(dsHoaDon);

            decimal tongDoanhThu = dsHoaDon.Sum(hd => hd.tongTienSauGiam) ?? 0;
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuChi = cboTieuChi.SelectedItem.ToString();
            string tenTimKiem = txtTimKiem.Text.Trim();
            decimal tongDoanhThu = 0;

            if (string.IsNullOrWhiteSpace(tenTimKiem))
            {
                List<HoaDon> dsHoaDon = hdbll.LoadDanhSachHoaDon();
                SettingDgv(dsHoaDon);
                tongDoanhThu = hdbll.TinhTongDoanhThu();
            }
            else
            {
                List<HoaDon> ketQuaTimKiem = hdbll.TimKiemHoaDon(tieuChi, tenTimKiem);
                SettingDgv(ketQuaTimKiem);
                tongDoanhThu = ketQuaTimKiem.Sum(hd => hd.tongTienSauGiam) ?? 0;
            }

            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        // Dữ liệu số nằm bên phải
        private void DgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal tien))
            {
                dgvHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.Value = tien.ToString("N0").Replace(",", ".");
                e.FormattingApplied = true;
            }
        }

        private void FrmQLHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                List<HoaDon> dsHoaDon = hdbll.LoadDanhSachHoaDon();
                SettingDgv(dsHoaDon);
                LoadTieuChiCombobox();

                decimal tongDoanhThu = hdbll.TinhTongDoanhThu();
                lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTieuChi.SelectedItem.ToString() == "Các tiêu chí")
            {
                txtTimKiem.Enabled = false;
                txtTimKiem.Text = "";
            }
            else
            {
                txtTimKiem.Enabled = true;
            }
        }

        private void SettingDgv(List<HoaDon> dsHoaDon)
        {
            dgvHoaDon.DataSource = dsHoaDon;            

            if (dgvHoaDon.Columns["KhachHang"] != null)
            {
                dgvHoaDon.Columns["KhachHang"].Visible = false;
            }
            if (dgvHoaDon.Columns["NhanVien"] != null)
            {
                dgvHoaDon.Columns["NhanVien"].Visible = false;
            }
            if (dgvHoaDon.Columns["maKhachHang"] != null)
            {
                dgvHoaDon.Columns["maKhachHang"].Visible = false;
            }
            if (dgvHoaDon.Columns["maNhanVien"] != null)
            {
                dgvHoaDon.Columns["maNhanVien"].Visible = false;
            }
            if (dgvHoaDon.Columns["trangThai"] != null)
            {
                dgvHoaDon.Columns["trangThai"].Visible = false;
            }
            if (dgvHoaDon.Columns["maHoaDon"] != null)
            {
                dgvHoaDon.Columns["maHoaDon"].HeaderText = "Mã hóa đơn";
            }
            if (dgvHoaDon.Columns["tenNhanVien"] != null)
            {
                dgvHoaDon.Columns["tenNhanVien"].HeaderText = "Tên nhân viên";
            }
            if (dgvHoaDon.Columns["tenKhachHang"] != null)
            {
                dgvHoaDon.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
            }
            if (dgvHoaDon.Columns["ngayLap"] != null)
            {
                dgvHoaDon.Columns["ngayLap"].HeaderText = "Ngày lập";
            }
            if (dgvHoaDon.Columns["tongTien"] != null)
            {
                dgvHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
            }
            if (dgvHoaDon.Columns["tienDuocGiam"] != null)
            {
                dgvHoaDon.Columns["tienDuocGiam"].HeaderText = "Giảm giá VIP";
            }
            if (dgvHoaDon.Columns["tongTienSauGiam"] != null)
            {
                dgvHoaDon.Columns["tongTienSauGiam"].HeaderText = "Tổng tiền hóa đơn";
            }
            if (dgvHoaDon.Columns["tentrangThai"] != null)
            {
                dgvHoaDon.Columns["tentrangThai"].HeaderText = "Trạng thái";
            }
            if (dgvHoaDon.Columns["hinhThucTra"] != null)
            {
                dgvHoaDon.Columns["hinhThucTra"].HeaderText = "Hình thức trả";
            }

            dgvHoaDon.Columns["maHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHoaDon.Columns["tongTienSauGiam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHoaDon.Columns["hinhThucTra"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHoaDon.Columns["tenKhachHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHoaDon.Columns["tienDuocGiam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvHoaDon.Columns["tenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvHoaDon.Columns["maHoaDon"].DisplayIndex = 0;
            dgvHoaDon.Columns["tenKhachHang"].DisplayIndex = 1;
            dgvHoaDon.Columns["tenNhanVien"].DisplayIndex = 2;
            dgvHoaDon.Columns["ngayLap"].DisplayIndex = 3;
            dgvHoaDon.Columns["tongTien"].DisplayIndex = 4;
            dgvHoaDon.Columns["tienDuocGiam"].DisplayIndex = 5;
            dgvHoaDon.Columns["tongTienSauGiam"].DisplayIndex = 6;
            dgvHoaDon.Columns["tentrangThai"].DisplayIndex = 7;
            dgvHoaDon.Columns["hinhThucTra"].DisplayIndex = 8;
        }
        private void LoadTieuChiCombobox()
        {
            List<string> tieuChi = new List<string>
            {
                "Các tiêu chí",
                "Mã hóa đơn",
                "Tên khách hàng",
                "Tên nhân viên",
                "Ngày lập"
            };
            cboTieuChi.DataSource = tieuChi;
            
            cboTieuChi.SelectedIndex = 0;
        }
    }
}
