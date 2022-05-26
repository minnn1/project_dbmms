using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace GlassesStore
{
    public partial class FormOrderview : Form
    {
        public FormOrderview()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";

        private void FormOrderview_Load(object sender, EventArgs e)
        {
 

        }

        private void order_idSpinEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            //คำสั่งคิวรี่
            SqlCommand sql = new SqlCommand("select [order].order_id,orderdetail.orderline_id,product.product_items,product.product_description,category.category_name,product.product_cost_price,[orderdetail].order_quantity,orderdetail.order_totalprice,[order].order_date from [order] inner join orderdetail on[order].order_id = orderdetail.order_id inner join payment on  payment.payment_id =[order].payment_id inner join product on product.product_id = [orderdetail].product_id inner join  category on category.category_id = product.category_id inner join member on member.member_id =[order].member_id inner join employee on employee.employee_id = orderdetail.employee_id where [order].order_id = '" + order_idSpinEdit.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridview1.DataSource = dt;
            con.Close();
        }

        private void datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //read only
            datagridview1.ReadOnly = true;
            
        }
    }
}
