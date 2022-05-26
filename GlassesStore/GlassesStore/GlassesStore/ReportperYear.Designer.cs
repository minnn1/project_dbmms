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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GlassesStoreDataSet2 = new GlassesStore.GlassesStoreDataSet2();
            this.View_perYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_perYearTableAdapter = new GlassesStore.GlassesStoreDataSet2TableAdapters.View_perYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.View_perYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportperYear.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GlassesStoreDataSet2
            // 
            this.GlassesStoreDataSet2.DataSetName = "GlassesStoreDataSet2";
            this.GlassesStoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_perYearBindingSource
            // 
            this.View_perYearBindingSource.DataMember = "View_perYear";
            this.View_perYearBindingSource.DataSource = this.GlassesStoreDataSet2;
            // 
            // View_perYearTableAdapter
            // 
            this.View_perYearTableAdapter.ClearBeforeFill = true;
            // 
            // ReportperYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportperYear";
            this.Text = "ReportperYear";
            this.Load += new System.EventHandler(this.ReportperYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_perYearBindingSource;
        private GlassesStoreDataSet2 GlassesStoreDataSet2;
        private GlassesStoreDataSet2TableAdapters.View_perYearTableAdapter View_perYearTableAdapter;
    }
}