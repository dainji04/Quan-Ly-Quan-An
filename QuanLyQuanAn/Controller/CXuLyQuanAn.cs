using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using static System.Net.WebRequestMethods;

namespace QuanLyQuanAn.Controller
{
    internal class CXuLyQuanAn
    {
        private List<CQuanAn> quanAn = new List<CQuanAn>();
        internal List<CQuanAn> QuanAn { get => quanAn; set => quanAn = value; }

        public void docFile()
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\QuanAn.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                QuanAn = (List<CQuanAn>)bf.Deserialize(fs);
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
                FileStream fs = new FileStream("..\\..\\Database\\QuanAn.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, QuanAn);
                fs.Close();
            }
            catch
            {
                var result = MessageBox.Show("Có Lỗi khi thêm vào database", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    ghiFile();
                }
            }
        }

        public CQuanAn tim(string text)
        {
            docFile();
            foreach (CQuanAn qa in QuanAn)
            {
                if (qa.MaQuan == text)
                {
                    return qa;
                }
            }
            return null;
        }

        public CQuanAn timTen(string ten)
        {
            docFile();
            foreach (CQuanAn qa in QuanAn)
            {
                if (qa.TenQuan == ten)
                {
                    return qa;
                }
            }
            return null;
        }

        public List<CQuanAn> tim(string text, string loai)
        {
            docFile();
            List<CQuanAn> result = new List<CQuanAn>();
            text = text.ToLower();
            if (loai == "id") {
                CQuanAn tmp = tim(text);
                if (tmp != null)
                {
                    result.Add(tmp);
                }
            }

            else if (loai == "tên")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].TenQuan.ToLower().Contains(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }

            else if(loai == "địa chỉ")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].DiaChi.ToLower().Contains(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }

            else if (loai == "sdt")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].Sdt.Contains(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }

            else if (loai == "email")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].Email.ToLower().Contains(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }

            else if (loai == "mô tả")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].MoTa.ToLower().Contains(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }

            else if (loai == "ngày")
            {
                for (int i = 0; i < QuanAn.Count; i++)
                {
                    if (QuanAn[i].NgayDangKy.Day == Convert.ToInt32(text))
                    {
                        result.Add(QuanAn[i]);
                    }
                }
            }


            return (result.Count > 0) ? result : null;
        }
    }
}
