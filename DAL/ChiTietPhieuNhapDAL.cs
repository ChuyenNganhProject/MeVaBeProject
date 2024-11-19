using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        private MeVaBeDBDataContext MeVaBeDBDataContext;
        public ChiTietPhieuNhapDAL() 
        { 
            this.MeVaBeDBDataContext = new MeVaBeDBDataContext();
        }
        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> chiTietPhieuNhaps = MeVaBeDBDataContext.ChiTietPhieuNhaps.Where(ctpm=>ctpm.maPhieuNhap == maPhieuNhap).Select(ctpn => ctpn).ToList<ChiTietPhieuNhap>();
            foreach (ChiTietPhieuNhap chiTietPhieuNhap in chiTietPhieuNhaps)
            {
                chiTietPhieuNhap.tenSanPham = MeVaBeDBDataContext.SanPhams.Where(sp => sp.maSanPham == chiTietPhieuNhap.maSanPham).Select(sp => sp.tenSanPham).FirstOrDefault();
            }
            return chiTietPhieuNhaps;
        }
        public bool TaoChiTietPhieuNhap (ChiTietPhieuNhap pChiTietPhieuNhap)
        {
            try
            {
                MeVaBeDBDataContext.ChiTietPhieuNhaps.InsertOnSubmit(pChiTietPhieuNhap);
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap pChiTietPhieuNhap)
        {
            try
            {
                ChiTietPhieuNhap chiTietPhieuNhapEdited = MeVaBeDBDataContext.ChiTietPhieuNhaps.Where(ctpn => ctpn.maPhieuDat == pChiTietPhieuNhap.maPhieuDat && ctpn.maPhieuNhap == pChiTietPhieuNhap.maPhieuNhap && ctpn.maSanPham == pChiTietPhieuNhap.maSanPham).Select(ctpn => ctpn).FirstOrDefault();
                chiTietPhieuNhapEdited.soLuong = pChiTietPhieuNhap.soLuong;
                chiTietPhieuNhapEdited.donGia = pChiTietPhieuNhap.donGia;
                chiTietPhieuNhapEdited.tongTien = pChiTietPhieuNhap.tongTien;
                MeVaBeDBDataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }        
    }
}
