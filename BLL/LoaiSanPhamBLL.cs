using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL lspdal = new LoaiSanPhamDAL();
        public LoaiSanPhamBLL() { }

        public List<LoaiSanPham> LoadLoaiSanPham()
        {
            return lspdal.LoadLoaiSanPham();
        }

        public LoaiSanPham LayTTLoaiSpTuMaLoaiSp(string ma)
        {
            return lspdal.LayTTLoaiSpTuMaLoaiSp(ma);
        }
    }
}
