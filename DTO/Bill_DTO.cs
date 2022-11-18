using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill_DTO
    {
        String bill_Id, customer_Id, bill_Time;
        int account_Id;
        double total;

        public Bill_DTO(string bill_Id, double total , string bill_Time, int account_Id, string customer_Id)
        {
            this.bill_Id = bill_Id;
            this.customer_Id = customer_Id;
            this.bill_Time = bill_Time;
            this.account_Id = account_Id;
            this.total = total;
        }

        public string Bill_Id { get => bill_Id; set => bill_Id = value; }
        public string Customer_Id { get => customer_Id; set => customer_Id = value; }
        public string Bill_Time { get => bill_Time; set => bill_Time = value; }
        public int Account_Id { get => account_Id; set => account_Id = value; }
        public double Total { get => total; set => total = value; }
    }
}
