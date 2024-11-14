    using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UuDaiThanhVienDAL
    {
        MeVaBeDBDataContext db = new MeVaBeDBDataContext();
        public UuDaiThanhVienDAL()
        {

        }
        public decimal GetPhanTramGiam(string maHang)
        {
            var uudais = db.UuDaiThanhViens
                .Where(u => u.maHang == maHang).FirstOrDefault();
            return uudais != null ? uudais.phanTramGiam.Value : 0;
        }
    }
}
