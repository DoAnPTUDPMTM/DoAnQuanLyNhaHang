namespace DoAnQuanLyNhaHang
{
    partial class frmBan
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
            System.Windows.Forms.Label maBanLabel;
            System.Windows.Forms.Label tenBanLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBan));
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.banBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.BanTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.banBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.banBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.banDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            maBanLabel = new System.Windows.Forms.Label();
            tenBanLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingNavigator)).BeginInit();
            this.banBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maBanLabel
            // 
            maBanLabel.AutoSize = true;
            maBanLabel.Location = new System.Drawing.Point(28, 46);
            maBanLabel.Name = "maBanLabel";
            maBanLabel.Size = new System.Drawing.Size(60, 17);
            maBanLabel.TabIndex = 2;
            maBanLabel.Text = "Mã Bàn:";
            // 
            // tenBanLabel
            // 
            tenBanLabel.AutoSize = true;
            tenBanLabel.Location = new System.Drawing.Point(28, 74);
            tenBanLabel.Name = "tenBanLabel";
            tenBanLabel.Size = new System.Drawing.Size(66, 17);
            tenBanLabel.TabIndex = 4;
            tenBanLabel.Text = "Tên Bàn:";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new System.Drawing.Point(28, 102);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(82, 17);
            trangThaiLabel.TabIndex = 6;
            trangThaiLabel.Text = "Trạng Thái:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banBindingSource
            // 
            this.banBindingSource.DataMember = "Ban";
            this.banBindingSource.DataSource = this.dataSet1;
            // 
            // banTableAdapter
            // 
            this.banTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BanTableAdapter = this.banTableAdapter;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNhomTaiKhoanTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // banBindingNavigator
            // 
            this.banBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.banBindingNavigator.BindingSource = this.banBindingSource;
            this.banBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.banBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.banBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.banBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.banBindingNavigatorSaveItem});
            this.banBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.banBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.banBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.banBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.banBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.banBindingNavigator.Name = "banBindingNavigator";
            this.banBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.banBindingNavigator.Size = new System.Drawing.Size(1056, 27);
            this.banBindingNavigator.TabIndex = 0;
            this.banBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(100, 24);
            this.bindingNavigatorAddNewItem.Text = "Thêm mới";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(59, 24);
            this.bindingNavigatorDeleteItem.Text = "Xoá";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // banBindingNavigatorSaveItem
            // 
            this.banBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("banBindingNavigatorSaveItem.Image")));
            this.banBindingNavigatorSaveItem.Name = "banBindingNavigatorSaveItem";
            this.banBindingNavigatorSaveItem.Size = new System.Drawing.Size(57, 24);
            this.banBindingNavigatorSaveItem.Text = "Lưu";
            this.banBindingNavigatorSaveItem.Click += new System.EventHandler(this.banBindingNavigatorSaveItem_Click);
            // 
            // banDataGridView
            // 
            this.banDataGridView.AutoGenerateColumns = false;
            this.banDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.banDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.banDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.banDataGridView.DataSource = this.banBindingSource;
            this.banDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.banDataGridView.Location = new System.Drawing.Point(0, 337);
            this.banDataGridView.Name = "banDataGridView";
            this.banDataGridView.RowTemplate.Height = 24;
            this.banDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.banDataGridView.Size = new System.Drawing.Size(1056, 293);
            this.banDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaBan";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaBan";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenBan";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenBan";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn3.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // txtMaBan
            // 
            this.txtMaBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banBindingSource, "MaBan", true));
            this.txtMaBan.Location = new System.Drawing.Point(116, 43);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(140, 22);
            this.txtMaBan.TabIndex = 3;
            // 
            // txtTenBan
            // 
            this.txtTenBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banBindingSource, "TenBan", true));
            this.txtTenBan.Location = new System.Drawing.Point(116, 71);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(140, 22);
            this.txtTenBan.TabIndex = 5;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.banBindingSource, "TrangThai", true));
            this.txtTrangThai.Location = new System.Drawing.Point(116, 99);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(140, 22);
            this.txtTrangThai.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaBan);
            this.groupBox1.Controls.Add(maBanLabel);
            this.groupBox1.Controls.Add(this.txtTrangThai);
            this.groupBox1.Controls.Add(trangThaiLabel);
            this.groupBox1.Controls.Add(tenBanLabel);
            this.groupBox1.Controls.Add(this.txtTenBan);
            this.groupBox1.Location = new System.Drawing.Point(393, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bàn";
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 630);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.banDataGridView);
            this.Controls.Add(this.banBindingNavigator);
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banBindingNavigator)).EndInit();
            this.banBindingNavigator.ResumeLayout(false);
            this.banBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource banBindingSource;
        private DataSet1TableAdapters.BanTableAdapter banTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator banBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton banBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView banDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}