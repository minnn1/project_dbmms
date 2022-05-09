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

     

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDBDataSet.Employee);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDBDataSet.Employee);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.ProductCategory' table. You can move, or remove it, as needed.
            this.productCategoryTableAdapter.Fill(this.iTshopDBDataSet.ProductCategory);

            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ProductCategory.productcategoryName,Product.productID, Product.productName, Product.productPrice,Product.productInventory FROM Product INNER JOIN ProductCategory ON Product.productcategoryID = ProductCategory.productcategoryID ORDER  by ProductCategory.productcategoryName; ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //update datagridview


        }

        private void productCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT ProductCategory.productcategoryName,Product.productID, Product.productName, Product.productPrice,Product.productInventory FROM Product INNER JOIN ProductCategory ON Product.productcategoryID = ProductCategory.productcategoryID ORDER  by ProductCategory.productcategoryName; ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //addnewitem
            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            con.Open();
            string query = "INSERT INTO ProductCategory VALUES ('" + productcategoryIDTextBox1.Text + "','" + productcategoryNameTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
