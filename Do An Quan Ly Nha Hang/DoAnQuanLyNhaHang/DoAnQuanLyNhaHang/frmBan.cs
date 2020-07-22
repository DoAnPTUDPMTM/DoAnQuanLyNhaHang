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
    public partial class frmBan : Form
    {
        QuanLyBan ban = new QuanLyBan();
        public frmBan()
        {
            InitializeComponent();
        }
        private void loadItemComboboxTrangThai()
        {
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.Items.Add("Còn trống");
            cbTrangThai.Items.Add("Đã có khách");
        }
        private void banBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.banBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            loadItemComboboxTrangThai();
            // TODO: This line of code loads data into the 'dataSet1.Ban' table. You can move, or remove it, as needed.
            loadDataGridView();

        }
        private void loadDataGridView()
        {
            dtgvBan.DataSource = ban.getBans();
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtMaBan.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool flag = ban.kiemtraDuLieu(txtMaBan.Text, txtTenBan.Text, cbTrangThai.Text);
            if (!flag)
            {
                return;
            }
            ban.themBan(txtMaBan.Text,txtTenBan.Text,cbTrangThai.Text);
            loadDataGridView();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá bàn '"+ dtgvBan.CurrentRow.Cells[0].Value.ToString() + "' không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.No)
            {
                return;
            }
            ban.xoaBan(dtgvBan.CurrentRow.Cells[0].Value.ToString());
            loadDataGridView();
        }

        private void dtgvBan_SelectionChanged(object sender, EventArgs e)
        {
            txtMaBan.Text = dtgvBan.CurrentRow.Cells[0].Value.ToString();
            txtTenBan.Text = dtgvBan.CurrentRow.Cells[1].Value.ToString();
            cbTrangThai.Text = dtgvBan.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool flag = ban.kiemtraMaBan(txtMaBan.Text);
            if (!flag)
            {
                MessageBox.Show("Mã bàn không tồn tại");
                return;
            }
            string maban = txtMaBan.Text;
            string tenban = txtTenBan.Text;
            string trangthai = cbTrangThai.Text;

            ban.suaBan(maban,tenban,trangthai);
            loadDataGridView();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
