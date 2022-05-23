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
    public partial class Formreport2 : Form
    {
        public Formreport2()
        {
            InitializeComponent();
        }

        private void Formreport2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ITshopDB2DataSet.Employee' table. You can move, or remove it, as needed.
            this.EmployeeTableAdapter.Fill(this.ITshopDB2DataSet.Employee);
            // TODO: This line of code loads data into the 'ITshopDB2DataSet.Product' table. You can move, or remove it, as needed.
            this.ProductTableAdapter.Fill(this.ITshopDB2DataSet.Product);

            this.reportViewer1.RefreshReport();
        }
    }
}
