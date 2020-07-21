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
    public partial class frmMain : Form
    {
        public string tendangnhap;
        public string matkhau;
        QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }
        private void phanQuyen()
        {
            string manhomtaikhoan = qltk.getMaNhomTaiKhoanByTenDangNhap(tendangnhap);
            int a = qltk.getPhanQuyen(manhomtaikhoan).Count();

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                foreach (ToolStripMenuItem dropDownItem in item.DropDownItems)
                {
                    foreach (PhanQuyen pq in qltk.getPhanQuyen(manhomtaikhoan))
                    {
                        if (dropDownItem.Tag.ToString().Equals(pq.MaManHinh.ToString()))
                        {
                            if (pq.CoQuyen == false)
                            {
                                dropDownItem.Enabled = false;
                            }
                        }
                    }
                }
                
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void nhómTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManHinh();
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmTàiKhoảnVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemTaiKhoanVaoNhom();
            frm.MdiParent = this;
            frm.Show();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmGoiMon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThucDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            phanQuyen();
            MessageBox.Show(tendangnhap+" @ "+matkhau);
        }
    }
}
