namespace Store
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
            System.Windows.Forms.Label invoiceIDLabel;
            System.Windows.Forms.Label receiptPnameLabel;
            System.Windows.Forms.Label receiptQTYLabel;
            System.Windows.Forms.Label receiptPriceLabel;
            System.Windows.Forms.Label receiptTotalPriceLabel;
            System.Windows.Forms.Label receiptDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.iTshopDBDataSet = new Store.ITshopDBDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Store.ITshopDBDataSetTableAdapters.InvoiceTableAdapter();
            this.tableAdapterManager = new Store.ITshopDBDataSetTableAdapters.TableAdapterManager();
            this.receiptTableAdapter = new Store.ITshopDBDataSetTableAdapters.ReceiptTableAdapter();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorReceipt = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.invoiceIDTextBox = new System.Windows.Forms.TextBox();
            this.receiptPnameTextBox = new System.Windows.Forms.TextBox();
            this.receiptQTYTextBox = new System.Windows.Forms.TextBox();
            this.receiptPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptDate = new System.Windows.Forms.TextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            invoiceIDLabel = new System.Windows.Forms.Label();
            receiptPnameLabel = new System.Windows.Forms.Label();
            receiptQTYLabel = new System.Windows.Forms.Label();
            receiptPriceLabel = new System.Windows.Forms.Label();
            receiptTotalPriceLabel = new System.Windows.Forms.Label();
            receiptDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorReceipt)).BeginInit();
            this.bindingNavigatorReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceIDLabel
            // 
            invoiceIDLabel.AutoSize = true;
            invoiceIDLabel.Location = new System.Drawing.Point(33, 43);
            invoiceIDLabel.Name = "invoiceIDLabel";
            invoiceIDLabel.Size = new System.Drawing.Size(146, 32);
            invoiceIDLabel.TabIndex = 7;
            invoiceIDLabel.Text = "invoice ID:";
            // 
            // receiptPnameLabel
            // 
            receiptPnameLabel.AutoSize = true;
            receiptPnameLabel.Location = new System.Drawing.Point(33, 88);
            receiptPnameLabel.Name = "receiptPnameLabel";
            receiptPnameLabel.Size = new System.Drawing.Size(205, 32);
            receiptPnameLabel.TabIndex = 9;
            receiptPnameLabel.Text = "receipt Pname:";
            // 
            // receiptQTYLabel
            // 
            receiptQTYLabel.AutoSize = true;
            receiptQTYLabel.Location = new System.Drawing.Point(33, 133);
            receiptQTYLabel.Name = "receiptQTYLabel";
            receiptQTYLabel.Size = new System.Drawing.Size(173, 32);
            receiptQTYLabel.TabIndex = 11;
            receiptQTYLabel.Text = "receipt QTY:";
            // 
            // receiptPriceLabel
            // 
            receiptPriceLabel.AutoSize = true;
            receiptPriceLabel.Location = new System.Drawing.Point(33, 178);
            receiptPriceLabel.Name = "receiptPriceLabel";
            receiptPriceLabel.Size = new System.Drawing.Size(180, 32);
            receiptPriceLabel.TabIndex = 13;
            receiptPriceLabel.Text = "receipt Price:";
            // 
            // receiptTotalPriceLabel
            // 
            receiptTotalPriceLabel.AutoSize = true;
            receiptTotalPriceLabel.Location = new System.Drawing.Point(33, 223);
            receiptTotalPriceLabel.Name = "receiptTotalPriceLabel";
            receiptTotalPriceLabel.Size = new System.Drawing.Size(251, 32);
            receiptTotalPriceLabel.TabIndex = 15;
            receiptTotalPriceLabel.Text = "receipt Total Price:";
            // 
            // receiptDateLabel
            // 
            receiptDateLabel.AutoSize = true;
            receiptDateLabel.Location = new System.Drawing.Point(33, 269);
            receiptDateLabel.Name = "receiptDateLabel";
            receiptDateLabel.Size = new System.Drawing.Size(175, 32);
            receiptDateLabel.TabIndex = 17;
            receiptDateLabel.Text = "receipt Date:";
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
            this.tableAdapterManager.ReceiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.UpdateOrder = Store.ITshopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(18, 313);
            this.invoiceDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.RowHeadersWidth = 62;
            this.invoiceDataGridView.RowTemplate.Height = 28;
            this.invoiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceDataGridView.Size = new System.Drawing.Size(1251, 257);
            this.invoiceDataGridView.TabIndex = 1;
            this.invoiceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "invoiceID";
            this.dataGridViewTextBoxColumn1.HeaderText = "invoiceID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employeeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "employeeID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn3.HeaderText = "productID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "memberID";
            this.dataGridViewTextBoxColumn4.HeaderText = "memberID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "invoicePname";
            this.dataGridViewTextBoxColumn5.HeaderText = "invoicePname";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "invoiceQTY";
            this.dataGridViewTextBoxColumn6.HeaderText = "invoiceQTY";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "invoicePrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "invoicePrice";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "invoiceDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "invoiceDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 570);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(942, 39);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.iTshopDBDataSet;
            // 
            // receiptDataGridView
            // 
            this.receiptDataGridView.AutoGenerateColumns = false;
            this.receiptDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.receiptDataGridView.Location = new System.Drawing.Point(614, 40);
            this.receiptDataGridView.Name = "receiptDataGridView";
            this.receiptDataGridView.RowHeadersWidth = 62;
            this.receiptDataGridView.RowTemplate.Height = 28;
            this.receiptDataGridView.Size = new System.Drawing.Size(655, 261);
            this.receiptDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "receiptID";
            this.dataGridViewTextBoxColumn10.HeaderText = "receiptID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "invoiceID";
            this.dataGridViewTextBoxColumn11.HeaderText = "invoiceID";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "receiptPname";
            this.dataGridViewTextBoxColumn12.HeaderText = "receiptPname";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "receiptQTY";
            this.dataGridViewTextBoxColumn13.HeaderText = "receiptQTY";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "receiptPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "receiptPrice";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "receiptTotalPrice";
            this.dataGridViewTextBoxColumn15.HeaderText = "receiptTotalPrice";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "receiptDate";
            this.dataGridViewTextBoxColumn16.HeaderText = "receiptDate";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // bindingNavigatorReceipt
            // 
            this.bindingNavigatorReceipt.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorReceipt.BindingSource = this.receiptBindingSource;
            this.bindingNavigatorReceipt.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorReceipt.DeleteItem = null;
            this.bindingNavigatorReceipt.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorReceipt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripButton1,
            this.saveToolStripButton,
            this.toolStripSeparator});
            this.bindingNavigatorReceipt.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorReceipt.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorReceipt.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorReceipt.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorReceipt.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorReceipt.Name = "bindingNavigatorReceipt";
            this.bindingNavigatorReceipt.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorReceipt.Size = new System.Drawing.Size(1319, 41);
            this.bindingNavigatorReceipt.TabIndex = 4;
            this.bindingNavigatorReceipt.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 36);
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // invoiceIDTextBox
            // 
            this.invoiceIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "invoiceID", true));
            this.invoiceIDTextBox.Location = new System.Drawing.Point(290, 40);
            this.invoiceIDTextBox.Name = "invoiceIDTextBox";
            this.invoiceIDTextBox.Size = new System.Drawing.Size(304, 39);
            this.invoiceIDTextBox.TabIndex = 8;
            // 
            // receiptPnameTextBox
            // 
            this.receiptPnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPname", true));
            this.receiptPnameTextBox.Location = new System.Drawing.Point(290, 85);
            this.receiptPnameTextBox.Name = "receiptPnameTextBox";
            this.receiptPnameTextBox.Size = new System.Drawing.Size(304, 39);
            this.receiptPnameTextBox.TabIndex = 10;
            // 
            // receiptQTYTextBox
            // 
            this.receiptQTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptQTY", true));
            this.receiptQTYTextBox.Location = new System.Drawing.Point(290, 130);
            this.receiptQTYTextBox.Name = "receiptQTYTextBox";
            this.receiptQTYTextBox.Size = new System.Drawing.Size(304, 39);
            this.receiptQTYTextBox.TabIndex = 12;
            // 
            // receiptPriceTextBox
            // 
            this.receiptPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPrice", true));
            this.receiptPriceTextBox.Location = new System.Drawing.Point(290, 175);
            this.receiptPriceTextBox.Name = "receiptPriceTextBox";
            this.receiptPriceTextBox.Size = new System.Drawing.Size(304, 39);
            this.receiptPriceTextBox.TabIndex = 14;
            // 
            // receiptTotalPriceTextBox
            // 
            this.receiptTotalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptTotalPrice", true));
            this.receiptTotalPriceTextBox.Location = new System.Drawing.Point(290, 220);
            this.receiptTotalPriceTextBox.Name = "receiptTotalPriceTextBox";
            this.receiptTotalPriceTextBox.Size = new System.Drawing.Size(304, 39);
            this.receiptTotalPriceTextBox.TabIndex = 16;
            // 
            // receiptDate
            // 
            this.receiptDate.Location = new System.Drawing.Point(290, 269);
            this.receiptDate.Name = "receiptDate";
            this.receiptDate.Size = new System.Drawing.Size(304, 39);
            this.receiptDate.TabIndex = 19;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Store.Properties.Resources.trash_can_32px;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 644);
            this.Controls.Add(this.receiptDate);
            this.Controls.Add(invoiceIDLabel);
            this.Controls.Add(this.invoiceIDTextBox);
            this.Controls.Add(receiptPnameLabel);
            this.Controls.Add(this.receiptPnameTextBox);
            this.Controls.Add(receiptQTYLabel);
            this.Controls.Add(this.receiptQTYTextBox);
            this.Controls.Add(receiptPriceLabel);
            this.Controls.Add(this.receiptPriceTextBox);
            this.Controls.Add(receiptTotalPriceLabel);
            this.Controls.Add(this.receiptTotalPriceTextBox);
            this.Controls.Add(receiptDateLabel);
            this.Controls.Add(this.bindingNavigatorReceipt);
            this.Controls.Add(this.receiptDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.invoiceDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorReceipt)).EndInit();
            this.bindingNavigatorReceipt.ResumeLayout(false);
            this.bindingNavigatorReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDBDataSet iTshopDBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ITshopDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private ITshopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ITshopDBDataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.DataGridView receiptDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.BindingNavigator bindingNavigatorReceipt;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.TextBox invoiceIDTextBox;
        private System.Windows.Forms.TextBox receiptPnameTextBox;
        private System.Windows.Forms.TextBox receiptQTYTextBox;
        private System.Windows.Forms.TextBox receiptPriceTextBox;
        private System.Windows.Forms.TextBox receiptTotalPriceTextBox;
        private System.Windows.Forms.TextBox receiptDate;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}