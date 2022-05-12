using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void productCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {   //เเสดงเเจ้งเตือนเมื่อมีปัญหา
            try
            {
                this.Validate();
                this.productCategoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);
            }
            catch (Exception)
            {

                //โชว์ข้อมความปัญหา
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.ProductCategory' table. You can move, or remove it, as needed.
            this.productCategoryTableAdapter.Fill(this.iTshopDBDataSet.ProductCategory);

        }
    }
}
