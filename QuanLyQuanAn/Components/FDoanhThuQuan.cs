using QuanLyQuanAn.Class;
using QuanLyQuanAn.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyQuanAn.Controller;

namespace QuanLyQuanAn.Components
{
    public partial class FDoanhThuQuan : Form
    {
        public FDoanhThuQuan()
        {
            InitializeComponent();
        }

        private void FDoanhThuQuan_Load(object sender, EventArgs e)
        {
            CHoaDon hoaDon = new CHoaDon();
            CXuLyHoaDon xuLyHoaDon = new CXuLyHoaDon();
            CXuLyDoanhThuQuan xuLyDoanhThuQuan = new CXuLyDoanhThuQuan();

            xuLyHoaDon.docFile();
            xuLyDoanhThuQuan.xulydoanhthu();

            int index = 0;

            foreach(CDoanhThuQuan  dtq in xuLyDoanhThuQuan.DoanhThuQuan)
            {
                string tenQuan = dtq.TenQuan;
                chartDTQuan.Series["Food"].Points.AddXY($"{dtq.TenQuan}", dtq.Food);
                chartDTQuan.Series["Food"].Points[index].Label = dtq.Food.ToString();

                chartDTQuan.Series["Drink"].Points.AddXY($"{dtq.TenQuan}", dtq.Drink);
                chartDTQuan.Series["Drink"].Points[index].Label = dtq.Drink.ToString();

                chartDTQuan.Series["Dessert"].Points.AddXY($"{dtq.TenQuan}", dtq.Dessert);
                chartDTQuan.Series["Dessert"].Points[index].Label = dtq.Dessert.ToString();

                chartDTQuan.Series["Soup"].Points.AddXY($"{dtq.TenQuan}", dtq.Soup);
                chartDTQuan.Series["Soup"].Points[index].Label = dtq.Soup.ToString();

                index++;
            }

            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Food", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Food));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Drink", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Drink));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Dessert", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Dessert));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Soup", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Soup));

        }
    }
}
