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

        public List<SanPham> LayDanhSachSanPham()
        {
            return spdal.LayDanhSachSanPham();
        }

        public SanPham TimKiemSanPhamTheoMaSP(string ma)
        {
            return spdal.TimKiemSanPhamTheoMaSP(ma);
        }
        public List<SanPham> LayDanhSachSanPhamTheoMaLoai(string maLoai)
        {
            
            return spdal.LayDanhSachSanPhamTheoMaLoai(maLoai);
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
    }
}
