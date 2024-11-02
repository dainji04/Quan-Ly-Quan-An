using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
        CQuanAn dsQuan = new CQuanAn();
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
            //nhanSuPage.Hide();
            hienthi();
            quanAnPage.Show();
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
            dgvQuanAn.DataSource = dsQuan.quanAn.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemQuanAn f = new FThemQuanAn();
            f.ShowDialog();
            
            CQuanAn quanAn = new CQuanAn();
            quanAn.MaQuan = f.MaQuan;
            quanAn.TenQuan = f.TenQuan;
            quanAn.DiaChi = f.DiaChi;
            quanAn.Sdt = f.Sdt;
            quanAn.Email = f.Email;
            quanAn.MoTa = f.MoTa;
            quanAn.NgayDangKy = f.NgayDangKy;

            dsQuan.quanAn.Add(quanAn);
            hienthi();
        }
    }
}
