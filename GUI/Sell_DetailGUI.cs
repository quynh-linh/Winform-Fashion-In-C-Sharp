using BUS;
using DAO;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections;
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
    public partial class Sell_DetailGUI : Form
    {

        DiscountBUS dc_bus = new DiscountBUS();
        SellBUS sellBuss = new SellBUS();
        ProductDTO product = new ProductDTO();
        DiscountDTO discount = new DiscountDTO();
        List<RadioButton> list_Size;
        List<int> size_Id;
        SellGui sellGUI;
        int initClick = 0;
        int sl = 1;
        double gia = 0;
        string name = "";
        int size = 0;
        double price_Discount = 0;
        int percent = 0;
        public Sell_DetailGUI(ProductDTO productDTO, SellGui sellGUI, String s, String size, int discount)
        {
            this.product = productDTO;
            InitializeComponent();
            checkSize(productDTO);
            checkedSize(productDTO);
            this.Text = s;
            this.sellGUI = sellGUI;
            _uriproduct = @"Image\" + this.product.Image;
            loadImageAsync();
            tb_nameProduct.Text = this.product.Product_Name;

            if (this.Text.Equals("Add new Product to Bill"))
                tb_quantityProduct.Text = 1 + "";
            else
            {
                int index = sellGUI.listOder.IndexOf(productDTO);
                int newQuantity = (int)sellGUI.list_Quantity_Choice[index];
                tb_quantityProduct.Text = newQuantity.ToString();
            }
            int size_Id = 0;
            if (size.Equals("S")) { rdb_sizeS.Checked = true; size_Id = 1; }
            else if (size.Equals("M")) { rdb_sizeM.Checked = true; size_Id = 2; }
            else if (size.Equals("L")) {rdb_sizeL.Checked = true; size_Id = 3; }
            else if (size.Equals("XL")) {rdo_XL.Checked = true; size_Id = 4;}

            if (discount > 0)
            {
                percent = discount;
                double price_up = this.product.Product_Price * 0.05 + this.product.Product_Price;
                this.price_Discount = price_up - (percent * price_up) / 100;
                double total = price_up * sl;
                double total_Discount = this.price_Discount * sl;
                guna2CircleButton1.Text = "-" + discount + "%";
                tb_priceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tb_priceProduct.Text = total.ToString("#,#,#") + "đ";
                guna2TextBox1.Text = total_Discount.ToString("#,#,#") + "đ";
            }
            else
            {
                price_Discount = product.Product_Price;
                guna2CircleButton1.Visible = false;
                label5.Visible = false;
                guna2TextBox1.Visible = false;
            }

            

        }
        public Task<Image> loadImageFromFileAsync(string uri)
        {
            return Task.Run(() =>
            {
                return Image.FromFile(uri);
            });
        }
        public string _uriproduct;

        public async void loadImageAsync()
        {
            var image = await loadImageFromFileAsync(this._uriproduct);
            ptb_imageDetailProduct.Image = image;
        }

        private void btn_addQuantity_Click(object sender, EventArgs e)
        {
            initClick++;
            sl = sl + 1;
            int count = this.product.Quantity;
            if (initClick > 0)
            {
                if (sl <= this.product.Quantity)
                {
                    tb_quantityProduct.Text = sl.ToString();

                }
                else
                {
                    sl = this.product.Quantity;
                    MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong cửa hàng !");
                }
            }
        }

        private void btn_subtracQuantity_Click(object sender, EventArgs e)
        {
            initClick++;
            sl = sl - 1;
            if (initClick > 0)
            {
                if (sl > 0)
                {
                    tb_quantityProduct.Text = sl.ToString();
                }
                else
                {
                    sl = 1;
                }
            }
        }

        private void tb_quantityProduct_TextChanged(object sender, EventArgs e)
        {
            if (tb_quantityProduct.Text != "")
            {
                string l = tb_quantityProduct.Text;
                sl = int.Parse(l);
                if (sl > 0)
                {
                    gia = this.product.Product_Price * sl;
                    double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
                    double tienloi = gia + thue;
                    tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";

                    if (this.percent > 0)
                    {
                        double price_up = this.product.Product_Price + this.product.Product_Price * 0.05;
                        this.price_Discount = price_up - (percent * price_up) / 100;
                        double total_Discount = this.price_Discount * sl;
                        guna2TextBox1.Text = total_Discount.ToString("#,#,#") + "đ";
                    }
                }
                if (sl > this.product.Quantity)
                {
                    sl = this.product.Quantity;
                    tb_quantityProduct.Text = sl.ToString();
                    MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
                }
            }
        }

        //check checked size cua sp
        public void checkedSize(ProductDTO productDTO)
        {
            ArrayList listSize = sellBuss.checkSize(productDTO);
            if ( listSize[0].ToString().Equals("1") ) rdb_sizeS.Checked = true;
            else if( listSize[0].ToString().Equals("2")) rdb_sizeM.Checked = true;
            else if(listSize[0].ToString().Equals("3")) rdb_sizeL.Checked = true;
            else if (listSize[0].ToString().Equals("4")) rdo_XL.Checked = true;
        }
        //check size de an di nhung sp ko co size do
        public void checkSize(ProductDTO productDTO)
        {
            ArrayList listSize = sellBuss.checkSize(productDTO);
            //MessageBox.Show(listSize[0]+"a");
            if (listSize.Contains("1"))
                rdb_sizeS.Enabled = true;
            else
                rdb_sizeS.Enabled = false;

            if (listSize.Contains("2"))
                rdb_sizeM.Enabled = true;
            else
                rdb_sizeM.Enabled = false;

            if (listSize.Contains("3"))
                rdb_sizeL.Enabled = true;
            else
                rdb_sizeL.Enabled = false;

            if (listSize.Contains("4"))
                rdo_XL.Enabled = true;
            else
                rdo_XL.Enabled = false;
        }

        //check nhap ki tu trong textbox so luong
        private void tb_quantityProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(tb_quantityProduct.Text) == 0)
                MessageBox.Show("Hết hàng!!");
            else
            {
                //SP đã có trong bill thì cập nhật số lượng của sp
                if (checkOrderExits(this.product) != null)
                {
                    int index = sellGUI.listOder.IndexOf(checkOrderExits(this.product));
                    sellGUI.list_Quantity_Choice.RemoveAt(index);
                    sellGUI.list_Quantity_Choice.Insert(index, int.Parse(tb_quantityProduct.Text));
                }
                else//SP k có trong bill thì thêm mới sp
                {
                    if (this.percent > 0)
                        this.product.Product_Price = this.price_Discount;
                    else this.product.Product_Price = this.product.Product_Price + 0.05 * this.product.Product_Price;
                    this.sellGUI.listOder.Add(this.product);
                    this.sellGUI.list_Quantity_Choice.Add(int.Parse(tb_quantityProduct.Text));
                }

                //do du lieu oder vo flowlayout
                this.sellGUI.addItemOder(this.sellGUI.listOder, this.sellGUI.list_Quantity_Choice);

                this.Hide();
            }
            
        }

        private void rdb_sizeS_CheckedChanged(object sender, EventArgs e)
        {
            list_Size = new List<RadioButton> { rdb_sizeS, rdb_sizeM, rdb_sizeL, rdo_XL };
            size_Id = new List<int> { 1, 2, 3, 4 };
            for (int i = 0; i < list_Size.Count; i++)
            {
                if (list_Size[i].Checked == true)
                {
                    name = this.product.Product_Name;
                    size = size_Id[i];

                    this.product = (ProductDTO)sellBuss.selectSize(name, size)[0];
                    gia = this.product.Product_Price * sl;
                    double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
                    double tienloi = gia + thue;
                    tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";

                    if (this.percent > 0)
                    {
                        double price_up = this.product.Product_Price + this.product.Product_Price * 0.05;
                        this.price_Discount = price_up - (percent * price_up) / 100;
                        double total_Discount = this.price_Discount * sl;
                        guna2TextBox1.Text = total_Discount.ToString("#,#,#") + "đ";
                    }

                    if (sl > this.product.Quantity)
                    {
                        sl = this.product.Quantity;
                        tb_quantityProduct.Text = sl.ToString();
                        MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
                    }
                }
            }
        }

        //Kiểm tra sp đã có trong bill hay chưa
        public ProductDTO checkOrderExits(ProductDTO product)
        {
            for(int i = 0; i < sellGUI.listOder.Count; i++)
            {
                ProductDTO p = (ProductDTO)sellGUI.listOder[i];
                if (product.Product_Name.Equals(p.Product_Name) && product.Size_id.Equals(p.Size_id))
                    return p;
            }
            return null;
        }
    }
}
