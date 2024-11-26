using BLL;
using DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MeVaBeProject
{
    public partial class frmThemSanPhamKhuyenMai : Form
    {
        private frmTrangChu parentfrm;

        LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
        SanPhamBLL spbll = new SanPhamBLL();
        KhuyenMaiSanPhamBLL kmspbll = new KhuyenMaiSanPhamBLL();
        KhuyenMaiBLL kmbll = new KhuyenMaiBLL();
        private string MaKM;
        private string MaSp;
        
        public frmThemSanPhamKhuyenMai(frmTrangChu parentfrm, string MaKM)
        {
            InitializeComponent();
            this.parentfrm = parentfrm;
            this.MaKM = MaKM;
            this.Load += FrmThemSanPhamKhuyenMai_Load;
            this.btnBack.Click += BtnBack_Click;

            this.btnTatCaSanPham.Click += BtnTatCaSanPham_Click;
            this.dgvDSSP.SelectionChanged += DgvDSSP_SelectionChanged;
            this.dgvDSSP.CellContentClick += DgvDSSP_CellContentClick;
            this.dgvDSSP.CellFormatting += DgvDSSP_CellFormatting;

            this.btnXacNhan.Click += BtnXacNhan_Click;
            this.btnHuyGiam.Click += BtnHuyGiam_Click;
        }

        private void BtnHuyGiam_Click(object sender, EventArgs e)
        {
            SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);
            KhuyenMaiSanPham sanPhamTrongKhuyenMai = kmspbll.LayTTSanPhamCuaKhuyenMai(MaKM, MaSp);
            
            
            if (sanPhamTrongKhuyenMai != null)
            {
                var result = MessageBox.Show("Bạn có chắc muốn hủy khuyến mãi sản phẩm " + sanPham.tenSanPham + " không ?",
                                                    "Thông báo",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (sanPhamTrongKhuyenMai.trangThai != "Đã hủy")
                    {
                        sanPhamTrongKhuyenMai.trangThai = "Đã hủy";
                        if (kmspbll.ThemHoacCapNhatSanPhamVaoCTKhuyenMai(sanPhamTrongKhuyenMai))
                        {
                            MessageBox.Show("Hủy khuyến mãi sản phẩm thành công",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            btnHuyGiam.Enabled = false;
                            numericPhanTramGiam.Value = numericPhanTramGiam.Minimum;
                            lblGiaSauGiam.Text = "";
                            lblPhanTramGiam.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Hủy khuyến mãi sản phẩm thất bại",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void DgvDSSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDSSP.Columns[e.ColumnIndex].Name == "maSanPham")
            {
                // Lấy mã sản phẩm của dòng hiện tại
                string maSp = dgvDSSP.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString();

                // Lấy thông tin khuyến mãi hiện tại
                var khuyenMaiHienTai = kmbll.LayTTKhuyenMaiTuMaKM(MaKM);
                DateTime tgBatDauCuaKhuyenMaiHienTai = khuyenMaiHienTai.ngayBatDau.Value;
                DateTime tgKetThucCuaKhuyenMaiHienTai = khuyenMaiHienTai.ngayKetThuc.Value;

                // Lấy danh sách khuyến mãi liên quan đến sản phẩm
                var khuyenMaiCoSanPhamDo = kmspbll.LayKhuyenMaiTheoSanPham(maSp);

                // Kiểm tra điều kiện đổi màu
                foreach (var kmsp in khuyenMaiCoSanPhamDo)
                {
                    var khuyenMai = kmbll.LayTTKhuyenMaiTuMaKM(kmsp.maKhuyenMai);
                    if (khuyenMai != null && khuyenMai.trangThai != "Đã kết thúc")
                    {
                        if (khuyenMai.ngayBatDau < tgKetThucCuaKhuyenMaiHienTai &&
                            khuyenMai.ngayKetThuc > tgBatDauCuaKhuyenMaiHienTai &&
                            khuyenMai.maKhuyenMai != MaKM)
                        {
                            // Nếu sản phẩm thuộc khuyến mãi khác trùng thời gian
                            dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                            dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                            return;
                        }
                        else if(khuyenMai.maKhuyenMai == MaKM)
                        {
                            dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                            dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                            return;
                        }
                    }
                }

                // Nếu không thỏa điều kiện, đặt lại màu mặc định
                dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvDSSP.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void DgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDSSP.Columns["duocChon"].Index && e.RowIndex >= 0)
            {
                string maSanPham = dgvDSSP.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString();
                MaSp = maSanPham;
                SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);
                if (sanPham != null)
                {
                    if (!kmspbll.KiemTraSanPhamTrongKhoangThoiGianKhuyenMai(MaKM, maSanPham))
                    {
                        MessageBox.Show("Sản phẩm này không thể thêm vào khuyến mãi mới do trùng thời gian với khuyến mãi khác.",
                                        "Cảnh báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);

                        DataGridViewCheckBoxCell checkBoxDuocChon = (DataGridViewCheckBoxCell)dgvDSSP.Rows[e.RowIndex].Cells["duocChon"];
                        checkBoxDuocChon.Value = false;
                        return;
                    }

                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvDSSP.Rows[e.RowIndex].Cells["duocChon"];
                    bool duocChon = (bool)(checkBoxCell.Value ?? false);
                    checkBoxCell.Value = !duocChon;

                    numericPhanTramGiam.Enabled = true;
                    numericSoLuongToiDa.Value = numericSoLuongToiDa.Minimum;
                }
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            var danhSachDuocChon = dgvDSSP.Rows.Cast<DataGridViewRow>()
                                    .Where(row => Convert.ToBoolean(row.Cells["duocChon"].Value) == true)
                                    .Select(row => new
                                    {
                                        maSanPham = row.Cells["maSanPham"].Value.ToString(),
                                        tenSanPham = row.Cells["tenSanPham"].Value.ToString()
                                    }).ToList();
            if(danhSachDuocChon.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để áp dụng khuyến mãi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(numericPhanTramGiam.Value == 0)
            {
                MessageBox.Show("Giá trị phần trăm giảm phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            decimal phanTramGiam = numericPhanTramGiam.Value;
            int soLuongToiDa = (int)numericSoLuongToiDa.Value;

            bool isSuccess = true;
            foreach (var sp in danhSachDuocChon)
            {
                KhuyenMaiSanPham kmsp = new KhuyenMaiSanPham
                {
                    maKhuyenMai = MaKM,
                    maSanPham = sp.maSanPham,
                    phanTramGiam = phanTramGiam,
                    soLuongToiDa = soLuongToiDa,
                    trangThai = "Có hiệu lực"
                };
                if(!kmspbll.ThemHoacCapNhatSanPhamVaoCTKhuyenMai(kmsp))
                {
                    isSuccess = false;
                    MessageBox.Show($"Thêm sản phẩm {sp.tenSanPham} thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (isSuccess)
            {
                MessageBox.Show("Thêm tất cả sản phẩm vào khuyến mãi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblTenSp.Text = "";
                lblGiaGoc.Text = "";
                lblGiaSauGiam.Text = "";
                numericPhanTramGiam.Value = 0;
                numericSoLuongToiDa.Value = 1;
                numericPhanTramGiam.Enabled = false;
                numericSoLuongToiDa.Enabled = false;
            }

            foreach (DataGridViewRow row in dgvDSSP.Rows)
            {
                row.Cells["duocChon"].Value = false;
            }
        }

        private void DgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSSP.SelectedRows.Count > 0)
            {
                string maSanPham = dgvDSSP.SelectedRows[0].Cells["maSanPham"].Value.ToString();
                MaSp = maSanPham;
                SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);

                if (sanPham != null)
                {
                    if (!kmspbll.KiemTraSanPhamTrongKhoangThoiGianKhuyenMai(MaKM, maSanPham))
                    {
                        MessageBox.Show("Sản phẩm này không thể thêm vào khuyến mãi mới do trùng thời gian với khuyến mãi khác.",
                                        "Cảnh báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        return;
                    }

                    lblTenSp.Text = sanPham.tenSanPham;
                    lblGiaGoc.Text = $"{sanPham.donGiaBan:N0}đ";
                    numericSoLuongToiDa.Enabled = true;
                    numericSoLuongToiDa.Maximum = sanPham.soLuong ?? 0;
                    numericPhanTramGiam.Value = numericPhanTramGiam.Minimum;
                    btnHuyGiam.Enabled = false;

                    KhuyenMaiSanPham sanPhamKhuyenMai = kmspbll.LayTTSanPhamCuaKhuyenMai(MaKM, MaSp);
                    if (sanPhamKhuyenMai != null)
                    {
                        numericPhanTramGiam.Value = sanPhamKhuyenMai.phanTramGiam.Value;
                        lblPhanTramGiam.Text = sanPhamKhuyenMai.phanTramGiam.Value.ToString("N0") + "% Giảm";
                        lblGiaSauGiam.Text = (sanPham.donGiaBan.Value - (sanPham.donGiaBan.Value * (sanPhamKhuyenMai.phanTramGiam.Value / 100)))
                            .ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
                        btnHuyGiam.Enabled = true;
                    }
                }
            }
        }

        private void FrmThemSanPhamKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
            LoadTatCaSanPham();
            numericPhanTramGiam.DecimalPlaces = 2;

            if (dgvDSSP.Rows.Count > 0)
            {
                var khuyenMaiHienTai = kmbll.LayTTKhuyenMaiTuMaKM(MaKM);
                DateTime tgBatDauCuaKhuyenMaiHienTai = khuyenMaiHienTai.ngayBatDau.Value; // 11
                DateTime tgKetThucCuaKhuyenMaiHienTai = khuyenMaiHienTai.ngayKetThuc.Value; // 14

                foreach (DataGridViewRow row in dgvDSSP.Rows)
                {
                    string maSp = row.Cells["maSanPham"].Value.ToString();
                    var khuyenMaiCoSanPhamDo = kmspbll.LayKhuyenMaiTheoSanPham(maSp);

                    foreach (var kmsp in khuyenMaiCoSanPhamDo)
                    {
                        var khuyenMai = kmbll.LayTTKhuyenMaiTuMaKM(kmsp.maKhuyenMai);
                        if (khuyenMai != null && khuyenMai.trangThai != "Đã kết thúc")
                        { // 10 11               13 14
                            if(khuyenMai.ngayBatDau < tgKetThucCuaKhuyenMaiHienTai && khuyenMai.ngayKetThuc > tgBatDauCuaKhuyenMaiHienTai)
                            {
                                if (khuyenMai.maKhuyenMai != MaKM)
                                {
                                    row.DefaultCellStyle.BackColor = Color.LightGray;
                                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                                }
                            }
                            
                            else
                            {
                                // Nếu sản phẩm thuộc khuyến mãi hiện tại, có thể đặt lại màu sắc
                                row.DefaultCellStyle.BackColor = Color.White;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        else
                        {
                            // Nếu sản phẩm không thuộc khuyến mãi nào
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void BtnTatCaSanPham_Click(object sender, EventArgs e)
        {
            LoadTatCaSanPham();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmTaoKhuyenMai frm = new frmTaoKhuyenMai(parentfrm, MaKM);
            parentfrm.OpenChildForm(frm);
        }

        private void AddLoaiSpButton(string tenLoaiSp, string maLoaiSp)
        {
            UIButton loaiSpButton = new UIButton();
            loaiSpButton.Text = tenLoaiSp;
            loaiSpButton.BackColor = SystemColors.Window;
            loaiSpButton.Cursor = Cursors.Hand;
            loaiSpButton.Dock = DockStyle.Top;
            loaiSpButton.FillColor = SystemColors.Window;
            loaiSpButton.FillHoverColor = Color.White;
            loaiSpButton.FillPressColor = Color.White;
            loaiSpButton.FillSelectedColor = Color.White;
            loaiSpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163)));
            loaiSpButton.ForeColor = Color.Black;
            loaiSpButton.ForeHoverColor = Color.Black;
            loaiSpButton.ForePressColor = Color.Magenta;
            loaiSpButton.ForeSelectedColor = Color.Magenta;
            loaiSpButton.MinimumSize = new Size(1, 1);
            loaiSpButton.Padding = new Padding(10);
            loaiSpButton.RectColor = SystemColors.Window;
            loaiSpButton.RectHoverColor = Color.HotPink;
            loaiSpButton.RectPressColor = Color.HotPink;
            loaiSpButton.RectSelectedColor = Color.HotPink;
            loaiSpButton.Size = new Size(this.btnTatCaSanPham.Width, this.btnTatCaSanPham.Height);
            loaiSpButton.TextAlign = ContentAlignment.MiddleLeft;
            loaiSpButton.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
            loaiSpButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);

            loaiSpButton.Click += (s, e) => LoadSanPhamTheoLoai(maLoaiSp);
            loaiSpPanel.Controls.Add(loaiSpButton);
        }

        private void LoadLoaiSanPham()
        {
            List<LoaiSanPham> loaiSanPhams = lspbll.LayDanhSachSanPham();

            foreach (var loaisp in loaiSanPhams)
            {
                AddLoaiSpButton(loaisp.tenLoaiSanPham, loaisp.maLoaiSanPham);
            }
        }

        private void LoadSanPhamTheoLoai(string maLoaiSanPham)
        {
            List<SanPham> danhSachSanPham = spbll.LayDanhSachSanPhamTheoMaLoai(maLoaiSanPham);

            var dataSource = danhSachSanPham.Select(sp => new
            {
                maSanPham = sp.maSanPham,
                tenSanPham = sp.tenSanPham,
                duocChon = false
            }).ToList();

            dgvDSSP.DataSource = null;
            dgvDSSP.DataSource = dataSource;

            dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void LoadTatCaSanPham()
        {
            List<SanPham> danhSachSanPham = spbll.LoadTatCaSanPham();

            var dataSource = danhSachSanPham.Select(sp => new
            {
                maSanPham = sp.maSanPham,
                tenSanPham = sp.tenSanPham,
                duocChon = false
            }).ToList();

            dgvDSSP.DataSource = null;
            dgvDSSP.DataSource = dataSource;

            dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["duocChon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
