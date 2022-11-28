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
        private Bill_BUS bill_BUS = new Bill_BUS();
        private ImportProductBUS importProductBUS = new ImportProductBUS();
        public ChartHomeGUI(string role_Manipulative)
        {
            InitializeComponent();
            if (!role_Manipulative.Equals("Được thay đổi"))
            {
                iconButton1.Enabled = false;
                iconButton2.Enabled = false;
                iconButton3.Enabled = false;
            }
            productQuantity.Text = productsBUS.sumQuantity() + "";
            customerSize.Text = customerBUS.quantityCustomer() + "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e) {
            productQuantity.Text = productsBUS.sumQuantity() + "";
            customerSize.Text = customerBUS.quantityCustomer() + "";
        }

        private void iconButton2_Click(object sender, EventArgs e) {
            productQuantity.Text = bill_BUS.getSumQuantityProductOfBill() + "";
        }

        private void iconButton3_Click(object sender, EventArgs e) {
            productQuantity.Text = importProductBUS.getSumQuantityProductOfImport() + "";
        }
    }
}
