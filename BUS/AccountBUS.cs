using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
            if(accountDao.checkExistUsername(account.User_Name)) {
                throw new ApplicationException("Username : " + account.User_Name + " đã tồn tại trong DB");
            }
            else if (accountDao.checkExistID(account.Account_Id)) {
                throw new ApplicationException("Id : " + account.Account_Id + " đã tồn tại trong DB");
            }
            //Only contains alphanumeric characters, underscore and dot. Underscore and dot can't be at the end or start of a username
            //Underscore and dot can't be next to each other,Underscore or dot can't be used multiple times in a row
            //Number of characters must be between 8 to 20.
            if (Regex.Match(account.User_Name, "^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$", RegexOptions.IgnoreCase).Success || account.User_Name.Equals("")) {
                throw new ApplicationException("username cần có 1 kí tự đặc biệt hoặc _ hoặc . , _ và . không được nằm cuối , _ . không nằm cạnh nhau, _ . không lặp lại cạnh nhau , số lượng kí tự từ 8 - 20");
            }
            // start to string, 3 or more character, 0 or more words with 3 or more character, end of string
            else if (Regex.Match(account.Full_Name, "^[a-zA-Z]{3,}( {1,2}[a-zA-Z]{3,}){0,}$", RegexOptions.IgnoreCase).Success || account.Full_Name.Equals("")) {
                throw new ApplicationException("Fullname fắt đầu và kết thúc bằng chuỗi, 3 hoặc nhiều hơn 3 từ");
            }
            //At least one upper case and at least one lower case English letter,At least one digit,At least one special character,Minimum eight in length
            else if (Regex.Match(account.Password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", RegexOptions.IgnoreCase).Success || account.Password.Equals("")) {
                throw new ApplicationException("Password ít nhất 1 từ viết hoa và 1 từ viết thường, ít nhất 1 số và 1 kí tự đặc biệt, ít nhất 8 kí tự");
            }
            else if (account.Role_Id.Equals("")) {
                throw new ApplicationException("Sai quyền");
            }
            MailAddress m = new MailAddress(account.Email.Equals("") ? "sai" : account.Email);
            if (accountDao.addAccount(account)) return true;
            return false;
        }

        public Boolean updateAccount(AccountDTO account)
        {
            //Only contains alphanumeric characters, underscore and dot. Underscore and dot can't be at the end or start of a username
            //Underscore and dot can't be next to each other,Underscore or dot can't be used multiple times in a row
            //Number of characters must be between 8 to 20.
            if (Regex.Match(account.User_Name, "^(?=[a-zA-Z0-9._]{8,20}$)(?!.*[_.]{2})[^_.].*[^_.]$", RegexOptions.IgnoreCase).Success || account.Full_Name.Equals("")) {
                throw new ApplicationException("username cần có 1 kí tự đặc biệt hoặc _ hoặc . , _ và . không được nằm cuối , _ . không nằm cạnh nhau, _ . không lặp lại cạnh nhau , số lượng kí tự từ 8 - 20");
            }
            // start to string, 3 or more character, 0 or more words with 3 or more character, end of string
            else if (Regex.Match(account.Full_Name, "^[a-zA-Z]{3,}( {1,2}[a-zA-Z]{3,}){0,}$", RegexOptions.IgnoreCase).Success || account.Full_Name.Equals("")) {
                throw new ApplicationException("Bắt đầu và kết thúc bằng chuỗi, 3 hoặc nhiều hơn 3 từ");
            }
            //At least one upper case and at least one lower case English letter,At least one digit,At least one special character,Minimum eight in length
            else if (Regex.Match(account.Password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", RegexOptions.IgnoreCase).Success || account.Full_Name.Equals("")) {
                throw new ApplicationException("Ít nhất 1 từ viết hoa và 1 từ viết thường, ít nhất 1 số và 1 kí tự đặc biệt, ít nhất 8 kí tự");
            }
            else if (account.Role_Id.Equals("")) {
                throw new ApplicationException("Sai quyền");
            }
            MailAddress m = new MailAddress(account.Email.Equals("") ? "sai" : account.Email);
            if (accountDao.updateAccount(account))
                    return true;
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
