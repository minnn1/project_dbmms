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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        
        string constr =(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
        public void insert_date()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_insertdate = "INSERT INTO Invoice(invoiceDate) VALUES (@invoiceDate)";
            SqlCommand cmd = new SqlCommand(sql_insertdate, con);
            cmd.Parameters.AddWithValue("@invoiceDate", Convert.ToDateTime(invoiceDateDateTimePicker.Value));
            cmd.ExecuteNonQuery();
        }
        public void insert_qty()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string sql_insertqty = "INSERT INTO Invoice(invoiceQTY) VALUES (@invoiceQty)";
                SqlCommand cmd = new SqlCommand(sql_insertqty, con);
                cmd.Parameters.AddWithValue("@invoiceQTY", Convert.ToInt32(invoiceQTYTextBox1.Text));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void insert_data()
        {
            try { 
                SqlConnection con = new SqlConnection(constr);
                string sql_insert = "INSERT INTO Invoice(invoiceID,employeeID,productID,memberID,invoicePname,invoicePrice,invoiceTotalPrice) VALUES (@invoiceID,@employeeID,@productID,@memberID,@invoicePname,@invoicePrice,@invoiceTotalPrice)";
                SqlCommand cmd = new SqlCommand(sql_insert, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@invoiceID", invoiceIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@employeeID",employeeIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@productID", productIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@memberID", memberIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@invoicePname", invoicePnameTextBox.Text);
                    cmd.Parameters.AddWithValue("@invoicePrice", invoicePriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@invoiceTotalPrice",invoiceTotalPriceTextBox.Text);
                    //cmd.Parameters.AddWithValue("@invoiceDate", Convert.ToDateTime(invoiceDateDateTimePicker.Value));
                    //datetime insert to daatetime
                    Convert.ToDateTime(invoiceDateDateTimePicker.Value);

                    cmd.ExecuteNonQuery();
                }
            
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDBDataSet.Invoice);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDBDataSet.Invoice);
            //
            datagirdProduct_load();
            datagirdMember_load();
            dataGridEmp_load();

        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
            try
            {
                insert_data();
                insert_date();
                insert_qty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void invoiceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);

        }
        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productIDTextBox.Text = dataGridProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            invoicePriceTextBox.Text = dataGridProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        public void datagirdProduct_load()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Product.[productID],Product.[productName],Product.[productPrice] FROM Product", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridProduct.AutoGenerateColumns = false;
            dataGridProduct.DataSource = dt;
            con.Close();
        }

        private void datagirdMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberIDTextBox.Text = datagirdMember.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        public void datagirdMember_load()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Members.memberID,Members.memberFname FROM Members", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagirdMember.AutoGenerateColumns = false;
            datagirdMember.DataSource = dt;
            con.Close();
        }


        public void dataGridEmp_load()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Employee.employeeID,Employee.employeeFName from Employee inner join JobPosition on JobPosition.jobpositionID = Employee.jobpositionID where JobPosition.jobpositionID = 2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridEmp.AutoGenerateColumns = false;
            dataGridEmp.DataSource = dt;
            con.Close();
        }

        private void dataGridEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeIDTextBox.Text = dataGridEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert_data();
        }

        private void invoiceQTYTextBox1_TextChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt16(invoicePriceTextBox.Text) * Convert.ToInt16(invoiceQTYTextBox1.Text);
            invoiceTotalPriceTextBox.Text = total.ToString();
        }
    }
}
