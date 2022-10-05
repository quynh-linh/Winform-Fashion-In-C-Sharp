using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class DiscountDTO
    {
        private int discount_Id;
        private string sale_percent;
        private string start_day;
        private string end_day;
        private string desciption;

        public DiscountDTO(int discount_Id, string sale_percent, string start_day, string end_day, string desciption)
        {
            this.discount_Id = discount_Id;
            this.sale_percent = sale_percent;
            this.start_day = start_day;
            this.end_day = end_day;
            this.desciption = desciption;
        }

        public int Discount_Id { get => discount_Id; set => discount_Id = value; }
        public string Sale_percent { get => sale_percent; set => sale_percent = value; }
        public string Start_day { get => start_day; set => start_day = value; }
        public string End_day { get => end_day; set => end_day = value; }
        public string Desciption { get => desciption; set => desciption = value; }
    }
}
