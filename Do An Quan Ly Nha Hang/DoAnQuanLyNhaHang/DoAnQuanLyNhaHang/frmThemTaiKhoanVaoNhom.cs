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
    public partial class frmThemTaiKhoanVaoNhom : Form
    {
        public frmThemTaiKhoanVaoNhom()
        {
            InitializeComponent();
        }

        private void fill_TaiKhoanTrongNhomToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void frmThemTaiKhoanVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TaiKhoanNhomTaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanNhomTaiKhoanTableAdapter.Fill(this.dataSet1.TaiKhoanNhomTaiKhoan);
            // TODO: This line of code loads data into the 'dataSet1.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.dataSet1.TaiKhoan);
            // TODO: This line of code loads data into the 'dataSet1.NhomTaiKhoan' table. You can move, or remove it, as needed.
            this.nhomTaiKhoanTableAdapter.Fill(this.dataSet1.NhomTaiKhoan);

        }

        private void nhomTaiKhoanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.taiKhoanTrongNhomTableAdapter.Fill_TaiKhoanTrongNhom(this.dataSet1.TaiKhoanTrongNhom, nhomTaiKhoanComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in taiKhoanDataGridView.SelectedRows)
            {
                if (taiKhoanTrongNhomTableAdapter.KiemTraKhoaChinh(item.Cells[0].Value.ToString(), nhomTaiKhoanComboBox.SelectedValue.ToString()) != null)
                {
                    MessageBox.Show("Đã tồn tại");
                    return;
                }
                else
                {
                    taiKhoanNhomTaiKhoanTableAdapter.Insert(item.Cells[0].Value.ToString(), nhomTaiKhoanComboBox.SelectedValue.ToString(), "");
                    taiKhoanTrongNhomTableAdapter.Fill_TaiKhoanTrongNhom(dataSet1.TaiKhoanTrongNhom, nhomTaiKhoanComboBox.SelectedValue.ToString());
                    MessageBox.Show("Thêm thành công " + item.Cells[0].Value.ToString() + " vào nhóm " + nhomTaiKhoanComboBox.Text + "");
                }
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in taiKhoanTrongNhomDataGridView.SelectedRows)
            {
                if (MessageBox.Show("Bạn có muốn xoá "+item.Cells[0].Value.ToString()+" ra khỏi nhóm "+nhomTaiKhoanComboBox.Text+" không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                {                  
                    return;
                }
                else
                {
                    taiKhoanNhomTaiKhoanTableAdapter.Delete(item.Cells[0].Value.ToString(), nhomTaiKhoanComboBox.SelectedValue.ToString(),item.Cells[2].Value.ToString());
                    taiKhoanTrongNhomTableAdapter.Fill_TaiKhoanTrongNhom(dataSet1.TaiKhoanTrongNhom, nhomTaiKhoanComboBox.SelectedValue.ToString());
                    MessageBox.Show("Xoá thành công!");
                }
            }
        }
    }
}
