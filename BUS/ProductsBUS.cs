using DAO;
using DTO;
using System;
using System.Data;

namespace BUS
{
    public class ProductsBUS
    {
        productDAO productDAO = new productDAO();
        public DataTable getProducts()
        {
            return productDAO.selectAllProducts();
        }
        public string checkAddProducts(ProductDTO pd)
        {
            if (productDAO.checkIdProducts(pd.Product_Id))
            {
                return "Mã sản phẩm đã tồn tại";
            } 
            else
            {
                if (productDAO.checkSizeProducts(pd.Size_id, pd.Product_Name))
                {
                    return "Không được thêm trùng kích cỡ sản phẩm";
                } else
                {
                    if (productDAO.addProducts(pd))
                    {
                        return "Thêm thành công";
                    } else
                    {
                        return "Thêm không thành công";
                    }
                }
            }
        }
        public DataTable searchProducts(String key)
        {
            return productDAO.searchProducts(key);
        }
        public string editProducts(ProductDTO pd)
        {
            if (productDAO.editProducts(pd))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa không thành công";
            }
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
