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
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.GLOBAL_CONSTANTS;
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
            if(CONST.TAIKHOAN.LoaiTaiKhoan != "admin")
            {
                btnDTMon.Visible = false;
                btnDTQuan.Visible = false;
                btnQLTK.Visible = false;
            } 
            else
            {
                btnDTMon.Enabled = true;
                btnDTQuan.Enabled = true;
            }
            FQuanLyQuanAn qlqa = new FQuanLyQuanAn(); // Assume FQuanLyQuanAn is now a UserControl
            qlqa.TopLevel = false;
            quanAnPage.Controls.Add(qlqa);
            quanAnPage.FillColor = Color.White;
            qlqa.FormBorderStyle = FormBorderStyle.None;
            qlqa.Dock = DockStyle.Fill;
            qlqa.Show();
            btnQLQA.FillColor = Color.FromArgb(237, 98, 20);
        }

        private void QuanLyQuanAn_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.FromArgb(237, 98, 20);
            btnQLNS.FillColor = Color.Transparent;
            btnLSHD.FillColor = Color.Transparent;
            btnDTQuan.FillColor = Color.Transparent;
            btnDTMon.FillColor = Color.Transparent;
            btnQLTK.FillColor = Color.Transparent;

            quanAnPage.Controls.Clear();
            FQuanLyQuanAn qlqa = new FQuanLyQuanAn(); // Assume FQuanLyQuanAn is now a UserControl
            qlqa.TopLevel = false;
            quanAnPage.Controls.Add(qlqa);
            quanAnPage.FillColor = Color.White;
            qlqa.FormBorderStyle = FormBorderStyle.None;
            qlqa.Dock = DockStyle.Fill;
            qlqa.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
        private void QuanAnUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void QLMonAn_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.Transparent;
            btnQLNS.FillColor = Color.FromArgb(237, 98, 20);
            btnLSHD.FillColor = Color.Transparent;
            btnDTQuan.FillColor = Color.Transparent;
            btnDTMon.FillColor = Color.Transparent;
            btnQLTK.FillColor = Color.Transparent;

            FQuanLyMon qlmon = new FQuanLyMon();
            quanAnPage.Controls.Clear();
            qlmon.TopLevel = false;
            qlmon.FormBorderStyle = FormBorderStyle.None;
            qlmon.Dock = DockStyle.Fill;
            qlmon.Show();
            quanAnPage.Controls.Add(qlmon);
        }

        private void btnDTQuan_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.Transparent;
            btnQLNS.FillColor = Color.Transparent;
            btnLSHD.FillColor = Color.Transparent;
            btnDTQuan.FillColor = Color.FromArgb(237, 98, 20);
            btnDTMon.FillColor = Color.Transparent;
            btnQLTK.FillColor = Color.Transparent;

            FDoanhThuQuan dtquan = new FDoanhThuQuan();
            dtquan.Dock = DockStyle.Fill;
            dtquan.TopLevel = false;
            dtquan.FormBorderStyle = FormBorderStyle.None;
            quanAnPage.Controls.Clear();
            quanAnPage.Controls.Add(dtquan);
            dtquan.Show();
        }

        private void btnDTMon_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.Transparent;
            btnQLNS.FillColor = Color.Transparent;
            btnLSHD.FillColor = Color.Transparent;
            btnDTQuan.FillColor = Color.Transparent;
            btnDTMon.FillColor = Color.FromArgb(237, 98, 20);
            btnQLTK.FillColor = Color.Transparent;

            FDoanhThuMon dtmon = new FDoanhThuMon();
            dtmon.Dock = DockStyle.Fill;
            dtmon.TopLevel = false;
            dtmon.FormBorderStyle = FormBorderStyle.None;
            quanAnPage.Controls.Clear();
            quanAnPage.Controls.Add(dtmon);
            dtmon.Show();
        }

        private void btnLSHD_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.Transparent;
            btnQLNS.FillColor = Color.Transparent;
            btnLSHD.FillColor = Color.FromArgb(237, 98, 20);
            btnDTQuan.FillColor = Color.Transparent;
            btnDTMon.FillColor = Color.Transparent;
            btnQLTK.FillColor = Color.Transparent;

            FQuanLyHoaDon qlhd = new FQuanLyHoaDon();
            qlhd.Dock = DockStyle.Fill;
            qlhd.TopLevel = false;
            qlhd.FormBorderStyle = FormBorderStyle.None;
            quanAnPage.Controls.Clear();
            quanAnPage.Controls.Add(qlhd);
            qlhd.Show();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            btnQLQA.FillColor = Color.Transparent;
            btnQLNS.FillColor = Color.Transparent;
            btnLSHD.FillColor = Color.Transparent;
            btnDTQuan.FillColor = Color.Transparent;
            btnDTMon.FillColor = Color.Transparent;
            btnQLTK.FillColor = Color.FromArgb(237, 98, 20);

            FQuanLyTaiKhoan qltk = new FQuanLyTaiKhoan();
            qltk.TopLevel = false;
            qltk.FormBorderStyle = FormBorderStyle.None;
            qltk.Dock = DockStyle.Fill;
            quanAnPage.Controls.Clear();
            quanAnPage.Controls.Add(qltk);
            qltk.Show();
        }
    }
}
