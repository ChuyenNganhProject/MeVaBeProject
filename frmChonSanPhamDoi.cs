using BLL;
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
    public partial class frmChonSanPhamDoi : Form
    {
        private decimal giaTriSanPham;
        private int rowIndex;
        private SanPhamBLL sanPhamBLL;        
        public delegate void SendDataHandler(string maSanPham,string tenSanPham,decimal giaTriSanPhamDoi,int rowIndex);
        public event SendDataHandler TruyenDuLieu;
        public frmChonSanPhamDoi(decimal giaTriSanPham,int rowIndex)
        {
            InitializeComponent();
            this.giaTriSanPham = giaTriSanPham;
            this.rowIndex = rowIndex;
            this.sanPhamBLL = new SanPhamBLL();
            this.Load += FrmChonSanPhamDoi_Load;
        }

        private void FrmChonSanPhamDoi_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = sanPhamBLL.LayDanhSachSanPhamTheoMucGia(giaTriSanPham);
            dgvProducts.Columns["hinhAnh"].Visible = false;
            dgvProducts.Columns["LoaiSanPham"].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string maSanPham = dgvProducts.Rows[e.RowIndex].Cells["maSanPham"].Value.ToString();
                string tenSanPham = dgvProducts.Rows[e.RowIndex].Cells["tenSanPham"].Value.ToString();
                decimal donGia = decimal.Parse(dgvProducts.Rows[e.RowIndex].Cells["donGiaBan"].Value.ToString());
                TruyenDuLieu?.Invoke(maSanPham, tenSanPham, donGia, rowIndex);
                this.Close();
            }
        }
    }
}
