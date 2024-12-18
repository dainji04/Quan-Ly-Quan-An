using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    internal class CDoanhThuQuan
    {
        private string tenQuan;
        private double food;
        private double drink;
        private double dessert;
        private double soup;
        public string TenQuan 
        { get => tenQuan; set => tenQuan = value; }
        public double Food 
        { get => food; set => food = value; }
        public double Drink 
        { get => drink; set => drink = value; }
        public double Dessert 
        { get => dessert; set => dessert = value; }
        public double Soup 
        { get => soup; set => soup = value; }
        public CDoanhThuQuan()
        {
            TenQuan = "";
            Food = 0;
            Drink = 0;
            Dessert = 0;
            Soup = 0;
        }
    }
}
