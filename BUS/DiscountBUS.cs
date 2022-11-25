using DAO;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class DiscountBUS
    {
        DiscountDAO dcDAO = new DiscountDAO();
        productDAO productDAO = new productDAO();

        public DataTable get_All_Discount( String s)
        {
            return dcDAO.get_All_Discount(s);
        }

        public DataTable load_Discount(String search, String cbb)
        {
            return dcDAO.load_Discount(search,cbb);
        }

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

        public bool check_Name(int percent, String id)
        {
            if (dcDAO.check_Name(percent, id).Rows.Count > 0) return true;
            return false;
        }

        public bool check_Discount_Id(String id)
        {
            if (dcDAO.check_Discount_Id(id).Rows.Count == 0) return true;
            return false;
        }

        public ArrayList load_Product_Remaining(String search, String cbb)
        {
            return dcDAO.load_Product_Remaining(search, cbb);
        }

        public ArrayList load_Detail_Discount(String id)
        {
            ArrayList list = new ArrayList();
            for(int i=0;i< dcDAO.load_Detail_Discount(id).Rows.Count; i++)
            {
                Discount_Detail_DTO dc = new Discount_Detail_DTO(dcDAO.load_Detail_Discount(id).Rows[i][0].ToString(), dcDAO.load_Detail_Discount(id).Rows[i][1].ToString());
                list.Add(dc);
            }
            return list;
        }

        public ArrayList load_Data_Category()
        {
            ArrayList list = new ArrayList();
            list.Add("Tất cả");
            for (int i = 0; i < dcDAO.load_Data_Category().Rows.Count; i++)
                list.Add(dcDAO.load_Data_Category().Rows[i][0].ToString());
            return list ;
        }

        public ProductDTO get_Product_By_Id(String id)
        {
            DataTable data = dcDAO.get_Product_By_Id(id);
            String pro_id = data.Rows[0][0].ToString();
            String name = data.Rows[0][1].ToString();
            double price = Double.Parse(data.Rows[0][2].ToString());
            String img = data.Rows[0][3].ToString();
            String des = data.Rows[0][4].ToString();
            String brand = data.Rows[0][5].ToString();
            String cate = data.Rows[0][6].ToString();
            int size = int.Parse(data.Rows[0][7].ToString());
            int quantity = int.Parse(data.Rows[0][8].ToString());
            return new ProductDTO(pro_id, name, price, img, des, brand, cate, size, quantity);
        }

        public int get_Percent(String id)
        {
            return dcDAO.get_Percent(id);
        }

        public bool insert_Detail_Discount(String discount_Id, String product_Id)
        {
            return dcDAO.insert_Detail_Discount(discount_Id, product_Id);
        }

        public bool delete_Detail_Discount(String discount_Id)
        {
            return dcDAO.delete_Detail_Discount(discount_Id);
        }
            public void insertDiscounts(DataTable dataTable) {
            List<DiscountDTO> discounts = new List<DiscountDTO>();
            //convert datatable to list<obj>
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                DiscountDTO discountDTO = new DiscountDTO();
                //discountDTO.Ma_product = dataTable.Rows[i]["maProduct"].ToString();
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
                //else if(productDAO.checkIdProducts(b.Ma_product)){
                    //throw new ApplicationException("Product ID : " + b.Ma_product + " là trường duy nhất không được phép trùng (dòng "+(index+1)+") ");
                //}
                else {
                    // insert discount to db
                    this.addDiscount(b);
                    index++;
                }
            });
        }
    }
}
