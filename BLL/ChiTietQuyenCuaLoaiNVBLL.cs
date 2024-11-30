using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ChiTietQuyenCuaLoaiNVBLL
    {
        private ChiTietQuyenCuaLoaiNVDAL ctQuyen;
        public ChiTietQuyenCuaLoaiNVBLL()
        {
            this.ctQuyen = new ChiTietQuyenCuaLoaiNVDAL();
        }
        public List<ChiTietQuyenCuaLoaiNhanVien> LayDanhSachQuyenCuaLoaiNhanVien(string maLoaiNV)
        {
            return ctQuyen.LayDanhSachQuyenCuaLoaiNhanVien(maLoaiNV);
        }
        public ChiTietQuyenCuaLoaiNhanVien TimQuyenCuaNhanVien(string maLoaiNV,string maQuyen)
        {
            return ctQuyen.TimQuyenCuaNhanVien(maLoaiNV, maQuyen);
        }
        public bool TaoChiTietQuyenCuaLoaiNhanVien(ChiTietQuyenCuaLoaiNhanVien pQuyen)
        {
            return ctQuyen.TaoChiTietQuyenCuaLoaiNhanVien(pQuyen);
        }
        public bool XoaChiTietQuyenCuaLoaiNhanVien(ChiTietQuyenCuaLoaiNhanVien pQuyen)
        {
            return ctQuyen.XoaChiTietQuyenCuaLoaiNhanVien(pQuyen);
        }
    }
}
