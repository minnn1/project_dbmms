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
    public partial class FormPurchaseRequisition : Form
    {
        public FormPurchaseRequisition()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public int id;
        public void datagridproduct_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "select Product.PK_Product_id,Category.categoryName, Product.productName, Product.productPrice, Product.productInventory from Product inner join Category on Product.FK_Category_id = Category.PK_Category_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduct.AutoGenerateColumns = false;
                dataGridProduct.DataSource = dt;
                conn.Close();
            }
        }
        public void datagridemp_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "select Employee.PK_Employee_id ,JobPosition.jobpositionName ,Employee.employeeFName,Employee.employeeLName from Employee inner join JobPosition on Employee.FK_JobPosition_id = JobPosition.PK_JobPosition_id where JobPosition.PK_JobPosition_id = 5";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid_Employee.AutoGenerateColumns = false;
                dataGrid_Employee.DataSource = dt;
                conn.Close();
            }
        }
        private void purchaseRequisitionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseRequisitionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void FormPurchaseRequisition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDB2DataSet.Employee);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDB2DataSet.Product);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.PurchaseRequisition' table. You can move, or remove it, as needed.
            this.purchaseRequisitionTableAdapter.Fill(this.iTshopDB2DataSet.PurchaseRequisition);
            //load data into datagrid
            datagridemp_load();
            datagridproduct_load();

        }

        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Employee_IDTextBox.Text = dataGrid_Employee.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Product_IDTextBox.Text = dataGridProduct.CurrentRow.Cells[0].Value.ToString();
            purchaserequisitionNameTextBox.Text = dataGridProduct.CurrentRow.Cells[1].Value.ToString() ;
            purchaserequisitionPriceTextBox.Text = dataGridProduct.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
