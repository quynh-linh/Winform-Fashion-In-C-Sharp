using DAO;
using DTO;
using System;
using System.Collections;
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
        //ProductDTO productDTO = new ProductDTO();
        ArrayList arrSell;
        public ArrayList getArrayListSell()
        {
            arrSell = new ArrayList();
            arrSell = sellDAO.getProduct();
            return arrSell;
        }
        public ArrayList checkSize(ProductDTO data)
        {
            return sellDAO.checkSize(data);
        }
        public ArrayList selectSize(string name, int size)
        {
            return sellDAO.selectSize(name, size);
        }

        public ArrayList searchProducts(String keyword, String cbb)
        {
            return sellDAO.searchProducts(keyword, cbb);
        }

    }
}
