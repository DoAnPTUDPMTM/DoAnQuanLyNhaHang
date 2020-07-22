using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNhaHang
{
    static class Program
    {
        public static frmMain mainForm = null;
        
        public static frmDangNhap DangNhapForm = null;
        public static updateAppConfig updateAppConfig = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBan());
        }
    }
}
