using System;
using System.Collections.Generic;
using System.Data;
using DAO;
using DTO;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace BUS
{
    public class CategoryBUS
    {
        private CategoryDAO categoryDAO = new CategoryDAO();

        public DataTable getAllCategory()
        {
            return categoryDAO.selectAllCategory();
        }

        public Boolean addCategory(CategoryDTO category)
        {
            if (categoryDAO.addCategory(category)) return true;
            return false;
        }

        public void insertCategories(DataTable dataTable) {
            List<CategoryDTO> categories = new List<CategoryDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                CategoryDTO categoryDTO = new CategoryDTO();
                categoryDTO.Category_Id = dataTable.Rows[i]["Mã loại sản phẩm"].ToString();
                categoryDTO.Category_Name = dataTable.Rows[i]["Tên loại sản phẩm"].ToString();
                categoryDTO.IsDeleted = 0;
                categories.Add(categoryDTO);
            }
            int index = 0;
            //check condition before insert data to database
            categories.ForEach(c => {
                if (categoryDAO.checkCategoryExist(c.Category_Id)) {
                    throw new ApplicationException("Id : " + c.Category_Id + " nằm ở dòng " + (index + 1) + " trong file excel đã tồn tại trong DB");
                }
                else {
                    // insert category to db
                    this.addCategory(c);
                    index++;
                }
            });
        }

        public Boolean fixCategory(CategoryDTO category)
        {
            if (categoryDAO.fixCategory(category)) return true;
            return false;
        }

        public Boolean deleteCategory(string id)
        {
            if (categoryDAO.deleteCategory(id)) return true;
            return false;
        }

        public DataTable searchCategory(string keyword)
        {
            return categoryDAO.searchCategory(keyword);
        }

        public Boolean check_Name(string id, string name)
        {
            if (categoryDAO.check_Name(id, name).Rows.Count > 0) return true;
            return false;
        }

        public int count()
        {
            return categoryDAO.count().Rows.Count;
        }

        public int count_Product_Belong_Category(String id)
        {
            return categoryDAO.count_Product_Belong_Category(id);
        }

        public bool delete_Product_From_Category(String id)
        {
            return categoryDAO.delete_Product_From_Category(id);
        }

    }
}
