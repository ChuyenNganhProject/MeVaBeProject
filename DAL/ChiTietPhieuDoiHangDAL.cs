using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietPhieuDoiHangDAL
    {
        private MeVaBeDBDataContext _db;
        public ChiTietPhieuDoiHangDAL()
        {
            this._db = new MeVaBeDBDataContext();
        }
        public List<ChiTietPhieuDoiHang> layDanhSachSanPhamDoi(string maPhieuDoi)
        {
            List<ChiTietPhieuDoiHang> danhSach = _db.ChiTietPhieuDoiHangs.Where(ctpd=>ctpd.maPhieuDoi == maPhieuDoi).ToList();
            foreach (ChiTietPhieuDoiHang item in danhSach)
            {
                item.tenSanPham = _db.SanPhams.Where(sp => sp.maSanPham == item.maSanPham).Select(sp => sp.tenSanPham).FirstOrDefault();
                item.tenSanPhamDoi = _db.SanPhams.Where(sp => sp.maSanPham == item.maSanPhamDoi).Select(sp => sp.tenSanPham).FirstOrDefault();
            }
            return danhSach;
        }
        public bool KiemTraPhieuDoiCuaHoaDon(string maHoaDon)
        {
            ChiTietPhieuDoiHang ctPhieuDoi = _db.ChiTietPhieuDoiHangs.Where(ct => ct.maHoaDon == maHoaDon).FirstOrDefault();
            if (ctPhieuDoi!=null)
            {
                return true;
            }
            return false;
        }
        public bool TaoChiTietPhieuDoi(ChiTietPhieuDoiHang ctPhieuDoi)
        {
            try
            {
                _db.ChiTietPhieuDoiHangs.InsertOnSubmit(ctPhieuDoi);
                _db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
