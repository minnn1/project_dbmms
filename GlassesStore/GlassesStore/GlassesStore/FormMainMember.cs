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
    public partial class FormMainMember : Form
    {
        public FormMainMember()
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
        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new FormviewProduct());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrder());
        }
    }
}
