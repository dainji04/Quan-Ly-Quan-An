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
    public partial class FSuaMon : Form
    {
        XuLyMon XuLyMon = new XuLyMon();
        public FSuaMon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CFood f = XuLyMon.tim(txtSearch.Text);
            if(f!=null)
            {
                txtMa.Text = f.Ma;
                txtMa.Enabled = false;
                txtTenMon.Text = f.Tenmon;
                txtGia.Text = f.Giatien.ToString();
                txtLoai.Text = f.Loaimon;
                ptbImage.Image = f.Hinhanh;
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            var result = msgSua.Show();
            if (result == DialogResult.Yes) {
                try
                {
                    CFood f = XuLyMon.tim(txtSearch.Text);
                    if (f != null)
                    {
                        f.Ma = txtMa.Text;
                        f.Tenmon = txtTenMon.Text;
                        f.Giatien = int.Parse(txtGia.Text);
                        f.Loaimon = txtLoai.Text;
                        f.Hinhanh = ptbImage.Image;
                        XuLyMon.ghiFile();
                        MessageBox.Show("Sửa món thành công");
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa món Thất Bại");
                }
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                ptbImage.Image = Image.FromFile(ofdImage.FileName);
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
