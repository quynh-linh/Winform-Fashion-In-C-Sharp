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
    public class ImportProductsDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectProducts()
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT pd.id , pd.price , pd.name  , pd.quantity ,br.name as nameBrand , " +
                    "ct.nameCategory as nameCate , s.name as sizename " +
                    "FROM product as pd , brand as br ,  category as ct , size as s " +
                    "WHERE pd.brand_id = br.id AND pd.category_id = ct.id AND pd.size_id = s.id";
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(ds);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }
        public bool addImportProduct(ImprotProductDTO ip)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO `imprort_product`(`maPhieuNhap`, `ngayNhap`, `maNhanVien`, `maNCC`, `tongtien`) " +
                    "VALUES ('{0}','{1}','{2}','{3}','{4}')", ip.MaPhieuNhap , ip.NgayNhap  , ip.MaNhanVien , ip.MaNCC , ip.Tongtien);
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
        public bool adDetail_Product(detail_importProductDTO detail)
        {
            try
            {
                // Kết nối
                conn.Open();
                string SQL = string.Format("INSERT INTO `detail_import`(`maChiTiet`, `maSanPham`, `SoLuong`, `GiaNhap`, `sunmoney`,`maPhieuNhap`)" +
                    " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", null,detail.MaSanPham, detail.SoLuong1,detail.GiaNhap1,detail.Sunmoney,detail.MaChiTietPN);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }
        public bool updatePriceAndQuantityProduct(double giaNhap, int soLuong , string maSp)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE product " +
                    "SET `price`= {0} ," +
                    "`quantity`= quantity + {1} " +
                    "WHERE id = '{2}'",giaNhap,soLuong,maSp);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            } catch(Exception e){
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
