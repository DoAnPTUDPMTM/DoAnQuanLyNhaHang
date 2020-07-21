using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNhaHang
{
    public partial class updateAppConfig : Form
    {
        QuanLy_NguoiDung CauHinh = new QuanLy_NguoiDung();
        public updateAppConfig()
        {
            InitializeComponent();
        }

        private void cbServerName_DropDown(object sender, EventArgs e)
        {
            cbServerName.DataSource = CauHinh.getNameServer();
            cbServerName.DisplayMember = "ServerName";
        }

        private void cbDatabase_DropDown(object sender, EventArgs e)
        {
            cbDatabase.DataSource = CauHinh.getDatabaseName(cbServerName.Text, txtUserName.Text, txtPassword.Text);
            cbDatabase.DisplayMember = "name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbServerName.SelectedText, txtUserName.Text, txtPassword.Text, cbDatabase.SelectedText);
            this.Close();
        }
    }
}
