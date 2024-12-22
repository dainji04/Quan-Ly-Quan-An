using QuanLyQuanAn.Class;
using QuanLyQuanAn.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.Controller
{
    internal class CQuanLyTaiKhoan
    {
        private List<CTaiKhoan> listTaiKhoan = null;

        public List<CTaiKhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        public CQuanLyTaiKhoan()
        {
            listTaiKhoan = new List<CTaiKhoan>();
            docFile();
        }

        public void docFile()
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\DSTaiKhoan.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                listTaiKhoan = (List<CTaiKhoan>)bf.Deserialize(fs);
                fs.Close();
            }
            catch
            {
                var result = MessageBox.Show("Có Lỗi khi đọc database hoặc database rỗng!!!", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    docFile();
                }
            }
        }
        public void ghiFile()
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\DSTaiKhoan.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, listTaiKhoan);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void themTaiKhoan(CTaiKhoan tk)
        {
            if (tim(tk.TenDangNhap) == null)
            {
                listTaiKhoan.Add(tk);
                MessageBox.Show("Thêm Tài Khoản Thành Công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ghiFile();
            }
            else
            {
                MessageBox.Show("Tên Tài Khoản đã tồn tại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void suaTaiKhoan(CTaiKhoan tk)
        {
            CTaiKhoan tmp = tim(tk.TenDangNhap);
            if (tmp != null)
            {
                tmp.TenDangNhap = tk.TenDangNhap;
                tmp.MatKhau = tk.MatKhau;
                tmp.LoaiTaiKhoan = tk.LoaiTaiKhoan;
                MessageBox.Show("Sửa Tài Khoản Thành Công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ghiFile();
            }
            else
            {
                MessageBox.Show("Tên tài khoản chưa tồn tại!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xoaTaiKhoan(string ma)
        {
            CTaiKhoan tmp = tim(ma);
            if (tmp != null)
            {
                listTaiKhoan.Remove(tmp);
                MessageBox.Show("Xóa Tài Khoản Thành Công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ghiFile();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public CTaiKhoan tim(string ma)
        {
            foreach (CTaiKhoan tk in listTaiKhoan)
            {
                if (tk.TenDangNhap == ma)
                {
                    return tk;
                }
            }
            return null;
        }

        
    }
}
