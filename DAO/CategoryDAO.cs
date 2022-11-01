using System;
using System.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class CategoryDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public DataTable selectAllCategory()
        {
            DataTable dtCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from category order by id";
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

        public Boolean addCategory(CategoryDTO category)
        {
            try
            {
                conn.Open();
                string sql = string.Format("INSERT INTO category(id,nameCategory)" +
                   " VALUES ('{0}', '{1}')", category.Category_Id, category.Category_Name);
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

        public bool fixCategory(CategoryDTO category)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE category " +
                    "SET " +
                    "nameCategory= '{0}'" +
                    "WHERE id = '{1}'", category.Category_Name, category.Category_Id);
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
        public bool deleteCategory(String id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM category WHERE id = '{0}'", id);
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

        public DataTable searchCategory(String keyword)
        {
            DataTable searchCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from category where nameCategory LIKE  '%" + keyword + "%'";
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
                String sql = "select * from category where nameCategory = '"+ name +"' and id not in ('"+ id +"')";
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
