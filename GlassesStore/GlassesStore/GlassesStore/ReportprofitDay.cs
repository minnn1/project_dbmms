using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassesStore
{
    public partial class ReportprofitDay : Form
    {
        public ReportprofitDay()
        {
            InitializeComponent();
        }

        private void ReportprofitDay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet5.View_profitDay' table. You can move, or remove it, as needed.
            this.View_profitDayTableAdapter.Fill(this.GlassesStoreDataSet5.View_profitDay);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text)==0)
            {
                this.View_profitDayTableAdapter.Fill(this.GlassesStoreDataSet5.View_profitDay);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                View_profitDayTableAdapter.FillBy(GlassesStoreDataSet5.View_profitDay, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
