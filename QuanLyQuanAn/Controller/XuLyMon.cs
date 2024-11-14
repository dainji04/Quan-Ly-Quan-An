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
        internal List<CFood> DsMon { get => dsMon; set => dsMon = value; }

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
                FileStream fs = new FileStream("..\\..\\Database\\dsMon.dat", FileMode.Create);
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
    }
}
