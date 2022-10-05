using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Role_PermissionDTO
    {
        private int id;
        private int role_Id;
        private string description;

        public Role_PermissionDTO(int id, int role_Id, string description)
        {
            this.id = id;
            this.role_Id = role_Id;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public int Role_Id { get => role_Id; set => role_Id = value; }
        public string Description { get => description; set => description = value; }
    }
}
