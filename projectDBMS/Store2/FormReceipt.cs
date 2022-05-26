using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store2
{
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }

        private void receiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receiptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.iTshopDB2DataSet.Invoice);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.Receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.iTshopDB2DataSet.Receipt);

        }

        private void invoiceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_Invoice_idTextBox.Text = invoiceDataGridView.CurrentRow.Cells[0].Value.ToString();
            receiptPnameTextBox.Text = invoiceDataGridView.CurrentRow.Cells[1].Value.ToString();
            receiptQTYTextBox.Text = invoiceDataGridView.CurrentRow.Cells[2].Value.ToString();
            receiptPriceTextBox.Text = invoiceDataGridView.CurrentRow.Cells[3].Value.ToString();
            receiptTotalPriceTextBox.Text = invoiceDataGridView.CurrentRow.Cells[4].Value.ToString();
            receiptDateDateTimePicker.Text = invoiceDataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formreport5 formreport5 = new Formreport5();
            formreport5.Show();
        }
    }
}
