namespace DoAnQuanLyNhaHang
{
    partial class frmThucDon
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
            this.dtgvThucDon = new System.Windows.Forms.DataGridView();
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.txtTenThucDon = new System.Windows.Forms.TextBox();
            this.txtGiaThucDon = new System.Windows.Forms.TextBox();
            this.cboLoaiThucDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTrangThaiThucDon = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvThucDon
            // 
            this.dtgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThucDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvThucDon.Location = new System.Drawing.Point(0, 324);
            this.dtgvThucDon.Name = "dtgvThucDon";
            this.dtgvThucDon.RowTemplate.Height = 24;
            this.dtgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThucDon.Size = new System.Drawing.Size(1015, 369);
            this.dtgvThucDon.TabIndex = 0;
            this.dtgvThucDon.SelectionChanged += new System.EventHandler(this.dtgvThucDon_SelectionChanged);
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Location = new System.Drawing.Point(263, 145);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(193, 22);
            this.txtMaThucDon.TabIndex = 2;
            // 
            // txtTenThucDon
            // 
            this.txtTenThucDon.Location = new System.Drawing.Point(263, 186);
            this.txtTenThucDon.Name = "txtTenThucDon";
            this.txtTenThucDon.Size = new System.Drawing.Size(193, 22);
            this.txtTenThucDon.TabIndex = 3;
            // 
            // txtGiaThucDon
            // 
            this.txtGiaThucDon.Location = new System.Drawing.Point(664, 97);
            this.txtGiaThucDon.Name = "txtGiaThucDon";
            this.txtGiaThucDon.Size = new System.Drawing.Size(193, 22);
            this.txtGiaThucDon.TabIndex = 4;
            // 
            // cboLoaiThucDon
            // 
            this.cboLoaiThucDon.FormattingEnabled = true;
            this.cboLoaiThucDon.Location = new System.Drawing.Point(263, 95);
            this.cboLoaiThucDon.Name = "cboLoaiThucDon";
            this.cboLoaiThucDon.Size = new System.Drawing.Size(193, 24);
            this.cboLoaiThucDon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại thực đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã thực đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên thực đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá thực đơn:";
            // 
            // cboTrangThaiThucDon
            // 
            this.cboTrangThaiThucDon.FormattingEnabled = true;
            this.cboTrangThaiThucDon.Location = new System.Drawing.Point(664, 169);
            this.cboTrangThaiThucDon.Name = "cboTrangThaiThucDon";
            this.cboTrangThaiThucDon.Size = new System.Drawing.Size(193, 24);
            this.cboTrangThaiThucDon.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trạng thái:";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_add_new_40;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(305, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 42);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_delete_40;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(423, 250);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 42);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_update_40;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(534, 250);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 42);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_cancel_40;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(664, 250);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(93, 42);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("UTM Magnesium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1015, 69);
            this.label6.TabIndex = 12;
            this.label6.Text = "THỰC ĐƠN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 693);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTrangThaiThucDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLoaiThucDon);
            this.Controls.Add(this.txtGiaThucDon);
            this.Controls.Add(this.txtTenThucDon);
            this.Controls.Add(this.txtMaThucDon);
            this.Controls.Add(this.dtgvThucDon);
            this.Name = "frmThucDon";
            this.Text = "frmThucDon";
            this.Load += new System.EventHandler(this.frmThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThucDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvThucDon;
        private System.Windows.Forms.TextBox txtMaThucDon;
        private System.Windows.Forms.TextBox txtTenThucDon;
        private System.Windows.Forms.TextBox txtGiaThucDon;
        private System.Windows.Forms.ComboBox cboLoaiThucDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTrangThaiThucDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label6;
    }
}