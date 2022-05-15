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
    public partial class FormPosition : Form
    {
        public FormPosition()
        {
            InitializeComponent();
        }
        private void FormPosition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.JobPosition' table. You can move, or remove it, as needed.
            this.jobPositionTableAdapter.Fill(this.iTshopDB2DataSet.JobPosition);

        }

        private void jobPositionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void jobPositionBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void jobPositionBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {

        }

        private void jobPositionBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.jobPositionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }
    }
}
