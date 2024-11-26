using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhuyenMaiSanPhamBLL
    {
        KhuyenMaiSanPhamDAL kmspdal = new KhuyenMaiSanPhamDAL();
        public KhuyenMaiSanPhamBLL() { }

        public List<KhuyenMaiSanPham> LoadSanPhamTheoKhuyenMai(string maKhuyenMai)
        {
            return kmspdal.LoadSanPhamTheoKhuyenMai(maKhuyenMai);
        }

        public bool ThemHoacCapNhatSanPhamVaoCTKhuyenMai(string maKhuyenMai, string maSanPham, decimal phanTramGiam, int soLuongToiDa)
        {
            return kmspdal.ThemHoacCapNhatSanPhamVaoCTKhuyenMai(maKhuyenMai, maSanPham, phanTramGiam, soLuongToiDa);
        }
        public KhuyenMaiSanPham LayKhuyenMaiTheoSanPham(string maSanPham)
        {
            return kmspdal.LayKhuyenMaiTheoSanPham(maSanPham);
        }

        public KhuyenMaiSanPham LayTTSanPhamCuaKhuyenMai(string maKhuyenMai, string maSanPham)
        {
            return kmspdal.LayTTSanPhamCuaKhuyenMai(maKhuyenMai, maSanPham);
        }
    }
}
