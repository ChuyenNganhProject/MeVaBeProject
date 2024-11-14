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
    public partial class frmTrangChu : Form
    {
        private string maNhanVien;
        public frmTrangChu(string maNhanVien)
        {
            InitializeComponent();
            this.btnClose.Click += BtnClose_Click;
            this.btnNhapHang.Click += BtnNhapHang_Click;
            this.btnSanPham.Click += BtnSanPham_Click;
            this.btnDangXuat.Click += BtnDangXuat_Click;
            this.Load += FrmTrangChu_Load;
            this.btnNhanVien.Click += BtnNhanVien_Click;
            this.btnKhachHang.Click += BtnKhachHang_Click;
            this.maNhanVien = maNhanVien;
            this.btnHoaDon.Click += BtnHoaDon_Click;
            this.btnDashboard.Click += BtnDashboard_Click;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard();
            OpenChildForm(frm);
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            frmQLHoaDon frm = new frmQLHoaDon();
            OpenChildForm(frm);
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            OpenChildForm(frm);
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
           frmNhanVien frm = new frmNhanVien();
           OpenChildForm(frm);
        }

        private void FrmTrangChu_Load(object sender, EventArgs a)
        {
            this.btnDangXuat.MouseHover += (s, e) => btnDangXuat.BackColor = System.Drawing.Color.LightPink;
            this.btnDangXuat.MouseDown += (s, e) => btnDangXuat.BackColor = System.Drawing.Color.HotPink;
            this.btnDangXuat.MouseLeave += (s, e) => btnDangXuat.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnNhanVien.MouseHover += (s, e) => btnNhanVien.BackColor = System.Drawing.Color.LightPink;
            this.btnNhanVien.MouseDown += (s, e) => btnNhanVien.BackColor = System.Drawing.Color.HotPink;
            this.btnNhanVien.MouseLeave += (s, e) => btnNhanVien.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnNhapHang.MouseHover += (s, e) => btnNhapHang.BackColor = System.Drawing.Color.LightPink;
            this.btnNhapHang.MouseDown += (s, e) => btnNhapHang.BackColor = System.Drawing.Color.HotPink;
            this.btnNhapHang.MouseLeave += (s, e) => btnNhapHang.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnKhachHang.MouseHover += (s, e) => btnKhachHang.BackColor = System.Drawing.Color.LightPink;
            this.btnKhachHang.MouseDown += (s, e) => btnKhachHang.BackColor = System.Drawing.Color.HotPink;
            this.btnKhachHang.MouseLeave += (s, e) => btnKhachHang.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnHoaDon.MouseHover += (s, e) => btnHoaDon.BackColor = System.Drawing.Color.LightPink;
            this.btnHoaDon.MouseDown += (s, e) => btnHoaDon.BackColor = System.Drawing.Color.HotPink;
            this.btnHoaDon.MouseLeave += (s, e) => btnHoaDon.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnSanPham.MouseHover += (s, e) => btnSanPham.BackColor = System.Drawing.Color.LightPink;
            this.btnSanPham.MouseDown += (s, e) => btnSanPham.BackColor = System.Drawing.Color.HotPink;
            this.btnSanPham.MouseLeave += (s, e) => btnSanPham.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnQLNhaCungCap.MouseHover += (s, e) => btnQLNhaCungCap.BackColor = System.Drawing.Color.LightPink;
            this.btnQLNhaCungCap.MouseDown += (s, e) => btnQLNhaCungCap.BackColor = System.Drawing.Color.HotPink;
            this.btnQLNhaCungCap.MouseLeave += (s, e) => btnQLNhaCungCap.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnDashboard.MouseHover += (s, e) => btnDashboard.BackColor = System.Drawing.Color.LightPink;
            this.btnDashboard.MouseDown += (s, e) => btnDashboard.BackColor = System.Drawing.Color.HotPink;
            this.btnDashboard.MouseLeave += (s, e) => btnDashboard.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);

            this.btnDatHang.MouseHover += (s, e) => btnDatHang.BackColor = System.Drawing.Color.LightPink;
            this.btnDatHang.MouseDown += (s, e) => btnDatHang.BackColor = System.Drawing.Color.HotPink;
            this.btnDatHang.MouseLeave += (s, e) => btnDatHang.BackColor = System.Drawing.Color.FromArgb(255, 70, 158);
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.Show();
                this.Close();
            }
        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            OpenChildForm(frm);
        }

        private void BtnNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang(maNhanVien);
            OpenChildForm(frm);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            frmQLDatHang frmQLDatHang = new frmQLDatHang(maNhanVien);
            OpenChildForm(frmQLDatHang);
        }

        private void btnQLNhaCungCap_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap frmQLNhaCungCap = new frmQLNhaCungCap();
            OpenChildForm(frmQLNhaCungCap);
        }
    }
}
