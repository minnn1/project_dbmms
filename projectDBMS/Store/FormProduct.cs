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
        // สร้างdataset
        DataSet ds = new DataSet();
        string strConn = "Data Source=localhost;Initial Catalog=ITshopDB;Integrated Security=True";

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);

        }
        private void LoadProduct()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Product", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Product");
            productDataGridView.DataSource = ds.Tables["Product"];

        }
        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);


        }
        private void productDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
