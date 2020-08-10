using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_DAL
    {
        QLShopThoiTrangDataContext da = new QLShopThoiTrangDataContext();
        public HoaDon_DAL() { }
        //lay danh sach hang hoa
        public IQueryable getHangHoa()
        {
            var hh = from h in da.HangHoas select h;
            return hh;
        }
        //lay danh sach hoa don
        public IQueryable getCTHoaDon(string ma)
        {
            var ct = from t in da.ChiTietHoaDons where t.maHD == ma select new { t.maMH, t.SoLuong, t.DonGia, t.ThanhTien };
            return ct;
        }
        //lay thong tin chi tiet cua mot mat hang
        public HangHoa getCTHH(string ma)
        {
            var hh = da.HangHoas.Where(t => t.maMH == ma).SingleOrDefault();
            return hh;
        }
        //them hoa don
        public void ThemHoaDon(string mahd, string ngaylap, string manv, string mathe)
        {
            HoaDon hd = new HoaDon();
            hd.maHD = mahd;
            hd.NgayLapHD = DateTime.Parse(ngaylap);
            hd.maNV = manv;
            hd.maThe = mathe;
            hd.TongTien = 0;

            da.HoaDons.InsertOnSubmit(hd);
            da.SubmitChanges();
        }
        // lay ma hoa don cuoi cung
        public string getMAHDLast()
        {
            List<HoaDon> a = da.HoaDons.ToList();
            if (a.Count == 0)// neu chua co hoa don nao
            { return ""; }
            //da co ma hoa don
            HoaDon b = da.HoaDons.ToList().OrderByDescending(t => t.maHD).First();// lay hoa don dau tien giam dan theo ma
            return b.maHD;
        }
    }
}
