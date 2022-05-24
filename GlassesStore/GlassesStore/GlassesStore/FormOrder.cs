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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";
        public void product_datagridview_load()
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select product_id,product_items,product_description,product_cost_price,product_quantity,category.category_name from product inner join category on product.category_id = category.category_id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            productDataGridView.DataSource = dt;
            con.Close();
        }
       
        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glassesStoreDataSet);
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glassesStoreDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.glassesStoreDataSet.employee);
            // TODO: This line of code loads data into the 'glassesStoreDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.glassesStoreDataSet.product);
            // TODO: This line of code loads data into the 'glassesStoreDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.glassesStoreDataSet.member);
            // TODO: This line of code loads data into the 'glassesStoreDataSet.orderdetail' table. You can move, or remove it, as needed.
            this.orderdetailTableAdapter.Fill(this.glassesStoreDataSet.orderdetail);
            // TODO: This line of code loads data into the 'glassesStoreDataSet.order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.glassesStoreDataSet.order);
            order_dateDateEdit.DateTime = DateTime.Now;
            product_datagridview_load();
        }

        private void order_idSpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            order_idSpinEdit1.Text = order_idSpinEdit.Text;
        }

        private void order_dateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
            orderline_dateDateEdit.Text = order_dateDateEdit.Text;
        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            product_idSpinEdit.Text = productDataGridView.CurrentRow.Cells[0].Value.ToString();
            order_priceSpinEdit.Text = productDataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void order_quantitySpinEdit_EditValueChanged(object sender, EventArgs e)
        {
            order_totalpriceSpinEdit.Text = (Convert.ToInt32(order_quantitySpinEdit.Text) * Convert.ToInt32(order_priceSpinEdit.Text)).ToString();
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            employee_idSpinEdit.Text = employeeDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select [payment_id] from payment where payment_id = '" + payment_idSpinEdit.Text + "'", con);
            payment_idSpinEdit.Text = Convert.ToInt32("1").ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select [payment_id] from payment where payment_id = '" + payment_idSpinEdit.Text + "'", con);
            payment_idSpinEdit.Text = Convert.ToInt32("2").ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select [payment_id] from payment where payment_id = '" + payment_idSpinEdit.Text + "'", con);
            payment_idSpinEdit.Text = Convert.ToInt32("3").ToString();
        }

        private void memberDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            member_idSpinEdit.Text = memberDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            //orderdetial save
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select [order].order_id,orderdetail.orderline_id,product.product_items,product.product_description,category.category_name,product.product_cost_price,[orderdetail].order_quantity,orderdetail.order_totalprice,[order].order_date from [order] inner join orderdetail on[order].order_id = orderdetail.order_id inner join payment on  payment.payment_id =[order].payment_id inner join product on product.product_id = [orderdetail].product_id inner join  category on category.category_id = product.category_id inner join member on member.member_id =[order].member_id inner join employee on employee.employee_id = orderdetail.employee_id where [order].order_id =" + order_idSpinEdit.Text, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                DialogResult dialogResult= MessageBox.Show("คำสั่งซื้อของคุณคือ: Order" + dr["order_id"].ToString() + "\n" + "สินค้า: " + dr["product_items"].ToString() + "\n" + "จำนวน " + dr["order_quantity"].ToString() + " ชิ้น " + "\n" + "ราคารวม " + dr["order_totalprice"].ToString() + " บาท");
                if (dialogResult == DialogResult.OK)
                {
                    SqlConnection con1 = new SqlConnection(constring);
                    con1.Open();
                    SqlCommand cmd = new SqlCommand("insert into orderdetail(orderline_id,order_quantity,order_totalprice,orderline_date,product_id,order_id,employee_id) values(@orderline_id,@order_quantity,@order_totalprice,@orderline_date,@product_id,@order_id,@employee_id)", con1);
                    cmd.Parameters.AddWithValue("@orderline_id", orderline_idSpinEdit.Text);
                    cmd.Parameters.AddWithValue("@order_quantity", order_quantitySpinEdit.Text);
                    cmd.Parameters.AddWithValue("@order_totalprice", order_totalpriceSpinEdit.Text);
                    cmd.Parameters.AddWithValue("@orderline_date", Convert.ToDateTime(orderline_dateDateEdit.Text));
                    cmd.Parameters.AddWithValue("@product_id", product_idSpinEdit.Text);
                    cmd.Parameters.AddWithValue("@order_id", order_idSpinEdit.Text);
                    cmd.Parameters.AddWithValue("@employee_id", employee_idSpinEdit.Text);
                    cmd.ExecuteNonQuery();
                    
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    //do something else
                }
            }
            dr.Close();
            //ถ้าตกลงให้บันทึกถ้าไม่ตกลงไม่ต้องบันทึก
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //reset detailorder
            orderline_idSpinEdit.Text = "";
            order_quantitySpinEdit.Text = "";
            order_totalpriceSpinEdit.Text = "";
            product_idSpinEdit.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(constring);
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("select [order].order_id,orderdetail.orderline_id,product.product_items,product.product_description,category.category_name,product.product_cost_price,[orderdetail].order_quantity,orderdetail.order_totalprice,[order].order_date from [order] inner join orderdetail on[order].order_id = orderdetail.order_id inner join payment on  payment.payment_id =[order].payment_id inner join product on product.product_id = [orderdetail].product_id inner join  category on category.category_id = product.category_id inner join member on member.member_id =[order].member_id inner join employee on employee.employee_id = orderdetail.employee_id where [order].order_id =" + order_idSpinEdit.Text , con1);
            SqlDataReader dr = cmd1.ExecuteReader();
           
            while (dr.Read())
            {
                MessageBox.Show("คำสั่งซื้อของคุณคือ: Order"+ dr["order_id"].ToString()+ "\n" + "สินค้า: "+ dr["product_items"].ToString() + "\n" + "จำนวน " + dr["order_quantity"].ToString() +  " ชิ้น "+ "\n" + "ราคารวม " + dr["order_totalprice"].ToString() + " บาท");
            }
            MessageBox.Show("ยืนยันคำสั่งซื้อ", "รายการสั่งซื้อ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
