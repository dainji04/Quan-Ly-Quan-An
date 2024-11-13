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

        public void ghiFile(CQuanAn quanAn)
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
                    ghiFile(quanAn);
                }
            }
        }

        public CQuanAn tim(string ma)
        {
            docFile();
            foreach (CQuanAn qa in QuanAn)
            {
                if (qa.MaQuan == ma)
                {
                    return qa;
                }
            }
            return null;
        }
    }
}
