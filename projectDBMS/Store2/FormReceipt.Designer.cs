namespace Store2
{
    partial class FormReceipt
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
            System.Windows.Forms.Label receiptPnameLabel;
            System.Windows.Forms.Label receiptQTYLabel;
            System.Windows.Forms.Label receiptPriceLabel;
            System.Windows.Forms.Label receiptTotalPriceLabel;
            System.Windows.Forms.Label receiptDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ReceiptTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.receiptBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fK_Invoice_idTextBox = new System.Windows.Forms.TextBox();
            this.receiptPnameTextBox = new System.Windows.Forms.TextBox();
            this.receiptQTYTextBox = new System.Windows.Forms.TextBox();
            this.receiptPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.receiptBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.receiptDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fK_Invoice_idLabel = new System.Windows.Forms.Label();
            receiptPnameLabel = new System.Windows.Forms.Label();
            receiptQTYLabel = new System.Windows.Forms.Label();
            receiptPriceLabel = new System.Windows.Forms.Label();
            receiptTotalPriceLabel = new System.Windows.Forms.Label();
            receiptDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingNavigator)).BeginInit();
            this.receiptBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receiptBindingNavigator
            // 
            this.receiptBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receiptBindingNavigator.BindingSource = this.receiptBindingSource;
            this.receiptBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receiptBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receiptBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.receiptBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.receiptBindingNavigatorSaveItem});
            this.receiptBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receiptBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receiptBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receiptBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receiptBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receiptBindingNavigator.Name = "receiptBindingNavigator";
            this.receiptBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receiptBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.receiptBindingNavigator.TabIndex = 0;
            this.receiptBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // fK_Invoice_idLabel
            // 
            fK_Invoice_idLabel.AutoSize = true;
            fK_Invoice_idLabel.Location = new System.Drawing.Point(12, 110);
            fK_Invoice_idLabel.Name = "fK_Invoice_idLabel";
            fK_Invoice_idLabel.Size = new System.Drawing.Size(185, 32);
            fK_Invoice_idLabel.TabIndex = 3;
            fK_Invoice_idLabel.Text = "FK Invoice id:";
            // 
            // fK_Invoice_idTextBox
            // 
            this.fK_Invoice_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "FK_Invoice_id", true));
            this.fK_Invoice_idTextBox.Location = new System.Drawing.Point(269, 107);
            this.fK_Invoice_idTextBox.Name = "fK_Invoice_idTextBox";
            this.fK_Invoice_idTextBox.Size = new System.Drawing.Size(200, 39);
            this.fK_Invoice_idTextBox.TabIndex = 4;
            // 
            // receiptPnameLabel
            // 
            receiptPnameLabel.AutoSize = true;
            receiptPnameLabel.Location = new System.Drawing.Point(12, 155);
            receiptPnameLabel.Name = "receiptPnameLabel";
            receiptPnameLabel.Size = new System.Drawing.Size(205, 32);
            receiptPnameLabel.TabIndex = 5;
            receiptPnameLabel.Text = "receipt Pname:";
            // 
            // receiptPnameTextBox
            // 
            this.receiptPnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPname", true));
            this.receiptPnameTextBox.Location = new System.Drawing.Point(269, 152);
            this.receiptPnameTextBox.Name = "receiptPnameTextBox";
            this.receiptPnameTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptPnameTextBox.TabIndex = 6;
            // 
            // receiptQTYLabel
            // 
            receiptQTYLabel.AutoSize = true;
            receiptQTYLabel.Location = new System.Drawing.Point(12, 200);
            receiptQTYLabel.Name = "receiptQTYLabel";
            receiptQTYLabel.Size = new System.Drawing.Size(173, 32);
            receiptQTYLabel.TabIndex = 7;
            receiptQTYLabel.Text = "receipt QTY:";
            // 
            // receiptQTYTextBox
            // 
            this.receiptQTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptQTY", true));
            this.receiptQTYTextBox.Location = new System.Drawing.Point(269, 197);
            this.receiptQTYTextBox.Name = "receiptQTYTextBox";
            this.receiptQTYTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptQTYTextBox.TabIndex = 8;
            // 
            // receiptPriceLabel
            // 
            receiptPriceLabel.AutoSize = true;
            receiptPriceLabel.Location = new System.Drawing.Point(12, 245);
            receiptPriceLabel.Name = "receiptPriceLabel";
            receiptPriceLabel.Size = new System.Drawing.Size(180, 32);
            receiptPriceLabel.TabIndex = 9;
            receiptPriceLabel.Text = "receipt Price:";
            // 
            // receiptPriceTextBox
            // 
            this.receiptPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPrice", true));
            this.receiptPriceTextBox.Location = new System.Drawing.Point(269, 242);
            this.receiptPriceTextBox.Name = "receiptPriceTextBox";
            this.receiptPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptPriceTextBox.TabIndex = 10;
            // 
            // receiptTotalPriceLabel
            // 
            receiptTotalPriceLabel.AutoSize = true;
            receiptTotalPriceLabel.Location = new System.Drawing.Point(12, 290);
            receiptTotalPriceLabel.Name = "receiptTotalPriceLabel";
            receiptTotalPriceLabel.Size = new System.Drawing.Size(251, 32);
            receiptTotalPriceLabel.TabIndex = 11;
            receiptTotalPriceLabel.Text = "receipt Total Price:";
            // 
            // receiptTotalPriceTextBox
            // 
            this.receiptTotalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptTotalPrice", true));
            this.receiptTotalPriceTextBox.Location = new System.Drawing.Point(269, 287);
            this.receiptTotalPriceTextBox.Name = "receiptTotalPriceTextBox";
            this.receiptTotalPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptTotalPriceTextBox.TabIndex = 12;
            // 
            // receiptDateLabel
            // 
            receiptDateLabel.AutoSize = true;
            receiptDateLabel.Location = new System.Drawing.Point(12, 336);
            receiptDateLabel.Name = "receiptDateLabel";
            receiptDateLabel.Size = new System.Drawing.Size(175, 32);
            receiptDateLabel.TabIndex = 13;
            receiptDateLabel.Text = "receipt Date:";
            // 
            // receiptDateDateTimePicker
            // 
            this.receiptDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptBindingSource, "receiptDate", true));
            this.receiptDateDateTimePicker.Location = new System.Drawing.Point(269, 332);
            this.receiptDateDateTimePicker.Name = "receiptDateDateTimePicker";
            this.receiptDateDateTimePicker.Size = new System.Drawing.Size(200, 39);
            this.receiptDateDateTimePicker.TabIndex = 14;
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
            // receiptBindingNavigatorSaveItem
            // 
            this.receiptBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receiptBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receiptBindingNavigatorSaveItem.Image")));
            this.receiptBindingNavigatorSaveItem.Name = "receiptBindingNavigatorSaveItem";
            this.receiptBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.receiptBindingNavigatorSaveItem.Text = "Save Data";
            this.receiptBindingNavigatorSaveItem.Click += new System.EventHandler(this.receiptBindingNavigatorSaveItem_Click);
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(511, 245);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.RowHeadersWidth = 62;
            this.invoiceDataGridView.RowTemplate.Height = 28;
            this.invoiceDataGridView.Size = new System.Drawing.Size(735, 220);
            this.invoiceDataGridView.TabIndex = 15;
            this.invoiceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellClick);
            // 
            // receiptDataGridView
            // 
            this.receiptDataGridView.AutoGenerateColumns = false;
            this.receiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.receiptDataGridView.DataSource = this.receiptBindingSource;
            this.receiptDataGridView.Location = new System.Drawing.Point(511, 16);
            this.receiptDataGridView.Name = "receiptDataGridView";
            this.receiptDataGridView.RowHeadersWidth = 62;
            this.receiptDataGridView.RowTemplate.Height = 28;
            this.receiptDataGridView.Size = new System.Drawing.Size(735, 220);
            this.receiptDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PK_Receipt_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "PK_Receipt_id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FK_Invoice_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "FK_Invoice_id";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "receiptPname";
            this.dataGridViewTextBoxColumn12.HeaderText = "receiptPname";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "receiptQTY";
            this.dataGridViewTextBoxColumn13.HeaderText = "receiptQTY";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "receiptPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "receiptPrice";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "receiptTotalPrice";
            this.dataGridViewTextBoxColumn15.HeaderText = "receiptTotalPrice";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "receiptDate";
            this.dataGridViewTextBoxColumn16.HeaderText = "receiptDate";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Invoice_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "PK_Invoice_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "invoicePname";
            this.dataGridViewTextBoxColumn4.HeaderText = "invoicePname";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "invoiceQTY";
            this.dataGridViewTextBoxColumn5.HeaderText = "invoiceQTY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "invoicePrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "invoicePrice";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "invoiceDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "invoiceDate";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.receiptDataGridView);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(fK_Invoice_idLabel);
            this.Controls.Add(this.fK_Invoice_idTextBox);
            this.Controls.Add(receiptPnameLabel);
            this.Controls.Add(this.receiptPnameTextBox);
            this.Controls.Add(receiptQTYLabel);
            this.Controls.Add(this.receiptQTYTextBox);
            this.Controls.Add(receiptPriceLabel);
            this.Controls.Add(this.receiptPriceTextBox);
            this.Controls.Add(receiptTotalPriceLabel);
            this.Controls.Add(this.receiptTotalPriceTextBox);
            this.Controls.Add(receiptDateLabel);
            this.Controls.Add(this.receiptDateDateTimePicker);
            this.Controls.Add(this.receiptBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingNavigator)).EndInit();
            this.receiptBindingNavigator.ResumeLayout(false);
            this.receiptBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private ITshopDB2DataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receiptBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton receiptBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fK_Invoice_idTextBox;
        private System.Windows.Forms.TextBox receiptPnameTextBox;
        private System.Windows.Forms.TextBox receiptQTYTextBox;
        private System.Windows.Forms.TextBox receiptPriceTextBox;
        private System.Windows.Forms.TextBox receiptTotalPriceTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateDateTimePicker;
        private ITshopDB2DataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridView receiptDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}