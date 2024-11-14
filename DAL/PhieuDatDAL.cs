using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuDatDAL
    {
        private MeVaBeDBDataContext MeVaBeDBDataContext;
        public PhieuDatDAL()
        {
            this.MeVaBeDBDataContext = new MeVaBeDBDataContext();
        }
        public List<PhieuDat> LayDanhSachPhieuDat()
        {
            List<PhieuDat> phieuDats = MeVaBeDBDataContext.PhieuDats.Select(pd => pd).ToList<PhieuDat>();
            foreach(PhieuDat phieuDat in phieuDats)
            {
                phieuDat.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuDat.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                phieuDat.tenNhaCungCap = MeVaBeDBDataContext.NhaCungCaps.Where(ncc => ncc.maNhaCungCap == phieuDat.maNhaCungCap).Select(ncc => ncc.tenNhaCungCap).FirstOrDefault();
            }
            return phieuDats;
        }
        public List<PhieuDat> LocDanhSachPhieuDatTheoNgayLap(DateTime ngayLap)
        {
            List<PhieuDat> phieuDats = MeVaBeDBDataContext.PhieuDats.Where(pd=>pd.ngayLap == ngayLap).Select(pd => pd).ToList<PhieuDat>();
            foreach (PhieuDat phieuDat in phieuDats)
            {
                phieuDat.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuDat.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                phieuDat.tenNhaCungCap = MeVaBeDBDataContext.NhaCungCaps.Where(ncc => ncc.maNhaCungCap == phieuDat.maNhaCungCap).Select(ncc => ncc.tenNhaCungCap).FirstOrDefault();
            }
            return phieuDats;
        }
        public PhieuDat TimKiemPhieuDatTheoMaPhieuDat(string maPhieuDat)
        {
            PhieuDat phieuDats = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).First();
            phieuDats.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuDats.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
            phieuDats.tenNhaCungCap = MeVaBeDBDataContext.NhaCungCaps.Where(ncc => ncc.maNhaCungCap == phieuDats.maNhaCungCap).Select(ncc => ncc.tenNhaCungCap).FirstOrDefault();
            return phieuDats;
        }
        public string TaoMaPhieuDat()
        {
            return MeVaBeDBDataContext.PhieuDats.OrderByDescending(pd => pd.maPhieuDat).Select(pd => pd.maPhieuDat).FirstOrDefault();
        }
        public bool TaoPhieuDat(PhieuDat pPhieuDat)
        {
            try
            {
                MeVaBeDBDataContext.PhieuDats.InsertOnSubmit(pPhieuDat);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaPhieuDat(PhieuDat pPhieuDat)
        {
            try
            {
                PhieuDat phieuDatEdited = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == pPhieuDat.maPhieuDat).Select(pd => pd).FirstOrDefault();
                phieuDatEdited.maNhaCungCap = pPhieuDat.maNhaCungCap;
                phieuDatEdited.maNhanVien = pPhieuDat.maNhanVien;
                phieuDatEdited.ngayCapNhat = pPhieuDat.ngayCapNhat;
                phieuDatEdited.soLuong = pPhieuDat.soLuong;
                phieuDatEdited.tongTien = pPhieuDat.tongTien;
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DuyetPhieuDat(string maPhieuDat)
        {
            try
            {
                PhieuDat phieuDatEdited = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).FirstOrDefault();
                phieuDatEdited.trangThai = "Đã duyệt";
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuDat(PhieuDat pPhieuDat)
        {
            try
            {
                PhieuDat phieuDatDeleted = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == pPhieuDat.maPhieuDat).Select(pd => pd).FirstOrDefault();
                MeVaBeDBDataContext.PhieuDats.DeleteOnSubmit(phieuDatDeleted);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaPhieuDat(string maPhieuDat)
        {
            try
            {
                MeVaBeDBDataContext.XoaPhieuDat_Proc(maPhieuDat);
                //PhieuDat phieuDatDeleted = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).FirstOrDefault();
                //MeVaBeDBDataContext.PhieuDats.DeleteOnSubmit(phieuDatDeleted);
                //MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
