using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoginDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public bool login(string username, string password)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("SELECT * FROM account WHERE username = '{0}' AND password = '{1}'",username,password);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Query và kiểm tra
                if (reader.Read())
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
    }
}
