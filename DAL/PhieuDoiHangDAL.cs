using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuDoiHangDAL
    {
        private MeVaBeDBDataContext _db;
        public PhieuDoiHangDAL()
        {
            this._db = new MeVaBeDBDataContext();
        }
        public string TaoMaPhieuDoiHang()
        {
            string maPhieuDoi = _db.PhieuDoiHangs.OrderByDescending(pd => pd.maPhieuDoi).Select(pd => pd.maPhieuDoi).FirstOrDefault();
            if (maPhieuDoi != null)
            {
                return maPhieuDoi;
            }
            return "PDH000000000";
        }
        public PhieuDoiHang TimPhieuDoi(string maPhieuDoi)
        {
            return _db.PhieuDoiHangs.Where(pd => pd.maPhieuDoi == maPhieuDoi).FirstOrDefault();
        }
        public bool TaoPhieuDoiHang(PhieuDoiHang pPhieuDoiHang)
        {
            try
            {
                _db.PhieuDoiHangs.InsertOnSubmit(pPhieuDoiHang);
                _db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
