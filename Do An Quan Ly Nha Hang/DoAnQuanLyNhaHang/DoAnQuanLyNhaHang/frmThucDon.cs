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
    public partial class frmThucDon : Form
    {
        QuanLyThucDon qltd = new QuanLyThucDon();
        public frmThucDon()
        {
            InitializeComponent();
        }

        private void frmThucDon_Load(object sender, EventArgs e)
        {
            loadTrangThaiThucDon();
            loadLoaiThucDon();
            loadDatagridviewThucDon();
        }

        private void loadTrangThaiThucDon()
        {
            cboTrangThaiThucDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThaiThucDon.Items.Add("Còn hàng");
            cboTrangThaiThucDon.Items.Add("Hết hàng");
        }

        private void loadLoaiThucDon()
        {
            cboLoaiThucDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThucDon.DataSource = qltd.getLoaiThucDons();
            cboLoaiThucDon.DisplayMember = "TenLoaiThucDon";
            cboLoaiThucDon.ValueMember = "MaLoaiThucDon";
        }

        private void loadDatagridviewThucDon()
        {
            DataTable dtThucDon = new DataTable();
            dtThucDon.Columns.Add("Mã Thực Đơn");
            dtThucDon.Columns.Add("Mã Loại Thực Đơn");
            dtThucDon.Columns.Add("Tên Thực Đơn");
            dtThucDon.Columns.Add("Giá");
            dtThucDon.Columns.Add("Trạng Thái");
            foreach (ThucDon td in qltd.getThucDons())
            {
                DataRow newRow = dtThucDon.NewRow();
                newRow["Mã Thực Đơn"] = td.MaThucDon.ToString();
                newRow["Mã Loại Thực Đơn"] = td.MaLoaiThucDon.ToString();
                newRow["Tên Thực Đơn"] = td.TenThucDon.ToString();
                newRow["Giá"] = td.Gia.ToString();
                newRow["Trạng Thái"] = td.TrangThai.ToString();
                dtThucDon.Rows.Add(newRow);
            }
            dtgvThucDon.DataSource = dtThucDon;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            qltd.themThucDon(txtMaThucDon.Text,cboLoaiThucDon.SelectedValue.ToString(),txtTenThucDon.Text,float.Parse(txtGiaThucDon.Text),cboTrangThaiThucDon.SelectedItem.ToString());
            loadDatagridviewThucDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xoá thực đơn '"+txtTenThucDon.Text+"'?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string mathucdon = dtgvThucDon.CurrentRow.Cells[0].Value.ToString();
                string tenthucdon = dtgvThucDon.CurrentRow.Cells[2].Value.ToString();
                bool flag = qltd.xoaThucDon(mathucdon);
                if (flag)
                {
                    MessageBox.Show("Đã xoá '" + tenthucdon + "' thành công");
                }
                else
                {
                    MessageBox.Show("Không xoá được '" + tenthucdon + "'");
                }
                loadDatagridviewThucDon();
            }
            else
            {
                return;
            }
            
        }

        private void dtgvThucDon_SelectionChanged(object sender, EventArgs e)
        {
            cboLoaiThucDon.SelectedValue = dtgvThucDon.CurrentRow.Cells[1].Value.ToString();
            txtMaThucDon.Text = dtgvThucDon.CurrentRow.Cells[0].Value.ToString();
            txtTenThucDon.Text = dtgvThucDon.CurrentRow.Cells[2].Value.ToString();
            txtGiaThucDon.Text = dtgvThucDon.CurrentRow.Cells[3].Value.ToString();
            cboTrangThaiThucDon.Text = dtgvThucDon.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maloaithucdon = cboLoaiThucDon.SelectedValue.ToString();
            qltd.suaThucDon(txtMaThucDon.Text, maloaithucdon, txtTenThucDon.Text, float.Parse(txtGiaThucDon.Text), cboTrangThaiThucDon.Text);
            loadDatagridviewThucDon();
        }
    }
}
