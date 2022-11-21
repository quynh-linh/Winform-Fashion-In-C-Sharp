using DAO;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Principal;
using DataTable = System.Data.DataTable;

namespace BUS
{
    public class ProductsBUS
    {
        productDAO productDAO = new productDAO();
        SizeProductsDAO sizeDao = new SizeProductsDAO();
        BrandDAO brandDAO= new BrandDAO();
        CategoryDAO categoryDAO= new CategoryDAO(); 
        public const string INSERT_SUCCESSFULLY = "Thêm thành công";
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
                        return INSERT_SUCCESSFULLY;
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
    
        // Mạnh Thành insert list product
        public void insertProducts(DataTable dataTable) {
            List<ProductDTO> products = new List<ProductDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                ProductDTO productDTO = new ProductDTO();
                productDTO.Product_Id = dataTable.Rows[i]["Mã"].ToString();
                productDTO.Product_Name = dataTable.Rows[i]["Tên"].ToString();
                productDTO.Product_Price = Convert.ToDouble(dataTable.Rows[i]["Giá"]);
                productDTO.Description = dataTable.Rows[i]["Mô tả"].ToString();
                productDTO.Brand_id = dataTable.Rows[i]["Thương hiệu"].ToString();
                productDTO.Category_Id = dataTable.Rows[i]["Danh mục"].ToString();
                productDTO.Size_id = Convert.ToInt32(dataTable.Rows[i]["Kích cỡ"]);
                productDTO.Quantity = Convert.ToInt32(dataTable.Rows[i]["Số lượng"]);
                productDTO.Image = dataTable.Rows[i]["Tên ảnh"].ToString();
                products.Add(productDTO);
            }
            int index = 0;
            //check condition before insert data to database
            products.ForEach(p => { 
                Console.WriteLine(p.Product_Id + " --- "+ p.Product_Name + " --- "+ p.Product_Price + " --- "+ p.Description);
                if (productDAO.checkIdProducts(p.Product_Id)) {
                    throw new ApplicationException("Id : " + p.Product_Id + " nằm ở dòng " + (index + 1) + " trong file excel đã tồn tại trong DB");
                }
                else if (!sizeDao.checkSizeExist(p.Size_id)) {
                    throw new ApplicationException("Size id : " + p.Size_id + " nằm ở dòng " + (index + 1) + " không tồn tại trong DB");
                }
                else if (!brandDAO.checkBrandExist(p.Brand_id)) {
                    throw new ApplicationException("Brand id : " + p.Brand_id + " nằm ở dòng " + (index + 1) + " không tồn tại trong DB");
                }
                else if (!categoryDAO.checkCategoryExist(p.Category_Id)) {
                    throw new ApplicationException("Category id : " + p.Category_Id + " nằm ở dòng " + (index + 1) + " không tồn tại trong DB");
                }else if (productDAO.checkSizeProducts(p.Size_id,p.Product_Name)) {
                    throw new ApplicationException("Sản phẩm không được cùng trùng tên và size với sản phẩm đã tồn tại trong DB");
                }
                else {
                    // insert product to db
                    productDAO.addProducts(p);
                    index++;
                }
            });
        }
    }
}
