using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class OrderDetailBUS
    {
        private OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
        public DataTable getAllOrderDetail()
        {
            return orderDetailDAO.selectAllOrderDetail();
        }
        public bool addOrderDetail(Order_DetailDTO orderDetail)
        {
            if (orderDetailDAO.addOrder(orderDetail))
            {
                return true;
            }
            return false;
        }
        public bool updateOrderDetail(Order_DetailDTO orderDetail)
        {
            if (orderDetailDAO.updateOrderDetail(orderDetail))
            {
                return true;
            }
            return false;
        }
        public bool deleteOrderDetail(String id)
        {
            if (orderDetailDAO.deleteOrderDetail(id))
            {
                return true;
            }
            return false;
        }
    }
}
