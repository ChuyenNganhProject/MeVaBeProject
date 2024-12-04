using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietHoaDonSanPhamBLL
    {
        ChiTietHoaDonSanPhamDAL ctdal = new ChiTietHoaDonSanPhamDAL();
        public ChiTietHoaDonSanPhamBLL() { }

        public bool ThemChiTietHoaDonSanPham(ChiTietHoaDonSanPham cthd)
        {
            return ctdal.ThemChiTietHoaDonSanPham(cthd);
        }

        public List<ChiTietHoaDonSanPham> LoadCTHDSanPham(string mahd)
        {
            return ctdal.LoadCTHDSanPham(mahd);
        }
        public ChiTietHoaDonSanPham TimChiTietHoaDonSanPham(string maHoaDon, string maSanPham)
        {
            return ctdal.TimChiTietHoaDonSanPham(maHoaDon, maSanPham);

        public ChiTietHoaDonSanPham LayTTSanPhamTrongHoaDon(string masp, string mahd)
        {
            return ctdal.LayTTSanPhamTrongHoaDon(masp, mahd);
        }
    }
}
