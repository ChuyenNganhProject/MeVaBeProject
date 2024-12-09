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
        private BindingSource bindingSource;
        private SanPhamBLL sanPhamBLL;
        private LoaiSanPhamBLL loaiSanPhamBLL;
        public delegate void SendDataHandler(string maSanPham,string tenSanPham,decimal giaTriSanPhamDoi,int rowIndex);
        public event SendDataHandler TruyenDuLieu;
        public frmChonSanPhamDoi(decimal giaTriSanPham,int rowIndex)
        {
            InitializeComponent();
            this.giaTriSanPham = giaTriSanPham;
            this.rowIndex = rowIndex;
            this.bindingSource = new BindingSource();
            this.sanPhamBLL = new SanPhamBLL();
            this.loaiSanPhamBLL = new LoaiSanPhamBLL();
            this.Load += FrmChonSanPhamDoi_Load;
        }
        private void LoadData()
        {
            bindingSource.DataSource = sanPhamBLL.LayDanhSachSanPhamTheoMucGia(giaTriSanPham);
        }
        private void FrmChonSanPhamDoi_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = bindingSource;
            //dgvProducts.Columns["hinhAnh"].Visible = false;
            //dgvProducts.Columns["LoaiSanPham"].Visible = false;

            cbLocTheoLoai.DataSource = loaiSanPhamBLL.LayDanhSachLoaiSanPham();
            cbLocTheoLoai.ValueMember = "maLoaiSanPham";
            cbLocTheoLoai.DisplayMember = "tenLoaiSanPham";
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
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                txtTimKiem.Text = "Nhập mã hoặc tên sản phẩm để tìm kiếm";
                txtTimKiem.ForeColor = Color.Silver;
                txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Italic);
                LoadData();
            }
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập mã hoặc tên sản phẩm để tìm kiếm")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
                txtTimKiem.Font = new Font(txtTimKiem.Font, FontStyle.Regular);
            }
        }
        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem phím nhấn có phải là Enter không
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Tự động click vào nút tìm kiếm
                btnSearch.PerformClick();

                // Ngăn chặn âm thanh bíp khi nhấn Enter
                e.Handled = true;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var results = sanPhamBLL.TimKiemSanPham(txtTimKiem.Text.Trim(),giaTriSanPham);

            // Kiểm tra kết quả trả về có hợp lệ không
            if (results != null && results.Count > 0)
            {
                // Cập nhật DataGridView với kết quả tìm kiếm
                bindingSource.DataSource = results;
            }
            else
            {
                // Nếu không tìm thấy kết quả, thông báo cho người dùng
                MessageBox.Show("Không tìm thấy sản phẩm nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private void cbLocTheoLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocTheoLoai.SelectedItem != null)
            {
                bindingSource.DataSource = sanPhamBLL.LayDanhSachSanPhamTheoMaLoai(cbLocTheoLoai.SelectedValue.ToString(),giaTriSanPham);
            }
        }
    }
}
