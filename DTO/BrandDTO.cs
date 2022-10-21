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
        
        public BrandDTO()
        {

        }
        public BrandDTO(String brand_Id, string brand_Name)
        {
            this.brand_Id = brand_Id;
            this.brand_Name = brand_Name;
        }

        public String Brand_Id { get => brand_Id; set => brand_Id = value; }
        public string Brand_Name { get => brand_Name; set => brand_Name = value; }
    }
}
