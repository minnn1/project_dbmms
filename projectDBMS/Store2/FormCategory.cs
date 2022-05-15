using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store2
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.iTshopDB2DataSet.Category);

        }
    }
}
