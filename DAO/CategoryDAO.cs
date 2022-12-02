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
                String sql = "select id, nameCategory from category where isDeleted = 0 ";
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
                string sql = string.Format("INSERT INTO category(id,nameCategory,isDeleted)" +
                   " VALUES ('{0}', '{1}',0)", category.Category_Id, category.Category_Name);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
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
                string SQL = string.Format("UPDATE category " +
                    "SET " +
                    "isDeleted = 1 " +
                    "WHERE id = '{0}'", id);
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
                String sql = "select id, nameCategory from category where nameCategory LIKE  '%" + keyword + "%' and isDeleted = 0";
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
                String sql = "select id, nameCategory from category where nameCategory = '" + name + "' and id not in ('" + id + "') and isDeleted = 0";
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

        public DataTable count()
        {
            DataTable data = new DataTable();

            try
            {
                conn.Open();
                String sql = "select * from category";
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

        public bool checkCategoryExist(string id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("SELECT * FROM `category` WHERE id = '{0}'", id);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                var reader = cm.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public int count_Product_Belong_Category(String id)
        {
            int count = 0;
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT COUNT(category_id) as count FROM product WHERE IsDeleted <> 0 AND category_id = '" + id + "'";
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
                count = data.Rows.Count;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

        public bool delete_Product_From_Category(String id)
        {
            try
            {
                conn.Open();
                string SQL = "UPDATE product SET IsDeleted = 0 WHERE category_id = '" + id + "'";
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
                conn.Close();
            }
            return false;
        }
    }
}
