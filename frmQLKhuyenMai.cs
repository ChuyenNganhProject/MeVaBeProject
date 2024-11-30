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
    public partial class frmQLKhuyenMai : Form
    {
        private NhanVien nhanVien;
        private frmTrangChu parentfrm;
        KhuyenMaiBLL kmbll = new KhuyenMaiBLL();
        private string MaKM;
        public frmQLKhuyenMai(frmTrangChu parentfrm, NhanVien nhanVien)
        {
            InitializeComponent();
            this.parentfrm = parentfrm;
            this.Load += FrmQLKhuyenMai_Load;
            this.btnBack.Click += BtnBack_Click;

            this.btnTaoKhuyenMai.Click += BtnTaoKhuyenMai_Click;
            this.btnXemKhuyenMai.Click += BtnXemKhuyenMai_Click;
            this.btnReset.Click += BtnReset_Click;
            this.dgvKhuyenMai.SelectionChanged += DgvKhuyenMai_SelectionChanged;
            this.nhanVien = nhanVien;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            kmbll.UpdateTrangThaiKhuyenMai();
            LoadDanhSachKhuyenMai();
        }

        private void DgvKhuyenMai_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvKhuyenMai.SelectedRows.Count > 0)
            {
                string maKm = dgvKhuyenMai.SelectedRows[0].Cells["maKhuyenMai"].Value.ToString();
                this.MaKM = maKm;
            }
        }

        private void BtnXemKhuyenMai_Click(object sender, EventArgs e)
        {
            frmTaoKhuyenMai frm = new frmTaoKhuyenMai(parentfrm,nhanVien, MaKM);
            parentfrm.OpenChildForm(frm);
        }

        private void FrmQLKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhuyenMai();
        }

        private void LoadDanhSachKhuyenMai()
        {
            List<KhuyenMai> khuyenMais = kmbll.LoadDanhSachKhuyenMai();
            dgvKhuyenMai.DataSource = khuyenMais;
            dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SettingDgv();
        }

        private void SettingDgv()
        {
            if (dgvKhuyenMai.Columns["ngayBatDau"] != null)
            {
                dgvKhuyenMai.Columns["ngayBatDau"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                dgvKhuyenMai.Columns["ngayBatDau"].HeaderText = "Thời gian bắt đầu";
            }
            if (dgvKhuyenMai.Columns["ngayKetThuc"] != null)
            {
                dgvKhuyenMai.Columns["ngayKetThuc"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
                dgvKhuyenMai.Columns["ngayKetThuc"].HeaderText = "Thời gian kết thúc";
            }

            if (dgvKhuyenMai.Columns["maKhuyenMai"] != null)
            {
                dgvKhuyenMai.Columns["maKhuyenMai"].HeaderText = "Mã khuyến mãi";
                dgvKhuyenMai.Columns["maKhuyenMai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dgvKhuyenMai.Columns["tenKhuyenMai"] != null)
            {
                dgvKhuyenMai.Columns["tenKhuyenMai"].HeaderText = "Tên khuyến mãi";
                dgvKhuyenMai.Columns["maKhuyenMai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            if (dgvKhuyenMai.Columns["moTa"] != null)
            {
                dgvKhuyenMai.Columns["moTa"].Visible = false;
            }
            if (dgvKhuyenMai.Columns["trangThai"] != null)
            {
                dgvKhuyenMai.Columns["trangThai"].HeaderText = "Trạng thái";
                dgvKhuyenMai.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void BtnTaoKhuyenMai_Click(object sender, EventArgs e)
        {
            frmTaoKhuyenMai frm = new frmTaoKhuyenMai(parentfrm,nhanVien, "");
            parentfrm.OpenChildForm(frm);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham(parentfrm,nhanVien);
            parentfrm.OpenChildForm(frm);
        }
    }
}
