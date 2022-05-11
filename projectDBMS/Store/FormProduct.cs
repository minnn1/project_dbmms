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
            using (ITshopDBEntities db = new ITshopDBEntities())
            {
                productBindingSource.DataSource = db.Products.ToList();
                productCategoryBindingSource.DataSource = db.ProductCategories.ToList();
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
        }
    }
}
