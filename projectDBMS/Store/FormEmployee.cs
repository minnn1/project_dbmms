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
        //string constr = "Data Source=DESKTOP-QK0JI0K;Initial Catalog=Store;Integrated Security=True";
        //public void load_employeejob()
        //{
        //        SqlConnection con = new SqlConnection(constr);
        //    string sql_select = "SELECT JobPosition.jobpositionID , JobPosition.jobpositionName FROM JobPosition";
        //    SqlCommand cmd = new SqlCommand(sql_select, con);
        //    cmd.CommandType = CommandType.Text;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    comboBox1.DataSource = dt;
        //    comboBox1.DisplayMember = "jobpositionName";
        //    comboBox1.ValueMember = "jobpositionID";
        //    con.Open();
        // }
        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception )
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            //load_employeejob();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            jobpositionIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            employeeFNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            employeeLNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void jobPositionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            jobpositionIDTextBox.Text = jobPositionDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
        //when cell click , show data relation  in datagridview1


    }
}
