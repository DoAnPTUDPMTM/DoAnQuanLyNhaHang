using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyNhaHang
{
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
        }

        private void banBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.banBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Ban' table. You can move, or remove it, as needed.
            this.banTableAdapter.Fill(this.dataSet1.Ban);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtMaBan.Focus();
        }
    }
}
