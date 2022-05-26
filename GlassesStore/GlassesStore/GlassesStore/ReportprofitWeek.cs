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
    public partial class ReportprofitWeek : Form
    {
        public ReportprofitWeek()
        {
            InitializeComponent();
        }

        private void ReportprofitWeek_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet6.View_profitWeek' table. You can move, or remove it, as needed.
            this.View_profitWeekTableAdapter.Fill(this.GlassesStoreDataSet6.View_profitWeek);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == 0)
            {
                this.View_profitWeekTableAdapter.Fill(this.GlassesStoreDataSet6.View_profitWeek);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                View_profitWeekTableAdapter.FillBy(GlassesStoreDataSet6.View_profitWeek, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
