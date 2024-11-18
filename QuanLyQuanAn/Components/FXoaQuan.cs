using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;

namespace QuanLyQuanAn.Components
{
    public partial class FXoaQuan : Form
    {
        CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        public FXoaQuan()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQuanAn qa = xulyQuan.tim(txtSearch.Text);
            if (qa != null)
            {
                txtMaQuan.Text = qa.MaQuan;
                txtTenQuan.Text = qa.TenQuan;
                txtDiaChi.Text = qa.DiaChi;
                txtSdt.Text = qa.Sdt;
                txtEmail.Text = qa.Email;
                txtMoTa.Text = qa.MoTa;
                dtpThanhLap.Value = qa.NgayDangKy;
            }
            else
            {
                MessageBox.Show("Không tìm thấy quán ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = msgLuu.Show();
            if (result == DialogResult.Yes)
            {
                CQuanAn qa = xulyQuan.tim(txtMaQuan.Text);
                if (qa != null)
                {
                    try
                    {
                        string path = "..\\..\\Database\\Quan" + txtMaQuan.Text;
                        //Directory.CreateDirectory(path);
                        Directory.Delete(path, true);
                    }
                    catch
                    {
                        MessageBox.Show("Xóa csdl thất bại");
                    }

                    xulyQuan.QuanAn.Remove(qa);
                    xulyQuan.ghiFile();
                    MessageBox.Show("Xóa thành công");
                    txtMaQuan.Text = "";
                    txtTenQuan.Text = "";
                    txtDiaChi.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtMoTa.Text = "";
                    dtpThanhLap.Value = DateTime.Now;
                    txtSearch.Text = "";
                }
                txtSearch.Focus();
            }
        }
    }
}
