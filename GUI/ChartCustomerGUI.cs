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
    public partial class ChartCustomerGUI : Form
    {
        public ChartCustomerGUI()
        {
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            chartCustomer.Series["Quantity"].Points.AddXY("Tháng 9", 120);
            chartCustomer.Series["Quantity"].Points.AddXY("Tháng 10", 110);
            chartCustomer.Series["Quantity"].Points.AddXY("Tháng 11", 156);
            chartCustomer.Series["Quantity"].Points.AddXY("Tháng 12", 100);
        }

        private void chartProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
