using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// using by me
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.Views;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
        private CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        private XuLyMon XuLyMon = new XuLyMon();
        private CXuLyHoaDon XuLyHoaDon = new CXuLyHoaDon();
        private string currentMaQuan = "";

        public string CurrentMaQuan { get => currentMaQuan; set => currentMaQuan = value; }
        internal CXuLyHoaDon XuLyHoaDon1 { get => XuLyHoaDon; set => XuLyHoaDon = value; }

        public QuanAnUI()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanAnUI_Load(object sender, EventArgs e)
        {
            pnlQLMA.Hide();
            pnlDoanhThu.Hide();
            quanAnPage.Show();
            hienthi();
        }

        private void QuanLyQuanAn_Click(object sender, EventArgs e)
        {
            pnlQLMA.Hide();
            pnlDoanhThu.Hide();
            quanAnPage.Show();
        }

        private void hienthi()
        {
            xulyQuan.docFile();
            dgvQuanAn.DataSource = xulyQuan.QuanAn.ToList();
        }
        private void hienthiMon()
        {
            XuLyMon.docFile();
            dgvFood.DataSource = XuLyMon.DsMon.ToList();
        }

        private void hienthiHD()
        {
            XuLyHoaDon.docFile();
            dgvHD.DataSource = XuLyHoaDon.DsHoaDon.ToList();
        }

        private void mnsThem_Click(object sender, EventArgs e)
        {
            FThemQuanAn f = new FThemQuanAn();
            f.ShowDialog();
            hienthi();
        }

        private void mnsSua_Click(object sender, EventArgs e)
        {
            FSuaQuan sq = new FSuaQuan();
            sq.ShowDialog();
            hienthi();
        }

        private void mnsXoa_Click(object sender, EventArgs e)
        {
            FXoaQuan xq = new FXoaQuan();
            xq.ShowDialog();
            hienthi();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQuanAn temp = xulyQuan.tim(txtSearch.Text);
            if(temp != null)
            {
                dgvQuanAn.DataSource = new List<CQuanAn> { temp };
            }
            else if(txtSearch.Text == string.Empty)
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy quán ăn");
            }
        }

        private void dgvQuanAn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CQuanAn qa = new CQuanAn();
            qa.MaQuan = dgvQuanAn.Rows[e.RowIndex].Cells[0].Value.ToString();
            qa.TenQuan = dgvQuanAn.Rows[e.RowIndex].Cells[1].Value.ToString();
            qa.DiaChi = dgvQuanAn.Rows[e.RowIndex].Cells[2].Value.ToString();
            qa.Sdt = dgvQuanAn.Rows[e.RowIndex].Cells[3].Value.ToString();
            qa.Email = dgvQuanAn.Rows[e.RowIndex].Cells[4].Value.ToString();
            qa.MoTa = dgvQuanAn.Rows[e.RowIndex].Cells[5].Value.ToString();
            qa.NgayDangKy = DateTime.Parse(dgvQuanAn.Rows[e.RowIndex].Cells[6].Value.ToString());
            CurrentMaQuan = qa.MaQuan;
        }

        private void dgvQuanAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FDatBan f = new FDatBan();
                f.MaQuan = currentMaQuan;
                f.Show();
                this.Hide();
            }
        }

        private void QLQA_Click(object sender, EventArgs e)
        {
            pnlDoanhThu.Hide();
            pnlQLMA.Show();
            hienthiMon();
        }

        private void mnsThemMon_Click(object sender, EventArgs e)
        {
            FThemMon f = new FThemMon();
            f.ShowDialog();

            hienthiMon();
        }

        private void mnsSuaMon_Click(object sender, EventArgs e)
        {
            FSuaMon f = new FSuaMon();
            f.ShowDialog();

            hienthiMon();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FXoaMon f = new FXoaMon();
            f.ShowDialog();

            hienthiMon();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            pnlQLMA.Show();
            pnlDoanhThu.Show();
            hienthiHD();
        }
    }
}
