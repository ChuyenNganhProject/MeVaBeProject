using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LoaiSanPhamBLL
    {
        LoaiSanPhamDAL lspdal = new LoaiSanPhamDAL();
        public LoaiSanPhamBLL() { }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            return lspdal.LoadLoaiSanPham();
        }

        public LoaiSanPham LayTTLoaiSpTuMaLoaiSp(string ma)
        {
            return lspdal.LayTTLoaiSpTuMaLoaiSp(ma);
        }
        public string TaoMaLoaiSanPham()
        {
            string maLoaiSP = lspdal.TaoMaLoaiSanPham();
            string prefixPart = maLoaiSP.Substring(0, 3);
            string numberPart = maLoaiSP.Substring(3);
            int number = int.Parse(numberPart) + 1;
            string newNumberPart = number.ToString("D" + numberPart.Length);
            string newMaLoaiSP = prefixPart + newNumberPart;
            return newMaLoaiSP;

        }
        public bool ThemLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            return lspdal.ThemLoaiSanPham(pLoaiSP);
        }
        public bool SuaLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            return lspdal.SuaLoaiSanPham(pLoaiSP);
        }
        public bool XoaLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            return lspdal.XoaLoaiSanPham(pLoaiSP);
        }
    }
}
