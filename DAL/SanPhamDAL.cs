﻿using System;
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
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
        public List<SanPham> LayDanhSachSanPham()
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp=>sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.maLoaiSanPham == maLoai && sp.trangThai == "Còn hàng").Select(sp => sp).ToList<SanPham>();
            foreach (SanPham sp in danhSachSanPham)
            {
                sp.tenLoaiSanPham = dataContext.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == sp.maLoaiSanPham).Select(lsp => lsp.tenLoaiSanPham).FirstOrDefault();
            }
            return danhSachSanPham;
        }
        public List<SanPham> LayDanhSachSanPhamTheoTrangThai(string trangThai)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.trangThai == trangThai).Select(sp => sp).ToList<SanPham>();
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
        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            List<SanPham> danhSachSanPham = dataContext.SanPhams.Where(sp => sp.tenSanPham.Contains(tuKhoa) || sp.maSanPham == tuKhoa).Select(sp => sp).ToList<SanPham>();
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
        public bool KhoiPhucSanPham(string maSanPham)
        {
            try
            {
                SanPham sanPhamEdited = dataContext.SanPhams.Where(sp => sp.maSanPham == maSanPham).FirstOrDefault();
                sanPhamEdited.trangThai = "Còn hàng";
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
                sanPhamEdited.donGiaBan = pSanPham.donGiaBan;
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
                sanPhamDeleted.trangThai = "Không tồn tại";
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
                sanPhamDeleted.trangThai = "Không tồn tại";
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}


