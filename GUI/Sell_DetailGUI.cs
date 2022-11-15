using BUS;
using DTO;
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
        UC_Sell_Item uc = new UC_Sell_Item();
        int initClick = 0;
        int sl = 1;
        double gia = 0;
        string name = "";
        int size = 0;
        public Sell_DetailGUI(ProductDTO productDTO, DiscountDTO dTO)
        {
            InitializeComponent();
            checkSize(productDTO);
            checkedSize(productDTO);
            
            this.discount = dTO;
            fillCombobox(dTO);
            this.product = productDTO;
            _uriproduct = @"Image\" + this.product.Image;
            loadImageAsync();
            tb_nameProduct.Text = this.product.Product_Name;
            gia = this.product.Product_Price * sl;
            double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
            double tienloi = gia + thue;
            tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
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
                    gia = this.product.Product_Price * sl;
                    double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
                    double tienloi = gia + thue;
                    tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
                }
                else
                {
                    sl = this.product.Quantity;
                    MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
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
                    gia = this.product.Product_Price * sl;
                    double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
                    double tienloi = gia + thue;
                    tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
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
                }
                if (sl > this.product.Quantity)
                {
                    sl = this.product.Quantity;
                    tb_quantityProduct.Text = sl.ToString();
                    MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
                }
            }
        }
        // gan ma giam gia len combobox
        public void fillCombobox(DiscountDTO data)
        {
            this.cbb_discountProduct.DataSource = dc_bus.getMadiscount(data);
            this.cbb_discountProduct.DisplayMember = "maDiscount";
            this.cbb_discountProduct.ValueMember = "maDiscount";
            this.cbb_discountProduct.Enabled = true;
            cbb_discountProduct.SelectedItem = null;
        }
        // aps max giam gia cho san pham
        private void giamgia()
        {

        }
        //check checked size cua sp
        public void checkedSize(ProductDTO productDTO)
        {
            ArrayList listSize = sellBuss.checkSize(productDTO);
            if (listSize.Contains("1") && !listSize.Contains("2") && !listSize.Contains("3"))
            {
                rdb_sizeS.Checked = true;

            }
            else if (!listSize.Contains("1") && listSize.Contains("2") && !listSize.Contains("3"))
            {
                rdb_sizeM.Checked = true;
            }
            else if (!listSize.Contains("1") && !listSize.Contains("2") && listSize.Contains("3"))
            {
                rdb_sizeL.Checked = true;
            }
            else if (listSize.Contains("1") && listSize.Contains("2") && listSize.Contains("3"))
            {
                rdb_sizeS.Checked = true;
            }
            else if (listSize.Contains("1") && listSize.Contains("2") && !listSize.Contains("3"))
            {
                rdb_sizeS.Checked = true;
            }
            else if (!listSize.Contains("1") && listSize.Contains("2") && listSize.Contains("3"))
            {
                rdb_sizeL.Checked = true;
            }
            else if (listSize.Contains("1") && !listSize.Contains("2") && listSize.Contains("3"))
            {
                rdb_sizeS.Checked = true;
            }

        }
        //check size de an di nhung sp ko co size do
        public void checkSize(ProductDTO productDTO)
        {
            ArrayList listSize = sellBuss.checkSize(productDTO);
            //MessageBox.Show(listSize[0]+"a");
            if (listSize.Contains("1"))
            {
                rdb_sizeS.Enabled = true;
            }
            else
            {
                rdb_sizeS.Enabled = false;
                rdb_sizeS.Text = "S";
            }
            if (listSize.Contains("2"))
            {
                rdb_sizeM.Enabled = true;
            }
            else
            {
                rdb_sizeM.Enabled = false;
                rdb_sizeM.Text = "M";
            }
            if (listSize.Contains("3"))
            {
                rdb_sizeL.Enabled = true;
            }
            else
            {
                rdb_sizeL.Enabled = false;
                rdb_sizeL.Text = "L";
            }
        }

        private void rdb_sizeS_Click(object sender, EventArgs e)
        {

            name = tb_nameProduct.Text;
            size = 1;
            //MessageBox.Show("name : " + name + "size : " + size);
            //sellBuss.selectSize(name, size);
            this.product = (ProductDTO)sellBuss.selectSize(name, size)[0];
            gia = this.product.Product_Price * sl;
            double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
            double tienloi = gia + thue;
            tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
            if (sl > this.product.Quantity)
            {
                sl = this.product.Quantity;
                tb_quantityProduct.Text = sl.ToString();
                MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
            }
        }

        private void rdb_sizeM_Click(object sender, EventArgs e)
        {
            name = tb_nameProduct.Text;
            size = 2;
            //MessageBox.Show("name : " + name + "size : " + size);
            //sellBuss.selectSize(name, size);
            this.product = (ProductDTO)sellBuss.selectSize(name, size)[0];
            gia = this.product.Product_Price * sl;
            double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
            double tienloi = gia + thue;
            tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
            if (sl > this.product.Quantity)
            {
                sl = this.product.Quantity;
                tb_quantityProduct.Text = sl.ToString();
                MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
            }
        }

        private void rdb_sizeL_Click(object sender, EventArgs e)
        {
            name = tb_nameProduct.Text;
            size = 3;
            this.product = (ProductDTO)sellBuss.selectSize(name, size)[0];
            //MessageBox.Show("name : " + name + "size : " + size);
            //sellBuss.selectSize(name, size);
            gia = this.product.Product_Price * sl;
            double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
            double tienloi = gia + thue;
            tb_priceProduct.Text = tienloi.ToString("#,#,#") + "đ";
            if (sl > this.product.Quantity)
            {
                sl = this.product.Quantity;
                tb_quantityProduct.Text = sl.ToString();
                MessageBox.Show("Vượt quá số lượng sản phẩm hiện có trong của hàng !");
            }
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

             //SellGui s = new SellGui();
             SellGui.listOder.Add(this.product);
            //do du lieu oder vo flowlayout
            //s.addItemOder(SellGui);
          
            this.Hide();  
        }
    }
}
