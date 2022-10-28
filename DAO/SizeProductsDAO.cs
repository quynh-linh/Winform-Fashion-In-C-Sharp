using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SizeProductsDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllSize()
        {
            DataTable dtSize = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM size";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter dtAdapter = new MySqlDataAdapter(sql, conn);
                dtAdapter.Fill(dtSize);
            }
            catch
            {
                Console.WriteLine("ket noi that bai !");
            }
            finally
            {
                conn.Close();
            }
            return dtSize;

        }
    }
}
