using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmPhieuThanhLy : Form
    {
        private string maPhieuThanhLy;
        private NhanVienBLL nhanVienBLL;
        private PhieuThanhLyBLL phieuThanhLyBLL;
        private ChiTietPhieuThanhLyBLL ctPhieuThanhLyBLL;
        public delegate void SendDataHandler(bool loadData);
        public event SendDataHandler DongForm;
        public frmPhieuThanhLy(string maPhieuThanhLy)
        {
            InitializeComponent();
            this.maPhieuThanhLy= maPhieuThanhLy;
            this.nhanVienBLL = new NhanVienBLL();
            this.phieuThanhLyBLL = new PhieuThanhLyBLL();
            this.ctPhieuThanhLyBLL = new ChiTietPhieuThanhLyBLL();
        }

        private void frmPhieuThanhLy_Load(object sender, EventArgs e)
        {
            PhieuThanhLy phieuThanhLy = phieuThanhLyBLL.TimPhieuThanhLy(maPhieuThanhLy);
            NhanVien nhanVien = nhanVienBLL.LayTTNhanVienTuMa(phieuThanhLy.maNhanVien);
            List<ChiTietPhieuThanhLy> danhSach = ctPhieuThanhLyBLL.LayChiTietPhieuThanhLy(maPhieuThanhLy);

            ReportParameter[] reportParameters = new ReportParameter[] {
                new ReportParameter("hoTen", nhanVien.tenNhanVien),
                new ReportParameter("loaiNhanVien", nhanVien.tenLoaiNhanVien),
                new ReportParameter("lyDo", phieuThanhLy.lyDo),                
                new ReportParameter("ngayLap", phieuThanhLy.ngayThanhLy.Value.ToString("dd-MM-yyyy"))
            };
            
            ReportDataSource rdsChiTiet = new ReportDataSource("ChiTietPhieuThanhLy", danhSach);

            phieuThanhLyReportView.LocalReport.DataSources.Clear();
            phieuThanhLyReportView.LocalReport.DataSources.Add(rdsChiTiet);
            phieuThanhLyReportView.LocalReport.SetParameters(reportParameters);           
            this.phieuThanhLyReportView.RefreshReport();
        }

        private void frmPhieuThanhLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            DongForm?.Invoke(true);
        }
    }
}
