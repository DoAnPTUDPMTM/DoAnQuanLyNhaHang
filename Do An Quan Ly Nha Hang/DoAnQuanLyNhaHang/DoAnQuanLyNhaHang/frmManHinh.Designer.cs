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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinh));
            System.Windows.Forms.Label maManHinhLabel;
            System.Windows.Forms.Label tenManHinhLabel;
            this.dataSet1 = new DoAnQuanLyNhaHang.DataSet1();
            this.manHinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manHinhTableAdapter = new DoAnQuanLyNhaHang.DataSet1TableAdapters.ManHinhTableAdapter();
            this.tableAdapterManager = new DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager();
            this.manHinhBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.manHinhBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.manHinhDataGridView = new System.Windows.Forms.DataGridView();
            this.maManHinhTextBox = new System.Windows.Forms.TextBox();
            this.tenManHinhTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maManHinhLabel = new System.Windows.Forms.Label();
            tenManHinhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingNavigator)).BeginInit();
            this.manHinhBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.ManHinhTableAdapter = this.manHinhTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoAnQuanLyNhaHang.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // manHinhBindingNavigator
            // 
            this.manHinhBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.manHinhBindingNavigator.BindingSource = this.manHinhBindingSource;
            this.manHinhBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.manHinhBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.manHinhBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.manHinhBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.manHinhBindingNavigatorSaveItem});
            this.manHinhBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.manHinhBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.manHinhBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.manHinhBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.manHinhBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.manHinhBindingNavigator.Name = "manHinhBindingNavigator";
            this.manHinhBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.manHinhBindingNavigator.Size = new System.Drawing.Size(682, 27);
            this.manHinhBindingNavigator.TabIndex = 0;
            this.manHinhBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(100, 24);
            this.bindingNavigatorAddNewItem.Text = "Thêm Mới";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(59, 24);
            this.bindingNavigatorDeleteItem.Text = "Xoá";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // manHinhBindingNavigatorSaveItem
            // 
            this.manHinhBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("manHinhBindingNavigatorSaveItem.Image")));
            this.manHinhBindingNavigatorSaveItem.Name = "manHinhBindingNavigatorSaveItem";
            this.manHinhBindingNavigatorSaveItem.Size = new System.Drawing.Size(57, 24);
            this.manHinhBindingNavigatorSaveItem.Text = "Lưu";
            this.manHinhBindingNavigatorSaveItem.Click += new System.EventHandler(this.manHinhBindingNavigatorSaveItem_Click);
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
            this.manHinhDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manHinhDataGridView.Location = new System.Drawing.Point(0, 176);
            this.manHinhDataGridView.Name = "manHinhDataGridView";
            this.manHinhDataGridView.RowTemplate.Height = 24;
            this.manHinhDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.manHinhDataGridView.Size = new System.Drawing.Size(682, 277);
            this.manHinhDataGridView.TabIndex = 1;
            // 
            // maManHinhLabel
            // 
            maManHinhLabel.AutoSize = true;
            maManHinhLabel.Location = new System.Drawing.Point(199, 65);
            maManHinhLabel.Name = "maManHinhLabel";
            maManHinhLabel.Size = new System.Drawing.Size(95, 17);
            maManHinhLabel.TabIndex = 2;
            maManHinhLabel.Text = "Mã Màn Hình:";
            // 
            // maManHinhTextBox
            // 
            this.maManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manHinhBindingSource, "MaManHinh", true));
            this.maManHinhTextBox.Location = new System.Drawing.Point(306, 62);
            this.maManHinhTextBox.Multiline = true;
            this.maManHinhTextBox.Name = "maManHinhTextBox";
            this.maManHinhTextBox.Size = new System.Drawing.Size(161, 22);
            this.maManHinhTextBox.TabIndex = 3;
            // 
            // tenManHinhLabel
            // 
            tenManHinhLabel.AutoSize = true;
            tenManHinhLabel.Location = new System.Drawing.Point(199, 103);
            tenManHinhLabel.Name = "tenManHinhLabel";
            tenManHinhLabel.Size = new System.Drawing.Size(101, 17);
            tenManHinhLabel.TabIndex = 4;
            tenManHinhLabel.Text = "Tên Màn Hình:";
            // 
            // tenManHinhTextBox
            // 
            this.tenManHinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manHinhBindingSource, "TenManHinh", true));
            this.tenManHinhTextBox.Location = new System.Drawing.Point(306, 100);
            this.tenManHinhTextBox.Multiline = true;
            this.tenManHinhTextBox.Name = "tenManHinhTextBox";
            this.tenManHinhTextBox.Size = new System.Drawing.Size(161, 22);
            this.tenManHinhTextBox.TabIndex = 5;
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
            // frmManHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(maManHinhLabel);
            this.Controls.Add(this.maManHinhTextBox);
            this.Controls.Add(tenManHinhLabel);
            this.Controls.Add(this.tenManHinhTextBox);
            this.Controls.Add(this.manHinhDataGridView);
            this.Controls.Add(this.manHinhBindingNavigator);
            this.Name = "frmManHinh";
            this.Text = "frmManHinh";
            this.Load += new System.EventHandler(this.frmManHinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhBindingNavigator)).EndInit();
            this.manHinhBindingNavigator.ResumeLayout(false);
            this.manHinhBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manHinhDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource manHinhBindingSource;
        private DataSet1TableAdapters.ManHinhTableAdapter manHinhTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator manHinhBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton manHinhBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView manHinhDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox maManHinhTextBox;
        private System.Windows.Forms.TextBox tenManHinhTextBox;
    }
}