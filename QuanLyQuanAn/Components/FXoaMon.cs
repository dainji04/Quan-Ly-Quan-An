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
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;

namespace QuanLyQuanAn.Components
{
    public partial class FXoaMon : Form
    {
        XuLyMon XuLyMon = new XuLyMon();
        public FXoaMon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CFood f = XuLyMon.tim(txtSearch.Text);
            if (f != null)
            {
                txtMa.Text = f.Ma;
                txtTenMon.Text = f.Tenmon;
                txtGia.Text = f.Giatien.ToString();
                txtLoai.Text = f.Loaimon;
                ptbImage.Image = f.Hinhanh;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                txtMa.Enabled = false;
                txtTenMon.Enabled = false;
                txtGia.Enabled = false;
                txtLoai.Enabled = false;
                btnAnh.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy món ăn");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = msgXoa.Show();
            if(result == DialogResult.Yes)
            {
                CFood f = XuLyMon.tim(txtSearch.Text);
                XuLyMon.DsMon.Remove(f);
                XuLyMon.ghiFile();
                MessageBox.Show("Xóa món thành công");
            }
        }
    }
}
