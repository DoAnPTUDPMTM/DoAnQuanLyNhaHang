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
using System.Text.RegularExpressions;

namespace DoAnQuanLyNhaHang
{
    public partial class frmNhanVien : Form
    {
        QuanLyNhanVien nv = new QuanLyNhanVien();
        public frmNhanVien()
        {
            InitializeComponent();

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (txtTenNhanVien.TextLength == 0 || txtMaNhanVien.TextLength == 0 || txtEmail.TextLength == 0 || txtDienThoai.TextLength == 0 || txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                return;
            }
            try
            {
                this.Validate();
                this.nhanVienBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\nVui lòng kiểm tra lại quy trình thực hiện.");
            }


        }
        private void loadDatagridviewNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            dtNhanVien.Columns.Add("Mã NV");
            dtNhanVien.Columns.Add("Tên NV");
            dtNhanVien.Columns.Add("Ngày sinh");
            dtNhanVien.Columns.Add("Giới tính");
            dtNhanVien.Columns.Add("Điện thoại");
            dtNhanVien.Columns.Add("Email");
            dtNhanVien.Columns.Add("Địa chỉ");
            dtNhanVien.Columns.Add("Tên đăng nhập");
            foreach (NhanVien nv in nv.getNhanViens())
            {
                DataRow newRow = dtNhanVien.NewRow();
                newRow["Mã NV"] = nv.MaNhanVien;
                newRow["Tên NV"] = nv.TenNhanVien;
                newRow["Ngày sinh"] = nv.NgaySinh;
                newRow["Giới tính"] = nv.GioiTinh;
                newRow["Điện thoại"] = nv.DienThoai;
                newRow["Email"] = nv.Email;
                newRow["Địa chỉ"] = nv.DiaChi;
                newRow["Tên đăng nhập"] = nv.TenDangNhap;
                dtNhanVien.Rows.Add(newRow);
            }
            dtgvNhanVien.DataSource = dtNhanVien;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.NhanVien' table. You can move, or remove it, as needed.
            loadDatagridviewNhanVien();
            radNam.Checked = true ;
            loadComboboxTaiKhoan();

        }
        private void loadComboboxTaiKhoan()
        {
            
            cboTaiKhoan.DataSource = nv.getTaiKhoanChuaCoDung();
            cboTaiKhoan.DisplayMember = "TenDangNhap";
        }
        private void gioiTinhTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                nhanVienBindingNavigatorSaveItem_Click(sender, e);


            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                string manhanvien = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
                if (!nv.kiemtraKhoaNgoai(manhanvien))
                {
                    MessageBox.Show("Không xoá được do những hoá đơn thanh toán của nhân viên này còn tồn tại.");
                    return;
                }               
                nv.xoaNhanVien(manhanvien);
                loadDatagridviewNhanVien();
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtMaNhanVien.TextLength == 0 || txtTenNhanVien.TextLength == 0 || txtDienThoai.TextLength == 0 || txtDiaChi.TextLength == 0 || txtEmail.TextLength == 0)
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin dữ liệu.");
            //    return;
            //}
            //if (hasSpecialChar(txtTenNhanVien.Text))
            //{
            //    MessageBox.Show("Tên nhân viên có kí tự đặc biệt.");
            //    return;
            //}
            //if (txtMaNhanVien.TextLength > 10)
            //{
            //    MessageBox.Show("Mã nhân viên không được quá 10 ký tự.");
            //    return;
            //}
            //if (!kiemtraEmail(txtEmail.Text))
            //{
            //    MessageBox.Show("Email không hợp lệ.");
            //    return;
            //}
            //if (!kiemtraSDT(txtDienThoai.Text))
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ.");
            //    return;
            //}
            bool flag = nv.kiemtraDuLieuNhap(txtMaNhanVien.Text,txtTenNhanVien.Text,dtpNgaySinh.Text,txtDienThoai.Text,txtEmail.Text,txtDiaChi.Text);
            if (flag)
            {
                string manhanvien = txtMaNhanVien.Text;
                string tennhanvien = txtTenNhanVien.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string tendangnhap = cboTaiKhoan.Text;
                string gioitinh;
                if (radNam.Checked)
                {
                    gioitinh = radNam.Text;
                }
                else
                {
                    gioitinh = radNu.Text;
                }
                string dienthoai = txtDienThoai.Text;
                string email = txtEmail.Text;
                string diachi = txtDiaChi.Text;

                nv.themNhanVien(manhanvien, tennhanvien, ngaysinh, gioitinh, dienthoai, email, diachi,tendangnhap);
                loadDatagridviewNhanVien();
                loadComboboxTaiKhoan();
            }
            else
            {
                return;
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNhanVien.TextLength == 0 || txtMaNhanVien.TextLength == 0 || txtEmail.TextLength == 0 || txtDienThoai.TextLength == 0 || txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên");
                return;
            }
            try
            {
                string gioitinh = "";
                if (radNam.Checked)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }
                bool flag = nv.suaNhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, dtpNgaySinh.Text, gioitinh, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text,cboTaiKhoan.Text);
                if(flag)
                {
                    loadDatagridviewNhanVien();
                    loadComboboxTaiKhoan();
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\nVui lòng kiểm tra lại quy trình thực hiện.");
            }
        }

        private void dtgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = dtgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dtgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            if (dtgvNhanVien.CurrentRow.Cells[3].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDienThoai.Text = dtgvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dtgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtDiaChi.Text = dtgvNhanVien.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
