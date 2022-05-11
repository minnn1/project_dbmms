using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Store
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        SqlDataAdapter resultAdapter1;
        
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.JobPosition' table. You can move, or remove it, as needed.

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee.employeeID, Employee.employeeFName, Employee.employeeLName,JobpoSition.jobpositionName FROM Employee INNER JOIN JobpoSition ON Employee.jobpositionID = JobpoSition.jobpositionID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.JobPosition' table. You can move, or remove it, as needed.
            this.jobPositionTableAdapter.Fill(this.iTshopDBDataSet.JobPosition);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.JobPosition' table. You can move, or remove it, as needed.
            this.jobPositionTableAdapter.Fill(this.iTshopDBDataSet.JobPosition);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.JobPosition' table. You can move, or remove it, as needed.
            this.jobPositionTableAdapter.Fill(this.iTshopDBDataSet.JobPosition);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDBDataSet.Employee);
            //datagridview show query = SELECT Employee.employeeID, Employee.employeeFName, Employee.employeeLName,JobpoSition.jobpositionName FROM Employee INNER JOIN JobpoSition ON Employee.jobpositionID = JobpoSition.jobpositionID;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Employee.employeeID, Employee.employeeFName, Employee.employeeLName,JobpoSition.jobpositionName FROM Employee INNER JOIN JobpoSition ON Employee.jobpositionID = JobpoSition.jobpositionID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //update datagridview
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
