using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class QuyenHeThongDAL
    {
        private MeVaBeDBDataContext dataContext;
        public QuyenHeThongDAL()
        {
            dataContext = new MeVaBeDBDataContext();
        }
        public List<QuyenHeThong> DanhSachQuyen()
        {
            return dataContext.QuyenHeThongs.ToList<QuyenHeThong>();
        }
    }
}
