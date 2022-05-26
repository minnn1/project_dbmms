namespace Store2
{
    partial class FormEmployee
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.text_employeeFName = new System.Windows.Forms.TextBox();
            this.text_employeeLName = new System.Windows.Forms.TextBox();
            this.dataGrid_Employee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Jobposition_id = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPostion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(998, 32);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(238, 77);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "เพิ่มพนักงาน";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(998, 206);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(238, 77);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "ลบพนักงาน";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(998, 119);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(238, 77);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "บันทึกเเก้ไขข้อมูล";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(998, 293);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(238, 77);
            this.buttonNew.TabIndex = 3;
            this.buttonNew.Text = "เพิ่มพนักงานใหม่";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(12, 408);
            this.textSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(978, 39);
            this.textSearch.TabIndex = 4;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // text_employeeFName
            // 
            this.text_employeeFName.Location = new System.Drawing.Point(211, 169);
            this.text_employeeFName.Name = "text_employeeFName";
            this.text_employeeFName.Size = new System.Drawing.Size(179, 39);
            this.text_employeeFName.TabIndex = 7;
            // 
            // text_employeeLName
            // 
            this.text_employeeLName.Location = new System.Drawing.Point(211, 229);
            this.text_employeeLName.Name = "text_employeeLName";
            this.text_employeeLName.Size = new System.Drawing.Size(179, 39);
            this.text_employeeLName.TabIndex = 8;
            // 
            // dataGrid_Employee
            // 
            this.dataGrid_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_Employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGrid_Employee.Location = new System.Drawing.Point(23, 38);
            this.dataGrid_Employee.Name = "dataGrid_Employee";
            this.dataGrid_Employee.RowHeadersWidth = 62;
            this.dataGrid_Employee.RowTemplate.Height = 28;
            this.dataGrid_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Employee.Size = new System.Drawing.Size(526, 282);
            this.dataGrid_Employee.TabIndex = 9;
            this.dataGrid_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Employee_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PK_Employee_id";
            this.Column1.HeaderText = "รหัสพนักงาน";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "jobpositionName";
            this.Column2.HeaderText = "ตำเเหน่งงาน";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "employeeFName";
            this.Column3.HeaderText = "ชื่อ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "employeeLName";
            this.Column4.HeaderText = "นามสกุล";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "ตำเเหน่งงาน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "ชื่อพนักงาน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "นามสกุลพนักงาน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Jobposition_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_employeeFName);
            this.groupBox1.Controls.Add(this.text_employeeLName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 339);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เพิ่มข้อมูลพนักงาน";
            // 
            // comboBox_Jobposition_id
            // 
            this.comboBox_Jobposition_id.FormattingEnabled = true;
            this.comboBox_Jobposition_id.Location = new System.Drawing.Point(211, 104);
            this.comboBox_Jobposition_id.Name = "comboBox_Jobposition_id";
            this.comboBox_Jobposition_id.Size = new System.Drawing.Size(179, 40);
            this.comboBox_Jobposition_id.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGrid_Employee);
            this.groupBox2.Location = new System.Drawing.Point(435, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 326);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ส่วนเเสดงผล";
            // 
            // buttonPostion
            // 
            this.buttonPostion.Location = new System.Drawing.Point(18, 357);
            this.buttonPostion.Name = "buttonPostion";
            this.buttonPostion.Size = new System.Drawing.Size(140, 43);
            this.buttonPostion.TabIndex = 16;
            this.buttonPostion.Text = "ตำเเหน่งงาน";
            this.buttonPostion.UseVisualStyleBackColor = true;
            this.buttonPostion.Click += new System.EventHandler(this.buttonPostion_Click);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1270, 531);
            this.Controls.Add(this.buttonPostion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Employee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.TextBox text_employeeFName;
        private System.Windows.Forms.TextBox text_employeeLName;
        private System.Windows.Forms.DataGridView dataGrid_Employee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_Jobposition_id;
        private System.Windows.Forms.Button buttonPostion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}