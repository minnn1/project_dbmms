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
    public partial class FormLogin1 : Form
    {
        public FormLogin1()
        {
            InitializeComponent();
        }
        private void buttonLoginEmp_Click(object sender, EventArgs e)
        {
            FormLogin2 formLogin2 = new FormLogin2();
            formLogin2.Show();
        }

        private void buttonLoginCus_Click(object sender, EventArgs e)
        {
            FormLoign3 formLoign3 = new FormLoign3();
            formLoign3.Show();
        }
    }
}
