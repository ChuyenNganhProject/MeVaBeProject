using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietPhieuDatDAL
    {
        private MeVaBeDBDataContext MeVaBeDBDataContext;
        public ChiTietPhieuDatDAL()
        {
            this.MeVaBeDBDataContext = new MeVaBeDBDataContext();
        }
        public List<ChiTietPhieuDat> LayChiTietPhieuDat(string maPhieuDat)
        {
            List<ChiTietPhieuDat> chiTietPhieuDats = MeVaBeDBDataContext.ChiTietPhieuDats.Where(ctpd => ctpd.maPhieuDat == maPhieuDat).Select(ctpd => ctpd).ToList<ChiTietPhieuDat>();
            foreach(ChiTietPhieuDat chiTietPhieuDat in chiTietPhieuDats)
            {
                chiTietPhieuDat.tenSanPham = MeVaBeDBDataContext.SanPhams.Where(sp => sp.maSanPham == chiTietPhieuDat.maSanPham).Select(sp => sp.tenSanPham).First();
            }
            return chiTietPhieuDats;
        }
        public bool TaoChiTietPhieuDat(ChiTietPhieuDat pChiTietPhieuDat)
        {
            try
            {
                MeVaBeDBDataContext.ChiTietPhieuDats.InsertOnSubmit(pChiTietPhieuDat);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaChiTietPhieuDat(ChiTietPhieuDat pChiTietPhieuDat)
        {
            try
            {
                ChiTietPhieuDat chiTietPhieuDatEdited = MeVaBeDBDataContext.ChiTietPhieuDats.Where(ctpd => ctpd.maPhieuDat == pChiTietPhieuDat.maPhieuDat && ctpd.maSanPham == pChiTietPhieuDat.maSanPham).Select(ctpd => ctpd).FirstOrDefault();
                chiTietPhieuDatEdited.soLuongDat = pChiTietPhieuDat.soLuongDat;
                chiTietPhieuDatEdited.donGia = pChiTietPhieuDat.donGia;
                chiTietPhieuDatEdited.tongTien = pChiTietPhieuDat.tongTien;
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaChiTietPhieuDat(ChiTietPhieuDat pChiTietPhieuDat)
        {
            try
            {
                ChiTietPhieuDat chiTietPhieuDatDeleted = MeVaBeDBDataContext.ChiTietPhieuDats.Where(ctpd => ctpd.maPhieuDat == pChiTietPhieuDat.maPhieuDat && ctpd.maSanPham == pChiTietPhieuDat.maSanPham).Select(ctpd => ctpd).FirstOrDefault();
                MeVaBeDBDataContext.ChiTietPhieuDats.DeleteOnSubmit(chiTietPhieuDatDeleted);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaChiTietPhieuDat(string maPhieuDat,string maSanPham)
        {
            try
            {
                ChiTietPhieuDat chiTietPhieuDatDeleted = MeVaBeDBDataContext.ChiTietPhieuDats.Where(ctpd => ctpd.maPhieuDat == maPhieuDat && ctpd.maSanPham == maSanPham).Select(ctpd => ctpd).FirstOrDefault();
                MeVaBeDBDataContext.ChiTietPhieuDats.DeleteOnSubmit(chiTietPhieuDatDeleted);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
