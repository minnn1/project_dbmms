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
    public partial class FormIncome : Form
    {
        public FormIncome()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public int id;
        public void calculate() 
        {
            //คำนวณหารายได้ทั้งหมด
            SqlConnection conn = new SqlConnection(constring);


        }        
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //คำนวณเงิน
                string sql = "SELECT SUM(incomeTotalprice) FROM Income";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtboxOutputIncome.Text = dt.Rows[0][0].ToString();
                conn.Close();

            }
        }

        private void FormIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDB2DataSet.Invoice);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Income' table. You can move, or remove it, as needed.
            this.incomeTableAdapter.Fill(this.iTshopDB2DataSet.Income);
             
        }

        private void incomeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incomeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void invoiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Invoice_idTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            incomeTotalpriceTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            incomeDateDateTimePicker.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void pK_Income_idTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
