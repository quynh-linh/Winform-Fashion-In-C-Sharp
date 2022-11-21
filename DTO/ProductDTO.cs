using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        private string product_Id;
        private string product_Name;
        private double product_Price;
        private string image;
        private string description;
        private string brand_id;
        private string category_Id;
        private int size_id;
        private int quantity;

        public ProductDTO()
        {
        }

        public ProductDTO(string product_Id, string product_Name, double product_Price, string image, string description, string brand_id, string category_Id, int size_id, int quantity)
        {
            this.product_Id = product_Id;
            this.product_Name = product_Name;
            this.product_Price = product_Price;
            this.image = image;
            this.description = description;
            this.brand_id = brand_id;
            this.category_Id = category_Id;
            this.size_id = size_id;
            this.quantity = quantity;
        }

        public string Product_Id { get => product_Id; set => product_Id = value; }
        public string Product_Name { get => product_Name; set => product_Name = value; }
        public double Product_Price { get => product_Price; set => product_Price = value; }
        public string Image { get => image; set => image = value; }
        public string Description { get => description; set => description = value; }
        public string Brand_id { get => brand_id; set => brand_id = value; }
        public string Category_Id { get => category_Id; set => category_Id = value; }
        public int Size_id { get => size_id; set => size_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        
    }
}
