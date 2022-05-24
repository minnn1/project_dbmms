namespace GlassesStore
{
    partial class FormLogin1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoginEmp = new System.Windows.Forms.Button();
            this.buttonLoginCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(146, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "เข้าสู่ระบบ";
            // 
            // buttonLoginEmp
            // 
            this.buttonLoginEmp.Location = new System.Drawing.Point(51, 111);
            this.buttonLoginEmp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonLoginEmp.Name = "buttonLoginEmp";
            this.buttonLoginEmp.Size = new System.Drawing.Size(147, 73);
            this.buttonLoginEmp.TabIndex = 11;
            this.buttonLoginEmp.Text = "เข้าใช้งานพนักงาน";
            this.buttonLoginEmp.UseVisualStyleBackColor = true;
            this.buttonLoginEmp.Click += new System.EventHandler(this.buttonLoginEmp_Click);
            // 
            // buttonLoginCus
            // 
            this.buttonLoginCus.Location = new System.Drawing.Point(250, 111);
            this.buttonLoginCus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonLoginCus.Name = "buttonLoginCus";
            this.buttonLoginCus.Size = new System.Drawing.Size(147, 73);
            this.buttonLoginCus.TabIndex = 12;
            this.buttonLoginCus.Text = "เข้าใช้งานลูกค้า";
            this.buttonLoginCus.UseVisualStyleBackColor = true;
            this.buttonLoginCus.Click += new System.EventHandler(this.buttonLoginCus_Click);
            // 
            // FormLogin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 253);
            this.Controls.Add(this.buttonLoginCus);
            this.Controls.Add(this.buttonLoginEmp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLogin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoginEmp;
        private System.Windows.Forms.Button buttonLoginCus;
    }
}