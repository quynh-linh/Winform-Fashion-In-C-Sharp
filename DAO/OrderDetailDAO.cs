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
    public class OrderDetailDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllOrderDetail()
        {
            DataTable dtOrder = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM order_detail";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter dtAdapter = new MySqlDataAdapter(sql, conn);
                dtAdapter.Fill(dtOrder);
            }
            catch
            {
                Console.WriteLine("ket noi that bai !");
            }
            finally
            {
                conn.Close();
            }
            return dtOrder;

        }

        public bool addOrder(Order_DetailDTO orderDetail)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO order_detail(product_detail_id,order_id,price,quantity)" + "VALUES ('{0}','{1}','{2}','{3}')", orderDetail.Product_Detail_Id1, orderDetail.Order_Id, orderDetail.Price, orderDetail.Quantity);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        public bool updateOrderDetail(Order_DetailDTO orderDetail)
        {
            try
            {
                conn.Open();
                //(customer_id, order_status, ammount, payment_method, create_time)
                String sql = String.Format("UPDATE order_detail " +
                    "SET " +
                    "product_detail_id= '{0}'" +
                    "order_id= '{1}'" +
                    "price= '{2}'" +
                    "quantity= '{3}'" +
                    "WHERE id = '{4}'", orderDetail.Product_Detail_Id1, orderDetail.Order_Id, orderDetail.Price, orderDetail.Quantity, orderDetail.Id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        public bool deleteOrderDetail(String id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("DELETE FROM order_detail WHERE id = '{0}'", id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
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
    }
}
