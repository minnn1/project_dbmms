namespace GlassesStore
{
    partial class FormMember
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
            System.Windows.Forms.Label member_adressLabel;
            System.Windows.Forms.Label member_fnameLabel;
            System.Windows.Forms.Label member_lnameLabel;
            System.Windows.Forms.Label member_contactLabel;
            System.Windows.Forms.Label member_idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.memberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.member_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.member_adressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_fnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_lnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_contactTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.memberDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager();
            member_adressLabel = new System.Windows.Forms.Label();
            member_fnameLabel = new System.Windows.Forms.Label();
            member_lnameLabel = new System.Windows.Forms.Label();
            member_contactLabel = new System.Windows.Forms.Label();
            member_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_fnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_lnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_contactTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // member_adressLabel
            // 
            member_adressLabel.AutoSize = true;
            member_adressLabel.Location = new System.Drawing.Point(34, 150);
            member_adressLabel.Name = "member_adressLabel";
            member_adressLabel.Size = new System.Drawing.Size(52, 29);
            member_adressLabel.TabIndex = 2;
            member_adressLabel.Text = "ที่อยู่";
            // 
            // member_fnameLabel
            // 
            member_fnameLabel.AutoSize = true;
            member_fnameLabel.Location = new System.Drawing.Point(34, 81);
            member_fnameLabel.Name = "member_fnameLabel";
            member_fnameLabel.Size = new System.Drawing.Size(39, 29);
            member_fnameLabel.TabIndex = 6;
            member_fnameLabel.Text = "ชื่อ";
            // 
            // member_lnameLabel
            // 
            member_lnameLabel.AutoSize = true;
            member_lnameLabel.Location = new System.Drawing.Point(34, 116);
            member_lnameLabel.Name = "member_lnameLabel";
            member_lnameLabel.Size = new System.Drawing.Size(91, 29);
            member_lnameLabel.TabIndex = 8;
            member_lnameLabel.Text = "นามสกุล";
            // 
            // member_contactLabel
            // 
            member_contactLabel.AutoSize = true;
            member_contactLabel.Location = new System.Drawing.Point(34, 187);
            member_contactLabel.Name = "member_contactLabel";
            member_contactLabel.Size = new System.Drawing.Size(114, 29);
            member_contactLabel.TabIndex = 10;
            member_contactLabel.Text = "เบอร์ติดต่อ";
            // 
            // member_idLabel
            // 
            member_idLabel.AutoSize = true;
            member_idLabel.Location = new System.Drawing.Point(9, 47);
            member_idLabel.Name = "member_idLabel";
            member_idLabel.Size = new System.Drawing.Size(117, 29);
            member_idLabel.TabIndex = 11;
            member_idLabel.Text = "รหัสสมาชิก";
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.memberBindingNavigatorSaveItem});
            this.memberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memberBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memberBindingNavigator.Name = "memberBindingNavigator";
            this.memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memberBindingNavigator.Size = new System.Drawing.Size(1244, 33);
            this.memberBindingNavigator.TabIndex = 0;
            this.memberBindingNavigator.Text = "bindingNavigator1";
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
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.glassesStoreDataSet;
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
            // memberBindingNavigatorSaveItem
            // 
            this.memberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memberBindingNavigatorSaveItem.Image")));
            this.memberBindingNavigatorSaveItem.Name = "memberBindingNavigatorSaveItem";
            this.memberBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.memberBindingNavigatorSaveItem.Text = "Save Data";
            this.memberBindingNavigatorSaveItem.Click += new System.EventHandler(this.memberBindingNavigatorSaveItem_Click);
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.AutoGenerateColumns = false;
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.memberDataGridView.DataSource = this.memberBindingSource;
            this.memberDataGridView.Location = new System.Drawing.Point(337, 219);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.RowHeadersWidth = 62;
            this.memberDataGridView.RowTemplate.Height = 28;
            this.memberDataGridView.Size = new System.Drawing.Size(210, 232);
            this.memberDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "member_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "member_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "member_adress";
            this.dataGridViewTextBoxColumn3.HeaderText = "member_adress";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "member_contact";
            this.dataGridViewTextBoxColumn4.HeaderText = "member_contact";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "status";
            this.dataGridViewTextBoxColumn5.HeaderText = "status";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memberDataGridView1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 619);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(member_idLabel);
            this.groupBox1.Controls.Add(this.member_idSpinEdit);
            this.groupBox1.Controls.Add(member_adressLabel);
            this.groupBox1.Controls.Add(this.member_adressTextEdit);
            this.groupBox1.Controls.Add(member_fnameLabel);
            this.groupBox1.Controls.Add(this.member_fnameTextEdit);
            this.groupBox1.Controls.Add(member_lnameLabel);
            this.groupBox1.Controls.Add(this.member_lnameTextEdit);
            this.groupBox1.Controls.Add(member_contactLabel);
            this.groupBox1.Controls.Add(this.member_contactTextEdit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "สมัครสมาชิก";
            // 
            // member_idSpinEdit
            // 
            this.member_idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_id", true));
            this.member_idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.member_idSpinEdit.Location = new System.Drawing.Point(150, 44);
            this.member_idSpinEdit.Name = "member_idSpinEdit";
            this.member_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.member_idSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.member_idSpinEdit.TabIndex = 12;
            // 
            // member_adressTextEdit
            // 
            this.member_adressTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_adress", true));
            this.member_adressTextEdit.Location = new System.Drawing.Point(150, 147);
            this.member_adressTextEdit.Name = "member_adressTextEdit";
            this.member_adressTextEdit.Size = new System.Drawing.Size(231, 26);
            this.member_adressTextEdit.TabIndex = 3;
            // 
            // member_fnameTextEdit
            // 
            this.member_fnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_fname", true));
            this.member_fnameTextEdit.Location = new System.Drawing.Point(150, 78);
            this.member_fnameTextEdit.Name = "member_fnameTextEdit";
            this.member_fnameTextEdit.Size = new System.Drawing.Size(231, 26);
            this.member_fnameTextEdit.TabIndex = 7;
            // 
            // member_lnameTextEdit
            // 
            this.member_lnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_lname", true));
            this.member_lnameTextEdit.Location = new System.Drawing.Point(150, 113);
            this.member_lnameTextEdit.Name = "member_lnameTextEdit";
            this.member_lnameTextEdit.Size = new System.Drawing.Size(231, 26);
            this.member_lnameTextEdit.TabIndex = 9;
            // 
            // member_contactTextEdit
            // 
            this.member_contactTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_contact", true));
            this.member_contactTextEdit.Location = new System.Drawing.Point(150, 184);
            this.member_contactTextEdit.Name = "member_contactTextEdit";
            this.member_contactTextEdit.Size = new System.Drawing.Size(231, 26);
            this.member_contactTextEdit.TabIndex = 11;
            // 
            // memberDataGridView1
            // 
            this.memberDataGridView1.AutoGenerateColumns = false;
            this.memberDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.memberDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.member_fname,
            this.member_lname,
            this.dataGridViewTextBoxColumn8,
            this.member_contact});
            this.memberDataGridView1.DataSource = this.memberBindingSource;
            this.memberDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberDataGridView1.Location = new System.Drawing.Point(625, 3);
            this.memberDataGridView1.Name = "memberDataGridView1";
            this.memberDataGridView1.ReadOnly = true;
            this.memberDataGridView1.RowHeadersWidth = 62;
            this.memberDataGridView1.RowTemplate.Height = 28;
            this.memberDataGridView1.Size = new System.Drawing.Size(616, 303);
            this.memberDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "member_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "รหัสสมาชิก";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // member_fname
            // 
            this.member_fname.DataPropertyName = "member_fname";
            this.member_fname.HeaderText = "ชื่อสมาชิก";
            this.member_fname.MinimumWidth = 8;
            this.member_fname.Name = "member_fname";
            this.member_fname.ReadOnly = true;
            // 
            // member_lname
            // 
            this.member_lname.DataPropertyName = "member_lname";
            this.member_lname.HeaderText = "นามสกุล";
            this.member_lname.MinimumWidth = 8;
            this.member_lname.Name = "member_lname";
            this.member_lname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "member_adress";
            this.dataGridViewTextBoxColumn8.HeaderText = "ที่อยู่";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // member_contact
            // 
            this.member_contact.DataPropertyName = "member_contact";
            this.member_contact.HeaderText = "เบอร์ติดต่อ";
            this.member_contact.MinimumWidth = 8;
            this.member_contact.Name = "member_contact";
            this.member_contact.ReadOnly = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.memberTableAdapter = this.memberTableAdapter;
            this.tableAdapterManager.orderdetailTableAdapter = null;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.paymentTableAdapter = null;
            this.tableAdapterManager.productTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.memberDataGridView);
            this.Controls.Add(this.memberBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_fnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_lnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_contactTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GlassesStoreDataSet glassesStoreDataSet;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private GlassesStoreDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private GlassesStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memberBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton memberBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView memberDataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit member_adressTextEdit;
        private DevExpress.XtraEditors.TextEdit member_fnameTextEdit;
        private DevExpress.XtraEditors.TextEdit member_lnameTextEdit;
        private DevExpress.XtraEditors.TextEdit member_contactTextEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_contact;
        private DevExpress.XtraEditors.SpinEdit member_idSpinEdit;
    }
}