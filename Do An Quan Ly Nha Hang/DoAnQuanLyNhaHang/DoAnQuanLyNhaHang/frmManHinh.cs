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
    public partial class frmManHinh : Form
    {
        public frmManHinh()
        {
            InitializeComponent();
        }

        private void manHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (tenManHinhTextBox.TextLength == 0 || maManHinhTextBox.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin màn hình");
                return;
            }
            this.Validate();
            this.manHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);
            MessageBox.Show("Lưu thành công");
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ManHinh' table. You can move, or remove it, as needed.
            this.manHinhTableAdapter.Fill(this.dataSet1.ManHinh);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            maManHinhTextBox.Focus();           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                frmManHinh_Load(sender, e);
                return;
            }
            else
            {
                manHinhBindingNavigatorSaveItem_Click(sender, e);
                
            }
        }
    }
}
