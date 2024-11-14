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
    public partial class frmNhapHang : Form
    {
        private NhaCungCapBLL nhaCungCapBLL;
        private string maNhanVien;
        public frmNhapHang(string maNhanVien)
        {
            this.nhaCungCapBLL = new NhaCungCapBLL();
            this.maNhanVien = maNhanVien;
            InitializeComponent();
            this.btnTaoPhieuNhap.Click += BtnDatHang_Click;
        }

        private void BtnQLNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        private void BtnDatHang_Click(object sender, EventArgs e)
        {

        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
