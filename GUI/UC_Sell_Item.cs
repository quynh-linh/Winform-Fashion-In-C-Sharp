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
            //string folderPath = @"C:\Users\Qmanh\Winform-Fashion-In-C-Sharp\GUI\bin\Debug\Image\";
            //string imgFilePath = Path.Combine(folderPath, data.Image);
            //string image = data.Image;
            //byte[] = image;
            //ptc_imageProductItem.Image = @"C:\Users\Qmanh\Winform-Fashion-In-C-Sharp\GUI\bin\Debug\Image\" + getImage();



        }
        public Task<Image> loadImageFromFileAsync(string uri)
        {
            return Task.Run(() =>
            {
                return Image.FromFile(uri);
            });
        }
        public string _uriproduct;
        // public string uri_product
        //{
        //  set
        // {
        //   this._uriproduct = value;

        // }
        // get
        // {
        //    return _uriproduct;
        // }
        //}
        public async void loadImageAsync()
        {
            var image = await loadImageFromFileAsync(this._uriproduct);
            ptc_imageProductItem.Image = image;
        }

        private void lb_nameProductItem_Click(object sender, EventArgs e)
        {

        }

        private void UC_Sell_Item_Click(object sender, EventArgs e)
        {
            Sell_DetailGUI sell_DetailGUI = new Sell_DetailGUI(this.productDTO, this.discountDTO);
            sell_DetailGUI.Show();
        }
        //public string _name;
        // public string name
        //{
        // set
        // {
        //  _name = value;
        // lb_nameProductItem.Text = value;
        //}
        // get
        // {
        //   return this._name;
        //}
        // }
        //public double _price;
        //public double price
        //{
        // set
        // {
        // _price = value;
        // lb_priceProductItem.Text = value.ToString("#,#,#") + "$";
        // }
        //get
        //{
        // return this._price;
        // }
        // }
    }
}
