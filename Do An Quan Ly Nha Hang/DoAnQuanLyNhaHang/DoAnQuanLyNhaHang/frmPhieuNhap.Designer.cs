namespace DoAnQuanLyNhaHang
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.dtgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cboMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaCTPN = new System.Windows.Forms.TextBox();
            this.cboMaPhieuNhap_CT = new System.Windows.Forms.ComboBox();
            this.cboMaNguyenLieu = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem_CT = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa_CT = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua_CT = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong_CT = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 1055);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("UTM Magnesium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1918, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Phiếu Nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtgvPhieuNhap, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.dtgvChiTietPhieuNhap, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1918, 944);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dtgvPhieuNhap
            // 
            this.dtgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPhieuNhap.Location = new System.Drawing.Point(3, 512);
            this.dtgvPhieuNhap.Name = "dtgvPhieuNhap";
            this.dtgvPhieuNhap.ReadOnly = true;
            this.dtgvPhieuNhap.RowTemplate.Height = 24;
            this.dtgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhieuNhap.Size = new System.Drawing.Size(933, 429);
            this.dtgvPhieuNhap.TabIndex = 0;
            // 
            // dtgvChiTietPhieuNhap
            // 
            this.dtgvChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietPhieuNhap.Location = new System.Drawing.Point(980, 512);
            this.dtgvChiTietPhieuNhap.Name = "dtgvChiTietPhieuNhap";
            this.dtgvChiTietPhieuNhap.ReadOnly = true;
            this.dtgvChiTietPhieuNhap.RowTemplate.Height = 24;
            this.dtgvChiTietPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietPhieuNhap.Size = new System.Drawing.Size(935, 429);
            this.dtgvChiTietPhieuNhap.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cboMaNhaCungCap);
            this.groupControl1.Controls.Add(this.cboMaNhanVien);
            this.groupControl1.Controls.Add(this.dtpNgayNhap);
            this.groupControl1.Controls.Add(this.txtMaPhieuNhap);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(933, 428);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtSoLuong);
            this.groupControl2.Controls.Add(this.cboMaNguyenLieu);
            this.groupControl2.Controls.Add(this.cboMaPhieuNhap_CT);
            this.groupControl2.Controls.Add(this.txtMaCTPN);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label9);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(980, 3);
            this.groupControl2.LookAndFeel.SkinName = "DevExpress Style";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(935, 428);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã nhà cung cấp:";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(371, 102);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(202, 23);
            this.txtMaPhieuNhap.TabIndex = 4;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(371, 176);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(371, 250);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(200, 24);
            this.cboMaNhanVien.TabIndex = 6;
            // 
            // cboMaNhaCungCap
            // 
            this.cboMaNhaCungCap.FormattingEnabled = true;
            this.cboMaNhaCungCap.Location = new System.Drawing.Point(371, 323);
            this.cboMaNhaCungCap.Name = "cboMaNhaCungCap";
            this.cboMaNhaCungCap.Size = new System.Drawing.Size(200, 24);
            this.cboMaNhaCungCap.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã nguyên liệu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mã phiếu nhập:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã chi tiết phiếu nhập:";
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.Location = new System.Drawing.Point(433, 102);
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Size = new System.Drawing.Size(202, 23);
            this.txtMaCTPN.TabIndex = 8;
            // 
            // cboMaPhieuNhap_CT
            // 
            this.cboMaPhieuNhap_CT.FormattingEnabled = true;
            this.cboMaPhieuNhap_CT.Location = new System.Drawing.Point(433, 178);
            this.cboMaPhieuNhap_CT.Name = "cboMaPhieuNhap_CT";
            this.cboMaPhieuNhap_CT.Size = new System.Drawing.Size(202, 24);
            this.cboMaPhieuNhap_CT.TabIndex = 12;
            // 
            // cboMaNguyenLieu
            // 
            this.cboMaNguyenLieu.FormattingEnabled = true;
            this.cboMaNguyenLieu.Location = new System.Drawing.Point(433, 250);
            this.cboMaNguyenLieu.Name = "cboMaNguyenLieu";
            this.cboMaNguyenLieu.Size = new System.Drawing.Size(202, 24);
            this.cboMaNguyenLieu.TabIndex = 13;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(433, 323);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(202, 23);
            this.txtSoLuong.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.154507F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.38627F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.67382F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4206F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.92275F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.44206F));
            this.tableLayoutPanel3.Controls.Add(this.btnThem, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSua, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnXoa, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnDong, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 437);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(933, 69);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.154507F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.38627F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.67382F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.4206F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.92275F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.44206F));
            this.tableLayoutPanel4.Controls.Add(this.btnThem_CT, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnXoa_CT, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSua_CT, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnDong_CT, 4, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(980, 437);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(935, 69);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image3")));
            this.btnThem.Location = new System.Drawing.Point(79, 5);
            this.btnThem.LookAndFeel.SkinName = "DevExpress Style";
            this.btnThem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 47);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(471, 5);
            this.btnSua.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSua.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 47);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image4")));
            this.btnXoa.Location = new System.Drawing.Point(269, 5);
            this.btnXoa.LookAndFeel.SkinName = "DevExpress Style";
            this.btnXoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 47);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image5")));
            this.btnDong.Location = new System.Drawing.Point(652, 5);
            this.btnDong.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(138, 47);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            // 
            // btnThem_CT
            // 
            this.btnThem_CT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnThem_CT.Location = new System.Drawing.Point(79, 5);
            this.btnThem_CT.LookAndFeel.SkinName = "DevExpress Style";
            this.btnThem_CT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThem_CT.Name = "btnThem_CT";
            this.btnThem_CT.Size = new System.Drawing.Size(138, 47);
            this.btnThem_CT.TabIndex = 6;
            this.btnThem_CT.Text = "Thêm";
            // 
            // btnXoa_CT
            // 
            this.btnXoa_CT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnXoa_CT.Location = new System.Drawing.Point(269, 5);
            this.btnXoa_CT.LookAndFeel.SkinName = "DevExpress Style";
            this.btnXoa_CT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXoa_CT.Name = "btnXoa_CT";
            this.btnXoa_CT.Size = new System.Drawing.Size(138, 47);
            this.btnXoa_CT.TabIndex = 7;
            this.btnXoa_CT.Text = "Xoá";
            // 
            // btnSua_CT
            // 
            this.btnSua_CT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btnSua_CT.Location = new System.Drawing.Point(471, 5);
            this.btnSua_CT.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSua_CT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSua_CT.Name = "btnSua_CT";
            this.btnSua_CT.Size = new System.Drawing.Size(138, 47);
            this.btnSua_CT.TabIndex = 8;
            this.btnSua_CT.Text = "Sửa";
            // 
            // btnDong_CT
            // 
            this.btnDong_CT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDong_CT.Location = new System.Drawing.Point(652, 5);
            this.btnDong_CT.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDong_CT.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDong_CT.Name = "btnDong_CT";
            this.btnDong_CT.Size = new System.Drawing.Size(138, 47);
            this.btnDong_CT.TabIndex = 9;
            this.btnDong_CT.Text = "Đóng";
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgvPhieuNhap;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaNhaCungCap;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMaNguyenLieu;
        private System.Windows.Forms.ComboBox cboMaPhieuNhap_CT;
        private System.Windows.Forms.TextBox txtMaCTPN;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btnThem_CT;
        private DevExpress.XtraEditors.SimpleButton btnXoa_CT;
        private DevExpress.XtraEditors.SimpleButton btnSua_CT;
        private DevExpress.XtraEditors.SimpleButton btnDong_CT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}