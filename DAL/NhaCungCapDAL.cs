using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public NhaCungCapDAL() { }

        public List<NhaCungCap> LoadNhaCungCap()
        {
            return db.NhaCungCaps.Select(ncc => ncc).ToList<NhaCungCap>();
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                db.NhaCungCaps.InsertOnSubmit(ncc);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
