using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product_SizeDTO
    {
        private int size_Id;
        private string size_Name;
        public Product_SizeDTO(int size_Id, string size_Name)
        {
            this.size_Id = size_Id;
            this.size_Name = size_Name;
           
        }

        public int Size_Id { get => size_Id; set => size_Id = value; }
        public string Size_Name { get => size_Name; set => size_Name = value; }
    }
}
