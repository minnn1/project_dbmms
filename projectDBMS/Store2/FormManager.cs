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
    public partial class FormManager : Form
    {
        public FormManager()
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
            panel1.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmployee());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProduct());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMember());

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategory());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrder());
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormReceipt());
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPurchaseRequisition());
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrint());
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPurchaseOrder());
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            openChildForm(new FormExpress());

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            openChildForm(new FormIncome());
        }
    }
}
