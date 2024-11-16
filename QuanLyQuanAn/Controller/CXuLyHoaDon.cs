using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Class;

namespace QuanLyQuanAn.Controller
{
    internal class CXuLyHoaDon : CHoaDon
    {
        List<CHoaDon> dsHoaDon = new List<CHoaDon>();
        List<CHoaDon> filterHD = new List<CHoaDon>();
        internal List<CHoaDon> DsHoaDon { get => dsHoaDon; set => dsHoaDon = value; }
        internal List<CHoaDon> FilterHD { get => filterHD; set => filterHD = value; }

        public void docFile()
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\Database\\DsHoaDon.dat", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dsHoaDon = (List<CHoaDon>)bf.Deserialize(fs);
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
                FileStream fs = new FileStream("..\\..\\Database\\DsHoaDon.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dsHoaDon);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //var result = MessageBox.Show("Có Lỗi khi thêm vào database", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                //if (result == DialogResult.Retry)
                //{
                //    ghiFile();
                //}
            }
        }

        public void timKiemTheoNgay(string day)
        {
            docFile();
            FilterHD.Clear();
            foreach (CHoaDon hd in dsHoaDon)
            {
                if (hd.NgayLap.Day == Convert.ToInt32(day))
                {
                    FilterHD.Add(hd);
                }
            }
        }
    }
}
