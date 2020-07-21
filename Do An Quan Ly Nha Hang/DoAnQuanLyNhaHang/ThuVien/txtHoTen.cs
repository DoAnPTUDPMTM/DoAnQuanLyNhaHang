using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThuVien
{
    public class txtHoTen : TextBox
    {
        public txtHoTen()
        {
            this.KeyPress += TxtHoTen_KeyPress;
        }

        private void TxtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       
    }
}
