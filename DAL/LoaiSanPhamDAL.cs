using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LoaiSanPhamDAL
    {
        private MeVaBeDBDataContext dBDataContext;
        public LoaiSanPhamDAL()
        {
            this.dBDataContext = new MeVaBeDBDataContext();
        }
        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            return dBDataContext.LoaiSanPhams.Select(lsp => lsp).ToList<LoaiSanPham>();
        }
    }
}
