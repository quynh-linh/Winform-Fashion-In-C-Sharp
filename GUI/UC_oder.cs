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
        public UC_oder(SellGui sellGUI)
        {
            InitializeComponent();
            this.sellGUI = sellGUI;
        }
        public void setDataOder(ProductDTO data, int quantity, int index)
        {
            this.product = data;

            if (data.Size_id == 1) this.size = "S";
            else if(data.Size_id == 2) this.size = "M";
            else if (data.Size_id == 3) this.size = "L";
            else if (data.Size_id == 4) this.size = "XL";

            lb_nameOder.Text = data.Product_Name +" ("+ this.size + ")";

            lbl_Quantity_X_Price.Text = quantity +" X "+ (data.Product_Price * 0.05 + data.Product_Price).ToString("#,#,#") + "đ";
            total = data.Product_Price * quantity * 0.05 + data.Product_Price * quantity;
            lb_priceOder.Text = total.ToString("#,#,#") + "đ";
            this.index = index;
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
            Sell_DetailGUI sell_DetailGUI = new Sell_DetailGUI(this.product, this.sellGUI, "Update Detail Product in Bill", this.size);
            sell_DetailGUI.Show();
        }
    }
}
