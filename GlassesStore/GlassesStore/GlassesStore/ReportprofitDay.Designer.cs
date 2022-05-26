namespace GlassesStore
{
    partial class ReportprofitDay
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
            this.GlassesStoreDataSet5 = new GlassesStore.GlassesStoreDataSet5();
            this.View_profitDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_profitDayTableAdapter = new GlassesStore.GlassesStoreDataSet5TableAdapters.View_profitDayTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitDayBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_profitDayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportprofitDay.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // GlassesStoreDataSet5
            // 
            this.GlassesStoreDataSet5.DataSetName = "GlassesStoreDataSet5";
            this.GlassesStoreDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_profitDayBindingSource
            // 
            this.View_profitDayBindingSource.DataMember = "View_profitDay";
            this.View_profitDayBindingSource.DataSource = this.GlassesStoreDataSet5;
            // 
            // View_profitDayTableAdapter
            // 
            this.View_profitDayTableAdapter.ClearBeforeFill = true;
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
            // ReportprofitDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportprofitDay";
            this.Text = "ReportprofitDay";
            this.Load += new System.EventHandler(this.ReportprofitDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitDayBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_profitDayBindingSource;
        private GlassesStoreDataSet5 GlassesStoreDataSet5;
        private GlassesStoreDataSet5TableAdapters.View_profitDayTableAdapter View_profitDayTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}