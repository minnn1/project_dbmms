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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        public string constr = (@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
        public void load_category()
        {

            SqlConnection con = new SqlConnection(constr);
            string sql_select = "SELECT productcategoryID,productcategoryName FROM ProductCategory";
            SqlCommand cmd = new SqlCommand(sql_select, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            productcategorycombobox.DataSource = dt;
            productcategorycombobox.DisplayMember = "productcategoryName";
            productcategorycombobox.ValueMember = "productcategoryID";
            con.Open();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);
            load_category();
            load_data_datagrid();
        }
        public void clear_data()
        {
            productInventoryTextBox.Text = "";
            productNameTextBox.Text = "";
            productPriceTextBox.Text = "";
            productcategorycombobox.SelectedValue = 0;

        }
        public void load_data_datagrid()
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_select = "select Product.productID,ProductCategory.productcategoryName,Product.productName,Product.productPrice,Product.productInventory  fROM Product INNER JOIN ProductCategory on Product.productcategoryID = ProductCategory.productcategoryID order by productcategoryName";
                SqlCommand cmd_select = new SqlCommand(sql_select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd_select);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;

            }

        }
        public void delete_data()
        {
            SqlConnection con = new SqlConnection(constr);
            //delete
            //string sql_insert = "INSERT INTO Product(productcategoryID,productName,productPrice,productInventory) VALUES (@productcategoryID,@productName,@productPrice,@productInventory)";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_delete = "DELETE FROM Product WHERE productID = @productID";
                SqlCommand cmd = new SqlCommand(sql_delete, con);
                cmd.Parameters.AddWithValue("@productID", id);
                cmd.ExecuteNonQuery();


            }
        }
        private void insert_data()
        {
            SqlConnection con = new SqlConnection(constr);
            string sql_insert = "INSERT INTO Product(productcategoryID,productName,productPrice,productInventory) VALUES (@productcategoryID,@productName,@productPrice,@productInventory)";
            SqlCommand cmd = new SqlCommand(sql_insert, con);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

                cmd.Parameters.AddWithValue("@productcategoryID", productcategorycombobox.SelectedValue);
                cmd.Parameters.AddWithValue("@productName", productNameTextBox.Text);
                cmd.Parameters.AddWithValue("@productPrice", productPriceTextBox.Text);
                cmd.Parameters.AddWithValue("@productInventory", productInventoryTextBox.Text);
                cmd.ExecuteNonQuery();

            }

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            insert_data();
            clear_data();
            load_category();
            load_data_datagrid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete_data();
            load_data_datagrid();
            clear_data();
            

        }
        public int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //เมื่อคลิกที่cell จะนำข้อมูลไปเเสดงที่ combobox เเละ  texbox
            // productcategorycombobox.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            productNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            productPriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            productInventoryTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            btninsert.Enabled = false;
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            btnnew.Visible = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnnew.Visible = false;
            btninsert.Enabled = true;
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            clear_data();
            load_category();
        }
        public void edit_data()
        {
            SqlConnection con = new SqlConnection(constr);
           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_update = "UPDATE Product SET  productName = @productName,productPrice = @productPrice,productInventory = @productInventory WHERE productID = @productID";
                SqlCommand cmd = new SqlCommand(sql_update, con);
                cmd.Parameters.AddWithValue("@productName", productNameTextBox.Text);
                cmd.Parameters.AddWithValue("@productPrice", productPriceTextBox.Text);
                cmd.Parameters.AddWithValue("@productInventory", productInventoryTextBox.Text);
                cmd.Parameters.AddWithValue("@productID", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit_data();
            clear_data();
            load_data_datagrid();
            load_category();
        }

        public void search_data()
        {
            SqlConnection con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                string sql_search = "select Product.productID,ProductCategory.productcategoryName,Product.productName,Product.productPrice,Product.productInventory  fROM Product INNER JOIN ProductCategory on Product.productcategoryID = ProductCategory.productcategoryID where productName like '" + textBox1.Text + "%'";
                SqlCommand cmd_search = new SqlCommand(sql_search, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd_search);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            load_data_datagrid();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search_data();
        }
    }
}
