using QuanLyQuanAn.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Controller
{
    internal class CXuLyDoanhThuMon
    {
        private List<CDoanhThuMon> listDTMon = new List<CDoanhThuMon>();

        public List<CDoanhThuMon> ListDTMon { get => listDTMon; set => listDTMon = value; }

        public void xuLyDoanhThuMon()
        {
            XuLyMon xuLyMon = new XuLyMon();
            xuLyMon.docFile();
            foreach(CFood mon in xuLyMon.DsMon)
            {
                CDoanhThuMon dtMon = new CDoanhThuMon();
                dtMon.TenMon = mon.Tenmon;
                ListDTMon.Add(dtMon);
            }

            CXuLyHoaDon xuLyHoaDon = new CXuLyHoaDon();
            xuLyHoaDon.docFile();
            foreach(CHoaDon hoaDon in xuLyHoaDon.DsHoaDon)
            {
                foreach(CFood food in hoaDon.DsMon)
                {
                    foreach(CDoanhThuMon dtMon in ListDTMon)
                    {
                        if (dtMon.TenMon == food.Tenmon)
                        {
                            dtMon.SoLuong++;
                            dtMon.DoanhThu += food.Giatien;
                            break;
                        }
                    }
                }
            }
        }
    }
}
