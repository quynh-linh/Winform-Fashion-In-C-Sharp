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

        public void insertAccounts(DataTable dataTable)  {
            List<AccountDTO> accounts = new List<AccountDTO>(); 
                for (int i = 0; i < dataTable.Rows.Count; i++) {
                    AccountDTO accountDTO = new AccountDTO();
                    accountDTO.Account_Id = Convert.ToInt32(dataTable.Rows[i]["id"]);
                    accountDTO.User_Name = dataTable.Rows[i]["username"].ToString();
                    accountDTO.Password = dataTable.Rows[i]["password"].ToString();
                    accountDTO.Full_Name = dataTable.Rows[i]["full_name"].ToString();
                    accountDTO.Email = dataTable.Rows[i]["email"].ToString();
                    accountDTO.Role_Id = dataTable.Rows[i]["role_id"].ToString();
                    accounts.Add(accountDTO);
                }
            int index = 0;
            foreach(AccountDTO account in accounts){
                if (accountDao.checkExistUsername(account.User_Name)) {
                    throw new ApplicationException("Username : " + account.User_Name + " nằm ở vị trí thứ " + (index + 1)  + " trong file excel đã tồn tại trong DB");
                }
                else if (accountDao.checkExistID(account.Account_Id)) {
                    throw new ApplicationException("Id : " + account.Account_Id + " nằm ở vị trí thứ " + (index + 1) + " trong file excel đã tồn tại trong DB");
                }
                else {
                    accountDao.addAccount(account);
                    index++;
                }
            }
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
