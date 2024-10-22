﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DiscountDTO
    {
        private string ma_discount;
        private string sale_percent;
        private string start_day;
        private string end_day;
        private string status;
        private int isDeleted;

        public DiscountDTO()
        {
        }

        public DiscountDTO(string ma_discount, string sale_percent, string start_day, string end_day, string status, int isDeleted)
        {
            this.ma_discount = ma_discount;
            this.sale_percent = sale_percent;
            this.start_day = start_day;
            this.end_day = end_day;
            this.status = status;
            this.isDeleted = isDeleted;
        }

        public string Ma_discount { get => ma_discount; set => ma_discount = value; }
        public string Sale_percent { get => sale_percent; set => sale_percent = value; }
        public string Start_day { get => start_day; set => start_day = value; }
        public string End_day { get => end_day; set => end_day = value; }
        public string Status { get => status; set => status = value; }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}
