using System;
using System.Collections;
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
        public List<Bill_DTO> getBillsAboutAndCustomerIdNotNull(String from, String to) {
            DataTable dataTable = bill_DAO.selectBillAboutAndCustomerNotNull(from, to);
            List<Bill_DTO> bills = new List<Bill_DTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Bill_DTO bill_DTO = new Bill_DTO();
                bill_DTO.Bill_Id = dataTable.Rows[i]["bill_Id"].ToString();
                bill_DTO.Customer_Id = dataTable.Rows[i]["customer_Id"].ToString();
                bill_DTO.Bill_Time = dataTable.Rows[i]["bill_Time"].ToString();
                bill_DTO.Account_Id = Convert.ToInt32(dataTable.Rows[i]["account_Id"]);
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

        public List<Bill_Detail_DTO> getBillDetailsByBillId(string billId) {
            DataTable dataTable = bill_DAO.getBillDetailsByBillId(billId);
            List<Bill_Detail_DTO> billDetailDTO = new List<Bill_Detail_DTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Bill_Detail_DTO bill_DTO = new Bill_Detail_DTO();
                bill_DTO.Bill_Id = dataTable.Rows[i]["bill_Id"].ToString();
                bill_DTO.Product_Id = dataTable.Rows[i]["product_id"].ToString();
                bill_DTO.Size = dataTable.Rows[i]["size"].ToString();
                bill_DTO.Quantity = Convert.ToInt32(dataTable.Rows[i]["quantity"].ToString());
                bill_DTO.Price = Convert.ToDouble(dataTable.Rows[i]["price"].ToString());
                billDetailDTO.Add(bill_DTO);
            }
            return billDetailDTO;
        }

        public int sumQuantityOfListBillDetail(List<Bill_Detail_DTO> billDetails) {
            int total = 0;
            billDetails.ForEach(billDetailDTO => total += billDetailDTO.Quantity);
            return total;
        }
        public double sumPriceOfListBillDetail(List<Bill_Detail_DTO> billDetails) {
            double total = 0;
            billDetails.ForEach(billDetailDTO => total += billDetailDTO.Price);
            return total;
        }
        public Dictionary<string, int> revenueWithDay(List<Bill_DTO> bills) {
            Dictionary<string, int> revenue = new Dictionary<string, int>();
            bills.ForEach(billDTO => {
                DateTime dateTime = DateTime.ParseExact(billDTO.Bill_Time, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                if (revenue.ContainsKey("Ngày " + dateTime.Day)) {
                    int sum = sumQuantityOfListBillDetail(getBillDetailsByBillId(billDTO.Bill_Id));
                    revenue["Ngày " + dateTime.Day] = revenue["Ngày " + dateTime.Day] + sum;
                }
                else {
                    int sum = sumQuantityOfListBillDetail(getBillDetailsByBillId(billDTO.Bill_Id));
                    revenue.Add("Ngày " + dateTime.Day, sum);
                }
            });
            return revenue;
        }
        public Dictionary<string, int> revenueWithMonth(List<Bill_DTO> bills) {
            Dictionary<string, int> revenue = new Dictionary<string, int>();
            bills.ForEach(billDTO => {
                DateTime dateTime = DateTime.ParseExact(billDTO.Bill_Time, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                if (revenue.ContainsKey("Tháng " + dateTime.Month)) {
                    int sum = sumQuantityOfListBillDetail(getBillDetailsByBillId(billDTO.Bill_Id));
                    revenue["Tháng " + dateTime.Month] = revenue["Tháng " + dateTime.Day] + sum;
                }
                else {
                    int sum = sumQuantityOfListBillDetail(getBillDetailsByBillId(billDTO.Bill_Id));
                    revenue.Add("Tháng " + dateTime.Month, sum);
                }
            });
            return revenue;
        }

        public long getSumQuantityProductOfBill() {

            DataTable data = bill_DAO.getSumQuantityProductOfBill();
            return long.Parse(data.Rows[0][0].ToString());
        }
        public List<Bill_DTO> findBillByCustomerId(String id) {
            DataTable dataTable = bill_DAO.findBillByCustomerId(id);
            List<Bill_DTO> bills = new List<Bill_DTO>();
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Bill_DTO bill_DTO = new Bill_DTO();
                bill_DTO.Bill_Id = dataTable.Rows[i]["bill_Id"].ToString();
                bill_DTO.Customer_Id = dataTable.Rows[i]["customer_Id"].ToString();
                bill_DTO.Bill_Time = dataTable.Rows[i]["bill_Time"].ToString();
                bill_DTO.Account_Id = Convert.ToInt32(dataTable.Rows[i]["account_Id"]);
                bill_DTO.Total = Convert.ToInt32(dataTable.Rows[i]["bill_Total"]);
                bills.Add(bill_DTO);
            }
            return bills;
        }

        public Bill_DTO get_Bill_By_Id(String id)
        {
            return bill_DAO.get_Bill_By_Id(id);
        }

        public ArrayList get_Detail_Bill_By_Id(String id)
        {
            return bill_DAO.get_Detail_Bill_By_Id(id);
        }

        public String get_Name_Staff_By_Id(int id)
        {
            return bill_DAO.get_Name_Staff_By_Id(id);
        }

        public String get_Name_Customer_By_Id(String id)
        {
            return bill_DAO.get_Name_Customer_By_Id(id);
        }

        public ProductDTO get_Product_In_Detail_Bill(String id, int size)
        {
            return bill_DAO.get_Product_In_Detail_Bill(id, size);
        }

    }
}
