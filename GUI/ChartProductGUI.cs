using BUS;
using DTO;
using NPOI.SS.UserModel.Charts;
using PdfSharp.Charting;
using PdfSharp.Pdf.Content.Objects;
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
        private Bill_BUS bill_BUS = new Bill_BUS();
        ChartGUI chartGUI;
        public ChartProductGUI(ChartGUI chartGUI)
        {
            this.chartGUI = chartGUI;
            InitializeComponent();
        }

        private void formChildProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<Bill_DTO> bills = bill_BUS.getBillsAbout(chartGUI.dateFrom.Value.ToString("dd-MM-yyyy HH:mm:ss"), chartGUI.dateTo.Value.ToString("dd-MM-yyyy HH:mm:ss"));
            chartProduct.Series["Quantity"].Points.Clear();
            if (bills.Count > 0) {
                Dictionary<string, int> revenue = new Dictionary<string, int>();
                Bill_DTO billFirst = bills[0];
                Bill_DTO billLast = bills[bills.Count - 1];
                DateTime dateFirst = DateTime.ParseExact(billFirst.Bill_Time, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dateLast = DateTime.ParseExact(billLast.Bill_Time, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                //MessageBox.Show((dateLast.Month).ToString() + (dateFirst.Month).ToString());
                if ((dateLast.Month - dateFirst.Month) > 0) {
                    revenue = bill_BUS.revenueWithMonth(bills);
                }
                else if ((dateLast.Month - dateFirst.Month) == 0) {
                    revenue = bill_BUS.revenueWithDay(bills);
                }
                foreach (var item in revenue) {
                    Console.WriteLine(item.Key + "---" + item.Value);
                    chartProduct.Series["Quantity"].Points.AddXY(item.Key, item.Value);
                }
            }
            else {
                MessageBox.Show("Không có hóa đơn nào được thực hiện trong thời gian này");
            }

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
