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
    public partial class ImportProductsGUI : Form
    {
        public ImportProductsGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Nhập hàng "))
            {
                guna2ImageButton2.Enabled = false;
                guna2ImageButton5.Enabled = false;
                guna2ImageButton6.Enabled = false;
            }      
        }

        private void ImportProductsGUI_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
