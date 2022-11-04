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
        public DataTable getAllCategory()
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
    }
}
