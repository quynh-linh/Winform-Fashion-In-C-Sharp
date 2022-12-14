using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class detail_importProductDTO
    {
        private int maChiTiet;
        private string maSanPham;
        private int SoLuong;
        private double GiaNhap;
        private double sunmoney;
        private string maChiTietPN;
        private int size;

        public detail_importProductDTO()
        {
        }

        public detail_importProductDTO(string maSanPham, int soLuong, double giaNhap, double sunmoney, string maChiTietPN, int size)
        {
            this.maSanPham = maSanPham;
            this.SoLuong = soLuong;
            this.GiaNhap = giaNhap;
            this.sunmoney = sunmoney;
            this.maChiTietPN = maChiTietPN;
            this.size = size;
        }

        public detail_importProductDTO(int maChiTiet, string maSanPham, int soLuong, double giaNhap, double sunmoney, string maChiTietPN, int size)
        {
            this.maChiTiet = maChiTiet;
            this.maSanPham = maSanPham;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            this.sunmoney = sunmoney;
            this.maChiTietPN = maChiTietPN;
            this.size = size;
        }
        public int MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public double GiaNhap1 { get => GiaNhap; set => GiaNhap = value; }
        public double Sunmoney { get => sunmoney; set => sunmoney = value; }
        public string MaChiTietPN { get => maChiTietPN; set => maChiTietPN = value; }
        public int Size { get => size; set => size = value; }
    }
}
