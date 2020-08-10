using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDon_BLL
    {
        HoaDon_DAL hd_dal = new HoaDon_DAL();
        public HoaDon_BLL() { }
        public IQueryable getHangHoa()
        {
            return hd_dal.getHangHoa();
        }
        public IQueryable getCTHoaDon(string ma)
        {
            return hd_dal.getCTHoaDon(ma);
        }
        public HangHoa getCTHH(string ma)
        {
            return hd_dal.getCTHH(ma);
        }
        public void ThemHoaDon(string mahd, string ngaylap, string manv, string mathe)
        {
            hd_dal.ThemHoaDon(mahd, ngaylap, manv, mathe);
        }
        public string getMAHDLast()
        {
            return hd_dal.getMAHDLast();
        }
    }
}
