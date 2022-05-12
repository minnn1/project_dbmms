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

         public void load_combo_employee()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_select = "SELECT employeeID,employeeFName FROM Employee";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboboxemployee.DataSource = dt;
            comboboxemployee.DisplayMember = "employeeFName";
            comboboxemployee.ValueMember = "employeeID";
        }
        public void load_combo_product()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_select = "SELECT productID,productName FROM Product";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboboxproduct.DataSource = dt;
            comboboxproduct.DisplayMember = "productName";
            comboboxproduct.ValueMember = "productID";
        }
        public void load_combo_member()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_select = "SELECT memberID,memberFname FROM Members";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboboxmember.DataSource = dt;
            comboboxmember.DisplayMember = "memberFname";
            comboboxmember.ValueMember = "memberID";
        }        


       private void insert_data()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_insert = "INSERT INTO Invoice(,employeeID,productID,memberID,invoicePname,invoiceQTY,invoicePrice,invoiceTotalPrice,invoiceDate) VALUES (@employeeID,@productID,@memberID,@invoicePname,@invoiceQTY,@invoicePrice,@invoiceTotalPrice,@invoiceDate)";
            SqlCommand cmd = new SqlCommand(sql_insert, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                cmd.Parameters.AddWithValue("@employeeID", comboboxemployee.SelectedValue);
                cmd.Parameters.AddWithValue("@productID", comboboxproduct.SelectedValue);
                cmd.Parameters.AddWithValue("@memberID", comboboxmember.SelectedValue);
                cmd.Parameters.AddWithValue("@invoicePname", invoicePnameTextBox.Text);
                cmd.Parameters.AddWithValue("@invoiceQTY", invoiceQTYTextBox.Text);
                cmd.Parameters.AddWithValue("@invoicePrice", invoicePriceTextBox.Text);
                cmd.Parameters.AddWithValue("@invoiceTotalPrice", invoiceTotalPriceTextBox.Text);
                cmd.Parameters.AddWithValue("@invoiceDate", invoiceDateDateTimePicker.Text);
                cmd.ExecuteNonQuery();

            }
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            load_combo_employee();
            load_combo_product();
            load_combo_member();
            load_data_datagrid();
        }
        public void load_data_datagrid()
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_select = "SELECT Invoice.invoiceID ,Invoice.invoicePname,Employee.employeeFName,Members.memberFname,Product.productName,Invoice.invoiceQTY ,Invoice.invoicePrice,Invoice.invoiceTotalPrice,Invoice.invoiceDate FROM Invoice INNER JOIN Employee ON Employee.employeeID = Invoice.employeeID INNER JOIN Product ON Product.productID = Invoice.invoiceID  INNER JOIN Members ON Members.memberID = Invoice.memberID";
                SqlCommand cmd_select = new SqlCommand(sql_select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd_select);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboboxemployee.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboboxmember.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboboxproduct.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            invoicePnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            invoiceQTYTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            invoicePriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            invoiceTotalPriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            invoiceDateDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
        }

        private void invoicePriceTextBox_TextChanged(object sender, EventArgs e)
        {
            //invoice price = product price
            //SELECT Invoice.invoicePrice,Product.productPrice from Invoice inner join Product on Invoice.productID = Product.productID;
            SqlConnection con = new SqlConnection(constr);
            invoicePriceTextBox.Text = "";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_select = "SELECT Invoice.invoicePrice,Product.productPrice from Invoice inner join Product on Invoice.productID = Product.productID where Invoice.productID = '" + comboboxproduct.SelectedValue + "'";
                invoicePriceTextBox.Text = sql_select.ToString();
                SqlCommand cmd_select = new SqlCommand(sql_select, con);
                SqlDataReader dr = cmd_select.ExecuteReader();
                if (dr.Read())
                {
                    invoicePriceTextBox.Text = dr["productPrice"].ToString();
                }
            }
        }
    }
}
