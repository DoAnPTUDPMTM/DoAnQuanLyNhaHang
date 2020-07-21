using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace DoAnQuanLyNhaHang
{
    class QuanLy_NguoiDung
    {
        SqlDataAdapter da_User;
        DataTable dt_User;
        public int check_Config()
        {
            if (Properties.Settings.Default.connect == string.Empty)
            {
                return 1;
            }
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connect);
            try
            {
                if(conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                return 0; // thành công, cấu hình hợp lệ
            }
            catch (Exception ex)
            {
                return 2; // cấu hình không phù hợp
            }
        }

        public int checkUser(string User, string Password)
        {
            da_User = new SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TenDangNhap='" + User + "' AND MatKhau='" + Password + "'", Properties.Settings.Default.connect);
            dt_User = new DataTable();
            da_User.Fill(dt_User);
            //dt_User = cSql.ExecuteQuery("SELECT * FROM QL_NguoiDung WHERE TenDangNhap='" + User + "' AND MatKhau='" + Password + "'",conn);
            if (dt_User.Rows.Count == 0)
            {
                return -1; // không tồn tại tài khoản user
            }
            else if (dt_User.Rows[0][2] == null || dt_User.Rows[0][2].ToString() == "False")
            {
                return 1; // Tài khoản user không hoạt động
            }
            return 0;
        }

        public DataTable getNameServer()
        {
            DataTable dt_getNameServer = new DataTable();
            dt_getNameServer = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt_getNameServer;
        }
        public DataTable getDatabaseName(string pServer, string pUser, string pPass)
        {
            DataTable dt_getDatabaseName = new DataTable();
            SqlDataAdapter da_getDatabaseName = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " + pPass + "");
            da_getDatabaseName.Fill(dt_getDatabaseName);
            return dt_getDatabaseName;
        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            Properties.Settings.Default.connect = "Data Source=" + pServer + ";Initial Catalog=" + pDBName + ";User ID=" + pUser + ";pwd= " + pPass + "";
            Properties.Settings.Default.Save();
        }
    }
}
