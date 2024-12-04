using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuGiaoDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public ChiTietPhieuGiaoDAL() { }

        public bool ThemHoacSuaChiTietPhieuGiao(ChiTietPhieuGiaoHang ctpg)
        {
            try
            {
                var sanPhamTrongPG = db.ChiTietPhieuGiaoHangs.FirstOrDefault(ctpgiao => ctpgiao.maPhieuGiao == ctpg.maPhieuGiao
                                                                    && ctpgiao.maHoaDon == ctpg.maHoaDon && ctpgiao.maSanPham == ctpg.maSanPham);
                if(sanPhamTrongPG == null)
                {
                    db.ChiTietPhieuGiaoHangs.InsertOnSubmit(ctpg);
                }
                else
                {
                    sanPhamTrongPG.soLuong = ctpg.soLuong;
                    sanPhamTrongPG.tongTien = ctpg.tongTien;
                }
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Load cho phiếu
        public List<ChiTietPhieuGiaoHang> LayDanhSachChiTietPhieuGiao(string maPhieuGiao)
        {
            if (!string.IsNullOrEmpty(maPhieuGiao))
            {
                var chiTietPhieuGiaoList = db.ChiTietPhieuGiaoHangs
                                 .Where(ctpg => ctpg.maPhieuGiao == maPhieuGiao)
                                 .ToList();

                var result = chiTietPhieuGiaoList.Select((ctpg, index) => new ChiTietPhieuGiaoHang
                {
                    STT = index + 1,
                    maPhieuGiao = ctpg.maPhieuGiao,
                    maHoaDon = ctpg.maHoaDon,
                    maSanPham = ctpg.maSanPham,
                    soLuong = ctpg.soLuong,
                    donGia = ctpg.donGia,
                    tongTien = ctpg.tongTien,
                    tenSanPham = db.SanPhams.FirstOrDefault(sp => sp.maSanPham == ctpg.maSanPham)?.tenSanPham
                }).ToList();

                return result;
            }
            else
            {
                return new List<ChiTietPhieuGiaoHang>();
            }
        }

        // Load cho form
        public List<ChiTietPhieuGiaoHang> LoadCTPGChoForm(string maPhieuGiao)
        {
            if (!string.IsNullOrEmpty(maPhieuGiao))
            {
                var list = db.ChiTietPhieuGiaoHangs.Where(ct => ct.maPhieuGiao == maPhieuGiao).Select(ct => ct).ToList<ChiTietPhieuGiaoHang>();
                foreach (var item in list)
                {
                    item.tenSanPham = db.SanPhams.Where(sp => sp.maSanPham == item.maSanPham).Select(sp => sp.tenSanPham).First();
                }
                return list;
            }
            else
            {
                return new List<ChiTietPhieuGiaoHang> { };
            }
        }

        public string LayMaPGTuHoaDon(string mahd)
        {
            return db.ChiTietPhieuGiaoHangs.Where(ct => ct.maHoaDon == mahd).Select(ct => ct.maPhieuGiao).FirstOrDefault();
        }
    }
}
