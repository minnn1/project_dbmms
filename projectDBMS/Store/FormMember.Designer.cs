﻿namespace Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            System.Windows.Forms.Label memberIDLabel;
            System.Windows.Forms.Label memberFnameLabel;
            System.Windows.Forms.Label memberLnameLabel;
            System.Windows.Forms.Label memberPhoneLabel;
            System.Windows.Forms.Label memberNohouseLabel;
            System.Windows.Forms.Label memberRoadLabel;
            System.Windows.Forms.Label memberDistrictLabel;
            System.Windows.Forms.Label memberSubdistrictLabel;
            System.Windows.Forms.Label memberProvinceLabel;
            System.Windows.Forms.Label memberPostLabel;
            this.iTshopDBDataSet = new Store.ITshopDBDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new Store.ITshopDBDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new Store.ITshopDBDataSetTableAdapters.TableAdapterManager();
            this.membersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.membersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.memberFnameTextBox = new System.Windows.Forms.TextBox();
            this.memberLnameTextBox = new System.Windows.Forms.TextBox();
            this.memberPhoneTextBox = new System.Windows.Forms.TextBox();
            this.memberNohouseTextBox = new System.Windows.Forms.TextBox();
            this.memberRoadTextBox = new System.Windows.Forms.TextBox();
            this.memberDistrictTextBox = new System.Windows.Forms.TextBox();
            this.memberSubdistrictTextBox = new System.Windows.Forms.TextBox();
            this.memberProvinceTextBox = new System.Windows.Forms.TextBox();
            this.memberPostTextBox = new System.Windows.Forms.TextBox();
            memberIDLabel = new System.Windows.Forms.Label();
            memberFnameLabel = new System.Windows.Forms.Label();
            memberLnameLabel = new System.Windows.Forms.Label();
            memberPhoneLabel = new System.Windows.Forms.Label();
            memberNohouseLabel = new System.Windows.Forms.Label();
            memberRoadLabel = new System.Windows.Forms.Label();
            memberDistrictLabel = new System.Windows.Forms.Label();
            memberSubdistrictLabel = new System.Windows.Forms.Label();
            memberProvinceLabel = new System.Windows.Forms.Label();
            memberPostLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).BeginInit();
            this.membersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iTshopDBDataSet
            // 
            this.iTshopDBDataSet.DataSetName = "ITshopDBDataSet";
            this.iTshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.iTshopDBDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClaimsTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = null;
            this.tableAdapterManager.IncomeTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.JobPositionTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.PurchaseRequisitionTableAdapter = null;
            this.tableAdapterManager.ReceiptTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Store.ITshopDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // membersBindingNavigatorSaveItem
            // 
            this.membersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membersBindingNavigatorSaveItem.Image")));
            this.membersBindingNavigatorSaveItem.Name = "membersBindingNavigatorSaveItem";
            this.membersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.membersBindingNavigatorSaveItem.Text = "Save Data";
            this.membersBindingNavigatorSaveItem.Click += new System.EventHandler(this.membersBindingNavigatorSaveItem_Click);
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new System.Drawing.Point(41, 81);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new System.Drawing.Size(159, 32);
            memberIDLabel.TabIndex = 1;
            memberIDLabel.Text = "member ID:";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberID", true));
            this.memberIDTextBox.Location = new System.Drawing.Point(313, 78);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberIDTextBox.TabIndex = 2;
            // 
            // memberFnameLabel
            // 
            memberFnameLabel.AutoSize = true;
            memberFnameLabel.Location = new System.Drawing.Point(41, 126);
            memberFnameLabel.Name = "memberFnameLabel";
            memberFnameLabel.Size = new System.Drawing.Size(220, 32);
            memberFnameLabel.TabIndex = 3;
            memberFnameLabel.Text = "member Fname:";
            // 
            // memberFnameTextBox
            // 
            this.memberFnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberFname", true));
            this.memberFnameTextBox.Location = new System.Drawing.Point(313, 123);
            this.memberFnameTextBox.Name = "memberFnameTextBox";
            this.memberFnameTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberFnameTextBox.TabIndex = 4;
            // 
            // memberLnameLabel
            // 
            memberLnameLabel.AutoSize = true;
            memberLnameLabel.Location = new System.Drawing.Point(41, 171);
            memberLnameLabel.Name = "memberLnameLabel";
            memberLnameLabel.Size = new System.Drawing.Size(219, 32);
            memberLnameLabel.TabIndex = 5;
            memberLnameLabel.Text = "member Lname:";
            // 
            // memberLnameTextBox
            // 
            this.memberLnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberLname", true));
            this.memberLnameTextBox.Location = new System.Drawing.Point(313, 168);
            this.memberLnameTextBox.Name = "memberLnameTextBox";
            this.memberLnameTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberLnameTextBox.TabIndex = 6;
            // 
            // memberPhoneLabel
            // 
            memberPhoneLabel.AutoSize = true;
            memberPhoneLabel.Location = new System.Drawing.Point(41, 216);
            memberPhoneLabel.Name = "memberPhoneLabel";
            memberPhoneLabel.Size = new System.Drawing.Size(215, 32);
            memberPhoneLabel.TabIndex = 7;
            memberPhoneLabel.Text = "member Phone:";
            // 
            // memberPhoneTextBox
            // 
            this.memberPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberPhone", true));
            this.memberPhoneTextBox.Location = new System.Drawing.Point(313, 213);
            this.memberPhoneTextBox.Name = "memberPhoneTextBox";
            this.memberPhoneTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberPhoneTextBox.TabIndex = 8;
            // 
            // memberNohouseLabel
            // 
            memberNohouseLabel.AutoSize = true;
            memberNohouseLabel.Location = new System.Drawing.Point(41, 261);
            memberNohouseLabel.Name = "memberNohouseLabel";
            memberNohouseLabel.Size = new System.Drawing.Size(246, 32);
            memberNohouseLabel.TabIndex = 9;
            memberNohouseLabel.Text = "member Nohouse:";
            // 
            // memberNohouseTextBox
            // 
            this.memberNohouseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberNohouse", true));
            this.memberNohouseTextBox.Location = new System.Drawing.Point(313, 258);
            this.memberNohouseTextBox.Name = "memberNohouseTextBox";
            this.memberNohouseTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberNohouseTextBox.TabIndex = 10;
            // 
            // memberRoadLabel
            // 
            memberRoadLabel.AutoSize = true;
            memberRoadLabel.Location = new System.Drawing.Point(41, 306);
            memberRoadLabel.Name = "memberRoadLabel";
            memberRoadLabel.Size = new System.Drawing.Size(200, 32);
            memberRoadLabel.TabIndex = 11;
            memberRoadLabel.Text = "member Road:";
            // 
            // memberRoadTextBox
            // 
            this.memberRoadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberRoad", true));
            this.memberRoadTextBox.Location = new System.Drawing.Point(313, 303);
            this.memberRoadTextBox.Name = "memberRoadTextBox";
            this.memberRoadTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberRoadTextBox.TabIndex = 12;
            // 
            // memberDistrictLabel
            // 
            memberDistrictLabel.AutoSize = true;
            memberDistrictLabel.Location = new System.Drawing.Point(41, 351);
            memberDistrictLabel.Name = "memberDistrictLabel";
            memberDistrictLabel.Size = new System.Drawing.Size(219, 32);
            memberDistrictLabel.TabIndex = 13;
            memberDistrictLabel.Text = "member District:";
            // 
            // memberDistrictTextBox
            // 
            this.memberDistrictTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberDistrict", true));
            this.memberDistrictTextBox.Location = new System.Drawing.Point(313, 348);
            this.memberDistrictTextBox.Name = "memberDistrictTextBox";
            this.memberDistrictTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberDistrictTextBox.TabIndex = 14;
            // 
            // memberSubdistrictLabel
            // 
            memberSubdistrictLabel.AutoSize = true;
            memberSubdistrictLabel.Location = new System.Drawing.Point(41, 396);
            memberSubdistrictLabel.Name = "memberSubdistrictLabel";
            memberSubdistrictLabel.Size = new System.Drawing.Size(266, 32);
            memberSubdistrictLabel.TabIndex = 15;
            memberSubdistrictLabel.Text = "member Subdistrict:";
            // 
            // memberSubdistrictTextBox
            // 
            this.memberSubdistrictTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberSubdistrict", true));
            this.memberSubdistrictTextBox.Location = new System.Drawing.Point(313, 393);
            this.memberSubdistrictTextBox.Name = "memberSubdistrictTextBox";
            this.memberSubdistrictTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberSubdistrictTextBox.TabIndex = 16;
            // 
            // memberProvinceLabel
            // 
            memberProvinceLabel.AutoSize = true;
            memberProvinceLabel.Location = new System.Drawing.Point(41, 441);
            memberProvinceLabel.Name = "memberProvinceLabel";
            memberProvinceLabel.Size = new System.Drawing.Size(243, 32);
            memberProvinceLabel.TabIndex = 17;
            memberProvinceLabel.Text = "member Province:";
            // 
            // memberProvinceTextBox
            // 
            this.memberProvinceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberProvince", true));
            this.memberProvinceTextBox.Location = new System.Drawing.Point(313, 438);
            this.memberProvinceTextBox.Name = "memberProvinceTextBox";
            this.memberProvinceTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberProvinceTextBox.TabIndex = 18;
            // 
            // memberPostLabel
            // 
            memberPostLabel.AutoSize = true;
            memberPostLabel.Location = new System.Drawing.Point(41, 486);
            memberPostLabel.Name = "memberPostLabel";
            memberPostLabel.Size = new System.Drawing.Size(189, 32);
            memberPostLabel.TabIndex = 19;
            memberPostLabel.Text = "member Post:";
            // 
            // memberPostTextBox
            // 
            this.memberPostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "memberPost", true));
            this.memberPostTextBox.Location = new System.Drawing.Point(313, 483);
            this.memberPostTextBox.Name = "memberPostTextBox";
            this.memberPostTextBox.Size = new System.Drawing.Size(100, 39);
            this.memberPostTextBox.TabIndex = 20;
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(memberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
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
            this.Controls.Add(this.membersBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).EndInit();
            this.membersBindingNavigator.ResumeLayout(false);
            this.membersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ITshopDBDataSet iTshopDBDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private ITshopDBDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private ITshopDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox memberFnameTextBox;
        private System.Windows.Forms.TextBox memberLnameTextBox;
        private System.Windows.Forms.TextBox memberPhoneTextBox;
        private System.Windows.Forms.TextBox memberNohouseTextBox;
        private System.Windows.Forms.TextBox memberRoadTextBox;
        private System.Windows.Forms.TextBox memberDistrictTextBox;
        private System.Windows.Forms.TextBox memberSubdistrictTextBox;
        private System.Windows.Forms.TextBox memberProvinceTextBox;
        private System.Windows.Forms.TextBox memberPostTextBox;
    }
}