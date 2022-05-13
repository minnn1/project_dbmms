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
    public partial class FormMember : Form
    {
        public FormMember()
        {
            InitializeComponent();
        }
        
        private void FormMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDBDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.iTshopDBDataSet.Members);

        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDBDataSet);

        }
        public string constr = (@"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB;Integrated Security=True");

        public void serch_data()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Members where memberFname like '" + textBox1.Text + "%'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serch_data();
        }
    }
}
