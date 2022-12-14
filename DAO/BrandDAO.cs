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
                String sql = "SELECT id, name FROM brand WHERE isDelete = 0";
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
                String sql = "SELECT * FROM brand WHERE isDelete = 0";
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
                String sql = String.Format("INSERT INTO brand(id,name,isDelete)" + "VALUES ('{0}','{1}',0)",br.Brand_Id,br.Brand_Name,br.IsDelete);
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
        public bool deleteBrand(string id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE brand " +
                    "SET " +
                    "isDelete = 1 " +
                    "WHERE id = '{0}'",id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool checkBrandExist(string id) {
            try {
                conn.Open();
                String sql = String.Format("SELECT * FROM `brand` WHERE id = '{0}'", id);
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
        // search
        public DataTable searchBrand(String keyword)
        {
            DataTable searchCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select id, name from brand where name LIKE  '%" + keyword + "%' and isDelete = 0";
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
        public DataTable check_Name(string id, string name)
        {
            DataTable data = new DataTable();

            try
            {
                conn.Open();
                String sql = "select id, name from brand where name = '" + name + "' and id not in ('" + id + "') and isDelete = 0";
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
