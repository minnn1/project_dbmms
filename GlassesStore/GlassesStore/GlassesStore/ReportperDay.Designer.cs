namespace GlassesStore
{
    partial class ReportperDay
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
            this.GlassesStoreDataSet3 = new GlassesStore.GlassesStoreDataSet3();
            this.View_perDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_perDayTableAdapter = new GlassesStore.GlassesStoreDataSet3TableAdapters.View_perDayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_perDayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportperDay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // GlassesStoreDataSet3
            // 
            this.GlassesStoreDataSet3.DataSetName = "GlassesStoreDataSet3";
            this.GlassesStoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_perDayBindingSource
            // 
            this.View_perDayBindingSource.DataMember = "View_perDay";
            this.View_perDayBindingSource.DataSource = this.GlassesStoreDataSet3;
            // 
            // View_perDayTableAdapter
            // 
            this.View_perDayTableAdapter.ClearBeforeFill = true;
            // 
            // ReportperDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportperDay";
            this.Text = "ReportperDay";
            this.Load += new System.EventHandler(this.ReportperDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perDayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_perDayBindingSource;
        private GlassesStoreDataSet3 GlassesStoreDataSet3;
        private GlassesStoreDataSet3TableAdapters.View_perDayTableAdapter View_perDayTableAdapter;
    }
}