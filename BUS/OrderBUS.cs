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
    public class OrderBUS
    {
        private OrderDAO orderDAO = new OrderDAO();
        public DataTable getAllOrder()
        {
            return orderDAO.selectAllOrder();
        }
        public bool addOrder(OrderDTO order)
        {
            if (orderDAO.addOrder(order))
            {
                return true;
            }
            return false;
        }
        public bool updateOrder(OrderDTO order)
        {
            if (orderDAO.updateOrder(order))
            {
                return true;
            }
            return false;
        }
        public bool deleteOrder(String id)
        {
            if (orderDAO.deleteOrder(id))
            {
                return true;
            }
            return false;
        }
    }
}
