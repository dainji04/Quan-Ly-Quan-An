using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyQuanAn.Class;

namespace QuanLyQuanAn.Controller
{
    internal class CXuLyDoanhThuQuan
    {
        List<CDoanhThuQuan> doanhThuQuan = new List<CDoanhThuQuan>();
        internal List<CDoanhThuQuan> DoanhThuQuan { get => doanhThuQuan; set => doanhThuQuan = value; }

        public void xulydoanhthu()
        {
            CXuLyHoaDon xuLyHoaDon = new CXuLyHoaDon();
            xuLyHoaDon.docFile();

            CXuLyQuanAn xuLyQuanAn = new CXuLyQuanAn();
            xuLyQuanAn.docFile();
            foreach(CQuanAn quan in xuLyQuanAn.QuanAn)
            {
                CDoanhThuQuan dtq = new CDoanhThuQuan();
                dtq.TenQuan = quan.TenQuan;
                DoanhThuQuan.Add(dtq);
            }

            xuLyHoaDon.DsHoaDon.ForEach(hd =>
            {
                foreach(CFood food in hd.DsMon)
                {
                    foreach (CDoanhThuQuan dt in DoanhThuQuan)
                    {
                        if (dt.TenQuan == hd.TenQuan)
                        {
                            if (food.Loaimon == "food")
                            {
                                dt.Food += food.Giatien;
                            }
                            else if (food.Loaimon == "drink")
                            {
                                dt.Drink += food.Giatien;
                            }
                            else if (food.Loaimon == "dessert")
                            {
                                dt.Dessert += food.Giatien;
                            }
                            else if (food.Loaimon == "soup")
                            {
                                dt.Soup += food.Giatien;
                            }
                            break;
                        }
                    }

                }
            });
        }
    }
}
