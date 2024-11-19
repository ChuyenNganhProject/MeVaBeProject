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
    public partial class frmSanPham : Form
    {
        private frmTrangChu parentfrm;
        public frmSanPham(frmTrangChu parentfrm)
        {
            InitializeComponent();
            this.parentfrm = parentfrm;
            this.btnKhuyenMai.Click += BtnKhuyenMai_Click;
        }

        private void BtnKhuyenMai_Click(object sender, EventArgs e)
        {
            frmQLKhuyenMai frm = new frmQLKhuyenMai(parentfrm);
            parentfrm.OpenChildForm(frm);
        }
    }
}
