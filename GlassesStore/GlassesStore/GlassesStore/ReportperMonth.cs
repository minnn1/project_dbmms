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
    public partial class ReportperMonth : Form
    {
        public ReportperMonth()
        {
            InitializeComponent();
        }

        private void ReportperMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet1.View_permonth' table. You can move, or remove it, as needed.
            this.View_permonthTableAdapter.Fill(this.GlassesStoreDataSet1.View_permonth);

            this.reportViewer1.RefreshReport();
        }
    }
}
