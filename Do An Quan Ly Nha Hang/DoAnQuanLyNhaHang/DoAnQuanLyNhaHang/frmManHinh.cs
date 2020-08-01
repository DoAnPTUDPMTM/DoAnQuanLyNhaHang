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
    public partial class frmManHinh : Form
    {
        int flag = 0;
        
        QuanLyManHinh qlmh = new QuanLyManHinh();
        public frmManHinh()
        {
            InitializeComponent();
        }
        private void loadDatagridviewManHinh()
        {
            manHinhDataGridView.DataSource = qlmh.loadDatagridviewManHinh();
        }
        private void manHinhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (tenManHinhTextBox.TextLength == 0 || maManHinhTextBox.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin màn hình");
                return;
            }
            if(flag==1) // khi thêm
            {
                string mamanhinh = maManHinhTextBox.Text;
                qlmh.themMaManHinhVaoPhanQuyen(mamanhinh);
            }
            //else if(flag == 2)
            //{
            //    qlmh.xoaManHinhVaXoaTrongPhanQuyen(mamanhinh);
            //}
            
            this.Validate();
            this.manHinhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

            MessageBox.Show("Lưu thành công");
        }

        private void frmManHinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ManHinh' table. You can move, or remove it, as needed.
            loadDatagridviewManHinh();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            flag = 1;
            maManHinhTextBox.Focus();           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            flag = 2;
            
               
                
            
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

        private void manHinhDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            maManHinhTextBox.Text = manHinhDataGridView.CurrentRow.Cells[0].Value.ToString();
            tenManHinhTextBox.Text = manHinhDataGridView.CurrentRow.Cells[1].Value.ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                string mamanhinh = manHinhDataGridView.CurrentRow.Cells[0].Value.ToString();
                qlmh.xoaManHinh(mamanhinh);
                loadDatagridviewManHinh();
            }
            else
            {
                return;
            }
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qlmh.themManHinh(maManHinhTextBox.Text,tenManHinhTextBox.Text);
            loadDatagridviewManHinh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            qlmh.suaManHinh(maManHinhTextBox.Text,tenManHinhTextBox.Text);
            loadDatagridviewManHinh();
        }
    }
}
