using BUS;
using DTO;
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

namespace GUI
{
    public partial class UC_Bill : UserControl
    {
        Bill_BUS bill_BUS = new Bill_BUS();
        DiscountBUS discountBUS = new DiscountBUS();
        private BillGui billGui;

        public UC_Bill(BillGui billGui)
        {
            InitializeComponent();
            this.billGui = billGui;
        }

        //
        public void setDataBillDetall(Bill_Detail_DTO data)
        {

            lb_nameOder.Text = bill_BUS.get_Name_Product(data.Product_Id) + " (" + data.Size + ")";
            lbl_Quantity_X_Price.Text = data.Quantity + " X " + data.Price.ToString("#,#,#") + "đ";
            double total = data.Price * data.Quantity;
            lb_priceOder.Text = total.ToString("#,#,#") + "đ";
            if (data.Percent > 0)
            {
                guna2CircleButton1.Text = "-" + data.Percent + "%";
                label1.Text = (discountBUS.get_Price_Product(data.Product_Id) + discountBUS.get_Price_Product(data.Product_Id) * 0.05).ToString("#,#,#") + "đ";
            }
            else
            {
                guna2CircleButton1.Visible = false;
                label1.Visible = false;
            }
        }
    }
}
