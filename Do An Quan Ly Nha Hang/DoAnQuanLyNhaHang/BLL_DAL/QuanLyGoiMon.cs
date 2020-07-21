using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyGoiMon
    {
        QuanLyNhaHangDataContext db = new QuanLyNhaHangDataContext();
        public void themMonAn(string maban, string mathucdon, string tenthucdon, string gia, string soluong)
        {
            if (!kiemTraMonAnTonTai(maban, mathucdon))
            {
                GoiMon newMon = new GoiMon();
                newMon.MaBan = maban;
                newMon.MaThucDon = mathucdon;
                newMon.TenThucDon = tenthucdon;
                newMon.Gia = int.Parse(gia);
                newMon.SoLuong = int.Parse(soluong);
                newMon.ThanhTien = int.Parse(gia) * int.Parse(soluong);
                newMon.ThoiGian = DateTime.Now;
                db.GoiMons.InsertOnSubmit(newMon);
                db.SubmitChanges();
                MessageBox.Show("Thêm món '" + tenthucdon + "' cho bàn '" + maban + "' thành công.");
                
            }
            else
            {
                capnhatMonAn(maban,mathucdon,soluong);
                
            }
            
        }
        public void capnhatMonAn(string maban, string mathucdon, string soluong)
        {
            GoiMon g = db.GoiMons.Where(a => a.MaBan == maban && a.MaThucDon == mathucdon).FirstOrDefault();
            if (g != null)
            {
                g.SoLuong = g.SoLuong + int.Parse(soluong);
                g.ThanhTien = g.ThanhTien + Convert.ToDecimal((int.Parse(soluong) * g.Gia));
                db.SubmitChanges();
                MessageBox.Show("Đã cập nhật món ăn.");
            }
        }
        public void xoaMonAn(int magoimon)
        {
            GoiMon delMon = db.GoiMons.Where(m => m.id == magoimon).FirstOrDefault();
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá món '" + delMon.TenThucDon + "' của bàn '" + delMon.MaBan + "' không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (delMon != null)
                {
                    db.GoiMons.DeleteOnSubmit(delMon);
                    MessageBox.Show("Xoá món '" + delMon.TenThucDon + "' thành công.");
                    db.SubmitChanges();

                }
            }


        }

        public bool kiemTraMonAnTonTai(string maban, string mathucdon)
        {
            GoiMon m = db.GoiMons.Where(a => a.MaBan == maban && a.MaThucDon == mathucdon).FirstOrDefault();
            if (m != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<GoiMon> loadGoiMonByBan(string maban)
        {
            var bans = from gm in db.GoiMons
                       where gm.MaBan == maban
                       select gm;
            return bans;

        }
    }
}
