namespace DoAnQuanLyNhaHang
{
    partial class frmGoiMon
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvMonAnDaGoi = new System.Windows.Forms.DataGridView();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMenu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboTenThucDon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBanConTrong = new System.Windows.Forms.ComboBox();
            this.cboBanCanChuyen = new System.Windows.Forms.ComboBox();
            this.btnChuyenBan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAnDaGoi)).BeginInit();
            this.flpBan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvMonAnDaGoi);
            this.panel2.Location = new System.Drawing.Point(500, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 287);
            this.panel2.TabIndex = 1;
            // 
            // dtgvMonAnDaGoi
            // 
            this.dtgvMonAnDaGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonAnDaGoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvMonAnDaGoi.Location = new System.Drawing.Point(0, 3);
            this.dtgvMonAnDaGoi.Name = "dtgvMonAnDaGoi";
            this.dtgvMonAnDaGoi.RowTemplate.Height = 24;
            this.dtgvMonAnDaGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMonAnDaGoi.Size = new System.Drawing.Size(867, 284);
            this.dtgvMonAnDaGoi.TabIndex = 0;
            this.dtgvMonAnDaGoi.SizeChanged += new System.EventHandler(this.dtgvMonAnDaGoi_SizeChanged);
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Controls.Add(this.flowLayoutPanel2);
            this.flpBan.Location = new System.Drawing.Point(12, 44);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(482, 723);
            this.flpBan.TabIndex = 2;
            this.flpBan.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMenu);
            this.panel1.Location = new System.Drawing.Point(500, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 223);
            this.panel1.TabIndex = 2;
            // 
            // dtgvMenu
            // 
            this.dtgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvMenu.Location = new System.Drawing.Point(0, 0);
            this.dtgvMenu.Name = "dtgvMenu";
            this.dtgvMenu.ReadOnly = true;
            this.dtgvMenu.RowTemplate.Height = 24;
            this.dtgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMenu.Size = new System.Drawing.Size(862, 220);
            this.dtgvMenu.TabIndex = 1;
            this.dtgvMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMenu_CellClick);
            this.dtgvMenu.SelectionChanged += new System.EventHandler(this.dtgvMenu_SelectionChanged);
            this.dtgvMenu.Click += new System.EventHandler(this.dtgvMenu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("UTM Magnesium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("UTM Magnesium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(500, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(867, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Các món ăn đã gọi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(740, 484);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(96, 31);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(877, 342);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(96, 31);
            this.btnXoaMon.TabIndex = 6;
            this.btnXoaMon.Text = "Xoá món";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("UTM Magnesium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(500, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(867, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gọi món";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1070, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng tiền:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1151, 341);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(156, 28);
            this.txtTongTien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1313, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "VNĐ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên thực đơn:";
            // 
            // cboTenThucDon
            // 
            this.cboTenThucDon.FormattingEnabled = true;
            this.cboTenThucDon.Location = new System.Drawing.Point(871, 438);
            this.cboTenThucDon.Name = "cboTenThucDon";
            this.cboTenThucDon.Size = new System.Drawing.Size(229, 24);
            this.cboTenThucDon.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1138, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(1212, 439);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(67, 22);
            this.numSoLuong.TabIndex = 14;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(888, 484);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(96, 31);
            this.btnThanhToan.TabIndex = 15;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(1029, 484);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(96, 31);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "In Hoá Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bàn:";
            // 
            // cboBan
            // 
            this.cboBan.FormattingEnabled = true;
            this.cboBan.Location = new System.Drawing.Point(634, 438);
            this.cboBan.Name = "cboBan";
            this.cboBan.Size = new System.Drawing.Size(119, 24);
            this.cboBan.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("UTM Magnesium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1377, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Chuyển bàn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboBanConTrong
            // 
            this.cboBanConTrong.FormattingEnabled = true;
            this.cboBanConTrong.Location = new System.Drawing.Point(289, 65);
            this.cboBanConTrong.Name = "cboBanConTrong";
            this.cboBanConTrong.Size = new System.Drawing.Size(137, 24);
            this.cboBanConTrong.TabIndex = 20;
            // 
            // cboBanCanChuyen
            // 
            this.cboBanCanChuyen.FormattingEnabled = true;
            this.cboBanCanChuyen.Location = new System.Drawing.Point(8, 65);
            this.cboBanCanChuyen.Name = "cboBanCanChuyen";
            this.cboBanCanChuyen.Size = new System.Drawing.Size(147, 24);
            this.cboBanCanChuyen.TabIndex = 21;
            // 
            // btnChuyenBan
            // 
            this.btnChuyenBan.Location = new System.Drawing.Point(181, 53);
            this.btnChuyenBan.Name = "btnChuyenBan";
            this.btnChuyenBan.Size = new System.Drawing.Size(78, 47);
            this.btnChuyenBan.TabIndex = 22;
            this.btnChuyenBan.Text = "Chuyển bàn";
            this.btnChuyenBan.UseVisualStyleBackColor = true;
            this.btnChuyenBan.Click += new System.EventHandler(this.btnChuyenBan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Bàn cần chuyển";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Bàn còn trống";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboBanConTrong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cboBanCanChuyen);
            this.groupBox1.Controls.Add(this.btnChuyenBan);
            this.groupBox1.Location = new System.Drawing.Point(1373, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 119);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // frmGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1820, 779);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboBan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTenThucDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.panel2);
            this.Name = "frmGoiMon";
            this.Text = "Gọi món";
            this.Load += new System.EventHandler(this.frmGoiMon_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonAnDaGoi)).EndInit();
            this.flpBan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.DataGridView dtgvMonAnDaGoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenThucDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBanConTrong;
        private System.Windows.Forms.ComboBox cboBanCanChuyen;
        private System.Windows.Forms.Button btnChuyenBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}