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
    public class SizeProductsBUS
    {
        SizeProductsDAO sizeProducts = new SizeProductsDAO();
        public DataTable getSize()
        {
            return sizeProducts.selectAllSize();
        }
    }
}
