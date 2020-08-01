namespace DoAnQuanLyNhaHang
{
    partial class frmManHinh
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
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.manHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manHinhTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.ManHinhTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.manHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(437, 55);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(95, 17);
            maManHinhLabel.TabIndex = 2;
            maManHinhLabel.Text = "Mã Màn Hình:";
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(437, 78);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(101, 17);
            tenManHinhLabel.TabIndex = 4;
            tenManHinhLabel.Text = "Tên Màn Hình:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manHinhBindingSource
            // 
            this.manHinhBindingSource.DataMember = "ManHinh";
            this.manHinhBindingSource.DataSource = this.dataSet1;
            // 
            // manHinhTableAdapter
            // 
            this.manHinhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = this.manHinhTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manHinhDataGridView
            // 
            this.manHinhDataGridView.AutoGenerateColumns = false;
            this.manHinhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.manHinhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manHinhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.manHinhDataGridView.DataSource = this.manHinhBindingSource;
            this.manHinhDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manHinhDataGridView.Location = new System.Drawing.Point(3, 240);
            this.manHinhDataGridView.Name = "manHinhDataGridView";
            this.manHinhDataGridView.ReadOnly = true;
            this.manHinhDataGridView.RowTemplate.Height = 24;
            this.manHinhDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manHinhDataGridView.Size = new System.Drawing.Size(1088, 578);
            this.manHinhDataGridView.TabIndex = 1;
            this.manHinhDataGridView.SelectionChanged += new System.EventHandler(this.manHinhDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maManHinhTextBox.Location = new System.Drawing.Point(545, 58);
            this.maManHinhTextBox.Multiline = true;
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(102, 17);
            this.maManHinhTextBox.TabIndex = 3;
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenManHinhTextBox.Location = new System.Drawing.Point(545, 81);
            this.tenManHinhTextBox.Multiline = true;
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(102, 17);
            this.tenManHinhTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.manHinhDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.9744214F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.917174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1094, 821);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.maManHinhTextBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(maManHinhLabel, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tenManHinhTextBox, 3, 2);
            this.tableLayoutPanel3.Controls.Add(tenManHinhLabel, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnThem, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnXoa, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.simpleButton1, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnDong, 4, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1088, 158);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("UTM Magnesium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1088, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Màn Hình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(437, 104);
            this.btnXoa.LookAndFeel.SkinName = "DevExpress Style";
            this.btnXoa.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 44);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(329, 104);
            this.btnThem.LookAndFeel.SkinName = "DevExpress Style";
            this.btnThem.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 44);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(545, 104);
            this.simpleButton1.LookAndFeel.SkinName = "DevExpress Style";
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 44);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image1")));
            this.btnDong.Location = new System.Drawing.Point(653, 104);
            this.btnDong.LookAndFeel.SkinName = "DevExpress Style";
            this.btnDong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(102, 44);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            // 
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 821);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmManHinh";
            this.Text = "frmManHinh";
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource manHinhBindingSource;
        private DataSet1TableAdapters.ManHinhTableAdapter manHinhTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView manHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
    }
}