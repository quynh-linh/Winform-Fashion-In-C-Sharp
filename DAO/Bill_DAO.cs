using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class Bill_DAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public bool insert_Bill(Bill_DTO bill)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO bill(bill_Id ,bill_Total, bill_Time, account_Id , customer_Id )" + "VALUES ('{0}',{1},'{2}',{3},'{4}')", bill.Bill_Id, bill.Total, bill.Bill_Time, bill.Account_Id, bill.Customer_Id);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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

        public int countGenerateId()
        {
            DataTable data = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from bill";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(data);
                return data.Rows.Count;
            }
            catch
            {
                Console.Read();
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }

        public bool insert_Detail_Bill(Bill_Detail_DTO bill_Detail)
        {
            try
            {
                conn.Open();
                String sql = String.Format("INSERT INTO bill_detail(bill_Id ,product_Id, size, quantity , price )" + "VALUES ('{0}','{1}','{2}','{3}','{4}')", bill_Detail.Bill_Id, bill_Detail.Product_Id, bill_Detail.Size, bill_Detail.Quantity, bill_Detail.Price);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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

        public bool update_Quantity_After_Payment(String product_Id, int quantity)
        {
            try
            {
                conn.Open();
                String sql = String.Format("UPDATE product SET quantity = quantity - " + quantity + " WHERE id = '" + product_Id + "'");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                Console.WriteLine(sql);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
