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

        int updateqty;
        string constr =(@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDBDataSet.Product);

        }
        public void updata_qty()
        {
            try
            {
                updateqty = Convert.ToInt32(textBox1.Text);
                SqlConnection conn = new SqlConnection(constr);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error" +  ex.Message);
            }
        }
    }
}
