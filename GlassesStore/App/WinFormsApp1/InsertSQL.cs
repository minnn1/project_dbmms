using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class InsertSQL:FormName
    {
        ConSQL con = new ConSQL();
        public  void InsertData()
        {
            try
            {
                con.conect();
                //insert
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[NameTable] (Name_id,First_Name,Last_Name) VALUES (@Name_id,@First_Name,@Last_Name)");
                MessageBox.Show("Insert Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
