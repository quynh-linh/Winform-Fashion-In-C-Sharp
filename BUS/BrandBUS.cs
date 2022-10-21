using DAO;
using DTO;
using System;
using System.Collections;
using System.Data;

namespace BUS
{
    
    public class BrandBUS
    {
        private BrandDAO brandDAO = new BrandDAO();
        ArrayList arrBrand;
        public void docBD() {
            arrBrand = new ArrayList();
            arrBrand = brandDAO.getBrand();
        }
        public ArrayList GetArrayListBrand()
        {
            return arrBrand;
        }
        public bool CheckKeyID(string id)
        {
            arrBrand = new ArrayList();
            arrBrand = brandDAO.getBrand();
            foreach (BrandDTO b in arrBrand )
            {
                if (b.Brand_Id.Equals(id))
                {
                    return true;
                }
            }
            return false; 
        }
        public DataTable getBrand()
        {
            return brandDAO.selectAllBrand();
        }
        public bool addBrand(BrandDTO br)
        {
            if (brandDAO.addBrand(br))
            {
                return true;
            }
            return false;
        }
        public bool editBrand(BrandDTO br)
        {
            if (brandDAO.editBrand(br))
            {
                return true;
            }
            return false;
        }
        public bool deleteBrand(String id)
        {
            if (brandDAO.deleteBrand(id))
            {
                return true;
            }
            return false;
        }

       
    }
}
