namespace GlassesStore
{
    partial class FormOrderview
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
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.order_idSpinEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridview1
            // 
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview1.Location = new System.Drawing.Point(0, 0);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RowHeadersWidth = 62;
            this.datagridview1.RowTemplate.Height = 28;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(800, 450);
            this.datagridview1.TabIndex = 0;
            this.datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellContentClick);
            // 
            // order_idSpinEdit
            // 
            this.order_idSpinEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.order_idSpinEdit.Location = new System.Drawing.Point(0, 0);
            this.order_idSpinEdit.Name = "order_idSpinEdit";
            this.order_idSpinEdit.Size = new System.Drawing.Size(800, 26);
            this.order_idSpinEdit.TabIndex = 1;
            this.order_idSpinEdit.TextChanged += new System.EventHandler(this.order_idSpinEdit_TextChanged);
            // 
            // FormOrderview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order_idSpinEdit);
            this.Controls.Add(this.datagridview1);
            this.Name = "FormOrderview";
            this.Text = "FormOrderview";
            this.Load += new System.EventHandler(this.FormOrderview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.TextBox order_idSpinEdit;
    }
}