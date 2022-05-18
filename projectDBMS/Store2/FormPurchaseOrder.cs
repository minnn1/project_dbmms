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
    public partial class FormPurchaseOrder : Form
    {
        public FormPurchaseOrder()
        {
            InitializeComponent();
        }

        private void purchaseOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTshopDB2DataSet);

        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.PurchaseRequisition' table. You can move, or remove it, as needed.
            this.purchaseRequisitionTableAdapter.Fill(this.iTshopDB2DataSet.PurchaseRequisition);
            // TODO: This line of code loads data into the 'iTshopDB2DataSet.PurchaseOrder' table. You can move, or remove it, as needed.
            this.purchaseOrderTableAdapter.Fill(this.iTshopDB2DataSet.PurchaseOrder);

        }

        private void purchaseRequisitionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fK_PurchaseRequisition_idTextBox.Text = purchaseRequisitionDataGridView.CurrentRow.Cells[0].Value.ToString();
            purchaseorderNameTextBox.Text = purchaseRequisitionDataGridView.CurrentRow.Cells[3].Value.ToString();
            purchaseorderQTYTextBox.Text = purchaseRequisitionDataGridView.CurrentRow.Cells[4].Value.ToString();
            purchaseorderPriceTextBox.Text = purchaseRequisitionDataGridView.CurrentRow.Cells[5].Value.ToString();
            purchaseorderDateDateTimePicker.Text = purchaseRequisitionDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
