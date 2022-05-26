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
    public partial class ReportperYear : Form
    {
        public ReportperYear()
        {
            InitializeComponent();
        }

        private void ReportperYear_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet2.View_perYear' table. You can move, or remove it, as needed.
            this.View_perYearTableAdapter.Fill(this.GlassesStoreDataSet2.View_perYear);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text)==0)
            {
                this.View_perYearTableAdapter.Fill(this.GlassesStoreDataSet2.View_perYear);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                this.View_perYearTableAdapter.FillBy(this.GlassesStoreDataSet2.View_perYear, Convert.ToInt32(textBox1.Text));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
