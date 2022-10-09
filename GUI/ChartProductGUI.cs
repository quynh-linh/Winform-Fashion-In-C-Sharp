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
    public partial class ChartProductGUI : Form
    {
        public ChartProductGUI()
        {
            InitializeComponent();
        }

        private void formChildProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            loadData("PRODUCT");
        }
        private void loadData(String type)
        {
            if (type.Equals("PRODUCT"))
            {
                chartProduct.Series["Quantity"].Points.AddXY("Tháng 9", 120);
                chartProduct.Series["Quantity"].Points.AddXY("Tháng 10", 110);
                chartProduct.Series["Quantity"].Points.AddXY("Tháng 11", 156);
                chartProduct.Series["Quantity"].Points.AddXY("Tháng 12", 100);
            }
            else if (type.Equals("STAFF"))
            {

            }
            else if (type.Equals("CUSTOMER"))
            {

            }
        }
    }
}
