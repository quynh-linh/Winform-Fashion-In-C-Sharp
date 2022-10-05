using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class BrandDTO
    {
        private int brand_Id;
        private string brand_Name;
        private string brand_Thumbnail;
        private string brand_Description;

        public BrandDTO(int brand_Id, string brand_Name, string brand_Thumbnail, string brand_Description)
        {
            this.brand_Id = brand_Id;
            this.brand_Name = brand_Name;
            this.brand_Thumbnail = brand_Thumbnail;
            this.brand_Description = brand_Description;
        }

        public int Brand_Id { get => brand_Id; set => brand_Id = value; }
        public string Brand_Name { get => brand_Name; set => brand_Name = value; }
        public string Brand_Thumbnail { get => brand_Thumbnail; set => brand_Thumbnail = value; }
        public string Brand_Description { get => brand_Description; set => brand_Description = value; }
    }
}
