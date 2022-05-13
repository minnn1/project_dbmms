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
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }
        public string constr = (@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.iTshopDBDataSet.Receipt);
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDBDataSet.Invoice);

        }
        
        
        public void insert_data()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                string sql_insert = "insert into Receipt(invoiceID,receiptPname,receiptQTY,receiptPrice,receiptTotalPrice,receiptDate) values(@invoiceID,@receiptPname,@receiptQTY,@receiptPrice,@receiptTotalPrice,@receiptDate)";
                SqlCommand cmd = new SqlCommand(sql_insert, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd.Parameters.AddWithValue("@invoiceID", invoiceIDTextBox.Text);
                    cmd.Parameters.AddWithValue("@receiptPname", receiptPnameTextBox.Text);
                    cmd.Parameters.AddWithValue("@receiptQTY", receiptQTYTextBox.Text);
                    cmd.Parameters.AddWithValue("@receiptPrice", receiptPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@receiptTotalPrice", receiptTotalPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@receiptDate", Convert.ToDateTime(receiptDate.Text));
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete_data()
        {

        }
        public void new_date()
        {

        }
        private void invoiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            invoiceIDTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            receiptPnameTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            receiptQTYTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            receiptPriceTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            receiptTotalPriceTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            receiptDate.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            insert_data();
            this.receiptTableAdapter.Fill(this.iTshopDBDataSet.Receipt);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
