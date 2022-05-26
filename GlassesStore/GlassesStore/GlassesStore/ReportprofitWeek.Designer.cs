namespace GlassesStore
{
    partial class ReportprofitWeek
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GlassesStoreDataSet6 = new GlassesStore.GlassesStoreDataSet6();
            this.View_profitWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_profitWeekTableAdapter = new GlassesStore.GlassesStoreDataSet6TableAdapters.View_profitWeekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitWeekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.View_profitWeekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportprofitWeek.rdlc";
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
            // GlassesStoreDataSet6
            // 
            this.GlassesStoreDataSet6.DataSetName = "GlassesStoreDataSet6";
            this.GlassesStoreDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_profitWeekBindingSource
            // 
            this.View_profitWeekBindingSource.DataMember = "View_profitWeek";
            this.View_profitWeekBindingSource.DataSource = this.GlassesStoreDataSet6;
            // 
            // View_profitWeekTableAdapter
            // 
            this.View_profitWeekTableAdapter.ClearBeforeFill = true;
            // 
            // ReportprofitWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportprofitWeek";
            this.Text = "ReportprofitWeek";
            this.Load += new System.EventHandler(this.ReportprofitWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitWeekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_profitWeekBindingSource;
        private GlassesStoreDataSet6 GlassesStoreDataSet6;
        private System.Windows.Forms.TextBox textBox1;
        private GlassesStoreDataSet6TableAdapters.View_profitWeekTableAdapter View_profitWeekTableAdapter;
    }
}