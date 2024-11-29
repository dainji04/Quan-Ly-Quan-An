
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
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.GLOBAL_CONSTANTS;

namespace QuanLyQuanAn.Components
{
    public partial class FQuanLyMon : Form
    {
        XuLyMon XuLyMon = new XuLyMon();
        public string ma;
        public FQuanLyMon()
        {
            InitializeComponent();
        }

        private void FQuanLyMon_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            hienthiMon();
            if(CONST.TAIKHOAN.LoaiTaiKhoan == "admin")
            {
                btnThemMon.Enabled = true;
                btnSuaMon.Enabled = true;
                btnXoa.Enabled = true;
            } 
            else
            {
                btnThemMon.Enabled = false;
                btnSuaMon.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void hienthiMon()
        {
            XuLyMon.docFile();
            var query = from mon in XuLyMon.DsMon
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void InitializeDataGridView()
        {
            // Add an Image column to the DataGridView if it doesn't already exist
            if (!dgvFood.Columns.Contains("Hinhanh"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "Hinhanh";
                imageColumn.HeaderText = "Hình Ảnh"; // Set the header text to "Hình Ảnh"
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust the image layout as needed
                imageColumn.DataPropertyName = "Hinhanh"; // The column in the DataSource to bind to
                dgvFood.Columns.Add(imageColumn);
            }

            // Set the row height and column width
            dgvFood.RowTemplate.Height = 100; // Set the desired row height
            dgvFood.Columns["Hinhanh"].Width = 100; // Set the desired column width
        }

        private void btnChonAnh(object sender, EventArgs e)
        {
            ofdImage.ShowDialog();
            if (ofdImage.FileName != "")
            {
                ptbImage.Image = Image.FromFile(ofdImage.FileName);
                ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            XuLyMon.timKiemTheoLoai("food");
            var query = from mon in XuLyMon.Filter
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void btnSoup_Click(object sender, EventArgs e)
        {
            XuLyMon.timKiemTheoLoai("soup");
            var query = from mon in XuLyMon.Filter
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            XuLyMon.timKiemTheoLoai("drink");
            var query = from mon in XuLyMon.Filter
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void btnDessert_Click(object sender, EventArgs e)
        {
            XuLyMon.timKiemTheoLoai("dessert");
            var query = from mon in XuLyMon.Filter
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            var query = from mon in XuLyMon.DsMon
                        select new
                        {
                            Ma = mon.Ma,
                            TenMon = mon.Tenmon,
                            GiaTien = mon.Giatien,
                            Loaimon = mon.Loaimon,
                            Hinhanh = mon.Hinhanh
                        };
            dgvFood.DataSource = query.ToList();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm món ăn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (XuLyMon.tim(txtMa.Text) == null)
                {
                    try
                    {
                        CFood food = new CFood();
                        food.Ma = txtMa.Text;
                        food.Tenmon = txtTenMon.Text;
                        food.Giatien = double.Parse(txtGia.Text);
                        food.Loaimon = cbxLoai.Text;

                        food.Hinhanh = ptbImage.Image;
                        XuLyMon.DsMon.Add(food);
                        XuLyMon.ghiFile();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi khi thêm món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Trùng mã món ăn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFood_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvFood.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenMon.Text = dgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGia.Text = dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxLoai.Text = dgvFood.Rows[e.RowIndex].Cells[3].Value.ToString();
            ptbImage.Image = (Image)dgvFood.Rows[e.RowIndex].Cells[4].Value;
            ptbImage.Width = 217;
            ptbImage.Height = 217;
            ptbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImage.BorderRadius = 15;
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn sửa món ăn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    CFood f = XuLyMon.tim(txtMa.Text);
                    if (f != null)
                    {
                        f.Ma = txtMa.Text;
                        f.Tenmon = txtTenMon.Text;
                        f.Giatien = int.Parse(txtGia.Text);
                        f.Loaimon = cbxLoai.Text;
                        f.Hinhanh = ptbImage.Image;
                        XuLyMon.ghiFile();
                        MessageBox.Show("Sửa món thành công");
                        hienthiMon();
                    }
                    else
                    {
                        MessageBox.Show("Mã món ăn không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa món Thất Bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thêm món ăn này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CFood f = XuLyMon.tim(txtMa.Text);
                XuLyMon.DsMon.Remove(f);
                XuLyMon.ghiFile();
                MessageBox.Show("Xóa món thành công");
                resetBtn();
                txtMa.Focus();
                hienthiMon();
            }
        }

        private void resetBtn()
        {
            txtMa.Text = "";
            txtTenMon.Text = "";
            txtGia.Text = "";
            cbxLoai.Text = "";
            ptbImage.Image = null;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetBtn();
        }
    }
}
