using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class RoleBUS
    {
        private RoleDAO roleDAO = new RoleDAO();

        public DataTable getAllRole()
        {
            return roleDAO.selectAllRole();
        }

        public Boolean addRole(RoleDTO role)
        {
            if (roleDAO.addRole(role)) return true;
            return false;
        }

        public Boolean fixRole(RoleDTO role)
        {
            if (roleDAO.fixRole(role)) return true;
            return false;
        }

        public Boolean deleteRole(string id)
        {
            if (roleDAO.deleteRole(id)) return true;
            return false;
        }

        public DataTable searchRole(string keyword)
        {
            return roleDAO.searchRole(keyword);
        }

        public RoleDTO get_Role_From_Id(String id)
        {
            DataTable data_Role_From_Id = roleDAO.get_Role_From_Id(id);
            string role_Id = data_Role_From_Id.Rows[0][0].ToString();
            string role_Name = data_Role_From_Id.Rows[0][1].ToString();
            string role_Description = data_Role_From_Id.Rows[0][2].ToString();
            return new RoleDTO(role_Id, role_Name, role_Description);
        }

        public Boolean check_Name(String name, string id)
        {
            if(roleDAO.check_Name(name, id).Rows.Count > 0) return true;
            return false;
        }
    }
}
