using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hddal = new HoaDonDAL();
        public HoaDonBLL() { }

        public List<HoaDon> LoadDanhSachHoaDon()
        {
            return hddal.LoadDanhSachHoaDon();
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return hddal.ThemHoaDon(hd);
        }

        public string TaoMaHoaDonTuDong()
        {
            return hddal.TaoMaHoaDonTuDong();
        }

        public List<HoaDon> TimKiemVaLocHoaDon(string tieuChi, string giaTriTimKiem, DateTime ngayBatDau, DateTime ngayKetThuc, string loaikh)
        {
            return hddal.TimKiemVaLocHoaDon(tieuChi, giaTriTimKiem, ngayBatDau, ngayKetThuc, loaikh);
        }

        public HoaDon LoadHoaDonTheoMa(string mahd)
        {
            return hddal.LoadHoaDonTheoMa(mahd);
        }

        public decimal TinhTongDoanhThu()
        {
            return hddal.TinhTongDoanhThu();
        }

        public int TongSoHoaDon()
        {
            return hddal.TongSoHoaDon();
        }

        // Custom
        public List<HoaDon> LoadDanhSachHoaDonTheoNgayLoc(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return hddal.LoadDanhSachHoaDonTheoNgayLoc(ngayBatDau, ngayKetThuc);
        }

        public decimal TinhDoanhThuTheoKhoangThoiGian(DateTime batDau, DateTime ketThuc)
        {
            return hddal.TinhDoanhThuTheoKhoangThoiGian(batDau, ketThuc);
        }

        public int TongSoHoaDonTheoKhoangThoiGian(DateTime batDau, DateTime ketThuc)
        {
            return hddal.TongSoHoaDonTheoKhoangThoiGian(batDau, ketThuc);
        }

        public Dictionary<DateTime?, decimal> ThongKeTongDoanhThuCuaTungNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return hddal.ThongKeTongDoanhThuCuaTungNgay(ngayBatDau, ngayKetThuc);
        }

        public Dictionary<int, decimal> ThongKeTongDoanhThuTheoGioTrongNgay(DateTime ngay)
        {
            return hddal.ThongKeTongDoanhThuTheoGioTrongNgay(ngay);
        }

        public List<ThongKeDoanhThuTheoThang> ThongKeTongDoanhThuTheoThangTrongNam(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return hddal.ThongKeTongDoanhThuTheoThangTrongNam(ngayBatDau, ngayKetThuc);
        }
    }
}
