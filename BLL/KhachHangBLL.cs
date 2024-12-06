using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL khdal = new KhachHangDAL();
        public KhachHangBLL() { }

        public bool ThemKhachHang(KhachHang kh)
        {
            return khdal.ThemKhachHang(kh);
        }
        public List<KhachHang> LoadKhachHang()
        {
            return khdal.LoadKhachHang();
        }
        public List<KhachHang> SearchKhachHang(string keyword)
        {
            return khdal.SearchKhachHang(keyword);
        }
        public string TaoMaKhachHangTuDong()
        {
            return khdal.TaoMaKhachHangTuDong();
        }
        public KhachHang LayKhachHangTheoSoDienThoai(string sdt)
        {
            return khdal.LayKhachHangTheoSoDienThoai(sdt);
        }
        public bool IsSDTDuplicate(string sdt)
        {
            return khdal.IsSDTDuplicate(sdt);
        }
        public string GetTenHangFromMaHang(string maHang)
        {
            return khdal.GetTenHangFromMaHang(maHang);
        }
        public bool CapNhatKhachHang(KhachHang khachhang)
        {
            return khdal.CapNhatKhachHang(khachhang);
        }
        public bool DeleteKhachHang(string khId)
        {
            return khdal.DeleteKhachHang(khId);
        }

        public KhachHang LayKHTheoMa(string ma)
        {
            return khdal.LayKHTheoMa(ma);
        }

        public int TongSoKhachHang()
        {
            return khdal.TongSoKhachHang();
        }
        
        public string GetPhoneNumberById(string maKH)
        {
            return khdal.GetPhoneNumberById(maKH);
        }

        public List<string> LoadDSSoDienThoai()
        {
            return khdal.LoadDSSoDienThoai();
        }
    }
}
