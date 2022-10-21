using MySql.Data.MySqlClient;
using System;
using System.Data;
using DTO;
using System.Collections;

namespace DAO
{
    public class BrandDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllBrand()
        {
            DataTable dtBrand = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM brand";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter dtAdapter = new MySqlDataAdapter(sql, conn);
                dtAdapter.Fill(dtBrand);
            }
            catch
            {
                Console.WriteLine("ket noi that bai !");
            }
            finally
            {
                conn.Close();
            }
            return dtBrand;

        }
        public ArrayList getBrand()
        {
            ArrayList brandDTO = new ArrayList();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM brand";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    BrandDTO brandDTO1 = new BrandDTO();
                    brandDTO1.Brand_Id = mySqlDataReader["id"].ToString();
                    brandDTO1.Brand_Name = mySqlDataReader["name"].ToString();
                    brandDTO.Add(brandDTO1);
                }
            }
            catch
            {
                Console.WriteLine("ket noi that bai !");
            }
            finally
            {
                conn.Close();
            }
            return brandDTO;
        }
        
        public bool addBrand(BrandDTO br)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO brand(id,name)" + "VALUES ('{0}','{1}')",br.Brand_Id,br.Brand_Name);
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                Console.WriteLine(sql);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool editBrand(BrandDTO br)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE brand " +
                    "SET " +
                    "name= '{0}'" +
                    "WHERE id = '{1}'",br.Brand_Name,br.Brand_Id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteBrand(String id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("DELETE FROM brand WHERE id = '{0}'",id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch
            {
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
