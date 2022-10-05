using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class ProductDTO
    {
        private int product_Id;
        private string product_Name;
        private double product_Price;
        private int product_Raw_Quantity;
        private int product_Discount_Id;
        private int category_Id;
        private int brand_Id;

        public ProductDTO(int product_Id, string product_Name, double product_Price, int product_Raw_Quantity, int product_Discount_Id, int category_Id, int brand_Id)
        {
            this.product_Id = product_Id;
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.product_Raw_Quantity = product_Raw_Quantity;
            this.product_Discount_Id = product_Discount_Id;
            this.category_Id = category_Id;
            this.brand_Id = brand_Id;
        }

        public int Product_Id { get => product_Id; set => product_Id = value; }
        public string Product_Name { get => product_Name; set => product_Name = value; }
        public double Product_Price { get => product_Price; set => product_Price = value; }
        public int Product_Raw_Quantity { get => product_Raw_Quantity; set => product_Raw_Quantity = value; }
        public int Product_Discount_Id { get => product_Discount_Id; set => product_Discount_Id = value; }
        public int Category_Id { get => category_Id; set => category_Id = value; }
        public int Brand_Id { get => brand_Id; set => brand_Id = value; }
    }
}
