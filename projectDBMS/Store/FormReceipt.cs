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
            // TODO: This line of code loads data into the 'iTshopDBDataSet1.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDBDataSet1.Invoice);
            // TODO: This line of code loads data into the 'iTshopDBDataSet1.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.iTshopDBDataSet1.Receipt);
            // TODO: This line of code loads data into the 'iTshopDBDataSet1.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.iTshopDBDataSet1.Receipt);
            //loaddatagrid
            datagirdvie1_load();
        }
        public void insert_data()
        {
           
        }
        public int id;

        private void receiptBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.receiptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet1);
        }
        private void receiptBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.receiptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet1);
            datagirdvie1_load();

        }

        private void invoiceDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            receiptIDTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            receiptPnameTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            receiptQTYTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            receiptPriceTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            receiptTotalPriceTextBox.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            receiptDateDateTimePicker.Text = invoiceDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        public void datagirdvie1_load()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Receipt.receiptID,Product.productName,Receipt.receiptQTY,Receipt.receiptPrice,Receipt.receiptTotalPrice,Receipt.receiptDate from Receipt inner join Invoice on Receipt.receiptID = Invoice.invoiceID inner join Product on Product.productID = Invoice.productID order by Receipt.receiptID;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receiptIDTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            receiptPnameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            receiptQTYTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            receiptPriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            receiptTotalPriceTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            receiptDateDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //delete_data2();
        }
        public void delete_data2()
        {
                SqlConnection con = new SqlConnection(constr);
                //delete
                //string sql_insert = "INSERT INTO Product(productcategoryID,productName,productPrice,productInventory) VALUES (@productcategoryID,@productName,@productPrice,@productInventory)";

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string sql_delete = "DELETE FROM Receipt WHERE receiptID = @receiptID";
                    SqlCommand cmd = new SqlCommand(sql_delete, con);
                    cmd.Parameters.AddWithValue("@receiptID", id);
                    cmd.ExecuteNonQuery();
                datagirdvie1_load();

            }
        }
    }
}
