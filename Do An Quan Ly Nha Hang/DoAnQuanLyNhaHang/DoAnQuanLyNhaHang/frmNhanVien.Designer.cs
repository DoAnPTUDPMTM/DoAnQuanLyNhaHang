namespace DoAnQuanLyNhaHang
{
    partial class frmNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNhanVienLabel;
            System.Windows.Forms.Label tenNhanVienLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboTaiKhoan = new System.Windows.Forms.ComboBox();
            this.grbGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            maNhanVienLabel = new System.Windows.Forms.Label();
            tenNhanVienLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.grbGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(71, 70);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(95, 17);
            maNhanVienLabel.TabIndex = 2;
            maNhanVienLabel.Text = "Mã Nhân Viên:";
            // 
            // tenNhanVienLabel
            // 
            tenNhanVienLabel.AutoSize = true;
            tenNhanVienLabel.Location = new System.Drawing.Point(71, 103);
            tenNhanVienLabel.Name = "tenNhanVienLabel";
            tenNhanVienLabel.Size = new System.Drawing.Size(101, 17);
            tenNhanVienLabel.TabIndex = 4;
            tenNhanVienLabel.Text = "Tên Nhân Viên:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(71, 137);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
            ngaySinhLabel.TabIndex = 6;
            ngaySinhLabel.Text = "Ngày Sinh:";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(71, 177);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(64, 17);
            gioiTinhLabel.TabIndex = 8;
            gioiTinhLabel.Text = "Giới Tính:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(71, 211);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(77, 17);
            dienThoaiLabel.TabIndex = 10;
            dienThoaiLabel.Text = "Điện Thoại:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(71, 253);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 17);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(71, 294);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(55, 17);
            diaChiLabel.TabIndex = 14;
            diaChiLabel.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(71, 332);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 17);
            label1.TabIndex = 23;
            label1.Text = "Tài khoản:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSet1;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNhanVien", true));
            this.txtMaNhanVien.Location = new System.Drawing.Point(184, 67);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(200, 23);
            this.txtMaNhanVien.TabIndex = 3;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNhanVien", true));
            this.txtTenNhanVien.Location = new System.Drawing.Point(184, 100);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(200, 23);
            this.txtTenNhanVien.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgaySinh", true));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(184, 133);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 23);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DienThoai", true));
            this.txtDienThoai.Location = new System.Drawing.Point(184, 208);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 23);
            this.txtDienThoai.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(184, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DiaChi", true));
            this.txtDiaChi.Location = new System.Drawing.Point(184, 291);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 23);
            this.txtDiaChi.TabIndex = 15;
            // 
            // cboTaiKhoan
            // 
            this.cboTaiKhoan.FormattingEnabled = true;
            this.cboTaiKhoan.Location = new System.Drawing.Point(184, 329);
            this.cboTaiKhoan.Name = "cboTaiKhoan";
            this.cboTaiKhoan.Size = new System.Drawing.Size(200, 24);
            this.cboTaiKhoan.TabIndex = 22;
            // 
            // grbGioiTinh
            // 
            this.grbGioiTinh.Controls.Add(this.radNu);
            this.grbGioiTinh.Controls.Add(this.radNam);
            this.grbGioiTinh.Location = new System.Drawing.Point(184, 161);
            this.grbGioiTinh.Name = "grbGioiTinh";
            this.grbGioiTinh.Size = new System.Drawing.Size(200, 41);
            this.grbGioiTinh.TabIndex = 22;
            this.grbGioiTinh.TabStop = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(119, 12);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(18, 12);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 21);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.dataSet1;
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvNhanVien.Location = new System.Drawing.Point(0, 527);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.ReadOnly = true;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1321, 366);
            this.dtgvNhanVien.TabIndex = 21;
            this.dtgvNhanVien.SelectionChanged += new System.EventHandler(this.dtgvNhanVien_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(715, 482);
            this.btnThem.LookAndFeel.SkinName = "DevExpress Style";
            this.btnThem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 39);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(869, 482);
            this.btnXoa.LookAndFeel.SkinName = "DevExpress Style";
            this.btnXoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 39);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnSua.Location = new System.Drawing.Point(1026, 482);
            this.btnSua.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSua.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 39);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image2")));
            this.btnDong.Location = new System.Drawing.Point(1176, 482);
            this.btnDong.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 39);
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(maNhanVienLabel);
            this.groupControl1.Controls.Add(this.cboTaiKhoan);
            this.groupControl1.Controls.Add(gioiTinhLabel);
            this.groupControl1.Controls.Add(this.grbGioiTinh);
            this.groupControl1.Controls.Add(dienThoaiLabel);
            this.groupControl1.Controls.Add(this.dtpNgaySinh);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtDienThoai);
            this.groupControl1.Controls.Add(this.txtMaNhanVien);
            this.groupControl1.Controls.Add(ngaySinhLabel);
            this.groupControl1.Controls.Add(diaChiLabel);
            this.groupControl1.Controls.Add(emailLabel);
            this.groupControl1.Controls.Add(tenNhanVienLabel);
            this.groupControl1.Controls.Add(this.txtTenNhanVien);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Location = new System.Drawing.Point(777, 57);
            this.groupControl1.LookAndFeel.SkinName = "DevExpress Style";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(450, 378);
            this.groupControl1.TabIndex = 26;
            this.groupControl1.Text = "Thông Tin Nhân Viên";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1321, 893);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNhanVien);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.grbGioiTinh.ResumeLayout(false);
            this.grbGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.GroupBox grbGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.ComboBox cboTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}