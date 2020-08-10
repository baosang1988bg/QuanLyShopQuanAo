using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HangHoa_DAL
    {
        QLShopThoiTrangDataContext da = new QLShopThoiTrangDataContext();
        public HangHoa_DAL() { }
        public List<LoaiHangHoa> getLoaiHang()
        {
            List<LoaiHangHoa> l = da.LoaiHangHoas.ToList();
            return l;
        }
    }
}
