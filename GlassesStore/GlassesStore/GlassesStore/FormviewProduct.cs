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
    public partial class FormviewProduct : Form
    {
        public FormviewProduct()
        {
            InitializeComponent();
        }

        private void FormviewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GlassesStoreDataSet10.View_product' table. You can move, or remove it, as needed.
            this.View_productTableAdapter.Fill(this.GlassesStoreDataSet10.View_product);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            View_productTableAdapter.FillBy(GlassesStoreDataSet10.View_product, Convert.ToInt32(textBox1.Text));
        }
    }
}
