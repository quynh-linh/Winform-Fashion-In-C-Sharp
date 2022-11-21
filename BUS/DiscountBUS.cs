using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class DiscountBUS
    {
        DiscountDAO dcDAO = new DiscountDAO();
        productDAO productDAO = new productDAO();

        public DataTable getDiscount()
        {
            return dcDAO.SelectDiscount();
        }
        public DataTable getMadiscount(DiscountDTO data)
        {
            return dcDAO.SelectMadiscount(data);
        }
        public int ma(String ma)
        {
            DataTable dt = dcDAO.SelectMa(ma);
            String percent = dt.Rows[0][1].ToString();
            int p = int.Parse(percent);
            return p;
        }
        public DataTable getIdProduct()
        {
            return dcDAO.SelectProduct();

        }
        public bool addDiscount(DiscountDTO dt)
        {
            if (dcDAO.addDiscount(dt))
            {
                return true;
            }
            return false;
        }
        public bool editDiscount(DiscountDTO dt)
        {
            if (dcDAO.editDiscount(dt))
            {
                return true;
            }
            return false;
        }
        public bool deleteDiscount(String id)
        {
            if (dcDAO.deleteDiscount(id))
            {
                return true;
            }
            return false;
        }
        public void insertDiscounts(DataTable dataTable) {
            List<DiscountDTO> discounts = new List<DiscountDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                DiscountDTO discountDTO = new DiscountDTO();
                discountDTO.Ma_product = dataTable.Rows[i]["maProduct"].ToString();
                discountDTO.Ma_discount = dataTable.Rows[i]["Mã Giảm Giá"].ToString();
                discountDTO.Sale_percent = dataTable.Rows[i]["Giảm Giá"].ToString();
                discountDTO.Start_day = dataTable.Rows[i]["Ngày Bắt Đầu"].ToString();
                discountDTO.End_day = dataTable.Rows[i]["Ngày Kết Thúc"].ToString();
                discounts.Add(discountDTO);
            }
            int index = 0;
            //check condition before insert data to database
            discounts.ForEach(b => {
                if (dcDAO.checkDiscountExist(b.Ma_discount)) {
                    throw new ApplicationException("Id : " + b.Ma_discount + " nằm ở dòng " + (index + 1) + " trong file excel đã tồn tại trong DB");
                } 
                else if(productDAO.checkIdProducts(b.Ma_product)){
                    throw new ApplicationException("Product ID : " + b.Ma_product + " là trường duy nhất không được phép trùng (dòng "+(index+1)+") ");
                }
                else {
                    // insert discount to db
                    this.addDiscount(b);
                    index++;
                }
            });
        }
    }
}
