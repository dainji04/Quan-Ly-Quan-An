using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    internal class CDoanhThuMon
    {
        private string id;
        private int soLuong;
        private double doanhThu;
        public string Id {
            get => id; set => id = value; 
        }
        public int SoLuong 
        { get => soLuong; set => soLuong = value; }
        public double DoanhThu
        { get => doanhThu; set => doanhThu = value; }
        public CDoanhThuMon()
        {
            Id = "";
            SoLuong = 0;
            DoanhThu = 0;
        }
    }
}
