using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class PhieuDoiHangBLL
    {
        private PhieuDoiHangDAL phieuDoiHangDAL;
        public PhieuDoiHangBLL()
        {
            this.phieuDoiHangDAL = new PhieuDoiHangDAL();
        }
        public string TaoMaPhieuDoiHang()
        {
            string maPhieuDoi = phieuDoiHangDAL.TaoMaPhieuDoiHang();
            string prefixPart = maPhieuDoi.Substring(0, 3);
            string numberPart = maPhieuDoi.Substring(3);
            int number = int.Parse(numberPart) + 1;
            string newNumberPart = number.ToString("D" + numberPart.Length);
            string newMaPhieuDoi = prefixPart + newNumberPart;
            return newMaPhieuDoi;
        }
        public PhieuDoiHang TimPhieuDoi(string maPhieuDoi)
        {
            return phieuDoiHangDAL.TimPhieuDoi(maPhieuDoi);
        }
        public bool TaoPhieuDoiHang(PhieuDoiHang pPhieuDoi)
        {
            return phieuDoiHangDAL.TaoPhieuDoiHang(pPhieuDoi);
        }
    }
}
