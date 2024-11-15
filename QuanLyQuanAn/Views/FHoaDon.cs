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
    public partial class FHoaDon : Form
    {
        public FHoaDon()
        {
            InitializeComponent();
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            //XuLyMon.docFile(currentBan);
            //int i = 0;
            //double sum = 0;
            //foreach (CFood odf in XuLyMon.DsOrder)
            //{
            //    Panel pnlItem = new Panel();
            //    Label lblTen = new Label();
            //    Label lblGia = new Label();
            //    Label lblSoLuong = new Label();
            //    Guna.UI2.WinForms.Guna2Button btnXoa = new Guna.UI2.WinForms.Guna2Button();

            //    pnlItem.Size = new Size(400, 50);
            //    pnlItem.Location = new Point(10, 3 + i * (50 + 15));
            //    pnlItem.Paint += panel1_Paint;

            //    lblTen.Text = odf.Tenmon;
            //    lblTen.Location = new Point(10, 10);
            //    lblTen.ForeColor = Color.White;
            //    lblTen.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            //    lblTen.BackColor = Color.Transparent;
            //    lblTen.Size = new Size(210, 20);

            //    lblGia.Text = (odf.Giatien * odf.soluong).ToString() + "$";
            //    lblGia.Location = new Point(275, 10);
            //    lblGia.ForeColor = Color.White;
            //    lblGia.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            //    lblGia.BackColor = Color.Transparent;
            //    lblGia.Size = new Size(40, 40);

            //    lblSoLuong.Text = odf.soluong.ToString();
            //    lblSoLuong.Location = new Point(220, 10);
            //    lblGia.Size = new Size(40, 40);
            //    lblSoLuong.ForeColor = Color.White;
            //    lblSoLuong.Font = new Font("Times New Roman", 14, FontStyle.Bold);

            //    btnXoa.Text = "Xóa";
            //    btnXoa.Location = new Point(330, 6);
            //    btnXoa.Font = new Font("Times New Roman", 10, FontStyle.Bold);
            //    btnXoa.Size = new Size(60, 40);
            //    btnXoa.FillColor = Color.Transparent;
            //    btnXoa.BorderThickness = 2;
            //    btnXoa.BorderColor = Color.FromArgb(234, 124, 105);
            //    btnXoa.ForeColor = Color.FromArgb(234, 124, 105);
            //    btnXoa.HoverState.FillColor = Color.FromArgb(234, 124, 105);
            //    btnXoa.HoverState.ForeColor = Color.White;
            //    btnXoa.BorderRadius = 10;
            //    btnXoa.BringToFront();
            //    btnXoa.Click += (s, eArgs) =>
            //    {
            //        XuLyMon.XuLyXoaMon(odf.Ma, currentBan);
            //        pnlOrder.Controls.Clear();
            //        hienthi();
            //    };


            //    pnlItem.Controls.Add(lblTen);
            //    pnlItem.Controls.Add(lblGia);
            //    pnlItem.Controls.Add(lblSoLuong);
            //    pnlItem.Controls.Add(btnXoa);
            //    pnlOrder.Controls.Add(pnlItem);

            //    sum += odf.Giatien * odf.soluong;
            //    i++;
            //}
            //lblThanhTien.Text = sum.ToString() + "$";
        }
    }
}
