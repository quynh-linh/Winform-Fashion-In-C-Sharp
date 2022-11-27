using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class productDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllProducts()
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT pd.id , pd.price , pd.name , pd.description , pd.quantity , pd.image, pd.isDeleted , " +
                    "br.name as nameBrand , " +
                    "ct.nameCategory as nameCate , s.name as sizename " +
                    "FROM product as pd , brand as br ,  category as ct , size as s " +
                    "WHERE (pd.brand_id = br.id AND pd.category_id = ct.id) AND (pd.size_id = s.id AND pd.isDeleted = 1)";
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(ds);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
        public bool checkSizeProducts(int size , String name)
        {
            try
            {
                conn.Open();
                string sql = String.Format("SELECT * FROM product WHERE size_id = {0} AND name = '{1}'",size, name);
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
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool addProducts(ProductDTO pd)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO `product`(`id`, `name`, `price`, `image`, `description`, `brand_id`, `category_id`, `size_id`, `quantity`,`isDeleted`) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')"
                    , pd.Product_Id,pd.Product_Name,pd.Product_Price,pd.Image,pd.Description,pd.Brand_id,pd.Category_Id,pd.Size_id,pd.Quantity,1);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql,conn);
                if(cm.ExecuteNonQuery() >0)
                    return true;
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
        public bool checkIdProducts(string id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("SELECT * FROM `product` WHERE id = '{0}'",id);
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
        public bool editProducts(ProductDTO pd)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE `product` " +
                    " SET " +
                    "`name`='{0}'," +
                    "`price`='{1}'," +
                    "`image`='{2}'," +
                    "`description`='{3}'," +
                    "`brand_id`='{4}'," +
                    "`category_id`='{5}'," +
                    "`size_id`= '{6}'," +
                    "`quantity`= '{7}' " +
                    "WHERE `id` = '{8}'"
                    , pd.Product_Name, pd.Product_Price, pd.Image, pd.Description, pd.Brand_id, pd.Category_Id, pd.Size_id, pd.Quantity,pd.Product_Id);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0) 
                return true;
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
        public bool removeProducts(String idProducts)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE `product` SET `isDeleted`='0' WHERE id = '{0}'", idProducts);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0) 
                return true;
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
        public DataTable searchProducts(String keyword)
        {
            DataTable searchCategory = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from product where name LIKE  '%" + keyword + "%'";
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
    }
}
