using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    internal class CBill
    {
        private string ma;
        private string tenMon;
        private double donGia;
        private int soLuong;
        private double thanhTien;
        public string Ma { get => ma; set => ma = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double ThanhTien { get => thanhTien = donGia*soLuong; set => thanhTien = value; }
    }
}
