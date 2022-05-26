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
    public partial class FormMember : Form
    {
        public FormMember()
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
            member_adress1TextEdit.Text = "";
            member_adress2TextEdit.Text = "";
            member_contactTextEdit.Text = "";

        }
    }
}
