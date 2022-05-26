namespace Store2
{
    partial class FormExpress
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
            System.Windows.Forms.Label pK_Income_idLabel;
            System.Windows.Forms.Label fK_Invoice_idLabel;
            System.Windows.Forms.Label incomeNameLabel;
            System.Windows.Forms.Label incomeTotalpriceLabel;
            System.Windows.Forms.Label incomeDateLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpress));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ExpensesTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.purchaseOrderTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.PurchaseOrderTableAdapter();
            this.expensesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.expensesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.expensesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pK_Expenses_idTextBox = new System.Windows.Forms.TextBox();
            this.fK_PurchaseOrder_idTextBox = new System.Windows.Forms.TextBox();
            this.expensesNameTextBox = new System.Windows.Forms.TextBox();
            this.expensesTotalpriceTextBox = new System.Windows.Forms.TextBox();
            this.expensesDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtboxOutputIncome = new System.Windows.Forms.TextBox();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            pK_Income_idLabel = new System.Windows.Forms.Label();
            fK_Invoice_idLabel = new System.Windows.Forms.Label();
            incomeNameLabel = new System.Windows.Forms.Label();
            incomeTotalpriceLabel = new System.Windows.Forms.Label();
            incomeDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingNavigator)).BeginInit();
            this.expensesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pK_Income_idLabel
            // 
            pK_Income_idLabel.AutoSize = true;
            pK_Income_idLabel.Location = new System.Drawing.Point(44, 45);
            pK_Income_idLabel.Name = "pK_Income_idLabel";
            pK_Income_idLabel.Size = new System.Drawing.Size(140, 32);
            pK_Income_idLabel.TabIndex = 21;
            pK_Income_idLabel.Text = "รหัสรายจ่าย";
            // 
            // fK_Invoice_idLabel
            // 
            fK_Invoice_idLabel.AutoSize = true;
            fK_Invoice_idLabel.Location = new System.Drawing.Point(37, 91);
            fK_Invoice_idLabel.Name = "fK_Invoice_idLabel";
            fK_Invoice_idLabel.Size = new System.Drawing.Size(147, 32);
            fK_Invoice_idLabel.TabIndex = 17;
            fK_Invoice_idLabel.Text = "รหัสใบสั่งซื้อ";
            // 
            // incomeNameLabel
            // 
            incomeNameLabel.AutoSize = true;
            incomeNameLabel.Location = new System.Drawing.Point(57, 136);
            incomeNameLabel.Name = "incomeNameLabel";
            incomeNameLabel.Size = new System.Drawing.Size(127, 32);
            incomeNameLabel.TabIndex = 18;
            incomeNameLabel.Text = "ชื่อรายการ";
            // 
            // incomeTotalpriceLabel
            // 
            incomeTotalpriceLabel.AutoSize = true;
            incomeTotalpriceLabel.Location = new System.Drawing.Point(72, 238);
            incomeTotalpriceLabel.Name = "incomeTotalpriceLabel";
            incomeTotalpriceLabel.Size = new System.Drawing.Size(112, 32);
            incomeTotalpriceLabel.TabIndex = 19;
            incomeTotalpriceLabel.Text = "ราคารวม";
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.Location = new System.Drawing.Point(64, 301);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new System.Drawing.Size(120, 32);
            incomeDateLabel.TabIndex = 20;
            incomeDateLabel.Text = "วันที่สั่งซื้อ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(57, 189);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(127, 32);
            label1.TabIndex = 24;
            label1.Text = "ราคาสั่งซื้อ";
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = this.expensesTableAdapter;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = this.purchaseOrderTableAdapter;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseOrderTableAdapter
            // 
            this.purchaseOrderTableAdapter.ClearBeforeFill = true;
            // 
            // expensesBindingNavigator
            // 
            this.expensesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.expensesBindingNavigator.BindingSource = this.expensesBindingSource;
            this.expensesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.expensesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.expensesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.expensesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.expensesBindingNavigatorSaveItem});
            this.expensesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.expensesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.expensesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.expensesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.expensesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.expensesBindingNavigator.Name = "expensesBindingNavigator";
            this.expensesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.expensesBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.expensesBindingNavigator.TabIndex = 0;
            this.expensesBindingNavigator.Text = "bindingNavigator1";
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
            // expensesBindingNavigatorSaveItem
            // 
            this.expensesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.expensesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("expensesBindingNavigatorSaveItem.Image")));
            this.expensesBindingNavigatorSaveItem.Name = "expensesBindingNavigatorSaveItem";
            this.expensesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.expensesBindingNavigatorSaveItem.Text = "Save Data";
            this.expensesBindingNavigatorSaveItem.Click += new System.EventHandler(this.expensesBindingNavigatorSaveItem_Click);
            // 
            // expensesDataGridView
            // 
            this.expensesDataGridView.AutoGenerateColumns = false;
            this.expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.expensesDataGridView.DataSource = this.expensesBindingSource;
            this.expensesDataGridView.Location = new System.Drawing.Point(580, 48);
            this.expensesDataGridView.Name = "expensesDataGridView";
            this.expensesDataGridView.RowHeadersWidth = 62;
            this.expensesDataGridView.RowTemplate.Height = 28;
            this.expensesDataGridView.Size = new System.Drawing.Size(577, 257);
            this.expensesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Expenses_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสรายจ่าย";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FK_PurchaseOrder_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสใบขอซื้อ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "expensesName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ชื่อรายการ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "expensesTotalprice";
            this.dataGridViewTextBoxColumn4.HeaderText = "ราคารวม";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "expensesDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "วันที่สั่งซื้อ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // pK_Expenses_idTextBox
            // 
            this.pK_Expenses_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "PK_Expenses_id", true));
            this.pK_Expenses_idTextBox.Location = new System.Drawing.Point(229, 48);
            this.pK_Expenses_idTextBox.Name = "pK_Expenses_idTextBox";
            this.pK_Expenses_idTextBox.Size = new System.Drawing.Size(292, 39);
            this.pK_Expenses_idTextBox.TabIndex = 3;
            // 
            // fK_PurchaseOrder_idTextBox
            // 
            this.fK_PurchaseOrder_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "FK_PurchaseOrder_id", true));
            this.fK_PurchaseOrder_idTextBox.Location = new System.Drawing.Point(229, 93);
            this.fK_PurchaseOrder_idTextBox.Name = "fK_PurchaseOrder_idTextBox";
            this.fK_PurchaseOrder_idTextBox.Size = new System.Drawing.Size(292, 39);
            this.fK_PurchaseOrder_idTextBox.TabIndex = 5;
            // 
            // expensesNameTextBox
            // 
            this.expensesNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "expensesName", true));
            this.expensesNameTextBox.Location = new System.Drawing.Point(229, 138);
            this.expensesNameTextBox.Name = "expensesNameTextBox";
            this.expensesNameTextBox.Size = new System.Drawing.Size(292, 39);
            this.expensesNameTextBox.TabIndex = 7;
            this.expensesNameTextBox.Text = "รายการรายจ่ายที่ ";
            // 
            // expensesTotalpriceTextBox
            // 
            this.expensesTotalpriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "expensesTotalprice", true));
            this.expensesTotalpriceTextBox.Location = new System.Drawing.Point(229, 240);
            this.expensesTotalpriceTextBox.Name = "expensesTotalpriceTextBox";
            this.expensesTotalpriceTextBox.Size = new System.Drawing.Size(292, 39);
            this.expensesTotalpriceTextBox.TabIndex = 9;
            // 
            // expensesDateDateTimePicker
            // 
            this.expensesDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.expensesBindingSource, "expensesDate", true));
            this.expensesDateDateTimePicker.Location = new System.Drawing.Point(229, 301);
            this.expensesDateDateTimePicker.Name = "expensesDateDateTimePicker";
            this.expensesDateDateTimePicker.Size = new System.Drawing.Size(292, 39);
            this.expensesDateDateTimePicker.TabIndex = 11;
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataMember = "PurchaseOrder";
            this.purchaseOrderBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // purchaseOrderDataGridView
            // 
            this.purchaseOrderDataGridView.AutoGenerateColumns = false;
            this.purchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.purchaseOrderDataGridView.DataSource = this.purchaseOrderBindingSource;
            this.purchaseOrderDataGridView.Location = new System.Drawing.Point(580, 324);
            this.purchaseOrderDataGridView.Name = "purchaseOrderDataGridView";
            this.purchaseOrderDataGridView.RowHeadersWidth = 62;
            this.purchaseOrderDataGridView.RowTemplate.Height = 28;
            this.purchaseOrderDataGridView.Size = new System.Drawing.Size(577, 289);
            this.purchaseOrderDataGridView.TabIndex = 12;
            this.purchaseOrderDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseOrderDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PK_PurchaseOrder_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "รหัสใบสั่งซื้อ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FK_PurchaseRequisition_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "รหัสใบขอซื้อ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "purchaseorderName";
            this.dataGridViewTextBoxColumn8.HeaderText = "รายการสั่งซื้อ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "purchaseorderQTY";
            this.dataGridViewTextBoxColumn9.HeaderText = "จำนวนขอซื้อ";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "purchaseorderPrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "ราคาสั่งซื้อ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "purchaseorderDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "วันที่สั่งซื้อ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // txtboxOutputIncome
            // 
            this.txtboxOutputIncome.Location = new System.Drawing.Point(236, 376);
            this.txtboxOutputIncome.Name = "txtboxOutputIncome";
            this.txtboxOutputIncome.Size = new System.Drawing.Size(316, 39);
            this.txtboxOutputIncome.TabIndex = 23;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(7, 376);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(211, 36);
            this.buttonQuery.TabIndex = 22;
            this.buttonQuery.Text = "เเสดงรายจ่าย";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(229, 189);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(292, 39);
            this.priceTextBox.TabIndex = 25;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // FormExpress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(label1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.txtboxOutputIncome);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(pK_Income_idLabel);
            this.Controls.Add(fK_Invoice_idLabel);
            this.Controls.Add(incomeNameLabel);
            this.Controls.Add(incomeTotalpriceLabel);
            this.Controls.Add(incomeDateLabel);
            this.Controls.Add(this.purchaseOrderDataGridView);
            this.Controls.Add(this.pK_Expenses_idTextBox);
            this.Controls.Add(this.fK_PurchaseOrder_idTextBox);
            this.Controls.Add(this.expensesNameTextBox);
            this.Controls.Add(this.expensesTotalpriceTextBox);
            this.Controls.Add(this.expensesDateDateTimePicker);
            this.Controls.Add(this.expensesDataGridView);
            this.Controls.Add(this.expensesBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormExpress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExpress";
            this.Load += new System.EventHandler(this.FormExpress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingNavigator)).EndInit();
            this.expensesBindingNavigator.ResumeLayout(false);
            this.expensesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private ITshopDB2DataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator expensesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton expensesBindingNavigatorSaveItem;
        private ITshopDB2DataSetTableAdapters.PurchaseOrderTableAdapter purchaseOrderTableAdapter;
        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.TextBox pK_Expenses_idTextBox;
        private System.Windows.Forms.TextBox fK_PurchaseOrder_idTextBox;
        private System.Windows.Forms.TextBox expensesNameTextBox;
        private System.Windows.Forms.TextBox expensesTotalpriceTextBox;
        private System.Windows.Forms.DateTimePicker expensesDateDateTimePicker;
        private System.Windows.Forms.BindingSource purchaseOrderBindingSource;
        private System.Windows.Forms.DataGridView purchaseOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TextBox txtboxOutputIncome;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}