namespace DoAnQuanLyNhaHang
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hoatDongLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.taiKhoanTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHoatDong = new System.Windows.Forms.CheckBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hoatDongLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(257, 84);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(113, 17);
            tenDangNhapLabel.TabIndex = 0;
            tenDangNhapLabel.Text = "Tên Đăng Nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(257, 112);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(72, 17);
            matKhauLabel.TabIndex = 0;
            matKhauLabel.Text = "Mật Khẩu:";
            // 
            // hoatDongLabel
            // 
            hoatDongLabel.AutoSize = true;
            hoatDongLabel.Location = new System.Drawing.Point(257, 142);
            hoatDongLabel.Name = "hoatDongLabel";
            hoatDongLabel.Size = new System.Drawing.Size(80, 17);
            hoatDongLabel.TabIndex = 0;
            hoatDongLabel.Text = "Hoạt Động:";
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(3, 258);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTaiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(795, 236);
            this.dtgvTaiKhoan.TabIndex = 4;
            this.dtgvTaiKhoan.SelectionChanged += new System.EventHandler(this.dtgvTaiKhoan_SelectionChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(135, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(262, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 34);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(406, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 34);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(553, 196);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(94, 34);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "TÀI KHOẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHoatDong
            // 
            this.cbHoatDong.AutoSize = true;
            this.cbHoatDong.Location = new System.Drawing.Point(377, 142);
            this.cbHoatDong.Name = "cbHoatDong";
            this.cbHoatDong.Size = new System.Drawing.Size(18, 17);
            this.cbHoatDong.TabIndex = 10;
            this.cbHoatDong.UseVisualStyleBackColor = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(377, 78);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(185, 22);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(377, 112);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(185, 22);
            this.txtMatKhau.TabIndex = 12;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 494);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbHoatDong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvTaiKhoan);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(hoatDongLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTaiKhoan";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DataSet1TableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHoatDong;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}