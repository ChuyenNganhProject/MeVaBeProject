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
            List<PhieuNhap> phieuNhaps = MeVaBeDBDataContext.PhieuNhaps.Select(pn => pn).ToList<PhieuNhap>();
            foreach(PhieuNhap pn in phieuNhaps)
            {
                pn.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == pn.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
            }
            return phieuNhaps;
        }
        public PhieuNhap TimKiemPhieuNhapTheoMaPhieuNhap(string maPhieuNhap)
        {
            try
            {
                PhieuNhap phieuNhaps = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuNhap == maPhieuNhap).Select(pn => pn).FirstOrDefault();
                phieuNhaps.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuNhaps.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                return phieuNhaps;
            }
            catch (Exception)
            {
                return null;
            }            
        }
        public List<PhieuNhap> TimKiemPhieuNhapTheoMaPhieuDat(string maPhieuDat)
        {
            try
            {
                List<PhieuNhap> phieuNhaps = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuDat == maPhieuDat).Select(pn => pn).ToList<PhieuNhap>();
                foreach(PhieuNhap pn in phieuNhaps)
                {
                    pn.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == pn.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                }                
                return phieuNhaps;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string TaoMaPhieuNhap()
        {
            string maPhieuNhap = MeVaBeDBDataContext.PhieuNhaps.OrderByDescending(pn => pn.maPhieuNhap).Select(pn => pn.maPhieuNhap).FirstOrDefault();
            if (maPhieuNhap != null)
            {
                return maPhieuNhap;
            }
            return "PN000000000";
        }
        public List<PhieuNhap> LocDanhSachPhieuNhapTheoNgayLap(DateTime ngayLap)
        {
            List<PhieuNhap> phieuNhaps = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.ngayNhap == ngayLap).Select(pn => pn).ToList<PhieuNhap>();
            foreach (PhieuNhap phieuNhap in phieuNhaps)
            {
                phieuNhap.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuNhap.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();                
            }
            return phieuNhaps;
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
        public bool XoaPhieuNhap(string maPhieuNhap,int? soLan)
        {
            try
            {
                PhieuNhap phieuNhapDeleted = MeVaBeDBDataContext.PhieuNhaps.Where(pn => pn.maPhieuNhap == maPhieuNhap && pn.soLan == soLan).Select(pn => pn).FirstOrDefault();
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
