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
    }
}
