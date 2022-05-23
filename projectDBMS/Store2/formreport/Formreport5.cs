using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store2
{
    public partial class Formreport5 : Form
    {
        public Formreport5()
        {
            InitializeComponent();
        }

        private void Formreport5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ITshopDB2DataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.ITshopDB2DataSet.Receipt);
            // TODO: This line of code loads data into the 'ITshopDB2DataSet.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.ITshopDB2DataSet.Employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
