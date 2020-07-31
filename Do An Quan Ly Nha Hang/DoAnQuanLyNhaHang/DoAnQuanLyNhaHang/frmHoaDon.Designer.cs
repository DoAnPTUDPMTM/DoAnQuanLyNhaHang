namespace DoAnQuanLyNhaHang
{
    partial class frmHoaDon
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
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaChiTietHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon_CTHD = new System.Windows.Forms.TextBox();
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.btnXoaHoaDon = new System.Windows.Forms.Button();
            this.btnSuaHoaDon = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnDongHoaDon = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnHuyChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnDongChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnLuuChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnSuaChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnXoaChiTietHoaDon = new System.Windows.Forms.Button();
            this.btnThemChiTietHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvHoaDon.Location = new System.Drawing.Point(3, 297);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.ReadOnly = true;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(825, 313);
            this.dtgvHoaDon.TabIndex = 0;
            this.dtgvHoaDon.SelectionChanged += new System.EventHandler(this.dtgvHoaDon_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuyHoaDon);
            this.groupBox1.Controls.Add(this.btnDongHoaDon);
            this.groupBox1.Controls.Add(this.btnLuuHoaDon);
            this.groupBox1.Controls.Add(this.btnSuaHoaDon);
            this.groupBox1.Controls.Add(this.btnXoaHoaDon);
            this.groupBox1.Controls.Add(this.btnThemHoaDon);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtMaKhachHang);
            this.groupBox1.Controls.Add(this.txtMaBan);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgvHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 613);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hoá Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuyChiTietHoaDon);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.btnDongChiTietHoaDon);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.btnLuuChiTietHoaDon);
            this.groupBox2.Controls.Add(this.btnSuaChiTietHoaDon);
            this.groupBox2.Controls.Add(this.txtMaThucDon);
            this.groupBox2.Controls.Add(this.btnXoaChiTietHoaDon);
            this.groupBox2.Controls.Add(this.txtMaHoaDon_CTHD);
            this.groupBox2.Controls.Add(this.btnThemChiTietHoaDon);
            this.groupBox2.Controls.Add(this.txtMaChiTietHoaDon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtgvChiTietHoaDon);
            this.groupBox2.Location = new System.Drawing.Point(896, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 613);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hoá Đơn";
            // 
            // dtgvChiTietHoaDon
            // 
            this.dtgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvChiTietHoaDon.Location = new System.Drawing.Point(3, 297);
            this.dtgvChiTietHoaDon.Name = "dtgvChiTietHoaDon";
            this.dtgvChiTietHoaDon.ReadOnly = true;
            this.dtgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dtgvChiTietHoaDon.Size = new System.Drawing.Size(825, 313);
            this.dtgvChiTietHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày tạo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền:";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(153, 37);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(188, 22);
            this.txtMaHoaDon.TabIndex = 7;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(153, 98);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(188, 22);
            this.txtMaBan.TabIndex = 8;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(153, 158);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(188, 22);
            this.txtMaKhachHang.TabIndex = 9;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(564, 37);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(188, 22);
            this.txtMaNhanVien.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(564, 158);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(188, 22);
            this.txtTongTien.TabIndex = 11;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(564, 96);
            this.dtpNgayTao.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(188, 22);
            this.dtpNgayTao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã chi tiết hoá đơn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã hoá đơn:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã thực đơn:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Thành tiền:";
            // 
            // txtMaChiTietHoaDon
            // 
            this.txtMaChiTietHoaDon.Location = new System.Drawing.Point(212, 39);
            this.txtMaChiTietHoaDon.Name = "txtMaChiTietHoaDon";
            this.txtMaChiTietHoaDon.ReadOnly = true;
            this.txtMaChiTietHoaDon.Size = new System.Drawing.Size(188, 22);
            this.txtMaChiTietHoaDon.TabIndex = 13;
            // 
            // txtMaHoaDon_CTHD
            // 
            this.txtMaHoaDon_CTHD.Location = new System.Drawing.Point(212, 101);
            this.txtMaHoaDon_CTHD.Name = "txtMaHoaDon_CTHD";
            this.txtMaHoaDon_CTHD.Size = new System.Drawing.Size(188, 22);
            this.txtMaHoaDon_CTHD.TabIndex = 18;
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Location = new System.Drawing.Point(573, 39);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(188, 22);
            this.txtMaThucDon.TabIndex = 19;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(573, 98);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(188, 22);
            this.txtSoLuong.TabIndex = 20;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(212, 158);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(188, 22);
            this.txtThanhTien.TabIndex = 21;
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(31, 238);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnThemHoaDon.TabIndex = 13;
            this.btnThemHoaDon.Text = "Thêm";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoaHoaDon
            // 
            this.btnXoaHoaDon.Location = new System.Drawing.Point(153, 238);
            this.btnXoaHoaDon.Name = "btnXoaHoaDon";
            this.btnXoaHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnXoaHoaDon.TabIndex = 14;
            this.btnXoaHoaDon.Text = "Xoá";
            this.btnXoaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSuaHoaDon
            // 
            this.btnSuaHoaDon.Location = new System.Drawing.Point(290, 238);
            this.btnSuaHoaDon.Name = "btnSuaHoaDon";
            this.btnSuaHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnSuaHoaDon.TabIndex = 15;
            this.btnSuaHoaDon.Text = "Sửa";
            this.btnSuaHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(434, 238);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnLuuHoaDon.TabIndex = 16;
            this.btnLuuHoaDon.Text = "Lưu";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnDongHoaDon
            // 
            this.btnDongHoaDon.Location = new System.Drawing.Point(693, 238);
            this.btnDongHoaDon.Name = "btnDongHoaDon";
            this.btnDongHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnDongHoaDon.TabIndex = 17;
            this.btnDongHoaDon.Text = "Đóng";
            this.btnDongHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(564, 238);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnHuyHoaDon.TabIndex = 18;
            this.btnHuyHoaDon.Text = "Huỷ";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHuyChiTietHoaDon
            // 
            this.btnHuyChiTietHoaDon.Location = new System.Drawing.Point(574, 224);
            this.btnHuyChiTietHoaDon.Name = "btnHuyChiTietHoaDon";
            this.btnHuyChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnHuyChiTietHoaDon.TabIndex = 24;
            this.btnHuyChiTietHoaDon.Text = "Huỷ";
            this.btnHuyChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnDongChiTietHoaDon
            // 
            this.btnDongChiTietHoaDon.Location = new System.Drawing.Point(703, 224);
            this.btnDongChiTietHoaDon.Name = "btnDongChiTietHoaDon";
            this.btnDongChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnDongChiTietHoaDon.TabIndex = 23;
            this.btnDongChiTietHoaDon.Text = "Đóng";
            this.btnDongChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLuuChiTietHoaDon
            // 
            this.btnLuuChiTietHoaDon.Location = new System.Drawing.Point(444, 224);
            this.btnLuuChiTietHoaDon.Name = "btnLuuChiTietHoaDon";
            this.btnLuuChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnLuuChiTietHoaDon.TabIndex = 22;
            this.btnLuuChiTietHoaDon.Text = "Lưu";
            this.btnLuuChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnSuaChiTietHoaDon
            // 
            this.btnSuaChiTietHoaDon.Location = new System.Drawing.Point(300, 224);
            this.btnSuaChiTietHoaDon.Name = "btnSuaChiTietHoaDon";
            this.btnSuaChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnSuaChiTietHoaDon.TabIndex = 21;
            this.btnSuaChiTietHoaDon.Text = "Sửa";
            this.btnSuaChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXoaChiTietHoaDon
            // 
            this.btnXoaChiTietHoaDon.Location = new System.Drawing.Point(163, 224);
            this.btnXoaChiTietHoaDon.Name = "btnXoaChiTietHoaDon";
            this.btnXoaChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnXoaChiTietHoaDon.TabIndex = 20;
            this.btnXoaChiTietHoaDon.Text = "Xoá";
            this.btnXoaChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThemChiTietHoaDon
            // 
            this.btnThemChiTietHoaDon.Location = new System.Drawing.Point(41, 224);
            this.btnThemChiTietHoaDon.Name = "btnThemChiTietHoaDon";
            this.btnThemChiTietHoaDon.Size = new System.Drawing.Size(82, 38);
            this.btnThemChiTietHoaDon.TabIndex = 19;
            this.btnThemChiTietHoaDon.Text = "Thêm";
            this.btnThemChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietHoaDon;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnDongHoaDon;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnSuaHoaDon;
        private System.Windows.Forms.Button btnXoaHoaDon;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.Button btnHuyChiTietHoaDon;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnDongChiTietHoaDon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnLuuChiTietHoaDon;
        private System.Windows.Forms.Button btnSuaChiTietHoaDon;
        private System.Windows.Forms.TextBox txtMaThucDon;
        private System.Windows.Forms.Button btnXoaChiTietHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon_CTHD;
        private System.Windows.Forms.Button btnThemChiTietHoaDon;
        private System.Windows.Forms.TextBox txtMaChiTietHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}