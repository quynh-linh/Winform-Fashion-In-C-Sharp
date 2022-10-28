using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class DiscountBUS
    {
        DiscountDAO dcDAO = new DiscountDAO();
        public DataTable getDiscount()
        {
            return dcDAO.SelectDiscount();
        }
        public DataTable getIdProduct()
        {
            return dcDAO.SelectProduct();

        }
        public bool addDiscount(DiscountDTO dt)
        {
            if (dcDAO.addDiscount(dt))
            {
                return true;
            }
            return false;
        }
        public bool editDiscount(DiscountDTO dt)
        {
            if (dcDAO.editDiscount(dt))
            {
                return true;
            }
            return false;
        }
        public bool deleteDiscount(String id)
        {
            if (dcDAO.deleteDiscount(id))
            {
                return true;
            }
            return false;
        }

    }
}
