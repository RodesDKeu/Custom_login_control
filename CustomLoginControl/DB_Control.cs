using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomLoginControl
{
    public partial class DB_Control : Form
    {
        public DB_Control()
        {
            InitializeComponent();
        }

        private void userInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._UserDBDataSet);

        }

        private void DB_Control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_UserDBDataSet.UserInfo' table. You can move, or remove it, as needed.
            this.userInfoTableAdapter.Fill(this._UserDBDataSet.UserInfo);

        }

        private void searchUsernameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userInfoTableAdapter.SearchUsername(this._UserDBDataSet.UserInfo, userNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
