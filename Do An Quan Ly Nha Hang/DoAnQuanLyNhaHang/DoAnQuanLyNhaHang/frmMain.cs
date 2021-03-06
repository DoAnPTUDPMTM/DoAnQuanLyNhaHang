﻿using System;
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
        QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
        QuanLyNhanVien qlnv = new QuanLyNhanVien();
        public string tendangnhap;
        public string matkhau;
        public string tennhanvien;
        
        
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmTaiKhoan();
            if (Application.OpenForms.OfType<frmTaiKhoan>().Any())
            {
                Application.OpenForms.OfType<frmTaiKhoan>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
        private void phanQuyen()
        {
            string manhomtaikhoan = qltk.getMaNhomTaiKhoanByTenDangNhap(tendangnhap);
            if(manhomtaikhoan==null)
            {
                MessageBox.Show("Tài Khoản này chưa phân quyền.");
                return;
            }
            int a = qltk.getPhanQuyen(manhomtaikhoan).Count();

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                foreach (PhanQuyen pq in qltk.getPhanQuyen(manhomtaikhoan))
                {
                    if (item.Tag.ToString().Equals(pq.MaManHinh.ToString()))
                    {
                        if (pq.CoQuyen == false)
                        {
                            item.Enabled = false;
                        }
                    }
                }
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
            else
            {
                Form frm = new frmDangNhap();

                frm.Show();
            }
            

        }

        private void nhómTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManHinh();
            if (Application.OpenForms.OfType<frmManHinh>().Any())
            {
                Application.OpenForms.OfType<frmManHinh>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void thêmTàiKhoảnVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThemTaiKhoanVaoNhom();
            if (Application.OpenForms.OfType<frmThemTaiKhoanVaoNhom>().Any())
            {
                Application.OpenForms.OfType<frmThemTaiKhoanVaoNhom>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPhanQuyen();
            if (Application.OpenForms.OfType<frmPhanQuyen>().Any())
            {
                Application.OpenForms.OfType<frmPhanQuyen>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhanVien();
            if (Application.OpenForms.OfType<frmNhanVien>().Any())
            {
                Application.OpenForms.OfType<frmNhanVien>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmBan();
            if (Application.OpenForms.OfType<frmBan>().Any())
            {
                Application.OpenForms.OfType<frmBan>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string manv = qlnv.getMaNhanVienByTenDangNhap(tendangnhap);
            Form frm = new frmGoiMon(manv);
            if (Application.OpenForms.OfType<frmGoiMon>().Any())
            {
                Application.OpenForms.OfType<frmGoiMon>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            
            frm.Show();
        }

        private void quảnLýThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmThucDon();
            if (Application.OpenForms.OfType<frmThucDon>().Any())
            {
                Application.OpenForms.OfType<frmThucDon>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            phanQuyen();
            lblTenNhanVien.Text = qltk.getTenNhanVienByTenDangNhap(tendangnhap);
            MessageBox.Show(tendangnhap+" @ "+matkhau);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            Form frm = new frmDoanhThu();
            if (Application.OpenForms.OfType<frmDoanhThu>().Any())
            {
                Application.OpenForms.OfType<frmDoanhThu>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void hệThốngToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void hệThốngToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmHoaDon();
            if (Application.OpenForms.OfType<frmHoaDon>().Any())
            {
                Application.OpenForms.OfType<frmHoaDon>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            Form frm = new frmNhaCungCap();
            if (Application.OpenForms.OfType<frmNhaCungCap>().Any())
            {
                Application.OpenForms.OfType<frmNhaCungCap>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPhieuNhap();
            if (Application.OpenForms.OfType<frmPhieuNhap>().Any())
            {
                Application.OpenForms.OfType<frmPhieuNhap>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýNguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmNguyenLieu();
            if (Application.OpenForms.OfType<frmNguyenLieu>().Any())
            {
                Application.OpenForms.OfType<frmNguyenLieu>().First().Close();
            }
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
