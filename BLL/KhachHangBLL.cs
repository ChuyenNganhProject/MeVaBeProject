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

        public string TaoMaKhachHangTuDong()
        {
            return khdal.TaoMaKhachHangTuDong();
        }
        public KhachHang LayKhachHangTheoSoDienThoai(string sdt)
        {
            return khdal.LayKhachHangTheoSoDienThoai(sdt);
        }

        public bool CapNhatKhachHang(KhachHang khachhang)
        {
            return khdal.CapNhatKhachHang(khachhang);
        }

        public KhachHang LayKHTheoMa(string ma)
        {
            return khdal.LayKHTheoMa(ma);
        }

        public int TongSoKhachHang()
        {
            return khdal.TongSoKhachHang();
        }
    }
}
