using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien
{
    public class txtMatKhau : TextBox
    {
        public txtMatKhau()
        {
            this.KeyUp += TxtMatKhau_KeyUp;
            this.PasswordChar = '*';
        }

        private void TxtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.TextLength > 20)
            {
                MessageBox.Show("Mật khẩu không được quá 20 kí tự\nVui lòng nhập lại");
                this.Clear();
                this.Focus();
            }
        }
    }
}
