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
    public class ProductsBUS
    {
        productDAO productDAO = new productDAO();
        public DataTable getProducts()
        {
            return productDAO.selectAllProducts();
        }
        public bool addProducts(ProductDTO pd)
        {
            if (productDAO.addProducts(pd))
            {
                return true;
            }
            return false;
        }
        public bool checkSizeProducts(int size_id , string name_products)
        {
            if (productDAO.checkSizeProducts(size_id,name_products))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public DataTable searchProducts(String key)
        {
            return productDAO.searchProducts(key);
        }
        public bool editProducts(ProductDTO pd)
        {
            if (productDAO.editProducts(pd))
            {
                return true;
            }
            return false;
        }
        public bool removeProducts(String idProducts)
        {
            if (productDAO.removeProducts(idProducts))
            {
                return true;
            }
            return false;
        }
    }
}
