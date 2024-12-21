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

using QuanLyQuanAn.Controller;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;

namespace QuanLyQuanAn.Views
{
    public partial class FHoaDon : Form
    {
        public bool isThanhToan = false;
        XuLyMon xulymon = new XuLyMon();
        private string currentBan;
        private CQuanAn quanAn;
        private string maHD;
        private string tongTien;
        private List<CFood> dsFood = new List<CFood>();
        public string CurrentBan { get => currentBan; set => currentBan = value; }
        internal CQuanAn QuanAn { get => quanAn; set => quanAn = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string TongTien { get => tongTien; set => tongTien = value; }

        public FHoaDon()
        {
            InitializeComponent();
        }

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            xulymon.docFile(currentBan, quanAn.MaQuan);

            var query = from mon in xulymon.DsOrder
                        select new
                        {
                            MaMon = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            SoLuong = mon.Soluong,
                            ThanhTien = mon.Tongtien
                        };

            dgvBill.DataSource = query.ToList();

            lblSoBan.Text = currentBan;
            lblMaHD.Text = maHD;
            lblTongTien.Text = TongTien;
            btnTongTien.Text = TongTien;

            lblTenQuan.Text = QuanAn.TenQuan;
            lblDiaChi.Text = QuanAn.DiaChi;
            lblSDT.Text = QuanAn.Sdt;
            lblEmail.Text = QuanAn.Email;
        }
        private void hienthi(List<CFood> ds)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            QuanAnUI quanAnUI = new QuanAnUI();
            quanAnUI.Show();
            this.Close();
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            var result = msgThanhToan.Show();
            if (result == DialogResult.OK)
            {
                isThanhToan = true;
                FOrder od = new FOrder();
                od.CurrentQuan = QuanAn;
                od.CurrentBan = currentBan;

                od.Show();

                this.Close();
            }
        }
    }
}
