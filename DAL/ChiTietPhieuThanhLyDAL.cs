using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietPhieuThanhLyDAL
    {
        private MeVaBeDBDataContext _db;
        public ChiTietPhieuThanhLyDAL()
        {
            this._db = new MeVaBeDBDataContext();
        }
        public List<ChiTietPhieuThanhLy> LayChiTietPhieuThanhLy(string maPhieuThanhLy)
        {
            List < ChiTietPhieuThanhLy > danhSach = _db.ChiTietPhieuThanhLies.Where(ct => ct.maThanhLy == maPhieuThanhLy).ToList();
            foreach (ChiTietPhieuThanhLy item in danhSach)
            {
                item.tenSanPham = _db.SanPhams.Where(sp => sp.maSanPham == item.maSanPham).Select(sp=>sp.tenSanPham).FirstOrDefault();
            }
            return danhSach;
        }
        public bool TaoChiTietPhieuThanhLy(ChiTietPhieuThanhLy pCTPhieuThanhLy)
        {
            try
            {
                _db.ChiTietPhieuThanhLies.InsertOnSubmit(pCTPhieuThanhLy);
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
