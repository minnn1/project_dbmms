namespace GlassesStore
{
    partial class FormLoign3
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
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRefesh = new System.Windows.Forms.Button();
            this.comboboxStatus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ชื่อผู้ใช้งาน";
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(141, 36);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(388, 37);
            this.comboBoxMember.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(37, 180);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(160, 48);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "เข้าใช้งาน";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRefesh
            // 
            this.buttonRefesh.Location = new System.Drawing.Point(369, 180);
            this.buttonRefesh.Name = "buttonRefesh";
            this.buttonRefesh.Size = new System.Drawing.Size(160, 48);
            this.buttonRefesh.TabIndex = 5;
            this.buttonRefesh.Text = "รีเฟช";
            this.buttonRefesh.UseVisualStyleBackColor = true;
            this.buttonRefesh.Click += new System.EventHandler(this.buttonRefesh_Click);
            // 
            // comboboxStatus
            // 
            this.comboboxStatus.Enabled = false;
            this.comboboxStatus.FormattingEnabled = true;
            this.comboboxStatus.Location = new System.Drawing.Point(141, 94);
            this.comboboxStatus.Name = "comboboxStatus";
            this.comboboxStatus.Size = new System.Drawing.Size(388, 37);
            this.comboboxStatus.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "สมัครสมาชิก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLoign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboboxStatus);
            this.Controls.Add(this.buttonRefesh);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormLoign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoign";
            this.Load += new System.EventHandler(this.FormLoign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRefesh;
        private System.Windows.Forms.ComboBox comboboxStatus;
        private System.Windows.Forms.Button button1;
    }
}