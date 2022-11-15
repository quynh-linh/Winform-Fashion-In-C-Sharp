using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class UC_oder : UserControl
    {
        ProductDTO product = new ProductDTO();
        public UC_oder(ProductDTO dto)
        {
            InitializeComponent();
        }
        public void setDataOder(ProductDTO data)
        {
     
            this.product = data;
            lb_nameOder.Text = data.Product_Name;
            double gia = data.Product_Price;
            lb_priceOder.Text = gia.ToString("#,#,#") + "đ";
            int sl = data.Quantity;
            lb_quantityOder.Text = sl.ToString();
            int size = data.Size_id;
            lb_sizeOder.Text = size.ToString();
        }
    }
}
