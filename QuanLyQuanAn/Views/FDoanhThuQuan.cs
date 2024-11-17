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

            foreach(CDoanhThuQuan  dtq in xuLyDoanhThuQuan.DoanhThuQuan)
            {
                chartDTQuan.Series["Food"].Points.AddXY($"{dtq.TenQuan}", dtq.Food);
                chartDTQuan.Series["Drink"].Points.AddXY($"{dtq.TenQuan}", dtq.Drink);
                chartDTQuan.Series["Dessert"].Points.AddXY($"{dtq.TenQuan}", dtq.Dessert);
                chartDTQuan.Series["Soup"].Points.AddXY($"{dtq.TenQuan}", dtq.Soup);
            }

            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Food", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Food));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Drink", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Drink));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Dessert", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Dessert));
            pieDoanhThu.Series["DoanhThu"].Points.AddXY("Soup", xuLyDoanhThuQuan.DoanhThuQuan.Sum(x => x.Soup));

        }
    }
}
