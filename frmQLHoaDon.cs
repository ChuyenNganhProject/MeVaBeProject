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
        public frmQLHoaDon()
        {
            InitializeComponent();
            this.Load += FrmQLHoaDon_Load;
            this.dtpNgayBatDau.Value = dtpNgayKetThuc.Value;

            this.btnReset.Click += BtnReset_Click; ;
            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.cboTieuChi.SelectedIndexChanged += CboTieuChi_SelectedIndexChanged;
            this.btnLocTheoNgay.Click += BtnLocTheoNgay_Click;
            this.dtpNgayBatDau.ValueChanged += DtpNgayBatDau_ValueChanged;
            this.dtpNgayKetThuc.ValueChanged += DtpNgayKetThuc_ValueChanged;

            this.dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;
            this.dgvHoaDon.CellFormatting += DgvHoaDon_CellFormatting;

            this.btnXemChiTiet.Click += BtnXemChiTiet_Click;
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
                frmCTHD frm = new frmCTHD(MaHoaDon);
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
                dgvHoaDon.DataSource = hdbll.LoadDanhSachHoaDon();
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SettingDgv();
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
            var hoadons = hdbll.LoadDanhSachHoaDonTheoNgayLoc(ngayBatDau, ngayKetThuc);
            dgvHoaDon.DataSource = hoadons;
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SettingDgv();

            decimal tongDoanhThu = hoadons.Sum(hd => hd.tongTienSauGiam) ?? 0;
            lblTongDoanhThu.Text = "Tổng doanh thu: " + tongDoanhThu.ToString("N0").Replace(",", ".") + "đ";
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuChi = cboTieuChi.SelectedItem.ToString();
            string tenTimKiem = txtTimKiem.Text.Trim();
            decimal tongDoanhThu = 0;

            if (string.IsNullOrWhiteSpace(tenTimKiem))
            {
                dgvHoaDon.DataSource = hdbll.LoadDanhSachHoaDon();
                tongDoanhThu = hdbll.TinhTongDoanhThu();
            }
            else
            {
                var ketQuaTimKiem = hdbll.TimKiemHoaDon(tieuChi, tenTimKiem);
                dgvHoaDon.DataSource = ketQuaTimKiem;
                tongDoanhThu = ketQuaTimKiem.Sum(hd => hd.tongTienSauGiam) ?? 0;
            }
            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SettingDgv();

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
                dgvHoaDon.DataSource = hdbll.LoadDanhSachHoaDon();
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SettingDgv();
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
            cboTieuChi.BackColor = System.Drawing.Color.White;
            cboTieuChi.ForeColor = System.Drawing.Color.Black;

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

        private void SettingDgv()
        {
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
                dgvHoaDon.Columns["tienDuocGiam"].HeaderText = "Tiền được giảm";
            }
            if (dgvHoaDon.Columns["tongTienSauGiam"] != null)
            {
                dgvHoaDon.Columns["tongTienSauGiam"].HeaderText = "Tổng tiền hóa đơn";
            }
            if (dgvHoaDon.Columns["tentrangThai"] != null)
            {
                dgvHoaDon.Columns["tentrangThai"].HeaderText = "Trạng thái";
            }
            dgvHoaDon.Columns["tongTienSauGiam"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvHoaDon.Columns["maHoaDon"].DisplayIndex = 0;
            dgvHoaDon.Columns["tenKhachHang"].DisplayIndex = 1;
            dgvHoaDon.Columns["tenNhanVien"].DisplayIndex = 2;
            dgvHoaDon.Columns["ngayLap"].DisplayIndex = 3;
            dgvHoaDon.Columns["tongTien"].DisplayIndex = 4;
            dgvHoaDon.Columns["tienDuocGiam"].DisplayIndex = 5;
            dgvHoaDon.Columns["tongTienSauGiam"].DisplayIndex = 6;
            dgvHoaDon.Columns["tentrangThai"].DisplayIndex = 7;
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
