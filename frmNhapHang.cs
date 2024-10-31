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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
            this.btnDatHang.Click += BtnDatHang_Click;
            this.btnQLNhaCungCap.Click += BtnQLNhaCungCap_Click;
        }

        private void BtnQLNhaCungCap_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap frm = new frmQLNhaCungCap();
            frm.ShowDialog();
        }

        private void BtnDatHang_Click(object sender, EventArgs e)
        {
            frmDatHang frmDatHang = new frmDatHang();
            frmDatHang.ShowDialog();
        }
    }
}
