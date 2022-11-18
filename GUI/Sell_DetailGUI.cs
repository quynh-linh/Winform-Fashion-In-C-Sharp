using BUS;
using DAO;
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
        List<RadioButton> list_Size;
        List<int> size_Id;
        UC_Sell_Item uc;
        SellGui sellGUI;
        int initClick = 0;
        int sl = 1;
        double gia = 0;
        string name = "";
        int size = 0;
        public Sell_DetailGUI(ProductDTO productDTO, SellGui sellGUI, String s, String size)
        {
            this.product = productDTO;
            InitializeComponent();
            checkSize(productDTO);
            checkedSize(productDTO);
            this.Text = s;
            
            this.sellGUI = sellGUI;
            //this.discount = dTO;
            //fillCombobox(dTO);
            _uriproduct = @"Image\" + this.product.Image;
            loadImageAsync();
            tb_nameProduct.Text = this.product.Product_Name;

            if (this.Text.Equals("Add new Product to Bill"))
                tb_quantityProduct.Text = 1 +"";
            else
            {
                int index = sellGUI.listOder.IndexOf(productDTO);
                int newQuantity = (int) sellGUI.list_Quantity_Choice[index];
                tb_quantityProduct.Text = newQuantity.ToString();
            }

            if (size.Equals("S")) rdb_sizeS.Checked = true;
            else if (size.Equals("M")) rdb_sizeM.Checked = true;
            else if (size.Equals("L")) rdb_sizeL.Checked = true;
            else if (size.Equals("XL")) rdo_XL.Checked = true;

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
            //SP đã có trong bill thì cập nhật số lượng của sp
            if (checkOrderExits(this.product) != null)
            {
                int index = sellGUI.listOder.IndexOf(checkOrderExits(this.product));
                sellGUI.list_Quantity_Choice.Insert(index, int.Parse(tb_quantityProduct.Text));
            }
            else//SP k có trong bill thì thêm mới sp
            {
                this.sellGUI.listOder.Add(this.product);
                this.sellGUI.list_Quantity_Choice.Add(int.Parse(tb_quantityProduct.Text));
            }
            

            //do du lieu oder vo flowlayout
            this.sellGUI.addItemOder(this.sellGUI.listOder, this.sellGUI.list_Quantity_Choice);   

            this.Hide();  
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
