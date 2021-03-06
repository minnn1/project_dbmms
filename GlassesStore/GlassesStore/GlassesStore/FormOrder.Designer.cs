namespace GlassesStore
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
            System.Windows.Forms.Label รหัสOrder;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label member_idLabel;
            System.Windows.Forms.Label payment_idLabel;
            System.Windows.Forms.Label order_quantityLabel;
            System.Windows.Forms.Label order_totalpriceLabel;
            System.Windows.Forms.Label orderline_dateLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label order_idLabel1;
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            System.Windows.Forms.Label orderline_idLabel1;
            this.glassesStoreDataSet = new GlassesStore.GlassesStoreDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.orderTableAdapter();
            this.tableAdapterManager = new GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.employeeTableAdapter();
            this.memberTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.memberTableAdapter();
            this.orderdetailTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.orderdetailTableAdapter();
            this.productTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.productTableAdapter();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.payment_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.member_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.order_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.order_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.order_totalpriceSpinEdit = new System.Windows.Forms.TextBox();
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_priceSpinEdit = new System.Windows.Forms.TextBox();
            this.order_quantitySpinEdit = new System.Windows.Forms.TextBox();
            this.orderline_dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.product_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.order_idSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.employee_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.พนักงานขาย = new System.Windows.Forms.GroupBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.orderline_idTextBox = new System.Windows.Forms.TextBox();
            รหัสOrder = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            member_idLabel = new System.Windows.Forms.Label();
            payment_idLabel = new System.Windows.Forms.Label();
            order_quantityLabel = new System.Windows.Forms.Label();
            order_totalpriceLabel = new System.Windows.Forms.Label();
            orderline_dateLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            order_idLabel1 = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            orderline_idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_dateDateEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderline_dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderline_dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_idSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.พนักงานขาย.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // รหัสOrder
            // 
            รหัสOrder.AutoSize = true;
            รหัสOrder.Location = new System.Drawing.Point(65, 31);
            รหัสOrder.Name = "รหัสOrder";
            รหัสOrder.Size = new System.Drawing.Size(104, 29);
            รหัสOrder.TabIndex = 1;
            รหัสOrder.Text = "รายการที่:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(65, 66);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(142, 29);
            order_dateLabel.TabIndex = 3;
            order_dateLabel.Text = "วันทำรายการ:";
            // 
            // member_idLabel
            // 
            member_idLabel.AutoSize = true;
            member_idLabel.Location = new System.Drawing.Point(65, 101);
            member_idLabel.Name = "member_idLabel";
            member_idLabel.Size = new System.Drawing.Size(123, 29);
            member_idLabel.TabIndex = 5;
            member_idLabel.Text = "รหัสสมาชิก:";
            // 
            // payment_idLabel
            // 
            payment_idLabel.AutoSize = true;
            payment_idLabel.Location = new System.Drawing.Point(65, 136);
            payment_idLabel.Name = "payment_idLabel";
            payment_idLabel.Size = new System.Drawing.Size(164, 29);
            payment_idLabel.TabIndex = 7;
            payment_idLabel.Text = "รหัสการจ่ายเงิน:";
            // 
            // order_quantityLabel
            // 
            order_quantityLabel.AutoSize = true;
            order_quantityLabel.Location = new System.Drawing.Point(24, 66);
            order_quantityLabel.Name = "order_quantityLabel";
            order_quantityLabel.Size = new System.Drawing.Size(136, 29);
            order_quantityLabel.TabIndex = 2;
            order_quantityLabel.Text = "จำนวนสินค้า:";
            // 
            // order_totalpriceLabel
            // 
            order_totalpriceLabel.AutoSize = true;
            order_totalpriceLabel.Location = new System.Drawing.Point(24, 132);
            order_totalpriceLabel.Name = "order_totalpriceLabel";
            order_totalpriceLabel.Size = new System.Drawing.Size(104, 29);
            order_totalpriceLabel.TabIndex = 4;
            order_totalpriceLabel.Text = "ราคารวม:";
            // 
            // orderline_dateLabel
            // 
            orderline_dateLabel.AutoSize = true;
            orderline_dateLabel.Location = new System.Drawing.Point(24, 167);
            orderline_dateLabel.Name = "orderline_dateLabel";
            orderline_dateLabel.Size = new System.Drawing.Size(61, 29);
            orderline_dateLabel.TabIndex = 6;
            orderline_dateLabel.Text = "วันที่:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(24, 202);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(106, 29);
            product_idLabel.TabIndex = 8;
            product_idLabel.Text = "รหัสสินค้า";
            // 
            // order_idLabel1
            // 
            order_idLabel1.AutoSize = true;
            order_idLabel1.Location = new System.Drawing.Point(24, 237);
            order_idLabel1.Name = "order_idLabel1";
            order_idLabel1.Size = new System.Drawing.Size(98, 29);
            order_idLabel1.TabIndex = 10;
            order_idLabel1.Text = "รายการที่";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(24, 272);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(135, 29);
            employee_idLabel.TabIndex = 12;
            employee_idLabel.Text = "รหัสพนักงาน";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 29);
            label1.TabIndex = 16;
            label1.Text = "ราคาสินค้า:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(382, 167);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 29);
            label2.TabIndex = 19;
            label2.Text = "เงินสดที่รับ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(381, 236);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(162, 29);
            label3.TabIndex = 21;
            label3.Text = "จำนวนเงินทอน:";
            // 
            // glassesStoreDataSet
            // 
            this.glassesStoreDataSet.DataSetName = "GlassesStoreDataSet";
            this.glassesStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.memberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.orderdetailTableAdapter = this.orderdetailTableAdapter;
            this.tableAdapterManager.orderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // orderdetailTableAdapter
            // 
            this.orderdetailTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(1327, 33);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
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
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonNew);
            this.groupBox1.Controls.Add(this.payment_idSpinEdit);
            this.groupBox1.Controls.Add(this.member_idSpinEdit);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(รหัสOrder);
            this.groupBox1.Controls.Add(this.order_idSpinEdit);
            this.groupBox1.Controls.Add(payment_idLabel);
            this.groupBox1.Controls.Add(order_dateLabel);
            this.groupBox1.Controls.Add(this.order_dateDateEdit);
            this.groupBox1.Controls.Add(member_idLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 321);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ชำระสินค้า";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "ดูรายการสั่งซื้อ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(353, 259);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(211, 37);
            this.buttonNew.TabIndex = 18;
            this.buttonNew.Text = "เพิ่มสินค้าที่ซื้อใหม่";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // payment_idSpinEdit
            // 
            this.payment_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "payment_id", true));
            this.payment_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.payment_idSpinEdit.Location = new System.Drawing.Point(353, 135);
            this.payment_idSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.payment_idSpinEdit.Name = "payment_idSpinEdit";
            this.payment_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.payment_idSpinEdit.Size = new System.Drawing.Size(225, 28);
            this.payment_idSpinEdit.TabIndex = 17;
            // 
            // member_idSpinEdit
            // 
            this.member_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "member_id", true));
            this.member_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.member_idSpinEdit.Location = new System.Drawing.Point(353, 97);
            this.member_idSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.member_idSpinEdit.Name = "member_idSpinEdit";
            this.member_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.member_idSpinEdit.Size = new System.Drawing.Size(225, 28);
            this.member_idSpinEdit.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(29, 268);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(114, 33);
            this.checkBox3.TabIndex = 15;
            this.checkBox3.Text = "โอนเงิน";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(29, 233);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 33);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "บัตรเครดิต";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(29, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 33);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "เงินสด";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(353, 173);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 37);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "ชำระสินค้า";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(353, 216);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(211, 37);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "เเก้ไขรายการสินค้า";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // order_idSpinEdit
            // 
            this.order_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "order_id", true));
            this.order_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.order_idSpinEdit.Location = new System.Drawing.Point(353, 27);
            this.order_idSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.order_idSpinEdit.Name = "order_idSpinEdit";
            this.order_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.order_idSpinEdit.Size = new System.Drawing.Size(225, 28);
            this.order_idSpinEdit.TabIndex = 2;
            this.order_idSpinEdit.EditValueChanged += new System.EventHandler(this.order_idSpinEdit_EditValueChanged);
            // 
            // order_dateDateEdit
            // 
            this.order_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderBindingSource, "order_date", true));
            this.order_dateDateEdit.EditValue = null;
            this.order_dateDateEdit.Location = new System.Drawing.Point(353, 63);
            this.order_dateDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.order_dateDateEdit.Name = "order_dateDateEdit";
            this.order_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.order_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.order_dateDateEdit.Size = new System.Drawing.Size(225, 26);
            this.order_dateDateEdit.TabIndex = 4;
            this.order_dateDateEdit.EditValueChanged += new System.EventHandler(this.order_dateDateEdit_EditValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(orderline_idLabel1);
            this.groupBox2.Controls.Add(this.orderline_idTextBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.order_totalpriceSpinEdit);
            this.groupBox2.Controls.Add(this.order_priceSpinEdit);
            this.groupBox2.Controls.Add(this.order_quantitySpinEdit);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(order_quantityLabel);
            this.groupBox2.Controls.Add(order_totalpriceLabel);
            this.groupBox2.Controls.Add(orderline_dateLabel);
            this.groupBox2.Controls.Add(this.orderline_dateDateEdit);
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Controls.Add(this.product_idSpinEdit);
            this.groupBox2.Controls.Add(order_idLabel1);
            this.groupBox2.Controls.Add(this.order_idSpinEdit1);
            this.groupBox2.Controls.Add(employee_idLabel);
            this.groupBox2.Controls.Add(this.employee_idSpinEdit);
            this.groupBox2.Location = new System.Drawing.Point(625, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 330);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายละเอียดชำระสินค้า";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(381, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 35);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 35);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // order_totalpriceSpinEdit
            // 
            this.order_totalpriceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderdetailBindingSource, "order_totalprice", true));
            this.order_totalpriceSpinEdit.Location = new System.Drawing.Point(213, 142);
            this.order_totalpriceSpinEdit.Name = "order_totalpriceSpinEdit";
            this.order_totalpriceSpinEdit.Size = new System.Drawing.Size(162, 35);
            this.order_totalpriceSpinEdit.TabIndex = 18;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "orderdetail$orderorderdetail";
            this.orderdetailBindingSource.DataSource = this.orderBindingSource;
            // 
            // order_priceSpinEdit
            // 
            this.order_priceSpinEdit.Location = new System.Drawing.Point(213, 104);
            this.order_priceSpinEdit.Name = "order_priceSpinEdit";
            this.order_priceSpinEdit.Size = new System.Drawing.Size(162, 35);
            this.order_priceSpinEdit.TabIndex = 17;
            // 
            // order_quantitySpinEdit
            // 
            this.order_quantitySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderdetailBindingSource, "order_quantity", true));
            this.order_quantitySpinEdit.Location = new System.Drawing.Point(213, 66);
            this.order_quantitySpinEdit.Name = "order_quantitySpinEdit";
            this.order_quantitySpinEdit.Size = new System.Drawing.Size(162, 35);
            this.order_quantitySpinEdit.TabIndex = 0;
            this.order_quantitySpinEdit.TextChanged += new System.EventHandler(this.order_quantitySpinEdit_EditValueChanged);
            // 
            // orderline_dateDateEdit
            // 
            this.orderline_dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderdetailBindingSource, "orderline_date", true));
            this.orderline_dateDateEdit.EditValue = null;
            this.orderline_dateDateEdit.Location = new System.Drawing.Point(213, 178);
            this.orderline_dateDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.orderline_dateDateEdit.Name = "orderline_dateDateEdit";
            this.orderline_dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderline_dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.orderline_dateDateEdit.Size = new System.Drawing.Size(162, 26);
            this.orderline_dateDateEdit.TabIndex = 7;
            // 
            // product_idSpinEdit
            // 
            this.product_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderdetailBindingSource, "product_id", true));
            this.product_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product_idSpinEdit.Location = new System.Drawing.Point(213, 212);
            this.product_idSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.product_idSpinEdit.Name = "product_idSpinEdit";
            this.product_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.product_idSpinEdit.Size = new System.Drawing.Size(162, 28);
            this.product_idSpinEdit.TabIndex = 9;
            // 
            // order_idSpinEdit1
            // 
            this.order_idSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderdetailBindingSource, "order_id", true));
            this.order_idSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.order_idSpinEdit1.Location = new System.Drawing.Point(213, 247);
            this.order_idSpinEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.order_idSpinEdit1.Name = "order_idSpinEdit1";
            this.order_idSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.order_idSpinEdit1.Size = new System.Drawing.Size(162, 28);
            this.order_idSpinEdit1.TabIndex = 11;
            // 
            // employee_idSpinEdit
            // 
            this.employee_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.orderdetailBindingSource, "employee_id", true));
            this.employee_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.employee_idSpinEdit.Location = new System.Drawing.Point(213, 282);
            this.employee_idSpinEdit.Margin = new System.Windows.Forms.Padding(4);
            this.employee_idSpinEdit.Name = "employee_idSpinEdit";
            this.employee_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.employee_idSpinEdit.Size = new System.Drawing.Size(162, 28);
            this.employee_idSpinEdit.TabIndex = 13;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.member_contact});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.memberDataGridView.Location = new System.Drawing.Point(3, 31);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.ReadOnly = true;
            this.memberDataGridView.RowHeadersWidth = 62;
            this.memberDataGridView.RowTemplate.Height = 28;
            this.memberDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataGridView.Size = new System.Drawing.Size(300, 239);
            this.memberDataGridView.TabIndex = 12;
            this.memberDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสสมาชิก";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "member_fname";
            this.dataGridViewTextBoxColumn4.HeaderText = "ชื่อ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // member_contact
            // 
            this.member_contact.DataPropertyName = "member_contact";
            this.member_contact.HeaderText = "เบอร์ติดต่อ";
            this.member_contact.MinimumWidth = 8;
            this.member_contact.Name = "member_contact";
            this.member_contact.ReadOnly = true;
            // 
            // พนักงานขาย
            // 
            this.พนักงานขาย.Controls.Add(this.employeeDataGridView);
            this.พนักงานขาย.Controls.Add(this.memberDataGridView);
            this.พนักงานขาย.Location = new System.Drawing.Point(12, 36);
            this.พนักงานขาย.Name = "พนักงานขาย";
            this.พนักงานขาย.Size = new System.Drawing.Size(610, 273);
            this.พนักงานขาย.TabIndex = 13;
            this.พนักงานขาย.TabStop = false;
            this.พนักงานขาย.Text = "พนักงานขาย";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.employeeDataGridView.Location = new System.Drawing.Point(307, 31);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.ReadOnly = true;
            this.employeeDataGridView.RowHeadersWidth = 62;
            this.employeeDataGridView.RowTemplate.Height = 28;
            this.employeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeeDataGridView.Size = new System.Drawing.Size(300, 239);
            this.employeeDataGridView.TabIndex = 12;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "รหัสพนักงาน";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "employee_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "ชื่อพนักงาน";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bindingNavigator1);
            this.groupBox3.Controls.Add(this.productDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(625, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 276);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "รายการสินค้า";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Location = new System.Drawing.Point(3, 86);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(614, 187);
            this.productDataGridView.TabIndex = 0;
            this.productDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellClick);
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.orderdetailBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 31);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(614, 33);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Leelawadee UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Save Data";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // orderline_idLabel1
            // 
            orderline_idLabel1.AutoSize = true;
            orderline_idLabel1.Location = new System.Drawing.Point(23, 34);
            orderline_idLabel1.Name = "orderline_idLabel1";
            orderline_idLabel1.Size = new System.Drawing.Size(136, 29);
            orderline_idLabel1.TabIndex = 22;
            orderline_idLabel1.Text = "รายการสินค้า";
            // 
            // orderline_idTextBox
            // 
            this.orderline_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderdetailBindingSource, "orderline_id", true));
            this.orderline_idTextBox.Location = new System.Drawing.Point(213, 24);
            this.orderline_idTextBox.Name = "orderline_idTextBox";
            this.orderline_idTextBox.Size = new System.Drawing.Size(162, 35);
            this.orderline_idTextBox.TabIndex = 23;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.พนักงานขาย);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_dateDateEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderline_dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderline_dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_idSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.พนักงานขาย.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlassesStoreDataSet glassesStoreDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private GlassesStoreDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private GlassesStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private GlassesStoreDataSetTableAdapters.orderdetailTableAdapter orderdetailTableAdapter;
        private DevExpress.XtraEditors.SpinEdit order_idSpinEdit;
        private DevExpress.XtraEditors.DateEdit order_dateDateEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private DevExpress.XtraEditors.DateEdit orderline_dateDateEdit;
        private DevExpress.XtraEditors.SpinEdit product_idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit order_idSpinEdit1;
        private DevExpress.XtraEditors.SpinEdit employee_idSpinEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private GlassesStoreDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.GroupBox พนักงานขาย;
        private GlassesStoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.TextBox order_totalpriceSpinEdit;
        private System.Windows.Forms.TextBox order_priceSpinEdit;
        private System.Windows.Forms.TextBox order_quantitySpinEdit;
        private GlassesStoreDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private DevExpress.XtraEditors.SpinEdit payment_idSpinEdit;
        private DevExpress.XtraEditors.SpinEdit member_idSpinEdit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox orderline_idTextBox;
    }
}