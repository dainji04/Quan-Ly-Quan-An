using QuanLyQuanAn.Class;
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
    internal class XuLyMon
    {
        private List<CFood> dsMon = new List<CFood>();
        private List<CFood> dsOrder = new List<CFood>();
        private List<CFood> filter = new List<CFood>();
        internal List<CFood> DsMon { get => dsMon; set => dsMon = value; }
        internal List<CFood> DsOrder { get => dsOrder; set => dsOrder = value; }
        internal List<CFood> Filter { get => filter; set => filter = value; }

        public void docFile()
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\dsMon.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DsMon = (List<CFood>)bf.Deserialize(fs);
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
                FileStream fs = new FileStream("..\\..\\Database\\DsMon.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DsMon);
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

        public void docFile(string soBan, string index)
        {
            try
            {
                FileStream fs = new FileStream($"..\\..\\Database\\Quan{index}\\{soBan}.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DsOrder = (List<CFood>)bf.Deserialize(fs);
                fs.Close();
            }
            catch
            {
                //var result = MessageBox.Show("Có Lỗi khi đọc database hoặc database rỗng!!!", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //if (result == DialogResult.Retry)
                //{
                //    docFile(soBan);
                //}
            }
        }

        public void ghiFile(string soBan, string index)
        {
            docFile();
            try
            {
                FileStream fs = new FileStream($"..\\..\\Database\\Quan{index}\\{soBan}.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DsOrder);
                fs.Close();
            }
            catch
            {
                var result = MessageBox.Show("Có Lỗi khi thêm vào database", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    ghiFile(soBan, index);
                }
            }
        }

        public CFood tim(string ma)
        {
            docFile();
            foreach (CFood qa in DsMon)
            {
                if (qa.Ma == ma)
                {
                    return qa;
                }
            }
            return null;
        }

        public bool XulyThemMon(string id, string ban, string currentQuan)
        {
            foreach (CFood qa in DsMon)
            {
                if (qa.Ma == id)
                {
                    foreach (CFood qa1 in DsOrder)
                    {
                        if (qa1.Ma == id)
                        {
                            qa1.Soluong++;
                            ghiFile(ban, currentQuan);
                            return false;
                        }
                    }
                    DsOrder.Add(qa);
                    ghiFile(ban, currentQuan);
                    break;
                }
            }
            return true;
        }

        public void XuLyXoaMon(string id, string ban, string currentQuan)
        {
            docFile();
            foreach (CFood qa in DsOrder)
            {
                if (qa.Ma == id)
                {
                    DsOrder.Remove(qa);
                    ghiFile(ban, currentQuan);
                    break;
                }
            }
        }

        public bool checkBan(string soBan, string index)
        {
            dsOrder = new List<CFood>();

            docFile(soBan, index);
            return dsOrder.Count > 0;
        }

        public void timKiemTheoLoai(string loai)
        {
            docFile();
            Filter = new List<CFood>();
            foreach (CFood qa in DsMon)
            {
                if (qa.Loaimon == loai)
                {
                    Filter.Add(qa);
                }
            }
        }
    }
}
