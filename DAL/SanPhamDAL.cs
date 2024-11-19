using System;
using System.Collections.Generic;
using System.Data.Linq;
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
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }

        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.maLoaiSanPham == maLoai).Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();

            }
            return danhSachSanPham;
        }
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            SanPham sp = dataContext.SanPhams.Where(sanPham => sanPham.maSanPham == maSP).Select(sanPham => sanPham).FirstOrDefault();
            sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
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

        // Nhật
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
            if (string.IsNullOrWhiteSpace(tenHoacMaTimKiem))
            {
                return dataContext.SanPhams.ToList();
            }

            var listSp = dataContext.SanPhams.ToList();
            string normalizedTenTimKiem = RemoveVietnameseDaus(tenHoacMaTimKiem.ToLower());

            var listSpLoc = listSp.Where(sp =>
                RemoveVietnameseDaus(sp.tenSanPham.ToLower()).Contains(normalizedTenTimKiem) ||
                RemoveVietnameseDaus(sp.maSanPham.ToLower()).Contains(normalizedTenTimKiem))
                .ToList();
            return listSpLoc;
        }

        public bool CapNhatSanPham(SanPham sanPham)
        {
            try
            {
                SanPham updatedSanPham = dataContext.SanPhams.FirstOrDefault(sp => sp.maSanPham == sanPham.maSanPham);
                if (updatedSanPham != null)
                {
                    updatedSanPham.tenSanPham = sanPham.tenSanPham;
                    updatedSanPham.donGiaBan = sanPham.donGiaBan;
                    updatedSanPham.donGiaSale = sanPham.donGiaSale;
                    updatedSanPham.hanSuDung = sanPham.hanSuDung;
                    updatedSanPham.hinhAnh = sanPham.hinhAnh;
                    updatedSanPham.ngaySanXuat = sanPham.ngaySanXuat;
                    updatedSanPham.soLuong = sanPham.soLuong;
                    updatedSanPham.trangThai = sanPham.trangThai;
                    
                    dataContext.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi sửa thông tin sản phẩm: " + ex.Message, ex);
            }
        }
    }
}


