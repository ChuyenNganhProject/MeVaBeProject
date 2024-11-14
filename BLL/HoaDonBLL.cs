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

        public decimal tongTienTatCaHoaDonCuaKH(KhachHang khachhang)
        {
            return hddal.tongTienTatCaHoaDonCuaKH(khachhang);
        }

        public List<HoaDon> TimKiemHoaDon(string tieuChi, string giaTriTimKiem)
        {
            return hddal.TimKiemHoaDon(tieuChi, giaTriTimKiem);
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

        // Năm này
        public decimal TinhDoanhThuNamNay()
        {
            return hddal.TinhDoanhThuNamNay();
        }
        public int TongHoaDonNamNay()
        {
            return hddal.TongHoaDonNamNay();
        }

        // Tháng này
        public decimal TinhDoanhThuThangNay()
        {
            return hddal.TinhDoanhThuThangNay();
        }
        public int TongHoaDonThangNay()
        {
            return hddal.TongHoaDonThangNay();
        }

        // 30 ngày qua
        public decimal TinhDoanhThu30NgayQua()
        {
            return hddal.TinhDoanhThu30NgayQua();
        }
        public int TongHoaDon30NgayQua()
        {
            return hddal.TongHoaDon30NgayQua();
        }

        // 7 ngày qua
        public decimal TinhDoanhThu7NgayQua()
        {
            return hddal.TinhDoanhThu7NgayQua();
        }
        public int TongHoaDon7NgayQua()
        {
            return hddal.TongHoaDon7NgayQua();
        }

        // Hôm nay
        public decimal TinhDoanhThuHomNay()
        {
            return hddal.TinhDoanhThuHomNay();
        }
        public int TongHoaDonHomNay()
        {
            return hddal.TongHoaDonHomNay();
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
    }
}
