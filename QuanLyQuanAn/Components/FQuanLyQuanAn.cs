
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.GLOBAL_CONSTANTS;
using QuanLyQuanAn.Views;

namespace QuanLyQuanAn.Components
{
    public partial class FQuanLyQuanAn : Form
    {
        private CXuLyQuanAn xulyQuan = new CXuLyQuanAn();
        public FQuanLyQuanAn()
        {
            InitializeComponent();
            hienthi();
        }
        private void FQuanLyQuanAn_Load(object sender, EventArgs e)
        {
            if (CONST.TAIKHOAN.LoaiTaiKhoan == "admin")
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnReset.Enabled = true;
            } 
            else
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void hienthi()
        {
            xulyQuan.docFile();

            dgvQuanAn.DataSource = xulyQuan.QuanAn.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaQuan.Text != string.Empty && txtTenQuan.Text != string.Empty && txtEmail.Text != string.Empty && txtDiaChi.Text != string.Empty)
            {
                if (xulyQuan.tim(txtMaQuan.Text) == null)
                {
                    CQuanAn qa = new CQuanAn();
                    qa.MaQuan = txtMaQuan.Text;
                    qa.TenQuan = txtTenQuan.Text;
                    qa.DiaChi = txtDiaChi.Text;
                    qa.Sdt = txtSdt.Text;
                    qa.Email = txtEmail.Text;
                    qa.MoTa = txtMoTa.Text;
                    qa.NgayDangKy = dtpThanhLap.Value;
                    xulyQuan.QuanAn.Add(qa);
                    xulyQuan.ghiFile();

                    try
                    {
                        string path = "..\\..\\Database\\Quan" + txtMaQuan.Text;
                        System.IO.Directory.CreateDirectory(path);
                    }
                    catch
                    {
                        MessageBox.Show("Tạo thư mục thất bại");
                    }

                    for (int i = 0; i < 16; i++)
                    {
                        int index = i + 1;
                        string pathFile = "..\\..\\Database\\Quan" + txtMaQuan.Text + "\\Ban " + index + ".dat";
                        FileStream fs = File.Create(pathFile);
                    }
                    MessageBox.Show("Them thanh cong");
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Ma Quan da ton tai");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa quán ăn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CQuanAn qa = xulyQuan.tim(txtMaQuan.Text);
                if (qa != null)
                {
                    try
                    {
                        string path = "..\\..\\Database\\Quan" + txtMaQuan.Text;
                        //Directory.CreateDirectory(path);
                        Directory.Delete(path, true);
                    }
                    catch
                    {
                        MessageBox.Show("Xóa csdl thất bại");
                    }

                    xulyQuan.QuanAn.Remove(qa);
                    xulyQuan.ghiFile();
                    MessageBox.Show("Xóa thành công");
                    txtMaQuan.Text = "";
                    txtTenQuan.Text = "";
                    txtDiaChi.Text = "";
                    txtSdt.Text = "";
                    txtEmail.Text = "";
                    txtMoTa.Text = "";
                    dtpThanhLap.Value = DateTime.Now;
                    txtSearch.Text = "";
                }
                txtSearch.Focus();
                hienthi();
            }
        }

        private void dgvQuanAn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQuan.Text = dgvQuanAn.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenQuan.Text = dgvQuanAn.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvQuanAn.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSdt.Text = dgvQuanAn.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvQuanAn.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMoTa.Text = dgvQuanAn.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpThanhLap.Value = Convert.ToDateTime(dgvQuanAn.Rows[e.RowIndex].Cells[6].Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn sửa quán ăn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CQuanAn qa = xulyQuan.tim(txtMaQuan.Text);
                if (qa != null)
                {
                    qa.MaQuan = txtMaQuan.Text;
                    qa.TenQuan = txtTenQuan.Text;
                    qa.DiaChi = txtDiaChi.Text;
                    qa.Sdt = txtSdt.Text;
                    qa.Email = txtEmail.Text;
                    qa.MoTa = txtMoTa.Text;
                    qa.NgayDangKy = dtpThanhLap.Value;
                    xulyQuan.ghiFile();
                    MessageBox.Show("Sửa thành công");
                    //isFixed = true;
                    //this.Close();
                    hienthi();
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            CQuanAn qa = xulyQuan.tim(txtSearch.Text);
            if (qa != null)
            {
                txtMaQuan.Text = qa.MaQuan;
                txtTenQuan.Text = qa.TenQuan;
                txtDiaChi.Text = qa.DiaChi;
                txtSdt.Text = qa.Sdt;
                txtEmail.Text = qa.Email;
                txtMoTa.Text = qa.MoTa;
                dtpThanhLap.Value = qa.NgayDangKy;
            }

            CQuanAn temp = xulyQuan.tim(txtSearch.Text);
            if (temp != null)
            {
                dgvQuanAn.DataSource = new List<CQuanAn> { temp };
            }
            else if (txtSearch.Text == string.Empty)
            {
                hienthi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy quán ăn");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaQuan.Text = "";
            txtTenQuan.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtMoTa.Text = "";
            dtpThanhLap.Value = DateTime.Now;
        }

        private void btnVaoQuan_Click(object sender, EventArgs e)
        {
            CQuanAn qa = new CQuanAn();
            qa.MaQuan = txtMaQuan.Text;
            qa.TenQuan = txtTenQuan.Text;
            qa.DiaChi = txtDiaChi.Text;
            qa.Sdt = txtSdt.Text;
            qa.Email = txtSdt.Text;
            qa.MoTa = txtSdt.Text;
            qa.NgayDangKy = dtpThanhLap.Value;
            //CurrentMaQuan = qa.MaQuan;
            FDatBan f = new FDatBan();
            f.MaQuan = qa.MaQuan;
            this.ParentForm.Hide();
            f.Show();
        }
    }
}
