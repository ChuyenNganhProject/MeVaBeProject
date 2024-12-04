using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class PhieuThanhLyBLL
    {
        private PhieuThanhLyDAL phieuThanhLyDAL;
        public PhieuThanhLyBLL()
        {
            this.phieuThanhLyDAL = new PhieuThanhLyDAL();
        }
        public PhieuThanhLy TimPhieuThanhLy(string maPhieu)
        {
            return phieuThanhLyDAL.TimPhieuThanhLy(maPhieu);
        }
        public string TaoMaPhieuThanhLy()
        {
            string maPhieuThanhLy = phieuThanhLyDAL.TaoMaPhieuThanhLy();
            string prefixPart = maPhieuThanhLy.Substring(0, 3);
            string numberPart = maPhieuThanhLy.Substring(3);
            int number = int.Parse(numberPart) + 1;
            string newNumberPart = number.ToString("D" + numberPart.Length);
            string newMaPhieuThanhLy = prefixPart + newNumberPart;
            return newMaPhieuThanhLy;
        }
        public bool TaoPhieuThanhLy(PhieuThanhLy pPhieuThanhLy)
        {
            return phieuThanhLyDAL.TaoPhieuThanhLy(pPhieuThanhLy);
        }
    }
}
