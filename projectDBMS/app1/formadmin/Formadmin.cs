using System;
using System.Windows.Forms;

namespace app1
{
    public partial class Formadmin : Form
    {
        public Formadmin()
        {
            InitializeComponent();
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //openform4
            Formemployee femp = new Formemployee();
            femp.Show();

        }
    }
}
