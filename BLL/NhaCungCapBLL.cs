using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL nccdal = new NhaCungCapDAL();
        public NhaCungCapBLL() { }
        public List<NhaCungCap> LoadNhaCungCap()
        {
            return nccdal.LoadNhaCungCap();
        }
        public NhaCungCap TimNhaCungCapTheoMa(string maNhaCungCap)
        {
            return nccdal.TimNhaCungCapTheoMa(maNhaCungCap);
        }
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            return nccdal.ThemNhaCungCap(ncc);
        }
        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            return nccdal.SuaNhaCungCap(ncc);
        }
        public bool XoaNhaCungCap(NhaCungCap ncc)
        {
            return nccdal.XoaNhaCungCap(ncc);
        }

        public int TongSoLuongNhaCungCap()
        {
            return nccdal.TongSoLuongNhaCungCap();
        }
    }
}
