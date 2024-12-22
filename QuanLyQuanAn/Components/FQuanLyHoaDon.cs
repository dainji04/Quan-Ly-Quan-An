using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.GLOBAL_CONSTANTS;
using QuanLyQuanAn.Views;
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
        private CXuLyHoaDon XuLyHoaDon = new CXuLyHoaDon();
        private XuLyMon xuLyMon = new XuLyMon();
        private CXuLyQuanAn xuLyQuanAn = new CXuLyQuanAn();
        private CHoaDon hd = new CHoaDon();
        public FQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void FQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            if (CONST.TAIKHOAN.LoaiTaiKhoan != "admin")
            {
                btnChiTiet.Visible = false;
                btnXoa.Visible = false;
            }    
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

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            CQuanAn quan = xuLyQuanAn.timTen(hd.TenQuan);
            if (quan != null)
            {
                FHoaDon fhd = new FHoaDon();
                fhd.CurrentBan = hd.SoBan;
                fhd.QuanAn = quan;
                fhd.MaHD = hd.Ma;
                fhd.TongTien = hd.TongTien.ToString();
                fhd.DsFood = hd.DsMon;
                fhd.ShowDialog();
            }
            else
            {
                MessageBox.Show("vui lòng chọn hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvHD.Rows[e.RowIndex];
            hd = XuLyHoaDon.tim(row.Cells[0].Value.ToString());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            hienthiHD();
        }
    }
}
