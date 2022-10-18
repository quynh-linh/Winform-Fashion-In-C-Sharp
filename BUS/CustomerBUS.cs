using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class CustomerBUS
    {
       private CustomerDAO customerDAO = new CustomerDAO();
        public DataTable getThanhVien()
        {
            return customerDAO.selectAllUser();
        }
        public bool themKhachHang(CustomerDTO tv)
        {
            if (customerDAO.themKhachHang(tv))
            {
                return true;
            }
            return false ;
        }
        public bool suaKhachHang(CustomerDTO tv)
        {
            if (customerDAO.suaKhachHang(tv))
            {
                return true;
            }
            return false;
        }
        public bool xoaKhachHang(String idCustomer)
        {
            if (customerDAO.xoaKhachHang(idCustomer))
            {
                return true;
            }
            return false;
        }
    }
}
