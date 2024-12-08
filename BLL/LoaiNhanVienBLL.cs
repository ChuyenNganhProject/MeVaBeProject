using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiNhanVienBLL
    {
        LoaiNhanVienDAL lnvdal =new LoaiNhanVienDAL();
        public List<LoaiNhanVien> LoadLoaiNhanVien()
        {
            return lnvdal.LoadLoaiNhanVien();
        }
        public bool InsertLoaiNhanVien(LoaiNhanVien lnv)
        {
            return  lnvdal.InsertLoaiNhanVien(lnv);
        }
        public bool DeleteLoaiNhanVien(string lnv)
        {
            return lnvdal.DeleteLoaiNhanVien(lnv);
        }
        public bool UpdateLoaiNhanVien(LoaiNhanVien lnv)
        {
            return lnvdal.UpdateLoaiNhanVien(lnv);
        }
        public List<LoaiNhanVien> SearchLoaiNhanVien(string lnv)
        {
            return lnvdal.SearchLoaiNhanVien(lnv);
        }
        public string GetMaLoaiNhanVienMoi()
        {
            // Lấy mã loại nhân viên mới nhất
            return lnvdal.GetMaLoaiNhanVienMoi();
        }
        public string GetTenLoaiNVByMa( string maLoaiNV)
        {
            // Lấy mã loại nhân viên mới nhất
            return lnvdal.GetTenLoaiNVByMa(maLoaiNV);
        }
        public bool IsTenLoaiNhanVienExit(string tenLNV)
        {

            return lnvdal.IsTenLoaiNhanVienExit(tenLNV);
        }
    }
}
