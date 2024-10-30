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
    public partial class frmNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += FrmNhanVien_Load;
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        public void LoadNhanVien()
        {
            try
            {
                List<NhanVien> nhanViens = nvbll.LoadNhanVien();
                dgvNhanVien.DataSource = nhanViens;
                if (dgvNhanVien.Columns["LoaiNhanVien"] != null)
                {
                    dgvNhanVien.Columns["LoaiNhanVien"].Visible = false;
                }
                if (dgvNhanVien.Columns["maLoaiNhanVien"] != null)
                {
                    dgvNhanVien.Columns["maLoaiNhanVien"].Visible = false;
                }
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
