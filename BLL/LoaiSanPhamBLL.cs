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
        private LoaiSanPhamDAL loaiSanPhamDAL;
        public LoaiSanPhamBLL()
        {
            this.loaiSanPhamDAL = new LoaiSanPhamDAL();
        }
        public List<LoaiSanPham> LayDanhSachSanPham()
        {
            return loaiSanPhamDAL.LayDanhSachLoaiSanPham();
        }
    }
}
