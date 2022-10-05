using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Product_SizeDTO
    {
        private int size_Id;
        private string size_Name;
        private string size_Code;
        private string size_Description;

        public Product_SizeDTO(int size_Id, string size_Name, string size_Code, string size_Description)
        {
            this.size_Id = size_Id;
            this.size_Name = size_Name;
            this.size_Code = size_Code;
            this.size_Description = size_Description;
        }

        public int Size_Id { get => size_Id; set => size_Id = value; }
        public string Size_Name { get => size_Name; set => size_Name = value; }
        public string Size_Code { get => size_Code; set => size_Code = value; }
        public string Size_Description { get => size_Description; set => size_Description = value; }
    }
}
