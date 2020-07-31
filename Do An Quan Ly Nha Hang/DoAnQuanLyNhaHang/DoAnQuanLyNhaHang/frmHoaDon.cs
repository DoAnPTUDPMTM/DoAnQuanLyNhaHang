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
    public partial class frmHoaDon : Form
    {
        DataTable dtHoaDon;
        DataTable dtChiTietHoaDon;
        QuanLyHoaDon qlhd = new QuanLyHoaDon();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadDatagridviewHoaDon();
            //loadDatagridviewChiTietHoaDon();
        }

        public void loadDatagridviewHoaDon()
        {
            dtHoaDon = new DataTable();
            dtHoaDon.Columns.Add("Mã Hoá Đơn");
            dtHoaDon.Columns.Add("Ngày Tạo");
            dtHoaDon.Columns.Add("Mã Bàn");
            dtHoaDon.Columns.Add("Mã Nhân Viên");
            dtHoaDon.Columns.Add("Mã Khách Hàng");
            dtHoaDon.Columns.Add("Tổng Tiền");
            foreach (HoaDon hd in qlhd.getHoaDons())
            {
                DataRow newRow = dtHoaDon.NewRow();
                newRow["Mã Hoá Đơn"] = hd.MaHoaDon;
                newRow["Ngày Tạo"] = hd.NgayTao;
                newRow["Mã Bàn"] = hd.MaBan;
                newRow["Mã Nhân Viên"] = hd.MaNhanVien;
                newRow["Mã Khách Hàng"] = hd.MaKhachHang;
                newRow["Tổng Tiền"] = hd.ThanhTien;

                dtHoaDon.Rows.Add(newRow);
            }
            dtgvHoaDon.DataSource = dtHoaDon;
        }

        public void loadDatagridviewChiTietHoaDon(string mahoadon)
        {
            dtChiTietHoaDon = new DataTable();
            dtChiTietHoaDon.Columns.Add("Mã Chi Tiết Hoá Đơn");
            dtChiTietHoaDon.Columns.Add("Mã Hoá Đơn");
            dtChiTietHoaDon.Columns.Add("Mã Thực Đơn");
            dtChiTietHoaDon.Columns.Add("Số Lượng");
            dtChiTietHoaDon.Columns.Add("Thành Tiền");

            foreach (ChiTietHoaDon hd in qlhd.getChiTietHoaDons(mahoadon))
            {
                DataRow newRow = dtChiTietHoaDon.NewRow();
                newRow["Mã Chi Tiết Hoá Đơn"] = hd.MaChiTietHoaDon;
                newRow["Mã Hoá Đơn"] = hd.MaHoaDon;
                newRow["Mã Thực Đơn"] = hd.MaThucDon;
                newRow["Số Lượng"] = hd.SoLuong;
                newRow["Thành Tiền"] = hd.ThanhTien;

                dtChiTietHoaDon.Rows.Add(newRow);
            }
            dtgvChiTietHoaDon.DataSource = dtChiTietHoaDon;
        }

        private void dtgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {

            // hiển thị lên textbox
            txtMaHoaDon.Text = dtgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            dtpNgayTao.Text = dtgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaBan.Text = dtgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtMaNhanVien.Text = dtgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtMaKhachHang.Text = dtgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtTongTien.Text = dtgvHoaDon.CurrentRow.Cells[5].Value.ToString();

            // bên dtgvChiTietHoaDOn sẽ hiện lên
            loadDatagridviewChiTietHoaDon(dtgvHoaDon.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
