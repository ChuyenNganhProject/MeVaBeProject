    using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UuDaiThanhVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public UuDaiThanhVienDAL()
        {

        }
        public decimal GetPhanTramGiam(string maHang)
        {
            var uudais = db.UuDaiThanhViens
                .Where(u => u.maHang == maHang).FirstOrDefault();
            return uudais != null ? uudais.phanTramGiam.Value : 0;
        }
        public bool CoUuDaiChoHang(string maHang)
        {
            return db.UuDaiThanhViens.Any(u => u.maHang == maHang);
        }
        public string TaoMaUuDai()
        {
            string maUuDai = db.UuDaiThanhViens.OrderByDescending(ud => ud.maUuDai).Select(ud => ud.maUuDai).FirstOrDefault();
            if (maUuDai != null)
            {
                return maUuDai;
            }
            return "UD000";
        }
        public UuDaiThanhVien LayUuDaiCuaHang(string maHang)
        {
            return db.UuDaiThanhViens.Where(ud=>ud.maHang ==maHang).FirstOrDefault();
        }
        public bool TaoUuDai(UuDaiThanhVien pUuDai)
        {
            try
            {
                db.UuDaiThanhViens.InsertOnSubmit(pUuDai);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaUuDai(UuDaiThanhVien pUuDai)
        {
            try
            {
                UuDaiThanhVien uuDaiEdited = db.UuDaiThanhViens.Where(ud=>ud.maUuDai==pUuDai.maUuDai).FirstOrDefault();
                uuDaiEdited.tenUuDai = pUuDai.tenUuDai;
                uuDaiEdited.phanTramGiam = pUuDai.phanTramGiam;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
