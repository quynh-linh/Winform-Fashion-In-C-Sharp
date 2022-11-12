using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DAO
{
    public class ImportProductsDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();
        public DataTable selectImportProducts()
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                String sql = "SELECT ip.maPhieuNhap , ip.ngayNhap , ip.tongtien , ac.full_name AS full_name , br.name AS name_Brand " +
                    "FROM imprort_product AS ip, account AS ac, brand AS br " +
                    "WHERE ip.maNhanVien = ac.id AND ip.maNCC = br.id";
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
        public DataTable selectDetailImportProducts(string maPhieuNhap)
        {
            DataTable ds = new DataTable();
            try
            {
                conn.Open();
                String sql =String.Format("SELECT di.size AS size_detail , di.maChiTiet AS maChiTiet , pd.name AS maSP , di.SoLuong AS so_luong , di.GiaNhap AS gia_nhap ,di.sunmoney AS tong_tien" +
                    " FROM detail_import AS di , imprort_product AS ip , product AS pd " +
                    " WHERE (di.maPhieuNhap = '{0}' AND ip.maPhieuNhap = '{1}') AND di.maSanPham = pd.id", maPhieuNhap,maPhieuNhap);
                Console.WriteLine(sql);
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
        public DataTable searchDateImmportProducts(string firstDate , string endDate)
        {
            DataTable ds = new DataTable();
            try
            {

                string sql = String.Format("SELECT ip.maPhieuNhap , ip.ngayNhap , ip.tongtien , ac.full_name AS full_name , br.name AS name_Brand " +
                    "FROM imprort_product AS ip, account AS ac, brand AS br " +
                    "WHERE (ngayNhap BETWEEN '12/11/2022'  AND '12/11/2022') AND (ip.maNhanVien = ac.id AND ip.maNCC = br.id)", firstDate,endDate);
                Console.WriteLine(sql);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(ds);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
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
                string SQL = string.Format("INSERT INTO `detail_import`(`maChiTiet`, `maSanPham`, `SoLuong`, `GiaNhap`, `sunmoney`,`maPhieuNhap`,`size`)" +
                    " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", null,detail.MaSanPham, detail.SoLuong1,detail.GiaNhap1,detail.Sunmoney,detail.MaChiTietPN,detail.Size);
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
        public bool updateDetailImportProduct(detail_importProductDTO detail) 
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE `detail_import` " +
                    "SET " +
                    "`maSanPham`='{0}'," +
                    "`SoLuong`='{1}'," +
                    "`GiaNhap`='{2}'," +
                    "`sunmoney`='{3}'," +
                    "`size`='{4}' " +
                    "WHERE `maChiTiet`= {5} AND `maPhieuNhap`= '{6}'",detail.MaSanPham,detail.SoLuong1,detail.GiaNhap1,detail.Sunmoney,detail.Size,detail.MaChiTiet, detail.MaChiTietPN);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                conn.Close();
            }
            return false;
        }
        public string getIdProductToName(string name , int size_id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("SELECT pd.id FROM product AS pd WHERE name = '{0}' AND size_id = {1}", name , size_id);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                var reader = cmd.ExecuteReader();
                // Kiểm tra có kết quả trả về
                string id = "";
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        id = reader.GetString("id");
                    }
                    return id;
                }  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return "";
        }
        public bool updateMoneyTotalImportProduct(string maPhieuNhap, double total)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE `imprort_product` SET `tongtien`= {0} WHERE maPhieuNhap = '{1}'",total,maPhieuNhap);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                conn.Close();
            }
            return false;
        }
        public bool removeDetailImportProduct(int maChiTiet)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM `detail_import` WHERE maChiTiet = '{0}'",maChiTiet);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                conn.Close();
            }
            return false;
        }
        public bool updateQuantityProduct(int soluong , string maSp , int size_id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("UPDATE `product` SET `quantity`= quantity -'{0}' WHERE id = '{1}' AND size_id = {2}", soluong , maSp,size_id);
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                Console.WriteLine(sql); 
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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
                conn.Close();
            }
            return false;
        }
    }
}
