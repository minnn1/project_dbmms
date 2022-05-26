namespace GlassesStore
{
    partial class ReportprofitYear
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GlassesStoreDataSet8 = new GlassesStore.GlassesStoreDataSet8();
            this.View_profitYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_profitYearTableAdapter = new GlassesStore.GlassesStoreDataSet8TableAdapters.View_profitYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_profitYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportprofitYear.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 1;
            // 
            // GlassesStoreDataSet8
            // 
            this.GlassesStoreDataSet8.DataSetName = "GlassesStoreDataSet8";
            this.GlassesStoreDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_profitYearBindingSource
            // 
            this.View_profitYearBindingSource.DataMember = "View_profitYear";
            this.View_profitYearBindingSource.DataSource = this.GlassesStoreDataSet8;
            // 
            // View_profitYearTableAdapter
            // 
            this.View_profitYearTableAdapter.ClearBeforeFill = true;
            // 
            // ReportprofitYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportprofitYear";
            this.Text = "ReportprofitYear";
            this.Load += new System.EventHandler(this.ReportprofitYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitYearBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_profitYearBindingSource;
        private GlassesStoreDataSet8 GlassesStoreDataSet8;
        private GlassesStoreDataSet8TableAdapters.View_profitYearTableAdapter View_profitYearTableAdapter;
    }
}