﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private int account_Id;
        private string user_Name;
        private string password;
        private string full_Name;
        private string email;
        private string role_Id;

        public AccountDTO() { }
        public AccountDTO(int account_Id, string user_Name, string password, string full_Name, string email, string role_Id)
        {
            this.account_Id = account_Id;
            this.user_Name = user_Name;
            this.password = password;
            this.full_Name = full_Name;
            this.email = email;
            this.role_Id = role_Id;
        }

        public int Account_Id { get => account_Id; set => account_Id = value; }
        public string User_Name { get => user_Name; set => user_Name = value; }
        public string Password { get => password; set => password = value; }
        public string Full_Name { get => full_Name; set => full_Name = value; }
        public string Email { get => email; set => email = value; }
        public string Role_Id { get => role_Id; set => role_Id = value; }

        public override string ToString()
        {
            return base.ToString() + ": " + user_Name;
        }
    }
}
