using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_oder : UserControl
    {
        ProductDTO product = new ProductDTO();
        SellGui sellGUI;
        private int index;
        public double total = 0;
        String size = "";
        int percent = 0;
        DiscountBUS discountBUS = new DiscountBUS();
        public UC_oder(SellGui sellGUI)
        {
            InitializeComponent();
            this.sellGUI = sellGUI;
        }
        public void setDataOder(ProductDTO data, int quantity, int index)
        {
            this.product = data;
            this.percent = discountBUS.check_Product_Discount(this.product.Product_Id, this.product.Product_Name, "name");
            if (data.Size_id == 1) this.size = "S";
            else if(data.Size_id == 2) this.size = "M";
            else if (data.Size_id == 3) this.size = "L";
            else if (data.Size_id == 4) this.size = "XL";

            lb_nameOder.Text = data.Product_Name +" ("+ this.size + ")";

            lbl_Quantity_X_Price.Text = quantity +" X "+ data.Product_Price.ToString("#,#,#") + "đ";
            total = data.Product_Price * quantity;
            lb_priceOder.Text = total.ToString("#,#,#") + "đ";
            this.index = index;

            if(this.percent > 0)
            {
                guna2CircleButton1.Text = "-"+ this.percent + "%";
                label1.Text = (discountBUS.get_Price_Product(data.Product_Id) + discountBUS.get_Price_Product(data.Product_Id) * 0.05).ToString("#,#,#") + "đ";
            }
            else
            {
                guna2CircleButton1.Visible = false;
                label1.Visible = false;
            }
        }

        private void btn_deleteOder_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sellGUI.listOder.RemoveAt(this.index);
                sellGUI.list_Quantity_Choice.RemoveAt(this.index);
                sellGUI.addItemOder(sellGUI.listOder, sellGUI.list_Quantity_Choice);
            }
        }

        private void lb_nameOder_Click(object sender, System.EventArgs e)
        {
            //MessageBox.Show(discountBUS.check_Product_Discount(this.product.Product_Id,this.product.Product_Name, "name")+" " + this.product.Product_Id);
            Sell_DetailGUI sell_DetailGUI = new Sell_DetailGUI(this.product, this.sellGUI, "Update Detail Product in Bill", this.size, discountBUS.check_Product_Discount(this.product.Product_Id, this.product.Product_Name, "name"));
            sell_DetailGUI.Show();
        }
    }
}
