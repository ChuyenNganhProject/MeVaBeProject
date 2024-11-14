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

        public List<SanPham> LoadSanPhamByLoaiSp(LoaiSanPham loaisp)
        {
            List<SanPham> danhSachSanPham= dataContext.SanPhams.Select(sp => sp).ToList<SanPham>();
            foreach(SanPham sp in danhSachSanPham)
            var listSp = db.SanPhams.Where(sp => sp.maLoaiSanPham == loaisp.maLoaiSanPham).Select(sp => sp).ToList();
            return listSp;
        }

        public SanPham LaySanPhamTheoMa(string ma)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            try
            {
                SanPham sanPham = db.SanPhams.FirstOrDefault(sp => sp.maSanPham == ma);
                return sanPham;
            }
            return danhSachSanPham;
            catch 
            {
                return null;
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        }

        public List<SanPham> LoadTatCaSanPham()
        {
            var listSp = db.SanPhams.Select(sp => sp).ToList();
            return listSp;
        }

        public static string RemoveVietnameseDaus(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            string[] daus = new string[]
            {
                "aáàảãạăắằẳẵặâấầẩẫậ", "AÁÀẢÃẠĂẮẰẲẴẶÂẤẦẨẪẬ",
                "dđ", "DĐ",
                "eéèẻẽẹêếềểễệ", "EÉÈẺẼẸÊẾỀỂỄỆ",
                "iíìỉĩị", "IÍÌỈĨỊ",
                "oóòỏõọôốồổỗộơớờởỡợ", "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ",
                "uúùủũụưứừửữự", "UÚÙỦŨỤƯỨỪỬỮỰ",
                "yýỳỷỹỵ", "YÝỲỶỸỴ"
            };

            foreach (var dau in daus)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp=>sp.maLoaiSanPham==maLoai).Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
                foreach (var ch in dau.Skip(1))
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    input = input.Replace(ch, dau[0]);
            }
            return danhSachSanPham;
        }
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            SanPham sp = dataContext.SanPhams.Where(sanPham => sanPham.maSanPham == maSP).Select(sanPham => sanPham).FirstOrDefault();
            sp.tenLoaiSanPham= dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            return sp;

            return input;
        }
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)

        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.tenSanPham.Contains(tenSP)).Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            if(string.IsNullOrWhiteSpace(tenHoacMaTimKiem))
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                return db.SanPhams.ToList(); 
            }
            return danhSachSanPham;

            var listSp = db.SanPhams.ToList();
            string normalizedTenTimKiem = RemoveVietnameseDaus(tenHoacMaTimKiem.ToLower());

            var listSpLoc = listSp.Where(sp => 
                RemoveVietnameseDaus(sp.tenSanPham.ToLower()).Contains(normalizedTenTimKiem) ||
                RemoveVietnameseDaus(sp.maSanPham.ToLower()).Contains(normalizedTenTimKiem))
                .ToList();
            return listSpLoc;
        }
    }
}
