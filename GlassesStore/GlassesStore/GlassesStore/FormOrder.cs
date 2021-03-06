using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            try
            {
                order_totalpriceSpinEdit.Text = (Convert.ToInt32(order_quantitySpinEdit.Text) * Convert.ToInt32(order_priceSpinEdit.Text)).ToString();
            }
            catch (Exception)
            {
                order_totalpriceSpinEdit.Text = "0";
            }
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
        public void insert_data()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                    string sql_insert = ("insert into [orderdetail]([orderline_id],[order_quantity],[order_totalprice],[orderline_date],[product_id],[order_id],[employee_id])values(@orderline_id,@order_quantity,@order_totalprice,@orderline_date,@product_id,@order_id,@employee_id)");
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);
                    //cmd.Parameters.AddWithValue("@PK_Employee_id", text_employee_id.Text);
                    //cmd.Parameters.AddWithValue(@);
                    cmd.Parameters.AddWithValue("@orderline_id", Convert.ToInt32(orderline_idTextBox.Text));
                    cmd.Parameters.AddWithValue("@order_quantity", Convert.ToInt32(order_quantitySpinEdit.Text));
                    cmd.Parameters.AddWithValue("@order_totalprice", Convert.ToInt32(order_totalpriceSpinEdit.Text));
                    cmd.Parameters.AddWithValue("@orderline_date", orderline_dateDateEdit.Text);
                    cmd.Parameters.AddWithValue("@product_id", product_idSpinEdit.Text);
                    cmd.Parameters.AddWithValue("@order_id", Convert.ToInt32(order_idSpinEdit.Text));
                    cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(employee_idSpinEdit.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                    conn.Close();
                }
                catch
                {
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select [order].order_id, orderdetail.orderline_id, product.product_items, product.product_description, category.category_name, product.product_cost_price,[orderdetail].order_quantity, orderdetail.order_totalprice,[order].order_date from[order] inner join orderdetail on[order].order_id = orderdetail.order_id inner join payment on  payment.payment_id =[order].payment_id inner join product on product.product_id = [orderdetail].product_id inner join  category on category.category_id = product.category_id inner join member on member.member_id =[order].member_id inner join employee on employee.employee_id = orderdetail.employee_id where [order].order_id = '" + order_idSpinEdit.Text + "'", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                DialogResult dialogResult = MessageBox.Show("คำสั่งซื้อของคุณคือ: Order" + dr["order_id"].ToString() + "\n" + "สินค้า: " + dr["product_items"].ToString() + "\n" + "จำนวน " + dr["order_quantity"].ToString() + " ชิ้น " + "\n" + "ราคารวม " + dr["order_totalprice"].ToString() + " บาท");
                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        insert_data();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ยกเลิกการสั่งซื้อเเล้ว");
                    }
                }
            }
            dr.Close();
            //ถ้าตกลงให้บันทึกถ้าไม่ตกลงไม่ต้องบันทึก
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            try
            {
                //reset detailorder
                orderline_idTextBox.Text = "";
                order_quantitySpinEdit.Text = "";
                order_totalpriceSpinEdit.Text = "";
                product_idSpinEdit.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("สามารถเพิ่มรายการสินค้าที่ต้องการเพิ่มเติมได้");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = ( Convert.ToInt32(textBox1.Text)- Convert.ToInt32(order_totalpriceSpinEdit.Text)).ToString();
        }

        private void order_totalpriceSpinEdit_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormView view = new FormView();
            view.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderdetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glassesStoreDataSet);
        }
    }
}
