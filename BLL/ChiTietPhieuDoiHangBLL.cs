using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ChiTietPhieuDoiHangBLL
    {
        private ChiTietPhieuDoiHangDAL ctPhieuDoiDAL;
        public ChiTietPhieuDoiHangBLL()
        {
            this.ctPhieuDoiDAL = new ChiTietPhieuDoiHangDAL();
        }
        public List<ChiTietPhieuDoiHang> layDanhSachSanPhamDoi(string maPhieuDoi)
        {
            return ctPhieuDoiDAL.layDanhSachSanPhamDoi(maPhieuDoi);
        }
        public bool KiemTraPhieuDoiCuaHoaDon(string maHoaDon)
        {
            return ctPhieuDoiDAL.KiemTraPhieuDoiCuaHoaDon(maHoaDon);
        }
        public bool TaoChiTietPhieuDoi(ChiTietPhieuDoiHang ctPhieuDoi)
        {
            return ctPhieuDoiDAL.TaoChiTietPhieuDoi(ctPhieuDoi);
        }
    }
}
