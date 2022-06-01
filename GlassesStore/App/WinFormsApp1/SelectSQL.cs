using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class SelectSQL
    {
        ConSQL con = new ConSQL();
        public void selectData()
        {         
            SqlCommand cmd = new SqlCommand("select First_Name,Last_Name from [NameTable]");
        }
    }
}
