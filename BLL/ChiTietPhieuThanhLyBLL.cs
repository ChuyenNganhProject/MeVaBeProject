using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class ChiTietPhieuThanhLyBLL
    {
        private ChiTietPhieuThanhLyDAL ctPhieuThanhLyDAL;
        public ChiTietPhieuThanhLyBLL()
        {
            this.ctPhieuThanhLyDAL = new ChiTietPhieuThanhLyDAL();
        }
        public List<ChiTietPhieuThanhLy> LayChiTietPhieuThanhLy(string maPhieuThanhLy)
        {
            return ctPhieuThanhLyDAL.LayChiTietPhieuThanhLy(maPhieuThanhLy);
        }
        public bool TaoChiTietPhieuThanhLy(ChiTietPhieuThanhLy ctPhieuThanhLy)
        {
            return ctPhieuThanhLyDAL.TaoChiTietPhieuThanhLy(ctPhieuThanhLy);
        }
    }
}
