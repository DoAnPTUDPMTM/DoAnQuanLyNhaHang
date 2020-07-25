using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace DoAnQuanLyNhaHang
{

    public partial class frmDoanhThu : Form
    {
        QuanLyDoanhThu dt = new QuanLyDoanhThu();
        public frmDoanhThu()
        {
            InitializeComponent();
            loadDateTimePicker();
            loadDatagridviewDoanhThu();
        }

        private void loadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dtpNgayDau.Value = new DateTime(today.Year, today.Month, 1);
            dtpNgayCuoi.Value = dtpNgayDau.Value.AddMonths(1).AddDays(-1);
        }

        private void loadDatagridviewDoanhThu()
        {
            DataTable dtDoanhThu = new DataTable();
            dtDoanhThu.Columns.Add("Mã HĐ");
            dtDoanhThu.Columns.Add("Ngày Tạo");
            dtDoanhThu.Columns.Add("Mã Bàn");
            dtDoanhThu.Columns.Add("Mã NV");
            dtDoanhThu.Columns.Add("Mã KH");
            dtDoanhThu.Columns.Add("Tổng Tiền");
            foreach(HoaDon hd in dt.getDoanhThu(dtpNgayDau.Value, dtpNgayCuoi.Value))
            {
                DataRow newRow = dtDoanhThu.NewRow();
                newRow["Mã HĐ"] = hd.MaHoaDon;
                newRow["Ngày Tạo"] = hd.NgayTao;
                newRow["Mã Bàn"] = hd.MaBan;
                newRow["Mã NV"] = hd.MaNhanVien;
                newRow["Mã KH"] = hd.MaKhachHang;
                newRow["Tổng Tiền"] = hd.ThanhTien;
                dtDoanhThu.Rows.Add(newRow);
            }
            dtgvDoanhThu.DataSource = dtDoanhThu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDatagridviewDoanhThu();
        }
    }
}
