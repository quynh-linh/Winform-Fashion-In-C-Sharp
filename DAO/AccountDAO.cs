using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class AccountDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public DataTable selectAllAccount()
        {
            DataTable dtCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from account";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtCategory);
            }
            catch (Exception e)
            {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }

            return dtCategory;
        }

        public Boolean addAccount(AccountDTO accountDTO)
        {
            try
            {
                conn.Open();
                string sql = string.Format("INSERT INTO account(username,password,email,full_name,role_id)" +
                   " VALUES ('{0}','{1}','{2}','{3}','{4}')",accountDTO.User_Name,accountDTO.Password,accountDTO.Email,accountDTO.Full_Name,accountDTO.Role_Id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Read();
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        public bool updateAccount(AccountDTO accountDTO)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE account " +
                    "SET " +
                    "password = '{0}', email = '{1}', full_name = '{2}'" +
                    "WHERE id = '{3}'", accountDTO.Password, accountDTO.Email,accountDTO.Full_Name,accountDTO.Account_Id);

                Console.WriteLine(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("abc: " + e);
                Console.Read();
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }
        public bool deleteAccount(String username)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM account WHERE username like '{0}'", username);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.Read();
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        public DataTable searchAccount(String keyword)
        {
            DataTable searchCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from account where username LIKE  '%" + keyword + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(returnVal);
                returnVal.Fill(searchCategory);
            }
            catch (Exception e)
            {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }

            return searchCategory;
        }

        public DataTable loginAccount(String userName, String password)
        {
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from account where username ='"+ userName +"' AND password ='" + password +"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }

            return data;
        }

       
    }
}
