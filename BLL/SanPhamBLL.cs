using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spdal = new SanPhamDAL();
        LoaiSanPhamDAL lspdal = new LoaiSanPhamDAL();
        public SanPhamBLL() { }

        public List<SanPham> LayDanhSachSanPham()
        {
            return spdal.LayDanhSachSanPham();
        }

        public SanPham TimKiemSanPhamTheoMaSP(string ma)
        {
            return spdal.TimKiemSanPhamTheoMaSP(ma);
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            
            return spdal.LayDanhSachSanPhamTheoMaLoai(maLoai);
        }

        public List<SanPham> LoadTatCaSanPham()
        {
            return spdal.LayDanhSachSanPham();
        }

        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        {
            return spdal.LoadSpTheoTenHoacMaSp(tenHoacMaTimKiem);
        }    
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            return spdal.TimKiemSanPhamTheoTenSP(tenSP);
        }

        public bool CapNhatSanPham(SanPham sanPham)
        {
            return spdal.CapNhatSanPham(sanPham);
        }
    }
}
