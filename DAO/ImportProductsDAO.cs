using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ImportProductsDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllProducts()
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT pd.id , pd.price , pd.name , pd.description , pd.quantity , pd.image, " +
                    "br.name as nameBrand , " +
                    "ct.nameCategory as nameCate , s.name as sizename " +
                    "FROM product as pd , brand as br ,  category as ct , size as s " +
                    "WHERE pd.brand_id = br.id AND pd.category_id = ct.id AND pd.size_id = s.id";
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
    }
}
