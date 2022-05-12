namespace Store
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
            System.Windows.Forms.Label productcategoryIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productPriceLabel;
            System.Windows.Forms.Label productInventoryLabel;
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productcategorycombobox = new System.Windows.Forms.ComboBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTshopDBDataSet = new Store.ITshopDBDataSet();
            this.productTableAdapter = new Store.ITshopDBDataSetTableAdapters.ProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            productcategoryIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            productInventoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // productcategoryIDLabel
            // 
            productcategoryIDLabel.AutoSize = true;
            productcategoryIDLabel.Location = new System.Drawing.Point(38, 87);
            productcategoryIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productcategoryIDLabel.Name = "productcategoryIDLabel";
            productcategoryIDLabel.Size = new System.Drawing.Size(189, 32);
            productcategoryIDLabel.TabIndex = 3;
            productcategoryIDLabel.Text = "ชื่อประเภทสินค้า";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(38, 138);
            productNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(106, 32);
            productNameLabel.TabIndex = 5;
            productNameLabel.Text = "ชื่อสินค้า";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new System.Drawing.Point(38, 189);
            productPriceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(128, 32);
            productPriceLabel.TabIndex = 7;
            productPriceLabel.Text = "ราคาสินค้า";
            // 
            // productInventoryLabel
            // 
            productInventoryLabel.AutoSize = true;
            productInventoryLabel.Location = new System.Drawing.Point(38, 240);
            productInventoryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            productInventoryLabel.Name = "productInventoryLabel";
            productInventoryLabel.Size = new System.Drawing.Size(148, 32);
            productInventoryLabel.TabIndex = 9;
            productInventoryLabel.Text = "จำนวนสินค้า";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(314, 133);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(280, 39);
            this.productNameTextBox.TabIndex = 6;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(314, 184);
            this.productPriceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(280, 39);
            this.productPriceTextBox.TabIndex = 8;
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Location = new System.Drawing.Point(314, 236);
            this.productInventoryTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(280, 39);
            this.productInventoryTextBox.TabIndex = 10;
            // 
            // productcategorycombobox
            // 
            this.productcategorycombobox.FormattingEnabled = true;
            this.productcategorycombobox.Location = new System.Drawing.Point(314, 87);
            this.productcategorycombobox.Margin = new System.Windows.Forms.Padding(5);
            this.productcategorycombobox.Name = "productcategorycombobox";
            this.productcategorycombobox.Size = new System.Drawing.Size(280, 40);
            this.productcategorycombobox.TabIndex = 12;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(618, 87);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(202, 68);
            this.btninsert.TabIndex = 13;
            this.btninsert.Text = "เพิ่มสินค้า";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(826, 174);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 63);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "ลบสินค้า";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.iTshopDBDataSet;
            // 
            // iTshopDBDataSet
            // 
            this.iTshopDBDataSet.DataSetName = "ITshopDBDataSet";
            this.iTshopDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(44, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(928, 268);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productcategoryName";
            this.Column2.HeaderText = "ประเภทสินค้า";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "productName";
            this.Column1.HeaderText = "ชื่อสินค้า";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "productPrice";
            this.Column3.HeaderText = "ราคาสินค้า";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "productInventory";
            this.Column4.HeaderText = "จำนวนสินค้า";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Location = new System.Drawing.Point(621, 174);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(199, 63);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "เเก้ไขสินค้า";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnnew
            // 
            this.btnnew.Location = new System.Drawing.Point(826, 90);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(157, 63);
            this.btnnew.TabIndex = 18;
            this.btnnew.Text = "เพิ่มสินค้าใหม่";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Visible = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 66);
            this.label1.TabIndex = 19;
            this.label1.Text = "เพิ่มข้อมูลสินค้า";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 811);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.productcategorycombobox);
            this.Controls.Add(productcategoryIDLabel);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(productInventoryLabel);
            this.Controls.Add(this.productInventoryTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTshopDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.ComboBox productcategorycombobox;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btndelete;
        private ITshopDBDataSet iTshopDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ITshopDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Label label1;
    }
}