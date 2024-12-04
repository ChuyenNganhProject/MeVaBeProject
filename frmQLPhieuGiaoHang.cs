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
    public partial class frmQLPhieuGiaoHang : Form
    {
        PhieuGiaoHangBLL pgbll = new PhieuGiaoHangBLL();
        private frmTrangChu parentfrm;
        private string maNhanVien;
        private string MaPG;
        private string MaHD;
        private string TenNV;
        public frmQLPhieuGiaoHang(frmTrangChu parentfrm, string maNhanVien)
        {
            InitializeComponent();
            this.parentfrm = parentfrm;
            this.Load += FrmQLPhieuGiaoHang_Load;
            this.dgvPhieuGiao.CellClick += DgvPhieuGiao_CellClick;
            this.dgvPhieuGiao.CellFormatting += DgvPhieuGiao_CellFormatting;
            this.dgvPhieuGiao.SelectionChanged += DgvPhieuGiao_SelectionChanged;
            this.btnBack.Click += BtnBack_Click;

            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.btnLocHienTai.Click += BtnLocHienTai_Click;
            this.btnLocTheoNgay.Click += BtnLocTheoNgay_Click;
            this.btnReset.Click += BtnReset_Click;
            this.btnXemChiTiet.Click += BtnXemChiTiet_Click;

            this.cboTieuChi.SelectedIndexChanged += CboTieuChi_SelectedIndexChanged;
            this.dtpNgayBatDau.ValueChanged += DtpNgayBatDau_ValueChanged;
            this.dtpNgayKetThuc.ValueChanged += DtpNgayKetThuc_ValueChanged;
            this.maNhanVien = maNhanVien;
        }

        private void DgvPhieuGiao_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuGiao.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPhieuGiao.SelectedRows[0];
                MaPG = selectedRow.Cells["maPhieuGiao"].Value.ToString();
                MaHD = selectedRow.Cells["maHD"].Value.ToString();
                TenNV = selectedRow.Cells["tenNhanVien"].Value.ToString();
            }
        }

        private void BtnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaPG))
            {
                frmCTPhieuGiao frm = new frmCTPhieuGiao(MaPG, MaHD, TenNV);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DgvPhieuGiao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPhieuGiao.Columns[e.ColumnIndex].Name == "soDienThoai")
            {
                return;
            }
            if (dgvPhieuGiao.Columns[e.ColumnIndex].Name == "DiaChiGiaoHang")
            {
                return;
            }
            if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal tien))
            {
                dgvPhieuGiao.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (tien != 0)
                {
                    e.Value = tien.ToString("N0").Replace(",", ".") + "đ";
                }
                else
                {
                    e.Value = tien.ToString("N0").Replace(",", ".");
                }
                e.FormattingApplied = true;
            }
        }

        private void DgvPhieuGiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhieuGiao.Columns["btnCapNhatTinhTrang"].Index && e.RowIndex >= 0)
            {
                string maPhieuGiao = dgvPhieuGiao.Rows[e.RowIndex].Cells["maPhieuGiao"].Value.ToString();
                PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(maPhieuGiao);
                if (phieuGiao.tinhTrang != "Chưa giao")
                {
                    MessageBox.Show("Phiếu giao này đã được giao, không thể cập nhật tình trạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Bạn muốn xác nhận là đã giao hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    phieuGiao.tinhTrang = "Đã giao";
                    phieuGiao.ngayDaGiao = DateTime.Now;
                    if(pgbll.ThemHoacSuaPhieuGiao(phieuGiao))
                    {
                        MessageBox.Show($"Đã cập nhật phiếu giao hàng: {phieuGiao.tinhTrang}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadDanhSachPhieuGiaoTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
                }
            }
        }

        private void FrmQLPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            LoadTieuChiCombobox();
            cboTrangThai.SelectedIndex = 0;
            this.dtpNgayBatDau.MaxDate = DateTime.Now.Date;
            this.dtpNgayKetThuc.MaxDate = DateTime.Now.Date;
            this.dtpNgayBatDau.Value = this.dtpNgayKetThuc.Value.AddDays(-7).Date;
            try
            {
                LoadDanhSachPhieuGiaoTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmQLHoaDon frm = new frmQLHoaDon(parentfrm,maNhanVien);
            parentfrm.OpenChildForm(frm);
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhieuGiaoTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            cboTieuChi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            this.dtpNgayKetThuc.Value = DateTime.Now.Date;
            this.dtpNgayBatDau.Value = this.dtpNgayKetThuc.Value.AddDays(-7).Date;
            LoadDanhSachPhieuGiaoTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
        }

        private void BtnLocTheoNgay_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhieuGiaoTheoNgayLoc(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);
        }

        private void BtnLocHienTai_Click(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now.Date;
            dtpNgayKetThuc.Value = DateTime.Now.Date;
            LoadDanhSachPhieuGiaoTheoNgayLoc(DateTime.Now.Date, DateTime.Now.Date);
        }
        private void LoadDanhSachPhieuGiaoTheoNgayLoc(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            string tieuChi = cboTieuChi.SelectedItem.ToString();
            string tenTimKiem = txtTimKiem.Text.Trim();
            string tinhTrang = cboTrangThai.SelectedItem.ToString();
            List<PhieuGiaoHang> ketQuaTimKiem;
            if (tinhTrang != "Chọn...")
            {
                ketQuaTimKiem = pgbll.TimKiemVaLocPhieuGiao(tieuChi, tenTimKiem, ngayBatDau, ngayKetThuc, tinhTrang)
                                             .OrderByDescending(pg => pg.ngayLap.Value).ToList();
                SettingDgv(ketQuaTimKiem);
            }
            else
            {
                ketQuaTimKiem = pgbll.TimKiemVaLocPhieuGiao(tieuChi, tenTimKiem, ngayBatDau, ngayKetThuc, "")
                                             .OrderByDescending(pg => pg.ngayLap.Value).ToList();
                SettingDgv(ketQuaTimKiem);
            }
            
        }
        private void SettingDgv(List<PhieuGiaoHang> dsPhieuGiaoHang)
        {
            dgvPhieuGiao.DataSource = dsPhieuGiaoHang;
            dgvPhieuGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (dgvPhieuGiao.Columns["NhanVien"] != null)
            {
                dgvPhieuGiao.Columns["NhanVien"].Visible = false;
            }
            if (dgvPhieuGiao.Columns["maPhieuGiao"] != null)
            {
                dgvPhieuGiao.Columns["maPhieuGiao"].HeaderText = "Mã phiếu giao";
            }
            if (dgvPhieuGiao.Columns["maHD"] != null)
            {
                dgvPhieuGiao.Columns["maHD"].HeaderText = "Mã hóa đơn";
            }
            if (dgvPhieuGiao.Columns["tenNhanVien"] != null)
            {
                dgvPhieuGiao.Columns["tenNhanVien"].HeaderText = "Tên nhân viên";
            }
            if (dgvPhieuGiao.Columns["maNhanVien"] != null)
            {
                dgvPhieuGiao.Columns["maNhanVien"].HeaderText = "Mã nhân viên";
            }
            if (dgvPhieuGiao.Columns["ngayLap"] != null)
            {
                dgvPhieuGiao.Columns["ngayLap"].HeaderText = "Ngày lập";
            }
            if (dgvPhieuGiao.Columns["tenKhachHang"] != null)
            {
                dgvPhieuGiao.Columns["tenKhachHang"].HeaderText = "Tên khách hàng";
            }
            if (dgvPhieuGiao.Columns["DiaChiGiaoHang"] != null)
            {
                dgvPhieuGiao.Columns["DiaChiGiaoHang"].HeaderText = "Địa chỉ giao hàng";
            }
            if (dgvPhieuGiao.Columns["ngayGiaoDuKien"] != null)
            {
                dgvPhieuGiao.Columns["ngayGiaoDuKien"].HeaderText = "Ngày giao dự kiến";
            }
            if (dgvPhieuGiao.Columns["chiPhi"] != null)
            {
                dgvPhieuGiao.Columns["chiPhi"].HeaderText = "Phí vận chuyển";
            }
            if (dgvPhieuGiao.Columns["tinhTrang"] != null)
            {
                dgvPhieuGiao.Columns["tinhTrang"].HeaderText = "Tình trạng";
            }
            if (dgvPhieuGiao.Columns["soDienThoai"] != null)
            {
                dgvPhieuGiao.Columns["soDienThoai"].HeaderText = "Số điện thoại";
            }
            if (dgvPhieuGiao.Columns["ngayDaGiao"] != null)
            {
                dgvPhieuGiao.Columns["ngayDaGiao"].HeaderText = "Ngày đã giao";
            }

            dgvPhieuGiao.Columns["maPhieuGiao"].DisplayIndex = 0;
            dgvPhieuGiao.Columns["maHD"].DisplayIndex = 1;
            dgvPhieuGiao.Columns["maNhanVien"].DisplayIndex = 2;
            dgvPhieuGiao.Columns["tenNhanVien"].DisplayIndex = 3;
            dgvPhieuGiao.Columns["tenKhachHang"].DisplayIndex = 4;
            dgvPhieuGiao.Columns["soDienThoai"].DisplayIndex = 5;
            dgvPhieuGiao.Columns["DiaChiGiaoHang"].DisplayIndex = 6;
            dgvPhieuGiao.Columns["ngayLap"].DisplayIndex = 7;
            dgvPhieuGiao.Columns["ngayGiaoDuKien"].DisplayIndex = 8;
            dgvPhieuGiao.Columns["chiPhi"].DisplayIndex = 9;
            dgvPhieuGiao.Columns["tinhTrang"].DisplayIndex = 10;
            dgvPhieuGiao.Columns["ngayDaGiao"].DisplayIndex = 11;

            dgvPhieuGiao.DataBindingComplete += DgvPhieuGiao_DataBindingComplete;
        }

        private void DgvPhieuGiao_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvPhieuGiao.Columns["btnCapNhatTinhTrang"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Cập nhật tình trạng";
                btnColumn.Name = "btnCapNhatTinhTrang";
                btnColumn.DataPropertyName = "btnCapNhatTinhTrang";
                btnColumn.Text = "Cập nhật";
                btnColumn.UseColumnTextForButtonValue = true;
                btnColumn.FlatStyle = FlatStyle.Flat;
                dgvPhieuGiao.Columns.Add(btnColumn);
            }
            foreach (DataGridViewRow row in dgvPhieuGiao.Rows)
            {
                string maPhieuGiao = row.Cells["maPhieuGiao"].Value.ToString();
                PhieuGiaoHang phieuGiao = pgbll.LayTTPhieuGiaoTuMaPG(maPhieuGiao);
                DataGridViewButtonCell btnCell = (DataGridViewButtonCell)row.Cells["btnCapNhatTinhTrang"];
                if (phieuGiao.tinhTrang != "Chưa giao")
                {
                    btnCell.ReadOnly = true;
                    btnCell.Style.BackColor = Color.Gray;
                }
                else
                {
                    btnCell.ReadOnly = false;
                    btnCell.Style.BackColor = ColorTranslator.FromHtml("#f78fb3"); ;
                }
            }
            dgvPhieuGiao.Columns["btnCapNhatTinhTrang"].DisplayIndex = dgvPhieuGiao.Columns.Count - 1;
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
            if (this.dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                this.dtpNgayBatDau.Value = dtpNgayKetThuc.Value;
            }
        }

        private void LoadTieuChiCombobox()
        {
            List<string> tieuChi = new List<string>
            {
                "Các tiêu chí",
                "Mã phiếu giao",
                "Mã hóa đơn",
                "Tên khách hàng",
                "Tên nhân viên",
                "Số điện thoại",
                "Địa chỉ"
            };
            cboTieuChi.DataSource = tieuChi;

            cboTieuChi.SelectedIndex = 0;
        }
    }
}
