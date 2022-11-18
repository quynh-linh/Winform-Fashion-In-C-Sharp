using MySql.Data.MySqlClient;
using System;
using DTO;
using System.Collections;

namespace DAO
{
    public class SellDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public ArrayList getProduct()
        {
            ArrayList arrayListSell = new ArrayList();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM product GROUP BY name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ProductDTO productDTO = new ProductDTO();
                    productDTO.Product_Id = mySqlDataReader["id"].ToString();
                    productDTO.Product_Name = mySqlDataReader["name"].ToString();
                    productDTO.Product_Price = (double)mySqlDataReader["price"];
                    productDTO.Image = mySqlDataReader["image"].ToString();
                    productDTO.Description = mySqlDataReader["description"].ToString();
                    productDTO.Brand_id = mySqlDataReader["brand_id"].ToString();
                    productDTO.Category_Id = mySqlDataReader["category_id"].ToString();
                    productDTO.Size_id = (int)mySqlDataReader["size_id"];
                    productDTO.Quantity = (int)mySqlDataReader["quantity"];
                    arrayListSell.Add(productDTO);
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
            return arrayListSell;
        }
        //check size
        public ArrayList checkSize(ProductDTO data)
        {
            ArrayList arrayListSell = new ArrayList();
            try
            {
                conn.Open();
                String sql = "SELECT size_id  FROM product WHERE name = '" + data.Product_Name + "' ORDER BY size_id";
                Console.WriteLine("loi" + data.Product_Name);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    arrayListSell.Add(mySqlDataReader["size_id"].ToString());
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
            return arrayListSell;
        }
        public ArrayList selectSize(string name, int size)
        {
            ArrayList arrayListSell = new ArrayList();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM product WHERE name = '" + name + "' AND size_id = '" + size + "' ";
                Console.WriteLine("loi" + sql);

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ProductDTO productDTO = new ProductDTO();
                    productDTO.Product_Id = mySqlDataReader["id"].ToString();
                    productDTO.Product_Name = mySqlDataReader["name"].ToString();
                    productDTO.Product_Price = (double)mySqlDataReader["price"];
                    productDTO.Image = mySqlDataReader["image"].ToString();
                    productDTO.Description = mySqlDataReader["description"].ToString();
                    productDTO.Brand_id = mySqlDataReader["brand_id"].ToString();
                    productDTO.Category_Id = mySqlDataReader["category_id"].ToString();
                    productDTO.Size_id = (int)mySqlDataReader["size_id"];
                    productDTO.Quantity = (int)mySqlDataReader["quantity"];
                    arrayListSell.Add(productDTO);
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
            return arrayListSell;
        }

    }
}
