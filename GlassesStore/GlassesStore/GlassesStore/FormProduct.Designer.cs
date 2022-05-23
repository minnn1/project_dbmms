namespace GlassesStore
{
    partial class FormProduct
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
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label product_itemsLabel;
            System.Windows.Forms.Label product_descriptionLabel;
            System.Windows.Forms.Label product_priceLabel;
            System.Windows.Forms.Label product_cost_priceLabel;
            System.Windows.Forms.Label product_quantityLabel;
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label category_idLabel1;
            System.Windows.Forms.Label category_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glassesStoreDataSet = new GlassesStore.GlassesStoreDataSet();
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
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.category_idSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.category_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.product_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.product_itemsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.product_descriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.product_priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.product_cost_priceSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.product_quantitySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.category_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.productTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.productTableAdapter();
            this.tableAdapterManager = new GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager();
            this.categoryTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.categoryTableAdapter();
            product_idLabel = new System.Windows.Forms.Label();
            product_itemsLabel = new System.Windows.Forms.Label();
            product_descriptionLabel = new System.Windows.Forms.Label();
            product_priceLabel = new System.Windows.Forms.Label();
            product_cost_priceLabel = new System.Windows.Forms.Label();
            product_quantityLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            category_idLabel1 = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_idSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_nameTextEdit.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_itemsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_descriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_cost_priceSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantitySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_idSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(16, 31);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(106, 29);
            product_idLabel.TabIndex = 0;
            product_idLabel.Text = "รหัสสินค้า";
            // 
            // product_itemsLabel
            // 
            product_itemsLabel.AutoSize = true;
            product_itemsLabel.Location = new System.Drawing.Point(16, 66);
            product_itemsLabel.Name = "product_itemsLabel";
            product_itemsLabel.Size = new System.Drawing.Size(91, 29);
            product_itemsLabel.TabIndex = 2;
            product_itemsLabel.Text = "ชื่อสินค้า";
            // 
            // product_descriptionLabel
            // 
            product_descriptionLabel.AutoSize = true;
            product_descriptionLabel.Location = new System.Drawing.Point(16, 101);
            product_descriptionLabel.Name = "product_descriptionLabel";
            product_descriptionLabel.Size = new System.Drawing.Size(169, 29);
            product_descriptionLabel.TabIndex = 4;
            product_descriptionLabel.Text = "รายละเอียดสินค้า";
            // 
            // product_priceLabel
            // 
            product_priceLabel.AutoSize = true;
            product_priceLabel.Location = new System.Drawing.Point(16, 136);
            product_priceLabel.Name = "product_priceLabel";
            product_priceLabel.Size = new System.Drawing.Size(118, 29);
            product_priceLabel.TabIndex = 6;
            product_priceLabel.Text = "ราคาต้นทุน";
            // 
            // product_cost_priceLabel
            // 
            product_cost_priceLabel.AutoSize = true;
            product_cost_priceLabel.Location = new System.Drawing.Point(16, 171);
            product_cost_priceLabel.Name = "product_cost_priceLabel";
            product_cost_priceLabel.Size = new System.Drawing.Size(94, 29);
            product_cost_priceLabel.TabIndex = 8;
            product_cost_priceLabel.Text = "ราคาขาย";
            // 
            // product_quantityLabel
            // 
            product_quantityLabel.AutoSize = true;
            product_quantityLabel.Location = new System.Drawing.Point(16, 206);
            product_quantityLabel.Name = "product_quantityLabel";
            product_quantityLabel.Size = new System.Drawing.Size(130, 29);
            product_quantityLabel.TabIndex = 10;
            product_quantityLabel.Text = "จำนวนสินค้า";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(16, 241);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(180, 29);
            category_idLabel.TabIndex = 12;
            category_idLabel.Text = "รหัสประเภทสินค้า";
            // 
            // category_idLabel1
            // 
            category_idLabel1.AutoSize = true;
            category_idLabel1.Location = new System.Drawing.Point(18, 32);
            category_idLabel1.Name = "category_idLabel1";
            category_idLabel1.Size = new System.Drawing.Size(180, 29);
            category_idLabel1.TabIndex = 0;
            category_idLabel1.Text = "รหัสประเภทสินค้า";
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Location = new System.Drawing.Point(18, 67);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(165, 29);
            category_nameLabel.TabIndex = 2;
            category_nameLabel.Text = "ชื่อประเภทสินค้า";
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
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
            this.productBindingNavigator.Size = new System.Drawing.Size(1304, 33);
            this.productBindingNavigator.TabIndex = 0;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // glassesStoreDataSet
            // 
            this.glassesStoreDataSet.DataSetName = "GlassesStoreDataSet";
            this.glassesStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.productBindingNavigatorSaveItem.Text = "Save Data";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(670, 3);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 62;
            this.productDataGridView.RowTemplate.Height = 28;
            this.productDataGridView.Size = new System.Drawing.Size(585, 313);
            this.productDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสสินค้า";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_items";
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อสินค้า";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "product_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "รายละเอียดสินค้า";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "product_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "ราคาต้นทุน";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product_cost_price";
            this.dataGridViewTextBoxColumn5.HeaderText = "ราคาขาย";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "product_quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "จำนวนสินค้า";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn7.HeaderText = "รหัสประเภทสินค้า";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.categoryDataGridView);
            this.flowLayoutPanel1.Controls.Add(this.productDataGridView);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1304, 616);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersWidth = 62;
            this.categoryDataGridView.RowTemplate.Height = 28;
            this.categoryDataGridView.Size = new System.Drawing.Size(661, 313);
            this.categoryDataGridView.TabIndex = 1;
            this.categoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "รหัสประเภทสินค้า";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "category_name";
            this.dataGridViewTextBoxColumn9.HeaderText = "ประเภทสินค้า";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "category";
            this.categoryBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(category_idLabel1);
            this.groupBox1.Controls.Add(this.category_idSpinEdit1);
            this.groupBox1.Controls.Add(category_nameLabel);
            this.groupBox1.Controls.Add(this.category_nameTextEdit);
            this.groupBox1.Location = new System.Drawing.Point(3, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "รายการประเภทสินค้า";
            // 
            // category_idSpinEdit1
            // 
            this.category_idSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "category_id", true));
            this.category_idSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.category_idSpinEdit1.Location = new System.Drawing.Point(201, 37);
            this.category_idSpinEdit1.Name = "category_idSpinEdit1";
            this.category_idSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.category_idSpinEdit1.Size = new System.Drawing.Size(150, 28);
            this.category_idSpinEdit1.TabIndex = 1;
            // 
            // category_nameTextEdit
            // 
            this.category_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.categoryBindingSource, "category_name", true));
            this.category_nameTextEdit.Location = new System.Drawing.Point(201, 72);
            this.category_nameTextEdit.Name = "category_nameTextEdit";
            this.category_nameTextEdit.Size = new System.Drawing.Size(150, 26);
            this.category_nameTextEdit.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(product_idLabel);
            this.groupBox2.Controls.Add(this.product_idSpinEdit);
            this.groupBox2.Controls.Add(product_itemsLabel);
            this.groupBox2.Controls.Add(this.product_itemsTextEdit);
            this.groupBox2.Controls.Add(product_descriptionLabel);
            this.groupBox2.Controls.Add(this.product_descriptionTextEdit);
            this.groupBox2.Controls.Add(product_priceLabel);
            this.groupBox2.Controls.Add(this.product_priceSpinEdit);
            this.groupBox2.Controls.Add(product_cost_priceLabel);
            this.groupBox2.Controls.Add(this.product_cost_priceSpinEdit);
            this.groupBox2.Controls.Add(product_quantityLabel);
            this.groupBox2.Controls.Add(this.product_quantitySpinEdit);
            this.groupBox2.Controls.Add(category_idLabel);
            this.groupBox2.Controls.Add(this.category_idSpinEdit);
            this.groupBox2.Location = new System.Drawing.Point(670, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 282);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "รายการสินค้า";
            // 
            // product_idSpinEdit
            // 
            this.product_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_id", true));
            this.product_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product_idSpinEdit.Location = new System.Drawing.Point(194, 28);
            this.product_idSpinEdit.Name = "product_idSpinEdit";
            this.product_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.product_idSpinEdit.Size = new System.Drawing.Size(178, 28);
            this.product_idSpinEdit.TabIndex = 1;
            // 
            // product_itemsTextEdit
            // 
            this.product_itemsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_items", true));
            this.product_itemsTextEdit.Location = new System.Drawing.Point(194, 63);
            this.product_itemsTextEdit.Name = "product_itemsTextEdit";
            this.product_itemsTextEdit.Size = new System.Drawing.Size(178, 26);
            this.product_itemsTextEdit.TabIndex = 3;
            // 
            // product_descriptionTextEdit
            // 
            this.product_descriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_description", true));
            this.product_descriptionTextEdit.Location = new System.Drawing.Point(194, 98);
            this.product_descriptionTextEdit.Name = "product_descriptionTextEdit";
            this.product_descriptionTextEdit.Size = new System.Drawing.Size(178, 26);
            this.product_descriptionTextEdit.TabIndex = 5;
            // 
            // product_priceSpinEdit
            // 
            this.product_priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_price", true));
            this.product_priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product_priceSpinEdit.Location = new System.Drawing.Point(194, 133);
            this.product_priceSpinEdit.Name = "product_priceSpinEdit";
            this.product_priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.product_priceSpinEdit.Size = new System.Drawing.Size(178, 28);
            this.product_priceSpinEdit.TabIndex = 7;
            // 
            // product_cost_priceSpinEdit
            // 
            this.product_cost_priceSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_cost_price", true));
            this.product_cost_priceSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product_cost_priceSpinEdit.Location = new System.Drawing.Point(194, 168);
            this.product_cost_priceSpinEdit.Name = "product_cost_priceSpinEdit";
            this.product_cost_priceSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.product_cost_priceSpinEdit.Size = new System.Drawing.Size(178, 28);
            this.product_cost_priceSpinEdit.TabIndex = 9;
            // 
            // product_quantitySpinEdit
            // 
            this.product_quantitySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "product_quantity", true));
            this.product_quantitySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.product_quantitySpinEdit.Location = new System.Drawing.Point(194, 203);
            this.product_quantitySpinEdit.Name = "product_quantitySpinEdit";
            this.product_quantitySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.product_quantitySpinEdit.Size = new System.Drawing.Size(178, 28);
            this.product_quantitySpinEdit.TabIndex = 11;
            // 
            // category_idSpinEdit
            // 
            this.category_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "category_id", true));
            this.category_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.category_idSpinEdit.Location = new System.Drawing.Point(194, 238);
            this.category_idSpinEdit.Name = "category_idSpinEdit";
            this.category_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.category_idSpinEdit.Size = new System.Drawing.Size(178, 28);
            this.category_idSpinEdit.TabIndex = 13;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = this.categoryTableAdapter;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = null;
            this.tableAdapterManager.orderdetailTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 649);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.productBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProduct";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการสินค้า";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_idSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_nameTextEdit.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_itemsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_descriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_cost_priceSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantitySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category_idSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlassesStoreDataSet glassesStoreDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private GlassesStoreDataSetTableAdapters.productTableAdapter productTableAdapter;
        private GlassesStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private GlassesStoreDataSetTableAdapters.categoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SpinEdit product_idSpinEdit;
        private DevExpress.XtraEditors.TextEdit product_itemsTextEdit;
        private DevExpress.XtraEditors.TextEdit product_descriptionTextEdit;
        private DevExpress.XtraEditors.SpinEdit product_priceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit product_cost_priceSpinEdit;
        private DevExpress.XtraEditors.SpinEdit product_quantitySpinEdit;
        private DevExpress.XtraEditors.SpinEdit category_idSpinEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private DevExpress.XtraEditors.SpinEdit category_idSpinEdit1;
        private DevExpress.XtraEditors.TextEdit category_nameTextEdit;
    }
}

