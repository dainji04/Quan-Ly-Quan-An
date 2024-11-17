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

            foreach(CDoanhThuMon dtMon in XLDTMon.ListDTMon)
            {
                chartDTMon.Series["Số Lượng"].Points.AddXY(dtMon.TenMon, dtMon.SoLuong);
                chartDTMon.Series["Doanh Thu"].Points.AddXY(dtMon.TenMon, dtMon.DoanhThu);
            }
        }
    }
}
