using DTO;
using BUS;
using System.Windows.Forms;
using System;

namespace GUI
{
    public partial class UC_Bill_import : UserControl
    {
        Bill_BUS bill_BUS = new Bill_BUS();
        BillGui billGui;
        String size = "";
        public UC_Bill_import(BillGui billGui)
        {
            InitializeComponent();
            this.billGui = billGui;
        }
        //
        public void setDataBillDetallImport(detail_importProductDTO data)
        {
            if (data.Size == 1) this.size = "S";
            else if (data.Size == 2) this.size = "M";
            else if (data.Size == 3) this.size = "L";
            else if (data.Size == 4) this.size = "XL";
            lb_nameOder.Text = bill_BUS.get_Name_Product(data.MaSanPham) + " (" +this.size + ")";
            lbl_Quantity_X_Price.Text = " X " + data.SoLuong1;
            lb_priceOder.Text = data.Sunmoney.ToString("#,#,#") + "đ";           
        }
    }
}
