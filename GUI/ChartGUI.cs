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
    public partial class ChartGUI : Form
    {
        private Form currentChildForm;
        public ChartGUI()
        {
            InitializeComponent();
            OpenChildForm(new ChartHomeGUI());
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

            OpenChildForm(new ChartProductGUI());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartHomeGUI());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartCustomerGUI());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChartStaffGUI());
        }
    }
}
