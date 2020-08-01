namespace DoAnQuanLyNhaHang
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.txtMaNhomTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMaManHinh = new System.Windows.Forms.TextBox();
            this.chkbCoQuyen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvPhanQuyen2 = new System.Windows.Forms.DataGridView();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanQuyen2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaNhomTaiKhoan
            // 
            this.txtMaNhomTaiKhoan.Location = new System.Drawing.Point(290, 58);
            this.txtMaNhomTaiKhoan.Name = "txtMaNhomTaiKhoan";
            this.txtMaNhomTaiKhoan.ReadOnly = true;
            this.txtMaNhomTaiKhoan.Size = new System.Drawing.Size(149, 22);
            this.txtMaNhomTaiKhoan.TabIndex = 0;
            // 
            // txtMaManHinh
            // 
            this.txtMaManHinh.Location = new System.Drawing.Point(290, 114);
            this.txtMaManHinh.Name = "txtMaManHinh";
            this.txtMaManHinh.ReadOnly = true;
            this.txtMaManHinh.Size = new System.Drawing.Size(149, 22);
            this.txtMaManHinh.TabIndex = 1;
            // 
            // chkbCoQuyen
            // 
            this.chkbCoQuyen.AutoSize = true;
            this.chkbCoQuyen.Location = new System.Drawing.Point(342, 169);
            this.chkbCoQuyen.Name = "chkbCoQuyen";
            this.chkbCoQuyen.Size = new System.Drawing.Size(18, 17);
            this.chkbCoQuyen.TabIndex = 2;
            this.chkbCoQuyen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã nhóm tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã màn hình:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Có quyền:";
            // 
            // dtgvPhanQuyen2
            // 
            this.dtgvPhanQuyen2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhanQuyen2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhanQuyen2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvPhanQuyen2.Location = new System.Drawing.Point(0, 281);
            this.dtgvPhanQuyen2.Name = "dtgvPhanQuyen2";
            this.dtgvPhanQuyen2.ReadOnly = true;
            this.dtgvPhanQuyen2.RowTemplate.Height = 24;
            this.dtgvPhanQuyen2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPhanQuyen2.Size = new System.Drawing.Size(683, 222);
            this.dtgvPhanQuyen2.TabIndex = 6;
            this.dtgvPhanQuyen2.SelectionChanged += new System.EventHandler(this.dtgvPhanQuyen_SelectionChanged);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(300, 214);
            this.btnSua.LookAndFeel.SkinName = "DevExpress Style";
            this.btnSua.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 29);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.Sửa_Click);
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 503);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtgvPhanQuyen2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkbCoQuyen);
            this.Controls.Add(this.txtMaManHinh);
            this.Controls.Add(this.txtMaNhomTaiKhoan);
            this.Name = "frmPhanQuyen";
            this.Text = "frmPhanQuyen";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhanQuyen2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaNhomTaiKhoan;
        private System.Windows.Forms.TextBox txtMaManHinh;
        private System.Windows.Forms.CheckBox chkbCoQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvPhanQuyen2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
    }
}