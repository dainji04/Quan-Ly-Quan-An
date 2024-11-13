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
    public partial class FSuaQuan : Form
    {
        CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        public bool isFixed = false;
        public FSuaQuan()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQuanAn qa = xulyQuan.tim(txtSearch.Text);
            if(qa != null )
            {
                txtMaQuan.Text = qa.MaQuan;
                txtTenQuan.Text = qa.TenQuan;
                txtDiaChi.Text = qa.DiaChi;
                txtSdt.Text = qa.Sdt;
                txtEmail.Text = qa.Email;
                txtMoTa.Text = qa.MoTa;
                dtpThanhLap.Value = qa.NgayDangKy;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CQuanAn qa = xulyQuan.tim(txtMaQuan.Text);
            if (qa != null)
            {
                qa.MaQuan = txtMaQuan.Text;
                qa.TenQuan = txtTenQuan.Text;
                qa.DiaChi = txtDiaChi.Text;
                qa.Sdt = txtSdt.Text;
                qa.Email = txtEmail.Text;
                qa.MoTa = txtMoTa.Text;
                qa.NgayDangKy = dtpThanhLap.Value;
                xulyQuan.ghiFile(qa);
                MessageBox.Show("Sửa thành công");
                isFixed = true;
                this.Close();
            }
        }
    }
}
