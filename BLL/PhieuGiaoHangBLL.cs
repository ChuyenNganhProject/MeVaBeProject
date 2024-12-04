using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuGiaoHangBLL
    {
        PhieuGiaoHangDAL pgdal = new PhieuGiaoHangDAL();
        public PhieuGiaoHangBLL() { }

        public bool ThemHoacSuaPhieuGiao(PhieuGiaoHang pg)
        {
            return pgdal.ThemHoacSuaPhieuGiao(pg);
        }
        public string TaoMaPhieuGiaoHangTuDong()
        {
            return pgdal.TaoMaPhieuGiaoHangTuDong();
        }

        public PhieuGiaoHang LayTTPhieuGiaoTuMaPG(string mapg)
        {
            return pgdal.LayTTPhieuGiaoTuMaPG(mapg);
        }
        public bool XoaPhieuGiao(PhieuGiaoHang phieuGiaoHang)
        {
            return pgdal.XoaPhieuGiao(phieuGiaoHang);
        }

        public List<PhieuGiaoHang> TimKiemVaLocPhieuGiao(string tieuChi, string giaTriTimKiem, DateTime ngayBatDau, DateTime ngayKetThuc, string tinhTrang)
        {
            return pgdal.TimKiemVaLocPhieuGiao(tieuChi, giaTriTimKiem, ngayBatDau, ngayKetThuc, tinhTrang);
        }
    }
}
