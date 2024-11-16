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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPwd.Text == "admin")
            {
                msgSignIn.Show("Đăng nhập thành công");
                QuanAnUI quanAnUI = new QuanAnUI();
                quanAnUI.Show();
                this.Hide();
            }
            else
            {
                msgError.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }
    }
}
