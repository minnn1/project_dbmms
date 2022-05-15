namespace Store2
{
    partial class FormPosition
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
            System.Windows.Forms.Label pK_JobPosition_idLabel;
            System.Windows.Forms.Label jobpositionNameLabel;
            System.Windows.Forms.Label jobpositionPassLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosition));
            this.iTshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.jobPositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobPositionTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.JobPositionTableAdapter();
            this.tableAdapterManager = new Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager();
            this.jobPositionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.jobPositionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jobPositionDataGridView = new System.Windows.Forms.DataGridView();
            this.pK_JobPosition_idTextBox = new System.Windows.Forms.TextBox();
            this.jobpositionNameTextBox = new System.Windows.Forms.TextBox();
            this.jobpositionPassTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pK_JobPosition_idLabel = new System.Windows.Forms.Label();
            jobpositionNameLabel = new System.Windows.Forms.Label();
            jobpositionPassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionBindingNavigator)).BeginInit();
            this.jobPositionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pK_JobPosition_idLabel
            // 
            pK_JobPosition_idLabel.AutoSize = true;
            pK_JobPosition_idLabel.Location = new System.Drawing.Point(31, 69);
            pK_JobPosition_idLabel.Name = "pK_JobPosition_idLabel";
            pK_JobPosition_idLabel.Size = new System.Drawing.Size(150, 32);
            pK_JobPosition_idLabel.TabIndex = 2;
            pK_JobPosition_idLabel.Text = "รหัสตำเเหน่ง";
            // 
            // jobpositionNameLabel
            // 
            jobpositionNameLabel.AutoSize = true;
            jobpositionNameLabel.Location = new System.Drawing.Point(31, 114);
            jobpositionNameLabel.Name = "jobpositionNameLabel";
            jobpositionNameLabel.Size = new System.Drawing.Size(136, 32);
            jobpositionNameLabel.TabIndex = 4;
            jobpositionNameLabel.Text = "ชื่อตำเเหน่ง";
            // 
            // jobpositionPassLabel
            // 
            jobpositionPassLabel.AutoSize = true;
            jobpositionPassLabel.Location = new System.Drawing.Point(31, 159);
            jobpositionPassLabel.Name = "jobpositionPassLabel";
            jobpositionPassLabel.Size = new System.Drawing.Size(105, 32);
            jobpositionPassLabel.TabIndex = 6;
            jobpositionPassLabel.Text = "รหัสผ่าน";
            // 
            // iTshopDB2DataSet
            // 
            this.iTshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.iTshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobPositionBindingSource
            // 
            this.jobPositionBindingSource.DataMember = "JobPosition";
            this.jobPositionBindingSource.DataSource = this.iTshopDB2DataSet;
            // 
            // jobPositionTableAdapter
            // 
            this.jobPositionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.JobPositionTableAdapter = this.jobPositionTableAdapter;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store2.ITshopDB2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jobPositionBindingNavigator
            // 
            this.jobPositionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobPositionBindingNavigator.BindingSource = this.jobPositionBindingSource;
            this.jobPositionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobPositionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jobPositionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.jobPositionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jobPositionBindingNavigatorSaveItem});
            this.jobPositionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobPositionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobPositionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobPositionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobPositionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobPositionBindingNavigator.Name = "jobPositionBindingNavigator";
            this.jobPositionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobPositionBindingNavigator.Size = new System.Drawing.Size(1422, 33);
            this.jobPositionBindingNavigator.TabIndex = 0;
            this.jobPositionBindingNavigator.Text = "bindingNavigator1";
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
            // jobPositionBindingNavigatorSaveItem
            // 
            this.jobPositionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jobPositionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jobPositionBindingNavigatorSaveItem.Image")));
            this.jobPositionBindingNavigatorSaveItem.Name = "jobPositionBindingNavigatorSaveItem";
            this.jobPositionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.jobPositionBindingNavigatorSaveItem.Text = "Save Data";
            this.jobPositionBindingNavigatorSaveItem.Click += new System.EventHandler(this.jobPositionBindingNavigatorSaveItem_Click_3);
            // 
            // jobPositionDataGridView
            // 
            this.jobPositionDataGridView.AutoGenerateColumns = false;
            this.jobPositionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jobPositionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobPositionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.jobPositionDataGridView.DataSource = this.jobPositionBindingSource;
            this.jobPositionDataGridView.Location = new System.Drawing.Point(479, 69);
            this.jobPositionDataGridView.Name = "jobPositionDataGridView";
            this.jobPositionDataGridView.RowHeadersWidth = 62;
            this.jobPositionDataGridView.RowTemplate.Height = 28;
            this.jobPositionDataGridView.Size = new System.Drawing.Size(557, 220);
            this.jobPositionDataGridView.TabIndex = 1;
            // 
            // pK_JobPosition_idTextBox
            // 
            this.pK_JobPosition_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobPositionBindingSource, "PK_JobPosition_id", true));
            this.pK_JobPosition_idTextBox.Location = new System.Drawing.Point(187, 66);
            this.pK_JobPosition_idTextBox.Name = "pK_JobPosition_idTextBox";
            this.pK_JobPosition_idTextBox.Size = new System.Drawing.Size(268, 39);
            this.pK_JobPosition_idTextBox.TabIndex = 3;
            // 
            // jobpositionNameTextBox
            // 
            this.jobpositionNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobPositionBindingSource, "jobpositionName", true));
            this.jobpositionNameTextBox.Location = new System.Drawing.Point(187, 111);
            this.jobpositionNameTextBox.Name = "jobpositionNameTextBox";
            this.jobpositionNameTextBox.Size = new System.Drawing.Size(268, 39);
            this.jobpositionNameTextBox.TabIndex = 5;
            // 
            // jobpositionPassTextBox
            // 
            this.jobpositionPassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobPositionBindingSource, "jobpositionPass", true));
            this.jobpositionPassTextBox.Location = new System.Drawing.Point(187, 156);
            this.jobpositionPassTextBox.Name = "jobpositionPassTextBox";
            this.jobpositionPassTextBox.Size = new System.Drawing.Size(268, 39);
            this.jobpositionPassTextBox.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_JobPosition_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "รหัสตำเเหน่ง";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "jobpositionName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ชื่อตำเเนห่ง";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "jobpositionPass";
            this.dataGridViewTextBoxColumn3.HeaderText = "รหัสผ่าน";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(pK_JobPosition_idLabel);
            this.Controls.Add(this.pK_JobPosition_idTextBox);
            this.Controls.Add(jobpositionNameLabel);
            this.Controls.Add(this.jobpositionNameTextBox);
            this.Controls.Add(jobpositionPassLabel);
            this.Controls.Add(this.jobpositionPassTextBox);
            this.Controls.Add(this.jobPositionDataGridView);
            this.Controls.Add(this.jobPositionBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormPosition";
            this.Text = "FormPositiob";
            this.Load += new System.EventHandler(this.FormPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionBindingNavigator)).EndInit();
            this.jobPositionBindingNavigator.ResumeLayout(false);
            this.jobPositionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobPositionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDB2DataSet iTshopDB2DataSet;
        private System.Windows.Forms.BindingSource jobPositionBindingSource;
        private ITshopDB2DataSetTableAdapters.JobPositionTableAdapter jobPositionTableAdapter;
        private ITshopDB2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobPositionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jobPositionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView jobPositionDataGridView;
        private System.Windows.Forms.TextBox pK_JobPosition_idTextBox;
        private System.Windows.Forms.TextBox jobpositionNameTextBox;
        private System.Windows.Forms.TextBox jobpositionPassTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}