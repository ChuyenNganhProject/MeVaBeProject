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
    public partial class frmQLNhaCungCap : Form
    {
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
            this.btnClose.Click += BtnClose_Click;
            this.btnThem.Click += BtnThem_Click;
            this.txtSDT.KeyPress += TxtSDT_KeyPress;
        }

        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                ClearForm();
                EnableDataGridView(false);
                btnThem.Text = "Xác nhận";
                btnHuyBo.Enabled = true;
                btnHuyBo.BackColor = Color.IndianRed;
                btnSua.Enabled = false;
                SetButtonStyle(btnSua, false);
                btnXoa.Enabled = false;
                SetButtonStyle(btnXoa, false);

                txtMaNCC.Enabled = true;
                txtTenNCC.Enabled = true;
                txtSDT.Enabled = true;
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
            }
            else if (btnThem.Text == "Xác nhận")
            {
                if (ValidateInput())
                {
                    string maNcc = txtMaNCC.Text.Trim();
                    string tenNcc = txtTenNCC.Text.Trim();
                    string sdt = txtSDT.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string email = txtEmail.Text.Trim();

                    NhaCungCap newNcc = new NhaCungCap
                    {
                        maNhaCungCap = maNcc,
                        tenNhaCungCap = tenNcc,
                        soDienThoai = sdt,
                        email = email,
                        diaChi = diaChi
                    };
                    try
                    {
                        bool isSuccess = nccbll.ThemNhaCungCap(newNcc);
                        if (isSuccess)
                        {
                            MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhaCungCap();

                            ClearForm();
                            EnableDataGridView(true);
                            btnSua.Enabled = true;
                            SetButtonStyle(btnSua, true);
                            btnXoa.Enabled = true;
                            SetButtonStyle(btnXoa, true);

                            btnThem.Text = "Thêm";
                            btnHuyBo.Enabled = false;
                            btnHuyBo.BackColor = Color.DarkGray;

                            txtMaNCC.Enabled = false;
                            txtTenNCC.Enabled = false;
                            txtSDT.Enabled = false;
                            txtDiaChi.Enabled = false;
                            txtEmail.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhà cung cấp thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi thêm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
                button.FillColor = System.Drawing.Color.LightPink;
                button.FillHoverColor = System.Drawing.Color.HotPink;
                button.FillPressColor = System.Drawing.Color.DeepPink;
                button.ForeColor = System.Drawing.Color.Black; // Màu chữ khi nút được kích hoạt
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadNhaCungCap()
        {
            List<NhaCungCap> nccList = nccbll.LoadNhaCungCap();
            dgvNhaCungCap.DataSource = nccList;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }

        private void EnableDataGridView(bool enable)
        {
            dgvNhaCungCap.Enabled = enable;
            dgvNhaCungCap.DefaultCellStyle.BackColor = enable ? Color.White : Color.LightGray;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
