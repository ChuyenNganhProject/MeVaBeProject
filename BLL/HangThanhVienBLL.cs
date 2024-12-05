using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class HangThanhVienBLL
    {
        HangThanhVienDAL hdal = new HangThanhVienDAL();
        public HangThanhVienBLL() { }
        public string GetMaHangThanhVienTheoDiemTichLuy(decimal diemTichLuy)
        {
            return hdal.GetMaHangThanhVienTheoDiemTichLuy(diemTichLuy);
        }

        public List<HangThanhVien> SearchHangTV(string keyword)
        {
            return hdal.SearchHangTV(keyword);
        }
        public List<HangThanhVien> LoadHangTV()
        {

            return hdal.LoadHangTV();
        }
        public bool InsertHangTV(HangThanhVien htv)
        {
            return hdal.InsertHangTV(htv);

        }
        public bool DeleteHangTV(string maH, out string hienthiloi)
        {
            return hdal.DeleteHangTV(maH, out hienthiloi);
        }
        public bool DeleteHangTV(string mahnv)
        {
            return hdal.DeleteHangTV(mahnv);
        }
        public bool UpdateHangTV(HangThanhVien htv)
        {
            return hdal.UpdateHangTV(htv);
        }
        public string GetTenHangTVByMa(string maHang)
        {
            return hdal.GetTenHangTVByMa(maHang);
        }
        public bool ValidateNewHang(string maHangMoi, decimal mucTieuBatDauMoi, decimal mucTieuKetThucMoi)
        {
            return hdal.ValidateNewHang(maHangMoi, mucTieuBatDauMoi, mucTieuKetThucMoi);

        }

        public string GenerateNewHangTV()
        {
            return hdal.GenerateNewHangTV();
        }
    }
}
