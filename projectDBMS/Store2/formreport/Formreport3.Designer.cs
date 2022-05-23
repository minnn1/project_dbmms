namespace Store2
{
    partial class Formreport3
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
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ITshopDB2DataSet = new Store2.ITshopDB2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeeTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.EmployeeTableAdapter();
            this.MembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MembersTableAdapter = new Store2.ITshopDB2DataSetTableAdapters.MembersTableAdapter();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITshopDB2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataMember = "Employee";
            this.EmployeeBindingSource.DataSource = this.ITshopDB2DataSet;
            // 
            // ITshopDB2DataSet
            // 
            this.ITshopDB2DataSet.DataSetName = "ITshopDB2DataSet";
            this.ITshopDB2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.membersBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Store2.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // EmployeeTableAdapter
            // 
            this.EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // MembersBindingSource
            // 
            this.MembersBindingSource.DataMember = "Members";
            this.MembersBindingSource.DataSource = this.ITshopDB2DataSet;
            // 
            // MembersTableAdapter
            // 
            this.MembersTableAdapter.ClearBeforeFill = true;
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "Members";
            this.membersBindingSource1.DataSource = this.ITshopDB2DataSet;
            // 
            // Formreport3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formreport3";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Formreport3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ITshopDB2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private ITshopDB2DataSet ITshopDB2DataSet;
        private ITshopDB2DataSetTableAdapters.EmployeeTableAdapter EmployeeTableAdapter;
        private System.Windows.Forms.BindingSource MembersBindingSource;
        private ITshopDB2DataSetTableAdapters.MembersTableAdapter MembersTableAdapter;
        private System.Windows.Forms.BindingSource membersBindingSource1;
    }
}