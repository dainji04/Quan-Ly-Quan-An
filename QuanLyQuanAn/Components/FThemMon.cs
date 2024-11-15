using QuanLyQuanAn.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyQuanAn.Controller;

namespace QuanLyQuanAn.Components
{
    public partial class FThemMon : Form
    {
        XuLyMon xuLyMon = new XuLyMon();

        public FThemMon()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                ptbImage.Image = Image.FromFile(ofdImage.FileName);
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var result =  msgThem.Show();
            if(result == DialogResult.Yes)
            {
                if (xuLyMon.tim(txtMa.Text) == null)
                {
                    try
                    {
                        CFood food = new CFood();
                        food.Ma = txtMa.Text;
                        food.Tenmon = txtTenMon.Text;
                        food.Giatien = double.Parse(txtGia.Text);
                        food.Loaimon = txtLoai.Text;

                        food.Hinhanh = ptbImage.Image;
                        xuLyMon.DsMon.Add(food);
                        xuLyMon.ghiFile();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi khi thêm món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng mã món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
