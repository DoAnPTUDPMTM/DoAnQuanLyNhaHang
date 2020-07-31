using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class QuanLyHoaDon
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public void themHoaDon(string maban, string manv, string thanhtien)
        {

        }

        public IEnumerable<HoaDon> getHoaDons()
        {
            var HoaDons = from hd in db.HoaDons select hd;
            return HoaDons;
        }

        public IEnumerable<ChiTietHoaDon> getChiTietHoaDons(string mahoadon)
        {
            var ChiTietHoaDons = from cthd in db.ChiTietHoaDons where cthd.MaHoaDon == mahoadon select cthd;
            return ChiTietHoaDons;
        }
    }
}
