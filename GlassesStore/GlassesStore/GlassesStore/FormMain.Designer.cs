namespace GlassesStore
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ButtonProduct = new System.Windows.Forms.ToolStripButton();
            this.ButtonCategory = new System.Windows.Forms.ToolStripButton();
            this.ButtonMember = new System.Windows.Forms.ToolStripButton();
            this.ButtonOrder = new System.Windows.Forms.ToolStripButton();
            this.ButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 619);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonProduct,
            this.toolStripLabel1,
            this.ButtonCategory,
            this.toolStripLabel3,
            this.ButtonMember,
            this.toolStripLabel4,
            this.ButtonOrder,
            this.toolStripLabel5,
            this.ButtonPrint,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1244, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 28);
            this.toolStripLabel1.Text = "สินค้า";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(102, 28);
            this.toolStripLabel3.Text = "ประเภทสินค้า";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(61, 28);
            this.toolStripLabel4.Text = "สมาชิก";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(68, 28);
            this.toolStripLabel5.Text = "ชำระเงิน";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 28);
            this.toolStripLabel2.Text = "พิมพ์รายงาน";
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonProduct.Image = global::GlassesStore.Properties.Resources.product_26px;
            this.ButtonProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Size = new System.Drawing.Size(34, 28);
            this.ButtonProduct.Text = "toolStripButton1";
            this.ButtonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonCategory.Image = global::GlassesStore.Properties.Resources.cardboard_box_24px;
            this.ButtonCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(34, 28);
            this.ButtonCategory.Text = "toolStripButton3";
            this.ButtonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // ButtonMember
            // 
            this.ButtonMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonMember.Image = global::GlassesStore.Properties.Resources.group_24px;
            this.ButtonMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonMember.Name = "ButtonMember";
            this.ButtonMember.Size = new System.Drawing.Size(34, 28);
            this.ButtonMember.Text = "toolStripButton4";
            this.ButtonMember.Click += new System.EventHandler(this.ButtonMember_Click);
            // 
            // ButtonOrder
            // 
            this.ButtonOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonOrder.Image = global::GlassesStore.Properties.Resources.checkout_32px;
            this.ButtonOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonOrder.Name = "ButtonOrder";
            this.ButtonOrder.Size = new System.Drawing.Size(34, 28);
            this.ButtonOrder.Text = "toolStripButton1";
            this.ButtonOrder.Click += new System.EventHandler(this.ButtonOrder_Click);
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtonPrint.Image = global::GlassesStore.Properties.Resources.print_32px;
            this.ButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(34, 28);
            this.ButtonPrint.Text = "toolStripButton2";
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "หน้าพนักงาน";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtonProduct;
        private System.Windows.Forms.ToolStripButton ButtonPrint;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton ButtonCategory;
        private System.Windows.Forms.ToolStripButton ButtonMember;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton ButtonOrder;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}