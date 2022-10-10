using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountAddOrUpdateGUI : Form
    {
        public AccountAddOrUpdateGUI(String type)
        {
            InitializeComponent();
            this.btnActionAccount.Text = type;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            this.textUsernameAccount.Text = "";
            this.textFullNameAccount.Text = "";
            this.textPasswordAccount.Text = "";
            this.textEmailAccount.Text = "";
        }
    }
}
