using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    [Serializable]
    internal class CFood
    {
        private string m_ma;
        private string m_tenmon;
        private double m_giatien;
        private string m_loaimon;
        private Image m_hinhanh;

        public string Ma { get => m_ma; set => m_ma = value; }
        public string Tenmon { get => m_tenmon; set => m_tenmon = value; }
        public double Giatien { get => m_giatien; set => m_giatien = value; }
        public string Loaimon { get => m_loaimon; set => m_loaimon = value; }
        public Image Hinhanh { get => m_hinhanh; set => m_hinhanh = value; }

        public CFood()
        {
            m_ma = "";
            m_tenmon = "";
            m_giatien = 0;
            m_loaimon = "";
            m_hinhanh = null;
        }
    }
}
