using DAO;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace BUS
{
    public class ImportProductBUS
    {
        ImportProductsDAO importDAO = new ImportProductsDAO();
        public DataTable getProducts()
        {
            return importDAO.selectProducts();
        }
        public DataTable getImportProducts()
        {
            return importDAO.selectImportProducts();
        }
        public DataTable getDetailImportProducts(string maPhieuNhap)
        {
            return importDAO.selectDetailImportProducts(maPhieuNhap);
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
        public DataTable searchDateImportProduct(string firstDate, string endDate)
        {
            return importDAO.searchDateImmportProducts(firstDate, endDate);
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
        public bool updatePriceAndQuantityReduce(double giaNhap, int soLuong, string maSp)
        {
            if (importDAO.updatePriceAndQuantityProductReduce(giaNhap, soLuong, maSp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updateTotalMonetImportProduct(string maPhieuNhap , double total)
        {
            if (importDAO.updateMoneyTotalImportProduct(maPhieuNhap,total))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool removeDetailImportProduct(int maChiTiet)
        {
            if (importDAO.removeDetailImportProduct(maChiTiet))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool removeImportProduct(String maPhieuNhap)
        {
            if (importDAO.removeImportProduct(maPhieuNhap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public String removeImportProductToID(String maPhieuNhap)
        {
            if (importDAO.removeDetailImportProductToId(maPhieuNhap))
            {
                if (importDAO.removeImportProduct(maPhieuNhap))
                {
                    return "Xóa thành công";
                }
            }
            else
            {
                return "Xóa không thành công";
            }
            return "";
        }
        public bool updateQuantity(int soluong, string maSp, int size_id)
        {
            if (importDAO.updateQuantityProduct(soluong,maSp,size_id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getIdProduct(string name , int size_id)
        {
            return importDAO.getIdProductToName(name, size_id);
        }
        public String updateDetailImportProduct(detail_importProductDTO detail , double total)
        {
            if (importDAO.updateDetailImportProduct(detail))
            {
                if (importDAO.updateMoneyTotalImportProduct(detail.MaChiTietPN,total))
                {
                    return "Cập nhập thành công";
                }
            }
            else
            {
                return "Cập nhập thất bại";
            }
            return "";
        }
        public long getSumQuantityProductOfImport() {
            DataTable data = importDAO.getSumQuantityProductOfImport();
            return long.Parse(data.Rows[0][0].ToString());
        }

        public List<ImprotProductDTO> getAllImportProduct() {
            List<ImprotProductDTO> improtProductDTOs= new List<ImprotProductDTO>();
            DataTable data = importDAO.selectImportProducts();
            for (int i = 0; i < data.Rows.Count; i++) {
                ImprotProductDTO improtProduct = new ImprotProductDTO();
                improtProduct.MaPhieuNhap = data.Rows[i]["maPhieuNhap"].ToString();
                improtProduct.NgayNhap = data.Rows[i]["ngayNhap"].ToString();
                improtProduct.Tongtien = Convert.ToDouble(data.Rows[i]["tongtien"].ToString());
                improtProductDTOs.Add(improtProduct);
            }
            return improtProductDTOs;
        } 
        public List<RevenueDTO> getAllRevenue() {
            List<ImprotProductDTO> improtProducts = this.getAllImportProduct();
            List<RevenueDTO> revenues = new List<RevenueDTO>();
            foreach (var item in revenueWithMonth(improtProducts)) {
                RevenueDTO revenue = new RevenueDTO();
                revenue.Month = item.Key;
                revenue.TongTien = item.Value;
                revenues.Add(revenue);
            }
            return revenues;
        }
        public Dictionary<string, double> revenueWithMonth(List<ImprotProductDTO> improtProducts) {
            Dictionary<string, double> revenue = new Dictionary<string, double>();
            improtProducts.ForEach(i => {
                DateTime dateTime = DateTime.ParseExact(i.NgayNhap , "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (revenue.ContainsKey("Tháng " + dateTime.Month)) {
                    double tongtien = i.Tongtien;
                    revenue["Tháng " + dateTime.Month] += tongtien;
                }
                else {
                    double tongtien = i.Tongtien;
                    revenue.Add("Tháng " + dateTime.Month, tongtien);
                }
            });
            return revenue;
        }

    }

}
