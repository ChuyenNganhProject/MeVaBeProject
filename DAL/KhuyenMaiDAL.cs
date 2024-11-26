﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public KhuyenMaiDAL() { }

        public List<KhuyenMai> LoadDanhSachKhuyenMai()
        {
            try
            {
                return db.KhuyenMais.Select(km => km).ToList();
            }
            catch
            {
                return new List<KhuyenMai>();
            }
        }

        public KhuyenMai LayTTKhuyenMaiTuTenKM(string tenKM)
        {
            KhuyenMai khuyenMai = db.KhuyenMais.FirstOrDefault(km => km.tenKhuyenMai == tenKM);
            if (khuyenMai != null)
            {
                return khuyenMai;
            }
            return null;
        }

        public KhuyenMai LayTTKhuyenMaiTuMaKM(string maKM)
        {
            KhuyenMai khuyenMai = db.KhuyenMais.FirstOrDefault(km => km.maKhuyenMai == maKM);
            if (khuyenMai != null)
            {
                return khuyenMai;
            }
            return null;
        }

        public bool ThemChuongTrinhKhuyenMai(KhuyenMai km)
        {
            try
            {
                db.KhuyenMais.InsertOnSubmit(km);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string TaoMaKhuyenMaiTuDong()
        {
            var khuyenMais = db.KhuyenMais.ToList();
            if (khuyenMais.Any())
            {
                var chuongTrinhKhuyenMaiCuoiCung = khuyenMais.OrderByDescending(km => int.Parse(km.maKhuyenMai.Substring(2))).FirstOrDefault();

                string maKhuyenMaiCuoiCung = chuongTrinhKhuyenMaiCuoiCung.maKhuyenMai;
                int stt = int.Parse(maKhuyenMaiCuoiCung.Substring(2)) + 1;

                return "KM" + stt.ToString("D5");
            }
            return "KM00001";
        }

        public bool CapNhatKhuyenMai(KhuyenMai khuyenMai)
        {
            try
            {
                KhuyenMai updatedKhuyenMai = db.KhuyenMais.FirstOrDefault(km => km.maKhuyenMai == khuyenMai.maKhuyenMai);
                if (updatedKhuyenMai != null)
                {
                    updatedKhuyenMai.tenKhuyenMai = khuyenMai.tenKhuyenMai;
                    updatedKhuyenMai.ngayBatDau = khuyenMai.ngayBatDau;
                    updatedKhuyenMai.ngayKetThuc = khuyenMai.ngayKetThuc;
                    updatedKhuyenMai.moTa = khuyenMai.moTa;
                    updatedKhuyenMai.trangThai = khuyenMai.trangThai;

                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi sửa thông tin chương trình khuyến mãi: " + ex.Message, ex);
            }
        }

        public void UpdateTrangThaiKhuyenMai()
        {
            try
            {
                db.ExecuteCommand("EXEC sp_UpdateTrangThaiKhuyenMai");

                db.Refresh(RefreshMode.OverwriteCurrentValues, db.KhuyenMais);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi cập nhật trạng thái khuyến mãi: " + ex.Message, ex);
            }
        }
    }
}
