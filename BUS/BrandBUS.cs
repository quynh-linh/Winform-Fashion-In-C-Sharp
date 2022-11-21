using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
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
        public void insertBrands(DataTable dataTable) {
            List<BrandDTO> brands = new List<BrandDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                BrandDTO brandDTO = new BrandDTO();
                brandDTO.Brand_Id = dataTable.Rows[i]["id"].ToString();
                brandDTO.Brand_Name = dataTable.Rows[i]["name"].ToString();
                brands.Add(brandDTO);
            }
            int index = 0;
            //check condition before insert data to database
            brands.ForEach(b => {
                if (brandDAO.checkBrandExist(b.Brand_Id)) {
                    throw new ApplicationException("Id : " + b.Brand_Id + " nằm ở dòng " + (index + 1) + " trong file excel đã tồn tại trong DB");
                }
                else {
                    // insert brand to db
                    this.addBrand(b);
                    index++;
                }
            });
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
