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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {   //open report
            
            view_OrderTableAdapter1.Fill(GlassesStoreDataSet9.View_Order);
            reportViewer1.RefreshReport();
        }
    }
}
