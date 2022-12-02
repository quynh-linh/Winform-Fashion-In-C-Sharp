using MySql.Data.MySqlClient;
using System;
using DTO;
using System.Data;

namespace DAO
{
    public class CustomerDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectAllUser() {
            //Tạo đối tượng Connection
            //tạo đối tượng DataSet
            DataTable dtThanhvien = new DataTable();     
            try
            {
                conn.Open();
                Console.WriteLine("Bắt đầu mở kết nối ...");
                Console.WriteLine("Kết nối thành công !");
                //Lấy toàn bộ dữ liệu từ bảng tblMatHang
                String sql = "select * from customer where idCustomer not in ('null') ";
                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(dtThanhvien);
                returnVal.Fill(dtThanhvien);
            }
            catch (Exception e)
            {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return dtThanhvien;
        }
        
        public DataTable findCustomerById(String id) {
            //Tạo đối tượng Connection
            //tạo đối tượng DataSet
            DataTable dtThanhvien = new DataTable();
            try {
                conn.Open();
                Console.WriteLine("Bắt đầu mở kết nối ...");
                Console.WriteLine("Kết nối thành công !");
                //Lấy toàn bộ dữ liệu từ bảng tblMatHang
                String sql = String.Format("select * from customer where idCustomer = '{0}' ",id);
                //Khởi tạo đối tượng DataAdapter và cung cấp vào câu lệnh SQL và đối tượng Connection
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(dtThanhvien);
                returnVal.Fill(dtThanhvien);
            }
            catch (Exception e) {
                Console.WriteLine("Kết nối thất bại với lỗi sau: " + e.Message);
                Console.Read();
            }
            finally {
                // Dong ket noi
                conn.Close();
            }
            return dtThanhvien;
        }
        
        public bool themKhachHang(CustomerDTO ct) {
            try
            {
                // Ket noi
                conn.Open();
               string SQL = string.Format("INSERT INTO customer(idCustomer,nameCustomer, address, phone,sex)" +
                   " VALUES ('{0}', '{1}', '{2}','{3}','{4}')",ct.IdCustomer,ct.NameCustomer,ct.AddressCustomer,ct.PhoneCustomer,ct.SexCustomer);
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
        public bool suaKhachHang(CustomerDTO ct)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("UPDATE customer " +
                    "SET " +
                    "nameCustomer= '{0}'," +
                    "address= '{1}'," +
                    "phone= '{2}'," +
                    "sex= '{3}' " +
                    "WHERE idCustomer = '{4}'",ct.NameCustomer,ct.AddressCustomer,ct.PhoneCustomer,ct.SexCustomer,ct.IdCustomer);
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
        public bool xoaKhachHang(String id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM customer WHERE idCustomer = '{0}'",id);
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

        public bool checkCustomerExist(string id) {
            try {
                conn.Open();
                String sql = String.Format("SELECT * FROM `customer` WHERE idCustomer = '{0}'", id);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                var reader = cm.ExecuteReader();
                if (reader.HasRows) {
                    return true;
                }
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.Read();
            }
            finally {
                conn.Close();
            }
            return false;
        }

        public String get_Customer_By_Phone(string phone, String ss)
        {
            String s = null;
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                String sql = String.Format("SELECT idCustomer, nameCustomer FROM `customer` WHERE phone = {0}", phone);
                Console.WriteLine(sql);
                MySqlCommand cm = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dt);
                if (dt.Rows.Count > 0) 
                    if(ss.Equals("name"))
                        return ss = dt.Rows[0][1].ToString();
                    else return dt.Rows[0][0].ToString();

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
            return null;
        }

        public DataTable count()
        {
            DataTable data = new DataTable();

            try
            {
                conn.Open();
                String sql = "select * from customer";
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
