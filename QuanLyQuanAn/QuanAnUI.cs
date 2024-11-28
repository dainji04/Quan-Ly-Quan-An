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
using QuanLyQuanAn.Views;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
        private CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        private XuLyMon XuLyMon = new XuLyMon();
        private CXuLyHoaDon XuLyHoaDon = new CXuLyHoaDon();
        private string currentMaQuan = "";

        public string CurrentMaQuan { get => currentMaQuan; set => currentMaQuan = value; }
        internal CXuLyHoaDon XuLyHoaDon1 { get => XuLyHoaDon; set => XuLyHoaDon = value; }

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
            FQuanLyQuanAn qlqa = new FQuanLyQuanAn(); // Assume FQuanLyQuanAn is now a UserControl
            qlqa.TopLevel = false;
            quanAnPage.Controls.Add(qlqa);
            quanAnPage.FillColor = Color.White;
            qlqa.FormBorderStyle = FormBorderStyle.None;
            qlqa.Dock = DockStyle.Fill;
            qlqa.Show();
        }

        private void QuanLyQuanAn_Click(object sender, EventArgs e)
        {
            quanAnPage.Controls.Clear();
            FQuanLyQuanAn qlqa = new FQuanLyQuanAn(); // Assume FQuanLyQuanAn is now a UserControl
            qlqa.TopLevel = false;
            quanAnPage.Controls.Add(qlqa);
            quanAnPage.FillColor = Color.White;
            qlqa.FormBorderStyle = FormBorderStyle.None;
            qlqa.Dock = DockStyle.Fill;
            qlqa.Show();
        }


        private void hienthiHD()
        {
            XuLyHoaDon.docFile();
            dgvHD.DataSource = XuLyHoaDon.DsHoaDon.ToList();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnlDoanhThu.Show();
            hienthiHD();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            if(txtDay.Text != string.Empty)
            {
                XuLyHoaDon.timKiemTheoNgay(txtDay.Text);
                dgvHD.DataSource = XuLyHoaDon.FilterHD.ToList();
            }
            else
            {
                hienthiHD();
            }
        }

        private void QuanAnUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnsQuan_Click(object sender, EventArgs e)
        {
            FDoanhThuQuan dtq = new FDoanhThuQuan();
            dtq.Show();
        }

        private void mnsMon_Click(object sender, EventArgs e)
        {
            FDoanhThuMon dtm = new FDoanhThuMon();
            dtm.Show();
        }

        private void QLMonAn_Click(object sender, EventArgs e)
        {
            FQuanLyMon qlmon = new FQuanLyMon();
            quanAnPage.Controls.Clear();
            qlmon.TopLevel = false;
            qlmon.FormBorderStyle = FormBorderStyle.None;
            qlmon.Dock = DockStyle.Fill;
            qlmon.Show();
            quanAnPage.Controls.Add(qlmon);
        }
    }
}
