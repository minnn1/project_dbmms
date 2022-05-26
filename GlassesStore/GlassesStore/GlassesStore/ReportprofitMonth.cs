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
    public partial class ReportprofitMonth : Form
    {
        public ReportprofitMonth()
        {
            InitializeComponent();
        }

        private void ReportprofitMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet7.View_profitMonth' table. You can move, or remove it, as needed.
            this.View_profitMonthTableAdapter.Fill(this.GlassesStoreDataSet7.View_profitMonth);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 12 || Convert.ToInt32(textBox1.Text) ==0)
            {
                MessageBox.Show("Month must be less than 12");
                this.View_profitMonthTableAdapter.Fill(this.GlassesStoreDataSet7.View_profitMonth);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                View_profitMonthTableAdapter.FillBy(GlassesStoreDataSet7.View_profitMonth, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
