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

namespace QuanLyQuanAn.Components
{
    public partial class FQuanLyHoaDon : Form
    {
        CXuLyHoaDon XuLyHoaDon = new CXuLyHoaDon();
        public FQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void FQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            hienthiHD();
        }
        private void hienthiHD()
        {
            XuLyHoaDon.docFile();
            dgvHD.DataSource = XuLyHoaDon.DsHoaDon.ToList();
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            if (txtDay.Text != string.Empty)
            {
                XuLyHoaDon.timKiemTheoNgay(txtDay.Text);
                dgvHD.DataSource = XuLyHoaDon.FilterHD.ToList();
            }
            else
            {
                hienthiHD();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hết dữ liệu không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                XuLyHoaDon.xoaAll();
                hienthiHD();
            }
        }
    }
}
