using DAO;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using DataTable = System.Data.DataTable;

namespace BUS
{
    public class CustomerBUS
    {
       private CustomerDAO customerDAO = new CustomerDAO();
        public DataTable getThanhVien()
        {
            return customerDAO.selectAllUser();
        }
        public long quantityCustomer() {
            return long.Parse(customerDAO.selectAllUser().Rows.Count.ToString());
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
        public CustomerDTO findCustomerById(String id) {
            DataTable data = customerDAO.findCustomerById(id);
            CustomerDTO customer = new CustomerDTO();
            customer.IdCustomer = data.Rows[0]["idCustomer"].ToString();
            customer.NameCustomer = data.Rows[0]["nameCustomer"].ToString();
            customer.AddressCustomer = data.Rows[0]["address"].ToString();
            customer.PhoneCustomer = Convert.ToInt32(data.Rows[0]["phone"].ToString());
            customer.SexCustomer = data.Rows[0]["sex"].ToString();
            return customer;
        }
        public String get_Customer_By_Phone(string phone, String ss)
        {
            return customerDAO.get_Customer_By_Phone(phone, ss);
        }


        public void insertCustomers(DataTable dataTable) {
            List<CustomerDTO> customers = new List<CustomerDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                CustomerDTO customerDTO = new CustomerDTO();
                customerDTO.IdCustomer = dataTable.Rows[i]["Mã Khách Hàng"].ToString();
                customerDTO.NameCustomer = dataTable.Rows[i]["Tên Khách Hàng"].ToString();
                customerDTO.AddressCustomer = dataTable.Rows[i]["Địa chỉ"].ToString();
                customerDTO.PhoneCustomer = Convert.ToInt32(dataTable.Rows[i]["Số điện thoại"].ToString());
                customerDTO.SexCustomer = dataTable.Rows[i]["Giới Tính"].ToString();
                customers.Add(customerDTO);
            }
            int index = 0;
            //check condition before insert data to database
            customers.ForEach(b => {
                if (customerDAO.checkCustomerExist(b.IdCustomer)) {
                    throw new ApplicationException("Id : " + b.IdCustomer + " nằm ở dòng " + (index + 1) + " trong file excel đã tồn tại trong DB");
                }
                else {
                    // insert customer to db
                    this.themKhachHang(b);
                    index++;
                }
            });
        }

        public int  count()
        {
            return customerDAO.count().Rows.Count;
        }
    }
}
