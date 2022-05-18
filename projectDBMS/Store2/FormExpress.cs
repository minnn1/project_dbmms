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
    public partial class FormExpress : Form
    {
        public FormExpress()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public int id;
        private void expensesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expensesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void FormExpress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.PurchaseOrder' table. You can move, or remove it, as needed.
            this.purchaseOrderTableAdapter.Fill(this.iTshopDB2DataSet.PurchaseOrder);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.iTshopDB2DataSet.Expenses);

        }

        private void purchaseOrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_PurchaseOrder_idTextBox.Text = purchaseOrderDataGridView.CurrentRow.Cells[0].Value.ToString();
            priceTextBox.Text = purchaseOrderDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //คำนวณเงิน
                string sql = "SELECT SUM([expensesTotalprice]) FROM [Expenses]";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtboxOutputIncome.Text = dt.Rows[0][0].ToString();
                conn.Close();

            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //คำนวณเงิน
                string sql = "SELECT SUM(purchaseorderPrice*purchaseorderQTY) FROM PurchaseOrder";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                expensesTotalpriceTextBox.Text = dt.Rows[0][0].ToString();
                conn.Close();

            }
        }
    }
}
