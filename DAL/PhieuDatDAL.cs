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
            List<PhieuDat> phieuDats = MeVaBeDBDataContext.PhieuDats.OrderByDescending(pd => pd.maPhieuDat).Select(pd => pd).ToList<PhieuDat>();
            foreach(PhieuDat phieuDat in phieuDats)
            {
                phieuDat.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuDat.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                phieuDat.tenNhaCungCap = MeVaBeDBDataContext.NhaCungCaps.Where(ncc => ncc.maNhaCungCap == phieuDat.maNhaCungCap).Select(ncc => ncc.tenNhaCungCap).FirstOrDefault();
            }
            return phieuDats;
        }
        public List<PhieuDat> LayDanhSachPhieuDatDuocDuyet()
        {
            List<PhieuDat> phieuDats = MeVaBeDBDataContext.PhieuDats.Where(pd=>pd.trangThai == "Đã duyệt" && pd.trangThaiXacNhan == "Đã chấp thuận").OrderByDescending(pd=>pd.maPhieuDat).Select(pd => pd).ToList<PhieuDat>();
            foreach (PhieuDat phieuDat in phieuDats)
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
            try
            {
                PhieuDat phieuDats = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).First();
                phieuDats.tenNhanVien = MeVaBeDBDataContext.NhanViens.Where(nv => nv.maNhanVien == phieuDats.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
                phieuDats.tenNhaCungCap = MeVaBeDBDataContext.NhaCungCaps.Where(ncc => ncc.maNhaCungCap == phieuDats.maNhaCungCap).Select(ncc => ncc.tenNhaCungCap).FirstOrDefault();
                return phieuDats;
            }
            catch (Exception)
            {
                return null;
            }           
        }
        public string TaoMaPhieuDat()
        {
            string maPhieuDat = MeVaBeDBDataContext.PhieuDats.OrderByDescending(pd => pd.maPhieuDat).Select(pd => pd.maPhieuDat).FirstOrDefault();
            if (maPhieuDat!=null)
            {
                return maPhieuDat;
            }
            return "PD000000000";
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
        public bool DuyetPhieuDat(string maPhieuDat,string trangThai)
        {
            try
            {
                PhieuDat phieuDatEdited = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).FirstOrDefault();
                phieuDatEdited.trangThai = trangThai;
                if (trangThai == "Đã duyệt")
                {
                    phieuDatEdited.trangThaiXacNhan = null;
                    phieuDatEdited.ghiChu = null;
                }                
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XacNhanPhieuDat(string maPhieuDat,string trangThai)
        {
            try
            {
                PhieuDat phieuDatEdited = MeVaBeDBDataContext.PhieuDats.Where(pd => pd.maPhieuDat == maPhieuDat).Select(pd => pd).FirstOrDefault();
                phieuDatEdited.trangThaiXacNhan = trangThai;
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
                MeVaBeDBDataContext.XoaPhieuDat_Proc(pPhieuDat.maPhieuDat);
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
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
