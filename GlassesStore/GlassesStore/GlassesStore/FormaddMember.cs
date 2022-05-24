using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlassesStore
{
    public partial class FormaddMember : Form
    {
        public FormaddMember()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glassesStoreDataSet);

        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glassesStoreDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.glassesStoreDataSet.member);
            //text เพิ่มข้อมูลใหม่
            member_fnameTextEdit.Text = "";
            member_lnameTextEdit.Text = "";
            member_adressTextEdit.Text = "";
            member_contactTextEdit.Text = "";

        }

        private void member_fnameTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            statusTextBox.Text = "unlock";
        }
    }
}
