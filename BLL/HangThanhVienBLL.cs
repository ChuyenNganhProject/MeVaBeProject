using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HangThanhVienBLL
    {
        HangThanhVienDAL hdal = new HangThanhVienDAL();
        public HangThanhVienBLL() { }
        public string GetMaHangThanhVienTheoDiemTichLuy(decimal diemTichLuy)
        {
            return hdal.GetMaHangThanhVienTheoDiemTichLuy(diemTichLuy);
        }
    }
}
