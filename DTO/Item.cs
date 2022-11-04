using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemDTO
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public ItemDTO(string iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
