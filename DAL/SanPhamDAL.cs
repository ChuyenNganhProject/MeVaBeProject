using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class SanPhamDAL
    {
        private MeVaBeDBDataContext dataContext;
        public SanPhamDAL()
        {
            this.dataContext = new MeVaBeDBDataContext();
        }
        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> danhSachSanPham= dataContext.SanPhams.Select(sp => sp).ToList<SanPham>();
            foreach(SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp=>sp.maLoaiSanPham==maLoai).Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            SanPham sp = dataContext.SanPhams.Where(sanPham => sanPham.maSanPham == maSP).Select(sanPham => sanPham).FirstOrDefault();
            sp.tenLoaiSanPham= dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            return sp;
        }
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.tenSanPham.Contains(tenSP)).Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
    }
}
