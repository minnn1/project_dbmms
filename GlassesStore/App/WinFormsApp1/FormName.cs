using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }
        ConSQL con = new ConSQL();
        InsertSQL insert = new InsertSQL();
        SelectSQL select = new SelectSQL();
        //medthod creat
        public void id()
        {
           
        }
        public void INSERT()
        {
            try
            {
                con.conect();
                
                SqlCommand cmd = new SqlCommand("INSERT INTO NameTable VALUES(@First_Name,@Last_Name)");
                cmd.Parameters.AddWithValue("@First_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Last_Name", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
                INSERT();
        }
        private void buttonCon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    con.conect();
            //    MessageBox.Show("Conected");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        public void datagrid_load()
        {
            //try
            //{
            //    con.conect();
            //    SqlCommand cmd = new SqlCommand("select First_Name,Last_Name from [NameTable]");
                
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    textBox3.Text = dt.Rows[0][0].ToString();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void FormName_Load(object sender, EventArgs e)
        {
            //con.conect();
            //datagrid_load();
        }
    }
}