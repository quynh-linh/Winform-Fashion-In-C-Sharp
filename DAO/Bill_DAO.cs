using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Bill_DAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectBillAbout(string from, string to)
        {
            DataTable dtBill= new DataTable();
            try
            {
                conn.Open();
                String sql = String.Format("select bill_Id, bill_Total, bill_Time, account_Id, customer_Id from bill where bill_time between '{0}' and '{1}'",from,to);
                // String sql = String.Format("select bill_Id, bill_Total, bill_Time, account_Id, customer_Id from bill where bill_time >= CAST('{0}' AS DATETIME) and bill_time <= CAST('{1}' AS DATETIME)", from, to);
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtBill);
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

            return dtBill;

        }

        public DataTable selectBillAboutAndCustomerNotNull(string from, string to) {
            DataTable dtBill = new DataTable();
            try {
                conn.Open();
                String sql = String.Format("select bill_Id, bill_Total, bill_Time, account_Id, customer_Id from bill where bill_time between '{0}' and '{1}' and customer_id not in ('null') order by bill_Total", from, to);
                // String sql = String.Format("select bill_Id, bill_Total, bill_Time, account_Id, customer_Id from bill where bill_time >= CAST('{0}' AS DATETIME) and bill_time <= CAST('{1}' AS DATETIME)", from, to);
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtBill);
            }
            catch (Exception e) {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();

            }
            finally {
                conn.Close();
            }

            return dtBill;

        }

        public DataTable findBillByCustomerId(String id) {
            DataTable dtBill = new DataTable();
            try {
                conn.Open();
                String sql = String.Format("select bill_Id, bill_Total, bill_Time, account_Id, customer_Id from bill where customer_id like '{0}'", id);
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtBill);
            }
            catch (Exception e) {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();

            }
            finally {
                conn.Close();
            }

            return dtBill;

        }

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
        public DataTable getBillDetailsByBillId(string billId) {
            DataTable dtBill = new DataTable();
            try {
                conn.Open();
                String sql = String.Format("select * from bill_detail where bill_id = '{0}'", billId);
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtBill);
            }
            catch (Exception e) {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally {
                conn.Close();
            }

            return dtBill;
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
                String sql = String.Format("INSERT INTO bill_detail(bill_Id ,product_Id, size, quantity , price , percent_Discount)" + "VALUES ('{0}','{1}','{2}','{3}','{4}', {5})", bill_Detail.Bill_Id, bill_Detail.Product_Id, bill_Detail.Size, bill_Detail.Quantity, bill_Detail.Price, bill_Detail.Percent);
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

        public DataTable getSumQuantityProductOfBill() {
            DataTable dtBill = new DataTable();
            try {
                conn.Open();
                String sql = String.Format("select SUM(quantity) as sum from bill_detail where 1");
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtBill);
            }
            catch (Exception e) {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally {
                conn.Close();
            }

            return dtBill;
        }

        public Bill_DTO get_Bill_By_Id(String id)
        {
            Bill_DTO bill = new Bill_DTO();
            DataTable Bill = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from bill where bill_Id = '"+id+"'";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(Bill);
                if(Bill.Rows.Count > 0)
                {
                    bill.Bill_Id = Bill.Rows[0][0].ToString();
                    bill.Total = Convert.ToDouble(Bill.Rows[0][1]);
                    bill.Bill_Time = Bill.Rows[0][2].ToString();
                    bill.Account_Id = Convert.ToInt32(Bill.Rows[0][3]);
                    bill.Customer_Id = Bill.Rows[0][4].ToString();
                }
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
            return bill;
        }

        public ArrayList get_Detail_Bill_By_Id(String id)
        {
            ArrayList arr = new ArrayList();
            DataTable Bill = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from bill_detail where bill_Id = '" + id + "'";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(Bill);
                for (int i = 0; i < Bill.Rows.Count; i++)
                {
                    Bill_Detail_DTO bill = new Bill_Detail_DTO();
                    bill.Bill_Id = Bill.Rows[i][0].ToString();
                    bill.Product_Id = Bill.Rows[i][1].ToString();
                    bill.Size = Bill.Rows[i][2].ToString();
                    bill.Quantity = Convert.ToInt32(Bill.Rows[i][3]);
                    bill.Price = Convert.ToDouble(Bill.Rows[i][4]);
                    bill.Percent = Convert.ToInt32(Bill.Rows[i][5]);
                    arr.Add(bill);
                }
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
            return arr;
        }

        public String get_Name_Staff_By_Id(int id)
        {
            String name = "";
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String sql = "select full_name from account where id = " + id;
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dt);
                name = dt.Rows[0][0].ToString();
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

            return name;
        }

        public String get_Name_Customer_By_Id(String id)
        {
            String name = "";
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String sql = "select nameCustomer from customer where idCustomer  = '" + id + "'";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dt);
                name = dt.Rows[0][0].ToString();
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

            return name;
        }

        public ProductDTO get_Product_In_Detail_Bill(String id, int size)
        {
            ProductDTO pd = new ProductDTO();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT * FROM product WHERE id= '" + id + "' AND size_id  = " + size + " AND IsDeleted <> 0";
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dt);
                pd.Product_Id = dt.Rows[0][0].ToString();
                pd.Product_Name = dt.Rows[0][1].ToString();
                pd.Product_Price = Double.Parse(dt.Rows[0][2].ToString());
                pd.Image = dt.Rows[0][3].ToString();
                pd.Description = dt.Rows[0][4].ToString();
                pd.Brand_id = dt.Rows[0][5].ToString();
                pd.Category_Id = dt.Rows[0][6].ToString();
                pd.Size_id = int.Parse(dt.Rows[0][7].ToString());
                pd.Quantity = int.Parse(dt.Rows[0][8].ToString());

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

            return pd;
        }
    }
}
