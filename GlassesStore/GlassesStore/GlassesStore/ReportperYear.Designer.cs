namespace GlassesStore
{
    partial class ReportperYear
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_perYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GlassesStoreDataSet2 = new GlassesStore.GlassesStoreDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_perYearTableAdapter = new GlassesStore.GlassesStoreDataSet2TableAdapters.View_perYearTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.View_perYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // View_perYearBindingSource
            // 
            this.View_perYearBindingSource.DataMember = "View_perYear";
            this.View_perYearBindingSource.DataSource = this.GlassesStoreDataSet2;
            // 
            // GlassesStoreDataSet2
            // 
            this.GlassesStoreDataSet2.DataSetName = "GlassesStoreDataSet2";
            this.GlassesStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.View_perYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportperYear.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_perYearTableAdapter
            // 
            this.View_perYearTableAdapter.ClearBeforeFill = true;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReportperYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportperYear";
            this.Text = "ReportperYear";
            this.Load += new System.EventHandler(this.ReportperYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_perYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_perYearBindingSource;
        private GlassesStoreDataSet2 GlassesStoreDataSet2;
        private GlassesStoreDataSet2TableAdapters.View_perYearTableAdapter View_perYearTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}