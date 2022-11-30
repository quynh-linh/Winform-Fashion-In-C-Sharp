using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BrandDTO
    {
        private String brand_Id;
        private string brand_Name;
        private int isDelete;
        
        public BrandDTO()
        {

        }

        public BrandDTO(string brand_Id, string brand_Name, int isDelete)
        {
            this.brand_Id = brand_Id;
            this.brand_Name = brand_Name;
            this.isDelete = isDelete;
        }

        public string Brand_Id { get => brand_Id; set => brand_Id = value; }
        public string Brand_Name { get => brand_Name; set => brand_Name = value; }
        public int IsDelete { get => isDelete; set => isDelete = value; }
    }
}
