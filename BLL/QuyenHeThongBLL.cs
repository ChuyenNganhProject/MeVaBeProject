using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BLL;
using DAL;
namespace BLL
{
    public class QuyenHeThongBLL
    {
        private QuyenHeThongDAL quyenHeThongDAL;
        public QuyenHeThongBLL()
        {
            this.quyenHeThongDAL = new QuyenHeThongDAL();
        }
        public List<QuyenHeThong> DanhSachQuyen()
        {
            return quyenHeThongDAL.DanhSachQuyen();
        }
    }
}
