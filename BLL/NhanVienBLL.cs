using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvdal = new NhanVienDAL();
        public NhanVienBLL()
        {

        }
        public string MaHoaMatKhauKieuSha256Hash(string pass)
        {
            return nvdal.MaHoaMatKhauKieuSha256Hash(pass);

        }
        public NhanVien DangNhap(string username, string pass)
        {
            return nvdal.DangNhap(username, pass);
        }

        public List<NhanVien> LoadNhanVien()
        {
            return nvdal.LoadNhanVien(); 
        }

        public NhanVien LayTTNhanVienTuTenDangNhap(string maNhanVien)
        {
            try
            {
                return nvdal.LayTTNhanVienTuTenDangNhap(maNhanVien);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy thông tin nhân viên", ex);
            }
        }

        public NhanVien LayTTNhanVienTuMa(string ma)
        {
            return nvdal.LayTTNhanVienTuMa(ma);
        }
        public bool IsTaiKhoanDuplicate(string tk)
        {
            return nvdal.IsTaiKhoanDuplicate(tk);
        }
        public bool IsSDTDuplicate(string sdt)
        {
            return nvdal.IsSDTDuplicate(sdt);
        }
        public bool InsertNhanVien(NhanVien nv)
        {
            return nvdal.InsertNhanVien(nv);
        }
        public bool DeleteNhanVien(string nv)
        {
            return nvdal.DeleteNhanVien(nv);
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            return nvdal.UpdateNhanVien(nv);
        }
        public List<NhanVien> SearchNhanVien(string nv)
        {
            return nvdal.SearchNhanVien(nv);
        }
        public string GetPhoneNumberById(string maNhanVien)
        {
            return nvdal.GetPhoneNumberById(maNhanVien);
        }

        public int TongSoLuongNhanVien()
        {
            return nvdal.TongSoLuongNhanVien();
        }
    }
}
