using System;

namespace DTO
{
    public class CategoryDTO
    {
        private string category_Id;
        private string category_Name;
        private int isDeleted;

        public CategoryDTO(string category_Id, string category_Name, int isDeleted)
        {
            this.category_Id = category_Id;
            this.category_Name = category_Name;
            this.isDeleted = isDeleted;
        }

        public string Category_Id { get => category_Id; set => category_Id = value; }
        public string Category_Name { get => category_Name; set => category_Name = value; }
        public int IsDeleted { get => isDeleted; set => isDeleted = value; }
    }
}
