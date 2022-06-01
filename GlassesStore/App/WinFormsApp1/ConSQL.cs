using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public class ConSQL:FormName
    {
        SqlConnection con1 = new SqlConnection("Data Source=LAPTOP-1SPFNIPG;Initial Catalog=demo2DB;Integrated Security=True");

        public void conect()
        {
            try
            {
                con1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Connected", ex.Message);
            }
            finally
            {
                con1.Close();
            }
        }
    }
        
}
