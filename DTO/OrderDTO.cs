using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class OrderDTO
    {
        private int order_Id;
        private int customer_Id;
        private string order_Status;
        private int order_Amount;
        private string payment_Method;
        private string create_Time;

        public OrderDTO(int order_Id, int customer_Id, string order_Status, int order_Amount, string payment_Method, string create_Time)
        {
            this.order_Id = order_Id;
            this.customer_Id = customer_Id;
            this.order_Status = order_Status;
            this.order_Amount = order_Amount;
            this.payment_Method = payment_Method;
            this.create_Time = create_Time;
        }

        public int Order_Id { get => order_Id; set => order_Id = value; }
        public int Customer_Id { get => customer_Id; set => customer_Id = value; }
        public string Order_Status { get => order_Status; set => order_Status = value; }
        public int Order_Amount { get => order_Amount; set => order_Amount = value; }
        public string Payment_Method { get => payment_Method; set => payment_Method = value; }
        public string Create_Time { get => create_Time; set => create_Time = value; }
    }
}
