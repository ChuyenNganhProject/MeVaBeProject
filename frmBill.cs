using BLL;
using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeVaBeProject
{
    public partial class frmBill : Form
    {
        private HoaDon _hoaDon;
        private string tienBiGiamText;
        private string tienTruocKhiGiamText;
        private string hangThanhVienText;
        private string phanTramGiamText;
        private int soLuong;
        private List<ChiTietHoaDonSanPham> _chiTietHoaDons;
        KhachHangBLL khbll = new KhachHangBLL();
        NhanVienBLL nvbll = new NhanVienBLL();
        public frmBill(HoaDon hoaDon, List<ChiTietHoaDonSanPham> chiTietHoaDons, 
            string tienBiGiamText, string tienTruocKhiGiamText, string hangThanhVienText, string phanTramGiamText) 
        { 
            InitializeComponent(); 
            _hoaDon = hoaDon; 
            _chiTietHoaDons = chiTietHoaDons; 
            this.tienBiGiamText = tienBiGiamText;
            this.tienTruocKhiGiamText = tienTruocKhiGiamText;
            this.hangThanhVienText = hangThanhVienText;
            this.phanTramGiamText = phanTramGiamText;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            hoaDonReport.LocalReport.ReportPath = @"./HoaDonMuaHang.rdlc";
            var khachHang = khbll.LayKHTheoMa(_hoaDon.maKhachHang);
            var nhanVien = nvbll.LayTTNhanVienTuMa(_hoaDon.maNhanVien);

            string tenNhanVien = nhanVien != null ? nhanVien.tenNhanVien : " ";
            string tenKhachHang = khachHang != null ? khachHang.tenKhachHang : " ";
            string ngayLap = _hoaDon.ngayLap.HasValue ? _hoaDon.ngayLap.Value.ToString("dd/MM/yyyy HH:mm:ss") : "N/A";
            decimal tongTienThanhToan = _hoaDon.tongTienSauGiam.Value;
            string tongTienThanhToanText = tongTienThanhToan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            string hangThanhVienValue = !string.IsNullOrEmpty(hangThanhVienText) ? hangThanhVienText : " ";
            string tienBiGiamValue = !string.IsNullOrEmpty(tienBiGiamText) ? tienBiGiamText: " ";
            string phanTramGiamValue = !string.IsNullOrEmpty(phanTramGiamText) ? phanTramGiamText : " ";
            soLuong = _chiTietHoaDons.Sum(ct => ct.soLuong).Value;
            string tongSoLuongText = "Số lượng: " + soLuong;
            string diemTichLuyDuocCongText;
            decimal tongDiemTichLuy = khachHang != null ? khachHang.diemTichLuy.Value : 0;
            string tongDiemTichLuyText;
            if (tenKhachHang == " ")
            {
                diemTichLuyDuocCongText = " ";
                tongDiemTichLuyText = " ";
            }
            else
            {
                diemTichLuyDuocCongText = "Điểm tích lũy được cộng: " + tongTienThanhToan.ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + "";
                tongDiemTichLuyText = "Tổng điểm tích lũy: " + tongDiemTichLuy.ToString("N0", CultureInfo.GetCultureInfo("vi-VN"));
            }

            ReportParameter[] reportParameters = new ReportParameter[] {
                new ReportParameter("TenKhachHang", tenKhachHang),
                new ReportParameter("TenNhanVien", tenNhanVien),
                new ReportParameter("NgayLap", ngayLap),
                new ReportParameter("TienThanhToan", tongTienThanhToanText),
                new ReportParameter("TienBiGiam", tienBiGiamValue),
                new ReportParameter("TienTruocKhiGiam", tienTruocKhiGiamText),
                new ReportParameter("HangThanhVien", hangThanhVienValue),
                new ReportParameter("PhanTramGiam", phanTramGiamValue),
                new ReportParameter("TongSoLuong", tongSoLuongText),
                new ReportParameter("DiemTichLuyDuocCong", diemTichLuyDuocCongText),
                new ReportParameter("TongDiemTichLuy", tongDiemTichLuyText)
            };

            ReportDataSource rdsChiTiet = new ReportDataSource("ChiTietHoaDonSanPhamDataSet", _chiTietHoaDons);

            hoaDonReport.LocalReport.DataSources.Clear();
            hoaDonReport.LocalReport.DataSources.Add(rdsChiTiet);
            hoaDonReport.LocalReport.SetParameters(reportParameters);

            this.hoaDonReport.RefreshReport();
        }
    }
}
