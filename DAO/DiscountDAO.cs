using MySql.Data.MySqlClient;
using System;
using System.Data;
using DTO;
using System.Diagnostics;
using System.Collections;

namespace DAO
{
    public class DiscountDAO
    {

        MySqlConnection conn = DBUtils.GetDBConnection();
        DiscountDTO discountDTO = new DiscountDTO();
        ProductDTO pro = new ProductDTO();

        public DataTable get_All_Discount(String s)
        {
            String sql = "";
            if (s.Equals("0"))
                sql = "SELECT maDiscount, sale_percent, status FROM discount WHERE isDeleted = 0";
            else sql = "SELECT maDiscount, sale_percent, status FROM discount";

            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(sql);
                adt.Fill(dtDiscount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi select : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDiscount;

        }

        public DataTable SelectDiscount()
        {
            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                //String sql = "SELECT ds.maDiscount , ds.sale_percent , ds.start_day , ds.end_day ,pd.name as nameProduct from discount as ds, product as pd where pd.id = ds.maProduct";
                String sql = "SELECT * FROM discount WHERE isDeleted = 0";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtDiscount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi select : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDiscount;

        }
        public DataTable SelectProduct()
        {
            DataTable dtProduct = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM product";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtProduct);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi select product : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtProduct;
        }
        public bool addDiscount(DiscountDTO dt)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO discount(maDiscount,sale_percent,start_day,end_day, status, isDeleted)"
                    + "VALUES ('{0}','{1}','{2}','{3}','{4}',{5})",
                    dt.Ma_discount, dt.Sale_percent, dt.Start_day, dt.End_day, dt.Status, dt.IsDeleted);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("loi add discount : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public DataTable load_Discount(String search, String cbb)
        {
            String sql = "";
            if (String.IsNullOrEmpty(search) && cbb.Equals("Tất cả"))
                sql = "SELECT maDiscount, sale_percent, status FROM discount WHERE isDeleted = 0";
            else if (!String.IsNullOrEmpty(search) && cbb.Equals("Tất cả"))
                sql = "SELECT maDiscount, sale_percent, status FROM discount WHERE isDeleted = 0 AND sale_percent LIKE '%" + search + "%'";
            else
            {
                if (cbb.Equals("Đang áp dụng"))
                    sql = "SELECT maDiscount, sale_percent, status FROM discount WHERE isDeleted = 0 AND sale_percent LIKE '%" + search + "%' AND status = 'Đang áp dụng'";
                else sql = "SELECT maDiscount, sale_percent, status FROM discount WHERE isDeleted = 0 AND sale_percent LIKE '%" + search + "%' AND status = 'Ngừng áp dụng'";
            }
            DataTable dtProduct = new DataTable();

            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtProduct);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi select product : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtProduct;
        }

