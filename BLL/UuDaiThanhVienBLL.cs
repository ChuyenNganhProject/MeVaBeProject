using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UuDaiThanhVienBLL
    {
        UuDaiThanhVienDAL uuddal = new UuDaiThanhVienDAL();
        public UuDaiThanhVienBLL() { }

        public decimal GetPhanTramGiam(string ma)
        {
            return uuddal.GetPhanTramGiam(ma);
        }

        public bool CoUuDaiChoHang(string maHang)
        {
            return uuddal.CoUuDaiChoHang(maHang);
        }
    }
}
