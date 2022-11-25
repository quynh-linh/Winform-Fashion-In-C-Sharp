using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Discount_Detail_DTO
    {
        String discount_Id;
        String product_Id;

        public Discount_Detail_DTO()
        {

        }
        public Discount_Detail_DTO(string discount_Id, string product_Id)
        {
            this.discount_Id = discount_Id;
            this.product_Id = product_Id;
        }

        public string Discount_Id { get => discount_Id; set => discount_Id = value; }
        public string Product_Id { get => product_Id; set => product_Id = value; }
    }
}
