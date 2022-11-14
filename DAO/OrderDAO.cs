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
    public class OrderDAO
    {

        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllOrder()
        {
            DataTable dtOrder = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM order";
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

        public bool addOrder(OrderDTO order)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO order(customer_id,order_status,ammount,payment_method,create_time)" + "VALUES ('{0}','{1}','{3}','{4}')", order.Customer_Id,order.Order_Status,order.Order_Amount,order.Payment_Method,order.Create_Time);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool updateOrder(OrderDTO order)
        {
            try
            {
                conn.Open();
                //(customer_id, order_status, ammount, payment_method, create_time)
                String sql = String.Format("UPDATE order " +
                    "SET " +
                    "customer_id= '{0}'" +
                    "order_status= '{1}'" +
                    "payment_method= '{2}'" +
                    "create_time= '{3}'" +
                    "ammount= '{4}'" +
                    "WHERE id = '{5}'", order.Customer_Id, order.Order_Status,order.Payment_Method,order.Create_Time,order.Order_Amount,order.Order_Id);
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
        public bool deleteOrder(String id)
        {
            try
            {
                conn.Open();
                String sql = String.Format("DELETE FROM Order WHERE id = '{0}'", id);
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
