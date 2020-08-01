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
            loadComboboxHoaDon();
            //loadDatagridviewChiTietHoaDon();
        }
        private void loadComboboxHoaDon()
        {
            cboMaHoaDon.DataSource = qlhd.loadComboboxHoaDon();
            cboMaHoaDon.DisplayMember = "MaHoaDon";
            cboMaHoaDon.ValueMember = "MaHoaDon";
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
            //loadDatagridviewChiTietHoaDon(dtgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            cboMaHoaDon.SelectedValue = dtgvHoaDon.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            qlhd.themHoaDon(txtMaHoaDon.Text,txtMaBan.Text,txtMaNhanVien.Text,txtMaKhachHang.Text,txtTongTien.Text);
            loadDatagridviewHoaDon();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            qlhd.luuHoaDon(txtMaHoaDon.Text, dtpNgayTao.Text, txtMaBan.Text, txtMaNhanVien.Text, txtMaKhachHang.Text, txtTongTien.Text);
            loadDatagridviewHoaDon();

        }

        private void btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            string mahd = dtgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            qlhd.xoaHoaDon(mahd);
            loadDatagridviewHoaDon();
        }

        private void dtgvChiTietHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            txtMaChiTietHoaDon.Text = dtgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();

            txtMaThucDon.Text = dtgvChiTietHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dtgvChiTietHoaDon.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dtgvChiTietHoaDon.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDongHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongChiTietHoaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            
            qlhd.themChiTietHoaDon(cboMaHoaDon.Text, txtMaThucDon.Text, txtSoLuong.Text);
            loadDatagridviewChiTietHoaDon(cboMaHoaDon.Text);
            loadDatagridviewHoaDon();
        }

        private void cboMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtChiTietHoaDon = new DataTable();
            dtChiTietHoaDon.Columns.Add("Mã Chi Tiết Hoá Đơn");
            dtChiTietHoaDon.Columns.Add("Mã Hoá Đơn");
            dtChiTietHoaDon.Columns.Add("Mã Thực Đơn");
            dtChiTietHoaDon.Columns.Add("Số Lượng");
            dtChiTietHoaDon.Columns.Add("Thành Tiền");

            foreach (ChiTietHoaDon hd in qlhd.loadDatagridviewChiTietHoaDonByCombobox(cboMaHoaDon.Text))
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

        private void btnXoaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            string ma = dtgvChiTietHoaDon.CurrentRow.Cells[0].Value.ToString();
            qlhd.xoaChiTietHoaDon(ma);
            loadDatagridviewHoaDon();
            loadDatagridviewChiTietHoaDon(cboMaHoaDon.Text);
        }

        private void btnSuaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            string machitiethoadon = txtMaChiTietHoaDon.Text;
            string mathucdon = txtMaThucDon.Text;
            string soluong = txtSoLuong.Text;
            string mahoadon = cboMaHoaDon.Text;
            qlhd.suaChiTietHoaDon(machitiethoadon,mathucdon,soluong,mahoadon);
            loadDatagridviewChiTietHoaDon(cboMaHoaDon.Text);
            loadDatagridviewHoaDon();
        }
    }
}
