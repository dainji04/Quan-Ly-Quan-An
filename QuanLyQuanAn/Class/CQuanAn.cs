﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.Class
{
    [Serializable]
    internal class CQuanAn
    {
        private string _maQuanAn;
        private string _tenQuanAn;
        private string _diaChi;
        private string _sdt;
        private string _email;
        private string _moTa;
        private DateTime _ngayDangKy;

        public string MaQuan 
        { get => _maQuanAn; set => _maQuanAn = value; }
        public string TenQuan 
        { get => _tenQuanAn; set => _tenQuanAn = value; }
        public string DiaChi 
        { get => _diaChi; set => _diaChi = value; }
        public string Sdt 
        { get => _sdt; set => _sdt = value; }
        public string Email 
        { get => _email; set => _email = value; }
        public string MoTa 
        { get => _moTa; set => _moTa = value; }
        public DateTime NgayDangKy 
        { get => _ngayDangKy; set => _ngayDangKy = value; }
        public CQuanAn()
        {
            _maQuanAn = "";
            _tenQuanAn = "";
            _diaChi = "";
            _sdt = "";
            _email = "";
            _moTa = "";
            _ngayDangKy = DateTime.Now;
        }
        public CQuanAn(string maQuan, string tenQuan, string diaChi, string sdt, string email, string moTa, DateTime ngayDangKy)
        {
            MaQuan = maQuan;
            TenQuan = tenQuan;
            DiaChi = diaChi;
            Sdt = sdt;
            Email = email;
            MoTa = moTa;
            NgayDangKy = ngayDangKy;
        }
    }
}
