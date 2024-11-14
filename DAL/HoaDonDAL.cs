using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public HoaDonDAL() { }

        public List<HoaDon> LoadDanhSachHoaDon()
        {
            try
            {
                var hoadons = db.HoaDons.Select(hd => hd).ToList<HoaDon>();
                foreach(var hoaDon in hoadons)
                {
                    var khachhangs = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == hoaDon.maKhachHang);
                    if (khachhangs != null)
                    {
                        hoaDon.tenKhachHang = khachhangs.tenKhachHang;
                    }
                    var nhanviens = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == hoaDon.maNhanVien);
                    if (nhanviens != null)
                    {
                        hoaDon.tenNhanVien = nhanviens.tenNhanVien;
                    }
                    if(hoaDon.trangThai == true)
                    {
                        hoaDon.tenTrangThai = "Đã thanh toán";
                    }
                    else
                    {
                        hoaDon.tenTrangThai = "Chưa thanh toán";
                    }
                }
                return hoadons;
            }
            catch { return new List<HoaDon>(); }
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            try
            {
                db.HoaDons.InsertOnSubmit(hd);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public string TaoMaHoaDonTuDong()
        {
            var hoaDons = db.HoaDons.ToList();
            if (hoaDons.Any())
            {
                var hoaDonCuoiCung = hoaDons.OrderByDescending(hd => int.Parse(hd.maHoaDon.Substring(2))).FirstOrDefault();

                string maHoaDonCuoiCung = hoaDonCuoiCung.maHoaDon;
                int stt = int.Parse(maHoaDonCuoiCung.Substring(2)) + 1;

                return "HD" + stt.ToString("D5");
            }
            return "HD00001";
        }

        public decimal tongTienTatCaHoaDonCuaKH(KhachHang khachhang)
        {
            return db.HoaDons
                .Where(hd => hd.maKhachHang == khachhang.maKhachHang)
                .Sum(hd => hd.tongTien ?? 0);
        }

        public static string RemoveVietnameseDaus(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            string[] daus = new string[]
            {
                "aáàảãạăắằẳẵặâấầẩẫậ", "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬ",
                "dđ", "DĐ",
                "eéèẻẽẹêếềểễệ", "EÉÈẺẼẸÊẾỀỂỄỆ",
                "iíìỉĩị", "IÍÌỈĨỊ",
                "oóòỏõọôốồổỗộơớờởỡợ", "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ",
                "uúùủũụưứừửữự", "UÚÙỦŨỤƯỨỪỬỮỰ",
                "yýỳỷỹỵ", "YÝỲỶỸỴ"
            };

            foreach (var dau in daus)
            {
                foreach (var ch in dau.Skip(1))
                {
                    input = input.Replace(ch, dau[0]);
                }
            }

            return input;
        }
        public List<HoaDon> TimKiemHoaDon(string tieuChi, string giaTriTimKiem)
        {
            try
            {
                var hoadons = db.HoaDons.ToList();
                foreach (var hoaDon in hoadons)
                {
                    var khachhang = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == hoaDon.maKhachHang);
                    if (khachhang != null)
                    {
                        hoaDon.tenKhachHang = khachhang.tenKhachHang;
                    }

                    var nhanvien = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == hoaDon.maNhanVien);
                    if (nhanvien != null)
                    {
                        hoaDon.tenNhanVien = nhanvien.tenNhanVien;
                    }
                }

                giaTriTimKiem = RemoveVietnameseDaus(giaTriTimKiem.ToLower());
                switch (tieuChi)
                {
                    case "Các tiêu chí":
                        {
                            hoadons = hoadons.ToList();
                            break;
                        }
                    case "Mã hóa đơn":
                        hoadons = hoadons.Where(hd => RemoveVietnameseDaus(hd.maHoaDon.ToLower()).Contains(giaTriTimKiem)).ToList();
                        break;
                    case "Tên khách hàng":
                        hoadons = hoadons
                            .Where(hd => hd.tenKhachHang != null && RemoveVietnameseDaus(hd.tenKhachHang.ToLower())
                            .Contains(giaTriTimKiem)).ToList();
                        break;
                    case "Tên nhân viên":
                        hoadons = hoadons
                            .Where(hd => hd.tenNhanVien != null && RemoveVietnameseDaus(hd.tenNhanVien.ToLower())
                            .Contains(giaTriTimKiem)).ToList();
                        break;
                    case "Ngày lập":
                        if (DateTime.TryParse(giaTriTimKiem, out DateTime ngayLap))
                        {
                            hoadons = hoadons.Where(hd => hd.ngayLap.HasValue && hd.ngayLap.Value.Date == ngayLap.Date).ToList();
                        }
                        break;
                }
                return hoadons;
            }
            catch
            {
                return new List<HoaDon>();
            }
        }

        public HoaDon LoadHoaDonTheoMa(string mahd)
        {
            HoaDon hoadon = db.HoaDons.FirstOrDefault(hd => hd.maHoaDon == mahd);
            hoadon.tenKhachHang = db.KhachHangs.Where(kh => kh.maKhachHang == hoadon.maKhachHang).Select(kh => kh.tenKhachHang).FirstOrDefault();
            hoadon.tenNhanVien = db.NhanViens.Where(nv => nv.maNhanVien == hoadon.maNhanVien).Select(nv => nv.tenNhanVien).FirstOrDefault();
            if(hoadon.trangThai == true)
            {
                hoadon.tenTrangThai = "Đã thanh toán";
            }
            else
            {
                hoadon.tenTrangThai = "Chưa thanh toán";
            }
            return hoadon;
        }

        // Tất cả hóa đơn
        public decimal TinhTongDoanhThu()
        {
            return db.HoaDons.Sum(hd => hd.tongTienSauGiam) ?? 0;
        }

        public int TongSoHoaDon()
        {
            return db.HoaDons.Count();
        }

        // Năm này
        public decimal TinhDoanhThuNamNay()
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Year == DateTime.Now.Year)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }

        public int TongHoaDonNamNay()
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Year == DateTime.Now.Year)
                .Count();
        }

        // Tháng này
        public decimal TinhDoanhThuThangNay()
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Month == DateTime.Now.Month && hd.ngayLap.Value.Year == DateTime.Now.Year)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }

        public int TongHoaDonThangNay()
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Month == DateTime.Now.Month && hd.ngayLap.Value.Year == DateTime.Now.Year)
                .Count();
        }

        // 30 ngày qua
        public decimal TinhDoanhThu30NgayQua()
        {
            DateTime BaMuoiNgayQua = DateTime.Now.AddDays(-30);
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value >= BaMuoiNgayQua && hd.ngayLap.Value <= DateTime.Now)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }
        public int TongHoaDon30NgayQua()
        {
            DateTime BaMuoiNgayQua = DateTime.Now.AddDays(-30);
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value >= BaMuoiNgayQua && hd.ngayLap.Value <= DateTime.Now)
                .Count();
        }

        // 7 ngày qua
        public decimal TinhDoanhThu7NgayQua()
        {
            DateTime BayNgayQua = DateTime.Now.AddDays(-7);
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date >= BayNgayQua.Date && hd.ngayLap.Value <= DateTime.Now)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }
        public int TongHoaDon7NgayQua()
        {
            DateTime BayNgayQua = DateTime.Now.AddDays(-7);
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date >= BayNgayQua.Date && hd.ngayLap.Value <= DateTime.Now)
                .Count();
        }

        // Hôm nay
        public decimal TinhDoanhThuHomNay()
        {
            DateTime HomNay = DateTime.Now;
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date == HomNay.Date)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }
        public int TongHoaDonHomNay()
        {
            DateTime HomNay = DateTime.Now;
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date == HomNay.Date)
                .Count();
        }

        // Custom
        public List<HoaDon> LoadDanhSachHoaDonTheoNgayLoc(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            try
            {
                var hoadons = db.HoaDons.Where(hd => hd.ngayLap.HasValue && hd.ngayLap.Value.Date >= ngayBatDau.Date
                                                    && hd.ngayLap.Value.Date <= ngayKetThuc.Date)
                                    .ToList();
                foreach (var hoaDon in hoadons)
                {
                    var khachhangs = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == hoaDon.maKhachHang);
                    if (khachhangs != null)
                    {
                        hoaDon.tenKhachHang = khachhangs.tenKhachHang;
                    }
                    var nhanviens = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == hoaDon.maNhanVien);
                    if (nhanviens != null)
                    {
                        hoaDon.tenNhanVien = nhanviens.tenNhanVien;
                    }
                    if (hoaDon.trangThai == true)
                    {
                        hoaDon.tenTrangThai = "Đã thanh toán";
                    }
                    else
                    {
                        hoaDon.tenTrangThai = "Chưa thanh toán";
                    }
                }
                return hoadons;
            }
            catch
            {
                return new List<HoaDon>();
            }
        }

        public decimal TinhDoanhThuTheoKhoangThoiGian(DateTime batDau, DateTime ketThuc)
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date >= batDau.Date && hd.ngayLap.Value.Date <= ketThuc.Date)
                .Sum(hd => hd.tongTienSauGiam) ?? 0;
        }

        public int TongSoHoaDonTheoKhoangThoiGian(DateTime batDau, DateTime ketThuc)
        {
            return db.HoaDons
                .Where(hd => hd.ngayLap.Value.Date >= batDau.Date && hd.ngayLap.Value.Date <= ketThuc.Date)
                .Count();
        }
    }
}
