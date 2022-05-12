namespace Store
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceQTYTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.invoiceTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.invoicePriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.invoicePnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboboxmember = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxproduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxemployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 366);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // invoiceQTYTextBox
            // 
            this.invoiceQTYTextBox.Location = new System.Drawing.Point(455, 89);
            this.invoiceQTYTextBox.Name = "invoiceQTYTextBox";
            this.invoiceQTYTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoiceQTYTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "จำนวนสินค้า";
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(1057, 92);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(200, 39);
            this.invoiceDateDateTimePicker.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1005, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "วันที่";
            // 
            // invoiceTotalPriceTextBox
            // 
            this.invoiceTotalPriceTextBox.Location = new System.Drawing.Point(799, 90);
            this.invoiceTotalPriceTextBox.Name = "invoiceTotalPriceTextBox";
            this.invoiceTotalPriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoiceTotalPriceTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "ราคารวมสินค้า";
            // 
            // invoicePriceTextBox
            // 
            this.invoicePriceTextBox.Location = new System.Drawing.Point(142, 86);
            this.invoicePriceTextBox.Name = "invoicePriceTextBox";
            this.invoicePriceTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoicePriceTextBox.TabIndex = 5;
            this.invoicePriceTextBox.TextChanged += new System.EventHandler(this.invoicePriceTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "ราคาสินค้า";
            // 
            // invoicePnameTextBox
            // 
            this.invoicePnameTextBox.Location = new System.Drawing.Point(1054, 34);
            this.invoicePnameTextBox.Name = "invoicePnameTextBox";
            this.invoicePnameTextBox.Size = new System.Drawing.Size(200, 39);
            this.invoicePnameTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(956, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 32);
            this.label4.TabIndex = 12;
            this.label4.Text = "ชื่อรายการ";
            // 
            // comboboxmember
            // 
            this.comboboxmember.FormattingEnabled = true;
            this.comboboxmember.Location = new System.Drawing.Point(446, 40);
            this.comboboxmember.Name = "comboboxmember";
            this.comboboxmember.Size = new System.Drawing.Size(200, 40);
            this.comboboxmember.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "สมาชิก";
            // 
            // comboboxproduct
            // 
            this.comboboxproduct.FormattingEnabled = true;
            this.comboboxproduct.Location = new System.Drawing.Point(735, 36);
            this.comboboxproduct.Name = "comboboxproduct";
            this.comboboxproduct.Size = new System.Drawing.Size(200, 40);
            this.comboboxproduct.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "สินค้า";
            // 
            // comboboxemployee
            // 
            this.comboboxemployee.FormattingEnabled = true;
            this.comboboxemployee.Location = new System.Drawing.Point(142, 40);
            this.comboboxemployee.Name = "comboboxemployee";
            this.comboboxemployee.Size = new System.Drawing.Size(200, 40);
            this.comboboxemployee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "พนักงาน";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 16;
            this.button1.Text = "บันทึกรายการ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 59);
            this.button2.TabIndex = 17;
            this.button2.Text = "เพิ่มรายการใหม่";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(511, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 59);
            this.button3.TabIndex = 18;
            this.button3.Text = "ลบรายการ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(735, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 59);
            this.button4.TabIndex = 19;
            this.button4.Text = "อัพเดทรายการ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "invoiceID";
            this.Column1.HeaderText = "รหัสชำระสินค้า";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "invoicePname";
            this.Column2.HeaderText = "ชื่อรายการ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "employeeFName";
            this.Column3.HeaderText = "พนักงาน";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "memberFname";
            this.Column4.HeaderText = "ลูกค้าสมาชิก";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "productName";
            this.Column5.HeaderText = "สินค้า";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "invoiceQTY";
            this.Column6.HeaderText = "จำนวนสินค้า";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "invoicePrice";
            this.Column7.HeaderText = "ราคาสินค้า";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "invoiceTotalPrice";
            this.Column8.HeaderText = "ราคาสินค้ารวม";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "invoiceDate";
            this.Column9.HeaderText = "วันที่ชำระ";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 886);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxemployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboboxproduct);
            this.Controls.Add(this.invoiceQTYTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboboxmember);
            this.Controls.Add(this.invoiceDateDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.invoicePnameTextBox);
            this.Controls.Add(this.invoiceTotalPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoicePriceTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox invoiceQTYTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker invoiceDateDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox invoiceTotalPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invoicePriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox invoicePnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboboxmember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboboxproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxemployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}