using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    internal class CTaiKhoan
    {
        private string tenDangNhap;
        private string matKhau;
        private string loaiTaiKhoan;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        public CTaiKhoan(string tenDangNhap, string matKhau, string loaiTaiKhoan)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }
    }
}
