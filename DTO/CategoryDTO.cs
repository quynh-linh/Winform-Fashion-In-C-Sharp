namespace DTO
{
    public class CategoryDTO
    {
        private string category_Id;
        private string category_Name;

        public CategoryDTO(string category_Id, string category_Name)
        {
            this.category_Id = category_Id;
            this.category_Name = category_Name;
        }

        public string Category_Id { get => category_Id; set => category_Id = value; }
        public string Category_Name { get => category_Name; set => category_Name = value; }
    }
}
