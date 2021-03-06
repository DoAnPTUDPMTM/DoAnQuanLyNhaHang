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
    public partial class frmGoiMon : Form
    {
        public string manvdn;
        ExcelExport excel = new ExcelExport();
        QuanLyBan ban = new QuanLyBan();
        QuanLyThucDon thucdon = new QuanLyThucDon();
        QuanLyGoiMon goimon = new QuanLyGoiMon();
        string idBanDaChon = "";
        int idGoiMon = 0;
        public frmGoiMon()
        {
            InitializeComponent();
        }
        public frmGoiMon(string manv)
        {
            InitializeComponent();
            manvdn = manv;
        }
        public void loadComboboxLoaiThucDon()
        {
            cboLoaiThucDon.DataSource = goimon.loadComboboxLoaiThucDon();
            cboLoaiThucDon.DisplayMember = "TenLoaiThucDon";
            cboLoaiThucDon.ValueMember = "MaLoaiThucDon";
            cboLoaiThucDon.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void frmGoiMon_Load(object sender, EventArgs e)
        {
            loadBans();
            loadMenu();
            loadComboboxLoaiThucDon();
            loadComboboxThucDon();
            loadComboboxBan();
            loadComboboxBanCanChuyen();
            loadComboboxBanTrong();
            
        }
        private void loadMenu()
        {
            DataTable dtMenu = new DataTable();
            dtMenu.Columns.Add("Mã thực đơn");
            dtMenu.Columns.Add("Tên thực đơn");
            dtMenu.Columns.Add("Giá");
            dtMenu.Columns.Add("Trạng thái");
            foreach (ThucDon td in thucdon.getThucDons())
            {
                DataRow newRow = dtMenu.NewRow();
                newRow["Mã thực đơn"] = td.MaThucDon;
                newRow["Tên thực đơn"] = td.TenThucDon;
                newRow["Giá"] = td.Gia;
                newRow["Trạng thái"] = td.TrangThai;
                dtMenu.Rows.Add(newRow);
            }
            dtgvMenu.DataSource = dtMenu;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadBans()
        {
            flpBan.Controls.Clear();
            foreach (Ban ban in goimon.getBans())
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = ban.TenBan + Environment.NewLine + ban.TrangThai;
                btn.Image = DoAnQuanLyNhaHang.Properties.Resources.icons8_restaurant_table_50;
                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Click += Btn_Click;
                btn.Tag = ban;
                goimon.setTrangThaiChoBan();
                if (ban.TrangThai == "Còn trống")
                {
                    btn.BackColor = Color.LimeGreen;

                }
                else
                {
                    btn.BackColor = Color.IndianRed;
                }
                flpBan.Controls.Add(btn);
            }
        }
        private void loadComboboxBan()
        {
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.DataSource = ban.getBans();
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            string id = ((sender as Button).Tag as Ban).MaBan;         
            idBanDaChon = id;
            cboBan.SelectedValue = id;
            showGoiMon(id);
            
        }
        private void tinhTien()
        {
            try
            {
                double tongtien = 0;
                int rowCount = dtgvMonAnDaGoi.Rows.Count;
                for (int i = 0; i < rowCount-1; i++)
                {
                    tongtien += double.Parse(dtgvMonAnDaGoi.Rows[i].Cells[7].Value.ToString());
                }
                txtTongTien.Text = tongtien.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
            
        }
        private void showGoiMon2(string id)
        {
            if (goimon.loadGoiMonByBan(id) != null)
            {
                DataTable dtGMBB = new DataTable();
                dtGMBB.Columns.Add("ID");
                dtGMBB.Columns.Add("Mã bàn");
                dtGMBB.Columns.Add("Mã thực đơn");
                dtGMBB.Columns.Add("Tên thực đơn");
                dtGMBB.Columns.Add("Giá");
                dtGMBB.Columns.Add("Số lượng");
                dtGMBB.Columns.Add("Thời gian");
                dtGMBB.Columns.Add("Thành tiền");
                foreach (GoiMon gm in ban.loadGoiMonByBan(id))
                {
                    DataRow newRow = dtGMBB.NewRow();
                    newRow["ID"] = gm.id;
                    newRow["Mã bàn"] = gm.MaBan;
                    newRow["Mã thực đơn"] = gm.MaThucDon;
                    newRow["Tên thực đơn"] = gm.TenThucDon;
                    newRow["Giá"] = gm.Gia;
                    newRow["Số lượng"] = gm.SoLuong;
                    newRow["Thời gian"] = gm.ThoiGian;
                    newRow["Thành tiền"] = gm.ThanhTien;
                    dtGMBB.Rows.Add(newRow);
                }
                dtgvMonAnDaGoi.DataSource = dtGMBB;
            }
            tinhTien();
        }
        private void showGoiMon(string id)
        {
            if (goimon.loadGoiMonByBan(id) != null)
            {
                DataTable dtGMBB = new DataTable();
                dtGMBB.Columns.Add("ID");
                
                dtGMBB.Columns.Add("Mã bàn");
                dtGMBB.Columns.Add("Mã thực đơn");
                dtGMBB.Columns.Add("Tên thực đơn");
                dtGMBB.Columns.Add("Giá");
                dtGMBB.Columns.Add("Số lượng");
                dtGMBB.Columns.Add("Thời gian");
                dtGMBB.Columns.Add("Thành tiền");
                foreach (GoiMon gm in goimon.loadGoiMonByBan(id))
                {
                    DataRow newRow = dtGMBB.NewRow();
                    newRow["ID"] = gm.id;
                    newRow["Mã bàn"] = gm.MaBan;
                    newRow["Mã thực đơn"] = gm.MaThucDon;
                    newRow["Tên thực đơn"] = gm.TenThucDon;
                    newRow["Giá"] = gm.Gia;
                    newRow["Số lượng"] = gm.SoLuong;
                    newRow["Thời gian"] = gm.ThoiGian;
                    newRow["Thành tiền"] = gm.ThanhTien;
                    dtGMBB.Rows.Add(newRow);
                }
                dtgvMonAnDaGoi.DataSource = dtGMBB;
                this.dtgvMonAnDaGoi.Columns["ID"].Visible = false;
            }
            tinhTien();

        }
        private void loadComboboxThucDon()
        {
            cboTenThucDon.DropDownStyle = ComboBoxStyle.DropDownList;
            string maloai = cboLoaiThucDon.SelectedValue.ToString();
            cboTenThucDon.DataSource = goimon.loadComboboxThucDon(maloai);
            cboTenThucDon.DisplayMember = "TenThucDon";
            cboTenThucDon.ValueMember = "MaThucDon";
        }
        private void dtgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            cboTenThucDon.SelectedValue = dtgvMenu.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            //if (idBanDaChon.Length == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn bàn muốn thêm món.");
            //    return;
            //}
            if (numSoLuong.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return;
            }
            string maban = cboBan.SelectedValue.ToString();
            string mathucdon = cboTenThucDon.SelectedValue.ToString();
            string tenthucdon = cboTenThucDon.Text;
            string gia = thucdon.getGiaByMaThucDon(mathucdon).Value.ToString();
            string soluong = numSoLuong.Value.ToString();
            goimon.themMonAn(maban,mathucdon,tenthucdon,gia,soluong);
            showGoiMon(maban);
            loadBans();
            loadComboboxBanCanChuyen();
            loadComboboxBanTrong();
            idBanDaChon = "";
        }

        private void dtgvMonAnDaGoi_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (dtgvMonAnDaGoi.Rows.Count == 0)
            {
                MessageBox.Show("Không thể xoá món ăn.");
                return;
            }

            int id = int.Parse(dtgvMonAnDaGoi.CurrentRow.Cells[0].Value.ToString());
            if (id != 0)
            {
                goimon.xoaMonAn(id);
                showGoiMon(id.ToString());
                loadBans();
                loadComboboxBanCanChuyen();
                loadComboboxBanTrong();
            }
            else
            {
                return;
            }
            
        }

        private void dtgvMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maHD = "";
            goimon.thanhToan(cboBan.SelectedValue.ToString(),manvdn,double.Parse(txtTongTien.Text),ref maHD);
            if(MessageBox.Show("Bạn có muốn in hoá đơn không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // lấy Hoá Đơn từ mã hoá đơn
                HoaDon hd = goimon.layHoaDonTuMaHoaDon(maHD);
                string name = string.Empty;
                List<ChiTietHoaDon> lstChiTietHoaDon = goimon.layDSChiTietHoaDonTuMaHoaDon(maHD);
                excel.ExportKhoa(lstChiTietHoaDon, hd, ref name, false);

                System.Diagnostics.Process.Start(name);
            }
            

            loadBans();
            loadComboboxBanCanChuyen();
            loadComboboxBanTrong();
            showGoiMon(idBanDaChon);


        }

        private void loadComboboxBanCanChuyen()
        {
            if(goimon.getBanCanChuyen().Count() == 0)
            {
                cboBanCanChuyen.Text = "";
            }
            cboBanCanChuyen.DataSource = goimon.getBanCanChuyen();
            cboBanCanChuyen.DisplayMember = "TenBan";
            cboBanCanChuyen.ValueMember = "MaBan";
        }

        private void loadComboboxBanTrong()
        {
            cboBanConTrong.DataSource = goimon.getBanConTrong();
            cboBanConTrong.DisplayMember = "TenBan";
            cboBanConTrong.ValueMember = "MaBan";
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if(cboBanCanChuyen.Text=="")
            {
                MessageBox.Show("Chuyển bàn thất bại.");
                return;
            }
            if(MessageBox.Show("Bạn có chắc muốn chuyển bàn '"+cboBanCanChuyen.Text+"' sang bàn '"+cboBanConTrong.Text+"' không?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            else
            {
                string macanchuyen = cboBanCanChuyen.SelectedValue.ToString();
                string macontrong = cboBanConTrong.SelectedValue.ToString();
                bool flag = goimon.chuyenBan(macanchuyen, macontrong);
                if (!flag)
                {
                    return;
                }
                else
                {
                    loadBans();
                }
            }
            
        }

        private void cboLoaiThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboboxThucDon();
        }
    }
}
