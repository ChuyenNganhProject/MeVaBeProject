using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            {
                return new List<SanPham>();
            }
        }

        public SanPham LaySanPhamTheoMa(string ma)
        {
            return spdal.LaySanPhamTheoMa(ma);
        }

        public List<SanPham> LoadTatCaSanPham()
        {
            return spdal.LoadTatCaSanPham();
        }

        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        {
            return spdal.LoadSpTheoTenHoacMaSp(tenHoacMaTimKiem);    
        }
    }
}
