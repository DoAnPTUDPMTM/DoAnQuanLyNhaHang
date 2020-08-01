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
    public partial class frmDangNhap : Form
    {
        QuanLy_NguoiDung CauHinh = new QuanLy_NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            //Form tmp = this.FindForm();
            //tmp.Close();
            //tmp.Dispose();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength == 0)
            {
                MessageBox.Show("Không được bỏ trống tài khoản");
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                txtMatKhau.Focus();
                return;
            }
            // kiểm tra cấu hình trong config
            int rs = CauHinh.check_Config();
            if (rs == 0) // Cấu hình đúng
            {
                ProcessLogin();
            }
            if (rs == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (rs == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }

        public void ProcessConfig()
        {
            if (Program.updateAppConfig == null || Program.updateAppConfig.IsDisposed)
            {
                Program.updateAppConfig = new updateAppConfig();
            }
            this.Visible = false;
            Program.updateAppConfig.Show();
        }
        public void ProcessLogin()
        {
            int rs;
            rs = CauHinh.checkUser(txtTaiKhoan.Text, txtMatKhau.Text);
            if (rs == 0) // tồn tại
            {
                if (Program.mainForm == null || Program.mainForm.IsDisposed)
                {
                    Program.mainForm = new frmMain();
                    
                    Program.mainForm.tendangnhap = txtTaiKhoan.Text;
                    Program.mainForm.matkhau = txtMatKhau.Text;
                    
                }
                this.Visible = false;
                //Program.mainForm.STenDangNhap = txtTaiKhoan.Text;
                Program.mainForm.Show();
            }
            else if (rs == -1) // không tồn tại
            {
                MessageBox.Show("Không tồn tại tài khoản này");
                
                txtTaiKhoan.Focus();
                return;
            }
            else if (rs == 1) // không hoạt động
            {
                MessageBox.Show("Tài khoản bị khóa");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
    }
}
