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
    public partial class frmTaiKhoan : Form
    {
        QuanLyTaiKhoan qltk = new QuanLyTaiKhoan();
        public frmTaiKhoan()
        {
            InitializeComponent();
            
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.TextLength == 0 || txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
                return;
            }
            if (qltk.kiemtraTaiKhoanTonTaiChua(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.");
                return;
            }
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Lưu thành công");
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TaiKhoan' table. You can move, or remove it, as needed.
            loadDatagridviewTaiKhoan();

        }
        private void loadDatagridviewTaiKhoan()
        {
            dtgvTaiKhoan.DataSource = qltk.getTaiKhoans();
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool hoatdong;
            if (txtTenDangNhap.TextLength == 0 || txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản");
                return;
            }
            if (txtTenDangNhap.TextLength > 10)
            {
                MessageBox.Show("Tên đăng nhập quá 10 ký tự.");
                return;
            }
            if (qltk.kiemtraTaiKhoanTonTaiChua(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.");
                return;
            }
            if (cbHoatDong.Checked)
            {
                hoatdong = true;
            }
            else
            {
                hoatdong = false;
            }
            qltk.themTaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text, hoatdong);
            MessageBox.Show("Thêm tài khoản '"+txtTenDangNhap.Text+"' thành công.");
            loadDatagridviewTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            string tendangnhap = dtgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            bool flag = qltk.xoaTaiKhoan(tendangnhap);
            if (flag)
            {
                MessageBox.Show("Xoá thành công tài khoản '" + tendangnhap + "'");
                loadDatagridviewTaiKhoan();
            }
            else
            {
                MessageBox.Show("Không xoá được.");
            }
        }

        private void dtgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = dtgvTaiKhoan.CurrentRow.Cells[0].Value.ToString();
            txtMatKhau.Text = dtgvTaiKhoan.CurrentRow.Cells[1].Value.ToString();
            if (dtgvTaiKhoan.CurrentRow.Cells[2].Value.ToString() == "True")
            {
                cbHoatDong.Checked = true;
            }
            else
            {
                cbHoatDong.Checked = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            bool hoatdong;
            if (cbHoatDong.Checked)
            {
                hoatdong = true;
            }
            else
            {
                hoatdong = false;
            }
            bool flag2 = qltk.suaTaiKhoan(tendangnhap, matkhau, hoatdong);
            if (flag2)
            {
                MessageBox.Show("Sửa thành công.");
            }
            else
            {
                MessageBox.Show("Sửa không thành công.");
            }
            loadDatagridviewTaiKhoan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
