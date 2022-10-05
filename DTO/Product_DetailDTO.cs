using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Product_DetailDTO
    {
        private int id;
        private int product_Id;
        private int size_Id;
        private int quantity;
        private string description;
        private string image;
        private string thumbnail;

        public Product_DetailDTO(int id, int product_Id, int size_Id, int quantity, string description, string image, string thumbnail)
        {
            this.id = id;
            this.product_Id = product_Id;
            this.size_Id = size_Id;
            this.quantity = quantity;
            this.description = description;
            this.image = image;
            this.thumbnail = thumbnail;
        }

        public int Id { get => id; set => id = value; }
        public int Product_Id { get => product_Id; set => product_Id = value; }
        public int Size_Id { get => size_Id; set => size_Id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public string Image { get => image; set => image = value; }
        public string Thumbnail { get => thumbnail; set => thumbnail = value; }
    }
}
