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
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }
        
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
            if(textBox1.Text == null)
            {
                view_1TableAdapter1.Fill(glassesStoreDataSet91.View_1);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                try
                {
                    view_1TableAdapter1.FillBy(glassesStoreDataSet91.View_1, Convert.ToInt32(textBox1.Text));
                    this.reportViewer1.RefreshReport();
                }
                catch(Exception ex)
                {
                    view_1TableAdapter1.Fill(glassesStoreDataSet91.View_1);
                    this.reportViewer1.RefreshReport();
                }
            }
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            view_1TableAdapter1.Fill(glassesStoreDataSet91.View_1);
            this.reportViewer1.RefreshReport();
        }
    }
}
