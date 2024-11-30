using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ChiTietQuyenCuaLoaiNVDAL
    {
        private MeVaBeDBDataContext dataContext;
        public ChiTietQuyenCuaLoaiNVDAL() 
        { 
            dataContext = new MeVaBeDBDataContext();
        }
        public List<ChiTietQuyenCuaLoaiNhanVien> LayDanhSachQuyenCuaLoaiNhanVien(string maLoaiNV)
        {
            List<ChiTietQuyenCuaLoaiNhanVien>  danhSach = dataContext.ChiTietQuyenCuaLoaiNhanViens.Where(ct => ct.maLoaiNhanVien == maLoaiNV).ToList();
            foreach (ChiTietQuyenCuaLoaiNhanVien item in danhSach)
            {
                item.tenQuyen = dataContext.QuyenHeThongs.Where(q => q.maQuyen == item.maQuyen).Select(q => q.tenQuyen).FirstOrDefault();
                item.tenLoaiNhanVien = dataContext.LoaiNhanViens.Where(q => q.maLoaiNhanVien == item.maLoaiNhanVien).Select(q => q.tenLoaiNhanVien).FirstOrDefault();
            }
            return danhSach;
        }
        public ChiTietQuyenCuaLoaiNhanVien TimQuyenCuaNhanVien(string maLoaiNV,string maQuyen)
        {
            return dataContext.ChiTietQuyenCuaLoaiNhanViens.Where(ct => ct.maLoaiNhanVien == maLoaiNV && ct.maQuyen == maQuyen).FirstOrDefault();
        }
        public bool TaoChiTietQuyenCuaLoaiNhanVien(ChiTietQuyenCuaLoaiNhanVien pQuyen)
        {
            try
            {
                dataContext.ChiTietQuyenCuaLoaiNhanViens.InsertOnSubmit(pQuyen);
                dataContext.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaChiTietQuyenCuaLoaiNhanVien(ChiTietQuyenCuaLoaiNhanVien pQuyen)
        {
            try
            {
                ChiTietQuyenCuaLoaiNhanVien deleted = dataContext.ChiTietQuyenCuaLoaiNhanViens.Where(ct => ct.maLoaiNhanVien == pQuyen.maLoaiNhanVien && ct.maQuyen == pQuyen.maQuyen).FirstOrDefault();
                dataContext.ChiTietQuyenCuaLoaiNhanViens.DeleteOnSubmit(deleted);
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
