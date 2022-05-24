using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassesStore
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
            this.tableAdapterManager.UpdateAll(this.glassesStoreDataSet);

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glassesStoreDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.glassesStoreDataSet.category);

        }
    }
}
