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
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 9", 120);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 10", 110);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 11", 156);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 12", 100);
        }

        private void formChildProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
            List<Bill_DTO> bills = bill_BUS.getBillsAbout(chartGUI.dateFrom.Value.ToString("dd-MM-yyyy HH:mm:ss"), chartGUI.dateTo.Value.ToString("dd-MM-yyyy HH:mm:ss"));

            MessageBox.Show(bills.Count.ToString());
            chartProduct.Series["Quantity"].Points.Clear();

            List<string> months = new List<string>();
            List<int> quantityOfMonth = new List<int>();
                bills.ForEach(b => {
                        DateTime dateTime = DateTime.ParseExact(b.Bill_Time, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    var matchingvalues = months.Where(stringToCheck => stringToCheck.Contains(dateTime.Month.ToString()));
                    if (matchingvalues!=null)
                    {
                        months.Add(dateTime.Month.ToString());
                    }
                });
           
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 9", 120);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 10", 110);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 11", 156);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 12", 100);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 13", 100);
            chartProduct.Series["Quantity"].Points.AddXY("Tháng 14", 100);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
