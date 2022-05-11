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

namespace Store
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //เชื่อมdatabase
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from JobPosition where jobpositionName='" + textBoxUsername.Text + "' and jobpositionPass='" + textBoxPassword.Text + "'", con);
            //open form of role ทำงาน
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
                    FormSales formSales = new FormSales();
                    formSales.Show();
                }
                else if (textBoxUsername.Text == "manager")
                {
                    FormManager formManager = new FormManager();
                    formManager.Show();
                }
                else if (textBoxUsername.Text == "accountant") 
                {
                    FormAccountant formAccountant = new FormAccountant();
                    formAccountant.Show();
                }
                else if (textBoxUsername.Text == "claimstaff")
                {
                    FormClaimstaff formClaimstaff = new FormClaimstaff();
                    formClaimstaff.Show();
                }
                else if (textBoxUsername.Text == "warehouse")
                {
                    FormWarehouse formWarehouse = new FormWarehouse();
                    formWarehouse.Show();
                }
                else if (textBoxUsername.Text == "purchasingStaff")
                {
                    FormPurchasingStaff formPurchasingStaff = new FormPurchasingStaff();
                    formPurchasingStaff.Show();
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
