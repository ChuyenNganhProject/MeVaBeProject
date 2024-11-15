using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public KhachHangDAL() { }

        public bool ThemKhachHang(KhachHang kh)
        {
            try
            {
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Tạo mã D5
        public string TaoMaKhachHangTuDong()
        {
            var khachHangs = db.KhachHangs.ToList();
            if (khachHangs.Any())
            {
                var khachHangCuoiCung = khachHangs.OrderByDescending(kh => int.Parse(kh.maKhachHang.Substring(2))).FirstOrDefault();

                string maKhachHangCuoiCung = khachHangCuoiCung.maKhachHang;
                int stt = int.Parse(maKhachHangCuoiCung.Substring(2)) + 1;

                return "KH" + stt.ToString("D5");
            }
            return "KH00001";
        }


        public KhachHang LayKhachHangTheoSoDienThoai(string sdt)
        {
            KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.soDienThoai == sdt);
            if (khachHang != null)
            {
                khachHang.tenHang = db.HangThanhViens.Where(h => h.maHang == khachHang.maHang).Select(h => h.tenHang).First();
                return khachHang;
            }
            return null;
        }

        public bool CapNhatKhachHang(KhachHang khachhang)
        {
            try
            {
                KhachHang updatedKhachHang = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == khachhang.maKhachHang);
                if (updatedKhachHang != null)
                {
                    updatedKhachHang.tenKhachHang = khachhang.tenKhachHang;
                    updatedKhachHang.soDienThoai = khachhang.soDienThoai;
                    updatedKhachHang.diemTichLuy = khachhang.diemTichLuy;
                    updatedKhachHang.maHang = khachhang.maHang;
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi sửa thông tin khách hàng: " + ex.Message, ex);
            }
        }

        public KhachHang LayKHTheoMa(string ma)
        {
            try
            {
                KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == ma);
                khachHang.tenHang = db.HangThanhViens.Where(h => h.maHang == khachHang.maHang).Select(h => h.tenHang).First();
                return khachHang;
            }
            catch
            {
                return null;
            }
        }

        public int TongSoKhachHang()
        {
            return db.KhachHangs.Count();
        }
    }
}
