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
    public partial class ReportprofitYear : Form
    {
        public ReportprofitYear()
        {
            InitializeComponent();
        }

        private void ReportprofitYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet8.View_profitYear' table. You can move, or remove it, as needed.
            this.View_profitYearTableAdapter.Fill(this.GlassesStoreDataSet8.View_profitYear);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > 0)
            {
                this.View_profitYearTableAdapter.Fill(this.GlassesStoreDataSet8.View_profitYear);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                View_profitYearTableAdapter.FillBy(GlassesStoreDataSet8.View_profitYear, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
