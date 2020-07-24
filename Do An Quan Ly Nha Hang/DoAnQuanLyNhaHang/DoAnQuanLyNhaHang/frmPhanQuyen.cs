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
    public partial class frmPhanQuyen : Form
    {
        QuanLyPhanQuyen pq = new QuanLyPhanQuyen();
        public frmPhanQuyen()
        {
            InitializeComponent();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            loadDatagridviewPhanQuyen();
        }
        private void loadDatagridviewPhanQuyen()
        {
            dtgvPhanQuyen.DataSource = pq.getPhanQuyens();
        }

        private void dtgvPhanQuyen_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNhomTaiKhoan.Text = dtgvPhanQuyen.CurrentRow.Cells[0].Value.ToString();
            txtMaManHinh.Text = dtgvPhanQuyen.CurrentRow.Cells[1].Value.ToString();
            if (dtgvPhanQuyen.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                chkbCoQuyen.Checked = true;
            }
            else
            {
                chkbCoQuyen.Checked = false;
            }
        }

        private void Sửa_Click(object sender, EventArgs e)
        {
            string manhomtaikhoan = txtMaNhomTaiKhoan.Text;
            string coquyen = "";
            string mamanhinh = txtMaManHinh.Text;
            if (chkbCoQuyen.Checked)
            {
                coquyen = "True";
            }
            else
            {
                coquyen = "False";
            }
            bool flag = pq.suaPhanQuyen(manhomtaikhoan,mamanhinh,coquyen);
            loadDatagridviewPhanQuyen();

        }
    }
}
