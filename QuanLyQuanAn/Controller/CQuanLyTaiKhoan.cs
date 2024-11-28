using QuanLyQuanAn.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Controller
{
    internal class CQuanLyTaiKhoan
    {
        private List<CTaiKhoan> listTaiKhoan = new List<CTaiKhoan>();

        public List<CTaiKhoan> ListTaiKhoan { get => listTaiKhoan; set => listTaiKhoan = value; }

        public CQuanLyTaiKhoan()
        {
            listTaiKhoan.Add(new CTaiKhoan("admin", "admin", "admin"));
            listTaiKhoan.Add(new CTaiKhoan("user", "123456", "user"));
        }
    }
}
