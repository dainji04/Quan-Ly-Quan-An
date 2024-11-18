using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanAn.Views
{
    public partial class FDoanhThuMon : Form
    {
        public FDoanhThuMon()
        {
            InitializeComponent();
        }

        private void FDoanhThuMon_Load(object sender, EventArgs e)
        {
            CXuLyDoanhThuMon XLDTMon = new CXuLyDoanhThuMon();
            XLDTMon.xuLyDoanhThuMon();

            int i = 0;
            foreach (CDoanhThuMon dtMon in XLDTMon.ListDTMon)
            {
                chartDTMon.Series["Doanh Thu"].Points.AddXY(Convert.ToInt32(dtMon.Id), dtMon.DoanhThu);
            }

            //chartDTMon.Series["Doanh Thu"].Points.AddXY(1, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(2, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(3, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(4, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(5, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(6, 10);
            //chartDTMon.Series["Doanh Thu"].Points.AddXY(7, 10);
        }
    }
}
