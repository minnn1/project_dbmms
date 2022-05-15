using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Store2
{
    class Classconection
    {
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public void conect()
        {
            SqlConnection conn = new SqlConnection(constring);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
