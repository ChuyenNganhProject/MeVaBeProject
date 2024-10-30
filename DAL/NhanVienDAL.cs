using System;
using System.Collections.Generic;
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
            var nhanVien = db.NhanViens.SingleOrDefault(nv => nv.tenDangNhap == username&& nv.matKhau == hashedPassword);
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

        public List<NhanVien> LoadNhanVien()
        {
            var nhanViens = (from nv in db.NhanViens 
                            join loainv in db.LoaiNhanViens on nv.maLoaiNhanVien equals loainv.maLoaiNhanVien
                            select nv).ToList();
            foreach(var nv in nhanViens)
            {
                var loainv = db.LoaiNhanViens.FirstOrDefault(lnv => lnv.maLoaiNhanVien == nv.maLoaiNhanVien);
                if(loainv != null)
                {
                    nv.tenLoaiNhanVien = loainv.tenLoaiNhanVien;
                }
            }
            return nhanViens;
        }
    }
}
