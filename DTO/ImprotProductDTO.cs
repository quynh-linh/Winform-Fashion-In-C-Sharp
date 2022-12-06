using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImprotProductDTO
    {
        private string maPhieuNhap;
        private string ngayNhap;
        private int maNhanVien;
        private string maNCC;
        private double tongtien;

        public ImprotProductDTO() { }
        public ImprotProductDTO(string maPhieuNhap, string ngayNhap, int maNhanVien, string maNCC, double tongtien)
        {
            this.maPhieuNhap = maPhieuNhap;
            this.ngayNhap = ngayNhap;
            this.maNhanVien = maNhanVien;
            this.maNCC = maNCC;
            this.tongtien = tongtien;
        }
        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public int MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}
