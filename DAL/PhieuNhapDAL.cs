using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuNhapDAL
    {
        private MeVaBeDBDataContext MeVaBeDBDataContext;
        public PhieuNhapDAL()
        {
            this.MeVaBeDBDataContext = new MeVaBeDBDataContext();
        }
        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            return MeVaBeDBDataContext.PhieuNhaps.Select(pn => pn).ToList<PhieuNhap>();
        }
        public bool TaoPhieuNhap(PhieuNhap pPhieuNhap)
        {
            try
            {
                MeVaBeDBDataContext.PhieuNhaps.InsertOnSubmit(pPhieuNhap);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaPhieuNhap(PhieuNhap pPhieuNhap)
        {
            try
            {
                PhieuNhap phieuNhapEdited = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuNhap == pPhieuNhap.maPhieuNhap).Select(pn => pn).FirstOrDefault();
                //phieuNhapEdited.soLuong = pPhieuNhap.soLuong;
                phieuNhapEdited.tongTien = pPhieuNhap.tongTien;
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuNhap(PhieuNhap pPhieuNhap)
        {
            try
            {
                PhieuNhap phieuNhapDeleted = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuNhap == pPhieuNhap.maPhieuNhap).Select(pn => pn).FirstOrDefault();
                MeVaBeDBDataContext.PhieuNhaps.DeleteOnSubmit(phieuNhapDeleted);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuNhap(string maPhieuNhap)
        {
            try
            {
                PhieuNhap phieuNhapDeleted = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuNhap == maPhieuNhap).Select(pn => pn).FirstOrDefault();
                MeVaBeDBDataContext.PhieuNhaps.DeleteOnSubmit(phieuNhapDeleted);
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
