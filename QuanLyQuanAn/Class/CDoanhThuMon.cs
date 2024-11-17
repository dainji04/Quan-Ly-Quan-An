using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    internal class CDoanhThuMon
    {
        private string tenMon;
        private int soLuong;
        private double doanhThu;
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DoanhThu { get => doanhThu; set => doanhThu = value; }

        public CDoanhThuMon()
        {
            TenMon = "";
            SoLuong = 0;
            DoanhThu = 0;
        }
    }
}
