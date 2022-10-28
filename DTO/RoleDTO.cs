using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDTO
    {
        private string role_Id;
        private string role_Name;
        private string role_Desciption;

        public RoleDTO(string role_Id, string role_Name, string role_Desciption)
        {
            this.role_Id = role_Id;
            this.role_Name = role_Name;
            this.role_Desciption = role_Desciption;
        }

        public string Role_Id { get => role_Id; set => role_Id = value; }
        public string Role_Name { get => role_Name; set => role_Name = value; }
        public string Role_Desciption { get => role_Desciption; set => role_Desciption = value; }
    }
}
