namespace GlassesStore
{
    partial class FormviewProduct
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GlassesStoreDataSet10 = new GlassesStore.GlassesStoreDataSet10();
            this.View_productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_productTableAdapter = new GlassesStore.GlassesStoreDataSet10TableAdapters.View_productTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_productBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GlassesStoreDataSet10
            // 
            this.GlassesStoreDataSet10.DataSetName = "GlassesStoreDataSet10";
            this.GlassesStoreDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_productBindingSource
            // 
            this.View_productBindingSource.DataMember = "View_product";
            this.View_productBindingSource.DataSource = this.GlassesStoreDataSet10;
            // 
            // View_productTableAdapter
            // 
            this.View_productTableAdapter.ClearBeforeFill = true;
            // 
            // FormviewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormviewProduct";
            this.Text = "FormviewProduct";
            this.Load += new System.EventHandler(this.FormviewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource View_productBindingSource;
        private GlassesStoreDataSet10 GlassesStoreDataSet10;
        private GlassesStoreDataSet10TableAdapters.View_productTableAdapter View_productTableAdapter;
    }
}