using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LoaiSanPhamDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public LoaiSanPhamDAL() { }

        public List<LoaiSanPham> LoadLoaiSanPham()
        {
            return db.LoaiSanPhams.Where(loai=>loai.maLoaiSanPham != "LSP001").Select(loai => loai).ToList<LoaiSanPham>();
        }
        public int DemSoSanPhamThuocLoai(string maLoaiSanPham)
        {
            return db.SanPhams.Where(sp => sp.maLoaiSanPham == maLoaiSanPham).Count();
        }
        public LoaiSanPham LayTTLoaiSpTuMaLoaiSp(string ma)
        {
            try
        {
                LoaiSanPham loaisp = db.LoaiSanPhams.FirstOrDefault(lsp => lsp.maLoaiSanPham == ma);
                return loaisp;
        }
            catch
        {
                return null;
            }
        }
        public string TaoMaLoaiSanPham()
        {
            string maLoaiSP = db.LoaiSanPhams.OrderByDescending(lsp=>lsp.maLoaiSanPham).Select(lsp=>lsp.maLoaiSanPham).FirstOrDefault();
            if (maLoaiSP == null)
            {
                return "LSP000";
            }
            return maLoaiSP;
        }
        public bool ThemLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            try
            {
                db.LoaiSanPhams.InsertOnSubmit(pLoaiSP);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SuaLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            try
            {
                LoaiSanPham loaiSPEdited = db.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == pLoaiSP.maLoaiSanPham).FirstOrDefault();
                loaiSPEdited.tenLoaiSanPham = pLoaiSP.tenLoaiSanPham;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool XoaLoaiSanPham(LoaiSanPham pLoaiSP)
        {
            try
            {
                LoaiSanPham loaiSPDeleted = db.LoaiSanPhams.Where(lsp => lsp.maLoaiSanPham == pLoaiSP.maLoaiSanPham).FirstOrDefault();
                db.LoaiSanPhams.DeleteOnSubmit(loaiSPDeleted);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
