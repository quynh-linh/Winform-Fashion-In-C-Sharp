using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_Detail_DTO
    {
        private String bill_Id, product_Id, size;
        private int quantity;
        private double price;

        public Bill_Detail_DTO(string bill_Id, string product_Id, string size, int quantity, double price)
        {
            this.bill_Id = bill_Id;
            this.product_Id = product_Id;
            this.size = size;
            this.quantity = quantity;
            this.price = price;
        }

        public string Bill_Id { get => bill_Id; set => bill_Id = value; }
        public string Product_Id { get => product_Id; set => product_Id = value; }
        public string Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
    }
}
