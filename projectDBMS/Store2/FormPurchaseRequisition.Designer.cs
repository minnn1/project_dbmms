namespace Store2
{
    partial class FormPurchaseRequisition
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
            System.Windows.Forms.Label pK_PurchaseRequisition_idLabel;
            System.Windows.Forms.Label fK_Employee_IDLabel;
            System.Windows.Forms.Label fK_Product_IDLabel;
            System.Windows.Forms.Label purchaserequisitionNameLabel;
            System.Windows.Forms.Label purchaserequisitionQTYLabel;
            System.Windows.Forms.Label purchaserequisitionPriceLabel;
            System.Windows.Forms.Label purchaserequisitionDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchaseRequisition));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.purchaseRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRequisitionTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.PurchaseRequisitionTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.EmployeeTableAdapter();
            this.productTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ProductTableAdapter();
            this.purchaseRequisitionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseRequisitionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseRequisitionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pK_PurchaseRequisition_idTextBox = new System.Windows.Forms.TextBox();
            this.fK_Employee_IDTextBox = new System.Windows.Forms.TextBox();
            this.fK_Product_IDTextBox = new System.Windows.Forms.TextBox();
            this.purchaserequisitionNameTextBox = new System.Windows.Forms.TextBox();
            this.purchaserequisitionQTYTextBox = new System.Windows.Forms.TextBox();
            this.purchaserequisitionPriceTextBox = new System.Windows.Forms.TextBox();
            this.purchaserequisitionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_Employee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pK_PurchaseRequisition_idLabel = new System.Windows.Forms.Label();
            fK_Employee_IDLabel = new System.Windows.Forms.Label();
            fK_Product_IDLabel = new System.Windows.Forms.Label();
            purchaserequisitionNameLabel = new System.Windows.Forms.Label();
            purchaserequisitionQTYLabel = new System.Windows.Forms.Label();
            purchaserequisitionPriceLabel = new System.Windows.Forms.Label();
            purchaserequisitionDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).BeginInit();
            this.purchaseRequisitionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // pK_PurchaseRequisition_idLabel
            // 
            pK_PurchaseRequisition_idLabel.AutoSize = true;
            pK_PurchaseRequisition_idLabel.Location = new System.Drawing.Point(28, 63);
            pK_PurchaseRequisition_idLabel.Name = "pK_PurchaseRequisition_idLabel";
            pK_PurchaseRequisition_idLabel.Size = new System.Drawing.Size(151, 32);
            pK_PurchaseRequisition_idLabel.TabIndex = 2;
            pK_PurchaseRequisition_idLabel.Text = "รหัสใบขอซื้อ";
            // 
            // fK_Employee_IDLabel
            // 
            fK_Employee_IDLabel.AutoSize = true;
            fK_Employee_IDLabel.Location = new System.Drawing.Point(28, 108);
            fK_Employee_IDLabel.Name = "fK_Employee_IDLabel";
            fK_Employee_IDLabel.Size = new System.Drawing.Size(151, 32);
            fK_Employee_IDLabel.TabIndex = 4;
            fK_Employee_IDLabel.Text = "รหัสพนักงาน";
            // 
            // fK_Product_IDLabel
            // 
            fK_Product_IDLabel.AutoSize = true;
            fK_Product_IDLabel.Location = new System.Drawing.Point(28, 153);
            fK_Product_IDLabel.Name = "fK_Product_IDLabel";
            fK_Product_IDLabel.Size = new System.Drawing.Size(120, 32);
            fK_Product_IDLabel.TabIndex = 6;
            fK_Product_IDLabel.Text = "รหัสสินค้า";
            // 
            // purchaserequisitionNameLabel
            // 
            purchaserequisitionNameLabel.AutoSize = true;
            purchaserequisitionNameLabel.Location = new System.Drawing.Point(28, 198);
            purchaserequisitionNameLabel.Name = "purchaserequisitionNameLabel";
            purchaserequisitionNameLabel.Size = new System.Drawing.Size(158, 32);
            purchaserequisitionNameLabel.TabIndex = 8;
            purchaserequisitionNameLabel.Text = "รายการขอซื้อ";
            // 
            // purchaserequisitionQTYLabel
            // 
            purchaserequisitionQTYLabel.AutoSize = true;
            purchaserequisitionQTYLabel.Location = new System.Drawing.Point(28, 243);
            purchaserequisitionQTYLabel.Name = "purchaserequisitionQTYLabel";
            purchaserequisitionQTYLabel.Size = new System.Drawing.Size(151, 32);
            purchaserequisitionQTYLabel.TabIndex = 10;
            purchaserequisitionQTYLabel.Text = "จำนวนขอซื้อ";
            // 
            // purchaserequisitionPriceLabel
            // 
            purchaserequisitionPriceLabel.AutoSize = true;
            purchaserequisitionPriceLabel.Location = new System.Drawing.Point(28, 288);
            purchaserequisitionPriceLabel.Name = "purchaserequisitionPriceLabel";
            purchaserequisitionPriceLabel.Size = new System.Drawing.Size(131, 32);
            purchaserequisitionPriceLabel.TabIndex = 12;
            purchaserequisitionPriceLabel.Text = "ราคาขอซื้อ";
            // 
            // purchaserequisitionDateLabel
            // 
            purchaserequisitionDateLabel.AutoSize = true;
            purchaserequisitionDateLabel.Location = new System.Drawing.Point(28, 334);
            purchaserequisitionDateLabel.Name = "purchaserequisitionDateLabel";
            purchaserequisitionDateLabel.Size = new System.Drawing.Size(124, 32);
            purchaserequisitionDateLabel.TabIndex = 14;
            purchaserequisitionDateLabel.Text = "วันที่ขอซื้อ";
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseRequisitionBindingSource
            // 
            this.purchaseRequisitionBindingSource.DataMember = "PurchaseRequisition";
            this.purchaseRequisitionBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // purchaseRequisitionTableAdapter
            // 
            this.purchaseRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = this.purchaseRequisitionTableAdapter;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseRequisitionBindingNavigator
            // 
            this.purchaseRequisitionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseRequisitionBindingNavigator.BindingSource = this.purchaseRequisitionBindingSource;
            this.purchaseRequisitionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseRequisitionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseRequisitionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.purchaseRequisitionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseRequisitionBindingNavigatorSaveItem});
            this.purchaseRequisitionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseRequisitionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseRequisitionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseRequisitionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseRequisitionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseRequisitionBindingNavigator.Name = "purchaseRequisitionBindingNavigator";
            this.purchaseRequisitionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseRequisitionBindingNavigator.Size = new System.Drawing.Size(1569, 33);
            this.purchaseRequisitionBindingNavigator.TabIndex = 0;
            this.purchaseRequisitionBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
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
            // purchaseRequisitionBindingNavigatorSaveItem
            // 
            this.purchaseRequisitionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseRequisitionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseRequisitionBindingNavigatorSaveItem.Image")));
            this.purchaseRequisitionBindingNavigatorSaveItem.Name = "purchaseRequisitionBindingNavigatorSaveItem";
            this.purchaseRequisitionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.purchaseRequisitionBindingNavigatorSaveItem.Text = "Save Data";
            this.purchaseRequisitionBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseRequisitionBindingNavigatorSaveItem_Click);
            // 
            // purchaseRequisitionDataGridView
            // 
            this.purchaseRequisitionDataGridView.AutoGenerateColumns = false;
            this.purchaseRequisitionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseRequisitionDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purchaseRequisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseRequisitionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.purchaseRequisitionDataGridView.DataSource = this.purchaseRequisitionBindingSource;
            this.purchaseRequisitionDataGridView.Location = new System.Drawing.Point(471, 36);
            this.purchaseRequisitionDataGridView.Name = "purchaseRequisitionDataGridView";
            this.purchaseRequisitionDataGridView.RowHeadersWidth = 62;
            this.purchaseRequisitionDataGridView.RowTemplate.Height = 28;
            this.purchaseRequisitionDataGridView.Size = new System.Drawing.Size(787, 338);
            this.purchaseRequisitionDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_PurchaseRequisition_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสใบขอซื้อ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FK_Employee_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสพนักงาน";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FK_Product_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "รหัสสินค้า";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "purchaserequisitionName";
            this.dataGridViewTextBoxColumn4.HeaderText = "รายการขอซื้อ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PurchaserequisitionQTY";
            this.dataGridViewTextBoxColumn5.HeaderText = "จำนวนขอซื้อ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "purchaserequisitionPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "ราคาขอซื้อ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "purchaserequisitionDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "วันที่ขอซื้อ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pK_PurchaseRequisition_idTextBox
            // 
            this.pK_PurchaseRequisition_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "PK_PurchaseRequisition_id", true));
            this.pK_PurchaseRequisition_idTextBox.Location = new System.Drawing.Point(210, 60);
            this.pK_PurchaseRequisition_idTextBox.Name = "pK_PurchaseRequisition_idTextBox";
            this.pK_PurchaseRequisition_idTextBox.ReadOnly = true;
            this.pK_PurchaseRequisition_idTextBox.Size = new System.Drawing.Size(206, 39);
            this.pK_PurchaseRequisition_idTextBox.TabIndex = 3;
            // 
            // fK_Employee_IDTextBox
            // 
            this.fK_Employee_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "FK_Employee_ID", true));
            this.fK_Employee_IDTextBox.Location = new System.Drawing.Point(210, 105);
            this.fK_Employee_IDTextBox.Name = "fK_Employee_IDTextBox";
            this.fK_Employee_IDTextBox.ReadOnly = true;
            this.fK_Employee_IDTextBox.Size = new System.Drawing.Size(206, 39);
            this.fK_Employee_IDTextBox.TabIndex = 5;
            // 
            // fK_Product_IDTextBox
            // 
            this.fK_Product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "FK_Product_ID", true));
            this.fK_Product_IDTextBox.Location = new System.Drawing.Point(210, 150);
            this.fK_Product_IDTextBox.Name = "fK_Product_IDTextBox";
            this.fK_Product_IDTextBox.ReadOnly = true;
            this.fK_Product_IDTextBox.Size = new System.Drawing.Size(206, 39);
            this.fK_Product_IDTextBox.TabIndex = 7;
            // 
            // purchaserequisitionNameTextBox
            // 
            this.purchaserequisitionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "purchaserequisitionName", true));
            this.purchaserequisitionNameTextBox.Location = new System.Drawing.Point(210, 195);
            this.purchaserequisitionNameTextBox.Name = "purchaserequisitionNameTextBox";
            this.purchaserequisitionNameTextBox.ReadOnly = true;
            this.purchaserequisitionNameTextBox.Size = new System.Drawing.Size(206, 39);
            this.purchaserequisitionNameTextBox.TabIndex = 9;
            // 
            // purchaserequisitionQTYTextBox
            // 
            this.purchaserequisitionQTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "PurchaserequisitionQTY", true));
            this.purchaserequisitionQTYTextBox.Location = new System.Drawing.Point(210, 240);
            this.purchaserequisitionQTYTextBox.Name = "purchaserequisitionQTYTextBox";
            this.purchaserequisitionQTYTextBox.Size = new System.Drawing.Size(206, 39);
            this.purchaserequisitionQTYTextBox.TabIndex = 11;
            // 
            // purchaserequisitionPriceTextBox
            // 
            this.purchaserequisitionPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseRequisitionBindingSource, "purchaserequisitionPrice", true));
            this.purchaserequisitionPriceTextBox.Location = new System.Drawing.Point(210, 285);
            this.purchaserequisitionPriceTextBox.Name = "purchaserequisitionPriceTextBox";
            this.purchaserequisitionPriceTextBox.ReadOnly = true;
            this.purchaserequisitionPriceTextBox.Size = new System.Drawing.Size(206, 39);
            this.purchaserequisitionPriceTextBox.TabIndex = 13;
            // 
            // purchaserequisitionDateDateTimePicker
            // 
            this.purchaserequisitionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseRequisitionBindingSource, "purchaserequisitionDate", true));
            this.purchaserequisitionDateDateTimePicker.Location = new System.Drawing.Point(210, 330);
            this.purchaserequisitionDateDateTimePicker.Name = "purchaserequisitionDateDateTimePicker";
            this.purchaserequisitionDateDateTimePicker.Size = new System.Drawing.Size(206, 39);
            this.purchaserequisitionDateDateTimePicker.TabIndex = 15;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridProduct.Location = new System.Drawing.Point(641, 380);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersWidth = 62;
            this.dataGridProduct.RowTemplate.Height = 28;
            this.dataGridProduct.Size = new System.Drawing.Size(617, 220);
            this.dataGridProduct.TabIndex = 18;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_Product_id";
            this.Column1.HeaderText = "รหัสสินค้า";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productName";
            this.Column2.HeaderText = "ชื่อสินค้า";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "categoryName";
            this.Column5.HeaderText = "ประเภทสินค้า";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "productPrice";
            this.Column3.HeaderText = "ราคาสินค้า";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "productInventory";
            this.Column4.HeaderText = "จำนวนสินค้า";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // dataGrid_Employee
            // 
            this.dataGrid_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGrid_Employee.Location = new System.Drawing.Point(-74, 380);
            this.dataGrid_Employee.Name = "dataGrid_Employee";
            this.dataGrid_Employee.RowHeadersWidth = 62;
            this.dataGrid_Employee.RowTemplate.Height = 28;
            this.dataGrid_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Employee.Size = new System.Drawing.Size(675, 220);
            this.dataGrid_Employee.TabIndex = 19;
            this.dataGrid_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Employee_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PK_Employee_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "รหัสพนักงาน";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "jobpositionName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ตำเเหน่งงาน";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "employeeFName";
            this.dataGridViewTextBoxColumn10.HeaderText = "ชื่อ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "employeeLName";
            this.dataGridViewTextBoxColumn11.HeaderText = "นามสกุล";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // FormPurchaseRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1569, 720);
            this.Controls.Add(this.dataGrid_Employee);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(pK_PurchaseRequisition_idLabel);
            this.Controls.Add(this.pK_PurchaseRequisition_idTextBox);
            this.Controls.Add(fK_Employee_IDLabel);
            this.Controls.Add(this.fK_Employee_IDTextBox);
            this.Controls.Add(fK_Product_IDLabel);
            this.Controls.Add(this.fK_Product_IDTextBox);
            this.Controls.Add(purchaserequisitionNameLabel);
            this.Controls.Add(this.purchaserequisitionNameTextBox);
            this.Controls.Add(purchaserequisitionQTYLabel);
            this.Controls.Add(this.purchaserequisitionQTYTextBox);
            this.Controls.Add(purchaserequisitionPriceLabel);
            this.Controls.Add(this.purchaserequisitionPriceTextBox);
            this.Controls.Add(purchaserequisitionDateLabel);
            this.Controls.Add(this.purchaserequisitionDateDateTimePicker);
            this.Controls.Add(this.purchaseRequisitionDataGridView);
            this.Controls.Add(this.purchaseRequisitionBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPurchaseRequisition";
            this.Text = "FormPurchaseRequisition";
            this.Load += new System.EventHandler(this.FormPurchaseRequisition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingNavigator)).EndInit();
            this.purchaseRequisitionBindingNavigator.ResumeLayout(false);
            this.purchaseRequisitionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource purchaseRequisitionBindingSource;
        private ITshopDB2DataSetTableAdapters.PurchaseRequisitionTableAdapter purchaseRequisitionTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseRequisitionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseRequisitionBindingNavigatorSaveItem;
        private ITshopDB2DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView purchaseRequisitionDataGridView;
        private System.Windows.Forms.TextBox pK_PurchaseRequisition_idTextBox;
        private System.Windows.Forms.TextBox fK_Employee_IDTextBox;
        private System.Windows.Forms.TextBox fK_Product_IDTextBox;
        private System.Windows.Forms.TextBox purchaserequisitionNameTextBox;
        private System.Windows.Forms.TextBox purchaserequisitionQTYTextBox;
        private System.Windows.Forms.TextBox purchaserequisitionPriceTextBox;
        private System.Windows.Forms.DateTimePicker purchaserequisitionDateDateTimePicker;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ITshopDB2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dataGrid_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}