using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace MeVaBeProject
{
    public partial class FormDangNhap : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public FormDangNhap()
        {
            InitializeComponent();
            this.btnLogin.Click += BtnLogin_Click;
            this.btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            var nhanVien = nvbll.DangNhap(tenDangNhap, matKhau);

            if(nhanVien != null)
            {
                MessageBox.Show($"Đăng nhập thành công! Xin chào, {nhanVien.tenNhanVien}");
                if(nhanVien.maLoaiNhanVien == "QL")
                {
                    frmTrangChu frm = new frmTrangChu(nhanVien.maNhanVien);
                    frm.Show();
                    this.Hide();
                }
                else if(nhanVien.maLoaiNhanVien == "NVBH")
                {
                    //frmBanHang frm = new frmBanHang();
                    //frm.Show();
                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
