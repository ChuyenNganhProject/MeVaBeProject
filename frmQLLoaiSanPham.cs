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

namespace MeVaBeProject
{
    public partial class frmQLLoaiSanPham : Form
    {
        private LoaiSanPhamBLL loaiSanPhamBLL;
        public delegate void SendDataHandler(bool loadData);
        public event SendDataHandler DongForm;
        public frmQLLoaiSanPham()
        {
            InitializeComponent();
            this.loaiSanPhamBLL = new LoaiSanPhamBLL();
            this.Load += FrmQLLoaiSanPham_Load;
        }
        private void LoadLoaiSanPham()
        {
            dtgvLoaiSanPham.DataSource = loaiSanPhamBLL.LayDanhSachLoaiSanPham();
        }
        private void FrmQLLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadLoaiSanPham();
            EnableTextBox(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DongForm?.Invoke(true);
            this.Close();
        }

        private void dtgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtMaLoai.Text = dtgvLoaiSanPham.Rows[e.RowIndex].Cells["maLoaiSanPham"].Value.ToString();
                txtTenLoai.Text = dtgvLoaiSanPham.Rows[e.RowIndex].Cells["tenLoaiSanPham"].Value.ToString();
            }
        }
        private void EnableDataGridView(bool enable)
        {
            dtgvLoaiSanPham.Enabled = enable;
            dtgvLoaiSanPham.DefaultCellStyle.BackColor = enable ? Color.White : Color.LightGray;
        }
        private void EnableTextBox(bool enable)
        {
            txtTenLoai.Enabled = enable;            
        }
        private void ClearForm()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";            
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập mã loại sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }            
            return true;
        }
        private void SetButtonStyle(UIButton button, bool isEnabled)
        {
            if (isEnabled)
            {
                button.RectColor = System.Drawing.Color.HotPink;
                button.RectDisableColor = System.Drawing.Color.Fuchsia;
                button.RectHoverColor = System.Drawing.Color.DeepPink;
                button.RectPressColor = System.Drawing.Color.DeepPink;
                button.RectSelectedColor = System.Drawing.Color.FromArgb(255, 128, 255);
                button.FillColor = System.Drawing.Color.HotPink;
                button.FillHoverColor = System.Drawing.Color.DeepPink;
                button.FillPressColor = System.Drawing.Color.DeepPink;
                button.ForeColor = System.Drawing.Color.White; // Màu chữ khi nút được kích hoạt
            }
            else
            {
                button.RectColor = System.Drawing.Color.DarkGray;
                button.RectDisableColor = System.Drawing.Color.DarkGray;
                button.RectHoverColor = System.Drawing.Color.DarkGray;
                button.RectPressColor = System.Drawing.Color.DarkGray;
                button.RectSelectedColor = System.Drawing.Color.DarkGray;
                button.FillColor = System.Drawing.Color.DarkGray;
                button.FillHoverColor = System.Drawing.Color.DarkGray;
                button.FillPressColor = System.Drawing.Color.DarkGray;
                button.ForeColor = System.Drawing.Color.Gray; // Màu chữ khi nút bị vô hiệu hóa
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text=="Thêm")
            {
                ClearForm();
                btnThem.Text = "Xác nhận";
                btnHuyBo.Enabled = true;
                btnHuyBo.BackColor = Color.IndianRed;
                btnSua.Enabled = false;
                SetButtonStyle(btnSua, false);
                btnXoa.Enabled = false;
                SetButtonStyle(btnXoa, false);
                txtMaLoai.Text = loaiSanPhamBLL.TaoMaLoaiSanPham();
                EnableTextBox(true);
            }
            else if (btnThem.Text == "Xác nhận")
            {
                if (ValidateInput())
                {
                    string maLoai = txtMaLoai.Text.Trim();
                    string tenLoai = txtTenLoai.Text.Trim();                   
                    LoaiSanPham newLoaiSP = new LoaiSanPham
                    {
                        maLoaiSanPham = maLoai,
                        tenLoaiSanPham = tenLoai,                        
                    };
                    try
                    {
                        bool isSuccess = loaiSanPhamBLL.ThemLoaiSanPham(newLoaiSP);
                        if (isSuccess)
                        {
                            MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLoaiSanPham();
                            ClearForm();
                            EnableDataGridView(true);
                            btnSua.Enabled = true;
                            SetButtonStyle(btnSua, true);
                            btnXoa.Enabled = true;
                            SetButtonStyle(btnXoa, true);

                            btnThem.Text = "Thêm";
                            btnHuyBo.Enabled = false;
                            btnHuyBo.BackColor = Color.DarkGray;

                            EnableTextBox(false);
                        }
                        else
                        {
                            MessageBox.Show("Thêm loại sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi thêm loại sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text!=string.Empty)
            {
                if (btnSua.Text == "Sửa")
                {
                    EnableDataGridView(false);
                    btnSua.Text = "Xác nhận";
                    btnHuyBo.Enabled = true;
                    btnHuyBo.BackColor = Color.IndianRed;
                    btnThem.Enabled = false;
                    SetButtonStyle(btnThem, false);
                    btnXoa.Enabled = false;
                    SetButtonStyle(btnXoa, false);

                    EnableTextBox(true);
                }
                else if (btnSua.Text == "Xác nhận")
                {
                    if (ValidateInput())
                    {
                        string maLoai = txtMaLoai.Text.Trim();
                        string tenLoai = txtTenLoai.Text.Trim();
                        LoaiSanPham newLoaiSP = new LoaiSanPham
                        {
                            maLoaiSanPham = maLoai,
                            tenLoaiSanPham = tenLoai,
                        };
                        try
                        {
                            bool isSuccess = loaiSanPhamBLL.SuaLoaiSanPham(newLoaiSP);
                            if (isSuccess)
                            {
                                MessageBox.Show("Sửa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadLoaiSanPham();

                                ClearForm();
                                EnableDataGridView(true);
                                btnThem.Enabled = true;
                                SetButtonStyle(btnThem, true);
                                btnXoa.Enabled = true;
                                SetButtonStyle(btnXoa, true);

                                btnSua.Text = "Sửa";
                                btnHuyBo.Enabled = false;
                                btnHuyBo.BackColor = Color.DarkGray;

                                EnableTextBox(false);
                            }
                            else
                            {
                                MessageBox.Show("Sửa loại sản phẩm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi sửa loại sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text!=string.Empty)
            {
                string maLoaiSanPham = txtMaLoai.Text;
                string tenLoaiSanPham = txtTenLoai.Text;
                DialogResult r = MessageBox.Show(this, "Bạn có chắc chắc muốn xóa loại sản phẩm " + tenLoaiSanPham + " này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    LoaiSanPham loaiSP = new LoaiSanPham
                    {
                        maLoaiSanPham = maLoaiSanPham,
                        tenLoaiSanPham = tenLoaiSanPham
                    };
                    int dem = loaiSanPhamBLL.DemSoSanPhamThuocLoai(loaiSP.maLoaiSanPham);
                    if (dem>0)
                    {
                        MessageBox.Show(this, $"Không thể xóa loại sản phẩm {loaiSP.tenLoaiSanPham} do còn sản phẩm thuộc loại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bool isSuccess = loaiSanPhamBLL.XoaLoaiSanPham(loaiSP);
                        if (isSuccess)
                        {
                            MessageBox.Show(this, "Xóa loại sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadLoaiSanPham();
                        }
                        else
                        {
                            MessageBox.Show(this, "Xóa loại sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ClearForm();
            EnableTextBox(false);

            EnableDataGridView(true);
            btnThem.Enabled = true;
            SetButtonStyle(btnThem, true);
            btnSua.Enabled = true;
            SetButtonStyle(btnSua, true);
            btnXoa.Enabled = true;
            SetButtonStyle(btnXoa, true);

            btnThem.Text = "Thêm";
            btnSua.Text = "Sửa";
            btnHuyBo.Enabled = false;
            btnHuyBo.BackColor = Color.DarkGray;
        }
    }
}
