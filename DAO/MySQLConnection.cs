using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MySQLConnection
    {
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            //string host = "127.0.0.1";

            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "csdl_ccharp";
            string username = "root";
            string password = "";
            return MySQLConnection.GetDBConnection(host, port, database, username, password);
        }

    }
}
    

