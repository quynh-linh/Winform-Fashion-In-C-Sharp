using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class RoleDAO
    {
        MySqlConnection conn = DBUtils.GetDBConnection();

        public DataTable selectAllRole()
        {
            DataTable dtRole = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from role order by id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dtRole);
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

            return dtRole;
        }

        public Boolean addRole(RoleDTO role)
        {
            try
            {
                conn.Open();
                string sql = string.Format("INSERT INTO role(id,role_name,role_description)" +
                   " VALUES ('{0}', '{1}', '{2}')", role.Role_Id, role.Role_Name, role.Role_Desciption);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
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

        public bool fixRole(RoleDTO role)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("UPDATE role " +
                    "SET " +
                    "role_name= '{0}'," +
                    "role_description = '{1}'" +
                    "WHERE id = '{2}'", role.Role_Name,role.Role_Desciption, role.Role_Id);
                Console.WriteLine(SQL);
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("abc: " + e);
                Console.Read();
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }
        public bool deleteRole(String id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM role WHERE id = '{0}'", id);
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

        public DataTable searchRole(String keyword)
        {
            DataTable searchRole = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from role where role_name LIKE  '%" + keyword + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                Console.WriteLine(returnVal);
                returnVal.Fill(searchRole);
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

            return searchRole;
        }

        public DataTable get_Role_From_Id(String id)
        {
            DataTable role = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from role where id = '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(role);
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

            return role;
        }

        public DataTable check_Name(string name, string id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from role where role_name = '" + name + "' and id not in ('"+ id +"')";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dataTable);
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

            return dataTable;
        }

        public DataTable get_Role_Name_From_Role_Id(String id)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                String sql = "select * from role where id = '" + id + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter returnVal = new MySqlDataAdapter(sql, conn);
                returnVal.Fill(dataTable);
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

            return dataTable;
        }
    }
}
