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

namespace Store2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //เปิดตามrole
                SqlCommand cmd = new SqlCommand("select * from JobPosition where jobpositionName='" + textBoxUsername.Text + "' and jobpositionPass='" + textBoxPassword.Text + "'", conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (textBoxUsername.Text == "admin")
                    {
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.Show();
                    }
                    else if (textBoxUsername.Text == "sales")
                    {
                        FormSales formsales = new FormSales();

                        formsales.Show();
                    }
                    else if (textBoxUsername.Text == "manager")
                    {
                        FormManager formManager = new FormManager();
                        formManager.Show();
                    }
                    else if (textBoxUsername.Text == "accountant")
                    {
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.Show();
                    }
                    else if (textBoxUsername.Text == "claimstaff")
                    {
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.Show();
                    }
                    else if (textBoxUsername.Text == "warehouse")
                    {
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.Show();
                    }
                    else if (textBoxUsername.Text == "purchasingStaff")
                    {
                        FormAdmin formadmin = new FormAdmin();
                        formadmin.Show();
                    }
                    else
                    {
                        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                    }
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");

                }

            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
            }
        }
    }
}
