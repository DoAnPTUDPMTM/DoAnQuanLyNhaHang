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
    }
}
