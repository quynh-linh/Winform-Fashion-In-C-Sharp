using System;
using System.Data;
using DAO;
using DTO;

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
    }
}
