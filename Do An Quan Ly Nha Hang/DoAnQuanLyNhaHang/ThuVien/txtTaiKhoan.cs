using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien
{
    public class txtTaiKhoan : TextBox
    {
        public txtTaiKhoan()
        {
            this.KeyPress += TxtTaiKhoan_KeyPress;
        }

        private void TxtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (hasSpecialChar(e.KeyChar.ToString()) == true && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (hasSpecialChar(this.Text) == true)
            {
                e.Handled = true;
            }
        }

        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,+_";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

    }
}
