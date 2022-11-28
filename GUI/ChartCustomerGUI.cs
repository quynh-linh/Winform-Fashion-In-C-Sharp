using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class ChartCustomerGUI : Form
    {
        private Bill_BUS bill_BUS = new Bill_BUS();
        private CustomerBUS customerBUS = new CustomerBUS();
        ChartGUI chartGUI;
        public ChartCustomerGUI(ChartGUI chartGUI)
        {
            this.chartGUI = chartGUI;
            InitializeComponent();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            List<Bill_DTO> bills = bill_BUS.getBillsAboutAndCustomerIdNotNull(chartGUI.dateFrom.Value.ToString("dd-MM-yyyy HH:mm:ss"), chartGUI.dateTo.Value.ToString("dd-MM-yyyy HH:mm:ss"));
            chartCustomer.Series["Quantity"].Points.Clear();
            if (bills.Count > 0) {
                bills.ForEach(bill => {
                    CustomerDTO customer = customerBUS.findCustomerById(bill.Customer_Id);
                    Console.WriteLine(bill.Total + customer.NameCustomer);
                    chartCustomer.Series["Quantity"].Points.AddXY(customer.NameCustomer, (bill.Total));
                });
            }
            else {
                MessageBox.Show("Không có hóa đơn nào được thực hiện trong thời gian này");
            }
        }

        private void chartProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
