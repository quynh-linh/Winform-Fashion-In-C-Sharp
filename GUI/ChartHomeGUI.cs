using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using FontAwesome.Sharp;

namespace GUI
{
    public partial class ChartHomeGUI : Form
    {
        private ProductsBUS productsBUS = new ProductsBUS();
        private CustomerBUS customerBUS = new CustomerBUS();
        public ChartHomeGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                iconButton1.Enabled = false;
                iconButton2.Enabled = false;
                iconButton3.Enabled = false;
            }
            productSize.Text = productsBUS.getProducts().Rows.Count.ToString();
            customerSize.Text = customerBUS.getThanhVien().Rows.Count.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
