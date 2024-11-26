using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL spdal = new SanPhamDAL();
        LoaiSanPhamDAL lspdal = new LoaiSanPhamDAL();
        public SanPhamBLL() { }
        public List<SanPham> LayTatCaSanPham()
        {
            return spdal.LayTatCaSanPham();
        }
        public List<SanPham> LayDanhSachSanPham()
        {
            return spdal.LayDanhSachSanPham();
        }
        public string TaoMaSanPham()
        {
            string maSanPham = spdal.TaoMaSanPham();
            string prefixPart = maSanPham.Substring(0, 2);
            string numberPart = maSanPham.Substring(2);
            int number = int.Parse(numberPart) + 1;
            string newNumberPart = number.ToString("D" + numberPart.Length);
            string newMaSanPham = prefixPart + newNumberPart;
            return newMaSanPham;
        }
        public SanPham TimKiemSanPhamTheoMaSP(string ma)
        {
            return spdal.TimKiemSanPhamTheoMaSP(ma);
        }
        public List<SanPham> TimKiemSanPham(string tuKhoa)
        {
            return spdal.TimKiemSanPham(tuKhoa);
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {            
            return spdal.LayDanhSachSanPhamTheoMaLoai(maLoai);
        }
        public List<SanPham> LayDanhSachSanPhamTheoTrangThai(string trangThai)
        {
            return spdal.LayDanhSachSanPhamTheoTrangThai(trangThai);
        }
        public List<SanPham> LoadTatCaSanPham()
        {
            return spdal.LayDanhSachSanPham();
        }
        public List<SanPham> LoadSpTheoTenHoacMaSp(string tenHoacMaTimKiem)
        {
            return spdal.LoadSpTheoTenHoacMaSp(tenHoacMaTimKiem);
        }    
        public List<SanPham> TimKiemSanPhamTheoTenSP(string tenSP)
        {
            return spdal.TimKiemSanPhamTheoTenSP(tenSP);
        }

        public int TongSoLuongSanPham()
        {
            return spdal.TongSoLuongSanPham();
        }

        public Dictionary<string, (string TenSanPham, int? SoLuongBan)> ThongKeTop5SanPhamBanChayNhat(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return spdal.ThongKeTop5SanPhamBanChayNhat(ngayBatDau, ngayKetThuc);
        }

        public List<(string TenSanPham, int? SoLuong)> ThongKeDanhSachSanPhamDuoiMucToiThieu()
        {
            return spdal.ThongKeDanhSachSanPhamDuoiMucToiThieu();
        }
        public bool ThemSanPham(SanPham pSanPham)
        {
            return spdal.ThemSanPham(pSanPham);
        }
        public bool KhoiPhucSanPham(string maSanPham)
        {
            return spdal.KhoiPhucSanPham(maSanPham);
        }
        public bool SuaSanPham(SanPham pSanPham)
        {
            return spdal.SuaSanPham(pSanPham);
        }
        public bool XoaSanPham(SanPham pSanPham)
        {
            return spdal.XoaSanPham(pSanPham);
        }
        public bool XoaSanPham(string maSanPham)
        {
            return spdal.XoaSanPham(maSanPham);
        }
    }
}
