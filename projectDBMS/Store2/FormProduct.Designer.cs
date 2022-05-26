namespace Store2
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCatagory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQTY = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridProduct);
            this.groupBox2.Location = new System.Drawing.Point(464, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 326);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ส่วนเเสดงผล";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dataGridProduct.Location = new System.Drawing.Point(6, 38);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.RowHeadersWidth = 62;
            this.dataGridProduct.RowTemplate.Height = 28;
            this.dataGridProduct.Size = new System.Drawing.Size(543, 282);
            this.dataGridProduct.TabIndex = 0;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Employee_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_Product_id";
            this.Column1.HeaderText = "รหัสสินค้า";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "productName";
            this.Column2.HeaderText = "ชื่อสินค้า";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "categoryName";
            this.Column5.HeaderText = "ประเภทสินค้า";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCatagory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxQTY);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 339);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มข้อมูลสินค้า";
            // 
            // comboBoxCatagory
            // 
            this.comboBoxCatagory.FormattingEnabled = true;
            this.comboBoxCatagory.Location = new System.Drawing.Point(195, 142);
            this.comboBoxCatagory.Name = "comboBoxCatagory";
            this.comboBoxCatagory.Size = new System.Drawing.Size(200, 40);
            this.comboBoxCatagory.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "จำนวนสินค้า";
            // 
            // textBoxQTY
            // 
            this.textBoxQTY.Location = new System.Drawing.Point(195, 256);
            this.textBoxQTY.Name = "textBoxQTY";
            this.textBoxQTY.Size = new System.Drawing.Size(200, 39);
            this.textBoxQTY.TabIndex = 16;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(195, 203);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(200, 39);
            this.textBoxProductPrice.TabIndex = 15;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(195, 85);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 39);
            this.textBoxProductName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "ราคาสินค้า";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "ประเภทสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(1027, 307);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(238, 77);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Text = "เพิ่มสินค้าใหม่";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1027, 133);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(238, 77);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "บันทึกเเก้ไขข้อมูล";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1027, 220);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(238, 77);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "ลบสินค้า";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1027, 46);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 77);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "เพิ่มสินค้า";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(41, 422);
            this.textSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(978, 39);
            this.textSearch.TabIndex = 21;
            this.textSearch.Click += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1422, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox textBoxQTY;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}