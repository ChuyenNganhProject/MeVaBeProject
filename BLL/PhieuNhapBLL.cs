using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class PhieuNhapBLL
    {
        private PhieuNhapDAL phieuNhapDAL;
        public PhieuNhapBLL()
        {
            this.phieuNhapDAL = new PhieuNhapDAL();
        }
        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            return phieuNhapDAL.LayDanhSachPhieuNhap();
        }
        public bool TaoPhieuNhap(PhieuNhap pPhieuNhap)
        {
            return phieuNhapDAL.TaoPhieuNhap(pPhieuNhap);
        }
        public bool SuaPhieuNhap(PhieuNhap pPhieuNhap)
        {
            return phieuNhapDAL.SuaPhieuNhap(pPhieuNhap);
        }
        public bool XoaPhieuNhap(PhieuNhap pPhieuNhap)
        {
            return phieuNhapDAL.XoaPhieuNhap(pPhieuNhap);
        }
        public bool XoaPhieuNhap(string maPhieuNhap)
        {
            return phieuNhapDAL.XoaPhieuNhap(maPhieuNhap);
        }

    }
}
