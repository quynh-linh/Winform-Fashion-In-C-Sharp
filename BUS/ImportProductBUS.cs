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
    public class ImportProductBUS
    {
        ImportProductsDAO importDAO = new ImportProductsDAO();
        public DataTable getProducts()
        {
            return importDAO.selectProducts();
        }
        public bool addImportProduct(ImprotProductDTO ip)
        {
            if (importDAO.addImportProduct(ip))
            {
                return true;
            } else
            {
                return false;
            }
        }
        public bool addDetailImportProduct(detail_importProductDTO detail)
        {
            if (importDAO.adDetail_Product(detail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updatePriceAndQuantity(double giaNhap, int soLuong , string maSp)
        {
            if (importDAO.updatePriceAndQuantityProduct(giaNhap,soLuong,maSp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
