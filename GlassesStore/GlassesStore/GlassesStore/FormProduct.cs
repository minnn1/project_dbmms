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

namespace GlassesStore
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";
        public int id;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glassesStoreDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.glassesStoreDataSet.category);
            // TODO: This line of code loads data into the 'glassesStoreDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.glassesStoreDataSet.product);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glassesStoreDataSet);

        }

        private void categoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            category_idSpinEdit.Text = categoryDataGridView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
