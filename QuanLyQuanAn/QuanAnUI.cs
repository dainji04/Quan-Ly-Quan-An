using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class QuanAnUI : Form
    {
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
            //nhanSuPage.Hide();
            quanAnPage.Show();
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
    }
}
