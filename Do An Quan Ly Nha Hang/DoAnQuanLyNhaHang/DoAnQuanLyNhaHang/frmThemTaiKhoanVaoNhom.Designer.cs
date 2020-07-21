namespace DoAnQuanLyNhaHang
{
    partial class frmThemTaiKhoanVaoNhom
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
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.taiKhoanTrongNhomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTrongNhomTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TaiKhoanTrongNhomTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.taiKhoanTrongNhomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomTaiKhoanTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.NhomTaiKhoanTableAdapter();
            this.nhomTaiKhoanComboBox = new System.Windows.Forms.ComboBox();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.taiKhoanNhomTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanNhomTaiKhoanTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TaiKhoanNhomTaiKhoanTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTrongNhomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTrongNhomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNhomTaiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTrongNhomBindingSource
            // 
            this.taiKhoanTrongNhomBindingSource.DataMember = "TaiKhoanTrongNhom";
            this.taiKhoanTrongNhomBindingSource.DataSource = this.dataSet1;
            // 
            // taiKhoanTrongNhomTableAdapter
            // 
            this.taiKhoanTrongNhomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTrongNhomDataGridView
            // 
            this.taiKhoanTrongNhomDataGridView.AutoGenerateColumns = false;
            this.taiKhoanTrongNhomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taiKhoanTrongNhomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanTrongNhomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.taiKhoanTrongNhomDataGridView.DataSource = this.taiKhoanTrongNhomBindingSource;
            this.taiKhoanTrongNhomDataGridView.Location = new System.Drawing.Point(634, 107);
            this.taiKhoanTrongNhomDataGridView.Name = "taiKhoanTrongNhomDataGridView";
            this.taiKhoanTrongNhomDataGridView.RowTemplate.Height = 24;
            this.taiKhoanTrongNhomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taiKhoanTrongNhomDataGridView.Size = new System.Drawing.Size(486, 401);
            this.taiKhoanTrongNhomDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nhomTaiKhoanBindingSource
            // 
            this.nhomTaiKhoanBindingSource.DataMember = "NhomTaiKhoan";
            this.nhomTaiKhoanBindingSource.DataSource = this.dataSet1;
            // 
            // nhomTaiKhoanTableAdapter
            // 
            this.nhomTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // nhomTaiKhoanComboBox
            // 
            this.nhomTaiKhoanComboBox.DataSource = this.nhomTaiKhoanBindingSource;
            this.nhomTaiKhoanComboBox.DisplayMember = "TenNhomTaiKhoan";
            this.nhomTaiKhoanComboBox.FormattingEnabled = true;
            this.nhomTaiKhoanComboBox.Location = new System.Drawing.Point(751, 62);
            this.nhomTaiKhoanComboBox.Name = "nhomTaiKhoanComboBox";
            this.nhomTaiKhoanComboBox.Size = new System.Drawing.Size(203, 24);
            this.nhomTaiKhoanComboBox.TabIndex = 2;
            this.nhomTaiKhoanComboBox.ValueMember = "MaNhomTaiKhoan";
            this.nhomTaiKhoanComboBox.SelectedIndexChanged += new System.EventHandler(this.nhomTaiKhoanComboBox_SelectedIndexChanged);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dataSet1;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanDataGridView
            // 
            this.taiKhoanDataGridView.AutoGenerateColumns = false;
            this.taiKhoanDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.taiKhoanDataGridView.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanDataGridView.Location = new System.Drawing.Point(12, 107);
            this.taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            this.taiKhoanDataGridView.RowTemplate.Height = 24;
            this.taiKhoanDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taiKhoanDataGridView.Size = new System.Drawing.Size(488, 401);
            this.taiKhoanDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn4.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn5.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HoatDong";
            this.dataGridViewCheckBoxColumn1.HeaderText = "HoatDong";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(515, 206);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 56);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = ">>>";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(515, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 56);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "<<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // taiKhoanNhomTaiKhoanBindingSource
            // 
            this.taiKhoanNhomTaiKhoanBindingSource.DataMember = "TaiKhoanNhomTaiKhoan";
            this.taiKhoanNhomTaiKhoanBindingSource.DataSource = this.dataSet1;
            // 
            // taiKhoanNhomTaiKhoanTableAdapter
            // 
            this.taiKhoanNhomTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhóm tài khoản:";
            // 
            // frmThemTaiKhoanVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.taiKhoanDataGridView);
            this.Controls.Add(this.nhomTaiKhoanComboBox);
            this.Controls.Add(this.taiKhoanTrongNhomDataGridView);
            this.Name = "frmThemTaiKhoanVaoNhom";
            this.Text = "frmThemTaiKhoanVaoNhom";
            this.Load += new System.EventHandler(this.frmThemTaiKhoanVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTrongNhomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTrongNhomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanNhomTaiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource taiKhoanTrongNhomBindingSource;
        private DataSet1TableAdapters.TaiKhoanTrongNhomTableAdapter taiKhoanTrongNhomTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView taiKhoanTrongNhomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource nhomTaiKhoanBindingSource;
        private DataSet1TableAdapters.NhomTaiKhoanTableAdapter nhomTaiKhoanTableAdapter;
        private System.Windows.Forms.ComboBox nhomTaiKhoanComboBox;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DataSet1TableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.DataGridView taiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.BindingSource taiKhoanNhomTaiKhoanBindingSource;
        private DataSet1TableAdapters.TaiKhoanNhomTaiKhoanTableAdapter taiKhoanNhomTaiKhoanTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}