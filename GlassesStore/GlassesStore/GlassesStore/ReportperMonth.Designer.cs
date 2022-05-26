namespace GlassesStore
{
    partial class ReportperMonth
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
            this.GlassesStoreDataSet1 = new GlassesStore.GlassesStoreDataSet1();
            this.View_permonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_permonthTableAdapter = new GlassesStore.GlassesStoreDataSet1TableAdapters.View_permonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_permonthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_permonthBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportperMonth.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GlassesStoreDataSet1
            // 
            this.GlassesStoreDataSet1.DataSetName = "GlassesStoreDataSet1";
            this.GlassesStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_permonthBindingSource
            // 
            this.View_permonthBindingSource.DataMember = "View_permonth";
            this.View_permonthBindingSource.DataSource = this.GlassesStoreDataSet1;
            // 
            // View_permonthTableAdapter
            // 
            this.View_permonthTableAdapter.ClearBeforeFill = true;
            // 
            // ReportperMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportperMonth";
            this.Text = "ReportperMonth";
            this.Load += new System.EventHandler(this.ReportperMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_permonthBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_permonthBindingSource;
        private GlassesStoreDataSet1 GlassesStoreDataSet1;
        private GlassesStoreDataSet1TableAdapters.View_permonthTableAdapter View_permonthTableAdapter;
    }
}