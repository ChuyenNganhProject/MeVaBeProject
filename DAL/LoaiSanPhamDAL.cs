using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public LoaiSanPhamDAL() { }

        public List<LoaiSanPham> LoadLoaiSanPham()
        {
            return db.LoaiSanPhams.Select(loai => loai).ToList<LoaiSanPham>();
        }

        public LoaiSanPham LayTTLoaiSpTuMaLoaiSp(string ma)
        {
            try
            {
                LoaiSanPham loaisp = db.LoaiSanPhams.FirstOrDefault(lsp => lsp.maLoaiSanPham == ma);
                return loaisp;
            }
            catch
            {
                return null;
            }
        }
    }
}
