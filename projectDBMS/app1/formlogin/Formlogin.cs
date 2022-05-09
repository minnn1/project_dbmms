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
namespace app1
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
        ///ก่อนจะใช้งานให้ทำการปิดชื่อ app1 โดยไปที่ตัวจัดการงาน เเละไปที่รายละเอียด เเละ คลิกจบการทำงาน app1
        private void ButtonLogin_Click(object sender, EventArgs e)
        {   //เชื่อมdatabse
            //ใช้sqladaper เปิดformตามjobposition
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from JobPosition where jobpositionName ='" + textBoxUsername.Text + "' and jobpositionPass='" + textBoxPassword.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                if (textBoxUsername.Text == "admin")
                {
                    Formadmin formadmin = new Formadmin();
                    formadmin.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "manager")
                {
                    Formmanager formmanager = new Formmanager();
                    formmanager.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "sales")
                {
                    Formsales formsales = new Formsales();
                    formsales.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "warehouse")
                {
                    Formwarehouse formwarehouse = new Formwarehouse();
                    formwarehouse.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "claimstaff")
                {
                    Formclaimstaff formclaimstaff = new Formclaimstaff();
                    formclaimstaff.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "purchasingStaff")
                {
                    FormpurchasingStaff formpurchasingStaff = new FormpurchasingStaff();
                    formpurchasingStaff.Show();
                    this.Hide();
                }
                else if (textBoxUsername.Text == "accountant")
                {
                    Formaccountant formaccountant = new Formaccountant();
                    formaccountant.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
                }
            }
                
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.Read())
                //{
                //    if (dr["jobpositionName"].ToString() == "admin")
                //    {
                //        Formadmin formadmin = new Formadmin();
                //        formadmin.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "manager")
                //    {
                //        Formmanager formmanager = new Formmanager();
                //        formmanager.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "sales")
                //    {
                //        Formsales formsales = new Formsales();
                //        formsales.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "warehouse")
                //    {
                //        Formwarehouse formwarehouse = new Formwarehouse();
                //        formwarehouse.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "claimstaff")
                //    {
                //        Formclaimstaff formclaimstaff = new Formclaimstaff();
                //        formclaimstaff.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "purchasingStaff")
                //    {
                //        FormpurchasingStaff formpurchasingStaff = new FormpurchasingStaff();
                //        formpurchasingStaff.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "accountant")
                //    {
                //        Formaccountant formaccountant = new Formaccountant();
                //        formaccountant.Show();
                //    }
                //    else if (dr["jobpositionName"].ToString() == "form1")
                //    {
                //        Form1 form1 = new Form1();
                //        form1.Show();
                //    }
                //    else
                //    {
                //        MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง1");
                //    }


                //}
                //else
                //{
                //    MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง2");
                //}


