namespace GlassesStore
{
    partial class ReportperWeek
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
            this.View_perWeekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GlassesStoreDataSet4 = new GlassesStore.GlassesStoreDataSet4();
            this.View_perWeekTableAdapter = new GlassesStore.GlassesStoreDataSet4TableAdapters.View_perWeekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_perWeekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_perWeekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportperWeek.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // View_perWeekBindingSource
            // 
            this.View_perWeekBindingSource.DataMember = "View_perWeek";
            this.View_perWeekBindingSource.DataSource = this.GlassesStoreDataSet4;
            // 
            // GlassesStoreDataSet4
            // 
            this.GlassesStoreDataSet4.DataSetName = "GlassesStoreDataSet4";
            this.GlassesStoreDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_perWeekTableAdapter
            // 
            this.View_perWeekTableAdapter.ClearBeforeFill = true;
            // 
            // ReportperWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReportperWeek";
            this.Text = "FormReportWeek";
            this.Load += new System.EventHandler(this.FormReportperWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_perWeekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource View_perWeekBindingSource;
        private GlassesStoreDataSet4 GlassesStoreDataSet4;
        private GlassesStoreDataSet4TableAdapters.View_perWeekTableAdapter View_perWeekTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}