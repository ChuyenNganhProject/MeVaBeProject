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
    public partial class frmTaoPhieuDoiHang : Form
    {
        private string maHoaDon;
        private string maNhanVien;
        private HoaDon hoaDon;        
        private HoaDonBLL hoaDonBLL;
        private ChiTietHoaDonSanPhamBLL ctHoaDonSPBLL;
        private PhieuDoiHangBLL phieuDoiHangBLL;
        private ChiTietPhieuDoiHangBLL ctPhieuDoiHangBLL;
        private KhuyenMaiSanPhamBLL khuyenMaiSanPhamBLL;
        private NhanVienBLL nhanVienBLL;
        public delegate void SendDataHandler(bool loadData);
        public event SendDataHandler DongForm;
        public frmTaoPhieuDoiHang(string maHoaDon,string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            this.maHoaDon = maHoaDon;
            this.hoaDonBLL = new HoaDonBLL();
            this.ctHoaDonSPBLL = new ChiTietHoaDonSanPhamBLL();
            this.phieuDoiHangBLL = new PhieuDoiHangBLL();
            this.ctPhieuDoiHangBLL =new ChiTietPhieuDoiHangBLL();
            this.khuyenMaiSanPhamBLL = new KhuyenMaiSanPhamBLL();
            this.nhanVienBLL = new NhanVienBLL();
            this.rdbtnDoiSanPham.CheckedChanged += RadioButton_CheckedChanged;
            this.rdbtnDoiThanhTien.CheckedChanged += RadioButton_CheckedChanged;
        }
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.Rows)
            {
                string price = item.Cells["tongTien"].Value.ToString();
                price = price.Replace("₫", "").Replace(".", "").Trim();
                decimal tongTienSP = decimal.Parse(price);
                tongTien += tongTienSP;
            }
            txtTongTien.Text = tongTien.ToString("C0");
        }
        private void TinhTongTienTungSanPham(bool doiSanPham)
        {
            foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.Rows)
            {
                int soLuongDoi = int.Parse(item.Cells["soLuongDoi"].Value.ToString());
                decimal giaTriSanPham = 0;
                if (doiSanPham)
                {
                    giaTriSanPham = decimal.Parse(item.Cells["giaTriSanPhamDoi"].Value.ToString().Replace("₫", "").Replace(".", "").Trim());
                }
                else
                {
                    giaTriSanPham = decimal.Parse(item.Cells["giaTriSanPham"].Value.ToString());
                }
                item.Cells["tongTien"].Value = soLuongDoi * giaTriSanPham;                
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == rdbtnDoiSanPham)
            {
                dtgvSanPhamTrongPhieuDoi.Columns["maSanPhamDoi"].Visible = true;
                dtgvSanPhamTrongPhieuDoi.Columns["tenSanPhamDoi"].Visible = true;
                dtgvSanPhamTrongPhieuDoi.Columns["giaTriSanPhamDoi"].Visible = true;
                dtgvSanPhamTrongPhieuDoi.Columns["chonSanPhamDoi"].Visible = true;
                if (dtgvSanPhamTrongPhieuDoi.Rows.Count > 0)
                {
                    TinhTongTienTungSanPham(true);
                    TinhTongTien();
                }
            }
            if (sender == rdbtnDoiThanhTien)
            {
                dtgvSanPhamTrongPhieuDoi.Columns["maSanPhamDoi"].Visible = false;
                dtgvSanPhamTrongPhieuDoi.Columns["tenSanPhamDoi"].Visible = false;
                dtgvSanPhamTrongPhieuDoi.Columns["giaTriSanPhamDoi"].Visible = false;
                dtgvSanPhamTrongPhieuDoi.Columns["chonSanPhamDoi"].Visible = false;
                if (dtgvSanPhamTrongPhieuDoi.Rows.Count>0)
                {
                    TinhTongTienTungSanPham(false);
                    TinhTongTien();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmTaoPhieuDoiHang_Load(object sender, EventArgs e)
        {
            hoaDon = hoaDonBLL.LoadHoaDonTheoMa(maHoaDon);            
            txtMaPhieuDoi.Text = phieuDoiHangBLL.TaoMaPhieuDoiHang();
            txtTenNhanVien.Text = nhanVienBLL.LayTTNhanVienTuMa(maNhanVien).tenNhanVien;
            txtTenKhachHang.Text = (hoaDon.tenKhachHang!=null)? hoaDon.tenKhachHang:"N/A";
            rdbtnDoiSanPham.Checked = true;
            dtgvSanPhamTrongHoaDon.DataSource = ctHoaDonSPBLL.LoadCTHDSanPham(maHoaDon);
            dtgvSanPhamTrongHoaDon.Columns["tongTien"].Visible = false;
            dtgvSanPhamTrongHoaDon.Columns["SanPham"].Visible = false;
            dtgvSanPhamTrongHoaDon.Columns["HoaDon"].Visible = false;
            dtgvSanPhamTrongHoaDon.Columns["maHoaDon"].Visible = false;
        }
        private void btnThemSPVaoPhieuDoi_Click(object sender, EventArgs e)
        {
            if (dtgvSanPhamTrongHoaDon.SelectedRows.Count>0)
            {
                foreach(DataGridViewRow item in dtgvSanPhamTrongHoaDon.SelectedRows)
                {
                    string maSanPham = item.Cells["maSanPham"].Value.ToString();
                    if (khuyenMaiSanPhamBLL.TimKhuyenMaiSanPhamTheoNgayLapHoaDon(maSanPham, hoaDon.ngayLap.Value)==null)
                    {
                        if (item.DefaultCellStyle.SelectionBackColor != System.Drawing.SystemColors.ControlDarkDark)
                        {
                            object[] rowData = new object[8];
                            rowData[0] = maSanPham;
                            rowData[1] = item.Cells["tenSanPham"].Value;
                            rowData[2] = 1;
                            rowData[3] = item.Cells["donGia"].Value;
                            rowData[4] = null;
                            rowData[5] = null;
                            rowData[6] = 0.ToString("C0");
                            rowData[7] = 0.ToString("C0");
                            dtgvSanPhamTrongPhieuDoi.Rows.Add(rowData);
                            item.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
                            item.DefaultCellStyle.SelectionForeColor = Color.White;
                            item.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                            item.DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, $"Sản phẩm {maSanPham} thuộc chương trình khuyến mãi không thể đổi trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void btnXoaSPTrongPhieuDoi_Click(object sender, EventArgs e)
        {
            if (dtgvSanPhamTrongPhieuDoi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.SelectedRows)
                {                    
                    foreach (DataGridViewRow row in dtgvSanPhamTrongHoaDon.Rows)
                    {
                        if (row.Cells["maSanPham"].Value == item.Cells["maSanPhamPDoi"].Value)
                        {
                            row.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                            row.DefaultCellStyle.SelectionBackColor = Color.HotPink;
                            row.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
                            break;
                        }
                    }
                    dtgvSanPhamTrongPhieuDoi.Rows.Remove(item);
                }
            }
        }
        private bool KtrSanPhamDoi()
        {
            foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.Rows)
            {
                if (item.Cells["maSanPhamDoi"].Value==null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool KtrLyDo()
        {
            if (txtLyDo.Text==null|| txtLyDo.Text=="")
            {
                return false;
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dtgvSanPhamTrongPhieuDoi.RowCount>0)
            {                
                if (rdbtnDoiSanPham.Checked)
                {
                    if (KtrSanPhamDoi())
                    {
                        if (KtrLyDo())
                        {
                            PhieuDoiHang phieuDoi = new PhieuDoiHang()
                            {
                                maPhieuDoi = txtMaPhieuDoi.Text,
                                maNhanVien = maNhanVien,
                                tenKhachHang = (txtTenKhachHang.Text!=null) ? txtTenKhachHang.Text:"N/A",
                                ngayDoi = DateTime.Now,
                                lyDoDoi = txtLyDo.Text,
                                hinhThucDoi = (rdbtnDoiSanPham.Checked) ? "Đổi sản phẩm khác" : "Đổi thành tiền",
                                tongTien = decimal.Parse(txtTongTien.Text.Replace("₫", "").Replace(".", "").Trim())
                            };
                            bool resultTaoPhieuDoi = phieuDoiHangBLL.TaoPhieuDoiHang(phieuDoi);
                            foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.Rows)
                            {
                                string maSanPham = item.Cells["maSanPhamPDoi"].Value.ToString();
                                string maSanPhamDoi = item.Cells["maSanPhamDoi"].Value.ToString();
                                int soLuongDoi = int.Parse(item.Cells["soLuongDoi"].Value.ToString());
                                decimal giaTriSanPham = decimal.Parse(item.Cells["giaTriSanPham"].Value.ToString());
                                decimal giaTriSanPhamDoi = decimal.Parse(item.Cells["giaTriSanPhamDoi"].Value.ToString());
                                decimal tongTien = decimal.Parse(item.Cells["tongTien"].Value.ToString());
                                ChiTietPhieuDoiHang ctPhieuDoi = new ChiTietPhieuDoiHang()
                                {
                                    maPhieuDoi = txtMaPhieuDoi.Text,
                                    maHoaDon = maHoaDon,
                                    maSanPham = maSanPham,
                                    soLuong = soLuongDoi,
                                    giaTriSanPham = giaTriSanPham,
                                    maSanPhamDoi = maSanPhamDoi,
                                    giaTriSanPhamDoi = giaTriSanPhamDoi,
                                    tongTien = tongTien
                                };
                                ctPhieuDoiHangBLL.TaoChiTietPhieuDoi(ctPhieuDoi);
                            }
                            frmPhieuDoiHang frmPhieuDoiHang = new frmPhieuDoiHang(phieuDoi.maPhieuDoi);
                            frmPhieuDoiHang.DongForm += FrmPhieuDoiHang_DongForm;
                            frmPhieuDoiHang.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(this, "Vui lòng ghi lý do đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Vui lòng chọn sản phẩm muốn đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (KtrLyDo())
                    {
                        TinhTongTienTungSanPham(false);
                        TinhTongTien();
                        PhieuDoiHang phieuDoi = new PhieuDoiHang()
                        {
                            maPhieuDoi = txtMaPhieuDoi.Text,
                            maNhanVien = maNhanVien,
                            tenKhachHang = (txtTenKhachHang.Text != null) ? txtTenKhachHang.Text : "N/A",
                            ngayDoi = DateTime.Now,
                            lyDoDoi = txtLyDo.Text,
                            hinhThucDoi = (rdbtnDoiSanPham.Checked) ? "Đổi sản phẩm khác" : "Đổi thành tiền",
                            tongTien = decimal.Parse(txtTongTien.Text.Replace("₫", "").Replace(".", "").Trim())
                        };
                        bool resultTaoPhieuDoi = phieuDoiHangBLL.TaoPhieuDoiHang(phieuDoi);
                        foreach (DataGridViewRow item in dtgvSanPhamTrongPhieuDoi.Rows)
                        {
                            string maSanPham = item.Cells["maSanPhamPDoi"].Value.ToString();
                            int soLuongDoi = int.Parse(item.Cells["soLuongDoi"].Value.ToString());
                            decimal giaTriSanPham = decimal.Parse(item.Cells["giaTriSanPham"].Value.ToString());
                            decimal tongTien = decimal.Parse(item.Cells["tongTien"].Value.ToString());
                            ChiTietPhieuDoiHang ctPhieuDoi = new ChiTietPhieuDoiHang()
                            {
                                maPhieuDoi = txtMaPhieuDoi.Text,
                                maHoaDon = maHoaDon,
                                maSanPham = maSanPham,
                                soLuong = soLuongDoi,
                                giaTriSanPham = giaTriSanPham,
                                maSanPhamDoi = null,
                                giaTriSanPhamDoi = 0,
                                tongTien = tongTien
                            };
                            ctPhieuDoiHangBLL.TaoChiTietPhieuDoi(ctPhieuDoi);
                        }
                        frmPhieuDoiHang frmPhieuDoiHang = new frmPhieuDoiHang(phieuDoi.maPhieuDoi);
                        frmPhieuDoiHang.DongForm += FrmPhieuDoiHang_DongForm;
                        frmPhieuDoiHang.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(this, "Vui lòng ghi lý do đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Vui lòng chọn sản phẩm muốn đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmPhieuDoiHang_DongForm(bool loadData)
        {
            if (loadData)
            {
                this.Close();
            }
        }
        private void dtgvSanPhamTrongPhieuDoi_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dtgvSanPhamTrongPhieuDoi.CurrentCell.ColumnIndex==2) // Thay "1" bằng chỉ số của cột bạn muốn kiểm soát
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += ChiNhapSo; ;
                    textBox.TextChanged += TextBox_TextChanged;
                }
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "1";
                textBox.SelectionStart = textBox.Text.Length;
            }
            if (textBox.Text.StartsWith("0") && textBox.Text.Length > 1)
            {
                // Xóa số "0" ở đầu
                textBox.Text = textBox.Text.TrimStart('0');
                textBox.SelectionStart = textBox.Text.Length; // Đặt con trỏ ở cuối
            }
            if (textBox.Text.StartsWith("0") && textBox.Text.Length == 1)
            {
                // Xóa số "0" ở đầu
                textBox.Text = "1";
                textBox.SelectionStart = textBox.Text.Length; // Đặt con trỏ ở cuối
            }            
        }
        private void ChiNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtgvSanPhamTrongPhieuDoi_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dtgvSanPhamTrongPhieuDoi.Columns[e.ColumnIndex].Name == "soLuongDoi")
            {
                int newValue;
                int maxValue = (int)ctHoaDonSPBLL.TimChiTietHoaDonSanPham(maHoaDon, dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["maSanPhamPDoi"].Value.ToString()).soLuong;
                if (!int.TryParse(e.FormattedValue.ToString(), out newValue) || newValue > maxValue)
                {
                    MessageBox.Show($"Vui lòng nhập số từ 1 đến {maxValue}.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Tag = maxValue;
                }
            }
        }
        private void dtgvSanPhamTrongPhieuDoi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvSanPhamTrongPhieuDoi.Columns[e.ColumnIndex].Name == "soLuongDoi")
            {
                var row = dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex];

                // Kiểm tra nếu dòng có giá trị Tag
                if (row.Tag != null)
                {
                    // Cập nhật lại giá trị ô thành maxValue
                    row.Cells["soLuongDoi"].Value = row.Tag;
                    row.Tag = null; // Xóa Tag sau khi sử dụng
                }
            }
        }
        private void dtgvSanPhamTrongPhieuDoi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dtgvSanPhamTrongPhieuDoi.Columns[e.ColumnIndex].Name;
            if (rdbtnDoiSanPham.Checked)
            {
                if (columnName == "soLuongDoi" || columnName == "giaTriSanPhamDoi")
                {
                    string price = dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["giaTriSanPhamDoi"].Value.ToString();
                    price = price.Replace("₫", "").Replace(".", "").Split(',')[0].Trim();
                    decimal donGiaDoi = decimal.Parse(price);
                    int soLuongDoi = int.Parse(dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["soLuongDoi"].Value.ToString());
                    decimal tongTien = soLuongDoi * donGiaDoi;
                    dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["tongTien"].Value = tongTien;
                }
            }
            else
            {
                if (columnName == "soLuongDoi")
                {
                    string price = dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["giaTriSanPham"].Value.ToString();
                    price = price.Replace("₫", "").Replace(".", "").Split(',')[0].Trim();
                    decimal donGiaDoi = decimal.Parse(price);
                    int soLuongDoi = int.Parse(dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["soLuongDoi"].Value.ToString());
                    decimal tongTien = soLuongDoi * donGiaDoi;
                    dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["tongTien"].Value = tongTien;
                }
            }
            if (columnName == "tongTien")
            {
                TinhTongTien();
            }
        }
        private void dtgvSanPhamTrongPhieuDoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                decimal giaTriSanPham = decimal.Parse(dtgvSanPhamTrongPhieuDoi.Rows[e.RowIndex].Cells["giaTriSanPham"].Value.ToString());
                if (e.ColumnIndex == dtgvSanPhamTrongPhieuDoi.Columns["chonSanPhamDoi"].Index)
                {
                    frmChonSanPhamDoi frmChonSanPhamDoi = new frmChonSanPhamDoi(giaTriSanPham,e.RowIndex);
                    frmChonSanPhamDoi.TruyenDuLieu += FrmChonSanPhamDoi_DongForm;
                    frmChonSanPhamDoi.ShowDialog();
                }
            }
        }
        private void FrmChonSanPhamDoi_DongForm(string maSanPham,string tenSanPham,decimal giaTriSanPhamDoi,int rowIndex)
        {
            dtgvSanPhamTrongPhieuDoi.Rows[rowIndex].Cells["maSanPhamDoi"].Value = maSanPham;
            dtgvSanPhamTrongPhieuDoi.Rows[rowIndex].Cells["tenSanPhamDoi"].Value = tenSanPham;
            dtgvSanPhamTrongPhieuDoi.Rows[rowIndex].Cells["giaTriSanPhamDoi"].Value = giaTriSanPhamDoi;
        }
        private void frmTaoPhieuDoiHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            DongForm?.Invoke(true);
        }
    }
}
