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


namespace GlassesStore
{
    public partial class ReportperWeek : Form
    {
        public ReportperWeek()
        {
            InitializeComponent();
        }

        private void FormReportperWeek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet4.View_perWeek' table. You can move, or remove it, as needed.
            this.View_perWeekTableAdapter.Fill(this.GlassesStoreDataSet4.View_perWeek);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ค้นหา@id
            this.View_perWeekTableAdapter.FillBy(this.GlassesStoreDataSet4.View_perWeek,Convert.ToInt32(textBox1.Text));
            this.reportViewer1.RefreshReport();
            if (Convert.ToInt32(textBox1.Text) == 0)
            {
                this.View_perWeekTableAdapter.Fill(this.GlassesStoreDataSet4.View_perWeek);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.View_perWeekTableAdapter.FillBy(this.GlassesStoreDataSet4.View_perWeek, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }


        }
    }
}
