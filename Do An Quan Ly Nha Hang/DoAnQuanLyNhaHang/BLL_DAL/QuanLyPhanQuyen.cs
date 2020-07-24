using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyPhanQuyen
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public bool suaPhanQuyen(string manhomtaikhoan,string mamanhinh,string coquyen)
        {
            PhanQuyen pq = db.PhanQuyens.Where(a => a.MaNhomTaiKhoan == manhomtaikhoan && a.MaManHinh == mamanhinh).FirstOrDefault();
            if (pq != null)
            {
               
                pq.CoQuyen = bool.Parse(coquyen);
                db.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
                return true;
            }
            MessageBox.Show("Sửa không thành công.");
            return false;
        }

        public IEnumerable<PhanQuyen> getPhanQuyens()
        {
            var pqs = from pq in db.PhanQuyens select pq;
            return pqs;
        }
    }
}
