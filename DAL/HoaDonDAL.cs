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
                var hoadons = db.HoaDons.Select(hd => hd).OrderByDescending(hd => hd.maHoaDon).ToList<HoaDon>();
                foreach(var hoaDon in hoadons)
                {
                    var khachhangs = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == hoaDon.maKhachHang);
                    if (khachhangs != null)
                    {
                        hoaDon.tenKhachHang = khachhangs.tenKhachHang;
                    }
                    else
                    {
                        hoaDon.tenKhachHang = "Khách vãng lai";
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
        public List<HoaDon> TimKiemVaLocHoaDon(string tieuChi, string giaTriTimKiem, DateTime ngayBatDau, DateTime ngayKetThuc, string loaikh)
        {
            try
            {
                var hoadons = db.HoaDons.Where(hd => hd.ngayLap.HasValue && hd.ngayLap.Value.Date >= ngayBatDau.Date 
                                            && hd.ngayLap.Value.Date <= ngayKetThuc.Date)
                                        .ToList();
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
                    hoaDon.tenTrangThai = hoaDon.trangThai == true ? "Đã thanh toán" : "Chưa thanh toán";
                }

                if (!string.IsNullOrEmpty(giaTriTimKiem))
                {
                    giaTriTimKiem = RemoveVietnameseDaus(giaTriTimKiem.ToLower());
                    switch (tieuChi)
                    {
                        case "Các tiêu chí":
                            break;
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
                    }
                }
                switch(loaikh)
                {
                    case "Loại khách hàng":
                        break;
                    case "Khách vãng lai":
                        hoadons = hoadons.Where(hd => hd.tenKhachHang == loaikh).ToList();
                        break;
                    case "Khách thành viên":
                        hoadons = hoadons.Where(hd => hd.tenKhachHang == loaikh).ToList();
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

        public Dictionary<DateTime?, decimal> ThongKeTongDoanhThuCuaTungNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var doanhThuTheoNgay = db.HoaDons
                                    .Where(hd => hd.ngayLap.Value.Date >= ngayBatDau.Date && hd.ngayLap.Value.Date <= ngayKetThuc.Date)
                                    .GroupBy(hd => hd.ngayLap.Value.Date)
                                    .Select(tk => new
                                    {
                                        Ngay = tk.Key,
                                        TongDoanhThu = tk.Sum(hd => hd.tongTienSauGiam) ?? 0
                                    }).ToDictionary(x => (DateTime?)x.Ngay, x => x.TongDoanhThu);

            if (!doanhThuTheoNgay.Any())
            {
                return new Dictionary<DateTime?, decimal>();
            }
            return doanhThuTheoNgay;
        }

        // Lọc hôm nay
        public Dictionary<int, decimal> ThongKeTongDoanhThuTheoGioTrongNgay(DateTime ngay)
        {
            DateTime ngayBatDau = ngay.Date;
            DateTime ngayKetThuc = ngayBatDau.AddDays(1);
            var doanhThuTheoGio = db.HoaDons
                                    .Where(hd => hd.ngayLap >= ngayBatDau && hd.ngayLap < ngayKetThuc)
                                    .GroupBy(hd => hd.ngayLap.Value.Hour)
                                    .Select(tk => new
                                    {
                                        Gio = tk.Key,
                                        TongDoanhThu = tk.Sum(hd => hd.tongTienSauGiam) ?? 0
                                    }).ToDictionary(x => x.Gio, x => x.TongDoanhThu);

            if (!doanhThuTheoGio.Any())
            {
                return new Dictionary<int, decimal>();
            }
            return doanhThuTheoGio;
        }

        // Lọc năm nay
        public List<ThongKeDoanhThuTheoThang> ThongKeTongDoanhThuTheoThangTrongNam(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var doanhThuTheoThang = db.HoaDons
                                  .Where(hd => hd.ngayLap >= ngayBatDau && hd.ngayLap <= ngayKetThuc)
                                  .GroupBy(hd => new { hd.ngayLap.Value.Year, hd.ngayLap.Value.Month })
                                  .Select(tk => new ThongKeDoanhThuTheoThang
                                  {
                                      Thang = new DateTime(tk.Key.Year, tk.Key.Month, 1),
                                      TongDoanhThu = TinhDoanhThuTheoKhoangThoiGian(ngayBatDau, ngayKetThuc)
                                  })
                                  .ToList();

            if (!doanhThuTheoThang.Any())
            {
                return new List<ThongKeDoanhThuTheoThang>();
            }
            return doanhThuTheoThang;
        }
    }
}
