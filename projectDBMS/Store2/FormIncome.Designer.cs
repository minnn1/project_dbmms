namespace Store2
{
    partial class FormIncome
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
            System.Windows.Forms.Label fK_Invoice_idLabel;
            System.Windows.Forms.Label incomeNameLabel;
            System.Windows.Forms.Label incomeDateLabel;
            System.Windows.Forms.Label pK_Income_idLabel;
            System.Windows.Forms.Label incomeTotalpriceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIncome));
            this.buttonQuery = new System.Windows.Forms.Button();
            this.txtboxOutputIncome = new System.Windows.Forms.TextBox();
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.IncomeTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.invoiceTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.InvoiceTableAdapter();
            this.incomeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.incomeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fK_Invoice_idTextBox = new System.Windows.Forms.TextBox();
            this.incomeNameTextBox = new System.Windows.Forms.TextBox();
            this.incomeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pK_Income_idTextBox = new System.Windows.Forms.TextBox();
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeTotalpriceTextBox = new System.Windows.Forms.TextBox();
            fK_Invoice_idLabel = new System.Windows.Forms.Label();
            incomeNameLabel = new System.Windows.Forms.Label();
            incomeDateLabel = new System.Windows.Forms.Label();
            pK_Income_idLabel = new System.Windows.Forms.Label();
            incomeTotalpriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingNavigator)).BeginInit();
            this.incomeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fK_Invoice_idLabel
            // 
            fK_Invoice_idLabel.AutoSize = true;
            fK_Invoice_idLabel.Location = new System.Drawing.Point(19, 96);
            fK_Invoice_idLabel.Name = "fK_Invoice_idLabel";
            fK_Invoice_idLabel.Size = new System.Drawing.Size(176, 32);
            fK_Invoice_idLabel.TabIndex = 9;
            fK_Invoice_idLabel.Text = "รหัสชำระสินค้า";
            // 
            // incomeNameLabel
            // 
            incomeNameLabel.AutoSize = true;
            incomeNameLabel.Location = new System.Drawing.Point(19, 141);
            incomeNameLabel.Name = "incomeNameLabel";
            incomeNameLabel.Size = new System.Drawing.Size(127, 32);
            incomeNameLabel.TabIndex = 11;
            incomeNameLabel.Text = "ชื่อรายการ";
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.Location = new System.Drawing.Point(19, 237);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new System.Drawing.Size(117, 32);
            incomeDateLabel.TabIndex = 15;
            incomeDateLabel.Text = "วันที่ชำระ";
            // 
            // pK_Income_idLabel
            // 
            pK_Income_idLabel.AutoSize = true;
            pK_Income_idLabel.Location = new System.Drawing.Point(19, 50);
            pK_Income_idLabel.Name = "pK_Income_idLabel";
            pK_Income_idLabel.Size = new System.Drawing.Size(130, 32);
            pK_Income_idLabel.TabIndex = 16;
            pK_Income_idLabel.Text = "รหัสรายรับ";
            // 
            // incomeTotalpriceLabel
            // 
            incomeTotalpriceLabel.AutoSize = true;
            incomeTotalpriceLabel.Location = new System.Drawing.Point(19, 191);
            incomeTotalpriceLabel.Name = "incomeTotalpriceLabel";
            incomeTotalpriceLabel.Size = new System.Drawing.Size(112, 32);
            incomeTotalpriceLabel.TabIndex = 13;
            incomeTotalpriceLabel.Text = "ราคารวม";
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(25, 297);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(175, 36);
            this.buttonQuery.TabIndex = 5;
            this.buttonQuery.Text = "เเสดงรายได้";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // txtboxOutputIncome
            // 
            this.txtboxOutputIncome.Location = new System.Drawing.Point(266, 294);
            this.txtboxOutputIncome.Name = "txtboxOutputIncome";
            this.txtboxOutputIncome.Size = new System.Drawing.Size(237, 39);
            this.txtboxOutputIncome.TabIndex = 6;
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataMember = "Income";
            this.incomeBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // incomeTableAdapter
            // 
            this.incomeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = this.incomeTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // incomeBindingNavigator
            // 
            this.incomeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.incomeBindingNavigator.BindingSource = this.incomeBindingSource;
            this.incomeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.incomeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.incomeBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.incomeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.incomeBindingNavigatorSaveItem});
            this.incomeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.incomeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.incomeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.incomeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.incomeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.incomeBindingNavigator.Name = "incomeBindingNavigator";
            this.incomeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.incomeBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.incomeBindingNavigator.TabIndex = 7;
            this.incomeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // incomeBindingNavigatorSaveItem
            // 
            this.incomeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.incomeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("incomeBindingNavigatorSaveItem.Image")));
            this.incomeBindingNavigatorSaveItem.Name = "incomeBindingNavigatorSaveItem";
            this.incomeBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.incomeBindingNavigatorSaveItem.Text = "Save Data";
            this.incomeBindingNavigatorSaveItem.Click += new System.EventHandler(this.incomeBindingNavigatorSaveItem_Click);
            // 
            // fK_Invoice_idTextBox
            // 
            this.fK_Invoice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "FK_Invoice_id", true));
            this.fK_Invoice_idTextBox.Location = new System.Drawing.Point(272, 93);
            this.fK_Invoice_idTextBox.Name = "fK_Invoice_idTextBox";
            this.fK_Invoice_idTextBox.ReadOnly = true;
            this.fK_Invoice_idTextBox.Size = new System.Drawing.Size(231, 39);
            this.fK_Invoice_idTextBox.TabIndex = 10;
            // 
            // incomeNameTextBox
            // 
            this.incomeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "incomeName", true));
            this.incomeNameTextBox.Location = new System.Drawing.Point(272, 138);
            this.incomeNameTextBox.Name = "incomeNameTextBox";
            this.incomeNameTextBox.Size = new System.Drawing.Size(231, 39);
            this.incomeNameTextBox.TabIndex = 12;
            this.incomeNameTextBox.Text = "รายการรายได้ที่ ";
            // 
            // incomeDateDateTimePicker
            // 
            this.incomeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.incomeBindingSource, "incomeDate", true));
            this.incomeDateDateTimePicker.Location = new System.Drawing.Point(272, 233);
            this.incomeDateDateTimePicker.Name = "incomeDateDateTimePicker";
            this.incomeDateDateTimePicker.Size = new System.Drawing.Size(231, 39);
            this.incomeDateDateTimePicker.TabIndex = 16;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(525, 275);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            this.invoiceDataGridView.RowHeadersWidth = 62;
            this.invoiceDataGridView.RowTemplate.Height = 28;
            this.invoiceDataGridView.Size = new System.Drawing.Size(736, 220);
            this.invoiceDataGridView.TabIndex = 16;
            this.invoiceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Invoice_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสชำระสินค้า";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "invoicePname";
            this.dataGridViewTextBoxColumn4.HeaderText = "ชื่อสินค้า";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "invoiceQTY";
            this.dataGridViewTextBoxColumn5.HeaderText = "จำนวนสินค้า";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "invoicePrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "ราคาสินค้า";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "ราคาสั่งซื้อ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "invoiceDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "วันที่ชำระ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // pK_Income_idTextBox
            // 
            this.pK_Income_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "PK_Income_id", true));
            this.pK_Income_idTextBox.Location = new System.Drawing.Point(272, 50);
            this.pK_Income_idTextBox.Name = "pK_Income_idTextBox";
            this.pK_Income_idTextBox.ReadOnly = true;
            this.pK_Income_idTextBox.Size = new System.Drawing.Size(231, 39);
            this.pK_Income_idTextBox.TabIndex = 17;
            this.pK_Income_idTextBox.TextChanged += new System.EventHandler(this.pK_Income_idTextBox_TextChanged);
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.AutoGenerateColumns = false;
            this.incomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.incomeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.incomeDataGridView.DataSource = this.incomeBindingSource;
            this.incomeDataGridView.Location = new System.Drawing.Point(525, 44);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.RowHeadersWidth = 62;
            this.incomeDataGridView.RowTemplate.Height = 28;
            this.incomeDataGridView.Size = new System.Drawing.Size(736, 220);
            this.incomeDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PK_Income_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสรายรับ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FK_Invoice_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "รหัสชำระสินค้า";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "incomeName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ชื่อรายการ";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "incomeTotalprice";
            this.dataGridViewTextBoxColumn10.HeaderText = "ราคารวม";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "incomeDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "วันที่ชำระ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // incomeTotalpriceTextBox
            // 
            this.incomeTotalpriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "incomeTotalprice", true));
            this.incomeTotalpriceTextBox.Location = new System.Drawing.Point(272, 188);
            this.incomeTotalpriceTextBox.Name = "incomeTotalpriceTextBox";
            this.incomeTotalpriceTextBox.Size = new System.Drawing.Size(231, 39);
            this.incomeTotalpriceTextBox.TabIndex = 14;
            // 
            // FormIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 702);
            this.Controls.Add(this.incomeBindingNavigator);
            this.Controls.Add(this.incomeDataGridView);
            this.Controls.Add(pK_Income_idLabel);
            this.Controls.Add(this.pK_Income_idTextBox);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(fK_Invoice_idLabel);
            this.Controls.Add(this.fK_Invoice_idTextBox);
            this.Controls.Add(incomeNameLabel);
            this.Controls.Add(this.incomeNameTextBox);
            this.Controls.Add(incomeTotalpriceLabel);
            this.Controls.Add(this.incomeTotalpriceTextBox);
            this.Controls.Add(incomeDateLabel);
            this.Controls.Add(this.incomeDateDateTimePicker);
            this.Controls.Add(this.txtboxOutputIncome);
            this.Controls.Add(this.buttonQuery);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormIncome";
            this.Text = "FormIncome";
            this.Load += new System.EventHandler(this.FormIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingNavigator)).EndInit();
            this.incomeBindingNavigator.ResumeLayout(false);
            this.incomeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.TextBox txtboxOutputIncome;
        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private ITshopDB2DataSetTableAdapters.IncomeTableAdapter incomeTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator incomeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton incomeBindingNavigatorSaveItem;
        private ITshopDB2DataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.TextBox fK_Invoice_idTextBox;
        private System.Windows.Forms.TextBox incomeNameTextBox;
        private System.Windows.Forms.DateTimePicker incomeDateDateTimePicker;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.TextBox pK_Income_idTextBox;
        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox incomeTotalpriceTextBox;
    }
}