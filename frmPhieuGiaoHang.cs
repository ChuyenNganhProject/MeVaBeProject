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
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmPhieuGiaoHang : Form
    {
        private string MaHD;
        private string MaPG;
        private string TenKH;
        private string DiaChiNhanHang;
        private string Sdt;
        private string TenNhanVien;
        private string PhiVanChuyenText;
        private string TongGiaTriText;
        private List<ChiTietHoaDonSanPham> _chiTietPGList;
        public frmPhieuGiaoHang(List<ChiTietHoaDonSanPham> chiTietPGList, string maHD, string maPG, 
                                string tenKH, string diaChiNhanHang, string sdt, string tenNhanVien, string tongGiaTriText, string phiVanChuyenText)
        {
            InitializeComponent();
            this.Load += FrmPhieuGiaoHang_Load;

            this._chiTietPGList = chiTietPGList;
            this.MaHD = maHD;
            this.MaPG = maPG;
            this.TenKH = tenKH;
            this.DiaChiNhanHang = diaChiNhanHang;
            this.Sdt = sdt;
            this.TenNhanVien = tenNhanVien;
            this.TongGiaTriText = tongGiaTriText;
            this.PhiVanChuyenText = phiVanChuyenText;
        }

        private void FrmPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            rptPhieuGiaoHang.LocalReport.ReportPath = @"./PhieuGiaoHang.rdlc";

            string ngayLapText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                new ReportParameter("MaHD", MaHD),
                new ReportParameter("MaPG", MaPG),
                new ReportParameter("TenKhachHang", TenKH),
                new ReportParameter("TenNhanVien", TenNhanVien),
                new ReportParameter("DiaChi", DiaChiNhanHang),
                new ReportParameter("SDT", Sdt),
                new ReportParameter("NgayLap", ngayLapText),
                new ReportParameter("TongGiaTri", TongGiaTriText),
                new ReportParameter("PhiVanChuyen", PhiVanChuyenText)
            };

            var chiTietPGListWithSTT = _chiTietPGList.Select((item, index) => new ChiTietPhieuGiaoHangWithSTT
            {
                STT = index + 1,
                MaSanPham = item.maSanPham,
                TenSanPham = item.tenSanPham,
                SoLuong = Convert.ToInt32(item.soLuong?.ToString()),
                DonGia = item.donGia?.ToString("N0").Replace(",", ".") + "đ",
                ThanhTien = item.tongTien?.ToString("N0").Replace(",", ".") + "đ"
            }).ToList();

            ReportDataSource reportDataSource = new ReportDataSource("ChiTietPhieuGHDataSet", chiTietPGListWithSTT);

            rptPhieuGiaoHang.LocalReport.DataSources.Clear();
            rptPhieuGiaoHang.LocalReport.DataSources.Add(reportDataSource);
            rptPhieuGiaoHang.LocalReport.SetParameters(reportParameters);

            this.rptPhieuGiaoHang.RefreshReport();
        }
    }
}
