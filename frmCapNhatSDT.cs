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
    public partial class frmCapNhatSDT : Form
    {
        private string oldSDT;
        public string newSDT;
        KhachHangBLL khbll = new KhachHangBLL();
        public frmCapNhatSDT(string oldSDT)
        {
            InitializeComponent();

            this.btnDong.Click += BtnDong_Click;
            this.btnCapNhat.Click += BtnCapNhat_Click;

            this.oldSDT = oldSDT;
            this.Load += FrmCapNhatSDT_Load;
            this.txtNewSDT.KeyPress += TxtNewSDT_KeyPress;
        }

        private void TxtNewSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNewSDT.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmCapNhatSDT_Load(object sender, EventArgs e)
        {
            txtOldSdt.Text = oldSDT;
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if(KiemTraTruocKhiSuaSoDienThoai())
            {
                newSDT = txtNewSDT.Text;
                KhachHang kh = khbll.LayKhachHangTheoSoDienThoai(oldSDT);
                if(newSDT != kh.soDienThoai)
                {
                    kh.soDienThoai = newSDT;
                    khbll.CapNhatKhachHang(kh);
                    MessageBox.Show("Cập nhật số điện thoại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại khác với số hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void BtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraTruocKhiSuaSoDienThoai()
        {
            bool dinhDang = true;
            errorSdt.Clear();
            if (string.IsNullOrWhiteSpace(txtNewSDT.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại mới", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorSdt.SetError(txtNewSDT, "Vui lòng nhập số điện thoại mới");
                dinhDang = false;
            }
            else if (txtNewSDT.Text.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điện thoại", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorSdt.SetError(txtNewSDT, "Vui lòng nhập đúng định dạng số điện thoại");
                dinhDang = false;
            }
            return dinhDang;
        }

        private void frmCapNhatSDT_Paint_1(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.HotPink;
            int borderWidth = 5;

            // Vẽ viền
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - borderWidth, this.Height - borderWidth);
            }
        }

        
    }
}
