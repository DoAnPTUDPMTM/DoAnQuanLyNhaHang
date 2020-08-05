using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyDoanhThu
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public IEnumerable<HoaDon> getDoanhThu(DateTime ngaydau,DateTime ngaycuoi)
        {
            
            var hoadons = from hd in db.HoaDons where hd.NgayTao >= ngaydau  && hd.NgayTao <= ngaycuoi select hd;
            
            return hoadons;
        }

        public List<HoaDon> layHoaDon(DateTime ngaydau, DateTime ngaycuoi)
        {
            List<HoaDon> lstHD = new List<HoaDon>();
            var hoadons = from hd in db.HoaDons where hd.NgayTao >= ngaydau && hd.NgayTao <= ngaycuoi select hd;
            int stt = 1;
            foreach(HoaDon hd in hoadons)
            {
                hd.STT = stt.ToString();
                hd.MaKhachHang = "";
                lstHD.Add(hd);
                stt++;
            }

            return lstHD;

        }
    }
}
