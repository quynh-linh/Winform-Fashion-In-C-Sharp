using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class PermissionDTO
    {
        private int permisson_Id;
        private string permission_Name;
        private string permission_Action;
        private string permission_Code;
        private string permission_Description;

        public PermissionDTO(int permisson_Id, string permission_Name, string permission_Action, string permission_Code, string permission_Description)
        {
            this.permisson_Id = permisson_Id;
            this.permission_Name = permission_Name;
            this.permission_Action = permission_Action;
            this.permission_Code = permission_Code;
            this.permission_Description = permission_Description;
        }

        public int Permisson_Id { get => permisson_Id; set => permisson_Id = value; }
        public string Permission_Name { get => permission_Name; set => permission_Name = value; }
        public string Permission_Action { get => permission_Action; set => permission_Action = value; }
        public string Permission_Code { get => permission_Code; set => permission_Code = value; }
        public string Permission_Description { get => permission_Description; set => permission_Description = value; }
    }

}
