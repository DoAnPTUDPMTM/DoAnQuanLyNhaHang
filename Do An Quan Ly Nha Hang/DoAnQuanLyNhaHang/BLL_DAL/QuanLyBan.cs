using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class QuanLyBan
    {
        QuanLyNhaHangDataContext qlnh = new QuanLyNhaHangDataContext();
        public IEnumerable<Ban> getBans()
        {
            var Bans = from b in qlnh.Bans select b;
            return Bans;
        }
        public bool kiemtraDuLieu(string maban, string tenban, string trangthai)
        {
            if (string.IsNullOrEmpty(maban) || string.IsNullOrEmpty(tenban) || string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.");
                return false;
            }
            return true;
        }

        public void themBan(string maban, string tenban, string trangthai)
        {
            bool flag = kiemtraMaBan(maban);
            if (flag)
            {
                MessageBox.Show("Mã bàn đã tồn tại.");
                return;
            }
            Ban ban = new Ban();
            ban.MaBan = maban;
            ban.TenBan = tenban;
            ban.TrangThai = trangthai;

            qlnh.Bans.InsertOnSubmit(ban);
            qlnh.SubmitChanges();
            MessageBox.Show("Thêm bàn thành công");
        }

        public bool kiemtraMaBan(string maban)
        {
            Ban ban = qlnh.Bans.Where(a => a.MaBan == maban).FirstOrDefault();
            if (ban != null)
            {
                return true;
            }
            return false;
        }
        public void xoaBan(string maban)
        {
            Ban ban = qlnh.Bans.Where(a => a.MaBan == maban).FirstOrDefault();
            if (ban != null)
            {
                qlnh.Bans.DeleteOnSubmit(ban);
                qlnh.SubmitChanges();
                MessageBox.Show("Xoá thành công mã bàn '" + maban + "'");
            }
        }

        public bool suaBan(string maban,string tenban,string trangthai)
        {
            Ban ban = qlnh.Bans.Where(a => a.MaBan == maban).FirstOrDefault();
            if (ban != null)
            {
                ban.MaBan = maban;
                ban.TenBan = tenban;
                ban.TrangThai = trangthai;
                qlnh.SubmitChanges();
                MessageBox.Show("Sửa thành công.");
                return true;
            }
            return false;
        }
        public void loadBans()
        {
            foreach (Ban ban in getBans())
            {
                Button btn = new Button() { Width = 50, Height = 50 };
            }
        }

        public IEnumerable<GoiMon> loadGoiMonByBan(string maban)
        {
            var bans = from gm in qlnh.GoiMons
                       where gm.MaBan == maban
                       select gm;
            return bans;
                       
        }
    }
}
