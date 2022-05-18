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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProduct());
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMember());

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrder());
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReceipt());
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrint());
        }
    }
}
