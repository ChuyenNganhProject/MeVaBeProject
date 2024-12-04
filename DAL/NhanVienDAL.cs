using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public NhanVienDAL()
        {

        }
        public NhanVien DangNhap(string username, string password)
        {
            var hashedPassword = MaHoaMatKhauKieuSha256Hash(password);
            var nhanVien = db.NhanViens.SingleOrDefault(nv => nv.tenDangNhap == username && nv.matKhau == hashedPassword);
            nhanVien.tenLoaiNhanVien = db.LoaiNhanViens.Where(lnv => lnv.maLoaiNhanVien == nhanVien.maLoaiNhanVien).Select(lnv => lnv.tenLoaiNhanVien).FirstOrDefault();
            return nhanVien;
        }
        public string MaHoaMatKhauKieuSha256Hash(string pass)
        {
            using(var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(pass)); // chuyển pass thành mảng byte
                return string.Concat(bytes.Select(b => b.ToString("x2"))); // chuyển sang chuỗi hexa 
            }

        }
        public NhanVien LayTTNhanVienTuTenDangNhap(string maNhanVien) 
        {
            try
            {
                NhanVien nhanvien = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == maNhanVien);
                nhanvien.tenLoaiNhanVien = db.LoaiNhanViens.Where(lnv => lnv.maLoaiNhanVien == nhanvien.maLoaiNhanVien).Select(lnv => lnv.tenLoaiNhanVien).FirstOrDefault();
                return nhanvien;
            }
            catch
            {
                return null;
            }
        }
        public NhanVien LayTTNhanVienTuMa(string ma)
        {
            try
            {
                NhanVien nhanVien = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == ma);
                nhanVien.tenLoaiNhanVien = db.LoaiNhanViens.Where(lnv => lnv.maLoaiNhanVien == nhanVien.maLoaiNhanVien).Select(lnv => lnv.tenLoaiNhanVien).FirstOrDefault();
                return nhanVien;
            }
            catch
            {
                return null;
            }
        }
        public List<NhanVien> LoadNhanVien()
        {
            var nhanViens = (from nv in db.NhanViens
                             join loainv in db.LoaiNhanViens on nv.maLoaiNhanVien equals loainv.maLoaiNhanVien
                             select nv).ToList();
            foreach (var nv in nhanViens)
            {
                var loainv = db.LoaiNhanViens.FirstOrDefault(lnv => lnv.maLoaiNhanVien == nv.maLoaiNhanVien);
                if (loainv != null)
                {
                    nv.tenLoaiNhanVien = loainv.tenLoaiNhanVien;
                }
            }
            return nhanViens;
        }
        public bool IsTaiKhoanDuplicate(string tk)
        {
            return LoadNhanVien().Any(nv => nv.tenDangNhap.Equals(tk, StringComparison.OrdinalIgnoreCase));
        }
        public bool IsSDTDuplicate(string sdt)
        {
            return LoadNhanVien().Any(nv => nv.soDienThoai.Equals(sdt, StringComparison.OrdinalIgnoreCase));
        }
        public string GenerateNewEmployeeCode()
        {
            // Tìm mã nhân viên lớn nhất trong bảng
            var maxMaNV = db.NhanViens
                .Where(x => x.maNhanVien.StartsWith("NV"))
                .Select(x => x.maNhanVien)
                .ToList(); // Chuyển đổi thành danh sách

            // Nếu không có mã nào, bắt đầu từ "NV0001"
            var newMaNV = "NV0001"; // Mã khởi tạo mặc định
            if (maxMaNV.Count > 0)
            {
                // Lấy mã lớn nhất
                var maxCode = maxMaNV.Max();

                // Kiểm tra xem mã nhân viên lớn nhất có vượt quá NV9999 không
                var numericPart = int.Parse(maxCode.Substring(2)); // Lấy phần số (bỏ 2 ký tự "NV")
                if (numericPart >= 9999)
                {
                    // Nếu đã đạt đến giới hạn NV9999, thông báo lỗi
                    throw new Exception("Số lượng nhân viên đã đạt đến giới hạn NV9999.");
                }

                // Tạo mã mới với 4 chữ số
                newMaNV = "NV" + (numericPart + 1).ToString("D4");
            }

            return newMaNV;
        }
        public bool InsertNhanVien(NhanVien nv)
        {
            try
            {
                // Sinh mã nhân viên mới
                nv.maNhanVien = GenerateNewEmployeeCode();

                // Thêm nhân viên vào cơ sở dữ liệu
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Ghi lại lỗi vào log hoặc thông báo
                Debug.WriteLine("Thêm thất bại: " + ex.Message);
                throw new Exception("Thêm thất bại: " + ex.Message);
            }
        }
        public bool DeleteNhanVien(string manv)
        {
            try
            {
                var nv = db.NhanViens.FirstOrDefault(n => n.maNhanVien == manv);
                if (nv != null)
                {
                    db.NhanViens.DeleteOnSubmit(nv);
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
        public bool UpdateNhanVien(NhanVien nv)
        {
            try
            {
                var exnv = db.NhanViens.FirstOrDefault(n => n.maNhanVien == nv.maNhanVien);
                if (exnv != null)
                {
                    exnv.maNhanVien = nv.maNhanVien;
                    exnv.tenNhanVien = nv.tenNhanVien;
                    exnv.diaChi = nv.diaChi;
                    exnv.ngaySinh = nv.ngaySinh;
                    exnv.soDienThoai = nv.soDienThoai;
                    exnv.luongCoBan = nv.luongCoBan;
                    exnv.ngayVaoLam = nv.ngayVaoLam;
                    exnv.tenDangNhap = nv.tenDangNhap;
                    exnv.matKhau = nv.matKhau;
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
        public List<NhanVien> SearchNhanVien(string keyword)
        {
            // Kiểm tra từ khóa có phải null hay không
            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu không có từ khóa, trả về tất cả loại nhân viên
                return LoadNhanVien();
            }

            // Tìm kiếm nhân viên 
            var filteredNhanVien = LoadNhanVien().Where(nv => (nv.tenNhanVien != null && nv.tenNhanVien.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                     (nv.soDienThoai != null && nv.soDienThoai.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                     (nv.diaChi != null && nv.diaChi.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();

            return filteredNhanVien;
        }
        public string GetPhoneNumberById(string maNhanVien)
        {
            try
            {
                var nhanVien = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == maNhanVien);

                if (nhanVien != null)
                {

                    return nhanVien.soDienThoai;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        public int TongSoLuongNhanVien()
        {
            return db.NhanViens.Count();
        }
    }
}
