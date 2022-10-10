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
    public partial class AccountGUI : Form
    {
        public AccountGUI()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Add");
            accountAddOrUpdateGUI.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Update");
            accountAddOrUpdateGUI.Show();
        }
    }
}
