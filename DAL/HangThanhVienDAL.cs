using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangThanhVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public HangThanhVienDAL() { }

        public string GetMaHangThanhVienTheoDiemTichLuy(decimal diemTichLuy)
        {
            var hangThanhVien = db.HangThanhViens
                .Where(h => h.mucTieuBatDau <= diemTichLuy && (diemTichLuy <= h.mucTieuKetThuc || h.mucTieuKetThuc == null)) // GOLD || DIAMOND
                .FirstOrDefault();
            return hangThanhVien != null ? hangThanhVien.maHang : "MEMBER";
        }
    }
}
