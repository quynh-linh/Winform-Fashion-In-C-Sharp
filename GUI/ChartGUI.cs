using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class ChartGUI : Form
    {
        private Form currentChildForm;
        private string role_Manipulative;
        public ChartGUI(string role_Manipulative)
        {
            InitializeComponent();
            this.role_Manipulative = role_Manipulative;
            OpenChildForm(new ChartHomeGUI(role_Manipulative));
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                button1.Enabled = false;
                iconButton4.Enabled = false;
                iconButton5.Enabled = false;
                button2.Enabled = false;
                iconButton6.Enabled = false;
                iconButton7.Enabled = false;
            }
        }

        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(form);
            form.Show();
        }

        private void ChartGUI_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartProductGUI(this));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartHomeGUI(role_Manipulative));
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartCustomerGUI(this));
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartStaffGUI());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
