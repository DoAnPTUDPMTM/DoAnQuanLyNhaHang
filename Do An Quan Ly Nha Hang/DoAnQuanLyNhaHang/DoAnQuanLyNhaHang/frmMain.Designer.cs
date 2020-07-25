namespace DoAnQuanLyNhaHang
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.gọiMónToolStripMenuItem,
            this.btnDangXuat,
            this.btnDoanhThu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(69, 10);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(46, 17);
            this.lblTenNhanVien.TabIndex = 1;
            this.lblTenNhanVien.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTenNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 36);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên NV:";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.nhómTàiKhoảnToolStripMenuItem,
            this.mànHìnhToolStripMenuItem,
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_system_task_50;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(106, 51);
            this.hệThốngToolStripMenuItem.Tag = "0";
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.tàiKhoảnToolStripMenuItem.Tag = "SF001";
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // nhómTàiKhoảnToolStripMenuItem
            // 
            this.nhómTàiKhoảnToolStripMenuItem.Name = "nhómTàiKhoảnToolStripMenuItem";
            this.nhómTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.nhómTàiKhoảnToolStripMenuItem.Tag = "SF002";
            this.nhómTàiKhoảnToolStripMenuItem.Text = "Nhóm Tài Khoản";
            this.nhómTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.nhómTàiKhoảnToolStripMenuItem_Click);
            // 
            // mànHìnhToolStripMenuItem
            // 
            this.mànHìnhToolStripMenuItem.Name = "mànHìnhToolStripMenuItem";
            this.mànHìnhToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.mànHìnhToolStripMenuItem.Tag = "SF003";
            this.mànHìnhToolStripMenuItem.Text = "Màn Hình";
            this.mànHìnhToolStripMenuItem.Click += new System.EventHandler(this.mànHìnhToolStripMenuItem_Click);
            // 
            // thêmTàiKhoảnVàoNhómToolStripMenuItem
            // 
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem.Name = "thêmTàiKhoảnVàoNhómToolStripMenuItem";
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem.Tag = "SF004";
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem.Text = "Thêm Tài Khoản Vào Nhóm";
            this.thêmTàiKhoảnVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmTàiKhoảnVàoNhómToolStripMenuItem_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.phânQuyềnToolStripMenuItem.Tag = "SF005";
            this.phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýBànToolStripMenuItem,
            this.quảnLýThựcĐơnToolStripMenuItem});
            this.nghiệpVụToolStripMenuItem.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_admin_settings_male_50;
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(111, 51);
            this.nghiệpVụToolStripMenuItem.Tag = "1";
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quảnLýNhânViênToolStripMenuItem.Tag = "SF006";
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýBànToolStripMenuItem
            // 
            this.quảnLýBànToolStripMenuItem.Name = "quảnLýBànToolStripMenuItem";
            this.quảnLýBànToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quảnLýBànToolStripMenuItem.Tag = "SF007";
            this.quảnLýBànToolStripMenuItem.Text = "Quản Lý Bàn";
            this.quảnLýBànToolStripMenuItem.Click += new System.EventHandler(this.quảnLýBànToolStripMenuItem_Click);
            // 
            // quảnLýThựcĐơnToolStripMenuItem
            // 
            this.quảnLýThựcĐơnToolStripMenuItem.Name = "quảnLýThựcĐơnToolStripMenuItem";
            this.quảnLýThựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.quảnLýThựcĐơnToolStripMenuItem.Tag = "SF008";
            this.quảnLýThựcĐơnToolStripMenuItem.Text = "Quản Lý Thực Đơn";
            this.quảnLýThựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThựcĐơnToolStripMenuItem_Click);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_waiter_50;
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(98, 51);
            this.gọiMónToolStripMenuItem.Tag = "SF009";
            this.gọiMónToolStripMenuItem.Text = "Gọi Món";
            this.gọiMónToolStripMenuItem.Click += new System.EventHandler(this.gọiMónToolStripMenuItem_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDangXuat.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_sign_out_50;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(111, 51);
            this.btnDangXuat.Tag = "3";
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Image = global::DoAnQuanLyNhaHang.Properties.Resources.icons8_sales_performance_50;
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(113, 51);
            this.btnDoanhThu.Tag = "SF010";
            this.btnDoanhThu.Text = "Doanh Thu";
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Phần Mềm Quản Lý Nhà Hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmTàiKhoảnVàoNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýThựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem btnDoanhThu;
    }
}