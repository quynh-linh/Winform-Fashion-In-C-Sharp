using BUS;
using DTO;
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
        private AccountDTO accountDTO;
        private AccountBUS accountBUS = new AccountBUS();
        public AccountGUI( string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                guna2Button1.Enabled = false;
                guna2Button4.Enabled = false;
                guna2Button3.Enabled = false;
                guna2Button2.Enabled = false;
                guna2Button6.Enabled = false;
            }

        }



        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Add", null);
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
            AccountAddOrUpdateGUI accountAddOrUpdateGUI = new AccountAddOrUpdateGUI("Update", accountDTO);
            accountAddOrUpdateGUI.Show();
        }

        private void AccountGUI_Load(object sender, EventArgs e)
        {
            dataGridViewAccount.DataSource = accountBUS.getAllAccount();
            DataGridViewRow row = dataGridViewAccount.Rows[0];
            accountDTO = new AccountDTO(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(),row.Cells[5].Value.ToString());
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewAccount.Rows[rowIndex];
            accountDTO = new AccountDTO(Int32.Parse(row.Cells[0].Value.ToString()), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[5].Value.ToString());
        }
    }
}
