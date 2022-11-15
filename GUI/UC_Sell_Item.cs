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

namespace GUI
{
    public partial class UC_Sell_Item : UserControl
    {
        ProductDTO productDTO = new ProductDTO();
        DiscountDTO discountDTO = new DiscountDTO();
        SellGui sell = new SellGui();
        public UC_Sell_Item()
        {
            InitializeComponent();
        }
        public ProductDTO data;
        public ProductDTO getData()
        {
            return data;
        }
        public void setData(ProductDTO data)
        {
            this.productDTO = data;
            lb_nameProductItem.Text = data.Product_Name;
            double gia = data.Product_Price;
            double thue = (5 * gia) / 100; // gia sp tang 5% so vs nhap hang
            double tienloi = gia + thue;
            lb_priceProductItem.Text = tienloi.ToString("#,#,#") + "đ";
            //lb_priceProductItem.Text = data.Product_Price.ToString("#,#,#") + "đ";
            _uriproduct = @"Image\" + data.Image;
            loadImageAsync();
            
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
            ptc_imageProductItem.Image = image;
        }

        private void UC_Sell_Item_Click(object sender, EventArgs e)
        {
            Sell_DetailGUI sell_DetailGUI = new Sell_DetailGUI(this.productDTO, this.discountDTO);
            sell_DetailGUI.Show();
        }
        
    }
}
