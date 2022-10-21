using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SellBUS
    {
        private SellDAO sellDAO = new SellDAO();
        public DataTable getProduct()
        {
            return sellDAO.selectAllpruduct();
        }

    }
}
