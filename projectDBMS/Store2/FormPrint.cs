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

namespace Store2
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
    
        private void buttonExport_Click(object sender, EventArgs e)
        {
   
        }
        private void button1_Click(object sender, EventArgs e)
        {   //เมื่อกดปุ่มนี้จะโหลดข้อมูลที่เรากรอกไว้ในtextbox เข้าไปในdatagridview
            //ให้ join ข้อมูล เมื่อcheckbox มีหลายอัน

            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = textsqlcommand.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }
        private void textsqlcommand_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //เมื่อcheckให้โหลด employee ลงในdatagrid view
            if (checkBox1.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT Employee.PK_Employee_id,JobPosition.jobpositionName,Employee.employeeFName,Employee.employeeLName FROM Employee INNER JOIN JobPosition ON Employee.FK_JobPosition_id = JobPosition.PK_JobPosition_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) 
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Product";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT * FROM Members";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
