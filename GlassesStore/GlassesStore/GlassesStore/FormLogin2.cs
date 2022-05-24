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
    public partial class FormLogin2 : Form
    {
        public FormLogin2()
        {
            InitializeComponent();
        }
        string username;
        string pwd;
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";
        public void combobox_load()
        {

            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "SELECT [employee_id],[employee_name],[employee_passworld] FROM [employee]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                /////ใส่ข้อมูลลงใน combobox
                comboBoxEmp.DataSource = dt;
                comboBoxEmp.DisplayMember = "employee_name";
                comboBoxEmp.ValueMember = "employee_id";
            }
        }
          private void FormLogin2_Load(object sender, EventArgs e)
        {
            combobox_load();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "SELECT [employee_id],[employee_name],[employee_passworld] FROM [employee] where employee_passworld = '" + textBoxPassword.Text + "' and employee_name = '" + comboBoxEmp.Text + "'";
                //ถ้าข้อมูลตรงกับฐานข้อมูลให้เปิดหน้าหลัก
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string username = reader["employee_name"].ToString();
                    string pwd = reader["employee_passworld"].ToString();
                    FormMain fm = new FormMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                }
            }
        }
    }
}
