using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangThanhVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public HangThanhVienDAL() { }

        public List<HangThanhVien> LoadHangTV()
        {

            return db.HangThanhViens.Select(lnv => lnv).ToList<HangThanhVien>();
        }


        public bool IsTenHTVExit(string tenHTV)
        {
            var ex = db.HangThanhViens.Any(lnv => lnv.tenHang == tenHTV);
            return ex;
        }

        public bool InsertHangTV(HangThanhVien htv)
        {
            try
            {
                // Kiểm tra trùng lặp tên hạng
                if (IsTenHTVExit(htv.tenHang))
                {
                    throw new InvalidOperationException("Tên hạng đã tồn tại.");
                }

                // Thêm đối tượng vào cơ sở dữ liệu
                db.HangThanhViens.InsertOnSubmit(htv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public string GenerateNewHangTV()
        {
            // Lấy danh sách tất cả mã hạng thành viên hiện có
            var allMaHTV = db.HangThanhViens
                .Select(x => x.maHang)
                .ToList();

            // Thiết lập mã mặc định là "HTV001"
            var newMaHTV = "HTV001";

            if (allMaHTV.Count > 0)
            {
                // Lọc các mã bắt đầu bằng "HTV"
                var htvs = allMaHTV
                    .Where(x => x.StartsWith("HTV"))
                    .Select(x => x.Substring(3)) // Chỉ lấy phần số
                    .ToList();

                // Kiểm tra xem có mã nào để xử lý không
                if (htvs.Count > 0)
                {
                    // Chuyển phần số thành số nguyên, lấy số lớn nhất, và tăng lên 1
                    int maxNumericPart = htvs
                        .Select(x => int.Parse(x)) // Chuyển chuỗi sang số nguyên
                        .Max(); // Lấy số lớn nhất

                    // Tạo mã mới
                    newMaHTV = "HTV" + (maxNumericPart + 1).ToString("D3");
                }
            }

            // Đảm bảo mã mới không trùng lặp
            while (allMaHTV.Contains(newMaHTV))
            {
                // Nếu trùng, tăng phần số lên 1
                var numericPart = int.Parse(newMaHTV.Substring(3)) + 1;
                newMaHTV = "HTV" + numericPart.ToString("D3");
            }

            return newMaHTV;
        }

        public string GetMaHangThanhVienTheoDiemTichLuy(decimal diemTichLuy)
        {
            var hangThanhVien = db.HangThanhViens
                .Where(h => h.mucTieuBatDau <= diemTichLuy && (diemTichLuy < h.mucTieuKetThuc || h.mucTieuKetThuc == null)) // GOLD || DIAMOND
                .FirstOrDefault();
            return hangThanhVien != null ? hangThanhVien.maHang : "HTV001";
        }

        public bool ValidateNewHang(string maHangMoi, decimal mucTieuBatDauMoi, decimal mucTieuKetThucMoi)
        {
            try
            {
                // Kiểm tra hàng trước đó
                var hangTruoc = db.HangThanhViens
                    .Where(h => string.Compare(h.maHang, maHangMoi) < 0)
                    .OrderByDescending(h => h.maHang)
                    .FirstOrDefault();

                if (hangTruoc != null)
                {
                    // Mức tiêu bắt đầu của hàng mới phải lớn hơn hoặc bằng mức tiêu kết thúc của hàng trước
                    if (mucTieuBatDauMoi < (hangTruoc.mucTieuKetThuc ?? 0))
                    {
                        throw new Exception("Mục tiêu bắt đầu phải bằng Mục tiêu kết thúc của hàng trước đó.");
                    }
                }

                // Kiểm tra hàng hiện tại
                var hangMoi = db.HangThanhViens
                    .FirstOrDefault(h => h.maHang == maHangMoi);

                if (hangMoi != null)
                {
                    // Mức tiêu bắt đầu phải nhỏ hơn mức tiêu kết thúc của hàng hiện tại
                    if (mucTieuBatDauMoi != (hangMoi.mucTieuKetThuc ?? decimal.MaxValue))
                    {
                        throw new Exception("Mục tiêu đầu phải = mục tiêu kết thúc của hạng trước đó.");
                    }
                }

                // Kiểm tra logic trong cùng hàng
                if (mucTieuKetThucMoi <= mucTieuBatDauMoi)
                {
                    throw new Exception("Mục tiêu đầu phải < mục tiêu kết thúc.");
                }

                // Nếu vượt qua mọi kiểm tra, dữ liệu hợp lệ
                return true;
            }
            catch (Exception ex)
            {
                // Ném lỗi chi tiết
                throw new Exception($"{ex.Message}");
            }
        }

        public bool ValidateNewHang_Sua(string maHangMoi, decimal mucTieuBatDauMoi, decimal mucTieuKetThucMoi)
        {
            try
            {
                // Kiểm tra hàng hiện tại
                var hangMoi = db.HangThanhViens
                    .FirstOrDefault(h => h.maHang == maHangMoi);
                // Kiểm tra logic trong cùng hàng
                if (mucTieuKetThucMoi <= mucTieuBatDauMoi)
                {
                    throw new Exception("Mục tiêu đầu phải < mục tiêu kết thúc.");
                }

                // Nếu vượt qua mọi kiểm tra, dữ liệu hợp lệ
                return true;
            }
            catch (Exception ex)
            {
                // Ném lỗi chi tiết
                throw new Exception($"{ex.Message}");
            }
        }
        //USE
        public bool DeleteHangTV(string maH, out string hienthiloi)
        {
            hienthiloi = string.Empty;

            // Lấy hạng thành viên cần xóa
            var htv = db.HangThanhViens.FirstOrDefault(h => h.maHang == maH);
            if (htv == null)
            {
                hienthiloi = "Không tìm thấy mã hạng cần xóa.";
                return false;
            }

            // Kiểm tra nếu mã hạng có giá trị mucTieuBatDau nhỏ nhất
            var minMucTieu = db.HangThanhViens.Min(h => h.mucTieuBatDau);
            if (htv.mucTieuBatDau == minMucTieu)
            {
                hienthiloi = "Đây là hạn mức thấp nhất, không thể xóa.";
                return false;
            }

            try
            {
                // Tìm hạng gần nhất (mã hạng có mục tiêu kết thúc nhỏ hơn hoặc bằng mục tiêu bắt đầu của mã đang xóa)
                var hangGanNhat = db.HangThanhViens
                    .Where(h => h.mucTieuKetThuc <= htv.mucTieuBatDau && h.maHang != maH)
                    .OrderByDescending(h => h.mucTieuKetThuc)
                    .FirstOrDefault();

                // Nếu tìm thấy hạng gần nhất, cập nhật mục tiêu kết thúc
                if (hangGanNhat != null)
                {
                    hangGanNhat.mucTieuKetThuc = htv.mucTieuKetThuc;
                }

                // Lưu thay đổi trong bảng HangThanhViens
                db.SubmitChanges();

                //// Cập nhật các bảng liên quan để sử dụng mã hạng gần nhất
                //if (hangGanNhat != null)
                //{
                //    var khachHangs = db.KhachHangs.Where(k => k.maHang == maH).ToList();
                //    foreach (var kh in khachHangs)
                //    {
                //        kh.maHang = hangGanNhat.maHang; // Cập nhật mã hạng thành mã gần nhất
                //    }

                //    var uuDaiThanhViens = db.UuDaiThanhViens.Where(u => u.maHang == maH).ToList();
                //    foreach (var uuDai in uuDaiThanhViens)
                //    {
                //        uuDai.maHang = hangGanNhat.maHang; // Cập nhật mã hạng thành mã gần nhất
                //    }

                //    // Lưu thay đổi trong các bảng liên quan
                //    db.SubmitChanges();
                //}

                // Xóa hạng thành viên
                db.HangThanhViens.DeleteOnSubmit(htv);
                db.SubmitChanges(); // Lưu thay đổi xóa

                return true;
            }
            catch (Exception ex)
            {
                hienthiloi = $"Có lỗi xảy ra: {ex.Message}";
                return false;
            }
        }

        //not use
        public bool DeleteHangTV(string maH)
        {

            try
            {

                // Cập nhật các bảng liên quan (KhachHang và UuDaiThanhVien) trước khi xóa
                var khachHangs = db.KhachHangs.Where(k => k.maHang == maH).ToList();
                foreach (var kh in khachHangs)
                {
                    // Set maHang thành null trong bảng KhachHang
                    kh.maHang = null;
                }

                var uuDaiThanhViens = db.UuDaiThanhViens.Where(u => u.maHang == maH).ToList();
                foreach (var uuDai in uuDaiThanhViens)
                {
                    // Set maHang thành null trong bảng UuDaiThanhVien
                    uuDai.maHang = null;
                }

                // Lưu các thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                // Tiến hành xóa bản ghi trong bảng HangThanhVien
                var htv = db.HangThanhViens.FirstOrDefault(h => h.maHang == maH);
                if (htv != null)
                {
                    db.HangThanhViens.DeleteOnSubmit(htv);
                    db.SubmitChanges(); // Lưu thay đổi sau khi xóa bản ghi
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAndDeleteHangTV: {ex.Message}");
                return false;
            }
            //try
            //{
            //    var htv = db.HangThanhViens.FirstOrDefault(n => n.maHang == mahnv);
            //    if (htv != null)
            //    {
            //        db.HangThanhViens.DeleteOnSubmit(htv);
            //        db.SubmitChanges();
            //        return true;
            //    }
            //    return false; // Không tìm thấy để xóa
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return false;
            //}


        }

        public bool UpdateHangTV(HangThanhVien htv)
        {
            try
            {
                var exlnv = db.HangThanhViens.FirstOrDefault(n => n.maHang == htv.maHang);
                if (exlnv != null)
                {
                    exlnv.maHang = htv.maHang;
                    exlnv.mucTieuBatDau = htv.mucTieuBatDau;
                    exlnv.mucTieuKetThuc = htv.mucTieuKetThuc;
                    exlnv.ghiChu = htv.ghiChu;
                    exlnv.tenHang = htv.tenHang;

                    var hangTruoc = db.HangThanhViens.FirstOrDefault(n => n.mucTieuKetThuc == exlnv.mucTieuBatDau);
                    if (hangTruoc != null)
                    {
                        hangTruoc.mucTieuKetThuc = exlnv.mucTieuBatDau;
                    }

                    var hangSau = db.HangThanhViens.FirstOrDefault(n => n.mucTieuBatDau == exlnv.mucTieuKetThuc);
                    if (hangSau != null)
                    {
                        hangSau.mucTieuBatDau = exlnv.mucTieuKetThuc;
                    }

                    db.SubmitChanges();
                    return true;
                }
                return false; // Không tìm thấy để sửa
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public List<HangThanhVien> SearchHangTV(string keyword)
        {
            // Kiểm tra từ khóa có phải null hay không
            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không có từ khóa, trả về tất cả loại nhân viên
                return LoadHangTV();
            }

            // Tìm kiếm các loại nhân viên 
            var filteredHTV = LoadHangTV()
                .Where(kh => (kh.tenHang != null && kh.tenHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                             (kh.maHang != null && kh.maHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
            return filteredHTV;
        }

        public string GetTenHangTVByMa(string maHang)
        {
            return db.HangThanhViens
                     .Where(lnv => lnv.maHang == maHang)
                     .Select(lnv => lnv.tenHang)
                     .SingleOrDefault();
        }
       
    }
}
