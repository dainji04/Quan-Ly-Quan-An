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
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Components;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
        CQuanAn dsQuan = new CQuanAn();
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
            dsQuan.quanAn = new List<CQuanAn>();
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\QuanAn.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsQuan.quanAn = (List<CQuanAn>)bf.Deserialize(fs);
                fs.Close();
                hienthi();
            }
            catch
            {
                var result = MessageBox.Show("Có Lỗi khi đọc database hoặc database rỗng!!!", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    QuanAnUI_Load(sender, e);
                }
            }
            quanAnPage.Show();
            hienthi();
        }

        private void QuanLyQuanAn_Click(object sender, EventArgs e)
        {
            //nhanSuPage.Hide();
            quanAnPage.Show();
        }

        private void QuanLyNhanSu_Click(object sender, EventArgs e)
        {
            //quanAnPage.Hide();
            //nhanSuPage.Show();
        }

        private void hienthi()
        {
            dgvQuanAn.DataSource = dsQuan.quanAn.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FThemQuanAn f = new FThemQuanAn();
            f.ShowDialog();
            if(f.isButtonClicked)
            {
                CQuanAn quanAn = new CQuanAn();
                quanAn.MaQuan = f.MaQuan;
                quanAn.TenQuan = f.TenQuan;
                quanAn.DiaChi = f.DiaChi;
                quanAn.Sdt = f.Sdt;
                quanAn.Email = f.Email;
                quanAn.MoTa = f.MoTa;
                quanAn.NgayDangKy = f.NgayDangKy;
                try
                {
                    dsQuan.quanAn.Add(quanAn);
                    FileStream fs = new FileStream("..\\..\\Database\\QuanAn.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dsQuan.quanAn);
                    fs.Close();
                    hienthi();
                }
                catch
                {
                    var result = MessageBox.Show("Có Lỗi khi thêm vào database", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                    {
                        btnThem_Click(sender, e);
                    }
                }
            }
        }

        private void dgvQuanAn_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double Click");
        }
    }
}
