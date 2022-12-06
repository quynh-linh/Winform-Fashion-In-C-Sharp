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
using DTO;
namespace GUI
{
    public partial class ChartRevenueGUI : Form
    {
        Bill_BUS bill_BUS= new Bill_BUS();  
        ImportProductBUS importProductBUS = new ImportProductBUS();
        public ChartRevenueGUI()
        {
            InitializeComponent();
            statistic.DataSource = new List<string>() {
                "Doanh Thu","Nhập vào","Bán ra"
            };
            List<RevenueDTO> revenuesImport = importProductBUS.getAllRevenue();
            List<RevenueDTO> revenuesBill = bill_BUS.getAllRevenue();

            revenuesImport.ForEach(revenue => {
                chartCustomer.Series["Nhập vào"].Points.AddXY(revenue.Month, revenue.TongTien);
            });

            revenuesBill.ForEach(revenue => {
                chartCustomer.Series["Bán ra"].Points.AddXY(revenue.Month, revenue.TongTien);
            });
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            chartCustomer.Series["Nhập vào"].Points.Clear();
            chartCustomer.Series["Bán ra"].Points.Clear();

            List<RevenueDTO> revenuesImport = importProductBUS.getAllRevenue();
            List<RevenueDTO> revenuesBill = bill_BUS.getAllRevenue();
            if (statistic.Text.Equals("Nhập vào")) {
                revenuesImport.ForEach(revenue => {
                    chartCustomer.Series["Nhập vào"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
            }
            else if (statistic.Text.Equals("Bán ra")) {
                revenuesBill.ForEach(revenue => {
                    chartCustomer.Series["Bán ra"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
            }
            else {
                revenuesImport.ForEach(revenue => {
                    chartCustomer.Series["Nhập vào"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
                revenuesBill.ForEach(revenue => {
                    chartCustomer.Series["Bán ra"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
            }

        }

        private void chartCustomer_Click(object sender, EventArgs e)
        {

        }

        private void statistic_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void iconButton2_Click(object sender, EventArgs e) {

            chartCustomer.Series["Nhập vào"].Points.Clear();
            chartCustomer.Series["Bán ra"].Points.Clear();
            List<RevenueDTO> revenuesBill = bill_BUS.getAllRevenue();
            revenuesBill.ForEach(revenue => {
                chartCustomer.Series["Bán ra"].Points.AddXY(revenue.Month, revenue.TongTien);
            });
        }

        private void iconButton3_Click(object sender, EventArgs e) {

            chartCustomer.Series["Nhập vào"].Points.Clear();
            chartCustomer.Series["Bán ra"].Points.Clear();
            List<RevenueDTO> revenuesImport = importProductBUS.getAllRevenue();
            revenuesImport.ForEach(revenue => {
                chartCustomer.Series["Nhập vào"].Points.AddXY(revenue.Month, revenue.TongTien);
            });
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            chartCustomer.Series["Nhập vào"].Points.Clear();
            chartCustomer.Series["Bán ra"].Points.Clear();

            List<RevenueDTO> revenuesImport = importProductBUS.getAllRevenue();
            List<RevenueDTO> revenuesBill = bill_BUS.getAllRevenue();
                revenuesImport.ForEach(revenue => {
                    chartCustomer.Series["Nhập vào"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
                revenuesBill.ForEach(revenue => {
                    chartCustomer.Series["Bán ra"].Points.AddXY(revenue.Month, revenue.TongTien);
                });
            }
    }
}
