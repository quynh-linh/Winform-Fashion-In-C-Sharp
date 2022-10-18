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
                String sql = "select * from customer";
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
    }
}
