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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
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
                string sql_insert = "insert into Employee(FK_JobPosition_id,employeeFName,employeeLName) values(@FK_JobPosition_id,@employeeFName,@employeeLName);";
                SqlCommand cmd = new SqlCommand(sql_insert, conn);
                //cmd.Parameters.AddWithValue("@PK_Employee_id", text_employee_id.Text);
                cmd.Parameters.AddWithValue("@FK_JobPosition_id", comboBox_Jobposition_id.SelectedValue);//add value to combobox
                cmd.Parameters.AddWithValue("@employeeFName", text_employeeFName.Text);
                cmd.Parameters.AddWithValue("@employeeLName", text_employeeLName.Text);
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
                DialogResult dr = MessageBox.Show("คุณต้องการลบข้อมูลลำดับที่"+id+"นี้หรือไม่ ?", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (id != 0 || id != null)
                    {
                        string sql_delete = "delete from Employee where PK_Employee_id=@PK_Employee_id;";
                        SqlCommand cmd = new SqlCommand(sql_delete, conn);
                        cmd.Parameters.AddWithValue("@PK_Employee_id", id);
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
                if (text_employeeFName.Text != "" && text_employeeLName.Text != "")
                {
                    string sql_update = "update Employee set FK_JobPosition_id=@FK_JobPosition_id,employeeFName=@employeeFName,employeeLName=@employeeLName where PK_Employee_id=@PK_Employee_id;";
                    SqlCommand cmd = new SqlCommand(sql_update, conn);
                    cmd.Parameters.AddWithValue("@PK_Employee_id", id);
                    cmd.Parameters.AddWithValue("@FK_JobPosition_id", comboBox_Jobposition_id.SelectedValue);//add value to combobox
                    cmd.Parameters.AddWithValue("@employeeFName", text_employeeFName.Text);
                    cmd.Parameters.AddWithValue("@employeeLName", text_employeeLName.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว");
                    clear();
                    combobox_job_load();
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
                string sql_search = "select Employee.PK_Employee_id ,JobPosition.jobpositionName ,Employee.employeeFName,Employee.employeeLName from Employee inner join JobPosition on Employee.FK_JobPosition_id = JobPosition.PK_JobPosition_id where( employeeFName like '%" + textSearch.Text + "%') or( jobpositionName like '%" + textSearch.Text + "%') ";
                SqlCommand cmd = new SqlCommand(sql_search, conn);
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
            comboBox_Jobposition_id.SelectedValue = -1;
            text_employeeFName.Text = "";
            text_employeeLName.Text = "";
        }
        //ส่วนload_data ต่างๆ
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void combobox_job_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "SELECT PK_JobPosition_id,jobpositionName FROM JobPosition";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                /////ใส่ข้อมูลลงใน combobox
                comboBox_Jobposition_id.DataSource = dt;
                comboBox_Jobposition_id.DisplayMember = "jobpositionName";
                comboBox_Jobposition_id.ValueMember = "PK_JobPosition_id";
                conn.Close();
            }
        }
        public void datagrid_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "select Employee.PK_Employee_id ,JobPosition.jobpositionName ,Employee.employeeFName,Employee.employeeLName from Employee inner join JobPosition on Employee.FK_JobPosition_id = JobPosition.PK_JobPosition_id";
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
        public void FormEmployee_Load(object sender, EventArgs e)
        {
            combobox_job_load();
            datagrid_load();
        }

        private void buttonPostion_Click(object sender, EventArgs e)
        {
            FormPosition formPosition = new FormPosition();
            formPosition.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            insert_data();
            clear();
            combobox_job_load();
            datagrid_load();
        }

        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGrid_Employee.Rows[e.RowIndex].Cells[0].Value);
            //comboBox_Jobposition_id.SelectedValue = dataGrid_Employee.Rows[e.RowIndex].Cells[1].Value;
            text_employeeFName.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[2].Value.ToString();
            text_employeeLName.Text = dataGrid_Employee.Rows[e.RowIndex].Cells[3].Value.ToString();
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
    }
}
