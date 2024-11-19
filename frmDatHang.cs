using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace MeVaBeProject
{
    public partial class frmDatHang : Form
    {
        #region
        private string maNhanVien;
        private string maPhieuDat;
        private string maNhaCungCap;
        private bool themPhieu;
        private BindingSource bindingSource;
        private BindingSource chiTietPhieuDats;
        private SanPhamBLL sanPhamBLL;
        private LoaiSanPhamBLL loaiSanPhamBLL;
        private NhaCungCapBLL nhaCungCapBLL;
        private PhieuDatBLL phieuDatBLL;
        private ChiTietPhieuDatBLL chiTietPhieuDatBLL;
        private List<DataGridViewRow> deletedRows;
        private List<ChiTietPhieuDat> chiTietPhieuDatBiXoa;
        #endregion
        public frmDatHang(string maNhanVien,bool themPhieu,string maPhieuDat,string maNhaCungCap)
        {
            this.maNhanVien = maNhanVien;            
            this.themPhieu = themPhieu;
            if (!themPhieu)
            {
                this.maPhieuDat = maPhieuDat;
                this.maNhaCungCap = maNhaCungCap;
                this.chiTietPhieuDats = new BindingSource();
                this.chiTietPhieuDatBiXoa = new List<ChiTietPhieuDat>();
            }
            this.bindingSource = new BindingSource();
            this.sanPhamBLL = new SanPhamBLL();
            this.loaiSanPhamBLL = new LoaiSanPhamBLL();
            this.nhaCungCapBLL = new NhaCungCapBLL();
            this.phieuDatBLL = new PhieuDatBLL();
            this.chiTietPhieuDatBLL = new ChiTietPhieuDatBLL();
            this.deletedRows = new List<DataGridViewRow>();
            InitializeComponent();
            this.txtSoLuongSanPham.KeyPress += onlyNumericInput;
            this.txtDonGia.KeyPress += onlyNumericInput;
        }
        private void onlyNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SetHinhAnh(List<SanPham> danhSachSanPham)
        {
            // Đường dẫn tương đối từ thư mục gốc của project
            string relativePath = @"..\..\PicSanPham";
            string absolutePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath));
            int i = 0;
            foreach(SanPham sp in danhSachSanPham)
            {
                string imagePath = Path.Combine(absolutePath, Path.GetFileName(sp.hinhAnh)).Replace("/", "\\");
                dtgvDanhSachSP.Rows[i].Cells["anh"].Value = Image.FromFile(imagePath);
                i++;
            }
        }       
        private void LoadDanhSachSanPham()
        {
            List<SanPham> danhSachSanPham = sanPhamBLL.LayDanhSachSanPham();
            bindingSource.DataSource = danhSachSanPham;
            dtgvDanhSachSP.DataSource = bindingSource;
            dtgvDanhSachSP.Columns["maLoaiSanPham"].Visible = false;
            dtgvDanhSachSP.Columns["LoaiSanPham"].Visible = false;
            dtgvDanhSachSP.Columns["hinhAnh"].Visible = false;
            dtgvDanhSachSP.Columns["donGiaSale"].Visible = false;
            SetHinhAnh(danhSachSanPham);
        }
        private void frmDatHang_Load(object sender, EventArgs e)
        {
            this.rdbtMaSP.Checked = true;
            LoadDanhSachSanPham();
            //Load dữ liệu danh sách loại sản phẩm
            cbLoaiSP.DataSource = loaiSanPhamBLL.LayDanhSachSanPham();
            cbLoaiSP.DisplayMember = "tenLoaiSanPham";
            cbLoaiSP.ValueMember = "maLoaiSanPham";
            this.cbLoaiSP.SelectedValueChanged += cbLoaiSP_SelectedValueChanged;
            //Load dữ liệu danh sách nhà cung cấp
            cbNhaCungCap.DataSource = nhaCungCapBLL.LoadNhaCungCap();
            cbNhaCungCap.DisplayMember = "tenNhaCungCap";
            cbNhaCungCap.ValueMember = "maNhaCungCap";
            if (themPhieu)
            {
                txtMaPhieuDat.Text = phieuDatBLL.TaoMaPhieuDat();
            }
            else
            {
                txtMaPhieuDat.Text = maPhieuDat;
                cbNhaCungCap.SelectedValue = maNhaCungCap;
                chiTietPhieuDats.DataSource = chiTietPhieuDatBLL.LayChiTietPhieuDat(maPhieuDat);
                dtgvSanPhamTrongPhieuDat.DataSource = chiTietPhieuDats;
                dtgvSanPhamTrongPhieuDat.Columns["maPhieuDat"].Visible = false;
                dtgvSanPhamTrongPhieuDat.Columns["PhieuDat"].Visible = false;
                dtgvSanPhamTrongPhieuDat.Columns["SanPham"].Visible = false;
                PhieuDat phieuDat = phieuDatBLL.TimKiemPhieuDatTheoMaPhieuDat(maPhieuDat);
                string tongTien = phieuDat.tongTien.ToString();
                tongTien = tongTien.Split(',')[0].Trim();
                txtTongTien.Text = int.Parse(tongTien).ToString("C0");
            }
        }
        private void cbLoaiSP_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = cbLoaiSP.SelectedValue.ToString();
            List<SanPham> sanPhams= sanPhamBLL.LayDanhSachSanPhamTheoMaLoai(selectedValue);
            bindingSource.DataSource = sanPhams;
            SetHinhAnh(sanPhams);
        }
        private void btnHuyLoc_Click(object sender, EventArgs e)
        {
            List<SanPham> sanPhams = sanPhamBLL.LayDanhSachSanPham();
            bindingSource.DataSource = sanPhams;
            SetHinhAnh(sanPhams);
            txtTimKiem.Text = string.Empty;
            rdbtMaSP.Checked = true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            if (rdbtMaSP.Checked)
            {
                bindingSource.DataSource = sanPhamBLL.TimKiemSanPhamTheoMaSP(txtTimKiem.Text);
            }
            else
            {
                sanPhams = sanPhamBLL.TimKiemSanPhamTheoTenSP(txtTimKiem.Text);
                bindingSource.DataSource = sanPhams;
                SetHinhAnh(sanPhams);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themPhieu)
            {
                //Tạo phiếu đặt
                PhieuDat pPhieuDat = new PhieuDat()
                {
                    maPhieuDat = txtMaPhieuDat.Text,
                    maNhaCungCap = cbNhaCungCap.SelectedValue.ToString(),
                    maNhanVien = maNhanVien,
                    ngayLap = DateTime.Now,
                    ngayCapNhat = DateTime.Now,
                    soLuong = dtgvSanPhamTrongPhieuDat.RowCount,
                    tongTien = decimal.Parse(txtTongTien.Text.Replace("₫", "").Replace(".", "").Trim()),
                    trangThai = "Chưa duyệt"
                };
                bool result = phieuDatBLL.TaoPhieuDat(pPhieuDat);
                if (result)
                {
                    bool resultTaoCTPD = false;
                    foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.Rows)
                    {
                        string donGia = row.Cells["donGiaSP"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        string tongTien = row.Cells["thanhTien"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        ChiTietPhieuDat pChiTietPhieuDat = new ChiTietPhieuDat()
                        {
                            maPhieuDat = txtMaPhieuDat.Text,
                            maSanPham = row.Cells["maSP"].Value.ToString(),
                            soLuongDat = int.Parse(row.Cells["soLuongDat"].Value.ToString()),
                            soLuongNhan = int.Parse(row.Cells["soLuongDaNhan"].Value.ToString()),
                            donGia = decimal.Parse(donGia),
                            tongTien = decimal.Parse(tongTien)
                        };
                        resultTaoCTPD = chiTietPhieuDatBLL.ThemChiTietPhieuDat(pChiTietPhieuDat);
                        if (!resultTaoCTPD)
                        {                            
                            MessageBox.Show(this, "Tạo phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }                        
                    }
                    if (resultTaoCTPD)
                    {
                        MessageBox.Show(this, "Tạo phiếu đặt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Tạo phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Sửa phiếu đặt
                PhieuDat pPhieuDat = new PhieuDat()
                {
                    maPhieuDat = txtMaPhieuDat.Text,
                    maNhaCungCap = cbNhaCungCap.SelectedValue.ToString(),
                    maNhanVien = maNhanVien,
                    ngayLap = DateTime.Now,
                    ngayCapNhat = DateTime.Now,
                    soLuong = dtgvSanPhamTrongPhieuDat.RowCount,
                    tongTien = decimal.Parse(txtTongTien.Text.Replace("₫", "").Replace(".", "").Trim()),
                    trangThai = "Chưa duyệt"
                };
                bool result = phieuDatBLL.SuaPhieuDat(pPhieuDat);
                if (result)
                {
                    bool resultSuaCTPD = false;
                    //Cập nhật chi tiết phiếu đặt
                    foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.Rows)
                    {
                        string donGia = row.Cells["donGiaSP"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        string tongTien = row.Cells["thanhTien"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        ChiTietPhieuDat pChiTietPhieuDat = new ChiTietPhieuDat()
                        {
                            maPhieuDat = txtMaPhieuDat.Text,
                            maSanPham = row.Cells["maSP"].Value.ToString(),
                            soLuongDat = int.Parse(row.Cells["soLuongDat"].Value.ToString()),
                            soLuongNhan = int.Parse(row.Cells["soLuongDaNhan"].Value.ToString()),
                            donGia = decimal.Parse(donGia),
                            tongTien = decimal.Parse(tongTien)
                        };
                        resultSuaCTPD = chiTietPhieuDatBLL.SuaChiTietPhieuDat(pChiTietPhieuDat);
                        if (!resultSuaCTPD)
                        {
                            resultSuaCTPD = chiTietPhieuDatBLL.ThemChiTietPhieuDat(pChiTietPhieuDat);
                        }                       
                    }                    
                    //Xóa những sản phẩm khỏi chi tiết phiếu đặt
                    bool xoaSanPham = true;
                    if (chiTietPhieuDatBiXoa.Count > 0)
                    {
                        foreach (ChiTietPhieuDat ctpd in chiTietPhieuDatBiXoa)
                        {
                            string maPhieuDat = txtMaPhieuDat.Text;
                            string maSanPham = ctpd.maSanPham;
                            xoaSanPham = chiTietPhieuDatBLL.XoaChiTietPhieuDat(maPhieuDat, maSanPham);
                            if (!xoaSanPham)
                            {
                                break;                                
                            }                           
                        }
                    }
                    if (resultSuaCTPD && xoaSanPham)
                    {
                        MessageBox.Show(this, "Sửa phiếu đặt thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Sửa phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Sửa phiếu đặt thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnThemSPVaoPhieuDat_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow selectedRow in dtgvDanhSachSP.SelectedRows)
            {
                string maSanPham = selectedRow.Cells["maSanPham"].Value.ToString();
                bool trungLap = false;
                foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.Rows)
                {
                    if (row.Cells["maSP"].Value.Equals(maSanPham))
                    {
                        trungLap = true;
                        // Tăng số lượng nếu trùng lặp
                        int currentQuantity = Convert.ToInt32(row.Cells["soLuongDat"].Value);
                        row.Cells["soLuongDat"].Value = currentQuantity + 1;
                        break;
                    }
                }
                if (!trungLap)
                {                    
                    if (themPhieu)
                    {
                        object[] rowData = new object[6];
                        rowData[0] = selectedRow.Cells["maSanPham"].Value;
                        rowData[1] = selectedRow.Cells["tenSanPham"].Value;
                        rowData[2] = 0;
                        rowData[3] = 0;
                        rowData[4] = 0.ToString("C0");
                        rowData[5] = 0.ToString("C0");
                        dtgvSanPhamTrongPhieuDat.Rows.Add(rowData);
                    }
                    else
                    {
                        ChiTietPhieuDat pChiTietPhieuDat = new ChiTietPhieuDat()
                        {
                            maPhieuDat = maPhieuDat,
                            maSanPham = selectedRow.Cells["maSanPham"].Value.ToString(),
                            tenSanPham = selectedRow.Cells["tenSanPham"].Value.ToString(),
                            soLuongDat = 0,
                            soLuongNhan = 0,
                            donGia = 0,
                            tongTien = 0,
                        };
                        chiTietPhieuDats.Add(pChiTietPhieuDat);
                    }
                }
            }
            dtgvDanhSachSP.ClearSelection();
        }
        private void btnXoaSPTrongPhieuDat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.SelectedRows)
            {
                    if (themPhieu)
                    {
                        deletedRows.Add(row);
                        dtgvSanPhamTrongPhieuDat.Rows.Remove(row);
                    }
                    else
                    {
                        string donGia = row.Cells["donGiaSP"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        string tongTien = row.Cells["thanhTien"].Value.ToString().Replace("₫", "").Replace(".", "").Trim();
                        ChiTietPhieuDat chiTietPhieuDatXoa = new ChiTietPhieuDat()
                        {
                            maPhieuDat = maPhieuDat,
                            maSanPham = row.Cells["maSP"].Value.ToString(),
                            tenSanPham = row.Cells["tenSP"].Value.ToString(),
                            soLuongDat = int.Parse(row.Cells["soLuongDat"].Value.ToString()),
                            soLuongNhan = int.Parse(row.Cells["soLuongDaNhan"].Value.ToString()),
                            donGia = decimal.Parse(donGia),
                            tongTien = decimal.Parse(tongTien),
                        };
                        chiTietPhieuDatBiXoa.Add(chiTietPhieuDatXoa);
                        dtgvSanPhamTrongPhieuDat.Rows.Remove(row);
                    }
            }
            TinhTongTien();
        }
        private void dtgvSanPhamTrongPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtMaSanPham.Text = dtgvSanPhamTrongPhieuDat.Rows[e.RowIndex].Cells["maSP"].Value.ToString();
                txtTenSanPham.Text = dtgvSanPhamTrongPhieuDat.Rows[e.RowIndex].Cells["tenSP"].Value.ToString();
                txtSoLuongSanPham.Text = dtgvSanPhamTrongPhieuDat.Rows[e.RowIndex].Cells["soLuongDat"].Value.ToString();
                string donGia = dtgvSanPhamTrongPhieuDat.Rows[e.RowIndex].Cells["donGiaSP"].Value.ToString();
                donGia = donGia.Replace("₫", "").Replace(".", "").Split(',')[0].Trim();
                txtDonGia.Text = donGia;
            }
        }
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (themPhieu)
            {
                foreach (DataGridViewRow row in deletedRows)
                {
                    dtgvSanPhamTrongPhieuDat.Rows.Add(row);                                      
                }
                deletedRows.Clear();
            }
            else
            {
                foreach(ChiTietPhieuDat chiTietPhieuDat in chiTietPhieuDatBiXoa)
                {
                    chiTietPhieuDats.Add(chiTietPhieuDat);
                }
                chiTietPhieuDatBiXoa.Clear();
            }
            TinhTongTien();
        }
        private void txtSoLuongSanPham_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuongSanPham.Text))
            {
                txtSoLuongSanPham.Text = "0";
                txtSoLuongSanPham.SelectionStart = txtSoLuongSanPham.Text.Length;
            }
            if (txtSoLuongSanPham.Text.StartsWith("0") && txtSoLuongSanPham.Text.Length > 1)
            {
                // Xóa số "0" ở đầu
                txtSoLuongSanPham.Text = txtSoLuongSanPham.Text.TrimStart('0');
                txtSoLuongSanPham.SelectionStart = txtSoLuongSanPham.Text.Length; // Đặt con trỏ ở cuối
            }
            if (dtgvSanPhamTrongPhieuDat.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.SelectedRows)
                {
                    int soLuongDat = int.Parse(txtSoLuongSanPham.Text.ToString());
                    row.Cells["soLuongDat"].Value = soLuongDat;
                    
                }
            }
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                txtDonGia.Text = "0";
                txtDonGia.SelectionStart = txtDonGia.Text.Length;
            }
            if (txtDonGia.Text.StartsWith("0") && txtDonGia.Text.Length > 1)
            {
                // Xóa số "0" ở đầu
                txtDonGia.Text = txtDonGia.Text.TrimStart('0');
                txtDonGia.SelectionStart = txtDonGia.Text.Length; // Đặt con trỏ ở cuối
            }
            if (dtgvSanPhamTrongPhieuDat.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.SelectedRows)
                {
                    decimal donGia = decimal.Parse(txtDonGia.Text.ToString());
                    row.Cells["donGiaSP"].Value = donGia;
                }
            }
        }
        private void TinhTongTien()
        {
            int tongTien = 0;
            foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.Rows)
            {
                string price = row.Cells["thanhTien"].Value.ToString();
                price = price.Replace("₫", "").Replace(".", "").Split(',')[0].Trim();
                int thanhTien = int.Parse(price);
                tongTien += thanhTien;
            }
            txtTongTien.Text = tongTien.ToString("C0");
        }
        private void dtgvSanPhamTrongPhieuDat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        { 
            string columnName = dtgvSanPhamTrongPhieuDat.Columns[e.ColumnIndex].Name;
            if (columnName == "soLuongDat" || columnName == "donGiaSP")
            {                
                foreach (DataGridViewRow row in dtgvSanPhamTrongPhieuDat.SelectedRows)
                {
                    string price = row.Cells["donGiaSP"].Value.ToString();
                    price = price.Replace("₫", "").Replace(".", "").Split(',')[0].Trim();
                    decimal donGia = decimal.Parse(price);
                    int soLuongDat = int.Parse(row.Cells["soLuongDat"].Value.ToString());
                    decimal thanhTien = soLuongDat * donGia;
                    row.Cells["thanhTien"].Value = thanhTien;
                }
            }
            if (columnName == "thanhTien")
            {
                TinhTongTien();
            }
        }
        private void dtgvSanPhamTrongPhieuDat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!themPhieu)
            {
                if ((dtgvSanPhamTrongPhieuDat.Columns[e.ColumnIndex].Name == "donGiaSP" && e.Value != null) || (dtgvSanPhamTrongPhieuDat.Columns[e.ColumnIndex].Name == "thanhTien" && e.Value != null))
                {
                    e.Value = ((decimal)e.Value).ToString("C0");
                    e.FormattingApplied = true;
                }
            }
        }
    }
}