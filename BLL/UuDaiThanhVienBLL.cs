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
        public string TaoMaUuDai()
        {
            string maUuDai = uuddal.TaoMaUuDai();
            string prefixPart = maUuDai.Substring(0, 2);
            string numberPart = maUuDai.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newNumberPart = number.ToString("D" + numberPart.Length);
            string newMaUuDai = prefixPart + newNumberPart;
            return newMaUuDai;
        }
        public UuDaiThanhVien LayUuDaiCuaHang(string maHang)
        {
            return uuddal.LayUuDaiCuaHang(maHang);
        }
        public bool TaoUuDai(UuDaiThanhVien pUuDai)
        {
            return uuddal.TaoUuDai(pUuDai);
        }
        public bool SuaUuDai(UuDaiThanhVien pUuDai)
        {
            return uuddal.SuaUuDai(pUuDai);
        }
    }
}
