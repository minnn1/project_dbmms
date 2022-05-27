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
    public partial class ReportperDay : Form
    {
        public ReportperDay()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";
        public void load()
        {
            //reportviewer เชื่มsqlcommand
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT DATEPART(Year, [order].order_date) ปี,DATEPART(MONTH,[order].order_date)เดือน,SUM(orderdetail.order_totalprice) ยอดรายรวมรายเดือน FROM[order] inner join orderdetail on[order].order_id = orderdetail.order_id GROUP BY DATEPART(Year, [order].order_date), DATEPART(MONTH,[order].order_date) ORDER BY ปี, เดือน", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            reportViewer1.LocalReport.ReportEmbeddedResource = "GlassesStore.Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }
        
        private void ReportperDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet3.View_perDay' table. You can move, or remove it, as needed.
            this.View_perDayTableAdapter.Fill(this.GlassesStoreDataSet3.View_perDay);
            //report per day
            this.reportViewer1.RefreshReport();



            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.View_perDayTableAdapter.Fill(this.GlassesStoreDataSet3.View_perDay);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                try
                {
                    this.View_perDayTableAdapter.FillBy(this.GlassesStoreDataSet3.View_perDay, Convert.ToInt32(textBox1.Text));
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    this.View_perDayTableAdapter.Fill(this.GlassesStoreDataSet3.View_perDay);
                    this.reportViewer1.RefreshReport();
                }
            }           
        }
    }
}
