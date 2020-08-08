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
    public partial class frmNguyenLieu : Form
    {
        QuanLyNguyenLieu qlnl = new QuanLyNguyenLieu();
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            loadDatagridviewNguyenLieu();
        }
        public void loadDatagridviewNguyenLieu()
        {
            dtgvNguyenLieu.DataSource = qlnl.loadDatagridviewNguyenLieu(); 
        }

        private void dtgvNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNguyenLieu.Text = dtgvNguyenLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenNguyenLieu.Text = dtgvNguyenLieu.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dtgvNguyenLieu.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qlnl.themNguyenLieu(txtTenNguyenLieu.Text,txtSoLuong.Text);
            loadDatagridviewNguyenLieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            qlnl.xoaNguyenLieu(txtMaNguyenLieu.Text);
            loadDatagridviewNguyenLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            qlnl.suaNguyenLieu(txtMaNguyenLieu.Text, txtTenNguyenLieu.Text, txtSoLuong.Text);
            loadDatagridviewNguyenLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
