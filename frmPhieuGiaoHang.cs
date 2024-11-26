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
    public partial class frmPhieuGiaoHang : Form
    {
        public frmPhieuGiaoHang()
        {
            InitializeComponent();
            this.Load += FrmPhieuGiaoHang_Load;
        }

        private void FrmPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            rptPhieuGiaoHang.LocalReport.ReportPath = @"./PhieuGiaoHang.rdlc";
        }
    }
}
