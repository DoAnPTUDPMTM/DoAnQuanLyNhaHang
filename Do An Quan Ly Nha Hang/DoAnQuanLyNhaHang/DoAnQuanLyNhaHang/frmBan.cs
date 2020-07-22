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
    }
}
