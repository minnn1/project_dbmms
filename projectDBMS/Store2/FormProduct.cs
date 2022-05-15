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

namespace Store2
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public int id;
        //ส่วนเพิ่มลบข้อมูล ลง database
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void insert_data()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql_insert = "insert into Product(FK_Category_id,productName,productPrice,productInventory) values(@FK_Category_id,@productName,@productPrice,@productInventory);";
                SqlCommand cmd = new SqlCommand(sql_insert, conn);
                //cmd.Parameters.AddWithValue("@PK_Employee_id", text_employee_id.Text);
                cmd.Parameters.AddWithValue("@FK_Category_id", comboBoxCatagory.SelectedValue);//add value to combobox
                cmd.Parameters.AddWithValue("@productName", textBoxProductName.Text);
                cmd.Parameters.AddWithValue("@productPrice", textBoxProductPrice.Text);
                cmd.Parameters.AddWithValue("@productInventory", textBoxQTY.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว");
                conn.Close();
            }
        }
        public void delete_data()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลลำดับที่" + id + "นี้หรือไม่ ?", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (id != 0 || id != null)
                    {
                        string sql_delete = "delete from Product where PK_Product_id=@PK_Product_id;";
                        SqlCommand cmd = new SqlCommand(sql_delete, conn);
                        cmd.Parameters.AddWithValue("@PK_Product_id", id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว");
                        clear();
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("ยกเลิกการลบข้อมูล");
                }
            }
        }
        public void update_data()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                if (textBoxProductName.Text != "" && textBoxProductPrice.Text != ""&&textBoxQTY.Text!="")
                {
                    string sql_update = "update Product set FK_Category_id=@FK_Category_id,productName=@productName,productPrice=@productPrice,productInventory=@productInventory where PK_Product_id=@PK_Product_id;";
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    cmd.Parameters.AddWithValue("@PK_Product_id", id);
                    cmd.Parameters.AddWithValue("@FK_Category_id", comboBoxCatagory.SelectedValue);//add value to combobox
                    cmd.Parameters.AddWithValue("@productName", textBoxProductName.Text);
                    cmd.Parameters.AddWithValue("@productPrice", textBoxProductPrice.Text);
                    cmd.Parameters.AddWithValue("@productInventory", textBoxQTY.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                    clear();
                    combobox_category_load();
                    conn.Close();
                }
            }
        }
        public void serch_data()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql_search = "select Product.PK_Product_id, Product.productName,Category.categoryName,Product.productPrice,Product.productInventory from Product inner join Category on Product.FK_Category_id = Category.PK_Category_id where(productName like '%" + textSearch.Text + "%')";
                SqlCommand cmd = new SqlCommand(sql_search, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridProduct.AutoGenerateColumns = false;
                dataGridProduct.DataSource = dt;
                conn.Close();
            }
        }
        public void clear()
        {
            comboBoxCatagory.SelectedValue = -1;
            textBoxProductName.Text = "";
            textBoxProductPrice.Text = "";
            textBoxQTY.Text = "";
        }
        //ส่วนload_data ต่างๆ
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void combobox_category_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "select Category.PK_Category_id, Category.categoryName from Category";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                /////ใส่ข้อมูลลงใน combobox
                comboBoxCatagory.DataSource = dt;
                comboBoxCatagory.DisplayMember = "categoryName";
                comboBoxCatagory.ValueMember = "PK_Category_id";
                conn.Close();
            }
        }
        public void datagrid_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "select Product.PK_Product_id,Category.categoryName, Product.productName, Product.productPrice, Product.productInventory from Product inner join Category on Product.FK_Category_id = Category.PK_Category_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridProduct.AutoGenerateColumns = false;
                dataGridProduct.DataSource = dt;
                conn.Close();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insert_data();
            clear();
            combobox_category_load();
            datagrid_load();
        }

        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridProduct.Rows[e.RowIndex].Cells[0].Value);
            //comboBox_Jobposition_id.SelectedValue = dataGrid_Employee.Rows[e.RowIndex].Cells[1].Value;
            textBoxProductName.Text = dataGridProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxProductPrice.Text = dataGridProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxQTY.Text = dataGridProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            clear();
            datagrid_load();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            delete_data();
            datagrid_load();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            update_data();
            datagrid_load();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            serch_data();
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            combobox_category_load();
            datagrid_load();
        }
    }
}
