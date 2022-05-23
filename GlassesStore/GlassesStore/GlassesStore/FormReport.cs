using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Reporting.WinForms;

namespace GlassesStore
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ดึงข้อมูลจากฐานข้อมูลมาเเสดงในreportviewer
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from product", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            reportViewer1.RefreshReport();
            
        }
    }
}
