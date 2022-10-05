using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class RoleDTO
    {
        private int role_Id;
        private string role_Name;

        public RoleDTO(int role_Id, string role_Name)
        {
            this.role_Id = role_Id;
            this.role_Name = role_Name;
        }

        public int Role_Id { get => role_Id; set => role_Id = value; }
        public string Role_Name { get => role_Name; set => role_Name = value; }
    }
}
