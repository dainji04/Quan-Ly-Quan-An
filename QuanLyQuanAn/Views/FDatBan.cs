﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Components;
using QuanLyQuanAn.Views;

namespace QuanLyQuanAn.Views
{
    public partial class FDatBan : Form
    {
        private string maQuan;
        public string MaQuan { get => maQuan; set => maQuan = value; }

        public FDatBan()
        {
            InitializeComponent();
        }

        private void FDatBan_Load(object sender, EventArgs e)
        {
            lblMaQuan.Text = maQuan;
        }

        private void btnBan_DoubleClick(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = sender as Guna.UI2.WinForms.Guna2Button;
            FOrder fo = new FOrder();
            fo.CurrentBan = btn.Text;
            fo.ShowDialog();
        }
    }
}
