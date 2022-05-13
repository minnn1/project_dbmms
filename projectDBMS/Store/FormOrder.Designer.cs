namespace Store
{
    partial class FormOrder
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
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label invoicePnameLabel;
            System.Windows.Forms.Label invoiceQTYLabel;
            System.Windows.Forms.Label invoicePriceLabel;
            System.Windows.Forms.Label invoiceTotalPriceLabel;
            System.Windows.Forms.Label invoiceDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.iTshopDBDataSet = new Store.ITshopDBDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Store.ITshopDBDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new Store.ITshopDBDataSetTableAdapters.TableAdapterManager();
            this.invoiceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.invoiceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.invoicePnameTextBox = new System.Windows.Forms.TextBox();
            this.invoicePriceTextBox = new System.Windows.Forms.TextBox();
            this.invoiceTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTotalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datagirdMember = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceQTYTextBox1 = new System.Windows.Forms.NumericUpDown();
            invoiceIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            memberIDLabel = new System.Windows.Forms.Label();
            invoicePnameLabel = new System.Windows.Forms.Label();
            invoiceQTYLabel = new System.Windows.Forms.Label();
            invoicePriceLabel = new System.Windows.Forms.Label();
            invoiceTotalPriceLabel = new System.Windows.Forms.Label();
            invoiceDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).BeginInit();
            this.invoiceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagirdMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceQTYTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(25, 51);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(146, 32);
            invoiceIDLabel.TabIndex = 1;
            invoiceIDLabel.Text = "invoice ID:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(25, 96);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(180, 32);
            employeeIDLabel.TabIndex = 3;
            employeeIDLabel.Text = "employee ID:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(25, 141);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(151, 32);
            productIDLabel.TabIndex = 5;
            productIDLabel.Text = "product ID:";
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(25, 186);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(159, 32);
            memberIDLabel.TabIndex = 7;
            memberIDLabel.Text = "member ID:";
            // 
            // invoicePnameLabel
            // 
            invoicePnameLabel.AutoSize = true;
            invoicePnameLabel.Location = new System.Drawing.Point(25, 231);
            invoicePnameLabel.Name = "invoicePnameLabel";
            invoicePnameLabel.Size = new System.Drawing.Size(209, 32);
            invoicePnameLabel.TabIndex = 9;
            invoicePnameLabel.Text = "invoice Pname:";
            // 
            // invoiceQTYLabel
            // 
            invoiceQTYLabel.AutoSize = true;
            invoiceQTYLabel.Location = new System.Drawing.Point(25, 276);
            invoiceQTYLabel.Name = "invoiceQTYLabel";
            invoiceQTYLabel.Size = new System.Drawing.Size(177, 32);
            invoiceQTYLabel.TabIndex = 11;
            invoiceQTYLabel.Text = "invoice QTY:";
            // 
            // invoicePriceLabel
            // 
            invoicePriceLabel.AutoSize = true;
            invoicePriceLabel.Location = new System.Drawing.Point(25, 321);
            invoicePriceLabel.Name = "invoicePriceLabel";
            invoicePriceLabel.Size = new System.Drawing.Size(184, 32);
            invoicePriceLabel.TabIndex = 13;
            invoicePriceLabel.Text = "invoice Price:";
            // 
            // invoiceTotalPriceLabel
            // 
            invoiceTotalPriceLabel.AutoSize = true;
            invoiceTotalPriceLabel.Location = new System.Drawing.Point(25, 366);
            invoiceTotalPriceLabel.Name = "invoiceTotalPriceLabel";
            invoiceTotalPriceLabel.Size = new System.Drawing.Size(255, 32);
            invoiceTotalPriceLabel.TabIndex = 15;
            invoiceTotalPriceLabel.Text = "invoice Total Price:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.Location = new System.Drawing.Point(25, 412);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(179, 32);
            invoiceDateLabel.TabIndex = 17;
            invoiceDateLabel.Text = "invoice Date:";
            // 
            // iTshopDBDataSet
            // 
            this.iTshopDBDataSet.DataSetName = "ITshopDBDataSet";
            this.iTshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.iTshopDBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store.ITshopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceBindingNavigator
            // 
            this.invoiceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoiceBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.invoiceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoiceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoiceBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.invoiceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.invoiceBindingNavigatorSaveItem});
            this.invoiceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoiceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoiceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoiceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoiceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoiceBindingNavigator.Name = "invoiceBindingNavigator";
            this.invoiceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoiceBindingNavigator.Size = new System.Drawing.Size(1284, 33);
            this.invoiceBindingNavigator.TabIndex = 0;
            this.invoiceBindingNavigator.Text = "bindingNavigator1";
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
            // invoiceBindingNavigatorSaveItem
            // 
            this.invoiceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoiceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBindingNavigatorSaveItem.Image")));
            this.invoiceBindingNavigatorSaveItem.Name = "invoiceBindingNavigatorSaveItem";
            this.invoiceBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.invoiceBindingNavigatorSaveItem.Text = "Save Data";
            this.invoiceBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoiceBindingNavigatorSaveItem_Click_1);
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(286, 48);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoiceIDTextBox.TabIndex = 2;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "employeeID", true));
            this.employeeIDTextBox.Location = new System.Drawing.Point(286, 93);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(200, 39);
            this.employeeIDTextBox.TabIndex = 4;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "productID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(286, 138);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(200, 39);
            this.productIDTextBox.TabIndex = 6;
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "memberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(286, 183);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(200, 39);
            this.memberIDTextBox.TabIndex = 8;
            // 
            // invoicePnameTextBox
            // 
            this.invoicePnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoicePname", true));
            this.invoicePnameTextBox.Location = new System.Drawing.Point(286, 228);
            this.invoicePnameTextBox.Name = "invoicePnameTextBox";
            this.invoicePnameTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoicePnameTextBox.TabIndex = 10;
            // 
            // invoicePriceTextBox
            // 
            this.invoicePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoicePrice", true));
            this.invoicePriceTextBox.Location = new System.Drawing.Point(286, 318);
            this.invoicePriceTextBox.Name = "invoicePriceTextBox";
            this.invoicePriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoicePriceTextBox.TabIndex = 14;
            // 
            // invoiceTotalPriceTextBox
            // 
            this.invoiceTotalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoiceTotalPrice", true));
            this.invoiceTotalPriceTextBox.Location = new System.Drawing.Point(286, 363);
            this.invoiceTotalPriceTextBox.Name = "invoiceTotalPriceTextBox";
            this.invoiceTotalPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoiceTotalPriceTextBox.TabIndex = 16;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "invoiceDate", true));
            this.invoiceDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "invoiceDate", true));
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(286, 408);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 39);
            this.invoiceDateDateTimePicker.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.invoicePnameDataGridViewTextBoxColumn,
            this.invoiceQTYDataGridViewTextBoxColumn,
            this.invoicePriceDataGridViewTextBoxColumn,
            this.invoiceTotalPriceDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(527, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 284);
            this.dataGridView1.TabIndex = 19;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "invoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoiceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "memberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoicePnameDataGridViewTextBoxColumn
            // 
            this.invoicePnameDataGridViewTextBoxColumn.DataPropertyName = "invoicePname";
            this.invoicePnameDataGridViewTextBoxColumn.HeaderText = "invoicePname";
            this.invoicePnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoicePnameDataGridViewTextBoxColumn.Name = "invoicePnameDataGridViewTextBoxColumn";
            this.invoicePnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceQTYDataGridViewTextBoxColumn
            // 
            this.invoiceQTYDataGridViewTextBoxColumn.DataPropertyName = "invoiceQTY";
            this.invoiceQTYDataGridViewTextBoxColumn.HeaderText = "invoiceQTY";
            this.invoiceQTYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceQTYDataGridViewTextBoxColumn.Name = "invoiceQTYDataGridViewTextBoxColumn";
            this.invoiceQTYDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoicePriceDataGridViewTextBoxColumn
            // 
            this.invoicePriceDataGridViewTextBoxColumn.DataPropertyName = "invoicePrice";
            this.invoicePriceDataGridViewTextBoxColumn.HeaderText = "invoicePrice";
            this.invoicePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoicePriceDataGridViewTextBoxColumn.Name = "invoicePriceDataGridViewTextBoxColumn";
            this.invoicePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceTotalPriceDataGridViewTextBoxColumn
            // 
            this.invoiceTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "invoiceTotalPrice";
            this.invoiceTotalPriceDataGridViewTextBoxColumn.HeaderText = "invoiceTotalPrice";
            this.invoiceTotalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceTotalPriceDataGridViewTextBoxColumn.Name = "invoiceTotalPriceDataGridViewTextBoxColumn";
            this.invoiceTotalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "invoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "invoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridProduct.Location = new System.Drawing.Point(527, 350);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersWidth = 62;
            this.dataGridProduct.RowTemplate.Height = 28;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(403, 253);
            this.dataGridProduct.TabIndex = 20;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "productID";
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
            // Column3
            // 
            this.Column3.DataPropertyName = "productPrice";
            this.Column3.HeaderText = "ราคาสินค้า";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // datagirdMember
            // 
            this.datagirdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagirdMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.datagirdMember.Location = new System.Drawing.Point(936, 350);
            this.datagirdMember.Name = "datagirdMember";
            this.datagirdMember.RowHeadersWidth = 62;
            this.datagirdMember.RowTemplate.Height = 28;
            this.datagirdMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagirdMember.Size = new System.Drawing.Size(336, 253);
            this.datagirdMember.TabIndex = 21;
            this.datagirdMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagirdMember_CellClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "memberID";
            this.Column4.HeaderText = "รหัสสมาชิก";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "memberFname";
            this.Column5.HeaderText = "ชื่อสมาชิก";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dataGridEmp.Location = new System.Drawing.Point(164, 453);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.RowHeadersWidth = 62;
            this.dataGridEmp.RowTemplate.Height = 28;
            this.dataGridEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmp.Size = new System.Drawing.Size(336, 150);
            this.dataGridEmp.TabIndex = 22;
            this.dataGridEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmp_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "employeeID";
            this.Column6.HeaderText = "รหัสพนักงาน";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "employeeFName";
            this.Column7.HeaderText = "ชื่อพนักงาน";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // invoiceQTYTextBox1
            // 
            this.invoiceQTYTextBox1.Location = new System.Drawing.Point(286, 276);
            this.invoiceQTYTextBox1.Name = "invoiceQTYTextBox1";
            this.invoiceQTYTextBox1.Size = new System.Drawing.Size(200, 39);
            this.invoiceQTYTextBox1.TabIndex = 23;
            this.invoiceQTYTextBox1.ValueChanged += new System.EventHandler(this.invoiceQTYTextBox1_ValueChanged);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 886);
            this.Controls.Add(this.invoiceQTYTextBox1);
            this.Controls.Add(this.dataGridEmp);
            this.Controls.Add(this.datagirdMember);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(invoiceIDLabel);
            this.Controls.Add(this.invoiceIDTextBox);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(invoicePnameLabel);
            this.Controls.Add(this.invoicePnameTextBox);
            this.Controls.Add(invoiceQTYLabel);
            this.Controls.Add(invoicePriceLabel);
            this.Controls.Add(this.invoicePriceTextBox);
            this.Controls.Add(invoiceTotalPriceLabel);
            this.Controls.Add(this.invoiceTotalPriceTextBox);
            this.Controls.Add(invoiceDateLabel);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(this.invoiceBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingNavigator)).EndInit();
            this.invoiceBindingNavigator.ResumeLayout(false);
            this.invoiceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagirdMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceQTYTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDBDataSet iTshopDBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ITshopDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private ITshopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoiceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton invoiceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox invoicePnameTextBox;
        private System.Windows.Forms.TextBox invoicePriceTextBox;
        private System.Windows.Forms.TextBox invoiceTotalPriceTextBox;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.DataGridView datagirdMember;
        private System.Windows.Forms.DataGridView dataGridEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTotalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.NumericUpDown invoiceQTYTextBox1;
    }
}