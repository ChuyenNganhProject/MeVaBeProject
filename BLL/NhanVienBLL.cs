﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nvdal = new NhanVienDAL();
        public NhanVienBLL()
        {

        }

        public NhanVien DangNhap(string username, string pass)
        {
            return nvdal.DangNhap(username, pass);
        }

        public List<NhanVien> LoadNhanVien()
        {
            return nvdal.LoadNhanVien(); 
        }

        public NhanVien LayTTNhanVienTuTenDangNhap(string maNhanVien)
        {
            try
            {
                return nvdal.LayTTNhanVienTuTenDangNhap(maNhanVien);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Lỗi khi lấy thông tin nhân viên", ex);
            }
        }

        public NhanVien LayTTNhanVienTuMa(string ma)
        {
            return nvdal.LayTTNhanVienTuMa(ma);
        }
    }
}
