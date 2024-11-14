using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Class;
using QuanLyQuanAn.Controller;
using QuanLyQuanAn.Views;


namespace QuanLyQuanAn.Components
{
    public partial class FOrder : Form
    {
        XuLyMon XuLyMon = new XuLyMon();
        private string currentBan;
        public string CurrentBan { get => currentBan; set => currentBan = value; }
        public FOrder()
        {
            InitializeComponent();
        }

        private void FOrder_Load(object sender, EventArgs e)
        {
            lblBanSo.Text = CurrentBan;
            XuLyMon.docFile();
            int i = 0;
            foreach (CFood mon in XuLyMon.DsMon)
            {
                Panel pnl = new Panel();
                Label lblTen = new Label();
                Label lblGia = new Label();
                PictureBox pic = new PictureBox();
                Button btnThem = new Button();

                pic.Image = mon.Hinhanh;
                pic.Location = new Point(15, 15); // Margin top and left = 15px
                pic.Size = new Size(pnl.Width - 30, 160); // Width = panel width - left and right margins (15px each)
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                lblTen.Text = mon.Tenmon;
                lblTen.Location = new Point(70, 200); // Position the label inside the panel
                lblTen.ForeColor = Color.White;
                lblTen.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                lblTen.BackColor = Color.Transparent; // Make the label background transparent

                lblGia.Text = mon.Giatien.ToString() + "$";
                lblGia.Location = new Point(70, 230); // Position the label inside the panel
                lblGia.ForeColor = Color.White;
                lblGia.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                lblGia.BackColor = Color.Transparent; // Make the label background transparent

                btnThem.Text = "Thêm";
                btnThem.Location = new Point(50, 280);
                btnThem.Size = new Size(pnl.Width-100, 40);
                btnThem.BackColor = Color.White;
                //btnThem.Click += Btn_Click;
                btnThem.Click += (s, eArgs) =>
                {
                    if(XuLyMon.XulyThemMon(mon.Ma))
                    {
                        hienthi();
                    }
                    else
                    {
                        pnlOrder.Controls.Clear();
                        hienthi();
                    }
                };

                pnl.Text = mon.Tenmon;
                pnl.Size = new Size(200, 339);
                pnl.Location = new Point(10 + (i % 3) * (200 + 30), 10 + (i / 3) * (339 + 15));
                pnl.Paint += panel1_Paint;
                pnl.BackColor = Color.Black;

                pnl.Controls.Add(pic);
                pnl.Controls.Add(lblTen);
                pnl.Controls.Add(lblGia);
                pnl.Controls.Add(btnThem);
                pnlFood.Controls.Add(pnl);

                i++;
            }
        }
        public void hienthi()
        {
            int i = 0;
            double sum = 0;
            foreach(CFood odf in XuLyMon.DsOrder)
            {
                Panel pnlItem = new Panel();
                Label lblTen = new Label();
                Label lblGia = new Label();
                Label lblSoLuong = new Label();

                pnlItem.Size = new Size(370, 50);
                pnlItem.Location = new Point(10, 3 + i * (50+15));
                pnlItem.Paint += panel1_Paint;

                lblTen.Text = odf.Tenmon;
                lblTen.Location = new Point(10, 10);
                lblTen.ForeColor = Color.White;
                lblTen.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                lblTen.BackColor = Color.Transparent;

                lblGia.Text = (odf.Giatien*odf.soluong).ToString() + "$";
                lblGia.Location = new Point(300, 10);
                lblGia.ForeColor = Color.White;
                lblGia.Font = new Font("Times New Roman", 14, FontStyle.Bold);
                lblGia.BackColor = Color.Transparent;

                lblSoLuong.Text = odf.soluong.ToString();
                lblSoLuong.Location = new Point(250, 10);
                lblSoLuong.ForeColor = Color.White;
                lblSoLuong.Font = new Font("Times New Roman", 14, FontStyle.Bold);

                pnlItem.Controls.Add(lblTen);
                pnlItem.Controls.Add(lblGia);
                pnlItem.Controls.Add(lblSoLuong);
                pnlOrder.Controls.Add(pnlItem);

                sum += odf.Giatien * odf.soluong;
                i++;
            }
            lblThanhTien.Text = sum.ToString() + "$";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 30;
            Panel panel = sender as Panel;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            panel.Region = new Region(path);

            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FDatBan db = new FDatBan();
            db.Show();
            this.Hide();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            QuanAnUI quanAnUI = new QuanAnUI();
            quanAnUI.Show();
            this.Hide();
        }
    }
}
