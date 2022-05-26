namespace GlassesStore
{
    partial class FormaddMember
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
            System.Windows.Forms.Label member_contactLabel;
            System.Windows.Forms.Label member_lnameLabel;
            System.Windows.Forms.Label member_fnameLabel;
            System.Windows.Forms.Label member_adressLabel;
            System.Windows.Forms.Label member_idLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaddMember));
            this.memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glassesStoreDataSet = new GlassesStore.GlassesStoreDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.memberBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memberTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.memberTableAdapter();
            this.tableAdapterManager = new GlassesStore.GlassesStoreDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.member_idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.member_fnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_lnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_contactTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_adress2TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.member_adress1TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            member_contactLabel = new System.Windows.Forms.Label();
            member_lnameLabel = new System.Windows.Forms.Label();
            member_fnameLabel = new System.Windows.Forms.Label();
            member_adressLabel = new System.Windows.Forms.Label();
            member_idLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).BeginInit();
            this.memberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_fnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_lnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_contactTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adress2TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adress1TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // member_contactLabel
            // 
            member_contactLabel.AutoSize = true;
            member_contactLabel.CausesValidation = false;
            member_contactLabel.Location = new System.Drawing.Point(27, 251);
            member_contactLabel.Name = "member_contactLabel";
            member_contactLabel.Size = new System.Drawing.Size(130, 32);
            member_contactLabel.TabIndex = 10;
            member_contactLabel.Text = "เบอร์ติดต่อ";
            // 
            // member_lnameLabel
            // 
            member_lnameLabel.AutoSize = true;
            member_lnameLabel.CausesValidation = false;
            member_lnameLabel.Location = new System.Drawing.Point(39, 128);
            member_lnameLabel.Name = "member_lnameLabel";
            member_lnameLabel.Size = new System.Drawing.Size(103, 32);
            member_lnameLabel.TabIndex = 8;
            member_lnameLabel.Text = "นามสกุล";
            // 
            // member_fnameLabel
            // 
            member_fnameLabel.AutoSize = true;
            member_fnameLabel.CausesValidation = false;
            member_fnameLabel.Location = new System.Drawing.Point(39, 89);
            member_fnameLabel.Name = "member_fnameLabel";
            member_fnameLabel.Size = new System.Drawing.Size(46, 32);
            member_fnameLabel.TabIndex = 6;
            member_fnameLabel.Text = "ชื่อ";
            // 
            // member_adressLabel
            // 
            member_adressLabel.AutoSize = true;
            member_adressLabel.CausesValidation = false;
            member_adressLabel.Location = new System.Drawing.Point(39, 166);
            member_adressLabel.Name = "member_adressLabel";
            member_adressLabel.Size = new System.Drawing.Size(59, 32);
            member_adressLabel.TabIndex = 2;
            member_adressLabel.Text = "ที่อยู่";
            // 
            // member_idLabel
            // 
            member_idLabel.AutoSize = true;
            member_idLabel.CausesValidation = false;
            member_idLabel.Location = new System.Drawing.Point(10, 52);
            member_idLabel.Name = "member_idLabel";
            member_idLabel.Size = new System.Drawing.Size(135, 32);
            member_idLabel.TabIndex = 11;
            member_idLabel.Text = "รหัสสมาชิก";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(35, 320);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(98, 32);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "status:";
            statusLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new System.Drawing.Point(39, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 32);
            label1.TabIndex = 27;
            label1.Text = "ที่อยู่จัดส่ง";
            // 
            // memberBindingNavigator
            // 
            this.memberBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memberBindingNavigator.BindingSource = this.memberBindingSource;
            this.memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memberBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memberBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
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
            this.memberBindingNavigator.Size = new System.Drawing.Size(431, 33);
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
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Visible = false;
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Visible = false;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(57, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Visible = false;
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
            this.bindingNavigatorMoveNextItem.Visible = false;
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Visible = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.member_idSpinEdit);
            this.groupBox1.Controls.Add(this.member_fnameTextEdit);
            this.groupBox1.Controls.Add(this.member_lnameTextEdit);
            this.groupBox1.Controls.Add(this.member_contactTextEdit);
            this.groupBox1.Controls.Add(this.member_adress2TextEdit);
            this.groupBox1.Controls.Add(this.member_adress1TextEdit);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(member_idLabel);
            this.groupBox1.Controls.Add(member_adressLabel);
            this.groupBox1.Controls.Add(member_fnameLabel);
            this.groupBox1.Controls.Add(member_lnameLabel);
            this.groupBox1.Controls.Add(member_contactLabel);
            this.groupBox1.Location = new System.Drawing.Point(27, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 393);
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
            this.member_idSpinEdit.Location = new System.Drawing.Point(163, 56);
            this.member_idSpinEdit.Name = "member_idSpinEdit";
            this.member_idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.member_idSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.member_idSpinEdit.TabIndex = 14;
            // 
            // member_fnameTextEdit
            // 
            this.member_fnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_fname", true));
            this.member_fnameTextEdit.Location = new System.Drawing.Point(163, 95);
            this.member_fnameTextEdit.Name = "member_fnameTextEdit";
            this.member_fnameTextEdit.Size = new System.Drawing.Size(150, 26);
            this.member_fnameTextEdit.TabIndex = 18;
            // 
            // member_lnameTextEdit
            // 
            this.member_lnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_lname", true));
            this.member_lnameTextEdit.Location = new System.Drawing.Point(163, 134);
            this.member_lnameTextEdit.Name = "member_lnameTextEdit";
            this.member_lnameTextEdit.Size = new System.Drawing.Size(150, 26);
            this.member_lnameTextEdit.TabIndex = 20;
            // 
            // member_contactTextEdit
            // 
            this.member_contactTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_contact", true));
            this.member_contactTextEdit.Location = new System.Drawing.Point(163, 257);
            this.member_contactTextEdit.Name = "member_contactTextEdit";
            this.member_contactTextEdit.Size = new System.Drawing.Size(150, 26);
            this.member_contactTextEdit.TabIndex = 22;
            // 
            // member_adress2TextEdit
            // 
            this.member_adress2TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_adress2", true));
            this.member_adress2TextEdit.Location = new System.Drawing.Point(163, 215);
            this.member_adress2TextEdit.Name = "member_adress2TextEdit";
            this.member_adress2TextEdit.Size = new System.Drawing.Size(150, 26);
            this.member_adress2TextEdit.TabIndex = 24;
            // 
            // member_adress1TextEdit
            // 
            this.member_adress1TextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.memberBindingSource, "member_adress1", true));
            this.member_adress1TextEdit.Location = new System.Drawing.Point(163, 172);
            this.member_adress1TextEdit.Name = "member_adress1TextEdit";
            this.member_adress1TextEdit.Size = new System.Drawing.Size(150, 26);
            this.member_adress1TextEdit.TabIndex = 26;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberBindingSource, "status", true));
            this.statusTextBox.Location = new System.Drawing.Point(139, 320);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 39);
            this.statusTextBox.TabIndex = 13;
            this.statusTextBox.Visible = false;
            // 
            // FormaddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.memberBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormaddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "สมัครสมาชิก";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingNavigator)).EndInit();
            this.memberBindingNavigator.ResumeLayout(false);
            this.memberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.member_idSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_fnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_lnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_contactTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adress2TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_adress1TextEdit.Properties)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusTextBox;
        private DevExpress.XtraEditors.SpinEdit member_idSpinEdit;
        private DevExpress.XtraEditors.TextEdit member_fnameTextEdit;
        private DevExpress.XtraEditors.TextEdit member_lnameTextEdit;
        private DevExpress.XtraEditors.TextEdit member_contactTextEdit;
        private DevExpress.XtraEditors.TextEdit member_adress2TextEdit;
        private DevExpress.XtraEditors.TextEdit member_adress1TextEdit;
    }
}