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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportperDay reportperDay = new ReportperDay();
            reportperDay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportperMonth reportperMonth = new ReportperMonth();
            reportperMonth.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportperYear reportperYear = new ReportperYear();
            reportperYear.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReportperWeek reportperWeek = new ReportperWeek();
            reportperWeek.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ReportprofitDay reportprofitDay = new ReportprofitDay();
            reportprofitDay.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportprofitWeek reportprofitWeek = new ReportprofitWeek();
            reportprofitWeek.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportprofitMonth reportprofitMonth = new ReportprofitMonth();
            reportprofitMonth.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReportprofitYear reportprofitYear = new ReportprofitYear();
            reportprofitYear.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormviewProduct formviewProduct = new FormviewProduct();
            formviewProduct.Show();
        }
    }
}
