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

namespace Store2
{
    public partial class FormClaims : Form
    {
        public FormClaims()
        {
            InitializeComponent();
        }
        public string constring = @"Data Source=LAPTOP-1SPFNIPG;Initial Catalog=ITshopDB2;Integrated Security=True";
        public int id;
        private void claimsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.claimsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

         
        private void FormClaims_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.iTshopDB2DataSet.Members);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.iTshopDB2DataSet.Receipt);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Claims' table. You can move, or remove it, as needed.
            this.claimsTableAdapter.Fill(this.iTshopDB2DataSet.Claims);
        }

        private void receiptDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Receipt_idTextBox.Text = receiptDataGridView.CurrentRow.Cells[0].Value.ToString();
            claimPnameTextBox.Text = receiptDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
        private void membersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Members_idTextBox.Text = membersDataGridView.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
