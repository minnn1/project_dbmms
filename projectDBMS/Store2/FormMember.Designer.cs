namespace Store2
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
            System.Windows.Forms.Label memberFnameLabel;
            System.Windows.Forms.Label memberLnameLabel;
            System.Windows.Forms.Label memberPhoneLabel;
            System.Windows.Forms.Label memberNohouseLabel;
            System.Windows.Forms.Label memberRoadLabel;
            System.Windows.Forms.Label memberDistrictLabel;
            System.Windows.Forms.Label memberSubdistrictLabel;
            System.Windows.Forms.Label memberProvinceLabel;
            System.Windows.Forms.Label memberPostLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.membersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.membersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberFnameTextBox = new System.Windows.Forms.TextBox();
            this.memberLnameTextBox = new System.Windows.Forms.TextBox();
            this.memberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.memberNohouseTextBox = new System.Windows.Forms.TextBox();
            this.memberRoadTextBox = new System.Windows.Forms.TextBox();
            this.memberDistrictTextBox = new System.Windows.Forms.TextBox();
            this.memberSubdistrictTextBox = new System.Windows.Forms.TextBox();
            this.memberProvinceTextBox = new System.Windows.Forms.TextBox();
            this.memberPostTextBox = new System.Windows.Forms.TextBox();
            memberFnameLabel = new System.Windows.Forms.Label();
            memberLnameLabel = new System.Windows.Forms.Label();
            memberPhoneLabel = new System.Windows.Forms.Label();
            memberNohouseLabel = new System.Windows.Forms.Label();
            memberRoadLabel = new System.Windows.Forms.Label();
            memberDistrictLabel = new System.Windows.Forms.Label();
            memberSubdistrictLabel = new System.Windows.Forms.Label();
            memberProvinceLabel = new System.Windows.Forms.Label();
            memberPostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).BeginInit();
            this.membersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberFnameLabel
            // 
            memberFnameLabel.AutoSize = true;
            memberFnameLabel.Location = new System.Drawing.Point(19, 100);
            memberFnameLabel.Name = "memberFnameLabel";
            memberFnameLabel.Size = new System.Drawing.Size(46, 32);
            memberFnameLabel.TabIndex = 4;
            memberFnameLabel.Text = "ชื่อ";
            // 
            // memberLnameLabel
            // 
            memberLnameLabel.AutoSize = true;
            memberLnameLabel.Location = new System.Drawing.Point(19, 145);
            memberLnameLabel.Name = "memberLnameLabel";
            memberLnameLabel.Size = new System.Drawing.Size(103, 32);
            memberLnameLabel.TabIndex = 6;
            memberLnameLabel.Text = "นามสกุล";
            // 
            // memberPhoneLabel
            // 
            memberPhoneLabel.AutoSize = true;
            memberPhoneLabel.Location = new System.Drawing.Point(19, 190);
            memberPhoneLabel.Name = "memberPhoneLabel";
            memberPhoneLabel.Size = new System.Drawing.Size(159, 32);
            memberPhoneLabel.TabIndex = 8;
            memberPhoneLabel.Text = "เบอร์โทรศัพท์";
            // 
            // memberNohouseLabel
            // 
            memberNohouseLabel.AutoSize = true;
            memberNohouseLabel.Location = new System.Drawing.Point(19, 235);
            memberNohouseLabel.Name = "memberNohouseLabel";
            memberNohouseLabel.Size = new System.Drawing.Size(113, 32);
            memberNohouseLabel.TabIndex = 10;
            memberNohouseLabel.Text = "บ้านเลขที่";
            // 
            // memberRoadLabel
            // 
            memberRoadLabel.AutoSize = true;
            memberRoadLabel.Location = new System.Drawing.Point(19, 280);
            memberRoadLabel.Name = "memberRoadLabel";
            memberRoadLabel.Size = new System.Drawing.Size(63, 32);
            memberRoadLabel.TabIndex = 12;
            memberRoadLabel.Text = "ถนน";
            // 
            // memberDistrictLabel
            // 
            memberDistrictLabel.AutoSize = true;
            memberDistrictLabel.Location = new System.Drawing.Point(19, 325);
            memberDistrictLabel.Name = "memberDistrictLabel";
            memberDistrictLabel.Size = new System.Drawing.Size(72, 32);
            memberDistrictLabel.TabIndex = 14;
            memberDistrictLabel.Text = "เเขวง";
            // 
            // memberSubdistrictLabel
            // 
            memberSubdistrictLabel.AutoSize = true;
            memberSubdistrictLabel.Location = new System.Drawing.Point(19, 370);
            memberSubdistrictLabel.Name = "memberSubdistrictLabel";
            memberSubdistrictLabel.Size = new System.Drawing.Size(54, 32);
            memberSubdistrictLabel.TabIndex = 16;
            memberSubdistrictLabel.Text = "เขต";
            // 
            // memberProvinceLabel
            // 
            memberProvinceLabel.AutoSize = true;
            memberProvinceLabel.Location = new System.Drawing.Point(19, 415);
            memberProvinceLabel.Name = "memberProvinceLabel";
            memberProvinceLabel.Size = new System.Drawing.Size(87, 32);
            memberProvinceLabel.TabIndex = 18;
            memberProvinceLabel.Text = "จังหวัด";
            // 
            // memberPostLabel
            // 
            memberPostLabel.AutoSize = true;
            memberPostLabel.Location = new System.Drawing.Point(19, 460);
            memberPostLabel.Name = "memberPostLabel";
            memberPostLabel.Size = new System.Drawing.Size(158, 32);
            memberPostLabel.TabIndex = 20;
            memberPostLabel.Text = "รหัสไปรษณีย์";
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersBindingNavigator
            // 
            this.membersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membersBindingNavigator.BindingSource = this.membersBindingSource;
            this.membersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membersBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.membersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.membersBindingNavigatorSaveItem});
            this.membersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.membersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membersBindingNavigator.Name = "membersBindingNavigator";
            this.membersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membersBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.membersBindingNavigator.TabIndex = 0;
            this.membersBindingNavigator.Text = "bindingNavigator1";
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
            // membersBindingNavigatorSaveItem
            // 
            this.membersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membersBindingNavigatorSaveItem.Image")));
            this.membersBindingNavigatorSaveItem.Name = "membersBindingNavigatorSaveItem";
            this.membersBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.membersBindingNavigatorSaveItem.Text = "Save Data";
            this.membersBindingNavigatorSaveItem.Click += new System.EventHandler(this.membersBindingNavigatorSaveItem_Click);
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.Location = new System.Drawing.Point(516, 52);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.RowHeadersWidth = 62;
            this.membersDataGridView.RowTemplate.Height = 28;
            this.membersDataGridView.Size = new System.Drawing.Size(729, 392);
            this.membersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_Members_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสสมาชิก";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "memberFname";
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "memberLname";
            this.dataGridViewTextBoxColumn3.HeaderText = "นามสกุล";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "memberPhone";
            this.dataGridViewTextBoxColumn4.HeaderText = "เบอร์โทรศัพท์";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // memberFnameTextBox
            // 
            this.memberFnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberFname", true));
            this.memberFnameTextBox.Location = new System.Drawing.Point(268, 97);
            this.memberFnameTextBox.Name = "memberFnameTextBox";
            this.memberFnameTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberFnameTextBox.TabIndex = 5;
            // 
            // memberLnameTextBox
            // 
            this.memberLnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberLname", true));
            this.memberLnameTextBox.Location = new System.Drawing.Point(268, 142);
            this.memberLnameTextBox.Name = "memberLnameTextBox";
            this.memberLnameTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberLnameTextBox.TabIndex = 7;
            // 
            // memberPhoneTextBox
            // 
            this.memberPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberPhone", true));
            this.memberPhoneTextBox.Location = new System.Drawing.Point(268, 187);
            this.memberPhoneTextBox.Name = "memberPhoneTextBox";
            this.memberPhoneTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberPhoneTextBox.TabIndex = 9;
            // 
            // memberNohouseTextBox
            // 
            this.memberNohouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberNohouse", true));
            this.memberNohouseTextBox.Location = new System.Drawing.Point(268, 232);
            this.memberNohouseTextBox.Name = "memberNohouseTextBox";
            this.memberNohouseTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberNohouseTextBox.TabIndex = 11;
            // 
            // memberRoadTextBox
            // 
            this.memberRoadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberRoad", true));
            this.memberRoadTextBox.Location = new System.Drawing.Point(268, 277);
            this.memberRoadTextBox.Name = "memberRoadTextBox";
            this.memberRoadTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberRoadTextBox.TabIndex = 13;
            // 
            // memberDistrictTextBox
            // 
            this.memberDistrictTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberDistrict", true));
            this.memberDistrictTextBox.Location = new System.Drawing.Point(268, 322);
            this.memberDistrictTextBox.Name = "memberDistrictTextBox";
            this.memberDistrictTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberDistrictTextBox.TabIndex = 15;
            // 
            // memberSubdistrictTextBox
            // 
            this.memberSubdistrictTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberSubdistrict", true));
            this.memberSubdistrictTextBox.Location = new System.Drawing.Point(268, 367);
            this.memberSubdistrictTextBox.Name = "memberSubdistrictTextBox";
            this.memberSubdistrictTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberSubdistrictTextBox.TabIndex = 17;
            // 
            // memberProvinceTextBox
            // 
            this.memberProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberProvince", true));
            this.memberProvinceTextBox.Location = new System.Drawing.Point(268, 412);
            this.memberProvinceTextBox.Name = "memberProvinceTextBox";
            this.memberProvinceTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberProvinceTextBox.TabIndex = 19;
            // 
            // memberPostTextBox
            // 
            this.memberPostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberPost", true));
            this.memberPostTextBox.Location = new System.Drawing.Point(268, 457);
            this.memberPostTextBox.Name = "memberPostTextBox";
            this.memberPostTextBox.Size = new System.Drawing.Size(229, 39);
            this.memberPostTextBox.TabIndex = 21;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(memberFnameLabel);
            this.Controls.Add(this.memberFnameTextBox);
            this.Controls.Add(memberLnameLabel);
            this.Controls.Add(this.memberLnameTextBox);
            this.Controls.Add(memberPhoneLabel);
            this.Controls.Add(this.memberPhoneTextBox);
            this.Controls.Add(memberNohouseLabel);
            this.Controls.Add(this.memberNohouseTextBox);
            this.Controls.Add(memberRoadLabel);
            this.Controls.Add(this.memberRoadTextBox);
            this.Controls.Add(memberDistrictLabel);
            this.Controls.Add(this.memberDistrictTextBox);
            this.Controls.Add(memberSubdistrictLabel);
            this.Controls.Add(this.memberSubdistrictTextBox);
            this.Controls.Add(memberProvinceLabel);
            this.Controls.Add(this.memberProvinceTextBox);
            this.Controls.Add(memberPostLabel);
            this.Controls.Add(this.memberPostTextBox);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.membersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMember";
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).EndInit();
            this.membersBindingNavigator.ResumeLayout(false);
            this.membersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private ITshopDB2DataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton membersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.TextBox memberFnameTextBox;
        private System.Windows.Forms.TextBox memberLnameTextBox;
        private System.Windows.Forms.TextBox memberPhoneTextBox;
        private System.Windows.Forms.TextBox memberNohouseTextBox;
        private System.Windows.Forms.TextBox memberRoadTextBox;
        private System.Windows.Forms.TextBox memberDistrictTextBox;
        private System.Windows.Forms.TextBox memberSubdistrictTextBox;
        private System.Windows.Forms.TextBox memberProvinceTextBox;
        private System.Windows.Forms.TextBox memberPostTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}