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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
            public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
            public int id;
            int qty;
            int price;
        //ส่วนเพิ่มลบข้อมูล ลง database
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void insert_data()
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql_insert = "insert into Invoice(FK_Product_id,FK_Members_id,FK_Employee_id,invoicePname,invoiceQTY,invoicePrice,invoiceTotalPrice,invoiceDate) values(@FK_Product_id,@FK_Members_id,@FK_Employee_id,@invoicePname,@invoiceQTY,@invoicePrice,@invoiceTotalPrice,@invoiceDate)";
                    SqlCommand cmd = new SqlCommand(sql_insert, conn);
                //cmd.Parameters.AddWithValue("@PK_Employee_id", text_employee_id.Text);
                cmd.Parameters.AddWithValue("@FK_Product_id", textBox_Product.Text);
                cmd.Parameters.AddWithValue("@FK_Members_id", comboBox_Member.SelectedValue);
                cmd.Parameters.AddWithValue("@FK_Employee_id", comboBox_Employee.SelectedValue);
                cmd.Parameters.AddWithValue("@invoicePname", text_invoicePname.Text);
                cmd.Parameters.AddWithValue("@invoiceQTY", text_invoiceQTY.Text);
                cmd.Parameters.AddWithValue("@invoicePrice", textBoxinvoicePrice.Text);
                cmd.Parameters.AddWithValue("@invoiceTotalPrice", textBoxinvoiceTotalPrice.Text);
                cmd.Parameters.AddWithValue("@invoiceDate",dateTimePicker_invoiceDate.Value);
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
                            string sql_delete = "delete from Invoice where PK_Invoice_id=@PK_Invoice_id;";
                            SqlCommand cmd = new SqlCommand(sql_delete, conn);
                            cmd.Parameters.AddWithValue("@[PK_Invoice_id]", id);
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
                    if (text_invoicePname.Text != "" && text_invoiceQTY.Text != "")
                    {
                        string sql_update = "update Invoice set FK_Product_id=@FK_Product_id,FK_Members_id=@FK_Members_id,FK_Employee_id=@FK_Employee_id,invoicePname=@invoicePname,invoiceQTY=@invoiceQTY,invoicePrice=@invoicePrice,invoiceTotalPrice=@invoiceTotalPrice,invoiceDate=@invoiceDate where PK_Invoice_id=@PK_Invoice_id";
                        SqlCommand cmd = new SqlCommand(sql_update, conn);
                        cmd.Parameters.AddWithValue("@PK_Invoice_id", id);
                        cmd.Parameters.AddWithValue("@FK_Product_id", textBox_Product.Text);
                        cmd.Parameters.AddWithValue("@FK_Members_id", comboBox_Member.SelectedValue);
                        cmd.Parameters.AddWithValue("@FK_Employee_id", comboBox_Employee.SelectedValue);
                        cmd.Parameters.AddWithValue("@invoicePname", text_invoicePname.Text);
                        cmd.Parameters.AddWithValue("@invoiceQTY", text_invoiceQTY.Text);
                        cmd.Parameters.AddWithValue("@invoicePrice", textBoxinvoicePrice.Text);
                        cmd.Parameters.AddWithValue("@invoiceTotalPrice", textBoxinvoiceTotalPrice.Text);
                        cmd.Parameters.AddWithValue("@invoiceDate", dateTimePicker_invoiceDate.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                        clear();
                        comboBox_Employee_load();
                        comboBox_Member_load();
                        //comboBox_Product_load();
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
                    string sql_serch = "select A.PK_Invoice_id,B.productName,C.memberFname,D.employeeFName,A.invoicePname,A.invoiceQTY,A.invoicePrice,A.invoiceTotalPrice,A.invoiceDate from Invoice as A  INNER JOIN Product AS B ON B.PK_Product_id = A.FK_Product_id INNER JOIN Members AS C ON C.PK_Members_id = A.FK_Members_id INNER JOIN Employee AS D ON D.PK_Employee_id = A.FK_Employee_id where CONCAT(PK_Invoice_id)LIKE '%" + textSearch.Text + "%'", con;
                SqlCommand cmd = new SqlCommand(sql_serch, conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGrid_Employee.AutoGenerateColumns = false;
                    dataGrid_Employee.DataSource = dt;
                    conn.Close();
                }
            }
            public void clear()
            {   
                comboBox_Employee.SelectedValue = -1;
                comboBox_Member.SelectedValue = -1;
                textBox_Product.Text = "";
                text_invoicePname.Text = "";
                text_invoiceQTY.Text = "";
                textBoxinvoicePrice.Text = "";
                textBoxinvoiceTotalPrice.Text = "";            
            }
            //ส่วนload_data ต่างๆ
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //public void comboBox_Product_load()
            //{
            //    SqlConnection conn = new SqlConnection(constring);
            //    if (conn.State == ConnectionState.Closed)
            //    {
            //        conn.Open();
            //        string sql = "SELECT PK_Product_id,productName FROM Product";
            //        SqlCommand cmd = new SqlCommand(sql, conn);
            //        cmd.CommandType = CommandType.Text;
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        DataTable dt = new DataTable();
            //        da.Fill(dt);
            //        /////ใส่ข้อมูลลงใน combobox
            //        comboBox_Product.DataSource = dt;
            //        comboBox_Product.DisplayMember = "productName";
            //        comboBox_Product.ValueMember = "PK_Product_id";
            //        conn.Close();
            //    }
            //}
            public void comboBox_Member_load()
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT Members.PK_Members_id,Members.memberFname FROM Members";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    /////ใส่ข้อมูลลงใน combobox
                    comboBox_Member.DataSource = dt;
                    comboBox_Member.DisplayMember = "memberFname";
                    comboBox_Member.ValueMember = "PK_Members_id";
                    conn.Close();
                }
            }
            public void comboBox_Employee_load()
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "SELECT Employee.PK_Employee_id,Employee.employeeFName FROM Employee";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    /////ใส่ข้อมูลลงใน combobox
                    comboBox_Employee.DataSource = dt;
                    comboBox_Employee.DisplayMember = "employeeFName";
                    comboBox_Employee.ValueMember = "PK_Employee_id";
                    conn.Close();
                }
             }        
            public void datagrid_load()
            {
                SqlConnection conn = new SqlConnection(constring);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    string sql = "select A.PK_Invoice_id,A.FK_Product_id,B.productName,C.memberFname,D.employeeFName,A.invoicePname,A.invoiceQTY,A.invoicePrice,A.invoiceTotalPrice,A.invoiceDate from Invoice as A  INNER JOIN Product AS B ON B.PK_Product_id = A.FK_Product_id INNER JOIN Members AS C ON C.PK_Members_id = A.FK_Members_id INNER JOIN Employee AS D ON D.PK_Employee_id = A.FK_Employee_id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGrid_Employee.AutoGenerateColumns = false;
                    dataGrid_Employee.DataSource = dt;
                    conn.Close();
                }
            }
            //ส่วนคำสั่งของ form
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            private void buttonAdd_Click(object sender, EventArgs e)
            {
                insert_data();
                clear();
                //comboBox_Product_load();
                comboBox_Member_load();
                comboBox_Employee_load();
                datagrid_load();
            }

        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGrid_Employee.Rows[e.RowIndex].Cells[0].Value);
            //comboBox_Jobposition_id.SelectedValue = dataGrid_Employee.Rows[e.RowIndex].Cells[1].Value;
            textBox_Product.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[1].Value.ToString();
            text_invoicePname.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[5].Value.ToString();
            text_invoiceQTY.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBoxinvoicePrice.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBoxinvoiceTotalPrice.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[8].Value.ToString();
                try
                {
                dateTimePicker_invoiceDate.Text = dataGrid_Employee.CurrentRow.Cells[9].Value.ToString();

            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            private void FormOrder_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDB2DataSet.Invoice);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.iTshopDB2DataSet.Employee);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.iTshopDB2DataSet.Members);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iTshopDB2DataSet.Product);
            comboBox_Member_load();
            //comboBox_Product_load();
            comboBox_Employee_load();
            datagrid_load();
            }

        private void text_invoiceQTY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int total = Convert.ToInt32(text_invoiceQTY.Text) * Convert.ToInt32(textBoxinvoicePrice.Text);
                textBoxinvoiceTotalPrice.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง");
            }

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Product.Text = productDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            text_invoicePname.Text = productDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxinvoicePrice.Text = productDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}

