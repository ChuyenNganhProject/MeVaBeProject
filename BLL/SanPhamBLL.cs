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

        public List<SanPham> LoadSanPhamByLoaiSp(string ma)
        {
            LoaiSanPham loaisp = lspdal.LayTTLoaiSpTuMaLoaiSp(ma);
            if(loaisp != null)
            {
                return spdal.LoadSanPhamByLoaiSp(loaisp);
        }
            else
        public List<SanPham> LayDanhSachSanPham()
        {
                return new List<SanPham>();
            }
            return sanPhamDAL.LayDanhSachSanPham();
        }

        public SanPham LaySanPhamTheoMa(string ma)
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            return spdal.LaySanPhamTheoMa(ma);
            return sanPhamDAL.LayDanhSachSanPhamTheoMaLoai(maLoai);
        }

        public List<SanPham> LoadTatCaSanPham()
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            return spdal.LoadTatCaSanPham();
            return sanPhamDAL.TimKiemSanPhamTheoMaSP(maSP);
        }

        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            return spdal.LoadSpTheoTenHoacMaSp(tenHoacMaTimKiem);    
            return sanPhamDAL.TimKiemSanPhamTheoTenSP(tenSP);
        }
    }
}
