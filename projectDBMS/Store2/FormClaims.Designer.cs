namespace Store2
{
    partial class FormClaims
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
            System.Windows.Forms.Label pK_Claims_idLabel;
            System.Windows.Forms.Label fK_Receipt_idLabel;
            System.Windows.Forms.Label fK_Members_idLabel;
            System.Windows.Forms.Label claimPnameLabel;
            System.Windows.Forms.Label claimDetailsLabel;
            System.Windows.Forms.Label claimDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClaims));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claimsTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ClaimsTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.receiptTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.ReceiptTableAdapter();
            this.claimsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.claimsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pK_Claims_idTextBox = new System.Windows.Forms.TextBox();
            this.fK_Receipt_idTextBox = new System.Windows.Forms.TextBox();
            this.fK_Members_idTextBox = new System.Windows.Forms.TextBox();
            this.claimPnameTextBox = new System.Windows.Forms.TextBox();
            this.claimDetailsTextBox = new System.Windows.Forms.TextBox();
            this.claimDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.claimsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDataGridView = new System.Windows.Forms.DataGridView();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.MembersTableAdapter();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pK_Claims_idLabel = new System.Windows.Forms.Label();
            fK_Receipt_idLabel = new System.Windows.Forms.Label();
            fK_Members_idLabel = new System.Windows.Forms.Label();
            claimPnameLabel = new System.Windows.Forms.Label();
            claimDetailsLabel = new System.Windows.Forms.Label();
            claimDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingNavigator)).BeginInit();
            this.claimsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pK_Claims_idLabel
            // 
            pK_Claims_idLabel.AutoSize = true;
            pK_Claims_idLabel.Location = new System.Drawing.Point(13, 52);
            pK_Claims_idLabel.Name = "pK_Claims_idLabel";
            pK_Claims_idLabel.Size = new System.Drawing.Size(142, 32);
            pK_Claims_idLabel.TabIndex = 1;
            pK_Claims_idLabel.Text = "รหัสใบเคลม";
            // 
            // fK_Receipt_idLabel
            // 
            fK_Receipt_idLabel.AutoSize = true;
            fK_Receipt_idLabel.Location = new System.Drawing.Point(13, 97);
            fK_Receipt_idLabel.Name = "fK_Receipt_idLabel";
            fK_Receipt_idLabel.Size = new System.Drawing.Size(139, 32);
            fK_Receipt_idLabel.TabIndex = 3;
            fK_Receipt_idLabel.Text = "รหัสใบเสร็จ";
            // 
            // fK_Members_idLabel
            // 
            fK_Members_idLabel.AutoSize = true;
            fK_Members_idLabel.Location = new System.Drawing.Point(13, 142);
            fK_Members_idLabel.Name = "fK_Members_idLabel";
            fK_Members_idLabel.Size = new System.Drawing.Size(135, 32);
            fK_Members_idLabel.TabIndex = 5;
            fK_Members_idLabel.Text = "รหัสสมาชิก";
            // 
            // claimPnameLabel
            // 
            claimPnameLabel.AutoSize = true;
            claimPnameLabel.Location = new System.Drawing.Point(13, 187);
            claimPnameLabel.Name = "claimPnameLabel";
            claimPnameLabel.Size = new System.Drawing.Size(209, 32);
            claimPnameLabel.TabIndex = 7;
            claimPnameLabel.Text = "รายการเคลมสินค้า";
            // 
            // claimDetailsLabel
            // 
            claimDetailsLabel.AutoSize = true;
            claimDetailsLabel.Location = new System.Drawing.Point(13, 232);
            claimDetailsLabel.Name = "claimDetailsLabel";
            claimDetailsLabel.Size = new System.Drawing.Size(229, 32);
            claimDetailsLabel.TabIndex = 9;
            claimDetailsLabel.Text = "รายละเอียดการเคลม";
            // 
            // claimDateLabel
            // 
            claimDateLabel.AutoSize = true;
            claimDateLabel.Location = new System.Drawing.Point(13, 278);
            claimDateLabel.Name = "claimDateLabel";
            claimDateLabel.Size = new System.Drawing.Size(115, 32);
            claimDateLabel.TabIndex = 11;
            claimDateLabel.Text = "วันที่เคลม";
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsBindingSource
            // 
            this.claimsBindingSource.DataMember = "Claims";
            this.claimsBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // claimsTableAdapter
            // 
            this.claimsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = this.claimsTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = this.receiptTableAdapter;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receiptTableAdapter
            // 
            this.receiptTableAdapter.ClearBeforeFill = true;
            // 
            // claimsBindingNavigator
            // 
            this.claimsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.claimsBindingNavigator.BindingSource = this.claimsBindingSource;
            this.claimsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.claimsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.claimsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.claimsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.claimsBindingNavigatorSaveItem});
            this.claimsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.claimsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.claimsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.claimsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.claimsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.claimsBindingNavigator.Name = "claimsBindingNavigator";
            this.claimsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.claimsBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.claimsBindingNavigator.TabIndex = 0;
            this.claimsBindingNavigator.Text = "bindingNavigator1";
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
            // claimsBindingNavigatorSaveItem
            // 
            this.claimsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.claimsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("claimsBindingNavigatorSaveItem.Image")));
            this.claimsBindingNavigatorSaveItem.Name = "claimsBindingNavigatorSaveItem";
            this.claimsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.claimsBindingNavigatorSaveItem.Text = "Save Data";
            this.claimsBindingNavigatorSaveItem.Click += new System.EventHandler(this.claimsBindingNavigatorSaveItem_Click);
            // 
            // pK_Claims_idTextBox
            // 
            this.pK_Claims_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.claimsBindingSource, "PK_Claims_id", true));
            this.pK_Claims_idTextBox.Location = new System.Drawing.Point(231, 49);
            this.pK_Claims_idTextBox.Name = "pK_Claims_idTextBox";
            this.pK_Claims_idTextBox.Size = new System.Drawing.Size(226, 39);
            this.pK_Claims_idTextBox.TabIndex = 2;
            // 
            // fK_Receipt_idTextBox
            // 
            this.fK_Receipt_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.claimsBindingSource, "FK_Receipt_id", true));
            this.fK_Receipt_idTextBox.Location = new System.Drawing.Point(231, 94);
            this.fK_Receipt_idTextBox.Name = "fK_Receipt_idTextBox";
            this.fK_Receipt_idTextBox.Size = new System.Drawing.Size(226, 39);
            this.fK_Receipt_idTextBox.TabIndex = 4;
            // 
            // fK_Members_idTextBox
            // 
            this.fK_Members_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.claimsBindingSource, "FK_Members_id", true));
            this.fK_Members_idTextBox.Location = new System.Drawing.Point(231, 139);
            this.fK_Members_idTextBox.Name = "fK_Members_idTextBox";
            this.fK_Members_idTextBox.Size = new System.Drawing.Size(226, 39);
            this.fK_Members_idTextBox.TabIndex = 6;
            // 
            // claimPnameTextBox
            // 
            this.claimPnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.claimsBindingSource, "claimPname", true));
            this.claimPnameTextBox.Location = new System.Drawing.Point(231, 184);
            this.claimPnameTextBox.Name = "claimPnameTextBox";
            this.claimPnameTextBox.Size = new System.Drawing.Size(226, 39);
            this.claimPnameTextBox.TabIndex = 8;
            // 
            // claimDetailsTextBox
            // 
            this.claimDetailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.claimsBindingSource, "claimDetails", true));
            this.claimDetailsTextBox.Location = new System.Drawing.Point(231, 229);
            this.claimDetailsTextBox.Name = "claimDetailsTextBox";
            this.claimDetailsTextBox.Size = new System.Drawing.Size(226, 39);
            this.claimDetailsTextBox.TabIndex = 10;
            // 
            // claimDateDateTimePicker
            // 
            this.claimDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.claimsBindingSource, "claimDate", true));
            this.claimDateDateTimePicker.Location = new System.Drawing.Point(231, 274);
            this.claimDateDateTimePicker.Name = "claimDateDateTimePicker";
            this.claimDateDateTimePicker.Size = new System.Drawing.Size(226, 39);
            this.claimDateDateTimePicker.TabIndex = 12;
            // 
            // claimsDataGridView
            // 
            this.claimsDataGridView.AutoGenerateColumns = false;
            this.claimsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.claimsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.claimsDataGridView.DataSource = this.claimsBindingSource;
            this.claimsDataGridView.Location = new System.Drawing.Point(484, 49);
            this.claimsDataGridView.Name = "claimsDataGridView";
            this.claimsDataGridView.RowHeadersWidth = 62;
            this.claimsDataGridView.RowTemplate.Height = 28;
            this.claimsDataGridView.Size = new System.Drawing.Size(666, 220);
            this.claimsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Claims_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสใบเคลม";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FK_Receipt_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสใบเสร็จ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FK_Members_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "รหัสสมาชิก";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "claimPname";
            this.dataGridViewTextBoxColumn4.HeaderText = "รายการเคลม";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "claimDetails";
            this.dataGridViewTextBoxColumn5.HeaderText = "รายละเอียดการเคลม";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "claimDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "วันที่เคลม";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "Receipt";
            this.receiptBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // receiptDataGridView
            // 
            this.receiptDataGridView.AutoGenerateColumns = false;
            this.receiptDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.receiptDataGridView.DataSource = this.receiptBindingSource;
            this.receiptDataGridView.Location = new System.Drawing.Point(484, 309);
            this.receiptDataGridView.Name = "receiptDataGridView";
            this.receiptDataGridView.RowHeadersWidth = 62;
            this.receiptDataGridView.RowTemplate.Height = 28;
            this.receiptDataGridView.Size = new System.Drawing.Size(674, 220);
            this.receiptDataGridView.TabIndex = 20;
            this.receiptDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDataGridView_CellClick);
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.Location = new System.Drawing.Point(19, 337);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.RowHeadersWidth = 62;
            this.membersDataGridView.RowTemplate.Height = 28;
            this.membersDataGridView.Size = new System.Drawing.Size(438, 220);
            this.membersDataGridView.TabIndex = 20;
            this.membersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PK_Members_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "รหัสสมาชิก";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "memberFname";
            this.dataGridViewTextBoxColumn9.HeaderText = "ชื่อสมาชิก";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "memberLname";
            this.dataGridViewTextBoxColumn10.HeaderText = "นามสกุล";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PK_Receipt_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "รหัสใบเสร็จ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FK_Invoice_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "รหัสชำระสินค้า";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "receiptPname";
            this.dataGridViewTextBoxColumn13.HeaderText = "รายการสินค้า";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "receiptQTY";
            this.dataGridViewTextBoxColumn14.HeaderText = "จำนวนสินค้า";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "receiptPrice";
            this.dataGridViewTextBoxColumn15.HeaderText = "ราคาสินค้า";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "receiptTotalPrice";
            this.dataGridViewTextBoxColumn16.HeaderText = "ราคารวม";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "receiptDate";
            this.dataGridViewTextBoxColumn17.HeaderText = "วันที่ออกใบเสร็จ";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // FormClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.receiptDataGridView);
            this.Controls.Add(this.claimsDataGridView);
            this.Controls.Add(pK_Claims_idLabel);
            this.Controls.Add(this.pK_Claims_idTextBox);
            this.Controls.Add(fK_Receipt_idLabel);
            this.Controls.Add(this.fK_Receipt_idTextBox);
            this.Controls.Add(fK_Members_idLabel);
            this.Controls.Add(this.fK_Members_idTextBox);
            this.Controls.Add(claimPnameLabel);
            this.Controls.Add(this.claimPnameTextBox);
            this.Controls.Add(claimDetailsLabel);
            this.Controls.Add(this.claimDetailsTextBox);
            this.Controls.Add(claimDateLabel);
            this.Controls.Add(this.claimDateDateTimePicker);
            this.Controls.Add(this.claimsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormClaims";
            this.Text = "FormClaims";
            this.Load += new System.EventHandler(this.FormClaims_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingNavigator)).EndInit();
            this.claimsBindingNavigator.ResumeLayout(false);
            this.claimsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claimsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource claimsBindingSource;
        private ITshopDB2DataSetTableAdapters.ClaimsTableAdapter claimsTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator claimsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton claimsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pK_Claims_idTextBox;
        private System.Windows.Forms.TextBox fK_Receipt_idTextBox;
        private System.Windows.Forms.TextBox fK_Members_idTextBox;
        private System.Windows.Forms.TextBox claimPnameTextBox;
        private System.Windows.Forms.TextBox claimDetailsTextBox;
        private System.Windows.Forms.DateTimePicker claimDateDateTimePicker;
        private System.Windows.Forms.DataGridView claimsDataGridView;
        private ITshopDB2DataSetTableAdapters.ReceiptTableAdapter receiptTableAdapter;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.DataGridView receiptDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private ITshopDB2DataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}