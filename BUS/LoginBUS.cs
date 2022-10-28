using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class LoginBUS
    {
        LoginDAO loginDAO = new LoginDAO();

        public LoginBUS()
        {
        }
        public string checkLogin(string username , string password)
        {
            if(loginDAO.login(username, password))
            {
                return "Đăng nhập thành công";
            }
            return "Đăng nhập thành công";
        }
    }
}
