using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuGiaoBLL
    {
        ChiTietPhieuGiaoDAL ctpgdal = new ChiTietPhieuGiaoDAL();
        public ChiTietPhieuGiaoBLL() { }
        public bool ThemHoacSuaChiTietPhieuGiao(ChiTietPhieuGiaoHang ctpg)
        {
            return ctpgdal.ThemHoacSuaChiTietPhieuGiao(ctpg);
        }

        public List<ChiTietPhieuGiaoHang> LayDanhSachChiTietPhieuGiao(string maPhieuGiao)
        {
            return ctpgdal.LayDanhSachChiTietPhieuGiao(maPhieuGiao);
        }

        public string LayMaPGTuHoaDon(string mahd)
        {
            return ctpgdal.LayMaPGTuHoaDon(mahd);
        }
        public List<ChiTietPhieuGiaoHang> LoadCTPGChoForm(string maPhieuGiao)
        {
            return ctpgdal.LoadCTPGChoForm(maPhieuGiao);
        }
    }
}
