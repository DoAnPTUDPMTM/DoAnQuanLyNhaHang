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
