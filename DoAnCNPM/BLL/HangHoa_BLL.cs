using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HangHoa_BLL
    {
        HangHoa_DAL hh_dal = new HangHoa_DAL();
        public HangHoa_BLL(){}
        public List<LoaiHangHoa> getLoaiHangHoa()
        {
            return hh_dal.getLoaiHang();
        }
    }
}