        public bool editDiscount(DiscountDTO dt)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE discount" +
                    " SET " +
                    "sale_percent = '{0}'," +
                    "start_day = '{1}'," +
                    "end_day = '{2}', status = '{3}' WHERE maDiscount = '{4}'", dt.Sale_percent, dt.Start_day, dt.End_day, dt.Status, dt.Ma_discount);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteDiscount(String id)
        {
            try
            {
                conn.Open();
                String sql = "UPDATE discount SET isDeleted = 1 WHERE maDiscount = '" + id + "'";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable SelectMadiscount(DiscountDTO data)
        {
            //this.discountDTO = data 
            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                //String sql = "SELECT ds.maDiscount , ds.sale_percent , ds.start_day , ds.end_day ,pd.name as nameProduct from discount as ds, product as pd where pd.id = ds.maProduct";
                String sql = "SELECT maDiscount FROM discount";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtDiscount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi select : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDiscount;

        }
        public DataTable SelectMa(String ma)
        {
            //this.discountDTO = data 
            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                //String sql = "SELECT ds.maDiscount , ds.sale_percent , ds.start_day , ds.end_day ,pd.name as nameProduct from discount as ds, product as pd where pd.id = ds.maProduct";
                String sql = "SELECT * FROM discount WHERE maDiscount = '" + ma + "'";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtDiscount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi select : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDiscount;

        }
        public bool checkDiscountExist(string id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("SELECT * FROM `discount` WHERE id = '{0}'", id);
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

        public DataTable check_Name(int percent, String id)
        {
            String sql = "";
            if (id.Equals("-1"))
                sql = "SELECT sale_percent FROM discount WHERE isDeleted = 0 AND sale_percent = '" + percent + "'";
            else
                sql = "SELECT sale_percent FROM discount WHERE isDeleted = 0 AND sale_percent = '" + percent + "' AND maDiscount  NOT IN ('" + id + "')";
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public DataTable check_Discount_Id(String id)
        {
            String sql = "SELECT * FROM detail_discount WHERE discount_Id = '" + id + "'";

            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public ArrayList load_Product_Remaining(String search, String cbb)
        {
            String sql = "";
            if (String.IsNullOrEmpty(search) && cbb.Equals("Tất cả"))
                sql = "SELECT * FROM product WHERE name NOT IN ( SELECT name FROM product WHERE id IN (SELECT product_Id FROM detail_discount)) GROUP BY name";
            else if (!String.IsNullOrEmpty(search) && cbb.Equals("Tất cả"))
                sql = "SELECT * FROM product WHERE name NOT IN ( SELECT name FROM product WHERE id IN (SELECT product_Id FROM detail_discount)) AND name LIKE N'%" + search + "%' GROUP BY name";
            else
                sql = "SELECT * FROM product, category WHERE category.id = product.category_id AND product.name NOT IN ( SELECT name FROM product WHERE id IN (SELECT product_Id FROM detail_discount)) AND product.name LIKE N'%" + search + "%' AND category.nameCategory = '" + cbb + "' GROUP BY name";
            ArrayList list_Pro = new ArrayList();

            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    String id = data.Rows[i][0].ToString();
                    String name = data.Rows[i][1].ToString();
                    double price = Double.Parse(data.Rows[i][2].ToString());
                    String img = data.Rows[i][3].ToString();
                    String des = data.Rows[i][4].ToString();
                    String brand = data.Rows[i][5].ToString();
                    String cate = data.Rows[i][6].ToString();
                    int size = int.Parse(data.Rows[i][7].ToString());
                    int quantity = int.Parse(data.Rows[i][8].ToString());

                    pro = new ProductDTO(id, name, price, img, des, brand, cate, size, quantity);
                    list_Pro.Add(pro);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return list_Pro;
        }

        public DataTable load_Detail_Discount(String id)
        {
            String sql = "SELECT * FROM detail_discount WHERE discount_Id = '" + id + "'";

            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(sql);
                returnVal.Fill(data);
                for(int i=0;i<data.Rows.Count;i++)
                    Console.WriteLine(data.Rows[i][1].ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;
        }

        public DataTable get_Product_By_Id(String id)
        {
            String sql = "SELECT * FROM product WHERE id = '" + id + "'";
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;

        }

        public int get_Percent(String id)
        {
            String sql = "SELECT * FROM discount WHERE maDiscount = '" + id + "'";
            int percent = 0;
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
                percent = int.Parse(data.Rows[0][1] + "");
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return percent;

        }

        public bool delete_Detail_Discount(String discount_Id)
        {
            String sql = "DELETE FROM detail_discount WHERE discount_Id = '" + discount_Id + "'";

            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool insert_Detail_Discount(String discount_Id, String product_Id)
        {
            String sql = "INSERT INTO detail_discount (discount_Id, product_Id)"
                + "VALUES( '" + discount_Id + "','" + product_Id + "')";

            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if (cm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;

        }

        public DataTable load_Data_Category()
        {
            DataTable data = new DataTable();
            String sql = "SELECT nameCategory FROM category WHERE isDeleted = 0";
            try
            {
                conn.Open();
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return data;

        }

        public DataTable get_Date_From_Discount_Id(String id)
        {
            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                //String sql = "SELECT ds.maDiscount , ds.sale_percent , ds.start_day , ds.end_day ,pd.name as nameProduct from discount as ds, product as pd where pd.id = ds.maProduct";
                String sql = "SELECT start_day,end_day FROM discount WHERE isDeleted = 0 AND maDiscount = '"+id+"'";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtDiscount);
                Console.WriteLine(sql);
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi select : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtDiscount;

        }
    }
}
