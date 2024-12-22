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
    public partial class FQuanLyTaiKhoan : Form
    {
        CQuanLyTaiKhoan qltk = new CQuanLyTaiKhoan();
        public FQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            qltk.xoaTaiKhoan(txtTenTK.Text);
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CTaiKhoan tk = new CTaiKhoan(txtTenTK.Text, txtPwd.Text, cboRole.Text);
            qltk.themTaiKhoan(tk);
            hienthi();
        }

        private void FQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void hienthi()
        {
            dgv.DataSource = qltk.ListTaiKhoan.ToList();
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtPwd.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenTK.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboRole.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CTaiKhoan tk = new CTaiKhoan(txtTenTK.Text, txtPwd.Text, cboRole.Text);
            qltk.suaTaiKhoan(tk);
            hienthi();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTenTK.Text = "";
            txtPwd.Text = "";
            cboRole.SelectedIndex = 0;
        }
    }
}
