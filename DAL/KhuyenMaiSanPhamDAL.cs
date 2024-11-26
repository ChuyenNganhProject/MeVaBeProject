using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiSanPhamDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public KhuyenMaiSanPhamDAL() { }

        public List<KhuyenMaiSanPham> LoadSanPhamTheoKhuyenMai(string maKhuyenMai)
        {
            try
            {
                var listSp = db.KhuyenMaiSanPhams.Where(km => km.maKhuyenMai == maKhuyenMai).Select(sp => sp).ToList();
                foreach (var spkm in listSp)
                {
                    spkm.tenSanPham = db.SanPhams.Where(sp => sp.maSanPham == spkm.maSanPham).Select(sp => sp.tenSanPham).FirstOrDefault();
                }
                return listSp;
            }
            catch
            {
                return new List<KhuyenMaiSanPham>();
            }
        }

        public bool ThemHoacCapNhatSanPhamVaoCTKhuyenMai(string maKhuyenMai, string maSanPham, decimal phanTramGiam, int soLuongToiDa)
        {
            try
            {
                var sanPhamKM = db.KhuyenMaiSanPhams.FirstOrDefault(kmsp => kmsp.maKhuyenMai == maKhuyenMai && kmsp.maSanPham == maSanPham);
                if (sanPhamKM == null)
                {
                    KhuyenMaiSanPham kmSanPham = new KhuyenMaiSanPham
                    {
                        maKhuyenMai = maKhuyenMai,
                        maSanPham = maSanPham,
                        phanTramGiam = phanTramGiam,
                        soLuongToiDa = soLuongToiDa,
                        trangThai = true
                    };

                    db.KhuyenMaiSanPhams.InsertOnSubmit(kmSanPham);
                }
                else
                {
                    sanPhamKM.phanTramGiam = phanTramGiam;
                    sanPhamKM.soLuongToiDa = soLuongToiDa;
                }

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public KhuyenMaiSanPham LayKhuyenMaiTheoSanPham(string maSanPham)
        {
            var khuyenMaiSanPham = db.KhuyenMaiSanPhams
                                    .Where(kmsp => kmsp.maSanPham == maSanPham && kmsp.trangThai == true)
                                    .Select(kmsp => kmsp)
                                    .FirstOrDefault();
            if(khuyenMaiSanPham != null)
            {
                return khuyenMaiSanPham;
            }
            return null;
        }

        public KhuyenMaiSanPham LayTTSanPhamCuaKhuyenMai(string maKhuyenMai, string maSanPham)
        {
            var khuyenMaiSanPham = db.KhuyenMaiSanPhams
                                    .Where(kmsp => kmsp.maSanPham == maSanPham && kmsp.maKhuyenMai == maKhuyenMai && kmsp.trangThai == true)
                                    .Select(kmsp => kmsp)
                                    .FirstOrDefault();
            if (khuyenMaiSanPham != null)
            {
                return khuyenMaiSanPham;
            }
            return null;
        }
    }
}
