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
        public string TaoMaSanPham()
        {
            string maSanPham = dataContext.SanPhams.OrderByDescending(sp => sp.maSanPham).Select(sp=> sp.maSanPham).First();
            if (maSanPham == null)
            {
                return "SP000";
            }
            return maSanPham;
        }
        public List<SanPham> LayTatCaSanPham()
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham>();
            }
        }
        public List<SanPham> LayDanhSachSanPham()
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.maLoaiSanPham == maLoai && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai,decimal giaTriSanPham)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.maLoaiSanPham == maLoai && sp.donGiaBan <=giaTriSanPham && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> LayDanhSachSanPhamHetHan()
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.hanSuDung <= DateTime.Now && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> LayDanhSachSanPhamSapHetHan()
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.hanSuDung <= DateTime.Now.AddMonths(5) && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> LayDanhSachSanPhamTheoTrangThai(string trangThai)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.trangThai == trangThai).Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham>();
            }
        }
        public SanPham TimKiemSanPhamTheoMaSP(string maSP)
        {
            try
            {
                SanPham sp = dataContext.SanPhams.Where(sanPham => sanPham.maSanPham == maSP && sanPham.trangThai == "Còn hàng").Select(sanPham => sanPham).FirstOrDefault();
                if (sp != null)
                {
                    sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                }
                return sp;
            }
            catch
            {
                return new SanPham();
            }
        }
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.tenSanPham.Contains(tenSP) && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.tenSanPham.Contains(tuKhoa) || sp.maSanPham == tuKhoa).Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
        }
        public List<SanPham> TimKiemSanPham(string tuKhoa, decimal giaTriSanPham)
        {
            try
            {
                List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => (sp.tenSanPham.Contains(tuKhoa) || sp.maSanPham == tuKhoa) && sp.donGiaBan<=giaTriSanPham).Select(sp => sp).ToList<SanPham>();
                foreach (SanPham sp in danhSachSanPham)
                {
                    if (sp != null)
                    {
                        sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
                    }
                }
                return danhSachSanPham;
            }
            catch
            {
                return new List<SanPham> { };
            }
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

            var listSp = dataContext.SanPhams.Where(sanPham => sanPham.trangThai == "Còn hàng").ToList();
            if(listSp != null)
            {
                string normalizedTenTimKiem = RemoveVietnameseDaus(tenHoacMaTimKiem.ToLower());

                var listSpLoc = listSp.Where(sp =>
                    RemoveVietnameseDaus(sp.tenSanPham.ToLower()).Contains(normalizedTenTimKiem) ||
                    RemoveVietnameseDaus(sp.maSanPham.ToLower()).Contains(normalizedTenTimKiem))
                    .ToList();
                return listSpLoc;
            }
            else
            {
                return new List<SanPham>();
            }
        }

        public int TongSoLuongSanPham()
        {
            return dataContext.SanPhams.Count();
        }

        public List<SanPhamBanChay> ThongKeTop5SanPhamBanChayNhat(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            var topSanPham = dataContext.ChiTietHoaDonSanPhams
                                .Where(ct => ct.HoaDon.ngayLap.Value.Date >= ngayBatDau.Date && ct.HoaDon.ngayLap.Value.Date <= ngayKetThuc.Date)
                                .GroupBy(ct => ct.maSanPham)
                                .Select(tk => new
                                {
                                    MaSanPham = tk.Key,
                                    TongSoLuong = tk.Sum(ct => ct.soLuong)
                                })
                                .OrderByDescending(tk => tk.TongSoLuong)
                                .Take(5)
                                .Join(dataContext.SanPhams, tk => tk.MaSanPham, sp => sp.maSanPham, (tk, sp) => new SanPhamBanChay
                                {
                                    MaSanPham = sp.maSanPham,
                                    TenSanPham = sp.tenSanPham,
                                    SoLuongBan = tk.TongSoLuong.Value
                                })
                                .ToList();

            if (!topSanPham.Any())
            {
                return new List<SanPhamBanChay>();
            }
            return topSanPham;
        }        
        public bool ThemSanPham(SanPham pSanPham)
        {
            try
            {
                dataContext.SanPhams.InsertOnSubmit(pSanPham);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaSanPham(SanPham pSanPham)
        {
            try
            {
                SanPham sanPhamEdited = dataContext.SanPhams.Where(sp => sp.maSanPham == pSanPham.maSanPham).FirstOrDefault();
                sanPhamEdited.tenSanPham = pSanPham.tenSanPham;
                sanPhamEdited.maLoaiSanPham = pSanPham.maLoaiSanPham;
                sanPhamEdited.hinhAnh = pSanPham.hinhAnh;
                sanPhamEdited.ngaySanXuat = pSanPham.ngaySanXuat;
                sanPhamEdited.hanSuDung = pSanPham.hanSuDung;                
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaSanPham(SanPham pSanPham)
        {
            try
            {
                SanPham sanPhamDeleted = dataContext.SanPhams.Where(sp => sp.maSanPham == pSanPham.maSanPham).FirstOrDefault();
                dataContext.SanPhams.DeleteOnSubmit(sanPhamDeleted);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaSanPham(string maSanPham)
        {
            try
            {
                SanPham sanPhamDeleted = dataContext.SanPhams.Where(sp => sp.maSanPham == maSanPham).FirstOrDefault();
                dataContext.SanPhams.DeleteOnSubmit(sanPhamDeleted);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool KiemTraSanPhamCoThuocHoaDon(string maSanPham)
        {
            int dem = dataContext.ChiTietHoaDonSanPhams.Where(sp => sp.maSanPham == maSanPham).Count();
            if (dem>0)
            {
                return true;
            }
            return false;
        }
        public bool KiemTraSanPhamCoThuocPhieuDat(string maSanPham)
        {
            int dem = dataContext.ChiTietPhieuDats.Where(sp => sp.maSanPham == maSanPham).Count();
            if (dem > 0)
            {
                return true;
            }
            return false;
        }
        public List<(string TenSanPham, int? SoLuong)> ThongKeDanhSachSanPhamDuoiMucToiThieu()
        {
            var sanPhamDuoiMucToiThieu = dataContext.SanPhams
                                .Where(sp => sp.soLuong < 40)
                                .Select(sp => new
                                {
                                    TenSanPham = sp.tenSanPham,
                                    SoLuong = sp.soLuong
                                })
                                .ToList();

            return sanPhamDuoiMucToiThieu.Select(sp => (sp.TenSanPham, sp.SoLuong)).ToList();
        }
        public List<SanPham> LayDanhSachSanPhamTheoMucGia(decimal giaTriSanPham)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.donGiaBan <= giaTriSanPham && sp.trangThai == "Còn hàng").ToList();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
    }
}


