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
            this.numericPhanTramGiam.ValueChanged += NumericPhanTramGiam_ValueChanged;

            this.btnXacNhan.Click += BtnXacNhan_Click;
        }

        private void NumericPhanTramGiam_ValueChanged(object sender, EventArgs e)
        {
            SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);
            decimal giaSauGiam = sanPham.donGiaBan.Value - (numericPhanTramGiam.Value / 100) * sanPham.donGiaBan.Value;
            lblGiaSauGiam.Text = giaSauGiam.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "đ";
            if (numericPhanTramGiam.Value == 0)
            {
                lblGiaSauGiam.Visible = false;
            }
            else
            {
                lblGiaSauGiam.Visible = true;
            }
        }

        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if(numericPhanTramGiam.Value == 0)
            {
                MessageBox.Show("Giá trị phần trăm giảm phải lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                decimal phanTramGiam = numericPhanTramGiam.Value;
                int soLuongToiDa = int.Parse(numericSoLuongToiDa.Value.ToString());
                if(kmspbll.ThemHoacCapNhatSanPhamVaoCTKhuyenMai(MaKM, MaSp, phanTramGiam, soLuongToiDa))
                {
                    string giaSauGiamText = lblGiaSauGiam.Text.Replace("đ", "");
                    if(decimal.TryParse(giaSauGiamText, NumberStyles.Currency, CultureInfo.GetCultureInfo("vi-VN"), out decimal giaSauGiam))
                    {
                        SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);
                        sanPham.donGiaSale = giaSauGiam;
                        spbll.CapNhatSanPham(sanPham);
                    }
                    
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblTenSp.Text = "";
                    lblGiaGoc.Text = "";
                    lblGiaSauGiam.Text = "";
                    numericPhanTramGiam.Value = 0;
                    numericSoLuongToiDa.Value = 1; 
                }
            }
        }

        private void DgvDSSP_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDSSP.SelectedRows.Count > 0)
            {
                string maSanPham = dgvDSSP.SelectedRows[0].Cells["maSanPham"].Value.ToString();
                MaSp = maSanPham;
                SanPham sanPham = spbll.TimKiemSanPhamTheoMaSP(MaSp);
                var khuyenMaiSanPham = kmspbll.LayKhuyenMaiTheoSanPham(maSanPham);
                
                if (khuyenMaiSanPham != null)
                {
                    var khuyenMai = kmbll.LayTTKhuyenMaiTuMaKM(khuyenMaiSanPham.maKhuyenMai);
                    if (khuyenMai != null && khuyenMai.maKhuyenMai != MaKM)
                    {
                        MessageBox.Show(
                            "Sản phẩm này đã thuộc khuyến mãi khác: " + khuyenMai.tenKhuyenMai + ".",
                            "Không thể chọn",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                    else if (khuyenMai != null && khuyenMai.maKhuyenMai == MaKM)
                    {
                        if (sanPham != null)
                        {
                            lblTenSp.Text = sanPham.tenSanPham;
                            lblGiaGoc.Text = sanPham.donGiaBan.Value.ToString("N0").Replace(",", ".") + "đ";
                            numericPhanTramGiam.Enabled = true;
                            numericSoLuongToiDa.Enabled = true;
                            numericSoLuongToiDa.Maximum = sanPham.soLuong.HasValue ? sanPham.soLuong.Value : 0;
                            KhuyenMaiSanPham sanPhamKhuyenMai = kmspbll.LayTTSanPhamCuaKhuyenMai(MaKM, MaSp);
                            numericSoLuongToiDa.Value = sanPhamKhuyenMai.soLuongToiDa.Value;
                            numericPhanTramGiam.Value = sanPhamKhuyenMai.phanTramGiam.Value;
                        }
                    }
                }
                
                else
                {
                    if (sanPham != null)
                    {
                        lblTenSp.Text = sanPham.tenSanPham;
                        lblGiaGoc.Text = sanPham.donGiaBan.Value.ToString("N0").Replace(",", ".") + "đ";
                        numericPhanTramGiam.Enabled = true;
                        numericSoLuongToiDa.Enabled = true;
                        numericSoLuongToiDa.Maximum = sanPham.soLuong.HasValue ? sanPham.soLuong.Value : 0;
                        numericSoLuongToiDa.Value = numericSoLuongToiDa.Minimum;
                        numericPhanTramGiam.Value = numericPhanTramGiam.Minimum;
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
                foreach (DataGridViewRow row in dgvDSSP.Rows)
                {
                    string maSp = row.Cells["maSanPham"].Value.ToString();
                    var kmsp = kmspbll.LayKhuyenMaiTheoSanPham(maSp);

                    if (kmsp != null)
                    {
                        var khuyenMai = kmbll.LayTTKhuyenMaiTuMaKM(kmsp.maKhuyenMai);
                        if (khuyenMai != null && khuyenMai.maKhuyenMai != MaKM && khuyenMai.trangThai != "Đã kết thúc")
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            row.DefaultCellStyle.ForeColor = Color.DarkRed;
                        }
                        else if (khuyenMai.trangThai == "Đã kết thúc")
                        {
                            // Nếu sản phẩm thuộc khuyến mãi hiện tại, có thể đặt lại màu sắc
                            row.DefaultCellStyle.BackColor = Color.White;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            // Sản phẩm thuộc khuyến mãi hiện tại
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

            dgvDSSP.DataSource = danhSachSanPham.Select(sp => new
            {
                maSanPham = sp.maSanPham,
                tenSanPham = sp.tenSanPham
            }).ToList();
            dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void LoadTatCaSanPham()
        {
            List<SanPham> danhSachSanPham = spbll.LoadTatCaSanPham();

            dgvDSSP.DataSource = danhSachSanPham.Select(sp => new
            {
                maSanPham = sp.maSanPham,
                tenSanPham = sp.tenSanPham
            }).ToList();
            dgvDSSP.Columns["maSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDSSP.Columns["tenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
