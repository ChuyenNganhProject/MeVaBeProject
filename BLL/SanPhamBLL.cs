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
        private SanPhamDAL sanPhamDAL;
        public SanPhamBLL()
        {
            sanPhamDAL = new SanPhamDAL();
        }
        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAL.LayDanhSachSanPham();
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            return sanPhamDAL.LayDanhSachSanPhamTheoMaLoai(maLoai);
        }
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            return sanPhamDAL.TimKiemSanPhamTheoMaSP(maSP);
        }
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            return sanPhamDAL.TimKiemSanPhamTheoTenSP(tenSP);
        }
    }
}
