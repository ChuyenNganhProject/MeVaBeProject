using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public SanPhamDAL()
        {

        }

        public List<SanPham> LoadSanPhamByLoaiSp(LoaiSanPham loaisp)
        {
            var listSp = db.SanPhams.Where(sp => sp.maLoaiSanPham == loaisp.maLoaiSanPham).Select(sp => sp).ToList();
            return listSp;
        }

        public SanPham LaySanPhamTheoMa(string ma)
        {
            try
            {
                SanPham sanPham = db.SanPhams.FirstOrDefault(sp => sp.maSanPham == ma);
                return sanPham;
            }
            catch 
            {
                return null;
            }
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
                foreach (var ch in dau.Skip(1))
                {
                    input = input.Replace(ch, dau[0]);
                }
            }

            return input;
        }

        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        {
            if(string.IsNullOrWhiteSpace(tenHoacMaTimKiem))
            {
                return db.SanPhams.ToList(); 
            }

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
