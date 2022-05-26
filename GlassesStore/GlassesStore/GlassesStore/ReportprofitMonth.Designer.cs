namespace GlassesStore
{
    partial class ReportprofitMonth
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
            this.GlassesStoreDataSet7 = new GlassesStore.GlassesStoreDataSet7();
            this.View_profitMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_profitMonthTableAdapter = new GlassesStore.GlassesStoreDataSet7TableAdapters.View_profitMonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitMonthBindingSource)).BeginInit();
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
            reportDataSource1.Value = this.View_profitMonthBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportprofitMonth.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 1;
            // 
            // GlassesStoreDataSet7
            // 
            this.GlassesStoreDataSet7.DataSetName = "GlassesStoreDataSet7";
            this.GlassesStoreDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_profitMonthBindingSource
            // 
            this.View_profitMonthBindingSource.DataMember = "View_profitMonth";
            this.View_profitMonthBindingSource.DataSource = this.GlassesStoreDataSet7;
            // 
            // View_profitMonthTableAdapter
            // 
            this.View_profitMonthTableAdapter.ClearBeforeFill = true;
            // 
            // ReportprofitMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportprofitMonth";
            this.Text = "ReportprofitMonth";
            this.Load += new System.EventHandler(this.ReportprofitMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_profitMonthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_profitMonthBindingSource;
        private GlassesStoreDataSet7 GlassesStoreDataSet7;
        private GlassesStoreDataSet7TableAdapters.View_profitMonthTableAdapter View_profitMonthTableAdapter;
    }
}