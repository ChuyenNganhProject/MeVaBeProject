using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuGiaoHangDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public PhieuGiaoHangDAL()
        {

        }

        public bool ThemHoacSuaPhieuGiao(PhieuGiaoHang pg)
        {
            try
            {
                var phieuGiao = db.PhieuGiaoHangs.FirstOrDefault(pgiao => pgiao.maPhieuGiao == pg.maPhieuGiao && pgiao.maNhanVien == pg.maNhanVien && pgiao.maHoaDon == pg.maHoaDon);
                if(phieuGiao == null)
                {
                    db.PhieuGiaoHangs.InsertOnSubmit(pg);
                }
                else
                {
                    phieuGiao.chiPhi = pg.chiPhi;
                    phieuGiao.tenKhachHang = pg.tenKhachHang;
                    phieuGiao.DiaChiGiaoHang = pg.DiaChiGiaoHang;
                    phieuGiao.ngayGiaoDuKien = pg.ngayGiaoDuKien;
                    phieuGiao.soDienThoai = pg.soDienThoai;
                    phieuGiao.tinhTrang = pg.tinhTrang;
                }
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

        public string TaoMaPhieuGiaoHangTuDong()
        {
            var phieuGiaoHangs = db.PhieuGiaoHangs.ToList();
            if (phieuGiaoHangs.Any())
            {
                var phieuGiaoHangCuoiCung = phieuGiaoHangs.OrderByDescending(pg => int.Parse(pg.maPhieuGiao.Substring(2))).FirstOrDefault();

                string maPhieuGiaoCuoiCung = phieuGiaoHangCuoiCung.maPhieuGiao;
                int stt = int.Parse(maPhieuGiaoCuoiCung.Substring(2)) + 1;

                return "PG" + stt.ToString("D9");
            }
            return "PG000000001";
        }

        public PhieuGiaoHang LayTTPhieuGiaoTuMaPG(string mapg)
        {
            return db.PhieuGiaoHangs.FirstOrDefault(pg => pg.maPhieuGiao == mapg);
        }
        public PhieuGiaoHang LayTTPhieuGiaoTuMaHoaDon(string mahd)
        {
            return db.PhieuGiaoHangs.FirstOrDefault(pg => pg.maHoaDon == mahd);
        }

        public bool XoaPhieuGiao(PhieuGiaoHang phieuGiaoHang)
        {
            try
            {
                db.XoaPhieuGiao_Proc(phieuGiaoHang.maPhieuGiao);
                return true;
            }
            catch { return false; }
        }

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
        public List<PhieuGiaoHang> TimKiemVaLocPhieuGiao(string tieuChi, string giaTriTimKiem, DateTime ngayBatDau, DateTime ngayKetThuc, string tinhTrang)
        {
            try
            {
                var phieugiaos = db.PhieuGiaoHangs.Where(pg => pg.ngayLap.HasValue && pg.ngayLap.Value.Date >= ngayBatDau.Date
                                            && pg.ngayLap.Value.Date <= ngayKetThuc.Date)
                                        .ToList();

                if(!string.IsNullOrEmpty(tinhTrang))
                {
                    phieugiaos = phieugiaos.Where(pg => pg.tinhTrang ==  tinhTrang).ToList();
                }
                if (!string.IsNullOrEmpty(giaTriTimKiem))
                {
                    giaTriTimKiem = RemoveVietnameseDaus(giaTriTimKiem.ToLower());
                    switch (tieuChi)
                    {
                        case "Các tiêu chí":
                            break;
                        case "Mã phiếu giao":
                            phieugiaos = phieugiaos.Where(pg => RemoveVietnameseDaus(pg.maPhieuGiao.ToLower()).Contains(giaTriTimKiem)).ToList();
                            break;
                        case "Mã hóa đơn":
                            phieugiaos = phieugiaos.Where(pg => RemoveVietnameseDaus(pg.maHoaDon.ToLower()).Contains(giaTriTimKiem)).ToList();
                            break;
                        case "Tên khách hàng":
                            phieugiaos = phieugiaos
                                .Where(pg => pg.tenKhachHang != null && RemoveVietnameseDaus(pg.tenKhachHang.ToLower())
                                .Contains(giaTriTimKiem)).ToList();
                            break;
                        case "Tên nhân viên":
                            phieugiaos = phieugiaos
                                .Where(pg => pg.tenNhanVien != null && RemoveVietnameseDaus(pg.tenNhanVien.ToLower())
                                .Contains(giaTriTimKiem)).ToList();
                            break;
                        case "Số điện thoại":
                            phieugiaos = phieugiaos
                                .Where(pg => pg.soDienThoai != null && pg.soDienThoai.Contains(giaTriTimKiem)).ToList();
                            break;
                        case "Địa chỉ":
                            phieugiaos = phieugiaos
                                .Where(pg => pg.DiaChiGiaoHang != null && RemoveVietnameseDaus(pg.DiaChiGiaoHang.ToLower())
                                .Contains(giaTriTimKiem)).ToList();
                            break;
                    }
                }
                foreach (var phieuGiao in phieugiaos)
                {
                    var nhanviens = db.NhanViens.FirstOrDefault(nv => nv.maNhanVien == phieuGiao.maNhanVien);
                    if (nhanviens != null)
                    {
                        phieuGiao.tenNhanVien = nhanviens.tenNhanVien;
                    }
                }
                return phieugiaos;
            }
            catch
            {
                return new List<PhieuGiaoHang>();
            }
        }
    }
}
