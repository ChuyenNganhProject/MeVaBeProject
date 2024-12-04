using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhieuThanhLyDAL
    {
        private MeVaBeDBDataContext _db;
        public PhieuThanhLyDAL()
        {
            this._db = new MeVaBeDBDataContext();
        }
        public PhieuThanhLy TimPhieuThanhLy(string maPhieu)
        {
            return _db.PhieuThanhLies.Where(p=>p.maThanhLy== maPhieu).FirstOrDefault();
        }
        public string TaoMaPhieuThanhLy()
        {
            string maPhieuThanhLy = _db.PhieuThanhLies.OrderByDescending(pd => pd.maThanhLy).Select(pd => pd.maThanhLy).FirstOrDefault();
            if (maPhieuThanhLy != null)
            {
                return maPhieuThanhLy;
            }
            return "PTL000000000";
        }
        public bool TaoPhieuThanhLy(PhieuThanhLy pPhieuThanhLy)
        {
            try
            {
                _db.PhieuThanhLies.InsertOnSubmit(pPhieuThanhLy);
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
