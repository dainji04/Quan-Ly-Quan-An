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

namespace QuanLyQuanAn.Views
{
    public partial class FHoaDon : Form
    {
        XuLyMon xulymon = new XuLyMon();
        private string currentBan;
        private CQuanAn quanAn;
        public string CurrentBan { get => currentBan; set => currentBan = value; }
        internal CQuanAn QuanAn { get => quanAn; set => quanAn = value; }
        public FHoaDon()
        {
            InitializeComponent();
        }

        

        private void FHoaDon_Load(object sender, EventArgs e)
        {
            xulymon.docFile(currentBan);

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
        }
    }
}
