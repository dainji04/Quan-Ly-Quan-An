﻿using QuanLyQuanAn.Class;
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
        internal List<CFood> DsMon { get => dsMon; set => dsMon = value; }
        internal List<CFood> DsOrder { get => dsOrder; set => dsOrder = value; }

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

        public void docFile(string soBan)
        {
            try
            {
                FileStream fs = new FileStream($"..\\..\\Database\\Ban\\{soBan}.dat", FileMode.Open);
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

        public void ghiFile(string soBan)
        {
            docFile();
            try
            {
                FileStream fs = new FileStream($"..\\..\\Database\\Ban\\{soBan}.dat", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DsOrder);
                fs.Close();
            }
            catch
            {
                var result = MessageBox.Show("Có Lỗi khi thêm vào database", "Thông Báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    ghiFile(soBan);
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

        public bool XulyThemMon(string id, string ban)
        {
            foreach(CFood qa in DsMon)
            {
                if (qa.Ma == id)
                {
                    foreach(CFood qa1 in DsOrder)
                    {
                        if (qa1.Ma == id)
                        {
                            qa1.Soluong++;
                            ghiFile(ban);
                            return false;
                        }
                    }
                    DsOrder.Add(qa);
                    ghiFile(ban);
                    break;
                }
            }
            return true;
        }

        public void XuLyXoaMon(string id, string ban)
        {
            docFile();
            foreach (CFood qa in DsOrder)
            {
                if (qa.Ma == id)
                {
                    DsOrder.Remove(qa);
                    ghiFile(ban);
                    break;
                }
            }
        }

        public bool checkBan(string soBan)
        {
            dsOrder = new List<CFood>();

            docFile(soBan);
            return dsOrder.Count > 0;
        }
    }
}
