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
        public bool XoaNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                NhaCungCap nccDeleted = db.NhaCungCaps.Where(nhaCC => nhaCC.maNhaCungCap == ncc.maNhaCungCap).Select(nhaCC => nhaCC).First();
                db.NhaCungCaps.DeleteOnSubmit(nccDeleted);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            try
            {
                NhaCungCap nccEdited = db.NhaCungCaps.Where(nhaCC => nhaCC.maNhaCungCap == ncc.maNhaCungCap).Select(nhaCC => nhaCC).First();
                nccEdited.tenNhaCungCap = ncc.tenNhaCungCap;
                nccEdited.diaChi = ncc.diaChi;
                nccEdited.email = ncc.email;
                nccEdited.soDienThoai = ncc.soDienThoai;
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
