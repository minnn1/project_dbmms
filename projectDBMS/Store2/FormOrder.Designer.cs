namespace Store2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Product = new System.Windows.Forms.TextBox();
            this.dateTimePicker_invoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxinvoiceTotalPrice = new System.Windows.Forms.TextBox();
            this.comboBox_Member = new System.Windows.Forms.ComboBox();
            this.textBoxinvoicePrice = new System.Windows.Forms.TextBox();
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_invoicePname = new System.Windows.Forms.TextBox();
            this.text_invoiceQTY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.dataGrid_Employee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.productTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.EmployeeTableAdapter();
            this.invoiceTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.InvoiceTableAdapter();
            this.membersTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.MembersTableAdapter();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(511, -7);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(179, 40);
            this.comboBox_Product.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Product);
            this.groupBox1.Controls.Add(this.dateTimePicker_invoiceDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxinvoiceTotalPrice);
            this.groupBox1.Controls.Add(this.comboBox_Member);
            this.groupBox1.Controls.Add(this.textBoxinvoicePrice);
            this.groupBox1.Controls.Add(this.comboBox_Employee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_invoicePname);
            this.groupBox1.Controls.Add(this.text_invoiceQTY);
            this.groupBox1.Location = new System.Drawing.Point(39, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 416);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มข้อมูลชำระสินค้า";
            // 
            // textBox_Product
            // 
            this.textBox_Product.Location = new System.Drawing.Point(215, 40);
            this.textBox_Product.Name = "textBox_Product";
            this.textBox_Product.Size = new System.Drawing.Size(180, 39);
            this.textBox_Product.TabIndex = 25;
            // 
            // dateTimePicker_invoiceDate
            // 
            this.dateTimePicker_invoiceDate.Location = new System.Drawing.Point(215, 363);
            this.dateTimePicker_invoiceDate.Name = "dateTimePicker_invoiceDate";
            this.dateTimePicker_invoiceDate.Size = new System.Drawing.Size(180, 39);
            this.dateTimePicker_invoiceDate.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "ราคารวม";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 32);
            this.label7.TabIndex = 25;
            this.label7.Text = "ชื่อรายการ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "วันที่ชำระ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "ราคาสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "จำนวนสินค้า";
            // 
            // textBoxinvoiceTotalPrice
            // 
            this.textBoxinvoiceTotalPrice.Location = new System.Drawing.Point(216, 317);
            this.textBoxinvoiceTotalPrice.Name = "textBoxinvoiceTotalPrice";
            this.textBoxinvoiceTotalPrice.Size = new System.Drawing.Size(179, 39);
            this.textBoxinvoiceTotalPrice.TabIndex = 20;
            // 
            // comboBox_Member
            // 
            this.comboBox_Member.FormattingEnabled = true;
            this.comboBox_Member.Location = new System.Drawing.Point(215, 87);
            this.comboBox_Member.Name = "comboBox_Member";
            this.comboBox_Member.Size = new System.Drawing.Size(179, 40);
            this.comboBox_Member.TabIndex = 18;
            // 
            // textBoxinvoicePrice
            // 
            this.textBoxinvoicePrice.Location = new System.Drawing.Point(216, 271);
            this.textBoxinvoicePrice.Name = "textBoxinvoicePrice";
            this.textBoxinvoicePrice.Size = new System.Drawing.Size(179, 39);
            this.textBoxinvoicePrice.TabIndex = 19;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(216, 132);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(179, 40);
            this.comboBox_Employee.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "พนักงานขาย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "สมาชิก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "สินค้า";
            // 
            // text_invoicePname
            // 
            this.text_invoicePname.Location = new System.Drawing.Point(216, 179);
            this.text_invoicePname.Name = "text_invoicePname";
            this.text_invoicePname.Size = new System.Drawing.Size(179, 39);
            this.text_invoicePname.TabIndex = 7;
            // 
            // text_invoiceQTY
            // 
            this.text_invoiceQTY.Location = new System.Drawing.Point(216, 225);
            this.text_invoiceQTY.Name = "text_invoiceQTY";
            this.text_invoiceQTY.Size = new System.Drawing.Size(179, 39);
            this.text_invoiceQTY.TabIndex = 8;
            this.text_invoiceQTY.TextChanged += new System.EventHandler(this.text_invoiceQTY_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productDataGridView);
            this.groupBox2.Controls.Add(this.dataGrid_Employee);
            this.groupBox2.Location = new System.Drawing.Point(462, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 452);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ส่วนเเสดงผล";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(23, 273);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(772, 152);
            this.productDataGridView.TabIndex = 24;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "PK_Product_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "productName";
            this.dataGridViewTextBoxColumn3.HeaderText = "productName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "productPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "productPrice";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid_Employee
            // 
            this.dataGrid_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column10,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGrid_Employee.Location = new System.Drawing.Point(23, 38);
            this.dataGrid_Employee.Name = "dataGrid_Employee";
            this.dataGrid_Employee.RowHeadersWidth = 62;
            this.dataGrid_Employee.RowTemplate.Height = 28;
            this.dataGrid_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Employee.Size = new System.Drawing.Size(772, 229);
            this.dataGrid_Employee.TabIndex = 9;
            this.dataGrid_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Employee_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_Invoice_id";
            this.Column1.HeaderText = "รหัสชำระ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "FK_Product_id";
            this.Column10.HeaderText = "รหัสสินค้า";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productName";
            this.Column2.HeaderText = "สินค้า";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "memberFname";
            this.Column3.HeaderText = "สมาชิก";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employeeFName";
            this.Column4.HeaderText = "พนักงานขาย";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "invoicePname";
            this.Column5.HeaderText = "รายการชำระ";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "invoiceQTY";
            this.Column6.HeaderText = "จำนวนสินค้า";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "invoicePrice";
            this.Column7.HeaderText = "ราคาสินค้า";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "invoiceTotalPrice";
            this.Column8.HeaderText = "ราคารวม";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "invoiceDate";
            this.Column9.HeaderText = "วันที่ชำระ";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(45, 507);
            this.textSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(395, 39);
            this.textSearch.TabIndex = 21;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(639, 507);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(167, 77);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Text = "เพิ่มพนักงานใหม่";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(816, 507);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(167, 77);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "บันทึกเเก้ไขข้อมูล";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(993, 507);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(167, 77);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "ลบพนักงาน";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(462, 507);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(167, 77);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "เพิ่มพนักงาน";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = this.invoiceTableAdapter;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.invoiceBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(1462, 33);
            this.productBindingNavigator.TabIndex = 24;
            this.productBindingNavigator.Text = "bindingNavigator1";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.iTshopDB2DataSet;
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
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 893);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBox_Product);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOrder";
            this.Text = "t";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_invoicePname;
        private System.Windows.Forms.TextBox text_invoiceQTY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGrid_Employee;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxinvoiceTotalPrice;
        private System.Windows.Forms.TextBox textBoxinvoicePrice;
        private System.Windows.Forms.ComboBox comboBox_Member;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private System.Windows.Forms.DateTimePicker dateTimePicker_invoiceDate;
        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ITshopDB2DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBox_Product;
        private ITshopDB2DataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private ITshopDB2DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private ITshopDB2DataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}