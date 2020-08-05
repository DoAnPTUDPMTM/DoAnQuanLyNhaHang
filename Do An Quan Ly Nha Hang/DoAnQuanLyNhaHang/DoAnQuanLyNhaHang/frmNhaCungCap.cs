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
    public partial class frmNhaCungCap : Form
    {
        QuanLyNhaCungCap ncc = new QuanLyNhaCungCap();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            loadDatagridviewNhaCungCap();
        }

        public void loadDatagridviewNhaCungCap()
        {
            dtgvNCC.DataSource = ncc.loadDatagridviewNhaCungCap();
        }

        private void dtgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNCC.Text = dtgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dtgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dtgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dtgvNCC.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ncc.themNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
            loadDatagridviewNhaCungCap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ncc.xoaNhaCungCap(txtMaNCC.Text);
            loadDatagridviewNhaCungCap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ncc.suaNhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
            loadDatagridviewNhaCungCap();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
