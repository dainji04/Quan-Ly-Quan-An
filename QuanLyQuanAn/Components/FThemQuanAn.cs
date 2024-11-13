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
    public partial class FThemQuanAn : Form
    {
        CXuLyQuanAn xulyquan = new CXuLyQuanAn();
        public bool isButtonClicked = false;
        public string MaQuan { get; private set; }
        public string TenQuan { get; private set; }
        public string DiaChi { get; private set; }
        public string Sdt { get; private set; }
        public string Email { get; private set; }
        public string MoTa { get; private set; }
        public DateTime NgayDangKy { get; private set; }
        public FThemQuanAn()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var result = msgLuu.Show();
            if(result == DialogResult.Yes)
            {
                if(txtMaQuan.Text != string.Empty && txtTenQuan.Text != string.Empty && txtEmail.Text != string.Empty && txtDiaChi.Text != string.Empty)
                {
                    if(xulyquan.tim(txtMaQuan.Text) == null)
                    {
                        isButtonClicked = true;
                        CQuanAn qa = new CQuanAn();
                        qa.MaQuan = txtMaQuan.Text;
                        qa.TenQuan = txtTenQuan.Text;
                        qa.DiaChi = txtDiaChi.Text;
                        qa.Sdt = txtSdt.Text;
                        qa.Email = txtEmail.Text;
                        qa.MoTa = txtMoTa.Text;
                        qa.NgayDangKy = dtpThanhLap.Value;
                        xulyquan.QuanAn.Add(qa);
                        xulyquan.ghiFile(qa);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ma Quan da ton tai");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }

            }
        }

    }
}
