using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class CategoryDTO
    {
        private int category_Id;
        private string category_Name;
        private string category_Thumbnail;
        private string category_Description;

        public CategoryDTO(int category_Id, string category_Name, string category_Thumbnail, string category_Description)
        {
            this.category_Id = category_Id;
            this.category_Name = category_Name;
            this.category_Thumbnail = category_Thumbnail;
            this.category_Description = category_Description;
        }

        public int Category_Id { get => category_Id; set => category_Id = value; }
        public string Category_Name { get => category_Name; set => category_Name = value; }
        public string Category_Thumbnail { get => category_Thumbnail; set => category_Thumbnail = value; }
        public string Category_Description { get => category_Description; set => category_Description = value; }
    }
}
