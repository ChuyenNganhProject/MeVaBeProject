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
    public partial class frmDanhSachPhieuDat : Form
    {
        private PhieuDatBLL phieuDatBLL;
        private PhieuNhapBLL phieuNhapBLL;
        private ChiTietPhieuDatBLL chiTietPhieuDatBLL;       
        public delegate void SendDataHandler(string data);
        public event SendDataHandler DataSent;
        public frmDanhSachPhieuDat()
        {
            InitializeComponent();
            this.phieuDatBLL = new PhieuDatBLL();
            this.phieuNhapBLL = new PhieuNhapBLL();
            this.chiTietPhieuDatBLL = new ChiTietPhieuDatBLL();
            this.Load += FrmDanhSachPhieuDat_Load;
        }
        private void FrmDanhSachPhieuDat_Load(object sender, EventArgs e)
        {
            List<PhieuDat> danhSachPhieuDat = phieuDatBLL.LayDanhSachPhieuDatDaDuyet();
            for (int i = danhSachPhieuDat.Count-1; i >=0; i--)
            {
                PhieuDat phieuDat = danhSachPhieuDat[i];
                List<PhieuNhap> danhSachPhieuNhap = phieuNhapBLL.TimKiemPhieuNhapTheoMaPhieuDat(phieuDat.maPhieuDat);
                if (danhSachPhieuNhap.Count==3 || (phieuDat.ngayLap.Value.Hour+5 > DateTime.Now.Hour && phieuDat.ngayLap.Value.Day == DateTime.Now.Day))
                {
                    danhSachPhieuDat.Remove(phieuDat);
                }
                else
                {
                    List<ChiTietPhieuDat> chiTietPhieuDats = chiTietPhieuDatBLL.LayChiTietPhieuDat(phieuDat.maPhieuDat);
                    int dem = 0;
                    foreach (ChiTietPhieuDat chiTietPhieuDat in chiTietPhieuDats)
                    {
                        if (chiTietPhieuDat.soLuongDat == chiTietPhieuDat.soLuongNhan)
                        {
                            dem++;
                        }
                    }
                    if (dem == phieuDat.soLuong)
                    {
                        danhSachPhieuDat.Remove(phieuDat);
                    }
                }                
            }
            dtgvDanhSachPhieuDat.DataSource = danhSachPhieuDat;
            dtgvDanhSachPhieuDat.Columns["trangThai"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["trangThaiXacNhan"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["ghiChu"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["ngayCapNhat"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["maNhanVien"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["NhanVien"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["NhaCungCap"].Visible = false;
            dtgvDanhSachPhieuDat.Columns["maNhaCungCap"].Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtgvDanhSachPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                string maPhieuDat = dtgvDanhSachPhieuDat.Rows[e.RowIndex].Cells["maPhieuDat"].Value.ToString();
                DataSent?.Invoke(maPhieuDat);
                this.Close();
            }
        }
    }
}
