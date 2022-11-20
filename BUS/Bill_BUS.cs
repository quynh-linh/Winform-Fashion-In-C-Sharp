using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Bill_BUS
    {
        private Bill_DAO bill_DAO = new Bill_DAO();

        public List<Bill_DTO> getBillsAbout(String from,String to)
        {
            DataTable dataTable = bill_DAO.selectBillAbout(from,to);
            List<Bill_DTO> bills = new List<Bill_DTO>();
            for (int i=0; i < dataTable.Rows.Count; i++)
            {
                Bill_DTO bill_DTO = new Bill_DTO();
                bill_DTO.Bill_Id = dataTable.Rows[i]["bill_Id"].ToString();
                bill_DTO.Customer_Id = dataTable.Rows[i]["customer_Id"].ToString();
                bill_DTO.Bill_Time = dataTable.Rows[i]["bill_Time"].ToString();
                bill_DTO.Account_Id = Convert.ToInt32 (dataTable.Rows[i]["account_Id"]);
                bill_DTO.Total = Convert.ToInt32(dataTable.Rows[i]["bill_Total"]);
                bills.Add(bill_DTO);
            }
            return bills;
        }

        public Boolean insert_Bill(Bill_DTO bill)
        {
            if (bill_DAO.insert_Bill(bill)) return true;
            return false;
        }

        public int countGenerateId()
        {
            return bill_DAO.countGenerateId();
        }

        public Boolean insert_Detail_Bill(Bill_Detail_DTO bill)
        {
            if (bill_DAO.insert_Detail_Bill(bill)) return true;
            return false;
        }

        public bool update_Quantity_After_Payment(String product_Id, int quantity)
        {
            if (bill_DAO.update_Quantity_After_Payment(product_Id, quantity)) return true;
            return false;
        }
    }
}
