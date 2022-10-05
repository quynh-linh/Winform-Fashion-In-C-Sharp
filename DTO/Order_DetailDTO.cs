using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Order_DetailDTO
    {
        private int id;
        private int Product_Detail_Id;
        private int order_Id;
        private double price;
        private int quantity;

        public Order_DetailDTO(int id, int product_Detail_Id, int order_Id, double price, int quantity)
        {
            this.id = id;
            Product_Detail_Id = product_Detail_Id;
            this.order_Id = order_Id;
            this.price = price;
            this.quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public int Product_Detail_Id1 { get => Product_Detail_Id; set => Product_Detail_Id = value; }
        public int Order_Id { get => order_Id; set => order_Id = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
