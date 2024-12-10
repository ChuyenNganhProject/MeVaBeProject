using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace MeVaBeProject
{
    public partial class frmQLPhanQuyen : Form
    {
        private string maLoaiNV;
        private QuyenHeThongBLL quyenHeThongBLL;
        private ChiTietQuyenCuaLoaiNVBLL chiTietQuyenBLL;
        private BindingSource bindingSource;
        public frmQLPhanQuyen(string maLoaiNV)
        {
            InitializeComponent();
            this.quyenHeThongBLL = new QuyenHeThongBLL();
            this.chiTietQuyenBLL = new ChiTietQuyenCuaLoaiNVBLL();
            this.bindingSource = new BindingSource();
            this.maLoaiNV = maLoaiNV;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadQuyenCuaLoaiNhanVien()
        {
            bindingSource.DataSource = chiTietQuyenBLL.LayDanhSachQuyenCuaLoaiNhanVien(maLoaiNV);            
        }
        private void frmQLPhanQuyen_Load(object sender, EventArgs e)
        {
            dtgvQuyenHeThong.DataSource = quyenHeThongBLL.DanhSachQuyen();
            LoadQuyenCuaLoaiNhanVien();
            dtgvChiTietQuyen.DataSource = bindingSource;
            dtgvChiTietQuyen.Columns["QuyenHeThong"].Visible = false;
            dtgvChiTietQuyen.Columns["LoaiNhanVien"].Visible = false;
            dtgvChiTietQuyen.Columns["maLoaiNhanVien"].Visible = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtgvQuyenHeThong.SelectedRows.Count>0)
            {
                bool result = false;
                foreach  (DataGridViewRow row in dtgvQuyenHeThong.SelectedRows)
                {
                    ChiTietQuyenCuaLoaiNhanVien ctQuyen = new ChiTietQuyenCuaLoaiNhanVien()
                    {
                        maQuyen = row.Cells["maQuyen"].Value.ToString(),
                        maLoaiNhanVien = maLoaiNV,
                        ngayCapQuyen = DateTime.Now,
                    };
                    if(chiTietQuyenBLL.TimQuyenCuaNhanVien(maLoaiNV, ctQuyen.maQuyen)==null)
                    {
                        result = chiTietQuyenBLL.TaoChiTietQuyenCuaLoaiNhanVien(ctQuyen);
                        if (!result)
                        {
                            break;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show(this, $"Loại nhân viên này đã có {row.Cells["tenQuyen"].Value.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (result)
                {
                    MessageBox.Show(this, "Phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuyenCuaLoaiNhanVien();
                }
                else
                {
                    MessageBox.Show(this, "Phân quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvChiTietQuyen.SelectedRows.Count > 0)
            {
                bool result = false;
                foreach (DataGridViewRow row in dtgvChiTietQuyen.SelectedRows)
                {
                    ChiTietQuyenCuaLoaiNhanVien ctQuyen = new ChiTietQuyenCuaLoaiNhanVien()
                    {
                        maQuyen = row.Cells["maQuyenCuaLoaiNhanVien"].Value.ToString(),
                        maLoaiNhanVien = maLoaiNV
                    };
                    result = chiTietQuyenBLL.XoaChiTietQuyenCuaLoaiNhanVien(ctQuyen);
                    if (!result)
                    {
                        break;
                    }
                }
                if (result)
                {
                    MessageBox.Show(this, "Xóa quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuyenCuaLoaiNhanVien();
                }
                else
                {
                    MessageBox.Show(this, "Xóa quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
