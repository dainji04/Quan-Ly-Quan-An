using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// using by me
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;
using QuanLyQuanAn.Controller;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
        private CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        public QuanAnUI()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanAnUI_Load(object sender, EventArgs e)
        {
            quanAnPage.Show();
            hienthi();
        }

        private void QuanLyQuanAn_Click(object sender, EventArgs e)
        {
            //nhanSuPage.Hide();
            quanAnPage.Show();
        }

        private void QuanLyNhanSu_Click(object sender, EventArgs e)
        {
            //quanAnPage.Hide();
            //nhanSuPage.Show();
        }

        private void hienthi()
        {
            xulyQuan.docFile();
            dgvQuanAn.DataSource = xulyQuan.QuanAn.ToList();
        }

        private void dgvQuanAn_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double Click");
        }

        private void mnsThem_Click(object sender, EventArgs e)
        {
            FThemQuanAn f = new FThemQuanAn();
            f.ShowDialog();
            if (f.isButtonClicked)
            {
                //    if(xulyQuan.tim() == null)
                //    {
                //        CQuanAn quanAn = new CQuanAn();
                //        quanAn.MaQuan = f.MaQuan;
                //        quanAn.TenQuan = f.TenQuan;
                //        quanAn.DiaChi = f.DiaChi;
                //        quanAn.Sdt = f.Sdt;
                //        quanAn.Email = f.Email;
                //        quanAn.MoTa = f.MoTa;
                //        quanAn.NgayDangKy = f.NgayDangKy;
                //        xulyQuan.QuanAn.Add(quanAn);
                //        xulyQuan.ghiFile(quanAn);
                //    }
                hienthi();
            }
        }

        private void mnsSua_Click(object sender, EventArgs e)
        {
            FSuaQuan sq = new FSuaQuan();
            sq.ShowDialog();
            if(sq.isFixed)
            {
                hienthi();
            }
        }
    }
}
