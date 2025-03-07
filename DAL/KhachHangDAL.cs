﻿using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            // Tìm mã khách hàng lớn nhất trong bảng
            var maxMaKH = db.KhachHangs
                .Where(x => x.maKhachHang.StartsWith("KH"))
                .Select(x => x.maKhachHang)
                .ToList();

            // Nếu không có mã nào, bắt đầu từ "KH000001"
            var newMaKH = "KH000001"; // Mã khởi tạo mặc định
            if (maxMaKH.Count > 0)
            {
                // Lấy mã lớn nhất
                var maxCode = maxMaKH.Max();

                // Kiểm tra xem mã khách hàng lớn nhất có vượt quá KH999999 không
                var numericPart = int.Parse(maxCode.Substring(2)); // Lấy phần số (bỏ 2 ký tự "KH")
                if (numericPart >= 999999)
                {
                    // Nếu đã đạt đến giới hạn KH999999, thông báo lỗi
                    throw new Exception("Số lượng khách hàng đã đạt đến giới hạn KH999999.");
                }

                // Tạo mã mới với 6 chữ số
                newMaKH = "KH" + (numericPart + 1).ToString("D6");
            }

            return newMaKH;
        }


        public KhachHang LayKhachHangTheoSoDienThoai(string sdt)
        {
            try
            { 
                KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.soDienThoai == sdt);
                khachHang.tenHang = db.HangThanhViens.Where(h => h.maHang == khachHang.maHang).Select(h => h.tenHang).First();
                return khachHang;
            }
            catch
            {
                return null;
            }
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
        public bool DeleteKhachHang(string maKhachHang)
        {
            //try
            //{
            //    var kh = db.KhachHangs.FirstOrDefault(k => k.maKhachHang == maKhachHang);
            //    if (kh != null)
            //    {
            //        db.KhachHangs.DeleteOnSubmit(kh);
            //        db.SubmitChanges();
            //        return true;
            //    }
            //    return false; // Customer not found
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine("Xóa khách hàng thất bại: " + ex.Message);
            //    return false;
            //}
            #region
            //try
            //{
            //    var kh = db.KhachHangs.FirstOrDefault(k => k.maKhachHang == maKhachHang);
            //    if (kh != null)
            //    {
            //        db.KhachHangs.DeleteOnSubmit(kh);
            //        db.SubmitChanges();
            //        return true;
            //    }
            //    return false; // Customer not found
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine("Xóa khách hàng thất bại: " + ex.Message);
            //    return false;
            //}
            #endregion
            try
            {

                bool existsInHoaDon = db.HoaDons.Any(hd => hd.maKhachHang == maKhachHang);
                if (existsInHoaDon)
                {

                    return false;
                }
                var kh = db.KhachHangs.FirstOrDefault(k => k.maKhachHang == maKhachHang);
                if (kh != null)
                {
                    db.KhachHangs.DeleteOnSubmit(kh);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Xóa khách hàng thất bại: " + ex.Message);
                return false;
            }
        }
        public bool IsSDTDuplicate(string sdt)
        {
            return db.KhachHangs.Any(kh => kh.soDienThoai == sdt);
        }
        public string GetTenHangFromMaHang(string maHang)
        {
            //try
            //{

            //    var tenHang = db.HangThanhViens
            //                    .Where(h => h.maHang == maHang)  // Điều kiện lọc theo maHang
            //                    .Select(h => h.tenHang)         // Chọn trường TenHang
            //                    .FirstOrDefault();              // Lấy phần tử đầu tiên hoặc null nếu không tìm thấy

            //    return tenHang ?? string.Empty;    // Nếu không tìm thấy, trả về chuỗi rỗng
            //}
            //catch (Exception ex)
            //{

            //    throw new Exception("Lỗi khi lấy tên hạng: " + ex.Message);
            //}


            try
            {
                if (string.IsNullOrWhiteSpace(maHang))
                {
                    Debug.WriteLine("Mã hạng bị rỗng hoặc chỉ chứa khoảng trắng.");
                    return string.Empty;
                }

                // Ghi log mã hạng nhận được
                Debug.WriteLine($"Mã hạng được truyền vào: '{maHang}'");

                // Truy vấn tên hạng dựa trên mã hạng
                var tenHang = db.HangThanhViens
                                .Where(h => h.maHang == maHang)
                                .Select(h => h.tenHang)
                                .FirstOrDefault();

                Debug.WriteLine($"Tên hạng lấy được: {tenHang ?? "Không tìm thấy"}");
                return tenHang ?? string.Empty; // Trả về chuỗi rỗng nếu không tìm thấy
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi trong GetTenHangFromMaHang: {ex.Message}");
                return string.Empty;
            }
        }

        public List<KhachHang> LoadKhachHang()
        {
            var khachHangs = (from kh in db.KhachHangs
                              join hang in db.HangThanhViens on kh.maHang equals hang.maHang
                              select kh).ToList();

            foreach (var kh in khachHangs)
            {
                var hang = db.HangThanhViens.FirstOrDefault(h => h.maHang == kh.maHang);
                if (hang != null)
                {
                    kh.tenHang = hang.tenHang;
                }
            }
            return khachHangs;
        }
        public List<KhachHang> SearchKhachHang(string keyword)
        {
            if (string.IsNullOrEmpty(keyword))
            {
                return LoadKhachHang();
            }

            var filteredKhachHang = LoadKhachHang()
                .Where(kh => (kh.tenKhachHang != null && kh.tenKhachHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                             (kh.soDienThoai != null && kh.soDienThoai.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                ||(kh.tenHang != null && kh.tenHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            return filteredKhachHang;
        }
        public int TongSoKhachHang()
        {
            return db.KhachHangs.Count();
        }

        public string GetPhoneNumberById(string maKH)
        {
            try
            {
                var khachhang = db.KhachHangs.FirstOrDefault(kh => kh.maKhachHang == maKH);

                if (khachhang != null)
                {

                    return khachhang.soDienThoai;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public List<string> LoadDSSoDienThoai()
        {
            return db.KhachHangs.Select(kh => kh.soDienThoai).ToList();
        }
        public decimal GetMaxDiemTichLuy_KhachHang()
        {
            var maxValue = db.KhachHangs.Max(kh => (decimal?)kh.diemTichLuy) ?? 0m;
            return maxValue;
        }
    }
}
