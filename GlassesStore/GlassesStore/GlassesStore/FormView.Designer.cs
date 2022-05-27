namespace GlassesStore
{
    partial class FormView
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
            this.View_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.glassesStoreDataSet = new GlassesStore.GlassesStoreDataSet();
            this.orderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orderTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.orderTableAdapter();
            this.orderdetailTableAdapter = new GlassesStore.GlassesStoreDataSetTableAdapters.orderdetailTableAdapter();
            this.view_1TableAdapter1 = new GlassesStore.GlassesStoreDataSet9TableAdapters.View_1TableAdapter();
            this.glassesStoreDataSet91 = new GlassesStore.GlassesStoreDataSet9();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GlassesStoreDataSet3 = new GlassesStore.GlassesStoreDataSet3();
            this.View_perDayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_perDayTableAdapter = new GlassesStore.GlassesStoreDataSet3TableAdapters.View_perDayTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.glassesStoreDataSet91BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.View_OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perDayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet91BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_OrderBindingSource
            // 
            this.View_OrderBindingSource.DataMember = "View_Order";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.glassesStoreDataSet;
            // 
            // glassesStoreDataSet
            // 
            this.glassesStoreDataSet.DataSetName = "GlassesStoreDataSet";
            this.glassesStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderdetailBindingSource
            // 
            this.orderdetailBindingSource.DataMember = "orderdetail";
            this.orderdetailBindingSource.DataSource = this.glassesStoreDataSet;
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
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // orderdetailTableAdapter
            // 
            this.orderdetailTableAdapter.ClearBeforeFill = true;
            // 
            // view_1TableAdapter1
            // 
            this.view_1TableAdapter1.ClearBeforeFill = true;
            // 
            // glassesStoreDataSet91
            // 
            this.glassesStoreDataSet91.DataSetName = "GlassesStoreDataSet9";
            this.glassesStoreDataSet91.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.glassesStoreDataSet91;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.ReportOrder.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 424);
            this.reportViewer1.TabIndex = 2;
            // 
            // glassesStoreDataSet91BindingSource
            // 
            this.glassesStoreDataSet91BindingSource.DataSource = this.glassesStoreDataSet91;
            this.glassesStoreDataSet91BindingSource.Position = 0;
            // 
            // view1BindingSource1
            // 
            this.view1BindingSource1.DataMember = "View_1";
            this.view1BindingSource1.DataSource = this.glassesStoreDataSet91BindingSource;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormView";
            this.Text = "view";
            this.Load += new System.EventHandler(this.FormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlassesStoreDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_perDayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassesStoreDataSet91BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource View_OrderBindingSource;
        private GlassesStoreDataSet9 GlassesStoreDataSet9;
        private GlassesStoreDataSet glassesStoreDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private GlassesStoreDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource orderdetailBindingSource;
        private GlassesStoreDataSetTableAdapters.orderdetailTableAdapter orderdetailTableAdapter;
        private GlassesStoreDataSet9TableAdapters.View_1TableAdapter view_1TableAdapter1;
        private GlassesStoreDataSet9 glassesStoreDataSet91;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private System.Windows.Forms.BindingSource View_perDayBindingSource;
        private GlassesStoreDataSet3 GlassesStoreDataSet3;
        private GlassesStoreDataSet3TableAdapters.View_perDayTableAdapter View_perDayTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource glassesStoreDataSet91BindingSource;
        private System.Windows.Forms.BindingSource view1BindingSource1;
    }
}