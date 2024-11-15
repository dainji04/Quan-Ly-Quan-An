using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    [Serializable]
    internal class CHoaDon
    {
        private string ma;
        private string tenQuan;
        private string soBan;
        private DateTime ngayLap;
        private double tongTien;
        private List<CFood> dsMon;
        public string Ma { get => ma; set => ma = value; }
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public string SoBan { get => soBan; set => soBan = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public double TongTien { get => tongTien; set => tongTien = value; }
        internal List<CFood> DsMon { get => dsMon; set => dsMon = value; }
    }
}
