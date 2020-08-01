using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public partial class ChiTietHoaDon
    {
        string _STT;

        public string STT
        {
            get { return _STT; }
            set { _STT = value; }
        }

        double dongia;

        public double DonGia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        string tenthucdon;

        public string TenThucDon
        {
            get { return tenthucdon; }
            set { tenthucdon = value; }
        }
    }
}
