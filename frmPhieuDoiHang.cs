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
using Microsoft.Reporting.WinForms;
namespace MeVaBeProject
{
    public partial class frmPhieuDoiHang : Form
    {
        private string maPhieuDoi;
        private NhanVien nhanVien;
        private PhieuDoiHangBLL phieuDoiHangBLL;
        private NhanVienBLL nhanVienBLL;        
        private ChiTietPhieuDoiHangBLL ctPhieuDoiBLL;
        public delegate void SendDataHandler(bool loadData);
        public event SendDataHandler DongForm;
        public frmPhieuDoiHang(string maPhieuDoi)
        {
            InitializeComponent();
            this.maPhieuDoi = maPhieuDoi;
            this.nhanVienBLL = new NhanVienBLL();            
            this.phieuDoiHangBLL = new PhieuDoiHangBLL();
            this.ctPhieuDoiBLL = new ChiTietPhieuDoiHangBLL();
        }
        private void frmPhieuDoiHang_Load(object sender, EventArgs e)
        {
            PhieuDoiHang phieuDoi = phieuDoiHangBLL.TimPhieuDoi(maPhieuDoi);
            nhanVien = nhanVienBLL.LayTTNhanVienTuMa(phieuDoi.maNhanVien);
            List<ChiTietPhieuDoiHang> danhSach = ctPhieuDoiBLL.layDanhSachSanPhamDoi(maPhieuDoi);
            ReportParameter[] reportParameters = new ReportParameter[] {
                new ReportParameter("tenNhanVien", nhanVien.tenNhanVien),
                new ReportParameter("tenKhachHang", phieuDoi.tenKhachHang),
                new ReportParameter("ngayDoi", phieuDoi.ngayDoi.Value.ToString("dd-MM-yyyy")),
                new ReportParameter("hinhThucDoi", phieuDoi.hinhThucDoi),
                new ReportParameter("lyDo", phieuDoi.lyDoDoi)
            };

            ReportDataSource rdsChiTiet = new ReportDataSource("ChiTietPhieuDoi", danhSach);

            phieuDoiHangReportViewer.LocalReport.DataSources.Clear();
            phieuDoiHangReportViewer.LocalReport.DataSources.Add(rdsChiTiet);
            phieuDoiHangReportViewer.LocalReport.SetParameters(reportParameters);
            this.phieuDoiHangReportViewer.RefreshReport();
        }
        private void frmPhieuDoiHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            DongForm?.Invoke(true);
        }
    }
}
