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

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            return nccdal.ThemNhaCungCap(ncc);
        }

        public List<NhaCungCap> LoadNhaCungCap()
        {
            return nccdal.LoadNhaCungCap();
        }
    }
}
