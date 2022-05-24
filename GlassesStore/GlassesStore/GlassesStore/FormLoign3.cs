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
    public partial class FormLoign3 : Form
    {
        public FormLoign3()
        {
            InitializeComponent();
        }
        //เชื่มต่อฐานข้อมูล
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=GlassesStore;Integrated Security=True";
        //เชื่มต่อฐานข้อมูลกับcombobox
        public void combobox_load()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                string sql = "SELECT [member_id],[member_fname],[status] FROM [member]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                /////ใส่ข้อมูลลงใน combobox
                comboBoxMember.DataSource = dt;
                comboBoxMember.DisplayMember = "member_fname";
                comboBoxMember.ValueMember = "member_id";
                comboboxStatus.DataSource = dt;
                comboboxStatus.DisplayMember = "status";
                comboboxStatus.ValueMember = "status";

            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //ตรวจสอบถ้า textBoxStatus = unlock ให้ไปหน้า FormMain
            if (comboboxStatus.Text == "unlock")
            {
                FormMainMember fm = new FormMainMember();
                fm.Show();
                
            }
            else
            {
                MessageBox.Show("สมาชิกถูกlockไม่สามารถใช้งานได้");
            }
        }

        private void FormLoign_Load(object sender, EventArgs e)
        {
            combobox_load();
        }

        private void buttonRefesh_Click(object sender, EventArgs e)
        {
            //refresh texbox
            comboboxStatus.Text = "";
            //refresh combobox
            combobox_load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open form add member
            FormaddMember fm = new FormaddMember();
            fm.Show();
        }
    }
}
