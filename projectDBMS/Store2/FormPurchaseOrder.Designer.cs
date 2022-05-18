namespace Store2
{
    partial class FormPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchaseOrder));
            System.Windows.Forms.Label pK_PurchaseRequisition_idLabel;
            System.Windows.Forms.Label fK_Product_IDLabel;
            System.Windows.Forms.Label purchaserequisitionNameLabel;
            System.Windows.Forms.Label purchaserequisitionQTYLabel;
            System.Windows.Forms.Label purchaserequisitionPriceLabel;
            System.Windows.Forms.Label purchaserequisitionDateLabel;
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.PurchaseOrderTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.purchaseRequisitionTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.PurchaseRequisitionTableAdapter();
            this.purchaseOrderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.purchaseOrderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pK_PurchaseOrder_idTextBox = new System.Windows.Forms.TextBox();
            this.fK_PurchaseRequisition_idTextBox = new System.Windows.Forms.TextBox();
            this.purchaseorderNameTextBox = new System.Windows.Forms.TextBox();
            this.purchaseorderQTYTextBox = new System.Windows.Forms.TextBox();
            this.purchaseorderPriceTextBox = new System.Windows.Forms.TextBox();
            this.purchaseorderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseRequisitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRequisitionDataGridView = new System.Windows.Forms.DataGridView();
            this.purchaseOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pK_PurchaseRequisition_idLabel = new System.Windows.Forms.Label();
            fK_Product_IDLabel = new System.Windows.Forms.Label();
            purchaserequisitionNameLabel = new System.Windows.Forms.Label();
            purchaserequisitionQTYLabel = new System.Windows.Forms.Label();
            purchaserequisitionPriceLabel = new System.Windows.Forms.Label();
            purchaserequisitionDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingNavigator)).BeginInit();
            this.purchaseOrderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = this.purchaseOrderTableAdapter;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = this.purchaseRequisitionTableAdapter;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseRequisitionTableAdapter
            // 
            this.purchaseRequisitionTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseOrderBindingNavigator
            // 
            this.purchaseOrderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseOrderBindingNavigator.BindingSource = this.purchaseOrderBindingSource;
            this.purchaseOrderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseOrderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseOrderBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.purchaseOrderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseOrderBindingNavigatorSaveItem});
            this.purchaseOrderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseOrderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseOrderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseOrderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseOrderBindingNavigator.Name = "purchaseOrderBindingNavigator";
            this.purchaseOrderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseOrderBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.purchaseOrderBindingNavigator.TabIndex = 0;
            this.purchaseOrderBindingNavigator.Text = "bindingNavigator1";
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
            // purchaseOrderBindingNavigatorSaveItem
            // 
            this.purchaseOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseOrderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseOrderBindingNavigatorSaveItem.Image")));
            this.purchaseOrderBindingNavigatorSaveItem.Name = "purchaseOrderBindingNavigatorSaveItem";
            this.purchaseOrderBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.purchaseOrderBindingNavigatorSaveItem.Text = "Save Data";
            this.purchaseOrderBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseOrderBindingNavigatorSaveItem_Click);
            // 
            // pK_PurchaseOrder_idTextBox
            // 
            this.pK_PurchaseOrder_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "PK_PurchaseOrder_id", true));
            this.pK_PurchaseOrder_idTextBox.Location = new System.Drawing.Point(213, 70);
            this.pK_PurchaseOrder_idTextBox.Name = "pK_PurchaseOrder_idTextBox";
            this.pK_PurchaseOrder_idTextBox.ReadOnly = true;
            this.pK_PurchaseOrder_idTextBox.Size = new System.Drawing.Size(246, 39);
            this.pK_PurchaseOrder_idTextBox.TabIndex = 2;
            // 
            // fK_PurchaseRequisition_idTextBox
            // 
            this.fK_PurchaseRequisition_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "FK_PurchaseRequisition_id", true));
            this.fK_PurchaseRequisition_idTextBox.Location = new System.Drawing.Point(213, 115);
            this.fK_PurchaseRequisition_idTextBox.Name = "fK_PurchaseRequisition_idTextBox";
            this.fK_PurchaseRequisition_idTextBox.ReadOnly = true;
            this.fK_PurchaseRequisition_idTextBox.Size = new System.Drawing.Size(246, 39);
            this.fK_PurchaseRequisition_idTextBox.TabIndex = 4;
            // 
            // purchaseorderNameTextBox
            // 
            this.purchaseorderNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "purchaseorderName", true));
            this.purchaseorderNameTextBox.Location = new System.Drawing.Point(213, 160);
            this.purchaseorderNameTextBox.Name = "purchaseorderNameTextBox";
            this.purchaseorderNameTextBox.ReadOnly = true;
            this.purchaseorderNameTextBox.Size = new System.Drawing.Size(246, 39);
            this.purchaseorderNameTextBox.TabIndex = 6;
            // 
            // purchaseorderQTYTextBox
            // 
            this.purchaseorderQTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "purchaseorderQTY", true));
            this.purchaseorderQTYTextBox.Location = new System.Drawing.Point(213, 205);
            this.purchaseorderQTYTextBox.Name = "purchaseorderQTYTextBox";
            this.purchaseorderQTYTextBox.ReadOnly = true;
            this.purchaseorderQTYTextBox.Size = new System.Drawing.Size(246, 39);
            this.purchaseorderQTYTextBox.TabIndex = 8;
            // 
            // purchaseorderPriceTextBox
            // 
            this.purchaseorderPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purchaseOrderBindingSource, "purchaseorderPrice", true));
            this.purchaseorderPriceTextBox.Location = new System.Drawing.Point(213, 250);
            this.purchaseorderPriceTextBox.Name = "purchaseorderPriceTextBox";
            this.purchaseorderPriceTextBox.ReadOnly = true;
            this.purchaseorderPriceTextBox.Size = new System.Drawing.Size(246, 39);
            this.purchaseorderPriceTextBox.TabIndex = 10;
            // 
            // purchaseorderDateDateTimePicker
            // 
            this.purchaseorderDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.purchaseOrderBindingSource, "purchaseorderDate", true));
            this.purchaseorderDateDateTimePicker.Location = new System.Drawing.Point(213, 295);
            this.purchaseorderDateDateTimePicker.Name = "purchaseorderDateDateTimePicker";
            this.purchaseorderDateDateTimePicker.Size = new System.Drawing.Size(246, 39);
            this.purchaseorderDateDateTimePicker.TabIndex = 12;
            // 
            // purchaseRequisitionBindingSource
            // 
            this.purchaseRequisitionBindingSource.DataMember = "PurchaseRequisition";
            this.purchaseRequisitionBindingSource.DataSource = this.iTshopDB2DataSet;
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
            this.purchaseRequisitionDataGridView.Location = new System.Drawing.Point(544, 284);
            this.purchaseRequisitionDataGridView.Name = "purchaseRequisitionDataGridView";
            this.purchaseRequisitionDataGridView.RowHeadersWidth = 62;
            this.purchaseRequisitionDataGridView.RowTemplate.Height = 28;
            this.purchaseRequisitionDataGridView.Size = new System.Drawing.Size(688, 272);
            this.purchaseRequisitionDataGridView.TabIndex = 13;
            this.purchaseRequisitionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseRequisitionDataGridView_CellClick);
            // 
            // purchaseOrderDataGridView
            // 
            this.purchaseOrderDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchaseOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.purchaseOrderDataGridView.DataSource = this.purchaseOrderBindingSource;
            this.purchaseOrderDataGridView.Location = new System.Drawing.Point(544, 36);
            this.purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            this.purchaseOrderDataGridView.RowHeadersWidth = 62;
            this.purchaseOrderDataGridView.RowTemplate.Height = 28;
            this.purchaseOrderDataGridView.Size = new System.Drawing.Size(688, 220);
            this.purchaseOrderDataGridView.TabIndex = 14;
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
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PK_PurchaseOrder_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "รหัสใบสั่งซื้อ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FK_PurchaseRequisition_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "รหัสใบขอซื้อ";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "purchaseorderName";
            this.dataGridViewTextBoxColumn10.HeaderText = "รายการสั่งซื้อ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "purchaseorderQTY";
            this.dataGridViewTextBoxColumn11.HeaderText = "จำนวนสั่งซื้อ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "purchaseorderPrice";
            this.dataGridViewTextBoxColumn12.HeaderText = "ราคาสั่งซื้อ";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "purchaseorderDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "วันที่สั่งซื้อ";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // pK_PurchaseRequisition_idLabel
            // 
            pK_PurchaseRequisition_idLabel.AutoSize = true;
            pK_PurchaseRequisition_idLabel.Location = new System.Drawing.Point(12, 70);
            pK_PurchaseRequisition_idLabel.Name = "pK_PurchaseRequisition_idLabel";
            pK_PurchaseRequisition_idLabel.Size = new System.Drawing.Size(147, 32);
            pK_PurchaseRequisition_idLabel.TabIndex = 15;
            pK_PurchaseRequisition_idLabel.Text = "รหัสใบสั่งซื้อ";
            // 
            // fK_Product_IDLabel
            // 
            fK_Product_IDLabel.AutoSize = true;
            fK_Product_IDLabel.Location = new System.Drawing.Point(12, 122);
            fK_Product_IDLabel.Name = "fK_Product_IDLabel";
            fK_Product_IDLabel.Size = new System.Drawing.Size(151, 32);
            fK_Product_IDLabel.TabIndex = 17;
            fK_Product_IDLabel.Text = "รหัสใบขอซื้อ";
            // 
            // purchaserequisitionNameLabel
            // 
            purchaserequisitionNameLabel.AutoSize = true;
            purchaserequisitionNameLabel.Location = new System.Drawing.Point(12, 167);
            purchaserequisitionNameLabel.Name = "purchaserequisitionNameLabel";
            purchaserequisitionNameLabel.Size = new System.Drawing.Size(154, 32);
            purchaserequisitionNameLabel.TabIndex = 18;
            purchaserequisitionNameLabel.Text = "รายการสั่งซื้อ";
            // 
            // purchaserequisitionQTYLabel
            // 
            purchaserequisitionQTYLabel.AutoSize = true;
            purchaserequisitionQTYLabel.Location = new System.Drawing.Point(12, 212);
            purchaserequisitionQTYLabel.Name = "purchaserequisitionQTYLabel";
            purchaserequisitionQTYLabel.Size = new System.Drawing.Size(147, 32);
            purchaserequisitionQTYLabel.TabIndex = 19;
            purchaserequisitionQTYLabel.Text = "จำนวนสั่งซื้อ";
            // 
            // purchaserequisitionPriceLabel
            // 
            purchaserequisitionPriceLabel.AutoSize = true;
            purchaserequisitionPriceLabel.Location = new System.Drawing.Point(12, 257);
            purchaserequisitionPriceLabel.Name = "purchaserequisitionPriceLabel";
            purchaserequisitionPriceLabel.Size = new System.Drawing.Size(127, 32);
            purchaserequisitionPriceLabel.TabIndex = 20;
            purchaserequisitionPriceLabel.Text = "ราคาสั่งซื้อ";
            // 
            // purchaserequisitionDateLabel
            // 
            purchaserequisitionDateLabel.AutoSize = true;
            purchaserequisitionDateLabel.Location = new System.Drawing.Point(12, 303);
            purchaserequisitionDateLabel.Name = "purchaserequisitionDateLabel";
            purchaserequisitionDateLabel.Size = new System.Drawing.Size(120, 32);
            purchaserequisitionDateLabel.TabIndex = 21;
            purchaserequisitionDateLabel.Text = "วันที่สั่งซื้อ";
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(pK_PurchaseRequisition_idLabel);
            this.Controls.Add(fK_Product_IDLabel);
            this.Controls.Add(purchaserequisitionNameLabel);
            this.Controls.Add(purchaserequisitionQTYLabel);
            this.Controls.Add(purchaserequisitionPriceLabel);
            this.Controls.Add(purchaserequisitionDateLabel);
            this.Controls.Add(this.purchaseOrderDataGridView);
            this.Controls.Add(this.purchaseRequisitionDataGridView);
            this.Controls.Add(this.pK_PurchaseOrder_idTextBox);
            this.Controls.Add(this.fK_PurchaseRequisition_idTextBox);
            this.Controls.Add(this.purchaseorderNameTextBox);
            this.Controls.Add(this.purchaseorderQTYTextBox);
            this.Controls.Add(this.purchaseorderPriceTextBox);
            this.Controls.Add(this.purchaseorderDateDateTimePicker);
            this.Controls.Add(this.purchaseOrderBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPurchaseOrder";
            this.Text = "FormPurchaseOrder";
            this.Load += new System.EventHandler(this.FormPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingNavigator)).EndInit();
            this.purchaseOrderBindingNavigator.ResumeLayout(false);
            this.purchaseOrderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequisitionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private ITshopDB2DataSetTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseOrderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseOrderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pK_PurchaseOrder_idTextBox;
        private System.Windows.Forms.TextBox fK_PurchaseRequisition_idTextBox;
        private System.Windows.Forms.TextBox purchaseorderNameTextBox;
        private System.Windows.Forms.TextBox purchaseorderQTYTextBox;
        private System.Windows.Forms.TextBox purchaseorderPriceTextBox;
        private System.Windows.Forms.DateTimePicker purchaseorderDateDateTimePicker;
        private ITshopDB2DataSetTableAdapters.PurchaseRequisitionTableAdapter purchaseRequisitionTableAdapter;
        private System.Windows.Forms.BindingSource purchaseRequisitionBindingSource;
        private System.Windows.Forms.DataGridView purchaseRequisitionDataGridView;
        private System.Windows.Forms.DataGridView purchaseOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}