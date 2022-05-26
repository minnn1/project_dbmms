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
    }
}
