using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiNhanVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public LoaiNhanVienDAL()
        {

        }
        public List<LoaiNhanVien> LoadLoaiNhanVien()
        {

            return db.LoaiNhanViens.Select(lnv => lnv).ToList<LoaiNhanVien>();
        }
        public string GetMaLoaiNhanVienMoi()
        {
           
                
                var maLoaiMoi = db.LoaiNhanViens
                    .OrderByDescending(x => x.maLoaiNhanVien) // Sắp xếp theo mã loại giảm dần
                    .Select(x => x.maLoaiNhanVien) // Chọn mã loại
                    .FirstOrDefault(); // Lấy mã loại đầu tiên

                return maLoaiMoi; // Trả về mã loại mới nhất
            
        }
        //public bool InsertLoaiNhanVien(LoaiNhanVien lnv)
        //{
        //    try
        //    {
        //        //// Kiểm tra xem tên loại nhân viên đã tồn tại chưa
        //        //var exLoaiNV = db.LoaiNhanViens
        //        //    .FirstOrDefault(x => x.tenLoaiNhanVien == lnv.tenLoaiNhanVien);
        //        //if (exLoaiNV != null)
        //        //{
        //        //    // Nếu đã tồn tại, trả về false
        //        //    return false;
        //        //}
        //        db.LoaiNhanViens.InsertOnSubmit(lnv);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //        throw new Exception("Thêm thất bại: " + ex.Message);


        //    }
        //}
        public bool InsertLoaiNhanVien(LoaiNhanVien lnv)
        {
            
            try
            {
                if (IsTenLoaiNhanVienExit(lnv.tenLoaiNhanVien))
                {
                    throw new InvalidOperationException("Tên loại nhân viên đã tồn tại");
                }
                // Tạo mã loại nhân viên mới
                string newMaLoaiNV = GenerateNewMaLoaiNV();

                // Gán mã loại nhân viên mới
                lnv.maLoaiNhanVien = newMaLoaiNV;

                // Thêm loại nhân viên vào cơ sở dữ liệu
                db.LoaiNhanViens.InsertOnSubmit(lnv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                //Debug.WriteLine("Thêm thất bại: " + ex.Message);
                throw new Exception("Thêm thất bại: " + ex.Message);
            }
        }

        private string GenerateNewMaLoaiNV()
        {
            // Lấy danh sách mã loại nhân viên có tiền tố "LNV" trong bảng
            var maxMaLoaiNV = db.LoaiNhanViens
                .Where(x => x.maLoaiNhanVien.StartsWith("LNV"))
                .Select(x => x.maLoaiNhanVien)
                .ToList();

            // Thiết lập mã mặc định là "LNV001"
            var newMaLoaiNV = "LNV001";

            if (maxMaLoaiNV.Count > 0)
            {
                // Lấy mã lớn nhất hiện có trong danh sách
                var maxCode = maxMaLoaiNV.Max();

                // Chuyển phần số của mã loại nhân viên thành số nguyên và tăng lên 1
                var numericPart = int.Parse(maxCode.Substring(3)); // Bỏ "LNV" và lấy phần số
                newMaLoaiNV = "LNV" + (numericPart + 1).ToString("D3"); // Tạo mã mới với 3 chữ số
            }

            return newMaLoaiNV;
        }

        public bool IsTenLoaiNhanVienExit(string tenLNV)
        {
            var ex = db.LoaiNhanViens.Any(lnv => lnv.tenLoaiNhanVien == tenLNV);
                return ex;
        }
        //public bool InsertLoaiNhanVien(LoaiNhanVien lnv)
        //{
        //    try
        //    {
        //        // Lấy danh sách mã loại nhân viên có tiền tố "LNV" trong bảng
        //        var maxMaLoaiNV = db.LoaiNhanViens
        //            .Where(x => x.maLoaiNhanVien.StartsWith("LNV"))
        //            .Select(x => x.maLoaiNhanVien)
        //            .ToList();

        //        // Thiết lập mã mặc định là "LNV001"
        //        var newMaLoaiNV = "LNV001";

        //        if (maxMaLoaiNV.Count > 0)
        //        {
        //            // Lấy mã lớn nhất hiện có trong danh sách
        //            var maxCode = maxMaLoaiNV.Max();

        //            // Chuyển phần số của mã loại nhân viên thành số nguyên và tăng lên 1
        //            var numericPart = int.Parse(maxCode.Substring(3)); // Bỏ "LNV" và lấy phần số
        //            newMaLoaiNV = "LNV" + (numericPart + 1).ToString("D3"); // Tạo mã mới với 3 chữ số
        //        }

        //        // Gán mã loại nhân viên mới
        //        lnv.maLoaiNhanVien = newMaLoaiNV;

        //        // Thêm loại nhân viên vào cơ sở dữ liệu
        //        db.LoaiNhanViens.InsertOnSubmit(lnv);
        //        db.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // Ghi lại lỗi vào log hoặc thông báo
        //        Debug.WriteLine("Thêm thất bại: " + ex.Message);
        //        throw new Exception("Thêm thất bại: " + ex.Message);
        //    }
        //}



        public bool DeleteLoaiNhanVien(string malnv)
        {
            try
            {
                var lnv = db.LoaiNhanViens.FirstOrDefault(n => n.maLoaiNhanVien == malnv);
                if (lnv != null)
                {
                    db.LoaiNhanViens.DeleteOnSubmit(lnv);
                    db.SubmitChanges();
                    return true;
                }
                return false; // Không tìm thấy để xóa
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateLoaiNhanVien(LoaiNhanVien lnv)
        {
            try
            {
                if (IsTenLoaiNhanVienExit(lnv.tenLoaiNhanVien))
                {
                    throw new InvalidOperationException("Tên loại nhân viên đã tồn tại");
                }
                var exlnv = db.LoaiNhanViens.FirstOrDefault(n => n.maLoaiNhanVien == lnv.maLoaiNhanVien);
                if (exlnv != null)
                {
                    exlnv.tenLoaiNhanVien = lnv.tenLoaiNhanVien;
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
        public List<LoaiNhanVien> SearchLoaiNhanVien(string keyword)
        {
            // Kiểm tra từ khóa có phải null hay không
            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không có từ khóa, trả về tất cả loại nhân viên
                return LoadLoaiNhanVien();
            }

            // Tìm kiếm các loại nhân viên 
            var filteredLoaiNV = LoadLoaiNhanVien() 
                .Where(x => x.tenLoaiNhanVien != null &&
                            x.tenLoaiNhanVien.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            return filteredLoaiNV;
        }

        public string GetTenLoaiNVByMa(string maLoaiNhanVien)
        {
            return db.LoaiNhanViens
                     .Where(lnv => lnv.maLoaiNhanVien == maLoaiNhanVien)
                     .Select(lnv => lnv.tenLoaiNhanVien)
                     .SingleOrDefault();
        }


    }
}
