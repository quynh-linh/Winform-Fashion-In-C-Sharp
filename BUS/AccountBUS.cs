using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        private AccountDAO accountDao = new AccountDAO();
        public DataTable getAllAccount()
        {
            return accountDao.selectAllAccount();
        }

        public Boolean createAccount(AccountDTO account)
        {
            if (accountDao.addAccount(account)) return true;
            return false;
        }

        public Boolean updateAccount(AccountDTO account)
        {
            if (accountDao.updateAccount(account)) return true;
            return false;
        }

        public Boolean deleteAccount(string username)
        {
            if (accountDao.deleteAccount(username)) return true;
            return false;
        }

        public DataTable searchAccount(string username)
        {
            return accountDao.searchAccount(username);
        }

        public AccountDTO loginAccount(String userName, String password)
        {
            DataTable data_Account = accountDao.loginAccount(userName, password);
            string id = data_Account.Rows[0][0].ToString();
            string username = data_Account.Rows[0][1].ToString();
            string pass = data_Account.Rows[0][2].ToString();
            string email = data_Account.Rows[0][3].ToString();
            string full_name = data_Account.Rows[0][4].ToString();
            string role_id = data_Account.Rows[0][5].ToString();
            return new AccountDTO(Int32.Parse(id), username, pass, full_name, email, role_id);
        }

    }
}
