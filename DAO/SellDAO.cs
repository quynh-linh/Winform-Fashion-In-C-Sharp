using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace DAO
{
    
    public class SellDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllpruduct()
        {
            DataTable dataProduct = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from product";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter dtadt = new MySqlDataAdapter(sql, conn);
                dtadt.Fill(dataProduct);
            }
            catch(Exception e)
            {
                Console.WriteLine("Kết nối thất bại với lỗi sau : " + e.Message);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return dataProduct;
        }

    }
}
