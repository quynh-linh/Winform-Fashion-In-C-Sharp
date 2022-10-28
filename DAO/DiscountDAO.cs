using MySql.Data.MySqlClient;
using System;
using System.Data;
using DTO;
using System.Diagnostics;

namespace DAO
{
    public class DiscountDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable SelectDiscount()
        {
            DataTable dtDiscount = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT ds.maDiscount , ds.sale_percent , ds.start_day , ds.end_day ,pd.name as nameProduct from discount as ds, product as pd where pd.id = ds.maProduct";
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter adt = new MySqlDataAdapter(sql, conn);
                adt.Fill(dtDiscount);
            }
            catch(Exception e)
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
                MySqlDataAdapter adt = new MySqlDataAdapter(sql,conn);
                adt.Fill(dtProduct);
            }
            catch(Exception e)
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
                String sql = String.Format("INSERT INTO discount(maDiscount,maProduct,sale_percent,start_day,end_day)"
                    + "VALUES ('{0}','{1}','{2}','{3}','{4}')",
                    dt.Ma_discount,dt.Ma_product,dt.Sale_percent,dt.Start_day,dt.End_day);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if(cm.ExecuteNonQuery() > 0)
                {
                    return true;

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("loi add discount : " + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool editDiscount(DiscountDTO dt)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE discount" +
                    " SET " +
                    "maDiscount = '{0}'," +
                    "sale_percent = '{1}'," +
                    "start_day = '{2}'," +
                    "end_day = '{3}' " +
                    "WHERE  maProduct = '{4}'",dt.Ma_discount,dt.Sale_percent,dt.Start_day,dt.End_day,dt.Ma_product);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if(cm.ExecuteNonQuery() > 0)
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
        public bool deleteDiscount(String id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("DELETE FROM discount WHERE maDiscount = '{0}'", id);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                if( cm.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("loi delete discount :" + e.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
}
