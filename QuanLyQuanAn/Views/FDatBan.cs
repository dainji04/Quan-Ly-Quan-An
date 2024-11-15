using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guna.UI2.WinForms;
using QuanLyQuanAn.Components;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.Class;

namespace QuanLyQuanAn.Views
{
    public partial class FDatBan : Form
    {
        CXuLyQuanAn xlqa = new CXuLyQuanAn();
        XuLyMon xulymon = new XuLyMon();
        private string maQuan;
        public string MaQuan { get => maQuan; set => maQuan = value; }

        public FDatBan()
        {
            InitializeComponent();
        }

        private void FDatBan_Load(object sender, EventArgs e)
        {
            
            CQuanAn qa = xlqa.tim(MaQuan);
            if (qa != null)
            {
                lblMaQuan.Text = "Mã Quán: " + maQuan;
                lblTenQuan.Text = "Tên Quán: " + qa.TenQuan;
                lblDiaChi.Text = "Địa Chỉ: " + qa.DiaChi;
                lblSdt.Text = "Số Điện Thoại: " + qa.Sdt;
                lblEmail.Text = "Email: " + qa.Email;
                lblMoTa.Text = "Mô Tả: " + qa.MoTa;
                lblNgayDK.Text = "Ngày Đăng Ký: " + qa.NgayDangKy;
            }
            else
            {
                lblMaQuan.Text = "Có Lỗi Khi Clicked Quán!!!";
                lblMaQuan.ForeColor = Color.Red;
            }
            loadBan();
        }
        public void loadBan()
        {
            for (int i = 0; i < 16; i++)
            {
                int index = i + 1;
                xulymon.docFile("Bàn " + index);
                Guna2Button btn = new Guna2Button();
                btn.Text = "Bàn " + index;
                btn.Size = new Size(176, 146);
                btn.Font = new Font("Times New Roman", 16, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.HoverState.FillColor = Color.FromArgb(255, 128, 0);
                btn.BorderRadius = 15;
                btn.Click += new EventHandler(btnBan_DoubleClick);
                btn.PressedColor = Color.Blue;
                btn.BackColor = Color.Transparent;

                btn.Location = new Point(35 + (i % 4) * 200, 20 + (i / 4) * 170);
                if (xulymon.checkBan("Bàn " + index))
                {
                    btn.FillColor = Color.FromArgb(255, 128, 0);
                }
                else
                {
                    btn.FillColor = Color.FromArgb(94, 148, 255);
                }
                pnlban.Controls.Add(btn);
            }
        }
        private void btnBan_DoubleClick(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            FOrder fo = new FOrder();
            CQuanAn qa = xlqa.tim(MaQuan);
            fo.CurrentBan = btn.Text;
            fo.CurrentQuan = qa.TenQuan;
            this.Close();
            fo.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            QuanAnUI qa = new QuanAnUI();
            this.Hide();
            qa.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            QuanAnUI qa = new QuanAnUI();
            this.Hide();
            qa.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pnlban.Controls.Clear();
            loadBan();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            QuanAnUI qa = new QuanAnUI();
            this.Hide();
            qa.Show();
        }
    }
}
