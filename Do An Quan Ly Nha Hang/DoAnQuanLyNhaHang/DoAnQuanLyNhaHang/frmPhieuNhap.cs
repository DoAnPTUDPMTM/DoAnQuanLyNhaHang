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
    public partial class frmPhieuNhap : Form
    {
        QuanLyPhieuNhap qlpn = new QuanLyPhieuNhap();
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qlpn.themPhieuNhap(dtpNgayNhap.Text,cboMaNhanVien.Text,cboMaNhaCungCap.Text);
            loadDatagridviewPhieuNhap();
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            loadComboboxMaNhanVien();
            loadComboboxMaNhaCungCap();
            loadDatagridviewPhieuNhap();
            loadDatagridviewChiTietPhieuNhap();
            loadComboboxMaNguyenLieu();
        }
        public void loadComboboxMaNhaCungCap()
        {
            cboMaNhaCungCap.DataSource = qlpn.loadComboboxMaNhaCungCap();
            cboMaNhaCungCap.DisplayMember = "MaNhaCungCap";
            cboMaNhaCungCap.ValueMember = "MaNhaCungCap";
        }

        public void loadComboboxMaNhanVien()
        {
            cboMaNhanVien.DataSource = qlpn.loadComboboxMaNhanVien();
            cboMaNhanVien.DisplayMember = "MaNhanVien";
            cboMaNhanVien.ValueMember = "MaNhanVien";
        }

        public void loadDatagridviewPhieuNhap()
        {
            dtgvPhieuNhap.DataSource = qlpn.loadDatagridviewPhieuNhap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qlpn.xoaPhieuNhap(txtMaPhieuNhap.Text);
            loadDatagridviewPhieuNhap();
        }

        private void dtgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            txtMaPhieuNhap.Text = dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            dtpNgayNhap.Text = dtgvPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            cboMaNhanVien.Text = dtgvPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            cboMaNhaCungCap.Text = dtgvPhieuNhap.CurrentRow.Cells[3].Value.ToString();

            cboMaPhieuNhap_CT.Text = dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString();

            loadDatagridviewChiTietPhieuNhap(dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qlpn.suaPhieuNhap(txtMaPhieuNhap.Text,dtpNgayNhap.Text,cboMaNhanVien.Text,cboMaNhaCungCap.Text);
            loadDatagridviewPhieuNhap();
        }

        public void loadDatagridviewChiTietPhieuNhap()
        {
            dtgvChiTietPhieuNhap.DataSource = qlpn.loadDatagridviewCTPhieuNhap();

        }

        private void btnThem_CT_Click(object sender, EventArgs e)
        {
            qlpn.themChiTietPhieuNhap(cboMaPhieuNhap_CT.Text,cboMaNguyenLieu.Text,txtSoLuong.Text);
            loadDatagridviewChiTietPhieuNhap(dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
        }

        public void loadComboboxMaNguyenLieu()
        {
            cboMaNguyenLieu.DataSource = qlpn.loadComboboxMaNguyenLieu();
            cboMaNguyenLieu.DisplayMember = "MaNguyenLieu";
            cboMaNguyenLieu.ValueMember = "MaNguyenLieu";
        }

        public void loadDatagridviewChiTietPhieuNhap(string mapn)
        {
            dtgvChiTietPhieuNhap.DataSource = qlpn.loadDatagridviewChiTietPhieuNhapByMaPhieuNhap(mapn);
        }

        private void btnXoa_CT_Click(object sender, EventArgs e)
        {
            
            int mactpn = int.Parse(dtgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString());
            qlpn.xoaChiTietPhieuNhap(mactpn);
            loadDatagridviewChiTietPhieuNhap(dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnSua_CT_Click(object sender, EventArgs e)
        {

            int mactpn = int.Parse(dtgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString());
            qlpn.suaChiTietPhieuNhap(mactpn,cboMaNguyenLieu.Text,txtSoLuong.Text);
            loadDatagridviewChiTietPhieuNhap(dtgvPhieuNhap.CurrentRow.Cells[0].Value.ToString());
        }

        private void dtgvChiTietPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            txtMaCTPN.Text = dtgvChiTietPhieuNhap.CurrentRow.Cells[0].Value.ToString();
            cboMaPhieuNhap_CT.Text = dtgvChiTietPhieuNhap.CurrentRow.Cells[1].Value.ToString();
            cboMaNguyenLieu.Text = dtgvChiTietPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dtgvChiTietPhieuNhap.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
