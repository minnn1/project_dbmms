namespace GlassesStore
{
    partial class FormLogin2
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
            this.buttonRefesh = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonRefesh
            // 
            this.buttonRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonRefesh.Location = new System.Drawing.Point(383, 174);
            this.buttonRefesh.Name = "buttonRefesh";
            this.buttonRefesh.Size = new System.Drawing.Size(160, 48);
            this.buttonRefesh.TabIndex = 11;
            this.buttonRefesh.Text = "รีเฟช";
            this.buttonRefesh.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonLogin.Location = new System.Drawing.Point(173, 174);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(160, 48);
            this.buttonLogin.TabIndex = 10;
            this.buttonLogin.Text = "เข้าใช้งาน";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxEmp
            // 
            this.comboBoxEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxEmp.FormattingEnabled = true;
            this.comboBoxEmp.Location = new System.Drawing.Point(155, 30);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(388, 37);
            this.comboBoxEmp.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "ชื่อผู้ใช้งาน";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxPassword.Location = new System.Drawing.Point(155, 101);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(388, 35);
            this.textBoxPassword.TabIndex = 14;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormLogin2
            // 
            this.ClientSize = new System.Drawing.Size(581, 253);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRefesh);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxEmp);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin2";
            this.Load += new System.EventHandler(this.FormLogin2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefesh;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.ComboBox comboBoxEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}