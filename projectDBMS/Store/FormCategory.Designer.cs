namespace Store
{
    partial class FormCategory
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
            System.Windows.Forms.Label productcategoryIDLabel;
            System.Windows.Forms.Label productcategoryNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
            this.iTshopDBDataSet = new Store.ITshopDBDataSet();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCategoryTableAdapter = new Store.ITshopDBDataSetTableAdapters.ProductCategoryTableAdapter();
            this.tableAdapterManager = new Store.ITshopDBDataSetTableAdapters.TableAdapterManager();
            this.productCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.productCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productcategoryIDTextBox = new System.Windows.Forms.TextBox();
            this.productcategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productcategoryIDLabel = new System.Windows.Forms.Label();
            productcategoryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).BeginInit();
            this.productCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // productcategoryIDLabel
            // 
            productcategoryIDLabel.AutoSize = true;
            productcategoryIDLabel.Location = new System.Drawing.Point(21, 102);
            productcategoryIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productcategoryIDLabel.Name = "productcategoryIDLabel";
            productcategoryIDLabel.Size = new System.Drawing.Size(203, 32);
            productcategoryIDLabel.TabIndex = 1;
            productcategoryIDLabel.Text = "รหัสประเภทสินค้า";
            // 
            // productcategoryNameLabel
            // 
            productcategoryNameLabel.AutoSize = true;
            productcategoryNameLabel.Location = new System.Drawing.Point(21, 154);
            productcategoryNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productcategoryNameLabel.Name = "productcategoryNameLabel";
            productcategoryNameLabel.Size = new System.Drawing.Size(189, 32);
            productcategoryNameLabel.TabIndex = 3;
            productcategoryNameLabel.Text = "ชื่อประเภทสินค้า";
            // 
            // iTshopDBDataSet
            // 
            this.iTshopDBDataSet.DataSetName = "ITshopDBDataSet";
            this.iTshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.iTshopDBDataSet;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = this.productCategoryTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store.ITshopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productCategoryBindingNavigator
            // 
            this.productCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productCategoryBindingNavigator.BindingSource = this.productCategoryBindingSource;
            this.productCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productCategoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productCategoryBindingNavigatorSaveItem});
            this.productCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productCategoryBindingNavigator.Name = "productCategoryBindingNavigator";
            this.productCategoryBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.productCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productCategoryBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.productCategoryBindingNavigator.TabIndex = 0;
            this.productCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(86, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // productCategoryBindingNavigatorSaveItem
            // 
            this.productCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productCategoryBindingNavigatorSaveItem.Image")));
            this.productCategoryBindingNavigatorSaveItem.Name = "productCategoryBindingNavigatorSaveItem";
            this.productCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.productCategoryBindingNavigatorSaveItem.Text = "Save Data";
            this.productCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.productCategoryBindingNavigatorSaveItem_Click);
            // 
            // productcategoryIDTextBox
            // 
            this.productcategoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "productcategoryID", true));
            this.productcategoryIDTextBox.Location = new System.Drawing.Point(234, 102);
            this.productcategoryIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productcategoryIDTextBox.Name = "productcategoryIDTextBox";
            this.productcategoryIDTextBox.Size = new System.Drawing.Size(278, 39);
            this.productcategoryIDTextBox.TabIndex = 2;
            // 
            // productcategoryNameTextBox
            // 
            this.productcategoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "productcategoryName", true));
            this.productcategoryNameTextBox.Location = new System.Drawing.Point(234, 153);
            this.productcategoryNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productcategoryNameTextBox.Name = "productcategoryNameTextBox";
            this.productcategoryNameTextBox.Size = new System.Drawing.Size(278, 39);
            this.productcategoryNameTextBox.TabIndex = 4;
            // 
            // productCategoryDataGridView
            // 
            this.productCategoryDataGridView.AutoGenerateColumns = false;
            this.productCategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productCategoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productCategoryDataGridView.DataSource = this.productCategoryBindingSource;
            this.productCategoryDataGridView.Location = new System.Drawing.Point(27, 220);
            this.productCategoryDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.productCategoryDataGridView.Name = "productCategoryDataGridView";
            this.productCategoryDataGridView.RowHeadersWidth = 62;
            this.productCategoryDataGridView.RowTemplate.Height = 28;
            this.productCategoryDataGridView.Size = new System.Drawing.Size(1026, 352);
            this.productCategoryDataGridView.TabIndex = 5;
            // 
            // productCategoryBindingSource1
            // 
            this.productCategoryBindingSource1.DataSource = typeof(Store.ProductCategory);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(539, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 66);
            this.label1.TabIndex = 17;
            this.label1.Text = "เพิ่มข้อมูลประเภทสินค้า";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "productcategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสประเภทสินค้า";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "productcategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อประเภทสินค้า";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCategoryDataGridView);
            this.Controls.Add(productcategoryIDLabel);
            this.Controls.Add(this.productcategoryIDTextBox);
            this.Controls.Add(productcategoryNameLabel);
            this.Controls.Add(this.productcategoryNameTextBox);
            this.Controls.Add(this.productCategoryBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCategory";
            this.Text = "FormCategory";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).EndInit();
            this.productCategoryBindingNavigator.ResumeLayout(false);
            this.productCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDBDataSet iTshopDBDataSet;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private ITshopDBDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private ITshopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productCategoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productcategoryIDTextBox;
        private System.Windows.Forms.TextBox productcategoryNameTextBox;
        private System.Windows.Forms.BindingSource productCategoryBindingSource1;
        private System.Windows.Forms.DataGridView productCategoryDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}