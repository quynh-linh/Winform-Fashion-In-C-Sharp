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
        public bool checkSizeExist(int id) {
            try {
                conn.Open();
                String sql = String.Format("SELECT * FROM `size` WHERE id = {0}", id);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                var reader = cm.ExecuteReader();
                if (reader.HasRows) {
                    return true;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.Read();
            }
            finally {
                conn.Close();
            }
            return false;
        }
    }
}
