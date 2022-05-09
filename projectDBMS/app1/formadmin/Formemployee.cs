using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace app1
{
    public partial class Formemployee : Form
    {
        public Formemployee()
        {
            InitializeComponent();
        }
        //dbcontext

        private void Formemployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDBDataSet.Employee);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDBDataSet.Employee);
            //load data to gridview

        }
    }
}
