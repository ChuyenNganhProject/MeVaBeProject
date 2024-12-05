using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHoaDonSanPhamDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public ChiTietHoaDonSanPhamDAL() { }

        public bool ThemChiTietHoaDonSanPham(ChiTietHoaDonSanPham cthd)
        {
            try
            {
                var sanPhamTonTai = db.SanPhams.Any(sp => sp.maSanPham.Trim() == cthd.maSanPham.Trim());
                if (!sanPhamTonTai)
                {
                    return false;
                }
                db.ChiTietHoaDonSanPhams.InsertOnSubmit(cthd);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ChiTietHoaDonSanPham> LoadCTHDSanPham(string mahd)
        {
            if(!string.IsNullOrEmpty(mahd))
            {
                var list = db.ChiTietHoaDonSanPhams.Where(ct => ct.maHoaDon == mahd).Select(ct => ct).ToList<ChiTietHoaDonSanPham>();
                foreach (var item in list)
                {
                    item.tenSanPham = db.SanPhams.Where(sp => sp.maSanPham == item.maSanPham).Select(sp => sp.tenSanPham).First();
                }
                return list;
            }
            else
            {
                return new List<ChiTietHoaDonSanPham> ();
            }
        }

        public ChiTietHoaDonSanPham LayTTSanPhamTrongHoaDon(string masp, string mahd)
        {
            return db.ChiTietHoaDonSanPhams.Where(cthd => cthd.maHoaDon == mahd && cthd.maSanPham == masp).Select(sp => sp).FirstOrDefault();
        }
        public ChiTietHoaDonSanPham TimChiTietHoaDonSanPham(string maHoaDon,string maSanPham)
        {
            return db.ChiTietHoaDonSanPhams.Where(ct => ct.maSanPham == maSanPham && ct.maHoaDon == maHoaDon).FirstOrDefault();
        }
    }
}
