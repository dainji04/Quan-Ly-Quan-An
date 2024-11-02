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

namespace QuanLyQuanAn.Components
{
    public partial class FThemQuanAn : Form
    {
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
            CQuanAn QuanAn = new CQuanAn();
            MaQuan = txtMaQuan.Text;
            TenQuan = txtTenQuan.Text;
            DiaChi = txtDiaChi.Text;
            Sdt = txtSdt.Text;
            Email = txtEmail.Text;
            QuanAn.MoTa = txtMoTa.Text;
            NgayDangKy = DateTime.Now;

            this.Close();
        }
    }
}
