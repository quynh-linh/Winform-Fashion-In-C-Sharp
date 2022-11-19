using System;
using System.Collections.Generic;
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
