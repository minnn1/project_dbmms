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
            System.Windows.Forms.Label receiptIDLabel;
            System.Windows.Forms.Label receiptPnameLabel;
            System.Windows.Forms.Label receiptQTYLabel;
            System.Windows.Forms.Label receiptPriceLabel;
            System.Windows.Forms.Label receiptTotalPriceLabel;
            System.Windows.Forms.Label receiptDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.iTshopDBDataSet1 = new Store.ITshopDBDataSet1();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptTableAdapter = new Store.ITshopDBDataSet1TableAdapters.ReceiptTableAdapter();
            this.tableAdapterManager = new Store.ITshopDBDataSet1TableAdapters.TableAdapterManager();
            this.invoiceTableAdapter = new Store.ITshopDBDataSet1TableAdapters.InvoiceTableAdapter();
            this.receiptBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.receiptBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.receiptIDTextBox = new System.Windows.Forms.TextBox();
            this.receiptPnameTextBox = new System.Windows.Forms.TextBox();
            this.receiptQTYTextBox = new System.Windows.Forms.TextBox();
            this.receiptPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            receiptIDLabel = new System.Windows.Forms.Label();
            receiptPnameLabel = new System.Windows.Forms.Label();
            receiptQTYLabel = new System.Windows.Forms.Label();
            receiptPriceLabel = new System.Windows.Forms.Label();
            receiptTotalPriceLabel = new System.Windows.Forms.Label();
            receiptDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingNavigator)).BeginInit();
            this.receiptBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptIDLabel
            // 
            receiptIDLabel.AutoSize = true;
            receiptIDLabel.Location = new System.Drawing.Point(34, 50);
            receiptIDLabel.Name = "receiptIDLabel";
            receiptIDLabel.Size = new System.Drawing.Size(142, 32);
            receiptIDLabel.TabIndex = 2;
            receiptIDLabel.Text = "receipt ID:";
            // 
            // receiptPnameLabel
            // 
            receiptPnameLabel.AutoSize = true;
            receiptPnameLabel.Location = new System.Drawing.Point(34, 95);
            receiptPnameLabel.Name = "receiptPnameLabel";
            receiptPnameLabel.Size = new System.Drawing.Size(205, 32);
            receiptPnameLabel.TabIndex = 4;
            receiptPnameLabel.Text = "receipt Pname:";
            // 
            // receiptQTYLabel
            // 
            receiptQTYLabel.AutoSize = true;
            receiptQTYLabel.Location = new System.Drawing.Point(34, 140);
            receiptQTYLabel.Name = "receiptQTYLabel";
            receiptQTYLabel.Size = new System.Drawing.Size(173, 32);
            receiptQTYLabel.TabIndex = 6;
            receiptQTYLabel.Text = "receipt QTY:";
            // 
            // receiptPriceLabel
            // 
            receiptPriceLabel.AutoSize = true;
            receiptPriceLabel.Location = new System.Drawing.Point(34, 185);
            receiptPriceLabel.Name = "receiptPriceLabel";
            receiptPriceLabel.Size = new System.Drawing.Size(180, 32);
            receiptPriceLabel.TabIndex = 8;
            receiptPriceLabel.Text = "receipt Price:";
            // 
            // receiptTotalPriceLabel
            // 
            receiptTotalPriceLabel.AutoSize = true;
            receiptTotalPriceLabel.Location = new System.Drawing.Point(34, 230);
            receiptTotalPriceLabel.Name = "receiptTotalPriceLabel";
            receiptTotalPriceLabel.Size = new System.Drawing.Size(251, 32);
            receiptTotalPriceLabel.TabIndex = 10;
            receiptTotalPriceLabel.Text = "receipt Total Price:";
            // 
            // receiptDateLabel
            // 
            receiptDateLabel.AutoSize = true;
            receiptDateLabel.Location = new System.Drawing.Point(34, 276);
            receiptDateLabel.Name = "receiptDateLabel";
            receiptDateLabel.Size = new System.Drawing.Size(175, 32);
            receiptDateLabel.TabIndex = 12;
            receiptDateLabel.Text = "receipt Date:";
            // 
            // iTshopDBDataSet1
            // 
            this.iTshopDBDataSet1.DataSetName = "ITshopDBDataSet1";
            this.iTshopDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.iTshopDBDataSet1;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.ReceiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.UpdateOrder = Store.ITshopDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
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
            this.receiptBindingNavigator.Size = new System.Drawing.Size(1327, 33);
            this.receiptBindingNavigator.TabIndex = 0;
            this.receiptBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // receiptBindingNavigatorSaveItem
            // 
            this.receiptBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receiptBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receiptBindingNavigatorSaveItem.Image")));
            this.receiptBindingNavigatorSaveItem.Name = "receiptBindingNavigatorSaveItem";
            this.receiptBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.receiptBindingNavigatorSaveItem.Text = "Save Data";
            this.receiptBindingNavigatorSaveItem.Click += new System.EventHandler(this.receiptBindingNavigatorSaveItem_Click_2);
            // 
            // receiptIDTextBox
            // 
            this.receiptIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptID", true));
            this.receiptIDTextBox.Location = new System.Drawing.Point(291, 47);
            this.receiptIDTextBox.Name = "receiptIDTextBox";
            this.receiptIDTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptIDTextBox.TabIndex = 3;
            // 
            // receiptPnameTextBox
            // 
            this.receiptPnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPname", true));
            this.receiptPnameTextBox.Location = new System.Drawing.Point(291, 92);
            this.receiptPnameTextBox.Name = "receiptPnameTextBox";
            this.receiptPnameTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptPnameTextBox.TabIndex = 5;
            // 
            // receiptQTYTextBox
            // 
            this.receiptQTYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptQTY", true));
            this.receiptQTYTextBox.Location = new System.Drawing.Point(291, 137);
            this.receiptQTYTextBox.Name = "receiptQTYTextBox";
            this.receiptQTYTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptQTYTextBox.TabIndex = 7;
            // 
            // receiptPriceTextBox
            // 
            this.receiptPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptPrice", true));
            this.receiptPriceTextBox.Location = new System.Drawing.Point(291, 182);
            this.receiptPriceTextBox.Name = "receiptPriceTextBox";
            this.receiptPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptPriceTextBox.TabIndex = 9;
            // 
            // receiptTotalPriceTextBox
            // 
            this.receiptTotalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "receiptTotalPrice", true));
            this.receiptTotalPriceTextBox.Location = new System.Drawing.Point(291, 227);
            this.receiptTotalPriceTextBox.Name = "receiptTotalPriceTextBox";
            this.receiptTotalPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.receiptTotalPriceTextBox.TabIndex = 11;
            // 
            // receiptDateDateTimePicker
            // 
            this.receiptDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receiptBindingSource, "receiptDate", true));
            this.receiptDateDateTimePicker.Location = new System.Drawing.Point(291, 272);
            this.receiptDateDateTimePicker.Name = "receiptDateDateTimePicker";
            this.receiptDateDateTimePicker.Size = new System.Drawing.Size(200, 39);
            this.receiptDateDateTimePicker.TabIndex = 13;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.iTshopDBDataSet1;
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(26, 368);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.RowHeadersWidth = 62;
            this.invoiceDataGridView.RowTemplate.Height = 28;
            this.invoiceDataGridView.Size = new System.Drawing.Size(1332, 220);
            this.invoiceDataGridView.TabIndex = 14;
            this.invoiceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "invoiceID";
            this.dataGridViewTextBoxColumn7.HeaderText = "invoiceID";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "employeeID";
            this.dataGridViewTextBoxColumn8.HeaderText = "employeeID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn9.HeaderText = "productID";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "memberID";
            this.dataGridViewTextBoxColumn10.HeaderText = "memberID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "invoicePname";
            this.dataGridViewTextBoxColumn11.HeaderText = "invoicePname";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "invoiceQTY";
            this.dataGridViewTextBoxColumn12.HeaderText = "invoiceQTY";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "invoicePrice";
            this.dataGridViewTextBoxColumn13.HeaderText = "invoicePrice";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn14.HeaderText = "invoiceTotalPrice";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "invoiceDate";
            this.dataGridViewTextBoxColumn15.HeaderText = "invoiceDate";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(555, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(721, 264);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(receiptIDLabel);
            this.Controls.Add(this.receiptIDTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.Load += new System.EventHandler(this.FormReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingNavigator)).EndInit();
            this.receiptBindingNavigator.ResumeLayout(false);
            this.receiptBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDBDataSet1 iTshopDBDataSet1;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private ITshopDBDataSet1TableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private ITshopDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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
        private ITshopDBDataSet1TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.TextBox receiptIDTextBox;
        private System.Windows.Forms.TextBox receiptPnameTextBox;
        private System.Windows.Forms.TextBox receiptQTYTextBox;
        private System.Windows.Forms.TextBox receiptPriceTextBox;
        private System.Windows.Forms.TextBox receiptTotalPriceTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateDateTimePicker;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}